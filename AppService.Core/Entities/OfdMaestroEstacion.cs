using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class OfdMaestroEstacion
    {
        public OfdMaestroEstacion()
        {
            OfdSeguimiento = new HashSet<OfdSeguimiento>();
        }

        public short IdEstacion { get; set; }
        public short IdFlujo { get; set; }
        public string NombreEstacion { get; set; }
        public string AbreviadoEstacion { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string UsuarioRegistro { get; set; }

        public virtual OfdMaestroFlujo IdFlujoNavigation { get; set; }
        public virtual OfdFlujoEstacion OfdFlujoEstacion { get; set; }
        public virtual ICollection<OfdSeguimiento> OfdSeguimiento { get; set; }
    }
}
