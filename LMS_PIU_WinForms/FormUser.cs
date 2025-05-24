using LMS_PIU;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS_PIU_WinForms
{
    public partial class FormUser: Form
    {
        private Library lib;
        public FormUser()
        {
            InitializeComponent();
            lib = new Library();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnImprumuta_Click(object sender, EventArgs e)
        {
            if (dataGridViewBooks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selectează o carte!");
                return;
            }

            var selected = dataGridViewBooks.SelectedRows[0].DataBoundItem as Book;
            if (selected.AvailableCopies > 0)
            {
                selected.AvailableCopies--;
                lib.SaveFile(); 
                MessageBox.Show("Cartea a fost împrumutată!");
                btnCauta_Click(null, null); 
            }
            else
            {
                MessageBox.Show("Nu mai sunt exemplare disponibile.");
            }
        }

        private void txtCautare_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            string search = txtCautare.Text.ToLower();
            var filtered = lib.GetAllBooks().Where(b =>
                b.Title.ToLower().Contains(search) ||
                b.Author.ToLower().Contains(search)).ToList();

            dataGridViewBooks.DataSource = null;
            dataGridViewBooks.DataSource = filtered;
            dataGridViewBooks.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridViewBooks.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnReturneaza_Click(object sender, EventArgs e)
        {
            if (dataGridViewBooks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selectează o carte.");
                return;
            }

            var selectedBook = dataGridViewBooks.SelectedRows[0].DataBoundItem as Book;

            if (selectedBook.AvailableCopies < selectedBook.TotalCopies)
            {
                selectedBook.AvailableCopies++;
                lib.SaveFile();
                MessageBox.Show("Carte returnată cu succes!");

                // Reîncarcă lista
                btnCauta_Click(null, null);
            }
            else
            {
                MessageBox.Show("Toate exemplarele sunt deja returnate.");
            }
        }
    }
}
