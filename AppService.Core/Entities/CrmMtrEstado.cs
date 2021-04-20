using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class CrmMtrEstado
    {
        public CrmMtrEstado()
        {
            CrmSeguimiento = new HashSet<CrmSeguimiento>();
        }

        public short IdEstado { get; set; }
        public string NombreEstado { get; set; }
        public bool FlagPendiente { get; set; }
        public bool FlagCerrada { get; set; }

        public virtual ICollection<CrmSeguimiento> CrmSeguimiento { get; set; }
    }
}
