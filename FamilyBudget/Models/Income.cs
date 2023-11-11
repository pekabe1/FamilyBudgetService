using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Income
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        
        // Foreign key for the User
        public int UserId { get; set; }
        public User User { get; set; }
        
        // Foreign key for the IncomeCategory
        public IncomeCategory IncomeCategory { get; set; }
        public int? IncomeCategoryId { get; set; }
    }
}
