using FamilyBudgetService.Api.Contracts;
using FamilyBudgetService.Api.Contracts.v1.Expense;
using FamilyBudgetService.Api.Filters;
using FamilyBudgetService.Api.Operations.Queries.Expenses;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace FamilyBudgetService.Api.Controllers.v1
{
    [ApiController]
    [Route("api/v1")]
    [ApiVersionInResponseHeader("v1")]
    public class ExpenseController : FamilyBudgetControllerBase
    {
        private readonly IMediator _mediator;

        public ExpenseController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("expenses")]
        [ProducesResponseType(typeof(FamilyBudgetServiceCollectionResponse<ExpenseResponse>), StatusCodes.Status200OK)]
        [Produces(MediaTypeNames.Application.Json)]
        public async Task<IActionResult> GetExpensesAsync([FromQuery] ExpenseFilteringRequest request)
        {
            var query = new CreateExpensesQuery
            {
                Id = request.ExpenseId
            };

            var result = await _mediator.Send(query);
            return result.Match(Ok, HandleResultError);
        }

        [HttpGet("expenses/{id}")]
        public async Task<IActionResult> GetExpenseAsync(int id)
        {
            var query = new CreateExpensesQuery()
            {
                Id = id
            };
            var result = await _mediator.Send(query);

            return result.Match(Ok, HandleResultError);
        }

        [HttpGet("expenses/filter")]
        [ProducesResponseType(typeof(FamilyBudgetServiceCollectionResponse<ExpenseResponse>), StatusCodes.Status200OK)]
        [Produces(MediaTypeNames.Application.Json)]
        public async Task<IActionResult> GetFilteredExpensesAsync([FromQuery] ExpenseFilteringRequest request)
        {
            var query = new CreateExpensesQuery
            {
                Id = request.ExpenseId,
                Description = request.Description,
                UserId = request.UserId,
                ExpenseCategoryId = request.ExpenseCategoryId,
                ExpenseDate = request.ExpenseDate,
                Amount = request.Amount,
                MaxAmount = request.MaxAmount,
                MinAmount = request.MinAmount,
                Page = request.Page,
                PageSize = request.PageSize,
            };

            var result = await _mediator.Send(query);
            return result.Match(Ok, HandleResultError);
        }

        [HttpPost]
        public IActionResult CreateExpense([FromBody] CreateExpenseRequest request)
        {
            throw new NotImplementedException();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateExpense(int id, [FromBody] UpdateExpenseRequest request)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteExpense(int id)
        {
            throw new NotImplementedException();
        }
    }
}
