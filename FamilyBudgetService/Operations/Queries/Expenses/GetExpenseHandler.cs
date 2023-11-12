using FamilyBudgetService.Api.Contracts.v1.Expense;
using FamilyBudgetService.Api.Mappers;
using FamilyBudgetService.Api.QueryServices.V1.Expenses;
using MediatR;

namespace FamilyBudgetService.Api.Operations.Queries.Expenses
{
    public class GetExpenseHandler : IRequestHandler<GetExpensesQuery, Result<PaginatedList<ExpenseResponse>>>
    {
        private readonly IExpenseQueryService _expenseQueryService;
        
        public GetExpenseHandler(IExpenseQueryService expenseQueryService)
        {
            _expenseQueryService = expenseQueryService;
        }

        public async Task<Result<PaginatedList<ExpenseResponse>>> Handle(GetExpensesQuery request, CancellationToken cancellationToken)
        {
            var expenses = await _expenseQueryService.GetExpenses(request, cancellationToken);

            return new PaginatedList<ExpenseResponse>(
                 expenses.MapToResponse(),
                 expenses.Page,
                 expenses.PageSize,
                 expenses.TotalCount);
        }
    }
}
