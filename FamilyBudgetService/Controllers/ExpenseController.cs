//using Microsoft.AspNetCore.Mvc;
//using Microsoft.VisualBasic;
//using System.Security.Claims;

//namespace FamilyBudgetService.Controllers
//{
//    public class ExpenseController
//    {
//        [HttpGet]
//        public IActionResult GetExpenses()
//        {
//            throw new NotImplementedException();
//        }

//        [HttpGet("{id}")]
//        public IActionResult GetExpense(int id)
//        {
//            throw new NotImplementedException();
//        }

//        [HttpPost]
//        public IActionResult CreateExpense([FromBody] Expense expense)
//        {
//            throw new NotImplementedException();
//        }

//        [HttpPut("{id}")]
//        public IActionResult UpdateExpense(int id, [FromBody] Expense updatedExpense)
//        {
//            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
//            var existingExpense = _dbContext.Expenses.FirstOrDefault(e => e.ExpenseId == id && e.UserId == userId);

//            if (existingExpense == null)
//                return NotFound();

//            // Update properties based on your model
//            existingExpense.Description = updatedExpense.Description;
//            existingExpense.Amount = updatedExpense.Amount;
//            existingExpense.Date = updatedExpense.Date;

//            _dbContext.SaveChanges();

//            return NoContent();
//        }

//        [HttpDelete("{id}")]
//        public IActionResult DeleteExpense(int id)
//        {
//            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
//            var expenseToDelete = _dbContext.Expenses.FirstOrDefault(e => e.ExpenseId == id && e.UserId == userId);

//            if (expenseToDelete == null)
//                return NotFound();

//            _dbContext.Expenses.Remove(expenseToDelete);
//            _dbContext.SaveChanges();

//            return NoContent();
//        }
//    }
//}
