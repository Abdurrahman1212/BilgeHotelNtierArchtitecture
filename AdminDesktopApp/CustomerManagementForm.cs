using Models.Entities;
using DataAccessLayer.Services.Concretes;
using DataAccessLayer.Configurations.Context;
using DataAccessLayer.Services.Abstracs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace AdminDesktopApp
{
    public partial class CustomerManagementForm : Form, IDisposable
    {
        private readonly CustomerRepo _customerRepo;
        private List<Customer> _customers;
        private readonly ProjectDatabaseContext _context;

        public CustomerManagementForm()
        {
            try
            {
                InitializeComponent();
                var optionsBuilder = new DbContextOptionsBuilder<ProjectDatabaseContext>();
                optionsBuilder.UseSqlServer("Server=.;Database=HotelDB;Trusted_Connection=True;TrustServerCertificate=True;");
                _context = new ProjectDatabaseContext(optionsBuilder.Options);
                _customerRepo = new CustomerRepo(_context);
                LoadCustomers();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Başlatma hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            try
            {
                ConfigureGridView();
                LoadCustomers();
            }
            catch (Exception ex)
            {
                HandleError("Form yüklenirken hata oluştu", ex);
            }
        }

        private void ConfigureGridView()
        {
            dgvCustomers.AutoGenerateColumns = false;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.MultiSelect = false;
            dgvCustomers.ReadOnly = true;
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AllowUserToDeleteRows = false;
        }

        private void HandleError(string message, Exception ex)
        {
            MessageBox.Show($"{message}: {ex.Message}\n\nDetaylar: {ex.StackTrace}",
                "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            // Log the error
            System.Diagnostics.Debug.WriteLine($"Error: {message}\n{ex}");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    dgvCustomers.DataSource = _customers;
                    return;
                }

                var searchText = txtSearch.Text.ToLower();
                var filteredCustomers = _customers.Where(c =>
                    c.FirstName.ToLower().Contains(searchText) ||
                    c.LastName.ToLower().Contains(searchText) ||
                    c.Email.ToLower().Contains(searchText) ||
                    c.CustomerPhone.Contains(searchText)
                ).ToList();

                dgvCustomers.DataSource = filteredCustomers;
            }
            catch (Exception ex)
            {
                HandleError("Arama işlemi sırasında hata oluştu", ex);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                LoadCustomers();
                if (txtSearch.Text.Length > 0)
                {
                    txtSearch.Clear();
                }
            }
            catch (Exception ex)
            {
                HandleError("Yenileme işlemi sırasında hata oluştu", ex);
            }
        }

        private void LoadCustomers()
        {
            try
            {
                using (var loading = new LoadingForm())
                {
                    loading.Show();
                    Application.DoEvents();

                    _customers = _customerRepo.GetAllCustomers();
                    if (_customers == null)
                    {
                        throw new Exception("Müşteri listesi alınamadı.");
                    }

                    dgvCustomers.DataSource = null;
                    dgvCustomers.DataSource = _customers;

                    dgvCustomers.Columns["Id"].HeaderText = "ID";
                    dgvCustomers.Columns["FirstName"].HeaderText = "Ad";
                    dgvCustomers.Columns["LastName"].HeaderText = "Soyad";
                    dgvCustomers.Columns["Email"].HeaderText = "E-posta";
                    dgvCustomers.Columns["CustomerPhone"].HeaderText = "Telefon";

                    loading.Close();
                }
            }
            catch (Exception ex)
            {
                HandleError("Müşteri listesi yüklenirken hata oluştu", ex);
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                using (var addForm = new AddCustomerForm())
                {
                    if (addForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadCustomers();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Müşteri eklenirken hata oluştu: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCustomers.SelectedRows.Count <= 0)
                {
                    MessageBox.Show("Lütfen düzenlenecek müşteriyi seçin.", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var customerId = (int)dgvCustomers.SelectedRows[0].Cells["Id"].Value;
                using (var editForm = new EditCustomerForm(customerId))
                {
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadCustomers();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Müşteri düzenlenirken hata oluştu: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCustomers.SelectedRows.Count <= 0)
                {
                    MessageBox.Show("Lütfen silinecek müşteriyi seçin.", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var customerId = (int)dgvCustomers.SelectedRows[0].Cells["Id"].Value;
                var result = MessageBox.Show("Seçili müşteriyi silmek istediğinizden emin misiniz?",
                    "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var customer = _customers.FirstOrDefault(c => c.Id == customerId);
                    if (customer != null)
                    {
                        await _customerRepo.DeleteAsync(customer);
                        LoadCustomers();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Müşteri silinirken hata oluştu: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
