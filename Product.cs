using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Group1_Shubham_Anila_Assignment2
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }

        public Product(int ProductID, string ProductName, int Price, int Stock)
        {
            this.ProductID = ProductID;
            this.ProductName = ProductName;
            this.Price = Price;
            this.Stock = Stock;
        }


        public void Increase(int count){ Stock = Stock + count; }

        public void Decrease(int count) { Stock = Stock - count; }


    }
}
