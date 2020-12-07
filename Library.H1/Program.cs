using System;

namespace Library.H1
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library("Sønderborg library");
            Console.WriteLine(library.GetLibrary());
        }
    }
}
