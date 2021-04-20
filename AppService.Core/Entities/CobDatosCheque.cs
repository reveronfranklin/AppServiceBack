using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class CobDatosCheque
    {
        public long Documento { get; set; }
        public string IdBanco { get; set; }
        public string IdTipoTransaccion { get; set; }
        public decimal MontoCheque { get; set; }
        public long NumCheque { get; set; }
        public DateTime FechaCheque { get; set; }

        public virtual CobGeneralCobranza DocumentoNavigation { get; set; }
    }
}
