﻿using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class GssEstatusSolicitud
    {
        public GssEstatusSolicitud()
        {
            GssSolicitud = new HashSet<GssSolicitud>();
        }

        public short IdEstatusSolicitud { get; set; }
        public string NombreEstatusSolicitud { get; set; }
        public string Abreviado { get; set; }
        public bool FlagCreada { get; set; }
        public bool FlagPorAprobar { get; set; }
        public bool FlagEnProceso { get; set; }
        public bool FlagCerrada { get; set; }
        public bool FlagCancelada { get; set; }
        public DateTime FechaCambio { get; set; }
        public int UsuarioCambio { get; set; }

        public virtual ICollection<GssSolicitud> GssSolicitud { get; set; }
    }
}
