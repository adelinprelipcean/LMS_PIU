using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubiectPIU_Student
{
    public partial class Form1: Form
    {   
        List<Student> listaStudenti = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbOras_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            string nume = txtNume.Text.Trim();
            string oras = cmbOras.SelectedItem?.ToString();
            DateTime data = dtpData.Value;
            string program = "";

            if (string.IsNullOrWhiteSpace(nume))
            {
                MessageBox.Show("Introduceti numele studentului.");
                return;
            }

            if (oras == null || oras == "Selecteaza orasul...")
            {
                MessageBox.Show("Selecteaza un oras din lista");
                return;
            }

            DateTime azi = DateTime.Now;
            if(data < azi.AddDays(-3) || data > azi.AddDays(3))
            {
                MessageBox.Show("Data de inscriere trebuie sa fie in intervalul de 3 zile.");
                return;
            }

            if (rbCalculatoare.Checked) program = "Calculatoare";
            else if (rbAutomatica.Checked) program = "Automatica";
            else if (rbElectronica.Checked) program = "Electronica";
            else
            {
                MessageBox.Show("Selecteaza un program de studiu");
                return;
            }

            bool exista = listaStudenti.Any(s => s.Nume == nume && s.Oras == oras && s.DataInscriere == data && s.ProgramStudiu == program);
            if (exista)
            {
                MessageBox.Show("Studentul exista deja in lista.");
                return;
            }

            Student studentNou = new Student(nume, oras, data, program);
            listaStudenti.Add(studentNou);
            MessageBox.Show("Student introdus cu succes!");

            txtNume.Clear();
            cmbOras.SelectedIndex = 0;
            dtpData.Value = DateTime.Now;
            rbCalculatoare.Checked = rbAutomatica.Checked = rbElectronica.Checked = false;
        }
    }
}
