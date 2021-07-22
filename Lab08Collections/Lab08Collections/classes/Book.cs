using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08Collections.classes
{
  public class Book
  {
    public string Title { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int BookLength { get; set; }

    public Book()
    {
      Console.Write("Title: ");
      Title = Console.ReadLine();
      Console.Write("Author first name: ");
      FirstName = Console.ReadLine();
      Console.Write("Author last name: ");
      LastName = Console.ReadLine();
      Console.Write("Number of pages: ");
      BookLength = Convert.ToInt32(Console.ReadLine());
    }
  }
}
