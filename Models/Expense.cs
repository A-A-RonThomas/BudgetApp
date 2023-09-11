using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp.Models
{
    public class Expense
    {
        public string? ID { get; set; }
        public string? Category { get; set; }
        public double? Planned { get; set; }
        public double? Actual { get; set; }
        public double? Difference { get; set; }

        public Expense(string? iD, string? category, int? planned, int? actual)
        {
            ID = iD;
            Category = category;
            Planned = planned;
            Actual = actual;
        }

        public Expense() {  }
        

    }
}
