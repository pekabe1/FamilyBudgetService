using Microsoft.EntityFrameworkCore;

namespace DataAccess.Models;

public class Expense
{
    public int Id { get; protected set; }
    public string Description { get; protected set; }
    
    [Precision(18, 2)]
    public decimal Amount { get; protected set; }
    public DateTime ExpenseDate { get; protected set; }

    // Foreign key for the expense category
    public ExpenseCategory ExpenseCategory { get; protected set; }
    public int? ExpenseCategoryId { get; protected set; }

    // Foreign key for the user who made the expense
    public int UserId { get; protected set; }
    public User User { get; protected set; }

    // Navigation property for shared expenses
    public List<SharedExpense> SharedWith { get; set; }
}
