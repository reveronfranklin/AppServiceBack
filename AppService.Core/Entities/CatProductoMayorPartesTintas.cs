using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class CatProductoMayorPartesTintas
    {
        public long CatProductoMayorPartesTintasId { get; set; }
        public long? CatProductoMayorId { get; set; }
        public long? CatProductoMayorPartesId { get; set; }
        public string CodigoProduct { get; set; }
        public int Partes { get; set; }
        public int Tintas { get; set; }
        public int Frecuencia { get; set; }
    }
}
