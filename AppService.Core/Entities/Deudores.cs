using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class Deudores
    {
        public string Cliente { get; set; }
        public string Nombre { get; set; }
        public string Rif { get; set; }
        public string Clase { get; set; }
    }
}
