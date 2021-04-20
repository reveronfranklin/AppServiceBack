using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class CreAdjuntoSolicitudCredito
    {
        public decimal SolicitudDeCredito { get; set; }
        public byte[] ReporteAnalisiCredito { get; set; }
    }
}
