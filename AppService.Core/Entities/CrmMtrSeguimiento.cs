using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class CrmMtrSeguimiento
    {
        public CrmMtrSeguimiento()
        {
            CrmSeguimiento = new HashSet<CrmSeguimiento>();
        }

        public short IdTipoSegumiento { get; set; }
        public string NombreSeguimiento { get; set; }
        public bool FlagUpdateData { get; set; }

        public virtual ICollection<CrmSeguimiento> CrmSeguimiento { get; set; }
    }
}
