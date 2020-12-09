using System;
using System.Collections.Generic;
using System.Text;

namespace Library.H1
{
    public class Library
    {
        private string libraryName;
        private List<Loanee> loanees;

        public Library(string name)
        {
            libraryName = name;
            loanees = new List<Loanee>();
        }        

        public string GetLibrary()
        {
            return $"Welcome to {libraryName}. The date is {DateTime.Now.ToShortDateString()}.\n";
        }

        public void CreateLoanee()
        {
            Console.Clear();
            int result = 0;
            do
            {
                Console.WriteLine("Enter Loanees ID number here:");
            } while (! int.TryParse(Console.ReadLine(), out result));

            Console.WriteLine("Enter Loanees Name here:");
            string loaneeName = Console.ReadLine();

            Console.WriteLine("Enter Loanees Email here:");
            string loaneeEmail = Console.ReadLine();

            loanees.Add(new Loanee(result, loaneeName, loaneeEmail));
            Console.Clear();

        }

        public string GetLoanee(int id)
        {
            Loanee firstLoanee = loanees.Find(item => item.LoaneeNumber == id);
            return $"LoaneeNumber: {firstLoanee.LoaneeNumber}. LoaneeEmail: {firstLoanee.Email}. {firstLoanee.Name} is a Loanee at {libraryName}.";
        }

        public void GetAllLoanees()
        {
            Console.WriteLine($"Here is a list of all the Loanees:\n");
            foreach (var loanee in loanees)
            {
                Console.WriteLine($"{GetLoanee(loanee.LoaneeNumber)}");
            }
        }
    }
}
