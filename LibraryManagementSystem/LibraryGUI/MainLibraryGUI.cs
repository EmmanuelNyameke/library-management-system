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
    public partial class MainLibraryGUI : Form
    {
        private Library library;
        private BorrowingHistory borrowingHistory;
        public MainLibraryGUI()
        {
            InitializeComponent();
            library = new Library();
            borrowingHistory = new BorrowingHistory();
        }

        private void btnManageBooks_Click(object sender, EventArgs e)
        {
            var bookManagement = new ManageBooks();
            bookManagement.Show();
            Hide();
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            var ManageUsers = new ManageUsers();
            ManageUsers.Show();
            Hide();
        }

        private void btnBorrowReturn_Click(object sender, EventArgs e)
        {
            var borrow = new BorrowReturn();
            borrow.Show();
            Hide();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            var generateReport = new GenerateReport();
            generateReport.Show();
            Hide();
        }
    }
}

