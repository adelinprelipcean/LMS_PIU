using LMS_PIU;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS_PIU_WinForms
{
    public partial class FormEditBook : Form
    {
        public Book EditedBook { get; private set; }

        private Book originalBook;

        public FormEditBook(Book book)
        {
            InitializeComponent();
            originalBook = book;

            // Populează controalele cu valorile curente
            txtTitle.Text = book.Title;
            txtAuthor.Text = book.Author;
            txtISBN.Text = book.ISBN;
            txtCopies.Text = book.TotalCopies.ToString();
            cmbCondition.DataSource = Enum.GetValues(typeof(BookCondition));

            cmbCondition.SelectedItem = book.BookCondition;

            clbLevel.Items.Clear();
            clbLevel.Items.AddRange(Enum.GetValues(typeof(EducationLevel)).Cast<object>().ToArray());

            foreach (EducationLevel level in Enum.GetValues(typeof(EducationLevel)))
            {
                if (book.MinimumLevel.HasFlag(level))
                {
                    int index = clbLevel.Items.IndexOf(level);
                    if (index >= 0) clbLevel.SetItemChecked(index, true);
                }
            }
        }

        private void FormEditBook_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int totalCopies = int.TryParse(txtCopies.Text, out int c) ? c : 1;
            BookCondition condition = (BookCondition)cmbCondition.SelectedItem;

            EducationLevel levels = 0;
            foreach (EducationLevel level in clbLevel.CheckedItems)
                levels |= level;

            EditedBook = new Book(
                txtTitle.Text,
                txtAuthor.Text,
                txtISBN.Text,
                totalCopies,
                condition,
                levels
            );

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
