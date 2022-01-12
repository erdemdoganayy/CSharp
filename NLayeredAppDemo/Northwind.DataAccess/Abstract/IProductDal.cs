using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Abstract
{
    public interface IProductDal
    {
        List<Product> GetAll();
        List<Product> GetAll(int categoryId);
        List<Product> GetAll(string productName);
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}
