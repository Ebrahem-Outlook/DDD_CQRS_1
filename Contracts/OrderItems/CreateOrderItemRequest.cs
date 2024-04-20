
namespace Contracts.OrderItems; 

public class CreateOrderItemRequest
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}
