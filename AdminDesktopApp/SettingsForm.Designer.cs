namespace AdminDesktopApp
{
    partial class SettingsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.CheckBox chkAutoBackup;
        private System.Windows.Forms.TextBox txtDatabaseConnection;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAutoBackup;
        private System.Windows.Forms.Label lblDatabaseConnection;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.chkAutoBackup = new System.Windows.Forms.CheckBox();
            this.txtDatabaseConnection = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAutoBackup = new System.Windows.Forms.Label();
            this.lblDatabaseConnection = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkAutoBackup
            // 
            this.chkAutoBackup.AutoSize = true;
            this.chkAutoBackup.Location = new System.Drawing.Point(150, 90);
            this.chkAutoBackup.Name = "chkAutoBackup";
            this.chkAutoBackup.Size = new System.Drawing.Size(15, 14);
            this.chkAutoBackup.TabIndex = 0;
            this.chkAutoBackup.UseVisualStyleBackColor = true;
            // 
            // lblAutoBackup
            // 
            this.lblAutoBackup.AutoSize = true;
            this.lblAutoBackup.Location = new System.Drawing.Point(20, 90);
            this.lblAutoBackup.Name = "lblAutoBackup";
            this.lblAutoBackup.Size = new System.Drawing.Size(100, 15);
            this.lblAutoBackup.TabIndex = 1;
            this.lblAutoBackup.Text = "Otomatik Yedekleme";
            // 
            // txtDatabaseConnection
            // 
            this.txtDatabaseConnection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDatabaseConnection.Location = new System.Drawing.Point(150, 120);
            this.txtDatabaseConnection.Name = "txtDatabaseConnection";
            this.txtDatabaseConnection.Size = new System.Drawing.Size(620, 23);
            this.txtDatabaseConnection.TabIndex = 2;
            // 
            // lblDatabaseConnection
            // 
            this.lblDatabaseConnection.AutoSize = true;
            this.lblDatabaseConnection.Location = new System.Drawing.Point(20, 123);
            this.lblDatabaseConnection.Name = "lblDatabaseConnection";
            this.lblDatabaseConnection.Size = new System.Drawing.Size(120, 15);
            this.lblDatabaseConnection.TabIndex = 3;
            this.lblDatabaseConnection.Text = "Veritabanı Bağlantısı";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 60);
            this.panel1.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(90, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Ayarlar";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDatabaseConnection);
            this.Controls.Add(this.txtDatabaseConnection);
            this.Controls.Add(this.lblAutoBackup);
            this.Controls.Add(this.chkAutoBackup);
            this.Name = "SettingsForm";
            this.Text = "Ayarlar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}