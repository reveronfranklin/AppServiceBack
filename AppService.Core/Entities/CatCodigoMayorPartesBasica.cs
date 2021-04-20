using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class CatCodigoMayorPartesBasica
    {
        public decimal Id { get; set; }
        public string CodigoMayor { get; set; }
        public int? Partes { get; set; }
        public string BasicaBusqueda { get; set; }
        public decimal? Frecuencia { get; set; }
    }
}
