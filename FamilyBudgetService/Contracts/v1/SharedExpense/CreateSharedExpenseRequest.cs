namespace FamilyBudgetService.Api.Contracts.v1.SharedExpense;

public record CreateSharedExpenseRequest(int UserId, int ExpenseId, decimal SharedAmount);

