﻿using DataAccessLayer.Contracts.Interfaces;
using Models.Abstracts;
using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer.Services.Abstracs
{
    public interface IManagerService <T>where T : class,IEntity
    {
        IEnumerable<T> GetAll();

        IEnumerable<T> GetActives();

        IEnumerable<T> GetPassives();

        T GetById(int id);


        //Modified Commands

        Task CreateAsync(T entity);

        Task CreateRangeAsync(List<T> entities);

        Task UpdateAsync(T entity);

        Task UpdateRangeAsync(List<T> entities);

        Task DeleteAsync(int id);

        Task DeleteAllAsync(List<T> entities);

        Task DestroyAsync(T entity);

        Task DestroyRangeAsync(List<T> entities);
    }
}
