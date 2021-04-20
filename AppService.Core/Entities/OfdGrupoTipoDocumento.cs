using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class OfdGrupoTipoDocumento
    {
        public OfdGrupoTipoDocumento()
        {
            OfdGrupoCriterio = new HashSet<OfdGrupoCriterio>();
            OfdTipoDocumento = new HashSet<OfdTipoDocumento>();
        }

        public short IdGrupoTipoDocumento { get; set; }
        public string NombreGrupo { get; set; }
        public string IdUsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string IdUsuarioModificacion { get; set; }
        public DateTime FechaModificacion { get; set; }

        public virtual ICollection<OfdGrupoCriterio> OfdGrupoCriterio { get; set; }
        public virtual ICollection<OfdTipoDocumento> OfdTipoDocumento { get; set; }
    }
}
