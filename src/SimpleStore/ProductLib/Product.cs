using System;

namespace ProductLib
{
    public abstract class Product
    {
        /// <summary>
        /// Имя.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Уникальный номер.
        /// </summary>
        public Guid Code { get; }
        /// <summary>
        /// Цена.
        /// </summary>
        public double Price { get; set; }

        public virtual void GetInfo()
        {
            Console.WriteLine($"Название продукта: {Name}.\nЦена: {Price}$.\nУникальный код: {Code}.");
        }
        /// <summary>
        /// Конструктор без параметров.
        /// </summary>
        protected Product() => Code = Guid.NewGuid();
        /// <summary>
        /// Конструктор с параметрами.
        /// </summary>
        /// <param name="name">Имя.</param>
        /// <param name="price">Цена.</param>
        protected Product(string name, double price)
        {
            // TODO: добавить проверку.
            Name = name;
            Code = Guid.NewGuid();
            Price = price;
        }

    }
}
