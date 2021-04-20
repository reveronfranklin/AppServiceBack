﻿using AppService.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IMtrCondicionPagoRepository
    {
        Task<List<MtrCondicionPago>> GetAll();
        Task<MtrCondicionPago> GetById(short idCondicionPago);

    }
}
