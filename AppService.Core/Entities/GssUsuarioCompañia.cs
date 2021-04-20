using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class GssUsuarioCompañia
    {
        public int IdUsuarioCompañia { get; set; }
        public int IdUsuario { get; set; }
        public short IdCompañia { get; set; }
        public DateTime FechaCambio { get; set; }
        public int UsuarioCambio { get; set; }

        public virtual GssCompañia IdCompañiaNavigation { get; set; }
        public virtual SegUsuario IdUsuarioNavigation { get; set; }
    }
}
