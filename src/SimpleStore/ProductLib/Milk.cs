using System;
using System.Collections.Generic;
using System.Text;

namespace ProductLib
{
    public class Milk : PieceProduct
    {
        /// <summary>
        /// Объем.
        /// </summary>
        public double Volume { get; set; }
        public Milk(string name, double price,int piece , double volume) 
            : base(name, price, piece)
        {
            //TODO: добавить проверку
            Volume = volume;
        }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Объем: {Volume}л.\n");
        }
        public Milk() { }
    }
}
