using Domain.Etities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations;

internal class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.HasKey(order => order.Id);

        builder.Property(order => order.Name)
            .HasColumnName("OrderName")
            .HasMaxLength(20)
            .IsRequired();

        builder.Property(order => order.TotalPrice)
            .HasColumnType("decimal(18,2)")
            .IsRequired();
    }
}
