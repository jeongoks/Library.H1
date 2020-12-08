using System;
using System.Collections.Generic;
using System.Text;

namespace Library.H1
{
    public class Library
    {
        private string libraryName;
        private Loanee loanee;

        public Library(string name)
        {
            libraryName = name;
        }

        public string GetLibrary()
        {
            return $"Welcome to {libraryName}. The date is {DateTime.Now.ToShortDateString()}.";
        }

        public void CreateLoanee(int loaneeNumber, string loaneeName)
        {
            loanee = new Loanee(loaneeNumber, loaneeName);
        }

        public string GetLoanee()
        {
            return $"LoaneeNumber: {loanee.LoaneeNumber}. {loanee.LoaneeName} is a Loanee at {libraryName}.";
        }
    }
}
