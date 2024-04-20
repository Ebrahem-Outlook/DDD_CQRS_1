
using Contracts.Orders;

using MediatR;

namespace Application.Services.Orders.Command.Update;

public class UpdateOrderCommand : IRequest<bool>
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public List<UpdateOrderRequest> OrderItems { get; private set; }

    public UpdateOrderCommand(Guid id, string name, List<UpdateOrderRequest> orderItems)
    {
        Id = id;
        Name = name;
        OrderItems = orderItems;
    }
}


 