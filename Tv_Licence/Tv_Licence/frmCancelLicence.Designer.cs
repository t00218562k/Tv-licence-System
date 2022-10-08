
namespace Tv_Licence
{
    partial class frmCancelLicence
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
            this.lblCancelTvLicence = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.txtCancelLicence = new System.Windows.Forms.TextBox();
            this.btnCancelLicence = new System.Windows.Forms.Button();
            this.pnlUserInfoP = new System.Windows.Forms.Panel();
            this.lblExpiry = new System.Windows.Forms.Label();
            this.lblCurnCounty = new System.Windows.Forms.Label();
            this.lblCurnTown = new System.Windows.Forms.Label();
            this.lblCurnStreet = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.pnlUserInfoP.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCancelTvLicence
            // 
            this.lblCancelTvLicence.AutoSize = true;
            this.lblCancelTvLicence.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCancelTvLicence.Location = new System.Drawing.Point(72, 64);
            this.lblCancelTvLicence.Name = "lblCancelTvLicence";
            this.lblCancelTvLicence.Size = new System.Drawing.Size(278, 35);
            this.lblCancelTvLicence.TabIndex = 0;
            this.lblCancelTvLicence.Text = "Enter your licence number";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuBack});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(538, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MnuBack
            // 
            this.MnuBack.Name = "MnuBack";
            this.MnuBack.Size = new System.Drawing.Size(52, 20);
            this.MnuBack.Text = "Home";
            this.MnuBack.Click += new System.EventHandler(this.MnuBack_Click);
            // 
            // txtCancelLicence
            // 
            this.txtCancelLicence.Location = new System.Drawing.Point(96, 128);
            this.txtCancelLicence.MaxLength = 9;
            this.txtCancelLicence.Name = "txtCancelLicence";
            this.txtCancelLicence.Size = new System.Drawing.Size(139, 23);
            this.txtCancelLicence.TabIndex = 7;
            // 
            // btnCancelLicence
            // 
            this.btnCancelLicence.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelLicence.Location = new System.Drawing.Point(264, 128);
            this.btnCancelLicence.Name = "btnCancelLicence";
            this.btnCancelLicence.Size = new System.Drawing.Size(75, 23);
            this.btnCancelLicence.TabIndex = 8;
            this.btnCancelLicence.Text = "Enter";
            this.btnCancelLicence.UseVisualStyleBackColor = false;
            this.btnCancelLicence.Click += new System.EventHandler(this.btnCancelLicence_Click);
            // 
            // pnlUserInfoP
            // 
            this.pnlUserInfoP.Controls.Add(this.lblExpiry);
            this.pnlUserInfoP.Controls.Add(this.lblCurnCounty);
            this.pnlUserInfoP.Controls.Add(this.lblCurnTown);
            this.pnlUserInfoP.Controls.Add(this.lblCurnStreet);
            this.pnlUserInfoP.Controls.Add(this.lblName);
            this.pnlUserInfoP.Controls.Add(this.lblUserInfo);
            this.pnlUserInfoP.Controls.Add(this.btnConfirm);
            this.pnlUserInfoP.Location = new System.Drawing.Point(12, 167);
            this.pnlUserInfoP.Name = "pnlUserInfoP";
            this.pnlUserInfoP.Size = new System.Drawing.Size(487, 371);
            this.pnlUserInfoP.TabIndex = 96;
            this.pnlUserInfoP.Visible = false;
            // 
            // lblExpiry
            // 
            this.lblExpiry.AutoSize = true;
            this.lblExpiry.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblExpiry.Location = new System.Drawing.Point(60, 252);
            this.lblExpiry.Name = "lblExpiry";
            this.lblExpiry.Size = new System.Drawing.Size(129, 35);
            this.lblExpiry.TabIndex = 99;
            this.lblExpiry.Text = "Expiry Date:";
            // 
            // lblCurnCounty
            // 
            this.lblCurnCounty.AutoSize = true;
            this.lblCurnCounty.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCurnCounty.Location = new System.Drawing.Point(60, 199);
            this.lblCurnCounty.Name = "lblCurnCounty";
            this.lblCurnCounty.Size = new System.Drawing.Size(91, 35);
            this.lblCurnCounty.TabIndex = 98;
            this.lblCurnCounty.Text = "County: ";
            // 
            // lblCurnTown
            // 
            this.lblCurnTown.AutoSize = true;
            this.lblCurnTown.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCurnTown.Location = new System.Drawing.Point(60, 153);
            this.lblCurnTown.Name = "lblCurnTown";
            this.lblCurnTown.Size = new System.Drawing.Size(76, 35);
            this.lblCurnTown.TabIndex = 97;
            this.lblCurnTown.Text = "Town: ";
            // 
            // lblCurnStreet
            // 
            this.lblCurnStreet.AutoSize = true;
            this.lblCurnStreet.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCurnStreet.Location = new System.Drawing.Point(60, 111);
            this.lblCurnStreet.Name = "lblCurnStreet";
            this.lblCurnStreet.Size = new System.Drawing.Size(81, 35);
            this.lblCurnStreet.TabIndex = 96;
            this.lblCurnStreet.Text = "Street: ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(60, 65);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(77, 35);
            this.lblName.TabIndex = 95;
            this.lblName.Text = "name: ";
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.AutoSize = true;
            this.lblUserInfo.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUserInfo.Location = new System.Drawing.Point(60, 24);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(235, 35);
            this.lblUserInfo.TabIndex = 94;
            this.lblUserInfo.Text = "Is this Your Information";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConfirm.Location = new System.Drawing.Point(166, 309);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(155, 43);
            this.btnConfirm.TabIndex = 11;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // frmCancelLicence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(538, 560);
            this.Controls.Add(this.pnlUserInfoP);
            this.Controls.Add(this.btnCancelLicence);
            this.Controls.Add(this.txtCancelLicence);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblCancelTvLicence);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmCancelLicence";
            this.Text = "Cancel licence";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlUserInfoP.ResumeLayout(false);
            this.pnlUserInfoP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCancelTvLicence;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnuBack;
        private System.Windows.Forms.TextBox txtCancelLicence;
        private System.Windows.Forms.Button btnCancelLicence;
        private System.Windows.Forms.Panel pnlUserInfoP;
        private System.Windows.Forms.Label lblCurnCounty;
        private System.Windows.Forms.Label lblCurnTown;
        private System.Windows.Forms.Label lblCurnStreet;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblExpiry;
    }
}