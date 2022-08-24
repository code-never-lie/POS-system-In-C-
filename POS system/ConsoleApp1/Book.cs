using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    abstract class Book
    {

        private string _desc;

        public string Desc
        {
            get { return _desc; }
            set { _desc = value; }
        }
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private double _price;

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public Book()
        {
            this.Desc = "Default Book";
            this.Id = 0;
            this.Price = 0.0;

        }
        public Book(string desc, int id, double price)
        {
            this.Desc = desc;
            this.Id = id;
            this.Price = price;

        }
        public virtual double CalculatePrice()
        {
            return this.Price;

        }

        public abstract void Display();


    }
    }
