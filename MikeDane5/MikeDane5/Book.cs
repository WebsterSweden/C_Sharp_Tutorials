using System;
using System.Collections.Generic;
using System.Text;

namespace MikeDane5
{
    class Book
    {
        public string title;
        public string author;
        public int pages;

        public Book(string titleParameter, string authorParameter, int pagesParameter)
        {
            title = titleParameter;
            author = authorParameter;
            pages = pagesParameter;
        }
    }
}
