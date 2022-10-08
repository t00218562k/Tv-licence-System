
namespace Tv_Licence
{
    partial class frmTransferLicence
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
            this.lblEnterTvLicenceNumber = new System.Windows.Forms.Label();
            this.btnTrasnferLicenceId = new System.Windows.Forms.Button();
            this.txtTransferLicence = new System.Windows.Forms.TextBox();
            this.pnlTransfer = new System.Windows.Forms.Panel();
            this.cbxCounties = new System.Windows.Forms.ComboBox();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblCounty = new System.Windows.Forms.Label();
            this.lblTown = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.btnTransferNewAddress = new System.Windows.Forms.Button();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.pnlUserInfoP = new System.Windows.Forms.Panel();
            this.lblExpiry = new System.Windows.Forms.Label();
            this.lblCurnCounty = new System.Windows.Forms.Label();
            this.lblCurnTown = new System.Windows.Forms.Label();
            this.lblCurnStreet = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnNewInfo = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.pnlTransfer.SuspendLayout();
            this.pnlUserInfoP.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuMain});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MnuMain
            // 
            this.MnuMain.Name = "MnuMain";
            this.MnuMain.Size = new System.Drawing.Size(52, 20);
            this.MnuMain.Text = "Home";
            this.MnuMain.Click += new System.EventHandler(this.MnuMain_Click);
            // 
            // lblEnterTvLicenceNumber
            // 
            this.lblEnterTvLicenceNumber.AutoSize = true;
            this.lblEnterTvLicenceNumber.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEnterTvLicenceNumber.Location = new System.Drawing.Point(47, 51);
            this.lblEnterTvLicenceNumber.Name = "lblEnterTvLicenceNumber";
            this.lblEnterTvLicenceNumber.Size = new System.Drawing.Size(308, 35);
            this.lblEnterTvLicenceNumber.TabIndex = 7;
            this.lblEnterTvLicenceNumber.Text = "Enter your Tv licence number";
            // 
            // btnTrasnferLicenceId
            // 
            this.btnTrasnferLicenceId.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTrasnferLicenceId.Location = new System.Drawing.Point(111, 145);
            this.btnTrasnferLicenceId.Name = "btnTrasnferLicenceId";
            this.btnTrasnferLicenceId.Size = new System.Drawing.Size(155, 43);
            this.btnTrasnferLicenceId.TabIndex = 8;
            this.btnTrasnferLicenceId.Text = "Find";
            this.btnTrasnferLicenceId.UseVisualStyleBackColor = false;
            this.btnTrasnferLicenceId.Click += new System.EventHandler(this.btnTrasnferLicenceId_Click);
            // 
            // txtTransferLicence
            // 
            this.txtTransferLicence.Location = new System.Drawing.Point(88, 96);
            this.txtTransferLicence.MaxLength = 9;
            this.txtTransferLicence.Name = "txtTransferLicence";
            this.txtTransferLicence.Size = new System.Drawing.Size(204, 23);
            this.txtTransferLicence.TabIndex = 9;
            // 
            // pnlTransfer
            // 
            this.pnlTransfer.Controls.Add(this.cbxCounties);
            this.pnlTransfer.Controls.Add(this.txtTown);
            this.pnlTransfer.Controls.Add(this.txtStreet);
            this.pnlTransfer.Controls.Add(this.lblCounty);
            this.pnlTransfer.Controls.Add(this.lblTown);
            this.pnlTransfer.Controls.Add(this.lblStreet);
            this.pnlTransfer.Controls.Add(this.btnTransferNewAddress);
            this.pnlTransfer.Location = new System.Drawing.Point(522, 51);
            this.pnlTransfer.Name = "pnlTransfer";
            this.pnlTransfer.Size = new System.Drawing.Size(450, 448);
            this.pnlTransfer.TabIndex = 10;
            // 
            // cbxCounties
            // 
            this.cbxCounties.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCounties.FormattingEnabled = true;
            this.cbxCounties.Location = new System.Drawing.Point(200, 225);
            this.cbxCounties.Name = "cbxCounties";
            this.cbxCounties.Size = new System.Drawing.Size(169, 23);
            this.cbxCounties.TabIndex = 93;
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(200, 166);
            this.txtTown.MaxLength = 30;
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(176, 23);
            this.txtTown.TabIndex = 25;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(200, 110);
            this.txtStreet.MaxLength = 50;
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(232, 23);
            this.txtStreet.TabIndex = 24;
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCounty.Location = new System.Drawing.Point(97, 213);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(80, 35);
            this.lblCounty.TabIndex = 23;
            this.lblCounty.Text = "County";
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTown.Location = new System.Drawing.Point(112, 158);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(65, 35);
            this.lblTown.TabIndex = 22;
            this.lblTown.Text = "Town";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStreet.Location = new System.Drawing.Point(28, 102);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(149, 35);
            this.lblStreet.TabIndex = 21;
            this.lblStreet.Text = "Address Street";
            // 
            // btnTransferNewAddress
            // 
            this.btnTransferNewAddress.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTransferNewAddress.Location = new System.Drawing.Point(200, 283);
            this.btnTransferNewAddress.Name = "btnTransferNewAddress";
            this.btnTransferNewAddress.Size = new System.Drawing.Size(155, 43);
            this.btnTransferNewAddress.TabIndex = 11;
            this.btnTransferNewAddress.Text = "Transfer";
            this.btnTransferNewAddress.UseVisualStyleBackColor = false;
            this.btnTransferNewAddress.Click += new System.EventHandler(this.btnTransferNewAddress_Click);
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.AutoSize = true;
            this.lblUserInfo.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUserInfo.Location = new System.Drawing.Point(56, 12);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(235, 35);
            this.lblUserInfo.TabIndex = 94;
            this.lblUserInfo.Text = "Is this Your Information";
            // 
            // pnlUserInfoP
            // 
            this.pnlUserInfoP.Controls.Add(this.lblExpiry);
            this.pnlUserInfoP.Controls.Add(this.lblCurnCounty);
            this.pnlUserInfoP.Controls.Add(this.lblCurnTown);
            this.pnlUserInfoP.Controls.Add(this.lblCurnStreet);
            this.pnlUserInfoP.Controls.Add(this.lblName);
            this.pnlUserInfoP.Controls.Add(this.lblUserInfo);
            this.pnlUserInfoP.Controls.Add(this.btnNewInfo);
            this.pnlUserInfoP.Location = new System.Drawing.Point(12, 194);
            this.pnlUserInfoP.Name = "pnlUserInfoP";
            this.pnlUserInfoP.Size = new System.Drawing.Size(487, 346);
            this.pnlUserInfoP.TabIndex = 95;
            this.pnlUserInfoP.Visible = false;
            // 
            // lblExpiry
            // 
            this.lblExpiry.AutoSize = true;
            this.lblExpiry.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblExpiry.Location = new System.Drawing.Point(56, 230);
            this.lblExpiry.Name = "lblExpiry";
            this.lblExpiry.Size = new System.Drawing.Size(129, 35);
            this.lblExpiry.TabIndex = 100;
            this.lblExpiry.Text = "Expiry Date:";
            // 
            // lblCurnCounty
            // 
            this.lblCurnCounty.AutoSize = true;
            this.lblCurnCounty.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCurnCounty.Location = new System.Drawing.Point(56, 185);
            this.lblCurnCounty.Name = "lblCurnCounty";
            this.lblCurnCounty.Size = new System.Drawing.Size(91, 35);
            this.lblCurnCounty.TabIndex = 98;
            this.lblCurnCounty.Text = "County: ";
            // 
            // lblCurnTown
            // 
            this.lblCurnTown.AutoSize = true;
            this.lblCurnTown.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCurnTown.Location = new System.Drawing.Point(56, 143);
            this.lblCurnTown.Name = "lblCurnTown";
            this.lblCurnTown.Size = new System.Drawing.Size(76, 35);
            this.lblCurnTown.TabIndex = 97;
            this.lblCurnTown.Text = "Town: ";
            // 
            // lblCurnStreet
            // 
            this.lblCurnStreet.AutoSize = true;
            this.lblCurnStreet.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCurnStreet.Location = new System.Drawing.Point(56, 97);
            this.lblCurnStreet.Name = "lblCurnStreet";
            this.lblCurnStreet.Size = new System.Drawing.Size(81, 35);
            this.lblCurnStreet.TabIndex = 96;
            this.lblCurnStreet.Text = "Street: ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(56, 56);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(77, 35);
            this.lblName.TabIndex = 95;
            this.lblName.Text = "name: ";
            // 
            // btnNewInfo
            // 
            this.btnNewInfo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNewInfo.Location = new System.Drawing.Point(162, 281);
            this.btnNewInfo.Name = "btnNewInfo";
            this.btnNewInfo.Size = new System.Drawing.Size(155, 43);
            this.btnNewInfo.TabIndex = 11;
            this.btnNewInfo.Text = "Confirm";
            this.btnNewInfo.UseVisualStyleBackColor = false;
            this.btnNewInfo.Click += new System.EventHandler(this.btnNewInfo_Click);
            // 
            // frmTransferLicence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(984, 552);
            this.Controls.Add(this.pnlUserInfoP);
            this.Controls.Add(this.pnlTransfer);
            this.Controls.Add(this.txtTransferLicence);
            this.Controls.Add(this.btnTrasnferLicenceId);
            this.Controls.Add(this.lblEnterTvLicenceNumber);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmTransferLicence";
            this.Text = "Transfer Licence";
            this.Load += new System.EventHandler(this.frmTransferLicence_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlTransfer.ResumeLayout(false);
            this.pnlTransfer.PerformLayout();
            this.pnlUserInfoP.ResumeLayout(false);
            this.pnlUserInfoP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
   
        private System.Windows.Forms.Label lblEnterTvLicenceNumber;
        private System.Windows.Forms.Button btnTrasnferLicenceId;
        private System.Windows.Forms.TextBox txtTransferLicence;
        private System.Windows.Forms.Panel pnlTransfer;
        private System.Windows.Forms.Button btnTransferNewAddress;
        private System.Windows.Forms.ToolStripMenuItem MnuMain;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.ComboBox cbxCounties;
        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.Panel pnlUserInfoP;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnNewInfo;
        private System.Windows.Forms.Label lblCurnStreet;
        private System.Windows.Forms.Label lblCurnTown;
        private System.Windows.Forms.Label lblCurnCounty;
        private System.Windows.Forms.Label lblExpiry;
    }
}