using System;

namespace Library.H1
{
    class Program
    {
        static string menuSelect;
        static Library lib = new Library("Sønderborg library");

        static void Main(string[] args)
        {
            // Adding 10 Loanees to the Library.
            for (int i = 0; i < 10; i++)
            {
                lib.Loanees.Add(new Loanee(i, $"Loanee{i}", $"Loanee{i}@mail.dk"));
            }

            // Adding 10 Books to the Library.
            for (int i = 0; i < 10; i++)
            {
                lib.Books.Add(new Book($"Title{i}", $"Author{i}", $"#{i}ISBNNR"));
            }

            while (menuSelect != "6")
            {
                Console.Clear();
                Menu();
            }
            
        }
         /// <summary>
         /// This is the Menu in our Console.
         /// </summary>
         /// <returns>The switch-case for the Menu</returns>
        public static string Menu()
        {
            Console.WriteLine("Please select one of the following:");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("1. Show library and current date.\n2. Create Loanee.\n3. Print all Loanees.\n4. Create a Book.\n5. Get all Books.\n6. Exit program.");
            menuSelect = Console.ReadLine();

            switch (menuSelect)
            {
                case "1":
                    Console.WriteLine(lib.GetLibrary());
                    Console.WriteLine("Please press Enter to return to menu.\n");
                    Console.ReadLine();
                    break;
                case "2":
                    lib.CreateLoanee();
                    Console.WriteLine("Please press Enter to return to menu.\n");
                    Console.ReadLine();
                    break;
                case "3":
                    lib.GetAllLoanees();
                    Console.WriteLine("Please press Enter to return to menu.\n");
                    Console.ReadLine();
                    break;
                case "4":
                    lib.CreateABook();
                    Console.WriteLine("Please press Enter to return to menu.\n");
                    Console.ReadLine();
                    break;
                case "5":
                    lib.GetAllBooks();
                    Console.WriteLine("Please press Enter to return to menu.\n");
                    Console.ReadLine();
                    break;
                case "6":
                    break;
            }
            return menuSelect;
        }
    }
}