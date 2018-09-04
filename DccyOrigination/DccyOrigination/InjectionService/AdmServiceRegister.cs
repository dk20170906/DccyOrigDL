

using DccyOrigination.Common.IRepository;
using DccyOrigination.Common.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DccyOrigination.InjectionService
{
    /// <summary>
    /// 主服务注入
    /// </summary>
    public class AdmServiceRegister : IServiceRegister
    {         

        public void Register(IServiceCollection services)
        {

            #region 批量注入程序集


            #endregion


            //    //services. Singleton 不关闭连接一直存在，单例，一般数据库连接可使用
            //    // 需要加入容器的类可在此处注入服务

            services.AddTransient<IToolUnit, ToolUnit>();        //工具类

            //用完立即消费
            services.AddTransient<IEncryptionAndDecryption, EncryptionAndDecryption>();        //加解密

        }
    }
}
