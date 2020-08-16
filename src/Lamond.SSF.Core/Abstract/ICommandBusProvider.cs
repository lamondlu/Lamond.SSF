using Lamond.SSF.Core.Abstract.Domain;

namespace Lamond.SSF.Core.Abstract
{
    public interface ICommandBusProvider
    {
        ICommandBus GetInstance();
    }
}