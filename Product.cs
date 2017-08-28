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
        // class variable 
        private static double taxRate = 18;

        public static double TaxRate
        {
            get
            {
                return taxRate; 
            }
            set
            {
                if (value > 0)
                    taxRate = value; 
            }  
        }

        // Constructor 
        public Product(string name, double price)
        {
            this.name = name;
            this.price = price; 
        }
        public Product(string name, double price, int qoh)
        {
            this.name = name;
            this.price = price;
            this.qoh = qoh;
        }

        public void Print()
        {
            Console.WriteLine(this.name);
            Console.WriteLine(this.price);
            Console.WriteLine(this.qoh);
        }
        
        public double GetPrice()
        {
            return price; 
        }
        // Readonly property
        public double NetPrice
        {
            get
            {
                return price + price * taxRate / 100;
            }
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

        // Read write property 
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value != "")
                    name = value; 
            }
        }
    }
    class TestProduct
    {
        public static void Main()
        {
            Product p; // object reference 

            p = new Product("Dell Laptop", 55000,10);
            Console.WriteLine(p.NetPrice);

            Product.TaxRate = 15;
            Console.WriteLine(p.NetPrice);

            Console.WriteLine( Product.TaxRate);


        }
    }
}
