using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class POS
    {
        private int _count_self_help;
        private int _count_nonfiction ;
        private int _count_history;
        private int _count_Food_Book;
        private int _count_Politics;

        public POS()
        {
            _count_self_help = 20;
            _count_nonfiction = 20;
            _count_history =20;
            _count_Food_Book = 20;
            _count_Politics = 20;
        }

        public int Count_self_help { get => _count_self_help; set => _count_self_help = value; }
        public int Count_nonfiction { get => _count_nonfiction; set => _count_nonfiction = value; }
        public int Count_history { get => _count_history; set => _count_history = value; }
        public int Count_Food_Book { get => _count_Food_Book; set => _count_Food_Book = value; }
        public int Count_Politics { get => _count_Politics; set => _count_Politics = value; }

        public void addcount()
        {

            Console.WriteLine("For Self_Help count enter 1 \n For Nonfiction count enter 2 \n For History count enter 3 \n For Food_Book  count enter 4 \n For Politics count enter 5");
            int a = 0;
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter count which you want to add");
            int c = 0;
            c = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
            {

                Count_self_help = Count_self_help + c;
            }
            else if (a == 2)
            {
                Count_nonfiction = Count_nonfiction + c;

            }
            else if (a == 3)
            {
                Count_history = Count_history + c;

            }

            else if (a == 4)
            {
                _count_Food_Book = _count_Food_Book + c;

            }
            else if (a == 5)
            {
                _count_Politics = _count_Politics + c;

            }
        }

        public void showcount()
        {

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("_count_self_help: " + this._count_self_help);
            Console.WriteLine("_count_nonfiction: " + this._count_nonfiction);
            Console.WriteLine("_count_history: " + this._count_history);
            Console.WriteLine("_count_Food_Book: " + this._count_Food_Book);
            Console.WriteLine("_count_Politics: " + this._count_Politics);
            Console.WriteLine("--------------------------------------------");
        }


    }
}
