using Microsoft.AspNetCore.Mvc;

namespace FamilyBudgetService.Api.Controllers
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
        public IActionResult CreateExpenseCategory([FromBody] ExpenseCategory expenseCategory)
        {
            if (expenseCategory == null)
                return BadRequest();

            _dbContext.ExpenseCategories.Add(expenseCategory);
            _dbContext.SaveChanges();

            return CreatedAtAction(nameof(GetExpenseCategory), new { id = expenseCategory.ExpenseCategoryId }, expenseCategory);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateExpenseCategory(int id, [FromBody] ExpenseCategory updatedExpenseCategory)
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
