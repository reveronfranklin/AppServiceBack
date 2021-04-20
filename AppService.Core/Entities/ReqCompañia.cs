using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class ReqCompañia
    {
        public ReqCompañia()
        {
            ReqOrigenRequerimiento = new HashSet<ReqOrigenRequerimiento>();
        }

        public string IdCompañia { get; set; }
        public string NombreCompañia { get; set; }
        public DateTime? FechaCambio { get; set; }
        public string UsuarioCambio { get; set; }

        public virtual ICollection<ReqOrigenRequerimiento> ReqOrigenRequerimiento { get; set; }
    }
}
