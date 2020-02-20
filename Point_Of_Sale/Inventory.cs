using System;
using System.Collections.Generic;
using System.Text;


namespace Point_Of_Sale
{
   class Inventory
    {
        private List<Product> products;
        public List<Product> Products { get => products; set => products = value; }

        public Inventory() 
        { 
            products = new List<Product>(); 
        }
        
        public void AddProduct(Product a)
        {
            products.Add(a);
        }

        public void ListProducts()
        {
            foreach (Product a in products)
            {
                Console.WriteLine(a);
            }
        }

    }
}
