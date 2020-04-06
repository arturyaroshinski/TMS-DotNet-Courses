using System;
using System.Collections.Generic;
using System.Text;

namespace ProductLib
{
    public class PieceProduct : Product
    {
        public int Piece { get; set; }
        public PieceProduct(string name, double price, int piece)
            : base(name, price) => Piece = piece;
        public PieceProduct() { }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Кол-во: {Piece}");
        }
    }
}
