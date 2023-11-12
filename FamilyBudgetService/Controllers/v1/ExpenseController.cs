using FamilyBudgetService.Api.Contracts.v1.Expense;
using FamilyBudgetService.Api.Filters;
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
        public IActionResult GetExpensesAsync()
        {
           
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
