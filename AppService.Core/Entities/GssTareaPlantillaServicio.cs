using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class GssTareaPlantillaServicio
    {
        public long IdTareaPlantillaServicio { get; set; }
        public long IdTarea { get; set; }
        public int IdPlantillaServicio { get; set; }
        public int IdVariable { get; set; }
        public string ValorEntrada { get; set; }
        public string ValorSalida { get; set; }
        public string MensajeBusqueda { get; set; }
        public short Secuencia { get; set; }
        public bool? Requerido { get; set; }
        public DateTime FechaCambio { get; set; }
        public int UsuarioCambio { get; set; }

        public virtual GssPlantillaServicio IdPlantillaServicioNavigation { get; set; }
        public virtual GssTarea IdTareaNavigation { get; set; }
    }
}
