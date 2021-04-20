using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class GssPlantillaServicio
    {
        public GssPlantillaServicio()
        {
            GssTareaPlantillaServicio = new HashSet<GssTareaPlantillaServicio>();
        }

        public int IdPlantillaServicio { get; set; }
        public int IdServicio { get; set; }
        public int IdVariable { get; set; }
        public string FuncionBusqueda { get; set; }
        public short Secuencia { get; set; }
        public bool Requerido { get; set; }
        public bool Activo { get; set; }
        public bool? OcultaDuplicado { get; set; }
        public DateTime FechaCambio { get; set; }
        public int UsuarioCambio { get; set; }

        public virtual GssServicios IdServicioNavigation { get; set; }
        public virtual GssVariable IdVariableNavigation { get; set; }
        public virtual ICollection<GssTareaPlantillaServicio> GssTareaPlantillaServicio { get; set; }
    }
}
