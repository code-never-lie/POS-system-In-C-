using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Bill
    {

        List<Book> items = new List<Book>();
        List<int> reemove = new List<int>();

        public void additem(int a)
        {

            if (a == 1)
            {
                Console.WriteLine("Enter Book id ");
                int i_id = 0;
                i_id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Book description ");
                string i_des = null;
                i_des = (Console.ReadLine());
                Console.WriteLine("Enter Book price ");
                double i_pr = 0;
                i_pr = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Book discount ");
                double i_dis = 0;
                i_dis = Convert.ToDouble(Console.ReadLine());

                Book i1 = new Self_Help(i_id, i_des, i_pr, i_dis);
                items.Add(i1);

            }
            else if (a == 2)
            {

                Console.WriteLine("Enter Book id ");
                int i_id = 0;
                i_id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Book description ");
                string i_des = null;
                i_des = (Console.ReadLine());
                Console.WriteLine("Enter Book price ");
                double i_pr = 0;
                i_pr = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Book Tax Rate ");
                double i_tax = 0;
                i_tax = Convert.ToDouble(Console.ReadLine());

                Book i2 = new Nonfiction(i_id, i_des, i_pr, i_tax);
                items.Add(i2);



            }
            else if (a == 3)
            {

                Console.WriteLine("Enter Book id ");
                int i_id = 0;
                i_id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Book description ");
                string i_des = null;
                i_des = (Console.ReadLine());
                Console.WriteLine("Enter Book price ");
                double i_pr = 0;
                i_pr = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Expire date of Book ");
                string i_expDate;
                i_expDate = (Console.ReadLine());

                Book i3 = new History(i_id, i_des, i_pr, i_expDate);
                items.Add(i3);



            }
            else if (a == 4)
            {

                Console.WriteLine("Enter Book id ");
                int i_id = 0;
                i_id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Book description ");
                string i_des = null;
                i_des = (Console.ReadLine());
                Console.WriteLine("Enter Book price ");
                double i_pr = 0;
                i_pr = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Size of Food_Book ");
                int i_Size = 0;
                i_Size = Convert.ToInt32(Console.ReadLine());

                Book i4 = new Food_Book(i_id, i_des, i_pr, i_Size);
                items.Add(i4);



            }
            else if (a == 5)
            {

                Console.WriteLine("Enter Book id ");
                int i_id = 0;
                i_id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Book description ");
                string i_des = null;
                i_des = (Console.ReadLine());
                Console.WriteLine("Enter Book price ");
                double i_pr = 0;
                i_pr = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Is makeup is waterproof ");
                bool i_isWaterproof;
                i_isWaterproof = Convert.ToBoolean(Console.ReadLine());

                Book i5 = new Politics(i_id, i_des, i_pr, i_isWaterproof);
                items.Add(i5);



            }

        }
        public void remove(int id)
        {
            Book r1 = null;
            foreach (Book aPart in items)
            {
                if (aPart.Id == id)
                {
                    r1 = aPart;
                }


            }

            items.Remove(r1);


        }


        public void total()
        {


            double t_price = 0;

            foreach (Book aPart in items)
            {

                aPart.Display();
                t_price = t_price + aPart.CalculatePrice();
            }

            Console.WriteLine("You have to pay: " + t_price);
            Console.WriteLine("--------------------------------------------");

        }

    }
}