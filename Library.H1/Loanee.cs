using System;
using System.Collections.Generic;
using System.Text;

namespace Library.H1
{
    public class Loanee
    {
        private int loaneeNumber;
        private string loaneeName;

        public int LoaneeNumber
        {
            get { return loaneeNumber; }
        }
        public string LoaneeName
        {
            get { return loaneeName; }
        }

        public Loanee(int number, string name)
        {
            loaneeNumber = number;
            loaneeName = name;
        }
    }
}
