using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class PrcUsuarioProcesos
    {
        public decimal Id { get; set; }
        public decimal IdProceso { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaRegistro { get; set; }

        public virtual PrcObjetosProcesos IdProcesoNavigation { get; set; }
    }
}
