using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class CrmVisitaFrecuencia
    {
        public CrmVisitaFrecuencia()
        {
            CrmVisitaSemana = new HashSet<CrmVisitaSemana>();
        }

        public short IdFrecuencia { get; set; }
        public string NombreFrecuencia { get; set; }

        public virtual ICollection<CrmVisitaSemana> CrmVisitaSemana { get; set; }
    }
}
