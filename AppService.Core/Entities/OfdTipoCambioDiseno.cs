using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class OfdTipoCambioDiseno
    {
        public OfdTipoCambioDiseno()
        {
            OfdCambioDiseno = new HashSet<OfdCambioDiseno>();
            OfdSolicitudDiseno = new HashSet<OfdSolicitudDiseno>();
        }

        public string IdTipoCambio { get; set; }
        public string NombreTipoCambio { get; set; }
        public short IdPonderacion { get; set; }
        public string UsuarioRegistro { get; set; }
        public DateTime FechaRegistro { get; set; }

        public virtual ICollection<OfdCambioDiseno> OfdCambioDiseno { get; set; }
        public virtual ICollection<OfdSolicitudDiseno> OfdSolicitudDiseno { get; set; }
    }
}
