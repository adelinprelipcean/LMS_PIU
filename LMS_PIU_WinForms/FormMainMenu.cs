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
    public partial class FormMainMenu: Form
    {
        public FormMainMenu()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            FormAddBooks formAdmin = new FormAddBooks();
            formAdmin.ShowDialog();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            FormUser formUser = new FormUser();
            formUser.ShowDialog();
        }
    }
}
