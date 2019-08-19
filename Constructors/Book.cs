using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors
{
    class Book
    {
        private string title;
        private string author;
        private int pages;

        public Book(string aTitle, string aAuthor, int aPages)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }

        public string Title
        {
            get { return title; }
        }

        public string Author
        {
            get { return author; }
        }

        public int Pages
        {
            get { return pages; }
        }
    }
}
