﻿using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class ValevenDataResumen
    {
        public long Tickets { get; set; }
        public long Anulados { get; set; }
        public long Escaneados { get; set; }
        public long Impresos { get; set; }
        public DateTime FechaActualizacion { get; set; }
    }
}
