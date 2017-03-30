using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();
            Product p1 = new Product() {Id = 1002, Name = "Ketchup", Price = 3.2};
            Product p2 = new Product() { Id = 1008, Name = "Yoghurt", Price = 4.99 };

            shop.AddProduct(new ProductAdapter(p1));
            shop.AddProduct(new ProductAdapter(p2));

            shop.PrintAll();


        }
    }
}
