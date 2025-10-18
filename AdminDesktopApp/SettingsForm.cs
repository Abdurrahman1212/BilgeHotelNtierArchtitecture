using System;
using System.Windows.Forms;

namespace AdminDesktopApp
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            LoadSettings();
        }

        private void LoadSettings()
        {
            // Ayarları yükle
            chkAutoBackup.Checked = true;
            txtDatabaseConnection.Text = "Server=localhost;Database=BilgeHotel;User=admin;Password=***";
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            // Ayarları kaydet
            MessageBox.Show("Ayarlar kaydedildi.");
        }
    }
}
