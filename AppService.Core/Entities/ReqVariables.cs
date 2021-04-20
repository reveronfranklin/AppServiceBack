using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class ReqVariables
    {
        public int IdVariable { get; set; }
        public string NombreVariable { get; set; }
        public int? IdTipoVariable { get; set; }
        public string TipoDato { get; set; }
        public string FuncionValidacion { get; set; }
        public DateTime? FechaCambio { get; set; }
        public string UsuarioCambio { get; set; }
    }
}
