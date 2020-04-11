using System;
using System.Collections.Generic;
using System.Text;

namespace ProductLib
{
    /// <summary>
    /// Поштучные продукты.
    /// </summary>
    public class PieceProduct : Product
    {
        /// <summary>
        /// Кол-во.
        /// </summary>
        public int Piece { get; set; }

        /// <summary>
        /// Конструктор с параметрами.
        /// </summary>
        /// <param name="name">Название.</param>
        /// <param name="price">Цена.</param>
        /// <param name="piece">Кол-во.</param>
        public PieceProduct(string name, double price, int piece)
            : base(name, price)
        {
            if (piece <= 0)
            {
                throw new ArgumentException();
            }

            Piece = piece;
        }

        /// <summary>
        /// Конструктор без параметров.
        /// </summary>
        public PieceProduct() { }

        /// <summary>
        /// Вывод информаци о продукте.
        /// </summary>
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Кол-во: {Piece}");
        }
    }
}
