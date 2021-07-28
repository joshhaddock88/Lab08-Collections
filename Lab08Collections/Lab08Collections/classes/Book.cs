using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08Collections.classes
{
    public class Book
    {
        // Here we declare that class Book will have four properties.
        public string Title { get; set; }
        public Author Author { get; set; }
        public int BookLength { get; set; }

        public override string ToString()
        {
            return $"{Title} - {Author}";
        }
    }
}
