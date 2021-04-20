using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class OfdMaestroFlujo
    {
        public OfdMaestroFlujo()
        {
            OfdMaestroEstacion = new HashSet<OfdMaestroEstacion>();
        }

        public short IdFlujo { get; set; }
        public string NombreFlujo { get; set; }

        public virtual ICollection<OfdMaestroEstacion> OfdMaestroEstacion { get; set; }
    }
}
