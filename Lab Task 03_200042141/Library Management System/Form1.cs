using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class Form1 : Form
    {
        List<User> users = new List<User>();
        List<Book> books = new List<Book>();
        public Form1()
        {
            InitializeComponent();
        }

        private void AddUserOnClick_Click(object sender, EventArgs e)
        {
            int userid = Convert.ToInt32(UserIdBox.Text);
            string name = NameBox.Text;
            string address = AddressBox.Text;

            User dummy_user = new User(userid, name, address);

            users.Add(dummy_user);

            MessageBox.Show("User has been added successfully!");
        }

        private void AddBookOnClick_Click(object sender, EventArgs e)
        {
            int bookid = Convert.ToInt32(BookIdBox.Text);
            string bookname = BookNameBox.Text;
            string author = AuthorBox.Text;
            string publisher = PublisherBox.Text;
            int quantity = Convert.ToInt32(QuantityBox.Text);

            if(quantity<0)
            {
                MessageBox.Show("Quantity cannot be negative.");
                return;
            }

            Book dummy_book = new Book(bookid, bookname, author, publisher, quantity);

            books.Add(dummy_book);

            MessageBox.Show("Book has been added successfully!");
        }

        private void ShowBookHistoryOnClick_Click(object sender, EventArgs e)
        {
            int bookid = Convert.ToInt32(BookIdHistoryBox.Text);
            bool flag = false;

            foreach(Book book in books)
            {
                if(book.bookid == bookid)
                {
                    flag = true;
                    BookIdLabel.Text = book.bookid.ToString();
                    BookNameLabel.Text = book.bookname;
                    AuthorLabel.Text = book.author;
                    PublisherLabel.Text = book.publisher;
                    QuantityLabel.Text = book.quantity.ToString();
                }
            }

            if(flag == false)
            {
                MessageBox.Show("Book could not be found!");
            }
        }

        

        private void BorrowBookOnClick_Click(object sender, EventArgs e)
        {
            int userid = Convert.ToInt32(UserIdBorrowBox.Text);
            int bookid = Convert.ToInt32(BookIdBorrowBox.Text);

            //if (bookExists(bookid) && userExists(userid))
            //{
                foreach(Book book in books)
                {
                    if(book.bookid == bookid)
                    {
                        if(book.quantity<1)
                        {
                            MessageBox.Show("Out of Stock :(");
                            break;
                        }

                        book.quantity -= 1;

                        foreach(User user in users)
                        {
                            if(user.userid == userid)
                            {
                                user.books.Add(bookid);
                                MessageBox.Show("Book has been added to the user.");
                            }
                        }
                        break;
                    }
                }
            //}

            //else
            //{
            //    MessageBox.Show("Invalid Input.");
            //}
        }

        private void ShowUserHistoryOnClick_Click(object sender, EventArgs e)
        {
            int userid = Convert.ToInt32(UserIdHistoryBox.Text);
            User dummy = new User();
            bool flag = false;
            foreach(User user in users)
            {
                if(user.userid == userid)
                {
                    flag = true;
                    dummy = user;
                    break;
                }
            }

            if(flag == false)
            {
                MessageBox.Show("User could not be found!");
            }

            UserHistoryList.Items.Clear();

            for(int i = 0; i<dummy.books.Count; i++)
            {
                int id_book = dummy.books[i];
                for(int j = 0; j<books.Count; j++)
                {
                    if(books[j].bookid == id_book)
                    {
                        UserHistoryList.Items.Add(books[j].UserHistory());
                    }
                }
            }
        }
    }
}
