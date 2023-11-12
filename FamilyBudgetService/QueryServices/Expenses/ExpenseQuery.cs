using MediatR;

namespace FamilyBudgetService.Api.QueryServices.Expenses
{
    public record ExpenseQuery() : CollectionQuery, IRequest<Result>
}
