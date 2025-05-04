using Microsoft.Identity.Client;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BussinessLogicLayer.Services.Abstracs
{
    // Fix: Adjust the order of constraints and ensure compatibility with IdentityUserService<T>
    public interface IUserService: IManagerService<User>
    {
        IEnumerable<User> GetUsersById(int UserId);
    }
}
