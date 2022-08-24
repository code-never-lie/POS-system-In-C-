using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Politics : Book
    {

        private bool _isWaterproof;

        public Politics(bool isWaterproof)
        {
            _isWaterproof = isWaterproof;
        }

        public Politics(int id, string desc, double price, bool isWaterproof) : base(desc, id, price)
        {

            _isWaterproof = isWaterproof;
        }

        public bool IsWaterproof { get => _isWaterproof; set => _isWaterproof = value; }

        public override void Display()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("id of Book: " + this.Id);
            Console.WriteLine("Descrption of Book: " + this.Desc);
            Console.WriteLine("Price of Book: " + this.Price);
            Console.WriteLine("Is makeup is waterproof: " + this.IsWaterproof);
            Console.WriteLine("--------------------------------------------");
        }

    }
}