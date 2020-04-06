using System;

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
            base.GetInfo();
            Console.WriteLine($"Вес: {Weight}г.\n");
        }
        public WeightProduct(string name, double price, double weight)
            : base(name, price) => Weight = weight;
        public WeightProduct() { }
        
    }
}
