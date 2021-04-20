using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class SapRetenciones
    {
        public decimal Id { get; set; }
        public string TipodeRetencion { get; set; }
        public string Denominacion { get; set; }
        public string IndicadordeRetencion { get; set; }
        public double? Porcentaje { get; set; }
        public double? AsigancionCuentadebe { get; set; }
        public double? AsigancionCuentahaber { get; set; }
        public double? TransaccionLegacy { get; set; }
    }
}
