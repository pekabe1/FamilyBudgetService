using FamilyBudgetService.Api.Contracts.v1.Expense;
using FamilyBudgetService.Api.Mappers;
using FamilyBudgetService.Api.QueryServices.v1.Expenses;
using MediatR;

namespace FamilyBudgetService.Api.Operations.Queries.Expenses
{
    public class CreateExpenseHandler : IRequestHandler<CreateExpensesQuery, Result<PaginatedList<ExpenseResponse>>>
    {
        private readonly IExpenseQueryService _expenseQueryService;

        public CreateExpenseHandler(IExpenseQueryService expenseQueryService)
        {
            _expenseQueryService = expenseQueryService;
        }

        public async Task<Result<PaginatedList<ExpenseResponse>>> Handle(CreateExpensesQuery request, CancellationToken cancellationToken)
        {
            var expenses = await _expenseQueryService.GetExpensesAsync(request, cancellationToken);

            return new PaginatedList<ExpenseResponse>(
                 expenses.MapToResponse(),
                 expenses.Page,
                 expenses.PageSize,
                 expenses.TotalCount);
        }
    }
}
