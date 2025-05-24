using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eveniment
{
    public partial class Form1: Form
    {
        List<Eveniment> evenimente = new List<Eveniment>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            string tip = "";
            if (rbAniversare.Checked) tip = "Aniversare";
            else if (rbConferinta.Checked) tip = "Conferinta";
            else if (rbNunta.Checked) tip = "Nunta";

            DateTime data = dtpData.Value;
            string locatie = txtLocatie.Text.Trim();

            if(string.IsNullOrWhiteSpace(locatie) || locatie.Length < 3)
            {
                MessageBox.Show("Introduceti o locatie valida (minim 3 caractere).");
                return;
            }

            Eveniment ev = new Eveniment(tip, data, locatie);
            evenimente.Add(ev);
            MessageBox.Show("Eveniment adaugat!");

            dgvEvenimente.DataSource = null;
            dgvEvenimente.DataSource = evenimente;
        }
    }
}
