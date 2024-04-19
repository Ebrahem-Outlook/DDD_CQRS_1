using Domain.Etities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations;

internal class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(user => user.Id);

        builder.Property(order => order.Name)
            .HasColumnName("UserName")
            .HasMaxLength(20)
            .IsUnicode(true)
            .IsRequired();

        builder.Property(order => order.Email)
            .HasColumnName("UserEmail")
            .HasMaxLength(20)
            .IsUnicode(true)
            .IsRequired();

        builder.Property(order => order.Password)
            .HasColumnName("UserPassword")
            .HasMaxLength(20)
            .IsRequired();

    }
}
