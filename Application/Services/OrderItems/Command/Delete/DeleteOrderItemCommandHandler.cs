
using Domain.Interfaces;
using MediatR;

namespace Application.Services.OrderItems.Command.Delete;

public class DeleteOrderItemCommandHandler : IRequestHandler<DeleteOrderItemCommand, bool>
{
    private readonly IOrderItemRepository context;
    public DeleteOrderItemCommandHandler(IOrderItemRepository context)
    {
        this.context = context;
    }

    public async Task<bool> Handle(DeleteOrderItemCommand request, CancellationToken cancellationToken)
    {
        var IsDelete = await context.Delete(request.Id);
        return IsDelete;
    }
}