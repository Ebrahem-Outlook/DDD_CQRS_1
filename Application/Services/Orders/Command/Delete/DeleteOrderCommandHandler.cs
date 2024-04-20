
using Domain.Interfaces;
using MediatR;

namespace Application.Services.Orders.Command.Delete;

public class DeleteOrderCommandHandler : IRequestHandler<DeleteOrderCommand, bool>
{
    private readonly IOrderRepository context;
    public DeleteOrderCommandHandler(IOrderRepository context)
    {
        this.context = context;
    }

    public async Task<bool> Handle(DeleteOrderCommand request, CancellationToken cancellationToken)
    {
        var IsDelete = await context.Delete(request.Id);
        return IsDelete;
    }
}
