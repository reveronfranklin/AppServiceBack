using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class CobDescuentoIvaTipoTransaccion
    {
        public short Id { get; set; }
        public string IdTipoTransaccion { get; set; }
        public decimal BsDesde { get; set; }
        public decimal BsHasta { get; set; }
        public decimal PorcDescuento { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
