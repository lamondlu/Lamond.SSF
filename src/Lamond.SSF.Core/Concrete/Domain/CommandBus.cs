using Lamond.SSF.Core.Abstract;
using Lamond.SSF.Core.Abstract.Domain;
using Lamond.SSF.Core.Models;
using System;

namespace Lamond.SSF.Core.Concrete.Domain
{
    public class CommandBus : ICommandBus
    {
        private readonly SSFOption ssfOption = null;
        private readonly IDomainLogger domainLogger = null;

        public CommandBus(SSFOption ssfOption, IDomainLogger domainLogger)
        {
            this.ssfOption = ssfOption;
            this.domainLogger = domainLogger;
        }

        public void Send<T>(T command) where T : ICommand
        {
            if (ssfOption.EnableDomainLog && command != null)
            {
                domainLogger.WriteBusinessLog("Initializing Request", $"{command.Operator} is trying to run this action.");
            }

            try
            {

            }
            catch (Exception ex)
            {
                domainLogger.WriteUnhandledErrorLog(ex.ToString());
            }

            domainLogger.WriteBusinessLog("Request end", "Request End.");
        }

        public void Test()
        {
            Console.WriteLine("Command Bus is running");
        }
    }
}