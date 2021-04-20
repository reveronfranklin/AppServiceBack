﻿using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class CobAvisosCobro
    {
        public decimal Id { get; set; }
        public string Cliente { get; set; }
        public string Usuario { get; set; }
        public string NombreArchivo { get; set; }
        public byte[] Archivo { get; set; }
        public bool Procesado { get; set; }
        public DateTime? Fecha { get; set; }
        public byte[] ArchivotTiff { get; set; }
        public string Html { get; set; }
    }
}
