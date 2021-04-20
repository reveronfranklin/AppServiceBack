using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class PrcPlantillaNumeraciones
    {
        public long Id { get; set; }
        public int? Mascara { get; set; }
        public int? Prefijo { get; set; }
        public string PrefijoChar { get; set; }
        public decimal? MaximoNumero { get; set; }
        public decimal? Hasta { get; set; }
    }
}
