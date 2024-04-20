
using Domain.Interfaces;
using MediatR;

namespace Application.Services.OrderItems.Command.Update;

public class UpdateOrderItemCommandHandler : IRequestHandler<UpdateOrderItemCommand, bool>
{
    private readonly IOrderItemRepository context;
    public UpdateOrderItemCommandHandler(IOrderItemRepository context)
    {
        this.context = context;
    }

    public async Task<bool> Handle(UpdateOrderItemCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var orderItem = await context.GetById(request.Id);
            if (orderItem == null)
            {
                throw new NullReferenceException();
            }
            orderItem.UpdateName(request.Name);
            orderItem.UpdateQuantity(request.Quantity);
            orderItem.UpdatePrice(request.Price);
            orderItem.UpdateQuantity(request.Quantity);

            var IsUpdate = await context.Update(orderItem);
            return IsUpdate;
        }
        catch (Exception)
        {
            return false;
        }
    }
}


