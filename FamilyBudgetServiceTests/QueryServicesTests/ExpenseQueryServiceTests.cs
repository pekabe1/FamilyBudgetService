using DataAccess.Models;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Moq;
using FamilyBudgetService.Api.QueryServices.v1.Expenses;

namespace DataAccessTests.QueryServicesTests;


public class ExpenseQueryServiceTests
{
    [Test]
    public async Task GetExpenses_Should_Return_PartialResult()
    {
        // Arrange
        var expenseQuery = new CreateExpensesQuery
        {
            Page = 1,
            PageSize = 10,
            FetchFullData = false,
        };
        var myDatabaseName = "mydatabase_" + DateTime.Now.ToFileTimeUtc();
        var options = new DbContextOptionsBuilder<FamilyBudgetDbContext>()
            .UseInMemoryDatabase(databaseName: myDatabaseName)
            .Options;

        var dbContextMock = new Mock<FamilyBudgetDbContext>(options);
        var expenseQueryService = new ExpenseQueryService(dbContextMock.Object);

        // Insert seed data into the database using one instance of the context
        using (var context = new FamilyBudgetDbContext(options))
        {
            context.Expenses.Add(new Expense { Id = 1, ExpenseCategoryId = 1,Amount = 50m, Description = "t1", UserId = 1 });
            context.Expenses.Add(new Expense { Id = 2, ExpenseCategoryId = 1, Amount = 50m, Description = "t1", UserId = 1 });
            context.SaveChanges();
        }

        // Act
        var result = await expenseQueryService.GetExpensesAsync(expenseQuery);

        // Assert
        Assert.NotNull(result);
        Assert.That(result.TotalCount, Is.EqualTo(2));
        Assert.That(result.PageSize, Is.EqualTo(expenseQuery.PageSize));
        Assert.That(result.Page, Is.EqualTo(expenseQuery.Page));
        // Add more assertions based on your expectations for the query result
    }
}