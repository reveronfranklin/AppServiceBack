using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class EjeucionProcesoComisiones
    {
        public decimal Id { get; set; }
        public decimal IdEvaluacion { get; set; }
        public string Query { get; set; }
        public string Mensaje { get; set; }
        public DateTime? Inicio { get; set; }
        public DateTime? Fin { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaEjecucion { get; set; }
    }
}
