using MediatR;

namespace Application.Services.Orders.Command.Delete;

public class DeleteOrderCommand : IRequest<bool>
{
    public Guid Id { get; private set; }

    public DeleteOrderCommand(Guid id) => Id = id;
}
