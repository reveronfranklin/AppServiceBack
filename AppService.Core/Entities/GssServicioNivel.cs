using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class GssServicioNivel
    {
        public int IdServicioNivel { get; set; }
        public int IdServicio { get; set; }
        public int IdNivel { get; set; }
        public short Secuencia { get; set; }
        public DateTime FechaCambio { get; set; }
        public int UsuarioCambio { get; set; }

        public virtual GssNivel IdNivelNavigation { get; set; }
        public virtual GssServicios IdServicioNavigation { get; set; }
    }
}
