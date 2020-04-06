using System;
using System.Collections.Generic;

namespace ProductLib
{
    public enum AggCategory
    {
        C3 = 1,
        C2 = 2,
        C1 = 2,
        C0 = 3,
        B = 4,
    }
    public class Agg : PieceProduct
    {
        /// <summary>
        /// Категоря яиц.
        /// </summary>
        public AggCategory Category { get; set; }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Категория яиц: {Category}.\n");
        }
        public Agg(string name, double price, AggCategory category, int piece)
            : base(name, price, piece) => Category = category;
        public Agg() { }
    }
}
