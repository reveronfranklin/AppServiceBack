using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class GssServicios
    {
        public GssServicios()
        {
            GssPlantillaServicio = new HashSet<GssPlantillaServicio>();
            GssServicioNivel = new HashSet<GssServicioNivel>();
            GssTarea = new HashSet<GssTarea>();
            GssUsuarioPlantillaServicio = new HashSet<GssUsuarioPlantillaServicio>();
        }

        public int IdServicio { get; set; }
        public string NombreServicio { get; set; }
        public int IdTipoServicio { get; set; }
        public bool Activo { get; set; }
        public bool FlagCoordinado { get; set; }
        public bool FlagAdjunto { get; set; }
        public bool? FlagControlNomina { get; set; }
        public string FormatoReporte { get; set; }
        public DateTime FechaCambio { get; set; }
        public int UsuarioCambio { get; set; }

        public virtual GssTipoServicio IdTipoServicioNavigation { get; set; }
        public virtual ICollection<GssPlantillaServicio> GssPlantillaServicio { get; set; }
        public virtual ICollection<GssServicioNivel> GssServicioNivel { get; set; }
        public virtual ICollection<GssTarea> GssTarea { get; set; }
        public virtual ICollection<GssUsuarioPlantillaServicio> GssUsuarioPlantillaServicio { get; set; }
    }
}
