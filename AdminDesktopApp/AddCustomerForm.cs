using System;
using System.Windows.Forms;

namespace AdminDesktopApp
{
    public partial class AddCustomerForm : Form
    {
        public AddCustomerForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // TODO: Implement customer creation logic
            MessageBox.Show("Müşteri ekleme özelliği henüz uygulanmadı.");
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