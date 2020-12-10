using System;
using System.Collections.Generic;
using System.Text;

namespace Library.H1
{
    public class Book
    {
        // Auto-properties for Book-class.
        public string Title { get; set; }
        public string Author { get; set; }
        public string IsbnNumber { get; set; }
        public DateTime BookingDate { get; set; }
        public bool IsAvailable { get; set; }

        /// <summary>
        /// Constructor where we're initializing the fields for our Book Class, used for creating a Book over in the Library.
        /// </summary>
        /// <param name="title">Title of a Book</param>
        /// <param name="author">Author of a Book</param>
        /// <param name="isbnNumber">ISBN Number of a Book</param>
        public Book(string title, string author, string isbnNumber)
        {
            Title = title;
            Author = author;
            IsbnNumber = isbnNumber;
        }
    }
}
