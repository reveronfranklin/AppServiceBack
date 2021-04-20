using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class ReqOrigenRequerimiento
    {
        public ReqOrigenRequerimiento()
        {
            ReqAreaRequerimiento = new HashSet<ReqAreaRequerimiento>();
        }

        public int IdOrigenRequerimiento { get; set; }
        public string DescripcionOrigenRequerimiento { get; set; }
        public string IdCompañia { get; set; }
        public DateTime? FechaCambio { get; set; }
        public string UsuarioCambio { get; set; }

        public virtual ReqCompañia IdCompañiaNavigation { get; set; }
        public virtual ICollection<ReqAreaRequerimiento> ReqAreaRequerimiento { get; set; }
    }
}
