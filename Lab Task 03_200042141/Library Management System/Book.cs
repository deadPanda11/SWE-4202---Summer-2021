using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    internal class Book
    {
        public int bookid;
        public string bookname;
        public string author;
        public string publisher;
        public int quantity;

        public Book(int bookid, string bookname, string author, string publisher, int quantity)
        {
            this.bookid = bookid;
            this.bookname = bookname;
            this.author = author;
            this.publisher = publisher;
            this.quantity = quantity;
        }

        public string UserHistory()
        {
            return this.bookid.ToString() + "\t" + this.bookname;
        }
    }
}
