using FamilyBudgetService.Api.Contracts.v1.Expense;
using FamilyBudgetService.Api.Controllers;
using FamilyBudgetService.Api.Filters;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FamilyBudgetService.Controllers
{
    [ApiController]
    [Route("api/v1")]
    [ApiVersionInResponseHeader("v1")]
    public class ExpenseController : FamilyBudgetControllerBase
    {
        private readonly IMediator _mediator;

        [HttpGet]
        public IActionResult GetExpenses()
        {
            throw new NotImplementedException();
        }

        [HttpGet("{id}")]
        public IActionResult GetExpense(int id)
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
