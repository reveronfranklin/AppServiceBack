using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class OfdSolicitudDisenoCambios
    {
        public long IdSolDisCam { get; set; }
        public long IdSolicitud { get; set; }
        public int IdCambio { get; set; }
        public DateTime FechaRegistro { get; set; }

        public virtual OfdCambioDiseno IdCambioNavigation { get; set; }
        public virtual OfdSolicitudDiseno IdSolicitudNavigation { get; set; }
    }
}
