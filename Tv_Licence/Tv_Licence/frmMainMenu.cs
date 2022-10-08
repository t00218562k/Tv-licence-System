using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Tv_Licence
{
    public partial class frmMainMenu : Form
    {
        public static Boolean login = false;

        public frmMainMenu()
        {
            InitializeComponent();
            btnDueLicence.Hide();
            //hiding button for due licences
            btnIssueRenNotice.Hide();
            //hiding button for issue renewal notice
            btnYAuthorAnalysis.Hide();
            //hiding button for Yearly auhtority analysis
            btnYRevAnalysis.Hide();
            //hiding button for Yearly revenue analysis
            btnPropHistory.Hide();
            //hides the buttom fpr propertery history 
            adminLogin(login);
        }

        private void btnPurcahseLicence_Click(object sender, EventArgs e)
        {
            this.Hide();
            //hides this form
            frmLicenceNew licenceNew = new frmLicenceNew();
            //create object for form licence new
            licenceNew.Show();
            //show form licence new
        }

        private void btnCancelLicence_Click(object sender, EventArgs e)
        {
            this.Hide();
            //hides this form
            frmCancelLicence cancelLicence = new frmCancelLicence();
            //create object for form cancel licence
            cancelLicence.Show();
            //show form cancel licence
        }

        private void btnTransferLicence_Click(object sender, EventArgs e)
        {
            this.Hide();
            //hides this form
            frmTransferLicence transferLicence = new frmTransferLicence();
            //create object for form transfer licence
            transferLicence.Show();
            //show form transfer licence
        }

        private void btnIRenLicence_Click(object sender, EventArgs e)
        {
            this.Hide();
            //hides this form
            frmRenewLicence renewLicence = new frmRenewLicence();
            //create object for form renew licence
            renewLicence.Show();
            //show form renew licence
        }
        private void btnPropHistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            //hides this form
            frmPropertyHistory propHistory = new frmPropertyHistory();
            //creates object for form property history
            propHistory.Show();
            //shows property History
        }
        private void btnIssueRenNotice_Click(object sender, EventArgs e)
        {
            this.Hide();
            //hides this form
            frmIssueNotice notice = new frmIssueNotice();
            //creates object for form issue renewal notice
            notice.Show();
            //shows issue notice form
        }
        private void btnYRevAnalysis_Click(object sender, EventArgs e)
        {
            this.Hide();
            //hides this form
            frmYearlyRevenue notice = new frmYearlyRevenue();
            //creates object for form issue renewal notice
            notice.Show();
            //shows issue notice form
        }
        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            if (txtAdminLogin.Text.Equals("admin123"))
            //checks if login password is correct
                adminLogin(true);           
        }

        private void btnDueLicence_Click(object sender, EventArgs e)
        {
            this.Hide();
            //hides this form
            frmOverdueLicence overdue = new frmOverdueLicence();
            //creates object for form issue renewal notice
            overdue.Show();
            //shows issue notice form
        }

        private void btnYAuthorAnalysis_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmYearlyAuthority yAuthority = new frmYearlyAuthority();
            yAuthority.Show();
        }

        public void adminLogin(Boolean valid) 
        {
            if (valid)
            {
                login = true;
                btnDueLicence.Show();
                btnIssueRenNotice.Show();
                btnYAuthorAnalysis.Show();
                btnYRevAnalysis.Show();
                btnPropHistory.Show();
                txtAdminLogin.Visible = false;
                btnAdminLogin.Visible = false;
            }
          
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Form help = new Form();
            help.Height = 600;
            help.Width = 470;
            help.Top = 50;
            help.Text = "Send email";
            help.BackColor = SystemColors.ControlLight;
        

            Label top = new Label();
            top.Text = "Topic";
            top.Font = new Font("Sitka Banner", 18);
            top.Width = 100;
            top.Height = 50;

            TextBox t1 = new TextBox();
            t1.Width = 400;
            t1.Top = 50;
            t1.Left = 10;

            Label m1 = new Label();
            m1.Text = "Message";
            m1.Font = new Font("Sitka Banner", 18);
            m1.Width = 100;
            m1.Height = 50;
            m1.Top = 80;


            TextBox t2 = new TextBox();
            t2.AutoSize = false;
            t2.Width = 400;
            t2.Height = 300;
            t2.Top = 140;
            t2.Left = 10;
            t2.Multiline = true;
            t2.ScrollBars = ScrollBars.Vertical;

            Button b1 = new Button();
            b1.Text = "Send";
            b1.Top = 500;
            b1.Width = 120;
            b1.Height = 40;
            b1.BackColor = SystemColors.ButtonFace;
            b1.Left = (help.Width - b1.Width) / 2;
            //https://stackoverflow.com/questions/22236037/adding-onclick-events-to-buttons
            b1.Click += (sender, e)=>
            {
                if(String.IsNullOrEmpty(t1.Text) || String.IsNullOrEmpty(t2.Text))
                {
                    MessageBox.Show("Please fill in topic and message");
                    return;
                }

                Utility.sendMail("dummywow401@gmail.com", t1.Text.ToString(), t2.Text.ToString());
                MessageBox.Show("Your Message has been sent, We will get back to you as soon as possible");
                help.Close();
            };

            help.Controls.Add(top);
            help.Controls.Add(t1);
            help.Controls.Add(m1);
            help.Controls.Add(t2);
            help.Controls.Add(b1);

            help.Show();
        }
    }
}
