using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class SapFrecuenciaVisitaCliente
    {
        public string IdCliente { get; set; }
        public short IdFrecuenciaVisita { get; set; }
        public short IdSemanaVisita { get; set; }
        public short IdDiaVisita { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaActualiza { get; set; }
        public string UsuarioActualiza { get; set; }
    }
}
