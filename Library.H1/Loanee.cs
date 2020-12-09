using System;
using System.Collections.Generic;
using System.Text;

namespace Library.H1
{
    public class Loanee : Person
    {
        private int loaneeNumber;

        public int LoaneeNumber
        {
            get { return loaneeNumber; }
        }

        public Loanee(int number, string name, string email)
        {
            loaneeNumber = number;
            Name = name;
            Email = email;
        }
    }
}
