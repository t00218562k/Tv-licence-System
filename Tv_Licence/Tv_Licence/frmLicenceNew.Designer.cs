
namespace Tv_Licence
{
    partial class frmLicenceNew
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MnuMain = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnApply = new System.Windows.Forms.Button();
            this.txtCVV = new System.Windows.Forms.TextBox();
            this.txtExpiry = new System.Windows.Forms.TextBox();
            this.txtCardName = new System.Windows.Forms.TextBox();
            this.txtCardNum = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblCVV = new System.Windows.Forms.Label();
            this.lblCardExpiry = new System.Windows.Forms.Label();
            this.lblCardName = new System.Windows.Forms.Label();
            this.lblCardNum = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCounty = new System.Windows.Forms.Label();
            this.lblTown = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.cbxCounties = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnuMain
            // 
            this.MnuMain.Name = "MnuMain";
            this.MnuMain.Size = new System.Drawing.Size(52, 20);
            this.MnuMain.Text = "Home";
            this.MnuMain.Click += new System.EventHandler(this.MnuMain_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuMain});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1023, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnApply.Location = new System.Drawing.Point(734, 260);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(120, 32);
            this.btnApply.TabIndex = 83;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // txtCVV
            // 
            this.txtCVV.Location = new System.Drawing.Point(734, 196);
            this.txtCVV.MaxLength = 3;
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.Size = new System.Drawing.Size(40, 23);
            this.txtCVV.TabIndex = 82;
            // 
            // txtExpiry
            // 
            this.txtExpiry.Location = new System.Drawing.Point(734, 140);
            this.txtExpiry.MaxLength = 5;
            this.txtExpiry.Name = "txtExpiry";
            this.txtExpiry.Size = new System.Drawing.Size(64, 23);
            this.txtExpiry.TabIndex = 81;
            // 
            // txtCardName
            // 
            this.txtCardName.Location = new System.Drawing.Point(734, 84);
            this.txtCardName.MaxLength = 50;
            this.txtCardName.Name = "txtCardName";
            this.txtCardName.Size = new System.Drawing.Size(208, 23);
            this.txtCardName.TabIndex = 80;
            // 
            // txtCardNum
            // 
            this.txtCardNum.Location = new System.Drawing.Point(734, 28);
            this.txtCardNum.MaxLength = 16;
            this.txtCardNum.Name = "txtCardNum";
            this.txtCardNum.Size = new System.Drawing.Size(144, 23);
            this.txtCardNum.TabIndex = 79;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(234, 300);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(248, 23);
            this.txtEmail.TabIndex = 78;
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(234, 188);
            this.txtTown.MaxLength = 30;
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(176, 23);
            this.txtTown.TabIndex = 76;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(234, 132);
            this.txtStreet.MaxLength = 50;
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(232, 23);
            this.txtStreet.TabIndex = 75;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(234, 28);
            this.txtFirstName.MaxLength = 30;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(176, 23);
            this.txtFirstName.TabIndex = 73;
            // 
            // lblCVV
            // 
            this.lblCVV.AutoSize = true;
            this.lblCVV.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCVV.Location = new System.Drawing.Point(644, 188);
            this.lblCVV.Name = "lblCVV";
            this.lblCVV.Size = new System.Drawing.Size(54, 35);
            this.lblCVV.TabIndex = 72;
            this.lblCVV.Text = "CVV";
            // 
            // lblCardExpiry
            // 
            this.lblCardExpiry.AutoSize = true;
            this.lblCardExpiry.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCardExpiry.Location = new System.Drawing.Point(575, 132);
            this.lblCardExpiry.Name = "lblCardExpiry";
            this.lblCardExpiry.Size = new System.Drawing.Size(123, 35);
            this.lblCardExpiry.TabIndex = 71;
            this.lblCardExpiry.Text = "Expiry Date";
            // 
            // lblCardName
            // 
            this.lblCardName.AutoSize = true;
            this.lblCardName.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCardName.Location = new System.Drawing.Point(582, 76);
            this.lblCardName.Name = "lblCardName";
            this.lblCardName.Size = new System.Drawing.Size(117, 35);
            this.lblCardName.TabIndex = 70;
            this.lblCardName.Text = "Card Name";
            // 
            // lblCardNum
            // 
            this.lblCardNum.AutoSize = true;
            this.lblCardNum.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCardNum.Location = new System.Drawing.Point(558, 20);
            this.lblCardNum.Name = "lblCardNum";
            this.lblCardNum.Size = new System.Drawing.Size(140, 35);
            this.lblCardNum.TabIndex = 69;
            this.lblCardNum.Text = "Card Number";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(127, 288);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(74, 35);
            this.lblEmail.TabIndex = 68;
            this.lblEmail.Text = "Email ";
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCounty.Location = new System.Drawing.Point(119, 235);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(80, 35);
            this.lblCounty.TabIndex = 67;
            this.lblCounty.Text = "County";
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTown.Location = new System.Drawing.Point(134, 183);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(65, 35);
            this.lblTown.TabIndex = 66;
            this.lblTown.Text = "Town";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStreet.Location = new System.Drawing.Point(50, 124);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(149, 35);
            this.lblStreet.TabIndex = 64;
            this.lblStreet.Text = "Address Street";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLastName.Location = new System.Drawing.Point(90, 68);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(111, 35);
            this.lblLastName.TabIndex = 63;
            this.lblLastName.Text = "Last Name";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(418, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 35);
            this.label2.TabIndex = 62;
            this.label2.Text = "Purchase Licence";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFirstName.Location = new System.Drawing.Point(90, 20);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(115, 35);
            this.lblFirstName.TabIndex = 90;
            this.lblFirstName.Text = "First Name";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(234, 76);
            this.txtLastName.MaxLength = 30;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(176, 23);
            this.txtLastName.TabIndex = 74;
            // 
            // pnlInfo
            // 
            this.pnlInfo.Controls.Add(this.cbxCounties);
            this.pnlInfo.Controls.Add(this.lblFirstName);
            this.pnlInfo.Controls.Add(this.lblLastName);
            this.pnlInfo.Controls.Add(this.lblStreet);
            this.pnlInfo.Controls.Add(this.lblTown);
            this.pnlInfo.Controls.Add(this.btnApply);
            this.pnlInfo.Controls.Add(this.txtCVV);
            this.pnlInfo.Controls.Add(this.lblCounty);
            this.pnlInfo.Controls.Add(this.txtExpiry);
            this.pnlInfo.Controls.Add(this.txtCardName);
            this.pnlInfo.Controls.Add(this.lblEmail);
            this.pnlInfo.Controls.Add(this.txtCardNum);
            this.pnlInfo.Controls.Add(this.txtLastName);
            this.pnlInfo.Controls.Add(this.lblCVV);
            this.pnlInfo.Controls.Add(this.txtFirstName);
            this.pnlInfo.Controls.Add(this.lblCardExpiry);
            this.pnlInfo.Controls.Add(this.txtStreet);
            this.pnlInfo.Controls.Add(this.lblCardName);
            this.pnlInfo.Controls.Add(this.lblCardNum);
            this.pnlInfo.Controls.Add(this.txtTown);
            this.pnlInfo.Controls.Add(this.txtEmail);
            this.pnlInfo.Location = new System.Drawing.Point(12, 122);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(990, 367);
            this.pnlInfo.TabIndex = 98;
            // 
            // cbxCounties
            // 
            this.cbxCounties.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCounties.FormattingEnabled = true;
            this.cbxCounties.Location = new System.Drawing.Point(234, 247);
            this.cbxCounties.Name = "cbxCounties";
            this.cbxCounties.Size = new System.Drawing.Size(169, 23);
            this.cbxCounties.TabIndex = 77;
            // 
            // frmLicenceNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1023, 501);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmLicenceNew";
            this.Text = "Purchase Licence";
            this.Load += new System.EventHandler(this.frmLicenceNew_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem MnuMain;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.TextBox txtCVV;
        private System.Windows.Forms.TextBox txtExpiry;
        private System.Windows.Forms.TextBox txtCardName;
        private System.Windows.Forms.TextBox txtCardNum;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblCVV;
        private System.Windows.Forms.Label lblCardExpiry;
        private System.Windows.Forms.Label lblCardName;
        private System.Windows.Forms.Label lblCardNum;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.ComboBox cbxCounties;
    }
}

