using DataAccess;
using DataAccess.Models;
using Polly;
using System;

namespace FamilyBudgetService.Api.QueryServices.Expenses
{
    public class ExpenseQueryService
    {
        private readonly FamilyBudgetDbContext _dbContext;

        public ExpenseQueryService(FamilyBudgetDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Expense>> GetExpenses()
        {
            IQueryable<Expense> query = _dbContext.Expenses;


        }
    }
}
