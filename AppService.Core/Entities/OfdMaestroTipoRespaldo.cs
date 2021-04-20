using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class OfdMaestroTipoRespaldo
    {
        public OfdMaestroTipoRespaldo()
        {
            OfdSolicitudDiseno = new HashSet<OfdSolicitudDiseno>();
        }

        public short IdTipoRespaldo { get; set; }
        public string TipoRespaldo { get; set; }

        public virtual ICollection<OfdSolicitudDiseno> OfdSolicitudDiseno { get; set; }
    }
}
