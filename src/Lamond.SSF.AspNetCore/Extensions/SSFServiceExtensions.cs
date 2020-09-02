using Lamond.SSF.Core.Abstract.Domain;
using Lamond.SSF.Core.Concrete.Domain;
using Lamond.SSF.Core.Interceptors;
using Lamond.SSF.Core.Models;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Lamond.SSF.AspNetCore.Extensions
{
    public static class SSFServiceExtensions
    {
        public static void AddSSF(this IServiceCollection services)
        {
            services.AddScoped<ICommandBus, CommandBus>();
            services.AddScoped<LogInterceptor>();
        }

        public static void AddSSF(this IServiceCollection services, Action<SSFOption> configureAction)
        {

        }
    }
}
