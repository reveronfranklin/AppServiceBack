using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class CatCalibrePapel
    {
        public string Papel { get; set; }
        public int? Gramaje { get; set; }
        public decimal? Calibre { get; set; }
    }
}
