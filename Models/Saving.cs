using System;
using System.Collections.Generic;

#nullable disable

namespace Budgeteer.Models
{
    public partial class Saving
    {
        public long Id { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Category { get; set; }
        public long? UserId { get; set; }
    }
}
