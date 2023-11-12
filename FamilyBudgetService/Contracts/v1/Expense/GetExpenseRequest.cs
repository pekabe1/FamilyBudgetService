namespace FamilyBudgetService.Api.Contracts.v1.Expense;

public record GetExpenseRequest(int ExpenseId) : CollectionRequest;
