﻿using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Cpry254
    {
        public long Orden { get; set; }
        public int MedidaBasica { get; set; }
        public int MedidaOpuesta { get; set; }
        public short CantidadTintas { get; set; }
        public short PerfHorizontal { get; set; }
        public short PerfVertical { get; set; }
        public short HoyosArchivo { get; set; }
        public short CarbonEngomado { get; set; }
        public short CarbonSpot { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
