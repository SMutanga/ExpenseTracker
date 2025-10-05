using System;

namespace ExpemseTracker
{
    public class Expense
    {
        public string Name { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }

        public override string ToString()
        {
            return $"{Name} - ${Amount:F2} on {Date:d}";
        }
    }
}

