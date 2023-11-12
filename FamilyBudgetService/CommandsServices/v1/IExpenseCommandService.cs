using DataAccess.Models;
using FamilyBudgetService.Api.Operations.Commands.Expenses.Create;

namespace FamilyBudgetService.Api.CommandsServices.v1
{
    public interface IExpenseCommandService
    {
        public Expense CreateExpenseAsnyc(CreateExpenseQuery createExpenseQuery);
        public Expense UpdateExpenseAsnyc();
        public void DeleteExpenseAsnyc();
    }
}
