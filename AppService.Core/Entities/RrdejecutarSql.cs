using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class RrdejecutarSql
    {
        public decimal Id { get; set; }
        public string Proceso { get; set; }
        public string QuerySql { get; set; }
        public string Ejecutar { get; set; }
    }
}
