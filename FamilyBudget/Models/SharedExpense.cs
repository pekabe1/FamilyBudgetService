namespace DataAccess.Models;

public class SharedExpense
{
    public int Id { get; set; }

    public int SharingUserId { get; set; }
    public User SharingUser { get; set; }

    public int ExpenseId { get; set; }
    public Expense Expense { get; set; }
}
