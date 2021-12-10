using System;
using System.Collections.Generic;

#nullable disable

namespace Budgeteer.Models
{
    public partial class Purchase
    {
        public long Id { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Category { get; set; }
        public string UserId { get; set; }
    }
}
