using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Expense
    {
        public int Id { get; protected set; }
        public string Description { get; protected set; }
        public decimal Amount { get; protected set; }
        public DateTime ExpenseDate { get; protected set; }

        // Foreign key for the expense type
        public ExpenseCategory ExpenseCategory { get; protected set; }
        public int ExpenseTypeId { get; protected set; }

        // Foreign key for the user who made the expense
        public int UserId { get; protected set; }
        public User User { get; protected set; }

        // Navigation property for shared expenses
        public List<SharedExpense> SharedWith { get; set; }
    }
}
