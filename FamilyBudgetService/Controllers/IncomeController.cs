//using Microsoft.AspNetCore.Mvc;
//using System.Security.Claims;

//namespace FamilyBudgetService.Controllers
//{
//    public class IncomeController
//    {
//        [HttpGet]
//        public IActionResult GetIncomes()
//        {
//            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
//            var incomes = _dbContext.Incomes.Where(i => i.UserId == userId).ToList();
//            return Ok(incomes);
//        }

//        [HttpGet("{id}")]
//        public IActionResult GetIncome(int id)
//        {
//            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
//            var income = _dbContext.Incomes.FirstOrDefault(i => i.IncomeId == id && i.UserId == userId);

//            if (income == null)
//                return NotFound();

//            return Ok(income);
//        }

//        [HttpPost]
//        public IActionResult AddIncome([FromBody] Income income)
//        {
//            if (income == null)
//                return BadRequest();

//            // Set the user ID based on the authenticated user
//            income.UserId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

//            _dbContext.Incomes.Add(income);
//            _dbContext.SaveChanges();

//            return CreatedAtAction(nameof(GetIncome), new { id = income.IncomeId }, income);
//        }

//        [HttpPut("{id}")]
//        public IActionResult UpdateIncome(int id, [FromBody] Income updatedIncome)
//        {
//            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
//            var existingIncome = _dbContext.Incomes.FirstOrDefault(i => i.IncomeId == id && i.UserId == userId);

//            if (existingIncome == null)
//                return NotFound();

//            // Update properties based on your model
//            existingIncome.Description = updatedIncome.Description;
//            existingIncome.Amount = updatedIncome.Amount;
//            existingIncome.Date = updatedIncome.Date;

//            _dbContext.SaveChanges();

//            return NoContent();
//        }

//        [HttpDelete("{id}")]
//        public IActionResult DeleteIncome(int id)
//        {
//            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
//            var incomeToDelete = _dbContext.Incomes.FirstOrDefault(i => i.IncomeId == id && i.UserId == userId);

//            if (incomeToDelete == null)
//                return NotFound();

//            _dbContext.Incomes.Remove(incomeToDelete);
//            _dbContext.SaveChanges();

//            return NoContent();
//        }
//    }
//}
