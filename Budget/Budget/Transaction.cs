using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget
{
    internal abstract class Transaction : IComparable
    {
        protected double value;
        protected string name;

        public double getValue()
        {
            return this.value;
        }

        public string getName()
        {
            return this.name;
        }

        public int CompareTo(object? obj)
        {
            // this; obj;
            /// this > obj   -1
            /// this == obj  0
            /// this < obj   1
            
            if(this.value > ((Transaction)obj).value) 
                return 1;
            if(this.value < ((Transaction)obj).value) 
                return -1;
            if(this.value == ((Transaction)obj).value) 
                return 0;

            return 0; 

            
        }
    }
}
