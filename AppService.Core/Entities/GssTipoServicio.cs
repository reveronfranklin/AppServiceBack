using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class GssTipoServicio
    {
        public GssTipoServicio()
        {
            GssServicios = new HashSet<GssServicios>();
        }

        public int IdTipoServicio { get; set; }
        public string NombreTipoServicio { get; set; }
        public int IdAreaServicio { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaCambio { get; set; }
        public int UsuarioCambio { get; set; }

        public virtual GssAreaServicio IdAreaServicioNavigation { get; set; }
        public virtual ICollection<GssServicios> GssServicios { get; set; }
    }
}
