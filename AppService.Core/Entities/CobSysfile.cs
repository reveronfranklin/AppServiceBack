﻿using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class CobSysfile
    {
        public short Id { get; set; }
        public DateTime FechaLm { get; set; }
        public bool? FlagAprobarRc { get; set; }
        public DateTime? FechaLmcxC { get; set; }
    }
}
