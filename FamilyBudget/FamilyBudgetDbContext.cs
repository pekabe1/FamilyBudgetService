using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess;

public class FamilyBudgetDbContext : DbContext
{
    public DbSet<Expense> Expenses { get; set; }
    public DbSet<ExpenseCategory> ExpenseCategories { get; set; }
    public DbSet<Income> Incomes { get; set; }
    public DbSet<IncomeCategory> IncomeCategories { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<UserExpense> UserExpenses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Configure the database connection
        optionsBuilder.UseSqlServer("Server=.;Initial Catalog=Microsoft.eShopOnContainers.Services.CatalogDb;Integrated Security=true");
    }
}