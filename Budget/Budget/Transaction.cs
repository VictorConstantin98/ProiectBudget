﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget
{
    internal abstract class Transaction
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
    }
}
