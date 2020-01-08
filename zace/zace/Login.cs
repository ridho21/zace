using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace zace
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public char PasswordChar { get; set; }

        private void btnMasuk_Click(object sender, EventArgs e)
        {
            Home secondForm = new Home();
            secondForm.Show();
            this.Hide();
        }
    }
}
