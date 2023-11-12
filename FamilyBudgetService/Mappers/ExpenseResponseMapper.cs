using DataAccess.Models;
using FamilyBudgetService.Api.Contracts.v1.Expense;
using Microsoft.Identity.Client;

namespace FamilyBudgetService.Api.Mappers
{
    public static class ExpenseResponseMapper
    {
        public static ExpenseResponse MapToResponse(this Expense expense)
        {
            return new ExpenseResponse
            {
                Amount = expense.Amount,
                Description = expense.Description,
                ExpenseCategoryId = expense.ExpenseCategoryId,
                ExpenseCategoryResponse = expense.ExpenseCategory != null ? expense.ExpenseCategory.MapToResponse() : null,
                ExpenseDate = expense.ExpenseDate,
                UserId = expense.UserId,
                User = expense.User.MapToResponse(),
                Id = expense.Id,
            };
        }

        public static IEnumerable<ExpenseResponse> MapToResponse(this IEnumerable<Expense> expenses)
        {
            return expenses.Select(MapToResponse);
        }
    }
}
