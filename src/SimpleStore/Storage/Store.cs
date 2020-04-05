using ProductLib;
using System.Collections.Generic;

namespace Storage
{
    public class Store
    {
        /// <summary>
        /// Список всех продуктов.
        /// </summary>
        public List<Product> Products { get; set; } = new List<Product>();
        public Store() { }
        /// <summary>
        /// Добавить продукт в магазин.
        /// </summary>
        /// <param name="p">Продукт.</param>
        public void AddProduct(Product p)
        {
            Products.Add(p);
        }
        /// <summary>
        /// Просмотр всех продуктов в магазине.
        /// </summary>
        public void ViewProduct()
        {
            foreach (var p in Products)
            {
                p.GetInfo();
            }
        }
    }
}
