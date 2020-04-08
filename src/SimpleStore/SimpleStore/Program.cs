using ProductLib;
using Storage;

namespace SimpleStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Store myStore = new Store();

            Agg myAgg = new Agg("Яйца", 0.2, AggCategory.B, 12);
            myStore.AddProduct(myAgg);

            Groats myGroats = new Groats("Гречка", 3,500);
            myStore.AddProduct(myGroats);

            Milk myMilk = new Milk("Молоко", 1.5, 7,0.5);
            myStore.AddProduct(myMilk);

            myStore.ViewProduct();
        }
    }
}
