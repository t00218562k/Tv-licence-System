
namespace Tv_Licence
{
    partial class frmPropertyHistory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnuMain = new System.Windows.Forms.ToolStripMenuItem();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblCounty = new System.Windows.Forms.Label();
            this.lblTown = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.cbxCounties = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuMain});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1094, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MnuMain
            // 
            this.MnuMain.Name = "MnuMain";
            this.MnuMain.Size = new System.Drawing.Size(52, 20);
            this.MnuMain.Text = "Home";
            this.MnuMain.Click += new System.EventHandler(this.MnuMain_Click);
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(196, 126);
            this.txtTown.MaxLength = 30;
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(176, 23);
            this.txtTown.TabIndex = 25;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(196, 70);
            this.txtStreet.MaxLength = 50;
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(232, 23);
            this.txtStreet.TabIndex = 24;
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCounty.Location = new System.Drawing.Point(93, 171);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(80, 35);
            this.lblCounty.TabIndex = 23;
            this.lblCounty.Text = "County";
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTown.Location = new System.Drawing.Point(108, 113);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(65, 35);
            this.lblTown.TabIndex = 22;
            this.lblTown.Text = "Town";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStreet.Location = new System.Drawing.Point(24, 58);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(149, 35);
            this.lblStreet.TabIndex = 21;
            this.lblStreet.Text = "Address Street";
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnApply.Location = new System.Drawing.Point(196, 226);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(120, 32);
            this.btnApply.TabIndex = 95;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // dgvHistory
            // 
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvHistory.Location = new System.Drawing.Point(496, 58);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.RowTemplate.Height = 25;
            this.dgvHistory.Size = new System.Drawing.Size(561, 356);
            this.dgvHistory.TabIndex = 91;
            this.dgvHistory.Visible = false;
            // 
            // cbxCounties
            // 
            this.cbxCounties.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCounties.FormattingEnabled = true;
            this.cbxCounties.Location = new System.Drawing.Point(196, 183);
            this.cbxCounties.Name = "cbxCounties";
            this.cbxCounties.Size = new System.Drawing.Size(169, 23);
            this.cbxCounties.TabIndex = 94;
            // 
            // frmPropertyHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1094, 449);
            this.Controls.Add(this.cbxCounties);
            this.Controls.Add(this.dgvHistory);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.txtTown);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.lblCounty);
            this.Controls.Add(this.lblTown);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmPropertyHistory";
            this.Text = "Property History";
            this.Load += new System.EventHandler(this.frmPropertyHistory_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnuMain;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.ComboBox cbxCounties;
    }
}