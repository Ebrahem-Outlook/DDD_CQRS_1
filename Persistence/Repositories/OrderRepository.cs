using Domain.Etities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;

namespace Persistence.Repositories;

public class OrderRepository : IOrderRepository
{
    private readonly ApplicationDbContext context;

    public OrderRepository(ApplicationDbContext context)
    {
        this.context = context;
    }

    public async Task<bool> Create(Order order)
    {
        await context.AddAsync(order);
        await context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> Delete(Guid id)
    {
        var order = await context.Orders.FindAsync(id);
        if (order is not null)
        {
            context.Remove(order);
            await context.SaveChangesAsync();
            return true;
        }
        return false;
    }

    public async Task<List<Order>> GetAll()
    {
        var orders = await context.Orders.ToListAsync();
        if(orders is null)
        {
            throw new NullReferenceException();
        }
        return orders;
    }

    public async Task<Order> GetById(Guid id)
    {
        var user = await context.Orders.FindAsync(id);
        if(user is null)
        {
            throw new NullReferenceException();
        }
        return user;
    }
    
    public async Task<bool> Update(Order order)
    {
        var entity = await context.Orders.FindAsync(order.Id);
        if (entity is null)
        {
            throw new NullReferenceException();
        }

        try
        {
            entity.UpdateOrderItem(order.OrderItems);
            await context.SaveChangesAsync();
            return true;
        }
        catch (ArgumentNullException)
        {
            return false;
        }
    }
}
