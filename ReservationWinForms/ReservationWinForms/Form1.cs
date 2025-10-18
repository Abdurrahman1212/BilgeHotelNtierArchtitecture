using Models.Entities;
using Models.Enums;
using System.Data;

namespace ReservationWinForms;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        LoadReservations();
        LoadRooms();
        LoadCurrencyRates();
    }

    private void LoadReservations()
    {
        // Rezervasyonları yükle - Business Logic katmanından gelecek
        // Şimdilik örnek veri
        var customers = new List<Customer>
        {
            new Customer { Id = 1, FirstName = "Ahmet", LastName = "Yılmaz", Email = "ahmet@example.com" },
            new Customer { Id = 2, FirstName = "Ayşe", LastName = "Demir", Email = "ayse@example.com" }
        };

        var reservations = new List<Reservation>
        {
            new Reservation { Id = 1, CheckInDate = DateTime.Now, CheckOutDate = DateTime.Now.AddDays(3), TotalAmount = 1500, Customer = customers[0] },
            new Reservation { Id = 2, CheckInDate = DateTime.Now, CheckOutDate = DateTime.Now.AddDays(5), TotalAmount = 2000, Customer = customers[1] }
        };

        dgvReservations.DataSource = reservations;
    }

    private void LoadRooms()
    {
        // Odaları yükle
        var rooms = new List<Room>
        {
            new Room { Id = 1, RoomNumber = 101, Status = RoomStatus.Empty, BasePricePerNight = 500 },
            new Room { Id = 2, RoomNumber = 102, Status = RoomStatus.Occupied, BasePricePerNight = 750 }
        };

        dgvRooms.DataSource = rooms;
    }

    private void LoadCurrencyRates()
    {
        // Döviz kurlarını yükle
        var rates = new List<CurrencyRate>
        {
            new CurrencyRate { Id = 1, CurrencyCode = "USD", Rate = 34.50m, LastUpdated = DateTime.Now },
            new CurrencyRate { Id = 2, CurrencyCode = "EUR", Rate = 37.80m, LastUpdated = DateTime.Now }
        };

        dgvCurrencyRates.DataSource = rates;
    }

    private void btnNewReservation_Click(object sender, EventArgs e)
    {
        var reservationForm = new ReservationForm();
        reservationForm.ShowDialog();
        LoadReservations(); // Yenile
    }

    private void btnCheckIn_Click(object sender, EventArgs e)
    {
        if (dgvReservations.SelectedRows.Count > 0)
        {
            var reservationId = (int)dgvReservations.SelectedRows[0].Cells["Id"].Value;
            // Check-in işlemi
            MessageBox.Show($"Rezervasyon {reservationId} check-in yapıldı.");
            LoadReservations();
        }
    }

    private void btnCheckOut_Click(object sender, EventArgs e)
    {
        if (dgvReservations.SelectedRows.Count > 0)
        {
            var reservationId = (int)dgvReservations.SelectedRows[0].Cells["Id"].Value;
            // Check-out işlemi
            MessageBox.Show($"Rezervasyon {reservationId} check-out yapıldı.");
            LoadReservations();
        }
    }

    private void btnRefreshRates_Click(object sender, EventArgs e)
    {
        LoadCurrencyRates();
    }
}
