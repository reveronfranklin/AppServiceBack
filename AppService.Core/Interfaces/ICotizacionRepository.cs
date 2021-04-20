﻿using AppService.Core.EntitiesMooreve;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface ICotizacionRepository
    {

        Task<List<Wsmy501>> GetAll();

        Task<Wsmy501> GetById(int id);

        Task<Wsmy501> GetByCotizacion(string cotizacion);

        Task Add(Wsmy501 entity);

        void Update(Wsmy501 entity);

        Task Delete(string id);

        string ProximaCotizacion(string Cod_Vendedor);

    }
}
