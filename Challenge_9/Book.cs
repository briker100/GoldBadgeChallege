using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_9
{
    public class Book
    {
        public Book() { }

        public Book(string author, string title, double price)
        {
            Author = author;
            Title = title;
            Price = price;
        }

        //Fields
        private string _author;
        private string _title;
        private double _price;

        //Constructors

        //Properties
        public string Title
        {

            get => _title;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Hey You Need A value For That Title");
                _title = value;
            }
        }

        public string Author
        {
            get { return _author; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Hey You Need To Put In A Author For The Book");
                _author = value;
            }
        }
        public double Price
        {
            get => _price;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("The Book Cant Be Less Than 0");
                _price = value;
            }
        }
      
    }
}
