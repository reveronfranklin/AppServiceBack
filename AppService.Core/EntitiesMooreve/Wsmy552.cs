﻿using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy552
    {
        public long Año { get; set; }
        public long Mes { get; set; }
        public string Vendedor { get; set; }
        public long AñoEmbarque { get; set; }
        public long MesEmbarque { get; set; }
        public decimal? SaldoInicialCxC { get; set; }
        public decimal? SaldoCxC { get; set; }
        public decimal? Embarques { get; set; }
        public decimal? DiasAcumulados { get; set; }
        public decimal? DiasDelMes { get; set; }
    }
}
