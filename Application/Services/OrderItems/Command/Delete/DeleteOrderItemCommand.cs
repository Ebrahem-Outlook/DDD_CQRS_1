
using MediatR;

namespace Application.Services.OrderItems.Command.Delete;

public class DeleteOrderItemCommand : IRequest<bool>
{
    public Guid Id { get; private set; }

    public DeleteOrderItemCommand(Guid id) => Id = id;
}
