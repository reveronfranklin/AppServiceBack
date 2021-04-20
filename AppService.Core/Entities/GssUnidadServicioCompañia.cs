using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class GssUnidadServicioCompañia
    {
        public int IdUnidadServicioCompañia { get; set; }
        public short IdUnidadServicio { get; set; }
        public short IdCompañia { get; set; }
        public DateTime FechaCambio { get; set; }
        public int UsuarioCambio { get; set; }

        public virtual GssCompañia IdCompañiaNavigation { get; set; }
        public virtual GssUnidadServicio IdUnidadServicioNavigation { get; set; }
    }
}
