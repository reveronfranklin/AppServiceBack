﻿using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class PcresumenOficinaHistorico
    {
        public int Id { get; set; }
        public int? CodigoOficina { get; set; }
        public string NombreOficina { get; set; }
        public decimal? Monto { get; set; }
        public string MontoString { get; set; }
        public int? IdPeriodo { get; set; }
    }
}
