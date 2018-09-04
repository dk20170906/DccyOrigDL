using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DccyOrigination.InjectionService
{
    public interface IServiceRegister
    {
        /// <summary>
        /// 注册
        /// </summary>
        void Register(IServiceCollection services);
    }
}
