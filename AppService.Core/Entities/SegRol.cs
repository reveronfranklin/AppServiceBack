using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class SegRol
    {
        public SegRol()
        {
            OfdRolTipoDocumento = new HashSet<OfdRolTipoDocumento>();
            SegUsuarioRol = new HashSet<SegUsuarioRol>();
        }

        public int IdRol { get; set; }
        public string NombreRol { get; set; }
        public int IdPrograma { get; set; }
        public string DescripcionRol { get; set; }
        public string AbreviadoRol { get; set; }

        public virtual ICollection<OfdRolTipoDocumento> OfdRolTipoDocumento { get; set; }
        public virtual ICollection<SegUsuarioRol> SegUsuarioRol { get; set; }
    }
}
