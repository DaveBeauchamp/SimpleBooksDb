using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooksSingleTableDb
{
    public partial class frmMain : Form
    {
        // creating an instance of booksNAuthors accessable to the entire form
        List<BooksWithAuthorName> booksNAuthors;

        public frmMain()
        {
            InitializeComponent();

            // could have made this data instance available globally though just decided not too
            // Database class methods are available data.methodName();
            Database data = new Database();

            // seed database when the form runs
            data.SeedDatabase();

            // store the values from the GetAllBooksWithAuthors method to use as data source for the dgv
            // on form load
            booksNAuthors = data.GetAllBooksWithAuthors();
            dgvBookList.DataSource = null;
            dgvBookList.DataSource = booksNAuthors;

            // store the values from the GetAllAuthors method to use as data source for the comboBox
            // on form load
            var listOfAuth = data.GetAllAuthors();
            cboAuthor.DataSource = listOfAuth;
            cboAuthor.DisplayMember = "authorName";
            cboAuthor.ValueMember = "authorId";
        }

        #region AuthorAddEditButtons
        private void btnAuthorSave_Click(object sender, EventArgs e)
        {
            // Database class methods are available data.methodName() from this instance
            Database data = new Database();

            // if label value is "0" insert new author if not "0" update the author 
            // look in the Database class for more information on the methods used
            if (lblAuthorID.Text == "0")
            {
                try
                {
                    data.insertAuthor(txtAuthorName.Text);
                    lblAddEditStatus.Text = "Successfully added an Author";
                }
                catch 
                {
                    lblAddEditStatus.Text = "Something went wrong adding an Author";
                }
            }
            else
            {
                try
                {
                    data.updateAuthor(lblAuthorID.Text, txtAuthorName.Text);
                    lblAddEditStatus.Text = "Successfully updated an Author";
                }
                catch 
                {
                    lblAddEditStatus.Text = "Something went wrong updating an Author";
                }
            }
        }

        // clears the fields to basic values
        private void btnAuthorNew_Click(object sender, EventArgs e)
        {
            lblAuthorID.Text = "0";
            txtAuthorName.Text = string.Empty;
        }
        #endregion

        #region AuthorNavigationButtons
        private void btnAuthorFirst_Click(object sender, EventArgs e)
        {
            // Database class methods are available data.methodName() from this instance
            Database data = new Database();

            // look in the Database class for more information on the methods used
            try
            {
                var authorData = data.getFirstAuthor();
                lblAuthorID.Text = authorData.AuthorId.ToString();
                txtAuthorName.Text = authorData.AuthorName.ToString();
                lblAddEditStatus.Text = "First Author";
            }
            catch 
            {
                lblAddEditStatus.Text = "Could not find first Author";
            }
        }

        private void btnAuthorLast_Click(object sender, EventArgs e)
        {
            // Database class methods are available data.methodName() from this instance
            Database data = new Database();

            // look in the Database class for more information on the methods used
            try
            {
                var authorData = data.getLastAuthor();
                lblAuthorID.Text = authorData.AuthorId.ToString();
                txtAuthorName.Text = authorData.AuthorName.ToString();
                lblAddEditStatus.Text = "Last Author";
            }
            catch
            {
                lblAddEditStatus.Text = "Could not find last Author";
            }
        }

        private void btnAuthorPrevious_Click(object sender, EventArgs e)
        {
            // Database class methods are available data.methodName() from this instance
            Database data = new Database();

            // look in the Database class for more information on the methods used
            try
            {
                var authorData = data.getPreviousAuthor(lblAuthorID.Text);
                lblAuthorID.Text = authorData.AuthorId.ToString();
                txtAuthorName.Text = authorData.AuthorName.ToString();
                lblAddEditStatus.Text = "Previous Author";
            }
            catch
            {
                lblAddEditStatus.Text = "This is the first Author";
            }
        }

        private void btnAuthorNext_Click(object sender, EventArgs e)
        {
            // Database class methods are available data.methodName() from this instance
            Database data = new Database();

            // look in the Database class for more information on the methods used
            try
            {
                var authorData = data.getNextAuthor(lblAuthorID.Text);
                lblAuthorID.Text = authorData.AuthorId.ToString();
                txtAuthorName.Text = authorData.AuthorName.ToString();
                lblAddEditStatus.Text = "Next Author";
            }
            catch
            {
                lblAddEditStatus.Text = "This is the last Author";
            }
        }
        #endregion

        #region BookAddEditButtons
        private void btnBookSave_Click(object sender, EventArgs e)
        {
            // Database class methods are available data.methodName() from this instance
            Database data = new Database();

            // if label value is "0" insert new book if not "0" update the book
            // look in the Database class for more information on the methods used
            if (lblBookEditID.Text == "0")
            {
                try
                {
                    data.InsertBook(txtBookTitle.Text, txtBookGenre.Text, cboAuthor.SelectedValue.ToString());
                    lblAddEditStatus.Text = "Successfully added an Book";
                }
                catch 
                {
                    lblAddEditStatus.Text = "Something went wrong adding an Book";
                }       
            }
            else
            {
                try
                {
                    data.updateBooks(txtBookTitle.Text, txtBookGenre.Text, cboAuthor.SelectedValue.ToString(), lblBookEditID.Text);
                    lblAddEditStatus.Text = "Successfully updated an Book";
                }
                catch 
                {
                    lblAddEditStatus.Text = "Something went wrong updating an Book";
                }
            }
        }

        // clears the fields to basic values
        private void btnBookNew_Click(object sender, EventArgs e)
        {
            lblBookEditID.Text = "0";
            txtBookTitle.Text = string.Empty;
            txtBookGenre.Text = string.Empty;
            cboAuthor.SelectedValue = string.Empty; // not sure if this will break the combo box  
        }

        // click event to refresh the comboBox values (if an author has been added you will always 
        // have an up  to date list)
        private void cboAuthor_Click(object sender, EventArgs e)
        {
            Database data = new Database();
            var listOfAuth = data.GetAllAuthors();
            cboAuthor.DataSource = listOfAuth;
            cboAuthor.DisplayMember = "authorName";
            cboAuthor.ValueMember = "authorId";
        }
        #endregion

        #region BookNavigationButtons
        private void btnBookFirst_Click(object sender, EventArgs e)
        {
            // Database class methods are available data.methodName() from this instance
            Database data = new Database();

            // look in the Database class for more information on the methods used
            try
            {
                var bookData = data.getFirstBookAndAuthor();
                lblBookEditID.Text = bookData.BookId.ToString();
                txtBookTitle.Text = bookData.BookTitle.ToString();
                txtBookGenre.Text = bookData.BookGenre.ToString();
                cboAuthor.Text = bookData.AuthorName.ToString();

                lblAddEditStatus.Text = "First Book";
            }
            catch
            {
                lblAddEditStatus.Text = "Could not find first Book";
            }
        }

        private void btnBookLast_Click(object sender, EventArgs e)
        {
            // Database class methods are available data.methodName() from this instance
            Database data = new Database();

            // look in the Database class for more information on the methods used
            try
            {
                var bookData = data.getLastBookAndAuthor();
                lblBookEditID.Text = bookData.BookId.ToString();
                txtBookTitle.Text = bookData.BookTitle.ToString();
                txtBookGenre.Text = bookData.BookGenre.ToString();
                cboAuthor.Text = bookData.AuthorName.ToString();

                lblAddEditStatus.Text = "Last Book";
            }
            catch
            {
                lblAddEditStatus.Text = "Could not find last Book";
            }
        }

        private void btnBookPrev_Click(object sender, EventArgs e)
        {
            // Database class methods are available data.methodName() from this instance
            Database data = new Database();

            // look in the Database class for more information on the methods used
            try
            {
                var bookData = data.getPreviousBookAndAuthor(lblBookEditID.Text);
                lblBookEditID.Text = bookData.BookId.ToString();
                txtBookTitle.Text = bookData.BookTitle.ToString();
                txtBookGenre.Text = bookData.BookGenre.ToString();
                cboAuthor.Text = bookData.AuthorName.ToString();

                lblAddEditStatus.Text = "Previous Book";
            }
            catch
            {
                lblAddEditStatus.Text = "This is the first Book";
            }
        }

        private void btnBookNext_Click(object sender, EventArgs e)
        {
            // Database class methods are available data.methodName() from this instance
            Database data = new Database();

            // look in the Database class for more information on the methods used
            try
            {
                var bookData = data.getNextBookAndAuthor(lblBookEditID.Text);
                lblBookEditID.Text = bookData.BookId.ToString();
                txtBookTitle.Text = bookData.BookTitle.ToString();
                txtBookGenre.Text = bookData.BookGenre.ToString();
                cboAuthor.Text = bookData.AuthorName.ToString();

                lblAddEditStatus.Text = "Next Book";
            }
            catch
            {
                lblAddEditStatus.Text = "This is the last Book";
            }
        }
        #endregion

        #region Navigation
        private void btnFirst_Click(object sender, EventArgs e)
        {
            // Database class methods are available data.methodName() from this instance
            Database data = new Database();

            // look in the Database class for more information on the methods used
            try
            {
                var navData = data.getFirstBookAndAuthor();
                lblBookId.Text = navData.BookId.ToString();
                lblBookTitle.Text = navData.BookTitle.ToString();
                lblBookGenre.Text = navData.BookGenre.ToString();
                lblBookAuthor.Text = navData.AuthorName.ToString();
                
                lblAddEditStatus.Text = "First Book";
            }
            catch
            {
                lblAddEditStatus.Text = "Could not find first Book";
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            // Database class methods are available data.methodName() from this instance
            Database data = new Database();

            // look in the Database class for more information on the methods used
            try
            {
                var navData = data.getLastBookAndAuthor();
                lblBookId.Text = navData.BookId.ToString();
                lblBookTitle.Text = navData.BookTitle.ToString();
                lblBookGenre.Text = navData.BookGenre.ToString();
                lblBookAuthor.Text = navData.AuthorName.ToString();

                lblAddEditStatus.Text = "Last Book";
            }
            catch
            {
                lblAddEditStatus.Text = "Could not find last Book";
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            // Database class methods are available data.methodName() from this instance
            Database data = new Database();

            // look in the Database class for more information on the methods used
            try
            {
                var navData = data.getPreviousBookAndAuthor(lblBookId.Text);
                lblBookId.Text = navData.BookId.ToString();
                lblBookTitle.Text = navData.BookTitle.ToString();
                lblBookGenre.Text = navData.BookGenre.ToString();
                lblBookAuthor.Text = navData.AuthorName.ToString();

                lblAddEditStatus.Text = "Previous Book";
            }
            catch
            {
                lblAddEditStatus.Text = "This is the first Book";
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Database class methods are available data.methodName() from this instance
            Database data = new Database();

            // look in the Database class for more information on the methods used
            try
            {
                var navData = data.getNextBookAndAuthor(lblBookId.Text);
                lblBookId.Text = navData.BookId.ToString();
                lblBookTitle.Text = navData.BookTitle.ToString();
                lblBookGenre.Text = navData.BookGenre.ToString();
                lblBookAuthor.Text = navData.AuthorName.ToString();

                lblAddEditStatus.Text = "Next Book";
            }
            catch
            {
                lblAddEditStatus.Text = "This is the last Book";
            }
        }

        // gets the values in the row that has been double clicked and shows them in the book information
        // to the left of the grid
        private void dgvBookList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvBookList.Rows[e.RowIndex];

                lblBookId.Text = row.Cells["BookId"].Value.ToString();
                lblBookTitle.Text = row.Cells["BookTitle"].Value.ToString();
                lblBookGenre.Text = row.Cells["BookGenre"].Value.ToString();
                lblBookAuthor.Text = row.Cells["AuthorName"].Value.ToString();
            }
        }

        // clears the fields to basic values
        private void btnClear_Click(object sender, EventArgs e)
        {
            lblBookId.Text = "0";
            lblBookTitle.Text = string.Empty;
            lblBookGenre.Text = string.Empty;
            lblBookAuthor.Text = string.Empty;
        }

        // refreshes the dgv, If new records have been added they will be displayed
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Database data = new Database();
            booksNAuthors = data.GetAllBooksWithAuthors();
            dgvBookList.DataSource = null;
            dgvBookList.DataSource = booksNAuthors;
        }
        #endregion
    }
}
