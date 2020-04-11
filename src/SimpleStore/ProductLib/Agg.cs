using System;

namespace ProductLib
{
    /// <summary>
    /// Категория яиц.
    /// </summary>
    public enum AggCategory
    {
        C3 = 1,
        C2 = 2,
        C1 = 2,
        C0 = 3,
        B = 4,
    }

    /// <summary>
    /// Яйца.
    /// </summary>
    public class Agg : PieceProduct
    {
        /// <summary>
        /// Категоря яиц.
        /// </summary>
        public AggCategory Category { get; set; }

        /// <summary>
        /// Вывод информации.
        /// </summary>
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Категория яиц: {Category}.\n");
        }

        /// <summary>
        /// Конструктор с параметрами.
        /// </summary>
        /// <param name="name">Название.</param>
        /// <param name="price">Цена.</param>
        /// <param name="category">Категория.</param>
        /// <param name="piece">Кол-во.</param>
        public Agg(string name, double price, AggCategory category, int piece)
            : base(name, price, piece) => Category = category;

        /// <summary>
        /// Конструктор без параметров.
        /// </summary>
        public Agg() { }
    }
}
