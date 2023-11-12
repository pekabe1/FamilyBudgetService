using DataAccess;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace FamilyBudgetService.Api.QueryServices.V1.Expenses
{
    public class ExpenseQueryService
    {
        private readonly FamilyBudgetDbContext _dbContext;

        public ExpenseQueryService(FamilyBudgetDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Expense>> GetExpenses(ExpenseQuery expenseQuery)
        {
            IQueryable<Expense> query = _dbContext.Expenses;

            if (expenseQuery.Id != null)
            {
                query = query.Where(p => p.Id == expenseQuery.Id);
            }
            if (string.IsNullOrEmpty(expenseQuery.Description))
            {
                query = query.Where(p => p.Description == expenseQuery.Description);
            }
            if (expenseQuery.UserId != null)
            {
                query = query.Where(p => p.UserId == expenseQuery.UserId);
            }
            if (expenseQuery.ExpenseDate != null)
            {
                query = query.Where(p => p.ExpenseDate == expenseQuery.ExpenseDate);
            }
            if (expenseQuery.Amount != null)
            {
                query = query.Where(p => p.Amount == expenseQuery.Amount);
            }
            if (expenseQuery.MaxAmount != null)
            {
                query = query.Where(p => p.Amount <= expenseQuery.MaxAmount);
            }
            if (expenseQuery.MinAmount != null)
            {
                query = query.Where(p => p.Amount >= expenseQuery.MinAmount);
            }

            return await query.ToListAsync();
        }
    }
}
