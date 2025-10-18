using Models.Entities;
using Models.Enums;
using BussinessLogicLayer.Services;
using System;
using System.Windows.Forms;

namespace ReservationWinForms;

public partial class ExtraChargeForm : Form
{
    private readonly ExtraChargesService _extraChargesService;

    public ExtraCharge ExtraCharge { get; private set; }

    public ExtraChargeForm()
    {
        InitializeComponent();
        _extraChargesService = new ExtraChargesService();
        ExtraCharge = new ExtraCharge(); // Initialize to avoid null warning

        LoadChargeTypes();
    }

    private void LoadChargeTypes()
    {
        var chargeTypes = _extraChargesService.GetAvailableChargeTypes();
        cmbChargeType.DataSource = chargeTypes;
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        if (ValidateForm())
        {
            ExtraCharge = new ExtraCharge
            {
                ChargeType = Enum.Parse<ExtraChargeType>(cmbChargeType.SelectedItem.ToString()),
                Description = txtDescription.Text,
                Amount = decimal.Parse(txtAmount.Text),
                Quantity = int.Parse(txtQuantity.Text),
                ChargeDate = DateTime.Now
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }

    private bool ValidateForm()
    {
        if (cmbChargeType.SelectedIndex == -1)
        {
            MessageBox.Show("Lütfen bir harcama türü seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (string.IsNullOrEmpty(txtDescription.Text))
        {
            MessageBox.Show("Lütfen açıklama girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (!decimal.TryParse(txtAmount.Text, out decimal amount) || amount <= 0)
        {
            MessageBox.Show("Lütfen geçerli bir tutar girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0)
        {
            MessageBox.Show("Lütfen geçerli bir miktar girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        return true;
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }
}
