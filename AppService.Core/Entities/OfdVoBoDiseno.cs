using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class OfdVoBoDiseno
    {
        public long IdVoBoSolicitud { get; set; }
        public short IdVoBo { get; set; }
        public long IdSolicitud { get; set; }
        public bool Estatus { get; set; }
        public string IdUsuario { get; set; }
        public DateTime FechaRegistro { get; set; }

        public virtual OfdSolicitudDiseno IdSolicitudNavigation { get; set; }
        public virtual OfdMaestroVoBo IdVoBoNavigation { get; set; }
    }
}
