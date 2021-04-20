using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class GssUsuarioPlantillaServicio
    {
        public int IdUsuarioPlantillaServicio { get; set; }
        public int IdUsuario { get; set; }
        public int IdServicio { get; set; }
        public int IdVariable { get; set; }

        public virtual GssServicios IdServicioNavigation { get; set; }
        public virtual GssVariable IdVariableNavigation { get; set; }
    }
}
