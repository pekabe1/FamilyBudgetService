using FamilyBudgetService.Api.Contracts.v1.ExpenseCategory;
using Microsoft.AspNetCore.Mvc;

namespace FamilyBudgetService.Api.Controllers.v1
{
    public class ExpenseCategoryController
    {
        [HttpGet]
        public IActionResult GetExpenseCategories()
        {
            throw new NotImplementedException();
        }

        [HttpGet("{id}")]
        public IActionResult GetExpenseCategory(int id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public IActionResult CreateExpenseCategory([FromBody] CreateExpenseCategoryRequest request)
        {
            throw new NotImplementedException();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateExpenseCategory(int id, [FromBody] UpdateExpenseCategoryRequest request)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteExpenseCategory(int id)
        {
            throw new NotImplementedException();
        }
    }
}
