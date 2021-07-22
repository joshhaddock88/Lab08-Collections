using Lab08Collections.interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08Collections.classes
{
  public class Library : ILibrary
  {
    public int Count;

    public void CreateBook()
    {
      Book book = new Book();
      Add(book.Title, book.FirstName, book.LastName, book.BookLength);
    }

    public void Add(string title, string firstName, string lastName, int numberOfPages)
    {
      Book book = new Book();
    }

    public Book Borrow(string title)
    {
      throw new NotImplementedException();
    }

    public IEnumerator<Book> GetEnumerator()
    {
      throw new NotImplementedException();
    }

    public void Return(Book book)
    {
      throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      throw new NotImplementedException();
    }
  }
}
