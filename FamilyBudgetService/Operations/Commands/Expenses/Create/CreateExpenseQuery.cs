using FamilyBudgetService.Api.Contracts.v1.Expense;
using FamilyBudgetService.Api.QueryServices;
using MediatR;

namespace FamilyBudgetService.Api.Operations.Commands.Expenses.Create;

public record CreateExpenseQuery : CollectionQuery, IRequest<Result<ExpenseResponse>>
{
    public string Description { get; set; }
    public decimal Amount { get; set; }
    public DateTime ExpenseDate { get; set; }
    public int? ExpenseCategoryId { get; set; }
    public int UserId { get; set; }
}
