using System.Xml.Linq;

namespace Domain.Etities;
public class OrderItem : IEquatable<OrderItem?>
{
    public Guid Id { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public string Description { get; private set; } = string.Empty;
    public decimal Price { get; private set; }

    private OrderItem() { }

    private OrderItem(string name, string description, decimal price)
    {
        Id = Guid.NewGuid();
        Name = name;
        Description = description;
        Price = price;
    }

    public OrderItem Create(string name, string description, decimal price)
    {
        var orderItem = new OrderItem(name, description, price);
        if(orderItem is OrderItem)
        {
            return orderItem;
        }
        throw new NullReferenceException();
    }

    public void UpdateName(string name)
    {
        if(name is null)
        {
            throw new ArgumentNullException();
        }
        Name = name;
    }

    public void UpdateDescription(string description)
    {
        if (description is null)
        {
            throw new ArgumentNullException();
        }
        Description = description;
    }

    public void UpdatePrice(decimal price) => Price = price;

    public override bool Equals(object? obj)
    {
        return Equals(obj as OrderItem);
    }

    public bool Equals(OrderItem? other)
    {
        return other is not null &&
               Id.Equals(other.Id) &&
               Name == other.Name &&
               Description == other.Description &&
               Price == other.Price;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id, Name, Description, Price);
    }

    public static bool operator ==(OrderItem? left, OrderItem? right)
    {
        return EqualityComparer<OrderItem>.Default.Equals(left, right);
    }

    public static bool operator !=(OrderItem? left, OrderItem? right)
    {
        return !(left == right);
    }
}
