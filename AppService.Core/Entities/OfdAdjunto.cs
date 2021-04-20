using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class OfdAdjunto
    {
        public OfdAdjunto()
        {
            OfdAdjuntoCriterio = new HashSet<OfdAdjuntoCriterio>();
        }

        public long IdAdjunto { get; set; }
        public short IdTipoDocumento { get; set; }
        public string NombreArchivo { get; set; }
        public byte[] Archivo { get; set; }
        public string IdUsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public long? IdAdjuntoCotizadorPluss { get; set; }

        public virtual ICollection<OfdAdjuntoCriterio> OfdAdjuntoCriterio { get; set; }
    }
}
