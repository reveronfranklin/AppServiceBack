using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class GssSolicitud
    {
        public GssSolicitud()
        {
            GssPasoSolicitud = new HashSet<GssPasoSolicitud>();
            GssTarea = new HashSet<GssTarea>();
        }

        public long IdSolicitud { get; set; }
        public string TituloSolicitud { get; set; }
        public string DescripcionSolicitud { get; set; }
        public string JustificacionSolicitud { get; set; }
        public short IdUnidadServicio { get; set; }
        public short IdEstatusSolicitud { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public DateTime FechaCambio { get; set; }
        public int UsuarioCambio { get; set; }

        public virtual GssEstatusSolicitud IdEstatusSolicitudNavigation { get; set; }
        public virtual GssUnidadServicio IdUnidadServicioNavigation { get; set; }
        public virtual ICollection<GssPasoSolicitud> GssPasoSolicitud { get; set; }
        public virtual ICollection<GssTarea> GssTarea { get; set; }
    }
}
