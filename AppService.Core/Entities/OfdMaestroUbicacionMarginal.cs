using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class OfdMaestroUbicacionMarginal
    {
        public OfdMaestroUbicacionMarginal()
        {
            OfdSolicitudDiseno = new HashSet<OfdSolicitudDiseno>();
        }

        public short IdUbicacionMarginal { get; set; }
        public string UbicacionMarginal { get; set; }

        public virtual ICollection<OfdSolicitudDiseno> OfdSolicitudDiseno { get; set; }
    }
}
