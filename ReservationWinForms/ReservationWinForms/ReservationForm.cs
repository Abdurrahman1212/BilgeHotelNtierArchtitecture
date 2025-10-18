using Models.Entities;
using Models.Enums;
using BussinessLogicLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ReservationWinForms;

public partial class ReservationForm : Form
{
    private readonly PricingService _pricingService;
    private readonly ReservationSyncService _syncService;
    private readonly ExtraChargesService _extraChargesService;
    private readonly IdentityVerificationService _identityVerificationService;
    private List<Room> _availableRooms;
    private Room _selectedRoom;
    private List<ExtraCharge> _currentExtraCharges;

    public ReservationForm()
    {
        InitializeComponent();
        _pricingService = new PricingService();
        _syncService = ReservationSyncService.Instance;
        _extraChargesService = new ExtraChargesService();
        _identityVerificationService = new IdentityVerificationService();

        LoadCustomers();
        LoadRooms();
        SetupEventHandlers();
        _currentExtraCharges = new List<ExtraCharge>();
    }

    private void LoadCustomers()
    {
        // Müşterileri yükle - Business Logic katmanından gelecek
        var customers = new List<Customer>
        {
            new Customer { Id = 1, FirstName = "Ahmet", LastName = "Yılmaz", Email = "ahmet@example.com" },
            new Customer { Id = 2, FirstName = "Ayşe", LastName = "Demir", Email = "ayse@example.com" }
        };

        cmbCustomers.DataSource = customers;
        cmbCustomers.DisplayMember = "FirstName";
        cmbCustomers.ValueMember = "Id";
    }

    private void LoadRooms()
    {
        // Tüm odaları yükle
        var roomInitService = new RoomInitializationService();
        var allRooms = roomInitService.InitializeHotelRooms();

        // Sadece müsait odaları göster
        DateTime checkInDate = dtpCheckIn.Value.Date;
        DateTime checkOutDate = dtpCheckOut.Value.Date;

        _availableRooms = _syncService.GetAvailableRooms(allRooms, checkInDate, checkOutDate);

        cmbRooms.DataSource = _availableRooms;
        cmbRooms.DisplayMember = "RoomNumber";
        cmbRooms.ValueMember = "Id";

        UpdateRoomDetails();
    }

    private void SetupEventHandlers()
    {
        dtpCheckIn.ValueChanged += (s, e) => { LoadRooms(); CalculateTotal(); };
        dtpCheckOut.ValueChanged += (s, e) => { LoadRooms(); CalculateTotal(); };
        cmbRooms.SelectedIndexChanged += (s, e) => { UpdateRoomDetails(); CalculateTotal(); };
        cmbPackageType.SelectedIndexChanged += (s, e) => CalculateTotal();
    }

    private void UpdateRoomDetails()
    {
        if (cmbRooms.SelectedItem != null)
        {
            _selectedRoom = (Room)cmbRooms.SelectedItem;
            lblRoomType.Text = $"Oda Tipi: {_pricingService.GetRoomTypeDescription(_selectedRoom.Type)}";
            lblRoomCapacity.Text = $"Kapasite: {_selectedRoom.RoomCapacity} kişi";
            lblRoomFeatures.Text = $"Özellikler: {string.Join(", ", _pricingService.GetRoomFeatures(_selectedRoom))}";
        }
    }

    private void CalculateTotal()
    {
        if (_selectedRoom != null && cmbPackageType.SelectedItem != null && dtpCheckIn.Value < dtpCheckOut.Value)
        {
            var packageType = (PackageType)cmbPackageType.SelectedItem;
            var nights = (dtpCheckOut.Value - dtpCheckIn.Value).Days;
            var totalAmount = _pricingService.CalculateTotalPrice(_selectedRoom, packageType, nights, dtpCheckIn.Value);

            txtTotalAmount.Text = totalAmount.ToString("F2");
        }
    }

    private void btnCheckAvailability_Click(object sender, EventArgs e)
    {
        LoadRooms();
        MessageBox.Show($"Bulunan {_availableRooms.Count} adet müsait oda.");
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        if (ValidateReservation())
        {
            try
            {
                var selectedCustomer = (Customer)cmbCustomers.SelectedItem;
                var packageType = (PackageType)cmbPackageType.SelectedItem;

                string errorMessage;
                bool success = _syncService.TryReserveRoom(
                    _selectedRoom,
                    dtpCheckIn.Value,
                    dtpCheckOut.Value,
                    packageType,
                    out errorMessage);

                if (success)
                {
                    MessageBox.Show("Rezervasyon başarıyla oluşturuldu!");

                    // Formu kapat ve ana formu yenile
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Rezervasyon oluşturulamadı: {errorMessage}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private void btnVerifyIdentity_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtIdentityNumber.Text) || txtIdentityNumber.Text.Length != 11)
        {
            MessageBox.Show("Lütfen geçerli bir TC Kimlik Numarası girin (11 haneli).", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (string.IsNullOrEmpty(txtCustomerFirstName.Text) || string.IsNullOrEmpty(txtCustomerLastName.Text))
        {
            MessageBox.Show("Lütfen ad ve soyad bilgilerini girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var birthYear = txtBirthYear.Text;
        if (string.IsNullOrEmpty(birthYear) || birthYear.Length != 4)
        {
            MessageBox.Show("Lütfen geçerli bir doğum yılı girin (4 haneli).", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        // btnVerifyIdentity.Enabled = false;
        // btnVerifyIdentity.Text = "Doğrulanıyor...";

        try
        {
            var result = _identityVerificationService.VerifyIdentityAsync(
                txtCustomerFirstName.Text,
                txtCustomerLastName.Text,
                birthYear,
                txtIdentityNumber.Text).Result;

            if (result.IsValid)
            {
                MessageBox.Show("TC Kimlik Numarası başarıyla doğrulandı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // txtIdentityNumber.ReadOnly = true;
            }
            else
            {
                MessageBox.Show($"TC Kimlik Numarası doğrulanamadı: {result.ErrorMessage}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Doğrulama sırasında hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            // btnVerifyIdentity.Enabled = true;
            // btnVerifyIdentity.Text = "TC No Doğrula";
        }
    }

    private void btnQueryIdentity_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtCustomerFirstName.Text) || string.IsNullOrEmpty(txtCustomerLastName.Text))
        {
            MessageBox.Show("Lütfen ad ve soyad bilgilerini girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var birthYear = txtBirthYear.Text;
        if (string.IsNullOrEmpty(birthYear) || birthYear.Length != 4)
        {
            MessageBox.Show("Lütfen geçerli bir doğum yılı girin (4 haneli).", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        // btnQueryIdentity.Enabled = false;
        // btnQueryIdentity.Text = "Sorgulanıyor...";

        try
        {
            var identityNumber = _identityVerificationService.GetIdentityNumberAsync(
                txtCustomerFirstName.Text,
                txtCustomerLastName.Text,
                birthYear).Result;

            if (!string.IsNullOrEmpty(identityNumber))
            {
                // txtIdentityNumber.Text = identityNumber;
                MessageBox.Show($"TC Kimlik Numarası bulundu: {identityNumber}", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // txtIdentityNumber.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("TC Kimlik Numarası bulunamadı. Lütfen manuel olarak girin.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Sorgulama sırasında hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            // btnQueryIdentity.Enabled = true;
            // btnQueryIdentity.Text = "TC No Sorgula";
        }
    }

    private void btnAddExtraCharge_Click(object sender, EventArgs e)
    {
        var chargeForm = new ExtraChargeForm();
        if (chargeForm.ShowDialog() == DialogResult.OK)
        {
            var charge = chargeForm.ExtraCharge;
            _currentExtraCharges.Add(charge);
            UpdateExtraChargesList();
            UpdateTotalAmount();
        }
    }

    private void UpdateExtraChargesList()
    {
        dgvExtraCharges.Rows.Clear();
        dgvExtraCharges.Columns.Clear();

        // Sütunları ekle
        dgvExtraCharges.Columns.Add("Id", "ID");
        dgvExtraCharges.Columns.Add("ChargeType", "Harcama Türü");
        dgvExtraCharges.Columns.Add("Description", "Açıklama");
        dgvExtraCharges.Columns.Add("Amount", "Tutar");
        dgvExtraCharges.Columns.Add("Quantity", "Miktar");
        dgvExtraCharges.Columns.Add("TotalAmount", "Toplam Tutar");

        // Ek ücretleri listeye ekleme işlemi
        foreach (var charge in _currentExtraCharges)
        {
            dgvExtraCharges.Rows.Add(
                charge.Id,
                _extraChargesService.GetChargeTypeDescription(charge.ChargeType),
                charge.Description,
                charge.Amount,
                charge.Quantity,
                charge.TotalAmount
            );
        }

        // Ek ücret eklendiğinde kullanıcıya bilgi ver
        if (_currentExtraCharges.Any())
        {
            var totalExtraCharges = _currentExtraCharges.Sum(c => c.TotalAmount);
            MessageBox.Show($"{_currentExtraCharges.Count} adet ek ücret eklendi. Toplam ek ücret: {totalExtraCharges:C}",
                          "Ek Ücret Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void UpdateTotalAmount()
    {
        if (_selectedRoom != null && cmbPackageType.SelectedItem != null && dtpCheckIn.Value < dtpCheckOut.Value)
        {
            var packageType = (PackageType)cmbPackageType.SelectedItem;
            var nights = (dtpCheckOut.Value - dtpCheckIn.Value).Days;
            var baseAmount = _pricingService.CalculateTotalPrice(_selectedRoom, packageType, nights, dtpCheckIn.Value);

            var extraChargesTotal = _currentExtraCharges.Sum(c => c.TotalAmount);
            var totalAmount = baseAmount + extraChargesTotal;

            txtTotalAmount.Text = totalAmount.ToString("F2");
        }
    }

    private bool ValidateReservation()
    {
        if (cmbCustomers.SelectedItem == null)
        {
            MessageBox.Show("Lütfen bir müşteri seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (cmbRooms.SelectedItem == null)
        {
            MessageBox.Show("Lütfen bir oda seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (dtpCheckIn.Value >= dtpCheckOut.Value)
        {
            MessageBox.Show("Giriş tarihi çıkış tarihinden önce olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (dtpCheckIn.Value < DateTime.Now.Date)
        {
            MessageBox.Show("Giriş tarihi bugün veya sonraki bir tarih olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        return true;
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
