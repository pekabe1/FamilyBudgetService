using FamilyBudgetService.Api.Contracts.v1.Expense;
using FamilyBudgetService.Api.Filters;
using FamilyBudgetService.Api.QueryServices.V1.Expenses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<IActionResult> GetExpensesAsync(GetExpenseRequest request)
        {
            var query = new ExpenseQuery()
            {
                Id = request.ExpenseId
            };

            var result = await _mediator.Send(query);
            return result.Match(Ok, HandleResultError);
        }

        [HttpGet("expenses/{id}")]
        public IActionResult GetExpenseAsync(int id)
        {
            throw new NotImplementedException();
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
