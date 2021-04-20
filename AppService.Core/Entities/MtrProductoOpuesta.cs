using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class MtrProductoOpuesta
    {
        public decimal Id { get; set; }
        public string Producto { get; set; }
        public string MedidaFraccion { get; set; }
        public string MedidaMascara { get; set; }
        public decimal? Frecuencia { get; set; }
    }
}
