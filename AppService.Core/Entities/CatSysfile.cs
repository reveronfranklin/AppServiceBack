using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class CatSysfile
    {
        public int CatSysfileId { get; set; }
        public string FechaPublicacion { get; set; }
        public string FechaModificacionMateriales { get; set; }
        public bool? InactivarConsultaPrecios { get; set; }
        public int? IdPrograma { get; set; }
    }
}
