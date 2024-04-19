using Domain.Etities;

namespace Domain.Interfaces;

public interface IOrderRepository
{
    // Commands
    Task<bool> Create(Order order);
    Task<bool> Update(Order order);
    Task<bool> Delete(Guid id);

    // Queries
    Task<List<Order>> GetAll();
    Task<Order> GetById(Guid id);
}
