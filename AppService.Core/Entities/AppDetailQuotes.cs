using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class AppDetailQuotes
    {
        public AppDetailQuotes()
        {
            AppDetailQuotesConversionUnit = new HashSet<AppDetailQuotesConversionUnit>();
        }

        public int Id { get; set; }
        public int AppGeneralQuotesId { get; set; }
        public string Cotizacion { get; set; }
        public string Producto { get; set; }
        public int IdProducto { get; set; }
        public string NombreComercialProducto { get; set; }
        public int IdEstatus { get; set; }
        public decimal Cantidad { get; set; }
        public decimal CantidadSolicitada { get; set; }
        public decimal Precio { get; set; }
        public decimal Total { get; set; }
        public decimal PrecioUsd { get; set; }
        public decimal TotalUsd { get; set; }
        public int IdUnidad { get; set; }
        public string Observaciones { get; set; }
        public int DiasEntrega { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string UserCreate { get; set; }
        public string UserUpdate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
       
       
        public int? RazonGanadaPerdida { get; set; }
        public int? Competidor { get; set; }

       

        public string ObsSolicitud { get; set; }

        public decimal ValorConvertido { get; set; }
        public decimal UnitPriceBaseProduction { get; set; }
        public decimal UnitPriceConverted { get; set; }
        public decimal CantidadPorUnidadProduccion { get; set; }
        public int QuantityPerPackage { get; set; }

        public virtual AppGeneralQuotes AppGeneralQuotes { get; set; }
        public virtual AppStatusQuote IdEstatusNavigation { get; set; }
        public virtual AppProducts IdProductoNavigation { get; set; }
        public virtual AppUnits IdUnidadNavigation { get; set; }
        public virtual ICollection<AppDetailQuotesConversionUnit> AppDetailQuotesConversionUnit { get; set; }
    }
}
