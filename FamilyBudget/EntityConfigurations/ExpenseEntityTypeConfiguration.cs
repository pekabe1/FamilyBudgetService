using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations;

public class ExpenseEntityTypeConfiguration : IEntityTypeConfiguration<Expense>
{
    public void Configure(EntityTypeBuilder<Expense> builder)
    {
        builder.ToTable("Expense");

        builder.HasKey(e => e.Id);

        builder.Property(e => e.Id)
          .UseHiLo("expense_hilo")
          .IsRequired();

        builder.Property(e => e.Description)
            .IsRequired();

        builder.Property(e => e.Amount)
            .IsRequired();

        builder.Property(e => e.ExpenseDate)
            .IsRequired();

        builder
            .HasOne(e => e.User)
            .WithMany(u => u.UserExpenses)
            .HasForeignKey(e => e.UserId);

        builder
            .HasMany(e => e.SharedWith)
            .WithOne(se => se.Expense)
            .HasForeignKey(se => se.ExpenseId);

        builder
            .HasOne(e => e.ExpenseCategory)
            .WithMany()
            .HasForeignKey(e => e.ExpenseCategoryId);
    }
}
