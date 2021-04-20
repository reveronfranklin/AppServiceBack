using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class GssCompañia
    {
        public GssCompañia()
        {
            GssUnidadServicioCompañia = new HashSet<GssUnidadServicioCompañia>();
            GssUsuarioCompañia = new HashSet<GssUsuarioCompañia>();
        }

        public short IdCompañia { get; set; }
        public string NombreCompañia { get; set; }
        public string IdJde { get; set; }
        public bool Activo { get; set; }
        public short IdPais { get; set; }
        public DateTime FechaCambio { get; set; }
        public int UsuarioCambio { get; set; }

        public virtual GssPais IdPaisNavigation { get; set; }
        public virtual ICollection<GssUnidadServicioCompañia> GssUnidadServicioCompañia { get; set; }
        public virtual ICollection<GssUsuarioCompañia> GssUsuarioCompañia { get; set; }
    }
}
