using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations;
public class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(u => u.UserId);

        builder.Property(u => u.UserName)
            .IsRequired();

        builder
            .HasMany(u => u.UserExpenses)
            .WithOne(e => e.User)
            .HasForeignKey(e => e.UserId);

        builder
            .HasMany(u => u.Incomes)
            .WithOne(i => i.User)
            .HasForeignKey(i => i.UserId);

        builder
            .HasMany(u => u.SharedExpenses)
            .WithOne(se => se.SharingUser)
            .HasForeignKey(se => se.SharingUserId);
    }
}
