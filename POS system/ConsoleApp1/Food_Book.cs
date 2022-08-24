using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Food_Book : Book
    {
        private int _Size;



        public int Size { get => _Size; set => _Size = value; }

        public Food_Book(int Size)
        {
            this.Size = Size;
        }
        public Food_Book(int id, string desc, double price, int Size) : base(desc, id, price)
        {
            this.Size = Size;
        }

        public override void Display()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("id of Book: " + this.Id);
            Console.WriteLine("Descrption of Book: " + this.Desc);
            Console.WriteLine("Price of Book: " + this.Price);
            Console.WriteLine("Size of Food_Book: " + this.Size);
            Console.WriteLine("--------------------------------------------");
        }
    }
}
