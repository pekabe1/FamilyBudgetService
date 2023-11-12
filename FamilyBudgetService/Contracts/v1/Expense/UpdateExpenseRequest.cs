namespace FamilyBudgetService.Api.Contracts.v1.Expense;

public record UpdateExpenseRequest(int? UserId, string? Description, decimal? Amount, DateTime? ExpenseDate, int? ExpesneCategory);