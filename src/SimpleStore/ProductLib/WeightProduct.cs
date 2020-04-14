using System;

namespace ProductLib
{
    /// <summary>
    /// Продукты с указанием веса.
    /// </summary>
    public class WeightProduct : Product
    {
        /// <summary>
        /// Вес.
        /// </summary>
        public double Weight { get; set; }

        /// <summary>
        /// Вывод информации о продукте.
        /// </summary>
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Вес: {Weight}г.\n");
        }

        /// <summary>
        /// Конструктор с параметрами.
        /// </summary>
        /// <param name="name">Название.</param>
        /// <param name="price">Цена.</param>
        /// <param name="weight">Вес.</param>
        public WeightProduct(string name, double price, double weight)
            : base(name, price)
        {
            if (weight <= 0)
            {
                throw new ArgumentException();
            }

            Weight = weight;
        }

        /// <summary>
        /// Конструкторм без параметров.
        /// </summary>
        public WeightProduct() { }
        
    }
}
