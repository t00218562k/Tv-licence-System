using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Tv_Licence
{
    public partial class frmIssueNotice : Form
    {
        frmMainMenu parent = new frmMainMenu();
        //making object of parent form

        public frmIssueNotice(frmMainMenu parent) 
        {
            InitializeComponent();
            this.parent = parent;
        }
        public frmIssueNotice()
        {
            InitializeComponent();
        }

        private void MnuMain_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnSendNotice_Click(object sender, EventArgs e)
        {
            DataSet d1 = Licence.getNoticeLicence();


            Utility.emailList(d1, "Your Tv licence will be expired within the next month, please renew");

            Licence.updateNotice();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dgvNotice.DataSource = Licence.getNoticeLicence().Tables["licence"];
            dgvNotice.Visible = true;
        }
    }
}
