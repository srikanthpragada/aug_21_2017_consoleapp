using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Product
    {
        // instance variables
        private string name;
        private double price;
        private int qoh;
        // Constructor 
        public Product(string n, double p)
        {
            name = n;
            price = p;
        }
        public void Print()
        {
            Console.WriteLine(name);
            Console.WriteLine(price);
            Console.WriteLine(qoh);
        }
        public string GetName()
        {
            return name;
        }

        public double GetPrice()
        {
            return price; 
        }
        public double GetNetPrice()
        {
            return price + 1.18;
        }

        public void Purchase(int qty)
        {
            qoh += qty;
        }

        public void Sell(int qty)
        {
            if (qoh >= qty)
                qoh -= qty;
            else
                Console.WriteLine("Sorry! Insufficient quantity!");
        }
    }
    class TestProduct
    {
        public static void Main()
        {
            Product p; // object reference 

            p = new Product("Dell Laptop", 55000);  

            //if (p.GetNetPrice() > 50000)
            //    Console.WriteLine("{0} is Costly Product", p.GetName());

            p.Purchase(10);
            p.Sell(3);

            p.Print();


        }
    }
}
