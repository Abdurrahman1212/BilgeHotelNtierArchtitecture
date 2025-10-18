using Models.Entities;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace BussinessLogicLayer.Services
{
    public class ReservationSyncService
    {
        private static readonly object _lockObject = new object();
        private static ReservationSyncService _instance;
        private List<Reservation> _activeReservations;

        private ReservationSyncService()
        {
            _activeReservations = new List<Reservation>();
        }

        public static ReservationSyncService Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lockObject)
                    {
                        if (_instance == null)
                        {
                            _instance = new ReservationSyncService();
                        }
                    }
                }
                return _instance;
            }
        }

        public bool TryReserveRoom(Room room, DateTime checkInDate, DateTime checkOutDate, PackageType packageType, out string errorMessage)
        {
            errorMessage = string.Empty;

            lock (_lockObject)
            {
                // Aynı tarihler için başka rezervasyon var mı kontrol et
                var conflictingReservation = _activeReservations.FirstOrDefault(r =>
                    r.RoomId == room.Id &&
                    r.ReservationStatus != ReservationStatus.Cancelled &&
                    !(r.CheckOutDate <= checkInDate || r.CheckInDate >= checkOutDate));

                if (conflictingReservation != null)
                {
                    errorMessage = $"Oda {room.RoomNumber} belirtilen tarihler arasında ({conflictingReservation.CheckInDate:dd.MM.yyyy} - {conflictingReservation.CheckOutDate:dd.MM.yyyy}) başka bir rezervasyon için ayrılmış durumda.";
                    return false;
                }

                // Rezervasyon oluştur
                var reservation = new Reservation
                {
                    RoomId = room.Id,
                    CheckInDate = checkInDate,
                    CheckOutDate = checkOutDate,
                    PackageType = packageType,
                    ReservationStatus = ReservationStatus.Confirmed,
                    TotalAmount = CalculateReservationAmount(room, packageType, checkInDate, checkOutDate)
                };

                _activeReservations.Add(reservation);
                return true;
            }
        }

        public List<Room> GetAvailableRooms(List<Room> allRooms, DateTime checkInDate, DateTime checkOutDate)
        {
            lock (_lockObject)
            {
                return allRooms.Where(room =>
                    room.IsAvailable &&
                    !_activeReservations.Any(r =>
                        r.RoomId == room.Id &&
                        r.ReservationStatus != ReservationStatus.Cancelled &&
                        !(r.CheckOutDate <= checkInDate || r.CheckInDate >= checkOutDate))
                ).ToList();
            }
        }

        public void ReleaseReservation(int reservationId)
        {
            lock (_lockObject)
            {
                var reservation = _activeReservations.FirstOrDefault(r => r.Id == reservationId);
                if (reservation != null)
                {
                    reservation.ReservationStatus = ReservationStatus.Cancelled;
                }
            }
        }

        public void ConfirmReservation(int reservationId)
        {
            lock (_lockObject)
            {
                var reservation = _activeReservations.FirstOrDefault(r => r.Id == reservationId);
                if (reservation != null)
                {
                    reservation.ReservationStatus = ReservationStatus.Confirmed;
                }
            }
        }

        public List<Reservation> GetActiveReservations()
        {
            lock (_lockObject)
            {
                return _activeReservations.Where(r => r.ReservationStatus != ReservationStatus.Cancelled).ToList();
            }
        }

        public List<RoomStatusInfo> GetRoomStatusForDate(DateTime date)
        {
            var statusInfo = new List<RoomStatusInfo>();

            lock (_lockObject)
            {
                foreach (var reservation in _activeReservations.Where(r =>
                    r.ReservationStatus != ReservationStatus.Cancelled &&
                    r.CheckInDate <= date && r.CheckOutDate > date))
                {
                    statusInfo.Add(new RoomStatusInfo
                    {
                        RoomId = reservation.RoomId,
                        Status = RoomStatus.Occupied,
                        ReservationId = reservation.Id,
                        OccupiedUntil = reservation.CheckOutDate
                    });
                }
            }

            return statusInfo;
        }

        private decimal CalculateReservationAmount(Room room, PackageType packageType, DateTime checkInDate, DateTime checkOutDate)
        {
            var pricingService = new PricingService();
            int nights = (checkOutDate - checkInDate).Days;
            return pricingService.CalculateTotalPrice(room, packageType, nights, checkInDate);
        }

        public void CleanupExpiredReservations()
        {
            lock (_lockObject)
            {
                var expiredReservations = _activeReservations.Where(r =>
                    r.CheckOutDate < DateTime.Now &&
                    r.ReservationStatus == ReservationStatus.Confirmed).ToList();

                foreach (var reservation in expiredReservations)
                {
                    reservation.ReservationStatus = ReservationStatus.Completed;
                }
            }
        }
    }

    public class RoomStatusInfo
    {
        public int RoomId { get; set; }
        public RoomStatus Status { get; set; }
        public int ReservationId { get; set; }
        public DateTime OccupiedUntil { get; set; }
    }
}
