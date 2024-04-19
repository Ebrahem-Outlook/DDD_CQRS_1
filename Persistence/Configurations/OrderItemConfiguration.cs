using Domain.Etities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations;

internal class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
{
    public void Configure(EntityTypeBuilder<OrderItem> builder)
    {
        builder.HasKey(orderItem => orderItem.Id);

        builder.Property(order => order.Name)
            .HasColumnName("OrderItemName")
            .HasMaxLength(20)
            .IsRequired();

        builder.Property(order => order.Description)
            .HasColumnName("Description")
            .HasMaxLength(20)
            .IsRequired();

        builder.Property(order => order.Price)
            .HasColumnType("decimal(18,2)")
            .IsRequired();
    }
}
