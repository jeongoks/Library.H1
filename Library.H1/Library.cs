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
            return $"Welcome to {libraryName}. The date is {DateTime.Now.ToShortDateString()}.";
        }

        public string CreateLoanee(int loaneeNumber, string loaneeName)
        {
            loanees.Add(new Loanee(loaneeNumber, loaneeName));
            return $"A loanee has been added with the ID: {loaneeNumber} and with the name: {loaneeName}";
        }

        public string GetLoanee(int id)
        {
            Loanee firstLoanee = loanees.Find(item => item.LoaneeNumber == id);
            return $"LoaneeNumber: {firstLoanee.LoaneeNumber}. {firstLoanee.LoaneeName} is a Loanee at {libraryName}.";
        }
    }
}
