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

        SeedExpenseCategories(builder);
        SeedUsers(builder);
        SeedExpenses(builder);
        SeedSharedExpenses(builder);
        SeedIncomes(builder);
        SeedIncomeCategories(builder);

    }

    public DbSet<Expense> Expenses { get; set; }
    public DbSet<ExpenseCategory> ExpenseCategories { get; set; }
    public DbSet<SharedExpense> SharedExpenses { get; set; }
    public DbSet<Income> Incomes { get; set; }
    public DbSet<IncomeCategory> IncomeCategories { get; set; }
    public DbSet<User> Users { get; set; }

    private void SeedExpenseCategories(ModelBuilder builder)
    {
        builder.Entity<ExpenseCategory>().HasData(
            new ExpenseCategory { Id = 1, Name = "Food" },
            new ExpenseCategory { Id = 2, Name = "Fuel" }
        );
    }

    private void SeedUsers(ModelBuilder builder)
    {
        builder.Entity<User>().HasData(
            new User { UserId = 1, UserName = "Adam990" },
            new User { UserId = 2, UserName = "Janusz889" }
        );
    }

    private void SeedExpenses(ModelBuilder builder)
    {
        builder.Entity<Expense>().HasData(
            new Expense { Id = 1, Description = "Grocery shopping", Amount = 50.0m, ExpenseDate = DateTime.Now, UserId = 1, ExpenseCategoryId = 1 },
            new Expense { Id = 2, Description = "Fuel", Amount = 30.0m, ExpenseDate = DateTime.Now, UserId = 2, ExpenseCategoryId = 2 },
            new Expense { Id = 3, Description = "Fuel", Amount = 30.0m, ExpenseDate = DateTime.Now, UserId = 1, ExpenseCategoryId = 2 }
            // Add more expenses as needed
        );
    }

    private void SeedSharedExpenses(ModelBuilder builder)
    {
        builder.Entity<SharedExpense>().HasData(
            new SharedExpense {Id =1, ExpenseId = 1, SharingUserId = 2 }
            // Add more shared expenses as needed
        );
    }

    private void SeedIncomes(ModelBuilder builder)
    {
        builder.Entity<Income>().HasData(
            new Income { Id = 1, Description = "Salary", Amount = 5000.0m, Date = DateTime.Now, UserId = 1, IncomeCategoryId = 1 }
            // Add more incomes as needed
        );
    }

    private void SeedIncomeCategories(ModelBuilder builder)
    {
        builder.Entity<IncomeCategory>().HasData(
            new IncomeCategory { Id = 1, CategoryName = "Salary" }
            // Add more income categories as needed
        );
    }
}

