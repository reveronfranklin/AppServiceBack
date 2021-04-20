using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class OfdFlujoEstacion
    {
        public short IdFlujoEstacion { get; set; }
        public short IdEstacionActual { get; set; }
        public short IdEstacionAprueba { get; set; }
        public short IdEstacionRechaza { get; set; }
        public DateTime FechaRegistro { get; set; }

        public virtual OfdMaestroEstacion IdEstacionActualNavigation { get; set; }
    }
}
