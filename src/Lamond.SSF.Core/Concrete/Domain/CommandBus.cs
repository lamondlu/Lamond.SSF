using Lamond.SSF.Core.Abstract;
using Lamond.SSF.Core.Abstract.Domain;
using Lamond.SSF.Core.Attributes;
using Lamond.SSF.Core.Models;
using System;

namespace Lamond.SSF.Core.Concrete.Domain
{
    public class CommandBus : ICommandBus
    {
        private readonly IDomainLogger domainLogger = null;

        public CommandBus(IDomainLogger domainLogger)
        {
            this.domainLogger = domainLogger;
        }
      
        public void Send<T>(T command) where T : ICommand
        {
            try
            {
                command.ExecuteSuccess();
            }
            catch (Exception ex)
            {
                domainLogger.WriteUnhandledErrorLog(ex.ToString());
            }
        }

        public void Test()
        {
            Console.WriteLine("Command Bus is running");
        }
    }
}