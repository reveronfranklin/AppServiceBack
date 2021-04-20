using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class CobPorcentajesImpuestos
    {
        public int IdPorcImpuestos { get; set; }
        public int? IdTransacccionCobranzas { get; set; }
        public decimal? Desde { get; set; }
        public decimal? Hasta { get; set; }
        public decimal? Incremento { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
