using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace hometask_4
{
    internal class ProductDB
    {
        public Product[] products = new Product[5];
        public int i = 0, itemNum = 0;
        public bool valid = true;

        public void addToProducts(Product product)
        {
            products[i] = product;
            i++;
            if (i == products.Length)
            {
                valid = false;
                Console.WriteLine("DATABASE IS FULL NOW!");
            }
        }
        public void ProductsList()
        {
            foreach (var item in products)
            {
                if (item != null)
                {
                    itemNum++;
                    Console.WriteLine();
                    Console.WriteLine("Product Number: " + itemNum);
                    Console.WriteLine("ID: " + item.ID);
                    Console.WriteLine("Name: " + item.NAME);
                    Console.WriteLine("Price: " + item.PRICE);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("THERE IS NO PRODUCT");
                }
            }
            itemNum = 0;
        }
        public void searchProduct(string name)
        {
            foreach (var item in products)
            {
                if (name == item.NAME)
                {
                    Console.WriteLine();
                    Console.WriteLine("ID: " + item.ID);
                    Console.WriteLine("Name: " + item.NAME);
                    Console.WriteLine("Price: " + item.PRICE);
                    Console.WriteLine();
                }
            }
        }
    }
}
