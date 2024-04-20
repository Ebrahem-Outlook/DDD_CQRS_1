
namespace Contracts.Orders;

public class UpdateOrderRequest
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public List<UpdateOrderRequest> OrderItemRequest { get; set; }
}
