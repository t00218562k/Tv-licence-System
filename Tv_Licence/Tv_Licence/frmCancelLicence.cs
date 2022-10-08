using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Tv_Licence
{
    public partial class frmCancelLicence : Form
    {
        frmMainMenu parent = new frmMainMenu();
        //object of form main menu

        public frmCancelLicence(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        public frmCancelLicence( )
        {
            InitializeComponent();
        }

        private void btnCancelLicence_Click(object sender, EventArgs e)
        {

            if (!(txtCancelLicence.Text.All(char.IsDigit)))
            {
                MessageBox.Show("Please enter digits only");
                return;
            }


            if (Licence.findLicenceId(Convert.ToInt32(txtCancelLicence.Text)) == 0)
            {
                MessageBox.Show("Could not find licence: " + txtCancelLicence.Text);
                txtCancelLicence.Focus();
                return;
            }

            int cusId = Customer.findCustomerId(Int32.Parse(txtCancelLicence.Text));

            DataSet ds = Customer.customerInfo(cusId);

            DataTable dt = ds.Tables["Customer"];

            DataRow row = dt.Rows[0];

            lblName.Text = "Name: " + row["FirstName"].ToString() + " " + row["LastName"].ToString();
            lblCurnStreet.Text = "Street: " + row["Street"].ToString();
            lblCurnTown.Text = "Town: " + row["Town"].ToString();
            lblCurnCounty.Text = "County: " + row["County"].ToString();
            lblExpiry.Text = "Expiry Date: " + row["ExpiryDate"].ToString();

            pnlUserInfoP.Visible = true;
        }

        private void MnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            //closes form cancel licence
            parent.Visible = true;
            //makes main menu form visible again
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtCancelLicence.Text);

            if (Licence.licenceStat(id) == "Valid" || Licence.licenceStat(id) == "Soon")
            {
                Licence.cancelLicence(Convert.ToInt32(txtCancelLicence.Text));
                txtCancelLicence.Clear();
                pnlUserInfoP.Visible = false;
                MessageBox.Show("Tv Licence has successfully been canceled");
            }
            else
                MessageBox.Show("This licence is already: " + Licence.licenceStat(id));
        }

    }
}
