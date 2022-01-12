using Northwind.DataAccess.Abstract;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        public List<Product> GetAll()
        {
            NorthwindContext context = new NorthwindContext();
           
            return context.Products.ToList();
        }
        public List<Product> GetAll(int categoryId)
        {
            NorthwindContext context = new NorthwindContext();

            return context.Products.Where(x=> x.CategoryId == categoryId).ToList();
        }

        public List<Product> GetAll(string productName)
        {
            NorthwindContext context = new NorthwindContext();

            return context.Products.Where(x => x.ProductName.ToLower().Contains(productName.ToLower())).ToList();
        }
    }
}
