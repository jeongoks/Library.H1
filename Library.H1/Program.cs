using System;

namespace Library.H1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a Library and writing out the Date of time.
            Library library = new Library("Sønderborg library");
            Console.WriteLine(library.GetLibrary());

            // Creating the Loanee and getting their information.
            library.CreateLoanee(1, "Michael");
            Console.WriteLine(library.GetLoanee());


        }
    }
}
