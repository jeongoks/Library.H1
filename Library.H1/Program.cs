using System;

namespace Library.H1
{
    class Program
    {
        static string menuSelect;
        static Library lib = new Library("Sønderborg library");
        static void Main(string[] args)
        {
            while (menuSelect != "4")
            {
                Console.Clear();
                Menu();
            }
            
        }

        public static string Menu()
        {
            Console.WriteLine("Please select one of the following:\n1. Show library and current date.\n2. Create Loanee.\n3. Print all Loanees.\n4. Exit program.");
            menuSelect = Console.ReadLine();

            switch (menuSelect)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine(lib.GetLibrary());
                    Console.WriteLine("Please press Enter to return to menu.");
                    Console.ReadLine();
                    break;
                case "2":
                    Console.Clear();
                    lib.CreateLoanee();
                    Console.WriteLine("Please press Enter to return to menu.");
                    Console.ReadLine();
                    break;
                case "3":
                    Console.Clear();
                    lib.GetAllLoanees();
                    Console.WriteLine("Please press Enter to return to menu.");
                    Console.ReadLine();
                    break;
                case "4":
                    break;
            }
            return menuSelect;
        }
    }
}
