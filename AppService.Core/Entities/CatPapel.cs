using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class CatPapel
    {
        public CatPapel()
        {
            CatMaterialDetalleTmp = new HashSet<CatMaterialDetalleTmp>();
        }

        public string CatPapelId { get; set; }
        public string Descripcion { get; set; }
        public bool EsCarbon { get; set; }

        public virtual ICollection<CatMaterialDetalleTmp> CatMaterialDetalleTmp { get; set; }
    }
}
