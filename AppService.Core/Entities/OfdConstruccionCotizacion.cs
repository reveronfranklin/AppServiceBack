﻿using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class OfdConstruccionCotizacion
    {
        public string Cotizacion { get; set; }
        public int Renglon { get; set; }
        public int Propuesta { get; set; }
        public string IdVariable { get; set; }
        public int IdParte { get; set; }
        public string Valor { get; set; }
        public DateTime FechaRegistro { get; set; }
        public decimal Id { get; set; }
    }
}
