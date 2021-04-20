using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class MtrTipoDocumentoFiscal
    {
        public MtrTipoDocumentoFiscal()
        {
            PrcNumeracionFiscal = new HashSet<PrcNumeracionFiscal>();
        }

        public string TipoDocumento { get; set; }
        public string Descripcion { get; set; }
        public bool ValidaNumero { get; set; }
        public int IdFormato { get; set; }

        public virtual ICollection<PrcNumeracionFiscal> PrcNumeracionFiscal { get; set; }
    }
}
