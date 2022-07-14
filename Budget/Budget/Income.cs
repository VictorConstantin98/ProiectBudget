using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget
{
    internal class Income : Transaction
    {
        private string provenience;

        public Income(string provenience, double value, string name)
        {
            this.provenience = provenience;
            this.value = value;
            this.name = name;
        }

        public double getValue()
        {
            return this.value;
        }

        public override string ToString()
        {
            string incomeString = "";
            incomeString = incomeString + "\n" + "Provenience: " + provenience + "\n" + "Value: " + value + "\n" + "Name: " + name;
            return incomeString;
        }
        // to implement equals 
    }
}
