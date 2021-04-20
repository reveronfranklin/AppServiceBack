using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class OfdVariablesEspecificacion
    {
        public string IdVariable { get; set; }
        public string NombreVariable { get; set; }
        public string FlagObligatorio { get; set; }
        public string FlagInactiva { get; set; }
        public string IdVariableMc { get; set; }
        public string FlagMultipleValor { get; set; }
        public string FlagGralParte { get; set; }
    }
}
