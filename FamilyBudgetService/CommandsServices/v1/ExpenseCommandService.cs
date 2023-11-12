using DataAccess;
using DataAccess.Models;
using FamilyBudgetService.Api.Operations.Commands.Expenses.Create;

namespace FamilyBudgetService.Api.CommandsServices.v1
{
    public class ExpenseCommandService : IExpenseCommandService
    {
        private readonly FamilyBudgetDbContext _dbContext;

        public ExpenseCommandService(FamilyBudgetDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Expense>  CreateExpenseAsnyc(CreateExpenseQuery createExpenseQuery, CancellationToken cancellationToken = default)
        {
            Expense expense = new Expense
            {
                Amount = createExpenseQuery.Amount,
                Description = createExpenseQuery.Description,
                ExpenseCategoryId = createExpenseQuery.ExpenseCategoryId,
                ExpenseDate = createExpenseQuery.ExpenseDate,
                UserId = createExpenseQuery.UserId,
            };

            _dbContext.Expenses.Add(expense);

            await _dbContext.SaveChangesAsync();
            return expense;
        }

        public void DeleteExpenseAsnyc()
        {
            throw new NotImplementedException();
        }

        Task<Expense> IExpenseCommandService.UpdateExpenseAsnyc()
        {
            throw new NotImplementedException();
        }
    }
}
