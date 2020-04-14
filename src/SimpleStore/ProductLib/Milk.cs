using System;
using System.Collections.Generic;
using System.Text;

namespace ProductLib
{
    /// <summary>
    /// Молоко.
    /// </summary>
    public class Milk : PieceProduct
    {
        /// <summary>
        /// Объем.
        /// </summary>
        public double Volume { get; set; }

        /// <summary>
        /// Конструктор с параметрами.
        /// </summary>
        /// <param name="name">Название.</param>
        /// <param name="price">Цена.</param>
        /// <param name="piece">Кол-во.</param>
        /// <param name="volume">Объем.</param>
        public Milk(string name, double price,int piece , double volume) 
            : base(name, price, piece)
        {
            if (volume <= 0)
            {
                throw new ArgumentException();
            }

            Volume = volume;
        }

        /// <summary>
        /// Вывод информации.
        /// </summary>
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Объем: {Volume}л.\n");
        }

        /// <summary>
        /// Конструктор без параметров.
        /// </summary>
        public Milk() { }
    }
}
