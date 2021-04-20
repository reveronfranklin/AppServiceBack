using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class CrmNotificacionActividades
    {
        public decimal IdNotificacion { get; set; }
        public long IdSeguimiento { get; set; }
        public string Para { get; set; }
        public string Cc { get; set; }
        public string Cuerpo { get; set; }
        public DateTime FechaHoraEnvio { get; set; }
    }
}
