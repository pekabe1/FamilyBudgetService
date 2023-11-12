using FamilyBudgetService.Api.Contracts.v1.Expense;
using MediatR;

namespace FamilyBudgetService.Api.QueryServices.V1.Expenses
{
    public record ExpenseQuery : CollectionQuery, IRequest<Result<PaginatedList<ExpenseResponse>>>
    {
        public int? Id { get; set; }
        public string? Description { get; set; }
        public decimal? Amount { get; set; }
        public decimal? MinAmount { get; set; }
        public decimal? MaxAmount { get; set; }
        public DateTime? ExpenseDate { get; set; }
        public int? ExpenseCategoryId { get; set; }
        public int? UserId { get; set; }
    }
}
