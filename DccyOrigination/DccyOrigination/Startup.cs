using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using DccyOrigination.EF;
using DccyOrigination.InjectionService;
using DccyOrigination.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DccyOrigination
{
    public class Startup
    {
        public Startup (IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices (IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            ////？？？需要注入的服务在 InjectionService.AdmServiceRegister.Register方法内注入即可
            /// //services.AddScoped<IParaReferRepository（接口）, ParaReferRepository（实现类）>();

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            //数据库连接
            var conStr = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build()["ConnectionStrings:SqlServerConnectiion"];
            services.AddDbContext<DccyDbContext>(options => options.UseSqlServer(conStr), ServiceLifetime.Scoped);

            //注入配置类
            services.AddOptions();
            services.Configure<AppSetting>(Configuration.GetSection("AppSetting"));

            #region 批量注入
            //外部注入
            string strValue = Configuration.GetSection("Appsetings").GetSection("key").Value;
            foreach (var item in GetClassName(strValue))
            {
                foreach (var typeArray in item.Value)
                {
                    services.AddScoped(typeArray, item.Key);
                }
            }

            //内部注入
            IEnumerable<Type> serviceList = AppDomain.CurrentDomain.GetAssemblies()
             .SelectMany(m => m.GetTypes()).Select(m => m.GetTypeInfo())
             .Where(m => !m.IsAbstract
                                   && !m.IsInterface
                                   && typeof(IServiceRegister).GetTypeInfo().IsAssignableFrom(m));

            foreach (Type type in serviceList)
            {
                IServiceRegister register = Activator.CreateInstance(type, true) as IServiceRegister;
                register.Register(services);
            }
            #endregion

            services.AddDistributedMemoryCache();
            services.AddSession();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        //通过程序名称获取内部接口实现类
        private Dictionary<Type, Type[]> GetClassName (string assemblyName)
        {
            if (!String.IsNullOrEmpty(assemblyName))
            {
                Assembly assembly = Assembly.Load(assemblyName);
                List<Type> ts = assembly.GetTypes().ToList();

                var result = new Dictionary<Type, Type[]>();
                foreach (var item in ts.Where(s => !s.IsInterface && s.IsAbstract && typeof(IServiceRegister).GetTypeInfo().IsAssignableFrom(s)))
                {
                    var interfaceType = item.GetInterfaces();
                    if (item.IsGenericType) continue;
                    result.Add(item, interfaceType);
                }
                return result;
            }
            return new Dictionary<Type, Type[]>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure (IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseSession();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
