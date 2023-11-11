using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class FamilyBudgetDbContext : DbContext
    {
        public CatalogContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CatalogContext>()
                .UseSqlServer("Server=.;Initial Catalog=Microsoft.eShopOnContainers.Services.CatalogDb;Integrated Security=true");

            return new CatalogContext(optionsBuilder.Options);
        }
    }
}
