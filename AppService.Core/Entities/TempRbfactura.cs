﻿using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class TempRbfactura
    {
        public decimal Recnum { get; set; }
        public long DocRb { get; set; }
        public long Factura { get; set; }
        public DateTime Fecha { get; set; }
    }
}
