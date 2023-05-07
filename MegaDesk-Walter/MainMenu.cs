using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Walter
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnAddNewQuote_Click(object sender, EventArgs e)
        {
            // Create form
            var addQuoteForm = new AddQuote();

            // Reference main menu
            addQuoteForm.Tag = this;

            // Show add quote form
            addQuoteForm.Show();

            // Hide main menu
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnViewQuote_Click(object sender, EventArgs e)
        {
            // Create form
            var viewQuotes = new ViewAllQuotes(this);

            // Show add quote form
            viewQuotes.Show();

            // Hide main menu
            this.Hide();
        }
    }
}
