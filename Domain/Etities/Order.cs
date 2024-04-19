namespace Domain.Etities;
public class Order : IEquatable<Order?>
{
    public Guid Id { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public decimal TotalPrice { get; private set; }
    public List<OrderItem> OrderItems { get; private set; } = new List<OrderItem>();

    public Order() { }

    public Order(string name, decimal totalPrice, List<OrderItem> orderItems)
    {
        Id = Guid.NewGuid();
        Name = name;
        TotalPrice = totalPrice;
        OrderItems = orderItems;
    }

    public void UpdateOrderItem(List<OrderItem> orderItems)
    {
        if(orderItems is null)
        {
            throw new ArgumentNullException();
        }
        OrderItems = orderItems;
    }

    public override bool Equals(object? obj)
    {
        return Equals(obj as Order);
    }

    public bool Equals(Order? other)
    {
        return other is not null &&
               Id.Equals(other.Id) &&
               Name == other.Name &&
               TotalPrice == other.TotalPrice &&
               EqualityComparer<List<OrderItem>>.Default.Equals(OrderItems, other.OrderItems);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id, Name, TotalPrice, OrderItems);
    }

    public static bool operator ==(Order? left, Order? right)
    {
        return EqualityComparer<Order>.Default.Equals(left, right);
    }

    public static bool operator !=(Order? left, Order? right)
    {
        return !(left == right);
    }
}
