using DataAccess.Models;
using FamilyBudgetService.Api.Operations.Queries.Expenses;

namespace FamilyBudgetService.Api.QueryServices.v1.Expenses
{
    public interface IExpenseQueryService
    {
        Task<PartialResult<Expense>> GetExpensesAsync(CreateExpensesQuery expenseQuery, CancellationToken cancellationToken = default);
    }
}
