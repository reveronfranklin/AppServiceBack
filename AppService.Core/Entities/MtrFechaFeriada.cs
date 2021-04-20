using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class MtrFechaFeriada
    {
        public decimal Recnum { get; set; }
        public DateTime FechaFeriada { get; set; }
        public string Motivo { get; set; }
        public string MostrarBs { get; set; }
    }
}
