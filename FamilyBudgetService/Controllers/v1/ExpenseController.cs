using FamilyBudgetService.Api.Contracts;
using FamilyBudgetService.Api.Contracts.v1.Expense;
using FamilyBudgetService.Api.Filters;
using FamilyBudgetService.Api.Operations.Queries.Expenses;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace FamilyBudgetService.Api.Controllers.v1
{
    [Authorize]
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

        [Authorize]
        [HttpGet("expenses")]
        [ProducesResponseType(typeof(FamilyBudgetServiceCollectionResponse<ExpenseResponse>), StatusCodes.Status200OK)]
        [Produces(MediaTypeNames.Application.Json)]
        public async Task<IActionResult> GetExpensesAsync()
        {
            var query = new GetExpensesQuery
            {        
            };

            var result = await _mediator.Send(query);
            return result.Match(Ok, HandleResultError);
        }

        [Authorize]
        [HttpGet("expenses/{id}")]
        [ProducesResponseType(typeof(ExpenseResponse), StatusCodes.Status200OK)]
        [Produces(MediaTypeNames.Application.Json)]
        public async Task<IActionResult> GetExpenseAsync(int id)
        {
            var query = new GetExpensesQuery()
            {
                Id = id
            };
            var result = await _mediator.Send(query);

            return result.Match(Ok, HandleResultError);
        }

        [Authorize]
        [HttpGet("expenses/filter")]
        [ProducesResponseType(typeof(FamilyBudgetServiceCollectionResponse<ExpenseResponse>), StatusCodes.Status200OK)]
        [Produces(MediaTypeNames.Application.Json)]
        public async Task<IActionResult> GetFilteredExpensesAsync([FromQuery] ExpenseFilteringRequest request)
        {
            var query = new GetExpensesQuery
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

        [Authorize]
        [HttpPost("expenses")]
        [ProducesResponseType(typeof(ExpenseResponse), StatusCodes.Status201Created)]
        [Produces(MediaTypeNames.Application.Json)]
 
        public IActionResult CreateExpense([FromQuery] CreateExpenseRequest request)
        {
            throw new NotImplementedException();
        }

        [HttpPut("expenses/{id}")]

        [ProducesResponseType(typeof(ExpenseResponse), StatusCodes.Status200OK)]
        [Produces(MediaTypeNames.Application.Json)]
        public IActionResult UpdateExpense(int id, [FromQuery] UpdateExpenseRequest request)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("expenses/{id}")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(ExpenseResponse), StatusCodes.Status202Accepted)]
        public IActionResult DeleteExpense(int id)
        {
            throw new NotImplementedException();
        }
    }
}
