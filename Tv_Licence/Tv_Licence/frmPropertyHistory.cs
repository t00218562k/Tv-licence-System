using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Tv_Licence
{
    public partial class frmPropertyHistory : Form
    {
        frmMainMenu parent = new frmMainMenu();
        String[] counties = Utility.countys();

        public frmPropertyHistory(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        public frmPropertyHistory()
        {
            InitializeComponent();
            //hides panel
        }


        private void MnuMain_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtStreet.Text) || string.IsNullOrEmpty(txtTown.Text) || cbxCounties.SelectedIndex < 0)
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }

            DataSet d1 = History.findHistory(txtStreet.Text.ToUpper(), txtTown.Text.ToUpper(), counties[cbxCounties.SelectedIndex]);

            d1.Tables[0].Columns.Add("StartDate", typeof(String));
            d1.Tables[0].Columns.Add("FirstName", typeof(String));
            d1.Tables[0].Columns.Add("LastName", typeof(String));

            for (int i = 0; i < d1.Tables[0].Rows.Count; i++)
            {
                string curnDate = d1.Tables[0].Rows[i]["ExpiryDate"].ToString();

                int id = Int32.Parse(d1.Tables[0].Rows[i]["Cus_Id"].ToString());

                DataSet cusInfo = Customer.customerInfo(id);
                DateTime sDate = Convert.ToDateTime(curnDate).AddYears(-1);

                d1.Tables[0].Rows[i]["StartDate"] = sDate.ToString("dd-MMM-yy");
                d1.Tables[0].Rows[i]["FirstName"] = cusInfo.Tables[0].Rows[0]["FirstName"];
                d1.Tables[0].Rows[i]["LastName"] = cusInfo.Tables[0].Rows[0]["LastName"];
            }

            dgvHistory.DataSource = d1.Tables["history"];

            dgvHistory.Visible = true;
        }

        private void frmPropertyHistory_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < counties.Length; i++)
                cbxCounties.Items.Add(counties[i]);
        }
    }
}
