using LibraryManagementSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryGUI
{
    public partial class GenerateReport : Form
    {
        private Library library;
        public GenerateReport()
        {
            InitializeComponent();
            library = new Library();
        }

        private void btnPopularBooks_Click(object sender, EventArgs e)
        {
            var popularBooks = FirstGUI.library.borrowingHistory.GetBorrowedBooks()
                .GroupBy(b => b.Book)
                .OrderByDescending(g => g.Count())
                .Take(5)
                .Select(g => g.Key);
            string message = "";
            message += "Popular Books Report:\n";
            message += "----------------------\n";
            foreach(var book in popularBooks)
            {
                message += $"Title: {book.Title}, Author:{book.Author}, Publication Year: {book.PublicationYear}, Borrowing count: {FirstGUI.library.borrowingHistory.GetBorrowedBooks().Count(b => b.Book == book)}\n";
            }
            message += "\n";

            MessageBox.Show($"{message}", "Popular Books", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLibraryStats_Click(object sender, EventArgs e)
        {
            var library = FirstGUI.library;
            var totalBooks = library.Books.Count;
            var availableBooks = library.Books.Count(b => b.IsBorrowed);
            var borrowedBooks = library.borrowingHistory.GetBorrowedBooks().Count;
            var ActiveUser = library.Users.Count(u => u.IsActive);
            MessageBox.Show($"Total Books: {totalBooks}\n Available Books: {availableBooks}\n Borrowed Books: {borrowedBooks}\n Active Users: {ActiveUser}", "Library Statistics Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var back = new MainLibraryGUI();
            back.Show();
            Hide();
        }

        private void btnActiveUsers_Click(object sender, EventArgs e)
        {
            var users = FirstGUI.library.users;
            string list = "";
            var activeUsers = library.Users.Where(u => u.IsActive).OrderByDescending(u => u.BorrowedBooks.Count);
            foreach (var user in activeUsers)
            {
                list += ($"Name: {user.Name}, Email: {user.Email}, Borrowed Books: {user.BorrowedBooks.Count}\n");
            }
            MessageBox.Show($"{list}", "Active Users Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
