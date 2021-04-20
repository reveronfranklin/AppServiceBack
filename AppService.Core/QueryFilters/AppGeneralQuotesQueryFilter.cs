using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Core.QueryFilters
{
    public class AppGeneralQuotesQueryFilter
    {
        //Paginacion
        public int PageSize { get; set; }

        public int PageNumber { get; set; }


        //Filtros
        public string UsuarioConectado { get; set; }

        public string Cotizacion { get; set; }

        public string SearchText { get; set; }



    }
}
