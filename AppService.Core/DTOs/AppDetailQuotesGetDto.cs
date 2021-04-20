﻿using AppService.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Core.DTOs
{
    public class AppDetailQuotesGetDto
    {

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
        public decimal ValorConvertido { get; set; }
        public decimal UnitPriceBaseProduction { get; set; }
        public decimal UnitPriceConverted { get; set; }
        public int? RazonGanadaPerdida { get; set; }
        public int? Competidor { get; set; }
        public int MyProperty { get; set; }
        public decimal CantidadPorUnidadProduccion { get; set; }

        public string ObsSolicitud { get; set; }

        public AppProductsGetDto AppProductsGetDto { get; set; }

        public AppStatusQuoteGetDto AppStatusQuoteGetDto { get; set; }

        public AppUnitsGetDto AppUnitsGetDto { get; set; }

        public List<AppTemplateConversionUnitGetDto> AppTemplateConversionUnitGetDto { get; set; }
       
        public StatusAprobacionDto StatusAprobacionDto { get; set; }


    }
}
