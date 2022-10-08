
namespace Tv_Licence
{
    partial class frmOverdueLicence
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
            this.dgvOverdue = new System.Windows.Forms.DataGridView();
            this.btnSendNotice = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnuMain = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverdue)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOverdue
            // 
            this.dgvOverdue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOverdue.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvOverdue.Location = new System.Drawing.Point(32, 46);
            this.dgvOverdue.Name = "dgvOverdue";
            this.dgvOverdue.RowTemplate.Height = 25;
            this.dgvOverdue.Size = new System.Drawing.Size(845, 356);
            this.dgvOverdue.TabIndex = 96;
            this.dgvOverdue.Visible = false;
            // 
            // btnSendNotice
            // 
            this.btnSendNotice.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSendNotice.Location = new System.Drawing.Point(204, 419);
            this.btnSendNotice.Name = "btnSendNotice";
            this.btnSendNotice.Size = new System.Drawing.Size(112, 40);
            this.btnSendNotice.TabIndex = 94;
            this.btnSendNotice.Text = "Send Notice";
            this.btnSendNotice.UseVisualStyleBackColor = false;
            this.btnSendNotice.Click += new System.EventHandler(this.btnSendNotice_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuMain});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(911, 24);
            this.menuStrip1.TabIndex = 93;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MnuMain
            // 
            this.MnuMain.Name = "MnuMain";
            this.MnuMain.Size = new System.Drawing.Size(52, 20);
            this.MnuMain.Text = "Home";
            this.MnuMain.Click += new System.EventHandler(this.MnuMain_Click_1);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLoad.Location = new System.Drawing.Point(32, 419);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(112, 40);
            this.btnLoad.TabIndex = 97;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // frmOverdueLicence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(911, 471);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dgvOverdue);
            this.Controls.Add(this.btnSendNotice);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmOverdueLicence";
            this.Text = "Overdue Licenses";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverdue)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOverdue;
        private System.Windows.Forms.Button btnSendNotice;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnuMain;
        private System.Windows.Forms.Button btnLoad;
    }
}