using System;
using Microsoft.Extensions.DependencyInjection;
using Lamond.SSF.Core.Models;

namespace Lamond.SSF.AspNetCore
{
    public static class SSFServiceExtensions
    {
        public static void AddSSF(this IServiceCollection services)
        {
            
        }

        public static void AddSSF(this IServiceCollection services, Action<SSFOption> configureAction)
        {

        }
    }
}
