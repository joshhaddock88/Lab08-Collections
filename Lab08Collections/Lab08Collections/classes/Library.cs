using Lab08Collections.interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08Collections.classes
{
    public class Library : ILibrary
    {
        private readonly Dictionary<string, Book> books = new Dictionary<string, Book>();
        public int Count => books.Count;

        public void Add(string title, string firstName, string lastName, int numberOfPages)
        {
            Book book = new Book
            {
                Title = title,
                BookLength = numberOfPages,
                Author = new Author
                {
                    FirstName = firstName,
                    LastName = lastName
                }
            };

            books.Add(title, book);
        }

        public Book Borrow(string title)
        {
            if (!books.ContainsKey(title))
            {
                return null;
            }
            //find book and save in a ariable
            Book book = books[title];
            //remove book from library
            books.Remove(title);
            //return book
            return book;
        }

        public void Return(Book book)
        {
            books.Add(book.Title, book);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            foreach(Book book in books.Values)
            {
                yield return book;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
