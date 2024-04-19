using Domain.Etities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;

namespace Persistence.Repositories;

public class OrderItemRepository : IOrderItemRepository
{
    private readonly ApplicationDbContext context;

    public OrderItemRepository(ApplicationDbContext context)
    {
        this.context = context;
    }

    public async Task<bool> Create(OrderItem orderItem)
    {
        await context.AddAsync(orderItem);
        await context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> Delete(Guid id)
    {
        var orderItems = await context.OrderItems.FindAsync(id);
        if (orderItems is not null)
        {
            context.Remove(orderItems);
            await context.SaveChangesAsync();
            return true;
        }
        return false;
    }

    public async Task<List<OrderItem>> GetAll()
    {
        var orderItems = await context.OrderItems.ToListAsync();
        if (orderItems is null)
        {
            throw new NullReferenceException();
        }
        return orderItems;
    }

    public async Task<OrderItem> GetById(Guid id)
    {
        var orderItem = await context.OrderItems.FindAsync(id);
        if (orderItem is null)
        {
            throw new NullReferenceException();
        }
        return orderItem;
    }

    public async Task<bool> Update(OrderItem orderItem)
    {
        var entity = await context.OrderItems.FindAsync(orderItem.Id);
        if (entity is null)
        {
            throw new NullReferenceException();
        }

        try
        {
            entity.UpdateName(orderItem.Name);
            entity.UpdateDescription(orderItem.Description);
            entity.UpdatePrice(orderItem.Price);
            await context.SaveChangesAsync();
            return true;
        }
        catch (ArgumentNullException)
        {
            return false;
        }
    }
}
