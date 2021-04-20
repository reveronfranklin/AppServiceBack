using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Core.DTOs
{
    public class AppGeneralQuotesActionSheetDto
    {

        public bool Actualizar { get; set; }
        public bool EnviarAlCliente { get; set; }

        public bool EnviarAprobacionPrecio { get; set; }

        public bool GanarPerder { get; set; }
        public bool Postergar { get; set; }
        public bool Eliminar { get; set; }
        public bool Cancel { get; set; }

        public bool ExistQuotes { get; set; }

        public bool Imprimir { get; set; }

    }
}
