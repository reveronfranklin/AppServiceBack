using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class GssNivel
    {
        public GssNivel()
        {
            GssAprobacionServicio = new HashSet<GssAprobacionServicio>();
            GssServicioNivel = new HashSet<GssServicioNivel>();
            GssUsuarioNivel = new HashSet<GssUsuarioNivel>();
        }

        public int IdNivel { get; set; }
        public string NombreNivel { get; set; }
        public bool FlagSolicitante { get; set; }
        public bool FlagAprobador { get; set; }
        public bool FlagAprobadorServicio { get; set; }
        public bool FlagAprobadorGerencia { get; set; }
        public bool FlagCoordinador { get; set; }
        public bool FlagEjecutor { get; set; }
        public short Secuencia { get; set; }
        public short IdUnidadServicio { get; set; }
        public DateTime FechaCambio { get; set; }
        public int UsuarioCambio { get; set; }

        public virtual GssUnidadServicio IdUnidadServicioNavigation { get; set; }
        public virtual ICollection<GssAprobacionServicio> GssAprobacionServicio { get; set; }
        public virtual ICollection<GssServicioNivel> GssServicioNivel { get; set; }
        public virtual ICollection<GssUsuarioNivel> GssUsuarioNivel { get; set; }
    }
}
