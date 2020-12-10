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

        /// <summary>
        /// Constructor where we initialize our Fields for the Loanee Class. We use these to Create and Get a Loanee over in Library.
        /// </summary>
        /// <param name="number">ID of a Loanee.</param>
        /// <param name="name">Name of a Loanee.</param>
        /// <param name="email">Email of a Loanee</param>
        public Loanee(int number, string name, string email)
        {
            loaneeNumber = number;
            Name = name;
            Email = email;
        }
    }
}
