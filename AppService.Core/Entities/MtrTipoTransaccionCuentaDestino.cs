using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class MtrTipoTransaccionCuentaDestino
    {
        public short IdTransaccionCuentaDestino { get; set; }
        public string IdTipoTransaccion { get; set; }
        public int IdTipoCuentaDestino { get; set; }
    }
}
