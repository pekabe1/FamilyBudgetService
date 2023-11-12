using DataAccess.Models;
using FamilyBudgetService.Api.Operations.Queries.Expenses;

namespace FamilyBudgetService.Api.QueryServices.V1.Expenses
{
    public interface IExpenseQueryService
    {
        Task<PartialResult<Expense>> GetExpenses(GetExpensesQuery expenseQuery, CancellationToken cancellationToken = default);
    }
}
