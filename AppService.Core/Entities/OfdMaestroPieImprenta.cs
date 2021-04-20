using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class OfdMaestroPieImprenta
    {
        public OfdMaestroPieImprenta()
        {
            OfdSolicitudDiseno = new HashSet<OfdSolicitudDiseno>();
        }

        public string IdPieImprenta { get; set; }
        public string DescripcionPie { get; set; }

        public virtual ICollection<OfdSolicitudDiseno> OfdSolicitudDiseno { get; set; }
    }
}
