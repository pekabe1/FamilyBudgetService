namespace FamilyBudgetService.Api.Contracts.v1.Expense;

public record CreateExpenseRequest(int UserId, string Description, decimal Amount, DateTime ExpenseDate,int? ExpesneCategoryId);