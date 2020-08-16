using Lamond.SSF.Core.Abstract;
using Lamond.SSF.Core.Abstract.Domain;
using Lamond.SSF.Core.Concrete.Domain;

namespace Lamond.SSF.Core.Concrete
{
    public class DefaultCommandBusProvider: ICommandBusProvider
    {
        public ICommandBus GetInstance()
        {
            return CommandBus.Default;
        }
    }
}