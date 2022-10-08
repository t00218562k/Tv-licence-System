using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Tv_Licence
{
    public partial class frmOverdueLicence : Form
    {
        frmMainMenu parent = new frmMainMenu();
        //making object of parent form
        public frmOverdueLicence(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        public frmOverdueLicence()
        {
            InitializeComponent();
        }
        private void MnuMain_Click_1(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnSendNotice_Click(object sender, EventArgs e)
        {
            DataSet d1 = Licence.getOverdueLicences();

            Utility.emailList(d1, "Your Tv licence is expired");

            Licence.updateOverdue();                
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dgvOverdue.DataSource = Licence.getOverdueLicences().Tables["licence"];     
            dgvOverdue.Visible = true;
        }
    }
}
