using System;
using Lamond.SSF.Core.Abstract.Domain;
using Lamond.SSF.Sample.Commands;

namespace Lamond.SSF.Sample.CommandHandlers {
    public class TestCommandHandler : ICommandHandler<TestCommand> {
        public void Dispose()
        {
            
        }

        public void Execute (TestCommand command) {
            Console.WriteLine(command.TestString);

            command.ExecuteSuccess();
        }
    }
}