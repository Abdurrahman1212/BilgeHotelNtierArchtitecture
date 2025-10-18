using System;
using System.Windows.Forms;

namespace AdminDesktopApp
{
    public partial class EditReservationForm : Form
    {
        private int _reservationId;

        public EditReservationForm(int reservationId)
        {
            InitializeComponent();
            _reservationId = reservationId;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Rezervasyon #{_reservationId} düzenleme özelliği henüz uygulanmadı.");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}