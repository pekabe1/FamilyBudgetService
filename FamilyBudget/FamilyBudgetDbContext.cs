using Microsoft.EntityFrameworkCore;
namespace DataAccess;

public class FamilyBudgetDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Configure the database connection
        optionsBuilder.UseSqlServer("your_connection_string_here");
    }
}