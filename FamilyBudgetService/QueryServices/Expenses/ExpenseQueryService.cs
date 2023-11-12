using DataAccess;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Polly;
using System;
using System.Diagnostics.Metrics;

namespace FamilyBudgetService.Api.QueryServices.Expenses
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

           return await query.ToListAsync();
        }
    }
}
