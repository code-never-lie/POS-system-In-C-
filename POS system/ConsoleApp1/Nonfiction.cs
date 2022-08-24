using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Nonfiction : Book
    {

        private double _taxRate;

        public double TaxRate
        {
            get { return _taxRate; }
            set { _taxRate = value; }
        }

        private void UpdatePrice()
        {
            this.Price = this.Price + (this.Price * this.TaxRate) / 100;

        }
        public Nonfiction(double taxRate)
        {
            this.TaxRate = taxRate;
        }
        public Nonfiction(int id, string desc, double price, double taxRate) : base(desc, id, price)
        {
            this.TaxRate = taxRate;
        }

        public override double CalculatePrice()
        {
            return this.Price = this.Price + (this.Price * this.TaxRate) / 100;

        }
        public override void Display()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("id of Book: " + this.Id);
            Console.WriteLine("Descrption of Book: " + this.Desc);
            Console.WriteLine("Price of Book: " + this.Price);
            Console.WriteLine("Tax Rate: " + this.TaxRate);
            Console.WriteLine("--------------------------------------------");
        }
    }
}