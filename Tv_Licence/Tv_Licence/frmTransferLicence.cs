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
    public partial class frmTransferLicence : Form
    {
        frmMainMenu parent = new frmMainMenu();
        String[] counties = Utility.countys();

        public frmTransferLicence(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        public frmTransferLicence()
        {
            InitializeComponent();
            
        }

        private void btnTrasnferLicenceId_Click(object sender, EventArgs e)
        {
            if (!(txtTransferLicence.Text.All(char.IsDigit)))
            {
                MessageBox.Show("Please enter digits only");
                return;
            }
            int id = Int32.Parse(txtTransferLicence.Text);

            if (Licence.findLicenceId(id) == 0)
            {
                MessageBox.Show("Id was not found");
                return;
            }

            DataSet ds = Customer.customerInfo(id);

            DataTable dt = ds.Tables["Customer"];

            DataRow row = dt.Rows[0];

            lblName.Text = "Name: " + row["FirstName"].ToString() + " " + row["LastName"].ToString();
            lblCurnStreet.Text = "Street: " + row["Street"].ToString();
            lblCurnTown.Text = "Town: " + row["Town"].ToString();
            lblCurnCounty.Text = "County: " + row["County"].ToString();
            lblExpiry.Text = "Expiry Date: " + row["ExpiryDate"].ToString();

            if (Licence.licenceStat(id) == "Cancelled" || Licence.licenceStat(id) == "Expired")
            {
                MessageBox.Show("You cant transfer right now your licence is: " + row["Stat"].ToString());
                return;
            }
            pnlUserInfoP.Visible = true;
        }

        private void MnuMain_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnTransferNewAddress_Click(object sender, EventArgs e)
        {
            if (!(Utility.alphaNumericChecker(txtStreet.Text)))
            {
                MessageBox.Show("Please enter a valid Street");
                txtStreet.Focus();
                return;
            }

            if (!(txtTown.Text.Length > 3) || !(Utility.alphaChecker(txtTown.Text)))
            {
                MessageBox.Show("Please enter a valid Town");
                txtTown.Focus();
                return;
            }

            if (cbxCounties.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose a County");
                cbxCounties.Focus();
                return;
            }

            int licenceId = Int32.Parse(txtTransferLicence.Text);
            Licence.transferLicence(licenceId, txtStreet.Text.ToUpper(), txtTown.Text.ToUpper(), counties[cbxCounties.SelectedIndex]);

            MessageBox.Show("Your licence has been transferred");
            ResetUI();
            pnlTransfer.Visible = false;
            pnlUserInfoP.Visible = false;
        }

        public void ResetUI()
        {
            txtStreet.Clear();
            txtTown.Clear();
            cbxCounties.SelectedIndex = -1;
        }

        private void frmTransferLicence_Load(object sender, EventArgs e)
        {
            pnlTransfer.Visible = false;

            for (int i = 0; i < counties.Length; i++)
                cbxCounties.Items.Add(counties[i]);
        }

        private void btnNewInfo_Click(object sender, EventArgs e)
        {
            pnlTransfer.Visible = true;
        }
    }
}
