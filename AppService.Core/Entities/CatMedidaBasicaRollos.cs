using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class CatMedidaBasicaRollos
    {
        public long CatMedidaBasicaRollosId { get; set; }
        public string Medida { get; set; }
        public decimal? MedidaIn { get; set; }
        public decimal? MedidaMm { get; set; }
    }
}
