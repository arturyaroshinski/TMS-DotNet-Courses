using ProductLib;
using Storage;

namespace SimpleStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Store myStore = new Store();

            Agg myAgg = new Agg();
            myStore.AddProduct(myAgg);

            Agg myAgg1 = new Agg();
            myStore.AddProduct(myAgg1);

            Agg myAgg2 = new Agg();
            myStore.AddProduct(myAgg2);

            myStore.ViewProduct();
        }
    }
}
