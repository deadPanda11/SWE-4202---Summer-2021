using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Management_System
{
    internal class StudyBook: Book
    {
        public string isbn;
        public string genre;

        public StudyBook(int id,string title,string author,string isbn,int quantity)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.isbn = isbn;
            this.quantity = quantity;
        }

        public string getInfo()
        {
            string studybook = id + "\t" + title + "\t" + author + "\t" + isbn + "\t" + quantity;
            return studybook;
        }
    }
}
