
namespace Tv_Licence
{
    partial class frmRenewLicence
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnuMain = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCardNum = new System.Windows.Forms.Label();
            this.lblCardName = new System.Windows.Forms.Label();
            this.lblCardExpiry = new System.Windows.Forms.Label();
            this.lblCVV = new System.Windows.Forms.Label();
            this.txtCardNum = new System.Windows.Forms.TextBox();
            this.txtCardName = new System.Windows.Forms.TextBox();
            this.txtExpiry = new System.Windows.Forms.TextBox();
            this.txtCVV = new System.Windows.Forms.TextBox();
            this.btnRenew = new System.Windows.Forms.Button();
            this.btnId = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.pnlRenew = new System.Windows.Forms.Panel();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnlRenew.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(318, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Renew your licence";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuMain});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(872, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MnuMain
            // 
            this.MnuMain.Name = "MnuMain";
            this.MnuMain.Size = new System.Drawing.Size(52, 20);
            this.MnuMain.Text = "Home";
            this.MnuMain.Click += new System.EventHandler(this.MnuMain_Click);
            // 
            // lblCardNum
            // 
            this.lblCardNum.AutoSize = true;
            this.lblCardNum.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCardNum.Location = new System.Drawing.Point(459, 31);
            this.lblCardNum.Name = "lblCardNum";
            this.lblCardNum.Size = new System.Drawing.Size(140, 35);
            this.lblCardNum.TabIndex = 13;
            this.lblCardNum.Text = "Card Number";
            // 
            // lblCardName
            // 
            this.lblCardName.AutoSize = true;
            this.lblCardName.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCardName.Location = new System.Drawing.Point(482, 87);
            this.lblCardName.Name = "lblCardName";
            this.lblCardName.Size = new System.Drawing.Size(117, 35);
            this.lblCardName.TabIndex = 14;
            this.lblCardName.Text = "Card Name";
            // 
            // lblCardExpiry
            // 
            this.lblCardExpiry.AutoSize = true;
            this.lblCardExpiry.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCardExpiry.Location = new System.Drawing.Point(476, 140);
            this.lblCardExpiry.Name = "lblCardExpiry";
            this.lblCardExpiry.Size = new System.Drawing.Size(123, 35);
            this.lblCardExpiry.TabIndex = 15;
            this.lblCardExpiry.Text = "Expiry Date";
            // 
            // lblCVV
            // 
            this.lblCVV.AutoSize = true;
            this.lblCVV.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCVV.Location = new System.Drawing.Point(545, 184);
            this.lblCVV.Name = "lblCVV";
            this.lblCVV.Size = new System.Drawing.Size(54, 35);
            this.lblCVV.TabIndex = 16;
            this.lblCVV.Text = "CVV";
            // 
            // txtCardNum
            // 
            this.txtCardNum.Location = new System.Drawing.Point(622, 42);
            this.txtCardNum.MaxLength = 16;
            this.txtCardNum.Name = "txtCardNum";
            this.txtCardNum.Size = new System.Drawing.Size(144, 23);
            this.txtCardNum.TabIndex = 94;
            // 
            // txtCardName
            // 
            this.txtCardName.Location = new System.Drawing.Point(622, 97);
            this.txtCardName.MaxLength = 50;
            this.txtCardName.Name = "txtCardName";
            this.txtCardName.Size = new System.Drawing.Size(208, 23);
            this.txtCardName.TabIndex = 95;
            // 
            // txtExpiry
            // 
            this.txtExpiry.Location = new System.Drawing.Point(622, 150);
            this.txtExpiry.MaxLength = 5;
            this.txtExpiry.Name = "txtExpiry";
            this.txtExpiry.Size = new System.Drawing.Size(64, 23);
            this.txtExpiry.TabIndex = 96;
            // 
            // txtCVV
            // 
            this.txtCVV.Location = new System.Drawing.Point(622, 196);
            this.txtCVV.MaxLength = 3;
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.Size = new System.Drawing.Size(40, 23);
            this.txtCVV.TabIndex = 97;
            // 
            // btnRenew
            // 
            this.btnRenew.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRenew.Location = new System.Drawing.Point(622, 271);
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.Size = new System.Drawing.Size(120, 32);
            this.btnRenew.TabIndex = 98;
            this.btnRenew.Text = "Renew";
            this.btnRenew.UseVisualStyleBackColor = false;
            this.btnRenew.Click += new System.EventHandler(this.btnRenew_Click);
            // 
            // btnId
            // 
            this.btnId.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnId.Location = new System.Drawing.Point(201, 80);
            this.btnId.Name = "btnId";
            this.btnId.Size = new System.Drawing.Size(79, 23);
            this.btnId.TabIndex = 98;
            this.btnId.Text = "Search";
            this.btnId.UseVisualStyleBackColor = false;
            this.btnId.Click += new System.EventHandler(this.btnId_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(111, 81);
            this.txtId.MaxLength = 8;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(84, 23);
            this.txtId.TabIndex = 90;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblId.Location = new System.Drawing.Point(71, 72);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(34, 35);
            this.lblId.TabIndex = 96;
            this.lblId.Text = "Id";
            // 
            // pnlRenew
            // 
            this.pnlRenew.Controls.Add(this.txtLastName);
            this.pnlRenew.Controls.Add(this.lblFirstName);
            this.pnlRenew.Controls.Add(this.txtEmail);
            this.pnlRenew.Controls.Add(this.txtFirstName);
            this.pnlRenew.Controls.Add(this.lblEmail);
            this.pnlRenew.Controls.Add(this.lblLastName);
            this.pnlRenew.Controls.Add(this.btnRenew);
            this.pnlRenew.Controls.Add(this.lblCardNum);
            this.pnlRenew.Controls.Add(this.txtCardNum);
            this.pnlRenew.Controls.Add(this.lblCardName);
            this.pnlRenew.Controls.Add(this.txtCVV);
            this.pnlRenew.Controls.Add(this.txtCardName);
            this.pnlRenew.Controls.Add(this.lblCardExpiry);
            this.pnlRenew.Controls.Add(this.lblCVV);
            this.pnlRenew.Controls.Add(this.txtExpiry);
            this.pnlRenew.Location = new System.Drawing.Point(12, 124);
            this.pnlRenew.Name = "pnlRenew";
            this.pnlRenew.Size = new System.Drawing.Size(848, 329);
            this.pnlRenew.TabIndex = 99;
            this.pnlRenew.Visible = false;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(189, 87);
            this.txtLastName.MaxLength = 30;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(176, 23);
            this.txtLastName.TabIndex = 92;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFirstName.Location = new System.Drawing.Point(45, 31);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(115, 35);
            this.lblFirstName.TabIndex = 103;
            this.lblFirstName.Text = "First Name";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(189, 140);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(248, 23);
            this.txtEmail.TabIndex = 93;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(189, 39);
            this.txtFirstName.MaxLength = 30;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(176, 23);
            this.txtFirstName.TabIndex = 91;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(86, 128);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(74, 35);
            this.lblEmail.TabIndex = 96;
            this.lblEmail.Text = "Email ";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLastName.Location = new System.Drawing.Point(45, 79);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(111, 35);
            this.lblLastName.TabIndex = 92;
            this.lblLastName.Text = "Last Name";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmRenewLicence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(872, 462);
            this.Controls.Add(this.pnlRenew);
            this.Controls.Add(this.btnId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Name = "frmRenewLicence";
            this.Text = "Renew Licence";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlRenew.ResumeLayout(false);
            this.pnlRenew.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lblCardNum;
        private System.Windows.Forms.Label lblCardName;
        private System.Windows.Forms.Label lblCardExpiry;
        private System.Windows.Forms.Label lblCVV;
        private System.Windows.Forms.TextBox txtCardNum;
        private System.Windows.Forms.TextBox txtCardName;
        private System.Windows.Forms.TextBox txtExpiry;
        private System.Windows.Forms.TextBox txtCVV;
        private System.Windows.Forms.Button btnRenew;
        private System.Windows.Forms.ToolStripMenuItem MnuMain;
        private System.Windows.Forms.Button btnId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Panel pnlRenew;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblLastName;
    }
}