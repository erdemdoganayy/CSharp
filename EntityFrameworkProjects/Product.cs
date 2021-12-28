using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkProjects
{
    public class Product
    {
        internal object unitPrice;
        internal object stockAmount;

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public int StockAmount { get; set; }
    }
}
