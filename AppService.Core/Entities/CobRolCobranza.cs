using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class CobRolCobranza
    {
        public int IdRolCobranza { get; set; }
        public string IdUsuario { get; set; }
        public short IdOficina { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
