﻿using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class EscaneoTicket
    {
        public decimal Id { get; set; }
        public string Data { get; set; }
        public string UsuarioEscaneo { get; set; }
        public DateTime? FechaEscaneo { get; set; }
    }
}
