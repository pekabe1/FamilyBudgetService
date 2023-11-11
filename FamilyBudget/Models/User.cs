namespace DataAccess.Models;

public class User
{
    public int UserId { get; protected set; }
    public string UserName { get; protected set; }
    public List<UserExpense> UserExpenses { get; protected set; }
    public List<SharedExpense> SharedExpenses { get; protected set; }
}
