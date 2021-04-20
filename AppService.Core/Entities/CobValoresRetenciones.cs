using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class CobValoresRetenciones
    {
        public long IdTransaccion { get; set; }
        public string Valores { get; set; }
        public bool FlagRango { get; set; }
        public bool FlagValorFijo { get; set; }
        public bool FlagRetieneSobreImp { get; set; }
        public string UsuarioRegistro { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string UsuarioModifica { get; set; }
        public DateTime? FechaModifica { get; set; }
    }
}
