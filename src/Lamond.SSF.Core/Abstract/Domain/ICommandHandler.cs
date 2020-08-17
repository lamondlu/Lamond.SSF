using System;

namespace Lamond.SSF.Core.Abstract.Domain
{
    public interface ICommandHandler<TCommand> : IDisposable where TCommand : ICommand
    {
        void Execute(TCommand command);
    }
}