using System;
using System.Collections.Generic;
using System.Text;

namespace ProductLib
{
    class Milk : PieceProduct
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
            base.GetInfo();// TODO: add imp
        }
        public Milk() { }
    }
}
