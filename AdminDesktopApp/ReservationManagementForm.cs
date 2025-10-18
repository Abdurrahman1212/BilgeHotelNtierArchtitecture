using System;
using System.Windows.Forms;

namespace AdminDesktopApp
{
    public partial class ReservationManagementForm : Form
    {
        public ReservationManagementForm()
        {
            this.Text = "Rezervasyon Yönetimi";
            this.Size = new System.Drawing.Size(600, 400);
            MessageBox.Show("Rezervasyon yönetimi formu açıldı!");
        }
    }
}
