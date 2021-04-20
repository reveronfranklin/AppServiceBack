using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class PrcOrdenIdPropuesta
    {
        public decimal Id { get; set; }
        public long IdPropuesta { get; set; }
        public long? Orden { get; set; }
    }
}
