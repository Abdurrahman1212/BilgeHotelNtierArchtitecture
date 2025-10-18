using System;
using System.Windows.Forms;

namespace AdminDesktopApp
{
    public partial class EditCustomerForm : Form
    {
        private int _customerId;

        public EditCustomerForm(int customerId)
        {
            InitializeComponent();
            _customerId = customerId;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // TODO: Implement customer update logic
            MessageBox.Show($"Müşteri #{_customerId} düzenleme özelliği henüz uygulanmadı.");
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