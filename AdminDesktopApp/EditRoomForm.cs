using System;
using System.Windows.Forms;

namespace AdminDesktopApp
{
    public partial class EditRoomForm : Form
    {
        private int _roomId;

        public EditRoomForm(int roomId)
        {
            InitializeComponent();
            _roomId = roomId;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Oda #{_roomId} düzenleme özelliği henüz uygulanmadı.");
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