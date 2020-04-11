using System;

namespace ProductLib
{
    /// <summary>
    /// Абстрактный класс продукт.
    /// </summary>
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

        /// <summary>
        /// Вывод информации о продукте.
        /// </summary>
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
            if (price < 0)
            {
                price = 0;
            }

            Name = name;
            Code = Guid.NewGuid();
            Price = price;
        }

    }
}
