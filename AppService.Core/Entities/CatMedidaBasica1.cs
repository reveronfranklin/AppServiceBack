using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class CatMedidaBasica1
    {
        public CatMedidaBasica1()
        {
            CatMaterial = new HashSet<CatMaterial>();
        }

        public int CatMedidaBasicaId { get; set; }
        public string MedidaString { get; set; }
        public string MedidaBusqueda { get; set; }
        public decimal MedidaDecimal { get; set; }

        public virtual ICollection<CatMaterial> CatMaterial { get; set; }
    }
}
