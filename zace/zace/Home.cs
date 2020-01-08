using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace zace
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*private void Home_Load(object sender, EventArgs e)
        {
            listPanel.Add(panelProfile);
            listPanel.Add(panelFollowing);
            listPanel.Add(panelEvent);
            listPanel.Add(panelArticle);
            listPanel[index].BringToFront();
        }*/

        private void btnHome_Click(object sender, EventArgs e)
        {
            panelHome.BringToFront();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            panelProfile.BringToFront();
        }

        private void btnFollowing_Click(object sender, EventArgs e)
        {
            panelFollowing.BringToFront();
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            panelEvent.BringToFront();
        }

        private void btnThread_Click(object sender, EventArgs e)
        {
            panelArticle.BringToFront();
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            panelDaftar.BringToFront();
        }

        private void btnHIMMSI_Click(object sender, EventArgs e)
        {
            panelBayar.BringToFront();
        }

        private void btnTaekwondo_Click(object sender, EventArgs e)
        {
            panelBayar.BringToFront();
        }

        private void btnAEC_Click(object sender, EventArgs e)
        {
            panelBayar.BringToFront();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            panelPilih.BringToFront();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialogForm openDialog = new OpenFileDialogForm();
            openDialog.Show();
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Ditunggu Pembayarannya");
            panelArticle.BringToFront();
            
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            panelUpload.BringToFront();
        }
    }
}
