using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class CatMedidaOpuesta
    {
        public CatMedidaOpuesta()
        {
            CatMaterialDetalle = new HashSet<CatMaterialDetalle>();
            CatMaterialDetalleTmp = new HashSet<CatMaterialDetalleTmp>();
        }

        public int CatMedidaOpuestaId { get; set; }
        public string MedidaString { get; set; }
        public string MedidaBusqueda { get; set; }
        public decimal MedidaDecimal { get; set; }

        public virtual ICollection<CatMaterialDetalle> CatMaterialDetalle { get; set; }
        public virtual ICollection<CatMaterialDetalleTmp> CatMaterialDetalleTmp { get; set; }
    }
}
