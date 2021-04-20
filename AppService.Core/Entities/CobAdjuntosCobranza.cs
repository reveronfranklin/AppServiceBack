using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppService.Core.Entities
{

    public partial class CobAdjuntosCobranza
    {
        public long IdAdjunto { get; set; }
        public long Documento { get; set; }
        public short IdTipoDocumento { get; set; }
        public string NombreArchivo { get; set; }
        
        [NotMapped]
        public byte?[] Archivo { get; set; }

        public string IdUsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Ruta { get; set; }

        public virtual CobGeneralCobranza DocumentoNavigation { get; set; }
    }

}
