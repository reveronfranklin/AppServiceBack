using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class GssUnidadServicio
    {
        public GssUnidadServicio()
        {
            GssAreaServicio = new HashSet<GssAreaServicio>();
            GssNivel = new HashSet<GssNivel>();
            GssSolicitud = new HashSet<GssSolicitud>();
            GssUnidadServicioCompañia = new HashSet<GssUnidadServicioCompañia>();
        }

        public short IdUnidadServicio { get; set; }
        public string NombreUnidadServicio { get; set; }
        public string Abreviado { get; set; }
        public bool Activo { get; set; }
        public string CuentaUnidadServicio { get; set; }
        public DateTime FechaCambio { get; set; }
        public int UsuarioCambio { get; set; }

        public virtual ICollection<GssAreaServicio> GssAreaServicio { get; set; }
        public virtual ICollection<GssNivel> GssNivel { get; set; }
        public virtual ICollection<GssSolicitud> GssSolicitud { get; set; }
        public virtual ICollection<GssUnidadServicioCompañia> GssUnidadServicioCompañia { get; set; }
    }
}
