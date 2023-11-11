namespace DataAccess.Models;

public class User
{
    public int UserId { get; protected set; }
    public string UserName { get; protected set; }
    public List<Expense>? UserExpenses { get; protected set; }
}
