using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tv_Licence
{
    public partial class frmRenewLicence : Form
    {
        frmMainMenu parent = new frmMainMenu();

        public frmRenewLicence(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        public frmRenewLicence()
        {
            InitializeComponent();
        }

        private void MnuMain_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnId_Click(object sender, EventArgs e)
        {
            if (!(txtId.Text.All(char.IsDigit)))
            {
                MessageBox.Show("I.D must be numeric");
                txtId.Focus();
                return;
            }

            int id = Int32.Parse(txtId.Text);

            if (!(Customer.findCustomer(id)))
            {
                MessageBox.Show("I.D was not found");
                txtId.Focus();
                return;
            }

            DataSet ds = Customer.customerInfo(id);

            DataTable dt = ds.Tables["Customer"];

            DataRow row = dt.Rows[0];

            txtFirstName.Text = row["FirstName"].ToString();
            txtLastName.Text = row["LastName"].ToString();
            txtEmail.Text = row["Email"].ToString();

            pnlRenew.Visible = true;

            if(Licence.licenceStat(id) == "Valid")
                MessageBox.Show("Your Licence is still valid");
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            //checks if email is Invalid
            if (!(Utility.emailValid(txtEmail.Text)))
            {
                txtEmail.Focus();
                return;
            }

            if (!(Utility.alphaChecker(txtFirstName.Text) && Utility.alphaChecker(txtLastName.Text)))
            {
                MessageBox.Show("Check first and last name are alphabetic");
                return;
            }

            if (!(Utility.cardLengthValid(txtCardNum.Text, 16)) && !(txtCardNum.Text.All(Char.IsDigit)))
            {
                txtCardNum.Focus();
                return;
            }

            if (!(Utility.fullName(txtCardName.Text)))
            {
                txtCardName.Focus();
                return;
            }

            if (!(Utility.expiryChecker(txtExpiry.Text)))
            {
                txtExpiry.Focus();
                return;
            }

            if (!(Utility.cardLengthValid(txtCVV.Text, 3)) && txtCVV.Text.All(char.IsDigit))
            {
                txtCVV.Focus();
                return;
            }

            Double price = Licence.getCurrentFee();

            DialogResult decision = MessageBox.Show("The current price of a licence is: " + price +"\nDo you wish to procede","Confirm", MessageBoxButtons.YesNo);

            if (decision == DialogResult.Yes)
                Licence.renewLicence(Int32.Parse(txtId.Text), txtFirstName.Text.ToUpper(), txtLastName.Text.ToUpper(), txtEmail.Text);
            else
                return;

            ResetUI();

            MessageBox.Show("Your licennce has been been renewed your next expiry is " + DateTime.Now.AddYears(1).ToString("dd-MMM-yy"));
        }

        public void ResetUI()
        {
            txtCardName.Clear();
            txtCardNum.Clear();
            txtLastName.Clear();
            txtCVV.Clear();
            txtEmail.Clear();
            txtExpiry.Clear();
            txtFirstName.Clear();
        }

    }
}
