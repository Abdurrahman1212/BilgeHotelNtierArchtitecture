﻿using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer.Services.Abstracs
{
    public interface IReservationService:IManagerService<Reservation>
    {
        IEnumerable<Reservation> GetReservationsByCustomerId(int customerId);
        bool IsRoomReserved(int roomId, DateTime checkInDate, DateTime checkOutDate);
        Reservation GetReservation(int reservationId);
    }
}
