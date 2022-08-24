using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Self_Help : Book
    {
        private double _discountRate;

        public double DiscountRate
        {
            get { return _discountRate; }
            set { _discountRate = value; }
        }

        public Self_Help(double discount)
        {
            this.DiscountRate = discount;
        }
        public Self_Help(int id, string desc, double price, double discount) : base(desc, id, price)
        {
            this.DiscountRate = discount;
        }
        public override double CalculatePrice()
        {
            return this.Price = this.Price - (this.Price * this.DiscountRate) / 100;

        }
        public override void Display()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("id of Book: " + this.Id);
            Console.WriteLine("Descrption of Book: " + this.Desc);
            Console.WriteLine("Price of Book: " + this.Price);
            Console.WriteLine("Dicount Rate: " + this.DiscountRate);
            Console.WriteLine("--------------------------------------------");
        }

    }
}
