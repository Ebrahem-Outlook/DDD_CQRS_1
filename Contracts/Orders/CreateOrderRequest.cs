
using Contracts.OrderItems;

namespace Contracts.Orders;

public class CreateOrderRequest
{
    public string Name { get; set; }
    public List<CreateOrderItemRequest> OrderItemRequest { get; set; } 
}
