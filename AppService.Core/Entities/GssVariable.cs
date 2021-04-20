using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class GssVariable
    {
        public GssVariable()
        {
            GssPlantillaServicio = new HashSet<GssPlantillaServicio>();
            GssUsuarioPlantillaServicio = new HashSet<GssUsuarioPlantillaServicio>();
        }

        public int IdVariable { get; set; }
        public string NombreVariable { get; set; }
        public string TituloVariable { get; set; }
        public short IdUnidadServicio { get; set; }
        public string TipoDato { get; set; }
        public string FuncionBusqueda { get; set; }
        public bool Activo { get; set; }
        public bool? FlagGenerica { get; set; }
        public DateTime FechaCambio { get; set; }
        public int UsuarioCambio { get; set; }

        public virtual ICollection<GssPlantillaServicio> GssPlantillaServicio { get; set; }
        public virtual ICollection<GssUsuarioPlantillaServicio> GssUsuarioPlantillaServicio { get; set; }
    }
}
