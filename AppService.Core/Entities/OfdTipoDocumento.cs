﻿using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class OfdTipoDocumento
    {
        public OfdTipoDocumento()
        {
            OfdRolTipoDocumento = new HashSet<OfdRolTipoDocumento>();
        }

        public short IdTipoDocumento { get; set; }
        public short IdGrupoTipoDocumento { get; set; }
        public string NombreDocumento { get; set; }
        public bool? Obligatorio { get; set; }
        public bool? AfectaExpediente { get; set; }
        public string IdUsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string IdUsuarioModificacion { get; set; }
        public DateTime FechaModificacion { get; set; }

        public virtual OfdGrupoTipoDocumento IdGrupoTipoDocumentoNavigation { get; set; }
        public virtual ICollection<OfdRolTipoDocumento> OfdRolTipoDocumento { get; set; }
    }
}
