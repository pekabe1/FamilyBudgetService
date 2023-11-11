using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class IncomeEntityTypeConfiguration : IEntityTypeConfiguration<Income>
    {
        public void Configure(EntityTypeBuilder<Income> builder)
        {
            throw new NotImplementedException();
        }
    }
}
