using FamilyBudgetService.Api.Contracts.v1.Expense;
using FamilyBudgetService.Api.Mappers;

using MediatR;

namespace FamilyBudgetService.Api.Operations.Commands.Expenses.Create;

public class CreateExpenseHandler : IRequestHandler<CreateExpenseQuery, Result<PaginatedList<ExpenseResponse>>>
{


    public CreateExpenseHandler(Icomm expenseQueryService)
    {
        _expenseQueryService = expenseQueryService;
    }

    public async Task<Result<PaginatedList<ExpenseResponse>>> Handle(CreateExpenseQuery request, CancellationToken cancellationToken)
    {
        var expenses = await _expenseQueryService.GetExpenses(request, cancellationToken);

        return new PaginatedList<ExpenseResponse>(
             expenses.MapToResponse(),
             expenses.Page,
             expenses.PageSize,
             expenses.TotalCount);
    }
}
