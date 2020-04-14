using System;

namespace ProductLib
{
    /// <summary>
    /// Крупы.
    /// </summary>
    public class Groats : WeightProduct
    {
        /// <summary>
        /// Конструктор без параметров.
        /// </summary>
        public Groats() { }

        /// <summary>
        /// Конструктор с параметрами.
        /// </summary>
        /// <param name="name">Название.</param>
        /// <param name="price">Цена.</param>
        /// <param name="weight">Вес.</param>
        public Groats(string name, double price, double weight)
           : base(name, price, weight)
        {
        }
    }
}
