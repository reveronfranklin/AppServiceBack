using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class GssTarea
    {
        public GssTarea()
        {
            GssAdjuntoTarea = new HashSet<GssAdjuntoTarea>();
            GssAprobacionServicio = new HashSet<GssAprobacionServicio>();
            GssTareaComentario = new HashSet<GssTareaComentario>();
            GssTareaPlantillaServicio = new HashSet<GssTareaPlantillaServicio>();
        }

        public long IdTarea { get; set; }
        public DateTime FechaTarea { get; set; }
        public DateTime? FechaEntrega { get; set; }
        public DateTime? FechaProcesada { get; set; }
        public DateTime? FechaCierre { get; set; }
        public int IdServicio { get; set; }
        public long IdSolicitud { get; set; }
        public string Observaciones { get; set; }
        public DateTime FechaCambio { get; set; }
        public int UsuarioCambio { get; set; }

        public virtual GssServicios IdServicioNavigation { get; set; }
        public virtual GssSolicitud IdSolicitudNavigation { get; set; }
        public virtual ICollection<GssAdjuntoTarea> GssAdjuntoTarea { get; set; }
        public virtual ICollection<GssAprobacionServicio> GssAprobacionServicio { get; set; }
        public virtual ICollection<GssTareaComentario> GssTareaComentario { get; set; }
        public virtual ICollection<GssTareaPlantillaServicio> GssTareaPlantillaServicio { get; set; }
    }
}
