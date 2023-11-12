using Microsoft.EntityFrameworkCore;

namespace DataAccess.Models;

public class Expense
{
    public int Id { get; set; }
    public string Description { get; set; }

    [Precision(18, 2)]
    public decimal Amount { get; set; }
    public DateTime ExpenseDate { get; set; }

    // Foreign key for the expense category
    public ExpenseCategory ExpenseCategory { get; set; }
    public int? ExpenseCategoryId { get; set; }

    // Foreign key for the user who made the expense
    public int UserId { get; set; }
    public User User { get; set; }

    // Navigation property for shared expenses
    public List<SharedExpense> SharedWith { get; set; }
}
