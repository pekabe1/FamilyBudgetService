namespace FamilyBudgetService.Api.Contracts.v1.Expense;

public record ExpenseFilteringRequest : CollectionRequest
{
    public string? Description { get; init; }
    public decimal? Amount { get; init; }
    public decimal? MinAmount { get; init; }
    public decimal? MaxAmount { get; init; }
    public DateTime? ExpenseDate { get; init; }
    public int? UserId { get; init; }
    public int? ExpenseId { get; init; }
    public int? ExpenseCategoryId { get; init; }
}