using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class History : Book
    {
        private string _expDate;

        public string ExpDate
        {
            get { return _expDate; }
            set { _expDate = value; }
        }
        public History(string expDate)
        {
            this.ExpDate = expDate;
        }

        public History(int id, string desc, double price, string expDate) : base(desc, id, price)
        {
            this.ExpDate = expDate;
        }
        public override void Display()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("id of Book: " + this.Id);
            Console.WriteLine("Descrption of Book: " + this.Desc);
            Console.WriteLine("Price of Book: " + this.Price);
            Console.WriteLine("Expire date of Book: " + this.ExpDate);
            Console.WriteLine("--------------------------------------------");
        }

    }
}
