using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task_3.BL;

namespace task_3.BL
{
    class Customer
    {
        public string CustomerName;
        public string CustomerAddress;
        public string CustomerContact;
        public List<Product> products = new List<Product>();

        public Customer()
        {

        }

        public List<Product> getAllProducts()
        {
            return products;
        }

        public Customer(string name, string address, string contact)
        {
            CustomerName = name;
            CustomerAddress = address;
            CustomerContact = contact;
        }

        public void addProduct(Product p)
        {
            products.Add(p);
        }
        public float calculateTax()
        {
            float tax = 0f;
            for(int x = 0; x < products.Count; x++)
            {
                tax = tax + ((products[x].ProductPrice * 10)/100);
            }
            return tax;
        }
    }
}
