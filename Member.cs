using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShapImprove
{
    internal class Member : Library
    {
        public List<Book> bookBorrows { get; set; }
        private string id { get; set; }
        public string Id
        {
            get { return id; } set { id = value; }
        }
        private string name { get; set; }
        public string Name
        {
            get { return name; } set { name = value; }
        }
        public Member(string id,string name)
        {
            this.id = id;
            this.Name = name;
        }

        public void displayInfo()
        {
            Console.WriteLine($"id:{Id} - name:{Name}");
            printListBookNew(this.bookBorrows);
        }

        public void printListBookNew(List<Book> bookBorrows)
        {
            Console.WriteLine("---List book to search---");
            foreach (Book book in bookBorrows)
            {
                book.displayInfoBook();
            }
        }

        public void borrowBook(bookBorrow bookBorrow,List<Book> list_book)
        {
            if(bookBorrows == null)
            {
                books = list_book;
            }
            var book = books.FirstOrDefault(q=>q.Isbn == bookBorrow.Isbn);
            var checkQuantity = checkQuantityBook(book.Quantity, bookBorrow.quantity);
            if (!checkQuantity)
            {
                book.Quantity = caculateBookBorrow(book.Quantity, bookBorrow.quantity);
                Book bookOfUserBorrow = new Book(book.Title, book.Author, bookBorrow.quantity, book.Isbn, book.AvailableQuantity);
                bookBorrows = new List<Book> {};
                bookBorrows.Add(bookOfUserBorrow);
            }
            displayInfo();
        }

        public void returnBorrowBook(bookBorrow bookReturnBorrow)
        {

            var book = books.FirstOrDefault(q => q.Isbn == bookReturnBorrow.Isbn);
            // var checkQuantity = checkQuantityBook(book.Quantity, bookReturnBorrow.quantity);
            book.Quantity = caculateBookReturn(book.Quantity, bookReturnBorrow.quantity);
            var bookReturn = bookBorrows.FirstOrDefault(q => q.Isbn == bookReturnBorrow.Isbn);
            bookReturn.Quantity -= bookReturnBorrow.quantity;
            displayInfo();
        }

        public bool checkQuantityBook(int quantity,int quantityBorrow)
        {
            if(quantity < quantityBorrow)
            {
                Console.WriteLine("Do't have enought for quantity!!!");
                return true;
            }
            return false;
        }

        public bool checkQuantityBookReturn(int quantity, int quantityBorrow)
        {
            if (quantity < quantityBorrow)
            {
                Console.WriteLine("Do't have enought for quantity!!!");
                return true;
            }
            return false;
        }


        public int caculateBookBorrow(int quantity, int quantityBorrow)
        {
            return quantity - quantityBorrow;
        }
        public int caculateBookReturn(int quantity, int quantityReturnBorrow)
        {
            return quantity + quantityReturnBorrow;
        }
    }
}
