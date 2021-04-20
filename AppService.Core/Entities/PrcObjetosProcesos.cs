using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class PrcObjetosProcesos
    {
        public PrcObjetosProcesos()
        {
            PrcUsuarioProcesos = new HashSet<PrcUsuarioProcesos>();
        }

        public decimal Id { get; set; }
        public string Servidor { get; set; }
        public string BaseDatos { get; set; }
        public string Objeto { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string UsuarioRegistro { get; set; }
        public decimal ColaDeTrabajo { get; set; }

        public virtual ICollection<PrcUsuarioProcesos> PrcUsuarioProcesos { get; set; }
    }
}
