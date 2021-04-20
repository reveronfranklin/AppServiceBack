using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class AppUnits
    {
        public AppUnits()
        {
            AppDetailQuotes = new HashSet<AppDetailQuotes>();
            AppProductsAppUnits = new HashSet<AppProducts>();
            AppProductsProductionUnit = new HashSet<AppProducts>();
            AppTemplateConversionUnitAppUnitIdSinceNavigation = new HashSet<AppTemplateConversionUnit>();
            AppTemplateConversionUnitAppUnitIdUntilNavigation = new HashSet<AppTemplateConversionUnit>();
            AppUnitsofMeasureforIngredients = new HashSet<AppUnitsofMeasureforIngredients>();
            AppUnitsofMeasureforMaterials = new HashSet<AppUnitsofMeasureforMaterials>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public string Description3 { get; set; }
        public string Description4 { get; set; }
        public string UserCreate { get; set; }
        public string UserUpdate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual ICollection<AppDetailQuotes> AppDetailQuotes { get; set; }
        public virtual ICollection<AppProducts> AppProductsAppUnits { get; set; }
        public virtual ICollection<AppProducts> AppProductsProductionUnit { get; set; }
        public virtual ICollection<AppTemplateConversionUnit> AppTemplateConversionUnitAppUnitIdSinceNavigation { get; set; }
        public virtual ICollection<AppTemplateConversionUnit> AppTemplateConversionUnitAppUnitIdUntilNavigation { get; set; }
        public virtual ICollection<AppUnitsofMeasureforIngredients> AppUnitsofMeasureforIngredients { get; set; }
        public virtual ICollection<AppUnitsofMeasureforMaterials> AppUnitsofMeasureforMaterials { get; set; }
    }
}
