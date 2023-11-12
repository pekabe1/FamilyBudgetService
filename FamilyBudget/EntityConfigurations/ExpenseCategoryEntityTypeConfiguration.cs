using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations;

public class ExpenseCategoryEntityTypeConfiguration : IEntityTypeConfiguration<ExpenseCategory>
{
    public void Configure(EntityTypeBuilder<ExpenseCategory> builder)
    {
        builder.ToTable("ExpenseCategory");

        builder.HasKey(ec => ec.Id);

        builder.Property(ec => ec.Id)
          .UseHiLo("expense_category_hilo")
          .IsRequired();

        builder.Property(ec => ec.Name)
            .IsRequired();
    }
}
