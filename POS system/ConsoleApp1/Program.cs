using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            bool a = true;
            Bill myBill = new Bill();
            POS POS = new POS();
            Console.WriteLine("Welcome to POS ");
            Console.WriteLine("Enter 1 if you want to login as Store keeper ");
            Console.WriteLine("Enter 2 if you want to generate invoice of customer ");
            int status1 = 0;
            status1 = Convert.ToInt32(Console.ReadLine());
            if (status1 == 1)
            {
                bool st = true;
                while (st)
                {
                    Console.WriteLine("Enter 1 to add Book count  ");
                    Console.WriteLine("Enter 2 to display Book count  ");
                    Console.WriteLine("Enter 3 to exit ");
                    int status2 = 0;
                    status2 = Convert.ToInt32(Console.ReadLine());
                    if (status2 == 1)
                    {
                        POS.addcount();
                    }
                    else if (status2 == 2)
                    {
                        POS.showcount();
                    }
                    else if (status2 == 3)
                    {
                        st = false;
                    }
                }

            }
            else if (status1 == 2)
            {


                while (a)
                {
                    int status = 0;

                    Console.WriteLine("Enter 1 to add Book in bucket  ");
                    Console.WriteLine("Enter 2 to generate bill  ");
                    Console.WriteLine("Enter 3 to remove  Book in bucket  ");
                    Console.WriteLine("Enter 4 to display  Book count  ");
                    Console.WriteLine("Enter 5 to exit  ");
                    status = Convert.ToInt32(Console.ReadLine());
                    if (status == 1)
                    {
                        Console.WriteLine("For Self_Help enter 1 \n For Nonfiction enter 2 \n For History enter 3 \n For Food_Book enter 4 \n For Politics enter 5");
                        int a1 = 0;
                        a1 = Convert.ToInt32(Console.ReadLine());
                        myBill.additem(a1);
                        if (a1 == 1)
                        {

                            POS.Count_self_help = POS.Count_self_help - 1;
                        }
                        else if (a1 == 2)
                        {
                            POS.Count_nonfiction = POS.Count_nonfiction - 1;

                        }
                        else if (a1 == 3)
                        {
                            POS.Count_history = POS.Count_history - 1;

                        }

                        else if (a1 == 4)
                        {
                            POS.Count_Food_Book = POS.Count_Food_Book - 1;

                        }
                        else if (a1 == 5)
                        {
                            POS.Count_Politics = POS.Count_Politics - 1;

                        }
                    }
                    else if (status == 2)
                    {
                        myBill.total();
                    }
                    else if (status == 3)
                    {
                        Console.WriteLine("For Self_Help enter 1 \n For Nonfiction enter 2 \n For History enter 3 \n For Food_Book enter 4 \n For Politics enter 5");
                        int a1 = 0;
                        a1 = Convert.ToInt32(Console.ReadLine());

                        if (a1 == 1)
                        {

                            POS.Count_self_help = POS.Count_self_help + 1;
                        }
                        else if (a1 == 2)
                        {
                            POS.Count_nonfiction = POS.Count_nonfiction + 1;

                        }
                        else if (a1 == 3)
                        {
                            POS.Count_history = POS.Count_history + 1;

                        }

                        else if (a1 == 4)
                        {
                            POS.Count_Food_Book = POS.Count_Food_Book + 1;

                        }
                        else if (a1 == 5)
                        {
                            POS.Count_Politics = POS.Count_Politics + 1;

                        }
                        int id;
                        Console.WriteLine("Enter id of Book which you want to delete ");
                        id = Convert.ToInt32(Console.ReadLine());
                        myBill.remove(id);
                    }
                    else if (status == 4)
                    {
                        POS.showcount();
                    }
                    else if (status == 5)
                    {
                        a = false;
                    }

                }

            }


        }
    }
}