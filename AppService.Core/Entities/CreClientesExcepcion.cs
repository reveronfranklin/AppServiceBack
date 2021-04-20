using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class CreClientesExcepcion
    {
        public decimal Id { get; set; }
        public string CodCliente { get; set; }
        public string Excepcion { get; set; }
    }
}
