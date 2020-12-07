using System;
using System.Collections.Generic;
using System.Text;

namespace Library.H1
{
    public class Library
    {
        private string libraryName;

        public Library(string name)
        {
            libraryName = name;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string GetLibrary()
        {
            return $"Welcome to {libraryName}. The date is {DateTime.Now.ToShortDateString()}.";
        }
    }
}
