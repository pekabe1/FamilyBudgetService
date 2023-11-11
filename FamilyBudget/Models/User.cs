namespace DataAccess.Models;

public class User
{
    public int UserId { get; protected set; }
    public string UserName { get; protected set; }

    // Navigation property for user's own expenses
    public List<Expense> UserExpenses { get; set; }

    // Navigation property for user's own incomes
    public List<Income> Incomes { get; set; }

    // Navigation property for shared expenses
    public List<SharedExpense> SharedExpenses { get; set; }
}
