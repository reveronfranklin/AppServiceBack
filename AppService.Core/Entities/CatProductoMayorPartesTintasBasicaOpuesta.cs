using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class CatProductoMayorPartesTintasBasicaOpuesta
    {
        public long CatProductoMayorPartesTintasBasicaOpuestaId { get; set; }
        public long? CatProductoMayorId { get; set; }
        public long? CatProductoMayorPartesId { get; set; }
        public long? CatProductoMayorPartesTintasId { get; set; }
        public long? CatProductoMayorPartesTintasBasicaId { get; set; }
        public string CodigoProduct { get; set; }
        public int Partes { get; set; }
        public int Tintas { get; set; }
        public string BasicaBusqueda { get; set; }
        public string OpuestaBusqueda { get; set; }
        public int Frecuencia { get; set; }
    }
}
