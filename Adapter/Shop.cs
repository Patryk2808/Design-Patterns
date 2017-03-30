using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public interface IProduct
    {
        void Print();
    }

    public class ProductAdapter : IProduct
    {
        private Product _product;

        public ProductAdapter(Product p)
        {
            _product = p;
        }

        public void Print()
        {
            Console.WriteLine($"PRODUCT: id: {_product.Id} name: {_product.Name} price: {_product.Price}");
        }
    }

    public class Shop
    {
        private List<IProduct> _products = new List<IProduct>();

        public void AddProduct(IProduct p)
        {
            _products.Add(p);
        }

        public void PrintAll()
        {
            foreach (var product in _products)
            {
                product.Print();
            }
        }
    }
}
