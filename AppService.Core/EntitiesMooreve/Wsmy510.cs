﻿using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy510
    {
        public decimal Id { get; set; }
        public int? Año { get; set; }
        public int? Mes { get; set; }
        public int? Semana { get; set; }
        public decimal? DiaHabil { get; set; }
        public decimal? Venta { get; set; }
        public decimal? EstimadoTotal { get; set; }
        public string Desde { get; set; }
        public string Hasta { get; set; }
        public decimal? DiasHabiles { get; set; }
        public decimal? EstimadoDiario { get; set; }
        public decimal? VentaAcumulada { get; set; }
        public decimal? EstimadoAcumulado { get; set; }
        public DateTime? FechaActualizacion { get; set; }
    }
}
