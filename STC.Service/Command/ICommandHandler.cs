namespace STC.Service.Command
{
    public interface ICommandHandler<in TCommand, out TResult>
        where TCommand : ICommand
    {
        TResult Handle(TCommand command);
    }
}
