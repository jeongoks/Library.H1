using System;
using System.Collections.Generic;
using System.Text;

namespace Library.H1
{
    public class Library
    {
        private string libraryName;
        private List<Loanee> loanees;
        private List<Book> books;

        public List<Loanee> Loanees
        {
            get
            {
                return loanees;
            }
        }
        public List<Book> Books
        {
            get
            {
                return books;
            }
        }

        /// <summary>
        /// Constructor where we're initializing our Fields.
        /// </summary>
        /// <param name="name"></param>
        public Library(string name)
        {
            libraryName = name;
            loanees = new List<Loanee>();
            books = new List<Book>();
        }        

        /// <summary>
        /// Getting information about a library. Its name and what the Date is Now.
        /// </summary>
        /// <returns></returns>
        public string GetLibrary()
        {
            Console.Clear();
            return $"Welcome to {libraryName}. The date is {DateTime.Now.ToShortDateString()}.\n";
        }

        /// <summary>
        /// Creating a Loanee and letting the user enter the ID, Name and Email in the Console.
        /// </summary>
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
        }

        /// <summary>
        /// Getting information about a specific Loanee, printing out ID, Email and the Name.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Returns a string with Loanee ID, Email and Name</returns>
        public string GetLoanee(int id)
        {
            Loanee firstLoanee = loanees.Find(item => item.LoaneeNumber == id);
            return $"LoaneeNumber: {firstLoanee.LoaneeNumber}. LoaneeEmail: {firstLoanee.Email}. LoaneeName: {firstLoanee.Name}.";
        }

        /// <summary>
        /// Getting all Loanees printed out in a List, seperated with a new line, so they stand beneath one another.
        /// </summary>
        public void GetAllLoanees()
        {
            Console.Clear();
            Console.WriteLine($"Here is a list of all the Loanees:\n");
            foreach (var loanee in loanees)
            {
                Console.WriteLine($"{GetLoanee(loanee.LoaneeNumber)}");
            }
        }

        /// <summary>
        /// Creating a Book, allowing the user in the Console to type in the Book Title, Book Author and the Book ISBN Number. 
        /// Lastly adding a new Book to the Book class, with the local variables.
        /// </summary>
        public void CreateABook()
        {
            Console.Clear();

            Console.WriteLine("Enter the Book's title here:");
            string bookTitle = Console.ReadLine();

            Console.WriteLine("Enter the Book's author here:");
            string bookAuthor = Console.ReadLine();

            Console.WriteLine("Enter the Book's ISBN number here:");
            string bookIsbn = Console.ReadLine();

            books.Add(new Book(bookTitle, bookAuthor, bookIsbn));
            Console.Clear();
        }

        /// <summary>
        /// Getting a book and returning it through a string.
        /// </summary>
        /// <param name="isbn"></param>
        /// <returns>A string stating the Title, Author and ISBN number of a book.</returns>
        public string GetBook(string isbn)
        {
            Book gettingbook = books.Find(item => item.IsbnNumber == isbn);
            return $"The title of the Book: {gettingbook.Title}.\nThe Book's Author: {gettingbook.Author}.\nISBN number of the Book: {gettingbook.IsbnNumber}.";
        }

        /// <summary>
        /// Getting all Books printed out in a List, seperated with a new line.
        /// </summary>
        public void GetAllBooks()
        {
            Console.Clear();
            Console.WriteLine($"Here is a list of all the Books:\n");
            foreach (var book in books)
            {
                Console.WriteLine($"{GetBook(book.IsbnNumber)}\n");
            }
        }
    }
}
