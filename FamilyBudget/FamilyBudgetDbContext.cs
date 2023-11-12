using DataAccess.EntityConfigurations;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DataAccess;

public class FamilyBudgetDbContext : DbContext
{
    protected readonly IConfiguration Configuration;

    public FamilyBudgetDbContext(DbContextOptions<FamilyBudgetDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new ExpenseCategoryEntityTypeConfiguration());
        builder.ApplyConfiguration(new ExpenseEntityTypeConfiguration());
        builder.ApplyConfiguration(new IncomeEntityTypeConfiguration());
        builder.ApplyConfiguration(new IncomeCategoryEntityTypeConfiguration());
        builder.ApplyConfiguration(new SharedExpenseEntityTypeConfiguration());
        builder.ApplyConfiguration(new UserEntityTypeConfiguration());
    }

    public DbSet<Expense> Expenses { get; set; }
    public DbSet<ExpenseCategory> ExpenseCategories { get; set; }
    public DbSet<SharedExpense> SharedExpenses { get; set; }
    public DbSet<Income> Incomes { get; set; }
    public DbSet<IncomeCategory> IncomeCategories { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Configure the database connection
        optionsBuilder.UseSqlServer("Data Source=localhost; Initial Catalog=FamilyBudget; User Id=test; Password=test1");
    }
}