using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class OfdSolicitudDiseno
    {
        public OfdSolicitudDiseno()
        {
            OfdAdjuntosDiseno = new HashSet<OfdAdjuntosDiseno>();
            OfdDetalleSolicitudDiseno = new HashSet<OfdDetalleSolicitudDiseno>();
            OfdSeguimiento = new HashSet<OfdSeguimiento>();
            OfdSolicitudDisenoCambios = new HashSet<OfdSolicitudDisenoCambios>();
            OfdVoBoDiseno = new HashSet<OfdVoBoDiseno>();
        }

        public long IdSolicitud { get; set; }
        public long IdPropuesta { get; set; }
        public string IdPieImprenta { get; set; }
        public short IdTipoRespaldo { get; set; }
        public short UbicacionMarginal { get; set; }
        public bool FlagCambioParte { get; set; }
        public string ObsvSolicitud { get; set; }
        public string IdUsuario { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string UsuarioActivo { get; set; }
        public string IdTipoCambio { get; set; }

        public virtual OfdMaestroPieImprenta IdPieImprentaNavigation { get; set; }
        public virtual OfdPropuesta IdPropuestaNavigation { get; set; }
        public virtual OfdTipoCambioDiseno IdTipoCambioNavigation { get; set; }
        public virtual OfdMaestroTipoRespaldo IdTipoRespaldoNavigation { get; set; }
        public virtual OfdMaestroUbicacionMarginal UbicacionMarginalNavigation { get; set; }
        public virtual OfdAprobacionDiseno OfdAprobacionDiseno { get; set; }
        public virtual ICollection<OfdAdjuntosDiseno> OfdAdjuntosDiseno { get; set; }
        public virtual ICollection<OfdDetalleSolicitudDiseno> OfdDetalleSolicitudDiseno { get; set; }
        public virtual ICollection<OfdSeguimiento> OfdSeguimiento { get; set; }
        public virtual ICollection<OfdSolicitudDisenoCambios> OfdSolicitudDisenoCambios { get; set; }
        public virtual ICollection<OfdVoBoDiseno> OfdVoBoDiseno { get; set; }
    }
}
