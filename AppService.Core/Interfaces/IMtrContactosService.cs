﻿using AppService.Core.DTOs;
using AppService.Core.Entities;
using AppService.Core.EntitiesSap;
using AppService.Core.QueryFilters;
using AppService.Core.Responses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IMtrContactosService
    {
        IEnumerable<MtrContactos> GetAll();
        Task<MtrContactos> GetById(long id);
        Task<MtrContactos> Insert(MtrContactos mtrContactos);
        Task<MtrContactos> Update(MtrContactos mtrContactos);
        Task<bool> Delete(long id);
        
        Task<List<MtrContactos>> GetByIdCliente(MtrClienteQueryFilter filter);
        Task<List<SapTratamientoContacto>> GetAllSapTratamientoContacto();
        Task<List<SapCargoContacto>> GetAllSapCargoContacto();
        Task<List<SapDepartamentoContacto>> GetAllSapDepartamentoContacto();
        Task<List<SapPoderContacto>> GetAllSapPoderContacto();
        Task<ApiResponse<bool>> CreateContactoAlTables(ContactoCreateDto dto);
        Task<ApiResponse<bool>> UpdateContactoAllTables(ContactoUpdateDto dto);
        Task<ApiResponse<ContactoGetDto>> GetContactoById(ContactoQueryFilter filter);
    }
}
