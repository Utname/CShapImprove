using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShapImprove
{
    internal class Book
    {
        private string title { get; set; }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        private string author { get; set; }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        private int quantity { get; set; }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        private string isbn { get; set; }
        public string Isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }
        private int availableQuantity {get;set;}
        public int AvailableQuantity
        {
            get { return availableQuantity; }
            set { availableQuantity = value; }
        }

        public Book(string title, string author, int quantity, string isbn, int availableQuantity)
        {
            this.Title = title;
            this.Author = author;
            this.Quantity = quantity;
            this.Isbn = isbn;
            this.AvailableQuantity = availableQuantity;
        }

        public void displayInfoBook()
        {
            Console.WriteLine($"title:{Title}, author:{Author}, quantity:{Quantity}, isbn:{Isbn}, availableQuantity:{AvailableQuantity}");
        }
    }
}
