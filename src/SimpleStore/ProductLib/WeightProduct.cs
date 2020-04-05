using System;
using System.Collections.Generic;
using System.Text;

namespace ProductLib
{
    public class WeightProduct : Product
    {
        /// <summary>
        /// Вес.
        /// </summary>
        public double Weight { get; set; }
        public override void GetInfo()
        {
            base.GetInfo();// TODO: add imp
        }
        public WeightProduct(string name, double price, double weight)
            : base(name, price) => Weight = weight;
        public WeightProduct() { }
        
    }
}
