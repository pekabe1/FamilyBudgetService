using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace DataAccess
{
    public class FamilyBudgetDesignFactory : IDesignTimeDbContextFactory<FamilyBudgetDbContext>
    {
        protected readonly IConfiguration Configuration;

        public FamilyBudgetDesignFactory()
        {
        }
        public FamilyBudgetDesignFactory(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public FamilyBudgetDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<FamilyBudgetDbContext>()
             .UseSqlServer("Data Source=localhost; Initial Catalog=FamilyBudget; User Id=test; Password=test1");

            return new FamilyBudgetDbContext(optionsBuilder.Options);
        }
    }
}
