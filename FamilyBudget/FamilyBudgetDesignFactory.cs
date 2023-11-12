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
             .UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=FamilyBudget;Trusted_Connection=True;MultipleActiveResultSets=true");

            return new FamilyBudgetDbContext(optionsBuilder.Options);
        }
    }
}
