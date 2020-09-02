using Castle.Core.Logging;
using Castle.DynamicProxy;
using Lamond.SSF.Core.Abstract;
using Lamond.SSF.Core.Attributes;
using Lamond.SSF.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lamond.SSF.Core.Interceptors
{
    public class LogInterceptor : IInterceptor
    {
        private IDomainLogger _logger;

        public LogInterceptor(IDomainLogger logger)
        {
            _logger = logger;
        }

        public void Intercept(IInvocation invocation)
        {
            try
            {
                var attrs = invocation.Method.GetCustomAttributes(typeof(LogAttribute), false);

                if (attrs != null && attrs.Count() > 0)
                {
                    var attr = (LogAttribute)attrs[0];
                    var command = (CommonCommand)invocation.Arguments[0];

                    _logger.WriteBusinessLog("Initializing Request", $"{command.Operator} is trying to run this action.");
                    invocation.Proceed();
                    _logger.WriteBusinessLog("Request end", "Request End.");
                }
                else
                {
                    invocation.Proceed();
                }
            }
            catch
            {

            }
        }
    }
}
