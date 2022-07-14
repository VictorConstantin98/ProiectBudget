using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget
{
    internal class Expense : Transaction
    {
        private string category;

        public Expense(string category, double value, string name)
        {
            this.category = category;
            this.value = value;
            this.name = name;
        }

        public double getValue()
        {
            return this.value;
        }

        public void setValue(double value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            string expenseString = "";
            expenseString = expenseString + "\n" + "Category: " + category + "\n" + "Value: " + value + "\n" + "Name: " + name;
            return expenseString;
        }
    }
}
