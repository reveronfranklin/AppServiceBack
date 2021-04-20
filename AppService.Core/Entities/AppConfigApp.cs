using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class AppConfigApp
    {
        public int Id { get; set; }
        public string Clave { get; set; }
        public string Valor { get; set; }
    }
}
