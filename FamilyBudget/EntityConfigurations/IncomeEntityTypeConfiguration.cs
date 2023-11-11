using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace DataAccess.EntityConfigurations;

public class IncomeEntityTypeConfiguration : IEntityTypeConfiguration<Income>
{
    public void Configure(EntityTypeBuilder<Income> builder)
    {
        builder.ToTable("Income");

        builder.HasKey(i => i.Id);

        builder.Property(e => e.Id)
            .UseHiLo("income_hilo")
            .IsRequired();

        builder.Property(i => i.Description)
            .IsRequired();

        builder.Property(i => i.Amount)
            .IsRequired();

        builder.Property(i => i.Date)
            .IsRequired();

        builder
            .HasOne(i => i.User)
            .WithMany(u => u.Incomes)
            .HasForeignKey(i => i.UserId);

        builder
           .HasOne(e => e.IncomeCategory)
           .WithMany()
           .HasForeignKey(e => e.IncomeCategoryId);
    }
}
