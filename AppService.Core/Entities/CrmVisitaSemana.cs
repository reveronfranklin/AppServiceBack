using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class CrmVisitaSemana
    {
        public short IdSemana { get; set; }
        public string NombreSemana { get; set; }
        public string AbreviadoSemana { get; set; }
        public short IdFrecuencia { get; set; }

        public virtual CrmVisitaFrecuencia IdFrecuenciaNavigation { get; set; }
    }
}
