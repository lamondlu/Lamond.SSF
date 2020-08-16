namespace Lamond.SSF.Core.Abstract.Domain
{
    public interface ICommandBus
    {
        void Test();

         void Send<T>(T command) where T : ICommand;
    }
}