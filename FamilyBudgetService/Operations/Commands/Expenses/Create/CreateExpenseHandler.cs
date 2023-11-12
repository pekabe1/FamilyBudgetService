using DataAccess.Models;
using FamilyBudgetService.Api.CommandsServices.v1;
using FamilyBudgetService.Api.Contracts.v1.Expense;
using FamilyBudgetService.Api.Mappers;

using MediatR;

namespace FamilyBudgetService.Api.Operations.Commands.Expenses.Create;

public class CreateExpenseHandler : IRequestHandler<CreateExpenseQuery, Result<ExpenseResponse>>
{
    private readonly IExpenseCommandService _expenseCommandService;

    public CreateExpenseHandler(IExpenseCommandService expenseCommandService)
    {
        _expenseCommandService = expenseCommandService;
    }


    public async Task<Result<ExpenseResponse>> Handle(CreateExpenseQuery request, CancellationToken cancellationToken)
    {
        var expense = await _expenseCommandService.CreateExpenseAsnyc(request, cancellationToken);

        return expense.MapToResponse();
    }
}

