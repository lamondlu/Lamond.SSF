using Lamond.SSF.Core.Abstract.Domain;

namespace Lamond.SSF.Core.Concrete.Domain
{

    public  class CommandBus : ICommandBus
    {
        public static ICommandBus Default = new CommandBus();
    }
}