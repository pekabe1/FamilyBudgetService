using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations;

public class IncomeCategoryEntityTypeConfiguration : IEntityTypeConfiguration<IncomeCategory>
{
    public void Configure(EntityTypeBuilder<IncomeCategory> builder)
    {
        builder.ToTable("IncomeCategory");

        builder.HasKey(ec => ec.Id);

        builder.Property(ec => ec.Id)
          .UseHiLo("income_category_hilo")
          .IsRequired();

        builder.Property(ec => ec.Name)
            .IsRequired();
    }
}
