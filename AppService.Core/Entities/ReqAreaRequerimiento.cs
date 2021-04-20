using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class ReqAreaRequerimiento
    {
        public ReqAreaRequerimiento()
        {
            ReqTipoTarea = new HashSet<ReqTipoTarea>();
        }

        public int IdAreaRequerimiento { get; set; }
        public string DescripcionAreaRequerimiento { get; set; }
        public int IdOrigenRequerimiento { get; set; }
        public DateTime? FechaCambio { get; set; }
        public string UsuarioCambio { get; set; }

        public virtual ReqOrigenRequerimiento IdOrigenRequerimientoNavigation { get; set; }
        public virtual ICollection<ReqTipoTarea> ReqTipoTarea { get; set; }
    }
}
