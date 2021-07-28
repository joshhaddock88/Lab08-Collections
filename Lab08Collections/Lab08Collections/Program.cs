using Lab08Collections.classes;
using System;

namespace Lab08Collections
{
    class Program
    {
        private static readonly classes.Library library = new();
        private static readonly classes.Satchel<Book> satchel = new();
        static void Main(string[] args)
        {
            LoadLibrary();
            UserInterface();
        }

        static void LoadLibrary()
        {
            library.Add("Guide to Craps", "John", "Cokos", 44);
            library.Add("Coding for Dummies", "Code", "Whisperer", 1);
            library.Add("Star Trek vs Star Wars", "Darth", "Picard", 10);
        }

        static void UserInterface()
        {
            while(true)
            {
                Console.WriteLine("Welcome to Library");
                Console.WriteLine("==================");
                Console.WriteLine("Pick an option Below");
                Console.WriteLine("==================");
                Console.WriteLine("1. View All Books");
                Console.WriteLine("2. Add New Book");
                Console.WriteLine("3. Borrow a Book");
                Console.WriteLine("4. Return a Book");
                Console.WriteLine("5. View My Satchel");
                Console.WriteLine("6. Exit");
                Console.WriteLine("");

                string choice = Console.ReadLine();

                switch(choice)
                {
                    case "1":
                        ShowLibrary();
                        break;
                    case "2":
                        AddBook();
                        break;
                    case "3":
                        BorrowBook();
                        break;
                    case "4":
                        ReturnBook();
                        break;
                    case "5":
                        BookInSatchel();
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Invalid Options");
                        Console.WriteLine();
                        break;
                }
            }
        }

        static void ShowLibrary()
        {
            Console.Clear();
            Console.WriteLine("Library...");
            Console.WriteLine("============");
            Console.WriteLine();
            int counter = 1;
            foreach( Book book in library)
            {
                Console.WriteLine($"{counter++}. {book}");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }

        static void AddBook()
        {
            Console.Clear();
            Console.WriteLine("Add Book");
            Console.WriteLine("============");

            Console.WriteLine();
            Console.Write("Book Title: ");
            string title = Console.ReadLine();

            Console.WriteLine();
            Console.Write("Author First Name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine();
            Console.Write("Author Last name: ");
            string lastName = Console.ReadLine();
            
            Console.WriteLine();
            Console.Write("Number of Pages: ");
            string pages = Console.ReadLine();
            int.TryParse(pages, out int numPages);

            library.Add(title, firstName, lastName, numPages);
        }

        static void BorrowBook()
        {
            Console.Clear();
            Console.WriteLine("Borrow a Book");
            Console.WriteLine("============");
            foreach (Book book in library )
            {
                Console.WriteLine(book);
            }

            Console.WriteLine();
            Console.Write("Enter Book Title(exactly):");
            string selection = Console.ReadLine();

            Book borrowed = library.Borrow(selection);

            satchel.Pack(borrowed);
        }

        static void ReturnBook()
        {
            Console.Clear();
            Console.WriteLine("Return Book");
            Console.WriteLine("============");

            int counter = 1;
            foreach(Book book in satchel)
            {
                Console.WriteLine($"{counter++}. {book}");
            }

            Console.WriteLine("Which book to Return?");
            int selection = Convert.ToInt32(Console.ReadLine()) - 1;

            Book bookToReturn = satchel.Unpack(selection);

            library.Return(bookToReturn);
        }

        static void BookInSatchel()
        {
            Console.Clear();
            Console.WriteLine("Satchel...");
            Console.WriteLine("============");
            Console.WriteLine();
            int counter = 1;
            foreach (Book book in satchel)
            {
                Console.WriteLine($"{counter++}. {book}");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
