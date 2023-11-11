using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations;

public class SharedExpenseEntityTypeConfiguration : IEntityTypeConfiguration<SharedExpense>
{
    public void Configure(EntityTypeBuilder<SharedExpense> builder)
    {
        builder.ToTable("SharedExpense");

        builder.HasKey(ex => ex.Id);

        builder.Property(ci => ci.Id)
            .UseHiLo("shared_expense_hilo")
            .IsRequired();

        builder.HasOne(se => se.SharingUser)
            .WithMany(u => u.SharedExpenses)
            .HasForeignKey(se => se.SharingUserId);

        builder.HasOne(se => se.Expense)
            .WithMany(e => e.SharedWith)
            .HasForeignKey(se => se.ExpenseId);
    }
}
