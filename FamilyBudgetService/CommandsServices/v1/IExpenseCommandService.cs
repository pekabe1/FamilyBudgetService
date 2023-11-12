using DataAccess.Models;
using FamilyBudgetService.Api.Operations.Commands.Expenses.Create;

namespace FamilyBudgetService.Api.CommandsServices.v1
{
    public interface IExpenseCommandService
    {
        public Task<Expense> CreateExpenseAsnyc(CreateExpenseQuery createExpenseQuery, CancellationToken cancellationToken = default);
        public Task<Expense> UpdateExpenseAsnyc();
        public void DeleteExpenseAsnyc();
    }
}
