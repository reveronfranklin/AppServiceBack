using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class CobGrabacionCobranzas
    {
        public CobGrabacionCobranzas()
        {
            CobPagosRetenciones = new HashSet<CobPagosRetenciones>();
        }

        public long Id { get; set; }
        public long? Documento { get; set; }
        public string Transaccion { get; set; }
        public decimal DocAfecta { get; set; }
        public decimal? Monto { get; set; }
        public string Cotizacion { get; set; }
        public double Rpdoc { get; set; }
        public string Rpdct { get; set; }
        public string Rpkco { get; set; }
        public string Rpsfx { get; set; }
        public string DocAfectaSap { get; set; }
        public decimal? Rmonto { get; set; }
        public string DocumentoSap { get; set; }
        public string EjercicioDocumentoSap { get; set; }
        public bool? PagoCorrespondeIva { get; set; }

        public string ErrorMessage { get; set; }

        public string ObjectSend { get; set; }

        public bool? PagoDeMas { get; set; }


        public virtual CobGeneralCobranza DocumentoNavigation { get; set; }
        public virtual CobTransacciones TransaccionNavigation { get; set; }
        public virtual ICollection<CobPagosRetenciones> CobPagosRetenciones { get; set; }
    }
}
