﻿using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMaestros
{
    public partial class VEmail
    {
        public decimal Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Texto { get; set; }
        public string Depurar { get; set; }
        public string Copia { get; set; }
        public string CopiaOculta { get; set; }
        public DateTime? FechaCreado { get; set; }
        public string HoraCreado { get; set; }
        public DateTime? FechaEnvio { get; set; }
        public string HoraEnvio { get; set; }
        public short? IdCarta { get; set; }
        public string IdFile { get; set; }
        public string Password { get; set; }
        public string NsfFile { get; set; }
    }
}
