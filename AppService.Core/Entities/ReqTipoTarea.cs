using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class ReqTipoTarea
    {
        public ReqTipoTarea()
        {
            ReqTarea = new HashSet<ReqTarea>();
        }

        public int IdTipoTarea { get; set; }
        public string DescripcionTipoTarea { get; set; }
        public int IdAreaRequerimiento { get; set; }
        public DateTime? FechaCambio { get; set; }
        public string UsuarioCambio { get; set; }

        public virtual ReqAreaRequerimiento IdAreaRequerimientoNavigation { get; set; }
        public virtual ICollection<ReqTarea> ReqTarea { get; set; }
    }
}
