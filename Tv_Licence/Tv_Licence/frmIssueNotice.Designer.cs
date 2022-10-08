
namespace Tv_Licence
{
    partial class frmIssueNotice
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
            this.btnSendNotice = new System.Windows.Forms.Button();
            this.dgvNotice = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotice)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuMain});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(918, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MnuMain
            // 
            this.MnuMain.Name = "MnuMain";
            this.MnuMain.Size = new System.Drawing.Size(52, 20);
            this.MnuMain.Text = "Home";
            this.MnuMain.Click += new System.EventHandler(this.MnuMain_Click);
            // 
            // btnSendNotice
            // 
            this.btnSendNotice.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSendNotice.Location = new System.Drawing.Point(207, 426);
            this.btnSendNotice.Name = "btnSendNotice";
            this.btnSendNotice.Size = new System.Drawing.Size(112, 40);
            this.btnSendNotice.TabIndex = 12;
            this.btnSendNotice.Text = "Send Notice";
            this.btnSendNotice.UseVisualStyleBackColor = false;
            this.btnSendNotice.Click += new System.EventHandler(this.btnSendNotice_Click);
            // 
            // dgvNotice
            // 
            this.dgvNotice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotice.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvNotice.Location = new System.Drawing.Point(32, 45);
            this.dgvNotice.Name = "dgvNotice";
            this.dgvNotice.RowTemplate.Height = 25;
            this.dgvNotice.Size = new System.Drawing.Size(845, 356);
            this.dgvNotice.TabIndex = 92;
            this.dgvNotice.Visible = false;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLoad.Location = new System.Drawing.Point(32, 426);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(112, 40);
            this.btnLoad.TabIndex = 93;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // frmIssueNotice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(918, 478);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dgvNotice);
            this.Controls.Add(this.btnSendNotice);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmIssueNotice";
            this.Text = "Issue Notice";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnuMain;
        private System.Windows.Forms.Button btnSendNotice;
        private System.Windows.Forms.DataGridView dgvNotice;
        private System.Windows.Forms.Button btnLoad;
    }
}