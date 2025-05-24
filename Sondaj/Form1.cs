using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sondaj
{
    public partial class Form1: Form
    {
        List<Sondaj> sondaje = new List<Sondaj>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            if(!int.TryParse(txtVarsta.Text, out int varsta))
            {
                MessageBox.Show("Introduceti o varsta corecta!");
                return;
            }
            if(varsta < 18 || varsta > 100)
            {
                MessageBox.Show("Introduceti o varsta intre 18 si 100!");
            }

            if(cmbLocalitatea.SelectedIndex <= 0)
            {
                MessageBox.Show("Selectati un oras!");
            }

            string localitate = cmbLocalitatea.SelectedItem.ToString();
            bool proeuropa = chkProEuropa.Checked;

            Sondaj s = new Sondaj(varsta, localitate, proeuropa);
            sondaje.Add(s);
            MessageBox.Show("Sondaj adaugat cu succes!");

            txtVarsta.Clear();
            cmbLocalitatea.SelectedIndex = 0;
            chkProEuropa.Checked = false;
        }

        private void btnAfiseaza_Click(object sender, EventArgs e)
        {
            lstSondaje.Items.Clear();
            foreach(var sondaj in sondaje)
            {
                lstSondaje.Items.Add(sondaj.ToString());
            }
        }
    }
}
