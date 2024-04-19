
using Domain.Etities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Data;

internal interface IApplicationDbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }
}
