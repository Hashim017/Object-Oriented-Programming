using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task_3.BL;

namespace task_3.BL
{
    class Product
    {
        public string ProductName;
        public string ProductCategory;
        public int ProductPrice;

        public Product()
        {

        }

        public Product(string name, string category, int price)
        {
            ProductName = name;
            ProductCategory = category;
            ProductPrice = price;
        }

    }
}
