using Domain.Etities;

namespace Domain.Interfaces;

public interface IOrderItemRepository
{
    // Commands
    Task<bool> Create(OrderItem orderItem);
    Task<bool> Update(OrderItem orderItem);
    Task<bool> Delete(Guid id);

    // Queries
    Task<List<OrderItem>> GetAll();
    Task<OrderItem> GetById(Guid id);

}
