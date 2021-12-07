using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Management_System
{
    internal class Article: Book
    {
        public string doi;
        public string corj;

        public Article(int id, string title, string author, string doi, int quantity, string corj)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.doi = doi;
            this.quantity = quantity;
            this.corj = corj;
        }

        public string getInfo()
        {
            string article = id + "\t" + title + "\t" + author + "\t" + doi + "\t" + quantity + "\t" + corj;
            return article;
        }
    }
}
