using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class SegRolEstacion
    {
        public int IdRolEstacion { get; set; }
        public int IdRol { get; set; }
        public short IdEstacion { get; set; }
    }
}
