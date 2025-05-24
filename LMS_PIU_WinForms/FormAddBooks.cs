using LMS_PIU;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS_PIU_WinForms
{
    public partial class FormAddBooks : Form
    {
        private Library lib;

        public FormAddBooks()
        {
            InitializeComponent();
            lib = new Library();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCondition.DataSource = Enum.GetValues(typeof(BookCondition));
            foreach (EducationLevel level in Enum.GetValues(typeof(EducationLevel)))
            {
                clbLevel.Items.Add(level);
            }

        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string author = txtAuthor.Text;
            string isbn = txtISBN.Text;
            int copies;

            lblMessage.Text = "";
            lblMessage.ForeColor = Color.Black;

            if (!int.TryParse(txtCopies.Text, out copies) || copies < 1 || copies > 100)
            {
                lblMessage.Text = "Numărul de exemplare trebuie să fie între 1 și 100.";
                lblMessage.ForeColor = Color.Red;
                txtCopies.BackColor = Color.LightCoral;
                return;
            }
            else
            {
                txtCopies.BackColor = Color.White;
            }

            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(author))
            {
                lblMessage.Text = "Titlul și autorul sunt obligatorii.";
                lblMessage.ForeColor = Color.Red;
                txtTitle.BackColor = Color.LightCoral;
                txtAuthor.BackColor = Color.LightCoral;
                return;
            }
            else
            {
                txtTitle.BackColor = Color.White;
                txtAuthor.BackColor = Color.White;
            }

            if (string.IsNullOrWhiteSpace(isbn))
            {
                lblMessage.Text = "ISBN-ul este obligatoriu.";
                lblMessage.ForeColor = Color.Red;
                txtISBN.BackColor = Color.LightCoral;
                return;
            }
            else
            {
                txtISBN.BackColor = Color.White;
            }

            BookCondition condition = (BookCondition)cmbCondition.SelectedItem;
            EducationLevel level = 0;

            foreach (var item in clbLevel.CheckedItems)
            {
                level |= (EducationLevel)item;
            }

            try
            {
                Book newBook = new Book(title, author, isbn, copies, condition, level);
                lib.AddBook(newBook);

                lblMessage.Text = "Carte adăugată cu succes!";
                lblMessage.ForeColor = Color.Green;

                txtTitle.Clear();
                txtAuthor.Clear();
                txtISBN.Clear();
                txtCopies.Clear();
                txtTitle.BackColor = Color.White;
                txtAuthor.BackColor = Color.White;
                txtISBN.BackColor = Color.White;
                txtCopies.BackColor = Color.White;
            }
            catch (Exception ex)
            {
                lblMessage.Text = $"Eroare la adăugare: {ex.Message}";
                lblMessage.ForeColor = Color.Red;
            }
        }

        private void btnDisplayBooks_Click(object sender, EventArgs e)
        {
            var displayForm = new FormDisplayBooks();
            displayForm.ShowDialog(); 
        }

        private void lblHeader_Click(object sender, EventArgs e)
        {

        }
    }
}
