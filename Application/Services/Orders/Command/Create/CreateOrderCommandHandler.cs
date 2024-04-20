using Domain.Etities;
using Domain.Interfaces;
using MediatR;

namespace Application.Services.Orders.Command.Create;

public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, bool>
{
    private readonly IOrderRepository context;
    public CreateOrderCommandHandler(IOrderRepository context)
    {
        this.context = context;
    }

    public async Task<bool> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
    {
        try
        {

            var user = Order.Create(request.Name, request.OrderItems);
            var IsCreate = await context.Create(user);
            return IsCreate;
        }
        catch (Exception)
        {
            return false;
        }
    }
}
