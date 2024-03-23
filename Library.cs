using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShapImprove
{
    struct bookBorrow
    {
        public string Isbn;
        public int quantity;

        public bookBorrow(string Isbn,int quantity)
        {
            this.Isbn = Isbn;
            this.quantity = quantity;
        }
    }
    internal class Library
    {
        public List<Book> books= new List<Book>();
        public void AddBook(Book book)
        {
            books.Add(book);
        }
        

        public void RemoveBook(string isbn)
        {
            Book book = books.FirstOrDefault(x => x.Isbn == isbn);
            books.Remove(book);
        }

        private Book getBook(string isnb)
        {
            var book = books.FirstOrDefault(x => x.Isbn == isnb);
            return book;
        }
        public void EditBook(Book book)
        {
            var result = getBook(book.Isbn);
            if (result != null)
            {
                result.Title = book.Title;
                result.Author = book.Author;
                result.Quantity = book.Quantity;
                result.AvailableQuantity = book.AvailableQuantity;
            }
            else notFoundBook();
        }

        public void notFoundBook()
        {
             Console.WriteLine("Not found book!!!");
        }

        public void printListBook()
        {
            Console.WriteLine("---List book to search---");
            foreach (Book book in books)
            {
                book.displayInfoBook();
            }
        }

        public void search(string search)
        {
            search = search.Trim().ToLower();
            var result = books.Where(q => q.Title.ToLower().Contains(search) || q.Author.ToLower().Contains(search) || q.Isbn.ToLower().Contains(search)).ToList();
            if (result.Count() > 0) printListBook();
            else notFoundBook();
        }

        public void memberBorrowBook()
        {
            Member member = new Member("01", "NguyenVanut");
            List<bookBorrow> listBorrowBooks = new List<bookBorrow>();
            listBorrowBooks.Add(new bookBorrow("b01", 2));
            listBorrowBooks.Add(new bookBorrow("b02",3));
            listBorrowBooks.ForEach(q =>
            {
                member.borrowBook(q);
            });
        }

    }
}
