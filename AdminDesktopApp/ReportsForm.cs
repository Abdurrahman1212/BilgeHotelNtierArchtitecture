using System;
using System.Windows.Forms;

namespace AdminDesktopApp
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
            LoadReportData();
        }

        private void LoadReportData()
        {
            // Rapor verilerini yükle
            txtReport.Text = "Bu hafta rezervasyon raporu:\n- Toplam Rezervasyon: 150\n- Gelir: 45,000 TL\n- Doluluk Oranı: %85";
        }

        private void btnExportReport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rapor dışa aktarıldı.");
        }
    }
}
