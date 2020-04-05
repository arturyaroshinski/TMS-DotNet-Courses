using System;
using System.Collections.Generic;
using System.Text;

namespace ProductLib
{
    public class Groats : WeightProduct
    {
        public Groats() { }
        public Groats(string name, double price, double weight)
           : base(name, price, weight)
        {
        }
    }
}
