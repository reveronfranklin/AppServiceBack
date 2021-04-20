using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class OfdCriterioBusqueda
    {
        public OfdCriterioBusqueda()
        {
            OfdAdjuntoCriterio = new HashSet<OfdAdjuntoCriterio>();
            OfdGrupoCriterio = new HashSet<OfdGrupoCriterio>();
        }

        public short IdCriterioBusqueda { get; set; }
        public string CampoBusqueda { get; set; }
        public string IdUsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }

        public virtual ICollection<OfdAdjuntoCriterio> OfdAdjuntoCriterio { get; set; }
        public virtual ICollection<OfdGrupoCriterio> OfdGrupoCriterio { get; set; }
    }
}
