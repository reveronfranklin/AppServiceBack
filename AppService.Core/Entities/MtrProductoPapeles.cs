using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class MtrProductoPapeles
    {
        public decimal Id { get; set; }
        public string Producto { get; set; }
        public int Parte { get; set; }
        public string Papel { get; set; }
        public decimal? Frecuencia { get; set; }
        public string Descripcion { get; set; }
    }
}
