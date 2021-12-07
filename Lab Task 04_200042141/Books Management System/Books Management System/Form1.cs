using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Books_Management_System
{
    public partial class Form1 : Form
    {
        List<StudyBook> books = new List<StudyBook>();
        List<Article> articles = new List<Article>();
        public Form1()
        {
            InitializeComponent();
        }

        private void AddStudyBookButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(StudyBookIdBox.Text);
            string title = StudyBookTitleBox.Text;
            string author = StudyBookAuthorBox.Text;
            string publisher = StudyBookPublisherBox.Text;
            string genre = GenreBox.Text;
            string isbn = IsbnBox.Text;
            int quantity = Convert.ToInt32(StudyBookQtyBox.Text);

            if (quantity < 0)
            {
                MessageBox.Show("Quantity cannot be negative.");
                return;
            }

            StudyBook dummy = new StudyBook(id, title, author, isbn, quantity);

            books.Add(dummy);

            MessageBox.Show("Study Book has been added successfully!");
        }

        private void AddResearchArticleButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ArticleIdBox.Text);
            string title = ArticleTitleBox.Text;
            string author = ArticleAuthorBox.Text;
            string publisher = ArticlePublisherBox.Text;
            string doi = DoiBox.Text;
            string corj = CorJBox.Text;
            int quantity = Convert.ToInt32(ArticleQtyBox.Text);

            Article dummy = new Article(id, title, author, doi, quantity, corj);

            articles.Add(dummy);

            MessageBox.Show("Research Article has been added successfully!");
        }

        private void StudyBookBorrowButton_Click(object sender, EventArgs e)
        {
            int studybookid = Convert.ToInt32(StudyBookBorrowBox.Text);

            foreach (StudyBook studybook in books)
            {
                if (studybook.id == studybookid)
                { 
                    studybook.quantity -= 1;
                }
            }

            MessageBox.Show("Study Book has been borrowed.");
        }

        private void ArticleBorrowButton_Click(object sender, EventArgs e)
        {
            int articleid = Convert.ToInt32(ArticleBorrowBox.Text);

            foreach (Article article in articles)
            { 
                if (article.id == articleid)
                {
                    article.quantity -= 1;
                }
            }

            MessageBox.Show("Researh Article has been borrowed.");
        }

        private void ShowStudyBooksListButton_Click(object sender, EventArgs e)
        {
            StudyBooksList.Items.Clear();
            for (int i = 0; i < books.Count; i++)
            {
                StudyBooksList.Items.Add(books[i].getInfo());
            }
        }

        private void ShowResearchArticlesListButton_Click(object sender, EventArgs e)
        {
            ResearchArticlesList.Items.Clear();
            for (int i = 0; i < articles.Count; i++)
            {
                ResearchArticlesList.Items.Add(articles[i].getInfo());
            }
        }
    }
}
