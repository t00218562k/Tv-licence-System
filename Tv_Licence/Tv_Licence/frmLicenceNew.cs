using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tv_Licence
{
    public partial class frmLicenceNew : Form
    {
        frmMainMenu parent = new frmMainMenu();
        String[] counties = Utility.countys();

        public frmLicenceNew(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        public frmLicenceNew()
        {
            InitializeComponent();
        }

        private void MnuMain_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            //array of texts
            String[] textList = {txtFirstName.Text, txtLastName.Text, txtStreet.Text, txtTown.Text,txtEmail.Text,
                txtCardNum.Text, txtCardName.Text, txtExpiry.Text, txtCVV.Text,};

            //checked if all the text are empthy
            for(int i=0; i<textList.Length; i++)
                if(string.IsNullOrEmpty(textList[i]) || cbxCounties.SelectedIndex<0)
                {
                    MessageBox.Show("All field must be entered");
                    return;
                }

            if (!(Utility.alphaChecker(txtFirstName.Text)) || !(Utility.alphaChecker(txtLastName.Text)))
            {
                MessageBox.Show("Check first and last name are alphabetic");
                return;
            }

            if (!(Utility.alphaNumericChecker(txtStreet.Text)))
            {
                MessageBox.Show("Please enter a valid Street");
                return;
            }

            if (!(txtTown.Text.Length > 3) || !(Utility.alphaChecker(txtTown.Text)))
            {
                MessageBox.Show("Please enter a valid Town");
                txtTown.Focus();
                return;
            }

            //checks if email is Invalid
            if (!(Utility.emailValid(txtEmail.Text)))
            {
                txtEmail.Focus();
                return;
            }
            
            //checks if the card number field is not equal to 16 charcters or if any non numerics were inputed
            if (!(Utility.cardLengthValid(txtCardNum.Text, 16)) || !(txtCardNum.Text.All(Char.IsDigit)))           
            {
                txtCardNum.Focus();
                return;
            }
            
            //checks if the CVV field is not equal to 3 charcters or if any non numerics were inputed
            if (!(Utility.cardLengthValid(txtCVV.Text, 3)) || !(txtCVV.Text.All(char.IsDigit)))       
            {      
                txtCVV.Focus();
                return;
            }
            
            //checks if the card expiry date is invalid
            if (!(Utility.expiryChecker(txtExpiry.Text)))
            {
                txtExpiry.Focus();
                return;
            }

            if (!(Utility.fullName(txtCardName.Text)))
            {
                txtCardName.Focus();
                return;
            }

            //gets licence id and customer id for that address. licence id is index 0
            int[] ids = Licence.addressValidLicence(txtStreet.Text.ToUpper(), txtTown.Text.ToUpper(), cbxCounties.SelectedItem.ToString());

            //if the address already has an account send recovery mail to user
            if (ids[0] != 0)
            {       
                DataSet ds = Customer.customerInfo(ids[1]);

                DataTable dt = ds.Tables["Customer"];

                DataRow row = dt.Rows[0];

                String userEmail = row["Email"].ToString(); 

                //this is here just for the prototype
                MessageBox.Show("This address already has a valid Licence\n licence id: " + ids[0] + "\nCustomer id: " + ids[1] + "\nPlease renew your licence and transfer if you have moved address");

                Utility.sendMail(userEmail, "Recover tv licence id", "Your tv licence id id: " + ids[0] + "\nyour account id is: " + ids[1]);

                ResetUI();
                return;
            }

            double price = Licence.getCurrentFee();

            DialogResult decision = MessageBox.Show("The current price of a licence is: " + price + "\nDo you wish to procede", "Confirm", MessageBoxButtons.YesNo);

            if (decision == DialogResult.No)
            {
                ResetUI();
                return;
            }

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
        
            int cusid = Customer.getNextCusId();

            String expDate = (DateTime.Now.AddYears(1)).ToString("dd-MMM-yy");
     
            Customer addCus = new Customer(cusid, txtFirstName.Text.ToUpper(), txtLastName.Text.ToUpper(), txtEmail.Text);
            addCus.addCustomer();
        
            double fee = Licence.getCurrentFee();

            Licence addLic = new Licence(Licence.getNextLicenceId(), cusid, txtStreet.Text.ToUpper(), txtTown.Text.ToUpper(), counties[cbxCounties.SelectedIndex], expDate, fee, "Valid");
            addLic.addLicence();
        
            MessageBox.Show("Your licence number: " + (Licence.getNextLicenceId()-1).ToString() + "\nYour customer id: " + cusid);
          
            ResetUI();         
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
            txtStreet.Clear();
            txtTown.Clear();
            cbxCounties.SelectedIndex = -1;
        }

        private void frmLicenceNew_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < counties.Length; i++)
                cbxCounties.Items.Add(counties[i]);
        }
    }
}
