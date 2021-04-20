using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class OfdRolTipoDocumento
    {
        public long IdRolTipoDocumento { get; set; }
        public int IdRol { get; set; }
        public short IdTipoDocumento { get; set; }

        public virtual SegRol IdRolNavigation { get; set; }
        public virtual OfdTipoDocumento IdTipoDocumentoNavigation { get; set; }
    }
}
