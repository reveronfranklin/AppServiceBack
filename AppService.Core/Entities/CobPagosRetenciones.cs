using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class CobPagosRetenciones
    {
        public long Id { get; set; }
        public long IdCobranza { get; set; }
        public int IdTransaccion { get; set; }
        public decimal Porcentaje { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaCrea { get; set; }
        public bool FlagComprobanteNo { get; set; }
        public string NroComprobante { get; set; }
        public DateTime FechaComprobante { get; set; }
        public decimal? Rmonto { get; set; }
        public string DocumentoSap { get; set; }
        public string EjercicioDocumentoSap { get; set; }

        public virtual CobGrabacionCobranzas IdCobranzaNavigation { get; set; }
    }
}
