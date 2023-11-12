using DataAccess.Models;
using FamilyBudgetService.Api.Contracts.v1.ExpenseCategory;

namespace FamilyBudgetService.Api.Mappers
{
    public static class ExpenseCategoryMapper
    {
        public static ExpenseCategoryResponse MapToResponse(this ExpenseCategory expenseCategory)
        {
            return new ExpenseCategoryResponse(expenseCategory.Id, expenseCategory.Name);
        }
    }
}
