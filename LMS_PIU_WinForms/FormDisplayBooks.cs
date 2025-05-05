using LMS_PIU;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LMS_PIU_WinForms
{
    public partial class FormDisplayBooks : Form
    {
        private Library lib;

        public FormDisplayBooks()
        {
            InitializeComponent();
            lib = new Library();
        }

        private void FormDisplayBooks_Load(object sender, EventArgs e)
        {
            ReloadGrid();

            dataGridViewBooks.Font = new Font("Segoe UI", 9);
            dataGridViewBooks.BackgroundColor = Color.White;
            dataGridViewBooks.GridColor = Color.LightGray;

            dataGridViewBooks.EnableHeadersVisualStyles = false;
            dataGridViewBooks.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSteelBlue;
            dataGridViewBooks.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridViewBooks.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);

            dataGridViewBooks.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewBooks.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridViewBooks.DefaultCellStyle.BackColor = Color.White;
            dataGridViewBooks.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (dataGridViewBooks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selectați o carte pentru a o șterge.");
                return;
            }

            var selectedRow = dataGridViewBooks.SelectedRows[0];
            var selectedBook = selectedRow.DataBoundItem as Book;

            if (selectedBook == null)
                return;

            var confirm = MessageBox.Show($"Sigur doriți să ștergeți cartea:\n\n{selectedBook.Title} de {selectedBook.Author}?",
                                          "Confirmare ștergere",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                lib.RemoveBook(selectedBook.ISBN);
                MessageBox.Show("Cartea a fost ștearsă.");
                ReloadGrid();
            }
        }
        private void ReloadGrid()
        {
            dataGridViewBooks.DataSource = null;
            dataGridViewBooks.DataSource = lib.GetAllBooks();
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            if (dataGridViewBooks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selectați o carte pentru a o modifica.");
                return;
            }

            var selectedRow = dataGridViewBooks.SelectedRows[0];
            var selectedBook = selectedRow.DataBoundItem as Book;

            if (selectedBook == null)
                return;

            string newTitle = Microsoft.VisualBasic.Interaction.InputBox("Titlu nou:", "Modificare", selectedBook.Title);
            string newAuthor = Microsoft.VisualBasic.Interaction.InputBox("Autor nou:", "Modificare", selectedBook.Author);

            if (!string.IsNullOrWhiteSpace(newTitle))
                selectedBook.Title = newTitle;
            if (!string.IsNullOrWhiteSpace(newAuthor))
                selectedBook.Author = newAuthor;

            lib.SaveFile();
            ReloadGrid();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(keyword))
            {
                ReloadGrid();
                return;
            }

            var filtered = lib.GetAllBooks()
                              .Where(b => b.Title.ToLower().Contains(keyword))
                              .ToList();

            if (filtered.Count == 0)
            {
                MessageBox.Show("Nicio carte găsită.");
            }

            dataGridViewBooks.DataSource = null;
            dataGridViewBooks.DataSource = filtered;
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
