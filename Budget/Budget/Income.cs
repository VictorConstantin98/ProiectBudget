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

        public override bool Equals(object? obj)
        {
            // Varianta cu tratare a exceptiei
            try
            {
                if (this.provenience == ((Income)obj).provenience && this.name == ((Income)obj).name)
                {
                    return true;
                }
                return false;
            }
            catch (InvalidCastException ex)
            {
                return false;
            }
           

            // Varianta Cu verificare a tipului de obiect
            /*if(obj is Income)
            {
           
                if (this.provenience == ((Income)obj).provenience && this.name == ((Income)obj).name)
                {
                    return true;
                }
                return false;
            
            }
            else
            {
                return false;
            }*/

        }
    }
}
