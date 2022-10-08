using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace Tv_Licence
{
    public partial class frmYearlyAuthority : Form
    {
        String[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Sep", "Aug", "Oct", "Nov", "Dec", "All"};
        String[] years = { "24", "23", "22", "21", "20", "19", "18", "17", "16", "15", "14", "13", "12", "11", "10", "09" };

        frmMainMenu parent = new frmMainMenu();

        public frmYearlyAuthority(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        public frmYearlyAuthority()
        {
            InitializeComponent();
        }

        private void MnuMain_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmYearlyAuthority_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < years.Length; i++)
                cbxYear.Items.Add(years[i]);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            double[] monthCount = new double[13];
            Double [] copyMonthCount = new double[12];
            int maxRev, lowRev;

            String year = years[cbxYear.SelectedIndex];
            String hisYear = years[cbxYear.SelectedIndex];
            String priceYear = years[(cbxYear.SelectedIndex + 1)];

            for (int i = 0; i < monthCount.Length; i++)
                monthCount[i] = Licence.revenue(year, months[i]) + History.revenue(hisYear, months[i]);

            for (int z = 0; z < copyMonthCount.Length; z++)
                copyMonthCount[z] = monthCount[z];

            maxRev = monthCount.ToList().IndexOf(copyMonthCount.Max());
            lowRev = monthCount.ToList().IndexOf(copyMonthCount.Min());

            DataSet d1 = new DataSet();

            d1.Tables.Add(new DataTable("Table"));
            d1.Tables[0].Columns.Add("Month", typeof(String));
            d1.Tables[0].Columns.Add("Revenue", typeof(String));

            double fee = Licence.findFee(priceYear);

            for (int z = 0; z < months.Length; z++)
            {
                d1.Tables[0].Rows.Add(months[z], "€" + monthCount[z] * fee);
            }

            dgvAnalysis.DataSource = d1.Tables["Table"];

            dgvAnalysis.Visible = true;
  
            dgvAnalysis.Rows[maxRev].DefaultCellStyle.BackColor = Color.Green;
            dgvAnalysis.Rows[lowRev].DefaultCellStyle.BackColor = Color.Red;

        }

        private void dgvAnalysis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int[] rowValues = new int[12];
            int maxRev, lowRev;

            for (int i = 0; i < rowValues.Length; i++)
                rowValues[i] = Int32.Parse(dgvAnalysis.Rows[i].Cells[1].Value.ToString());

            maxRev = rowValues.ToList().IndexOf(rowValues.Max());
            lowRev = rowValues.ToList().IndexOf(rowValues.Min());

            dgvAnalysis.Rows[maxRev].DefaultCellStyle.BackColor = Color.Green;
            dgvAnalysis.Rows[lowRev].DefaultCellStyle.BackColor = Color.Red;
        }
    }
}
