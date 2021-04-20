using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class AppProducts
    {
        public AppProducts()
        {
            AppDetailQuotes = new HashSet<AppDetailQuotes>();
            AppProductVariableSearchText = new HashSet<AppProductVariableSearchText>();
            AppRecipes = new HashSet<AppRecipes>();
            AppUnitsofMeasureforMaterials = new HashSet<AppUnitsofMeasureforMaterials>();
        }

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
        public string UserCreate { get; set; }
        public string UserUpdate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string VariablesSearchText { get; set; }
        public string ExternalCode { get; set; }
        public int QuantityPerPackage { get; set; }
        public bool AceptaMultiplesItem { get; set; }
        public bool RequiereDatosEntrada { get; set; }

        public virtual AppSubCategory AppSubCategory { get; set; }
        public virtual AppUnits AppUnits { get; set; }
        public virtual AppUnits ProductionUnit { get; set; }
        public virtual MtrTipoMoneda PrymaryMtrMoneda { get; set; }
        public virtual MtrTipoMoneda SecundaryMtrMoneda { get; set; }
        public virtual ICollection<AppDetailQuotes> AppDetailQuotes { get; set; }
        public virtual ICollection<AppProductVariableSearchText> AppProductVariableSearchText { get; set; }
        public virtual ICollection<AppRecipes> AppRecipes { get; set; }
        public virtual ICollection<AppUnitsofMeasureforMaterials> AppUnitsofMeasureforMaterials { get; set; }
    }
}
