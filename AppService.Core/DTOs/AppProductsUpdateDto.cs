using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Core.DTOs
{
    public class AppProductsUpdateDto
    {

        public int Id { get; set; }
        public string Code { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public int? AppUnitsId { get; set; }
        public int? ProductionUnitId { get; set; }
        public decimal UnitPrice { get; set; }
        public long? PrymaryMtrMonedaId { get; set; }
        public long? SecundaryMtrMonedaId { get; set; }
        public string UrlImage { get; set; }
        public int? AppSubCategoryId { get; set; }
        public string UsuarioConectado { get; set; }
        public string ExternalCode { get; set; }

        public int QuantityPerPackage { get; set; }

    }
}
