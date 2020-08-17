using Lamond.SSF.Core.Abstract.Domain;
using Lamond.SSF.Core.Concrete.Domain;
using Lamond.SSF.Core.Models;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Lamond.SSF.AspNetCore
{
    public static class SSFServiceExtensions
    {
        public static void AddSSF(this IServiceCollection services)
        {
            services.AddScoped<ICommandBus, CommandBus>();
        }

        public static void AddSSF(this IServiceCollection services, Action<SSFOption> configureAction)
        {

        }
    }
}
