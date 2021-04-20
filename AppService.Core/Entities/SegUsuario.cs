using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class SegUsuario
    {
        public SegUsuario()
        {
            GssAprobacionServicio = new HashSet<GssAprobacionServicio>();
            GssUsuarioCompañia = new HashSet<GssUsuarioCompañia>();
            SegUsuarioRol = new HashSet<SegUsuarioRol>();
        }

        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public bool Inactivo { get; set; }
        public DateTime? FechaCambio { get; set; }
        public int? ConteoExpira { get; set; }
        public int? ConteoBloquea { get; set; }
        public string Email { get; set; }
        public string Ficha { get; set; }
        public double? An8 { get; set; }
        public string ClasificacionUsuario { get; set; }
        public string Imei1 { get; set; }
        public string EquipoImei1 { get; set; }
        public string Imei2 { get; set; }
        public string EquipoImei2 { get; set; }
        public string Imei3 { get; set; }
        public string EquipoImei3 { get; set; }
        public string FlagDisenador { get; set; }

        public virtual ICollection<GssAprobacionServicio> GssAprobacionServicio { get; set; }
        public virtual ICollection<GssUsuarioCompañia> GssUsuarioCompañia { get; set; }
        public virtual ICollection<SegUsuarioRol> SegUsuarioRol { get; set; }
    }
}
