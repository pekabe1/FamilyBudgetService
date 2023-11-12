namespace FamilyBudgetService.Api.Contracts.v1.SharedExpense;

public record UpdateSharedExpenseRequest(int? SharedUserId, int? ExpenseId, decimal? SharedAmount);