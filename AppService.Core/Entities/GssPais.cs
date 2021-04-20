using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class GssPais
    {
        public GssPais()
        {
            GssCompañia = new HashSet<GssCompañia>();
        }

        public short IdPais { get; set; }
        public string NombrePais { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaCambio { get; set; }
        public int UsuarioCambio { get; set; }

        public virtual ICollection<GssCompañia> GssCompañia { get; set; }
    }
}
