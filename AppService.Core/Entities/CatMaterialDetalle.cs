using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class CatMaterialDetalle
    {
        public long CatMaterialDetalleId { get; set; }
        public long CatMaterialId { get; set; }
        public int Parte { get; set; }
        public string CatPapelId { get; set; }
        public int CatMedidaOpuestaId { get; set; }
        public string CatCarbonId { get; set; }

        public virtual CatMaterial CatMaterial { get; set; }
        public virtual CatMedidaOpuesta CatMedidaOpuesta { get; set; }
    }
}
