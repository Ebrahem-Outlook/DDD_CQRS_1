
using MediatR;

namespace Application.Services.OrderItems.Command.Update;

public class UpdateOrderItemCommand : IRequest<bool>
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public decimal Price { get; private set; }
    public int Quantity { get; private set; }

    public UpdateOrderItemCommand(Guid id, string name, string description, decimal price, int quantity)
    {
        Id = id;
        Name = name;
        Description = description;
        Price = price;
        Quantity = quantity;
    }
}
