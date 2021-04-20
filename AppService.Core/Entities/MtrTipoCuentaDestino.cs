using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class MtrTipoCuentaDestino
    {
        public MtrTipoCuentaDestino()
        {
            MtrBancos = new HashSet<MtrBancos>();
        }

        public int IdTipoCuentaDestino { get; set; }
        public string NombreCuentaDestino { get; set; }

        public virtual ICollection<MtrBancos> MtrBancos { get; set; }
    }
}
