using Microsoft.EntityFrameworkCore;

namespace DataAccess.Models;

public class SharedExpense
{
    public int Id { get; set; }
    
    // Foreign key for the User
    public int SharingUserId { get; set; }
    public User SharingUser { get; set; }

    // Foreign key for the Expense
    public int ExpenseId { get; set; }
    public Expense Expense { get; set; }
    
    [Precision(18, 2)]
    public decimal SharedAmount { get; set; }
}
