using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace TestWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class BookService : IBookService
    {
        public List<Book> allBooks = new List<Book>();

        public List<Book> GetAllBooks()
        {
            allBooks.AddRange(new List<Book>(
               new[]{ 
                   new Book() { ID = "1", Author = "humayoun", Description = "good book", Genre = "Romantic", Price = 22.25m, PublishDate = new DateTime(2018,5,12,8,30,52), Title = "Himur biye" },
                   new Book() { ID = "2", Author = "kabir", Description = "good book", Genre = "Comedy", Price = 52.60m, PublishDate = new DateTime(2018,5,12,8,30,52), Title = "Himur shushur bari" },
                   new Book() { ID = "3", Author = "sohel", Description = "good book", Genre = "Thrill", Price = 80.32m, PublishDate = new DateTime(2018,5,12,8,30,52), Title = "Himur bashor ghor" }
               }
                ));

            return allBooks;
        }

        public Book GetBookByID(string BookID)
        {
            var selectedBook = (from book in GetAllBooks()
                           where book.ID.Equals(BookID)
                           select book).FirstOrDefault();
            return selectedBook;
        }

        public Book Filter(string Author, string Genre, string Title)
        {
            var selectedBook = (from book in GetAllBooks()
                                where book.Author.Equals(Author) && book.Genre.Equals(Genre) && book.Title.Equals(Title)
                                select book).FirstOrDefault();
            return selectedBook;
        }
    }
}
