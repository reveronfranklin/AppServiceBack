using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class MtrPerfilCorreo
    {
        public decimal Id { get; set; }
        public string PerfilId { get; set; }
        public string Perfil { get; set; }
    }
}
