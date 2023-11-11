using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class User
    {
        public int UserId { get; protected set; }
        public string UserName { get; protected set; }
        public List<Expense>? Expenses { get; protected set; }
    }
}
