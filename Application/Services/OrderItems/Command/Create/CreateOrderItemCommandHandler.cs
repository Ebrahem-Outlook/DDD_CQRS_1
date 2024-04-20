
using Domain.Etities;
using Domain.Interfaces;
using MediatR;

namespace Application.Services.OrderItems.Command.Create;

public class CreateOrderItemCommandHandler : IRequestHandler<CreateOrderItemCommand, bool>
{
    private readonly IOrderItemRepository context;
    public CreateOrderItemCommandHandler(IOrderItemRepository context)
    {
        this.context = context;
    }

    public async Task<bool> Handle(CreateOrderItemCommand request, CancellationToken cancellationToken)
    {
        var user = OrderItem.Create(request.Name, request.Description, request.Price, request.Quantity);
        var IsCreate = await context.Create(user);
        return IsCreate;
    }
}
