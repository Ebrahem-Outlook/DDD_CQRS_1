
using MediatR;

namespace Application.Services.OrderItems.Command.Create;

public class CreateOrderItemCommand : IRequest<bool>
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    public decimal Price { get; private set; }
    public int Quantity { get; private set; }

    public CreateOrderItemCommand(string name, string description, decimal price, int quantity)
    {
        Name = name;
        Description = description;
        Price = price;
        Quantity = quantity;
    }
}
