using STC.Service;
using STC.Service.Command;

public interface ICommandHandler<in TCommand>
       where TCommand : ICommand
{
    Result Handle(TCommand command);
}