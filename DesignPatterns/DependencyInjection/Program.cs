using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new ProductDal());
            productManager.Save();
            Console.ReadLine();
        }
    }

    interface IProductDal
    {
        void Save();
    }
    class ProductDal : IProductDal
    {
        public void Save()
        {
            Console.WriteLine("Saved with Entity");
        }
    }

    class ProductManager
    {
        IProductDal _productDal;
        public ProductManager (IProductDal productDal)
        {
            _productDal = productDal;
        }
        public void Save ()
        {
            _productDal.Save();
        }
    }
}
