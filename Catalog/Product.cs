using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogConsoleApp
{
    class Product
    {
        private int id;
        private string title;
        private string desc;
        private double unitPrice;
        private int quantity;

        public Product()
        {
            this.id = 0;
            this.title = "title";
            this.desc = "desc";
            this.unitPrice = 0;
            this.quantity = 0;
        }
        public Product(int id, string title, string desc, double unitPrice, int quantity)
        {
            this.id = id;
            this.title = title;
            this.desc = desc;
            this.unitPrice = unitPrice;
            this.quantity = quantity;
        }
        public int GetId(){
            return this.id;
        }
        public void SetId(int id)
        {
            this.id = id;
        }
        public string GetTitle()
        {
            return this.title;
        }
        public void SetTitle(string title)
        {
            this.title = title;
        }
        public string Getdesc()
        {
            return this.desc;
        }
        public void SetDesc(string desc)
        {
            this.desc = desc;
        }

        public double GetUnitPrice()
        {
            return this.unitPrice;
        }
        public void SetUnitPrice(double unitPrice)
        {
            this.unitPrice = unitPrice;
        }
        public int GetQuantity()
        {
            return this.quantity;
        }
        public void SetQuantity(int quantity)
        {
            this.quantity = quantity;
        }

        public override string ToString()
        {
            return this.id + " "+this.title + " "+this.desc+ " "+this.quantity + " "+this.unitPrice;
        }

        public void Accept()
        {
            Console.WriteLine("Enter Product Id");
            this.SetId(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Enter Product Title");
            this.SetTitle(Console.ReadLine());
            Console.WriteLine("Enter Product Desc");
            this.SetDesc(Console.ReadLine());          
            Console.WriteLine("Enter Product Price");
            this.SetUnitPrice(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Enter Product Quantity");
            this.SetQuantity(Convert.ToInt32(Console.ReadLine()));
        }
        public void Display()
        {
            Console.WriteLine(this.ToString());
        }
        public double GetTotalPrice()
        {
            return unitPrice * quantity;
        }
        public double GetDiscountedPrice(double discount)
        {
            double TotalPrice = GetTotalPrice();
            return TotalPrice - (TotalPrice * discount / 100);
        }
    }
}
