using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityConfigurations
{
    public class ExpenseTypeEntityTypeConfiguration : IEntityTypeConfiguration<Income>
    {
        public void Configure(EntityTypeBuilder<Income> builder)
        {
            throw new NotImplementedException();
        }
    }
}
