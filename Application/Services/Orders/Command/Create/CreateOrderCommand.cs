using Contracts.OrderItems;
using Domain.Etities;
using MediatR;

namespace Application.Services.Orders.Command.Create;

public class CreateOrderCommand : IRequest<bool>
{
    public string Name { get; private set; }
    public List<OrderItem> OrderItems { get; private set; }

    public CreateOrderCommand(string name, List<OrderItem> orderItems)
    {
        Name = name;
        OrderItems = orderItems;
    }
}
