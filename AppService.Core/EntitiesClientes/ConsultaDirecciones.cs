﻿using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesClientes
{
    public partial class ConsultaDirecciones
    {
        public decimal? Codigo { get; set; }
        public string Rif { get; set; }
        public decimal? IdDireccion { get; set; }
        public string Direccion { get; set; }
        public string Direccion1 { get; set; }
        public string Direccion2 { get; set; }
        public string Estado { get; set; }
        public string Municipio { get; set; }
        public string Nuevo { get; set; }
        public string Vendedor1 { get; set; }
        public string OficinaVenta { get; set; }
    }
}
