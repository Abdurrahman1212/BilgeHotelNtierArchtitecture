using AutoMapper;
using BussinessLogicLayer.DtoClasses;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<User,UserDTO>().ReverseMap();
            CreateMap<Employee,EmployeeDTO>().ReverseMap();
            CreateMap<Reservation,ReservationDTO>().ReverseMap();
            CreateMap<Customer,CustomerDTO>().ReverseMap();
            CreateMap<Shift,ShiftDTO>().ReverseMap();
            CreateMap<Room,RoomDTO>().ReverseMap();
            CreateMap<Expense,ExpenseDTO>().ReverseMap();   
        }
    }
}
