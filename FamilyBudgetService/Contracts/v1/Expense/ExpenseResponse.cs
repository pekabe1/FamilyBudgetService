using Microsoft.EntityFrameworkCore;

namespace FamilyBudgetService.Api.Contracts.v1.Expense
{
    public record ExpenseResponse
    {
        public int Id { get; init; }
        public string Description { get; init; }
        public decimal Amount { get; init; }
        public DateTime ExpenseDate { get; init; }
        public int? ExpenseCategoryId { get; init; }
        public int UserId { get; init; }
    }
}
