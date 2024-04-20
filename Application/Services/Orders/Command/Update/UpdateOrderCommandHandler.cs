using Domain.Interfaces;
using MediatR;

namespace Application.Services.Orders.Command.Update;

public class UpdateOrderCommandHandler : IRequestHandler<UpdateOrderCommand, bool>
{
    private readonly IOrderRepository context;
    public UpdateOrderCommandHandler(IOrderRepository context)
    {
        this.context = context;
    }

    public async Task<bool> Handle(UpdateOrderCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var order = await context.GetById(request.Id);
            if (order == null)
            {
                throw new NullReferenceException();
            }
            order.UpdateName(request.Name);
            // order.UpdateOrderItem(request.OrderItems);

            var IsUpdate = await context.Update(order);
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
}


