using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class AppIngredients
    {
        public AppIngredients()
        {
            AppRecipes = new HashSet<AppRecipes>();
            AppUnitsofMeasureforIngredients = new HashSet<AppUnitsofMeasureforIngredients>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int AppUnitId { get; set; }
        public decimal Cost { get; set; }
        public long? PrymaryMtrMonedaId { get; set; }
        public long? SecundaryMtrMonedaId { get; set; }
        public string UserCreate { get; set; }
        public string UserUpdate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual MtrTipoMoneda PrymaryMtrMoneda { get; set; }
        public virtual MtrTipoMoneda SecundaryMtrMoneda { get; set; }
        public virtual ICollection<AppRecipes> AppRecipes { get; set; }
        public virtual ICollection<AppUnitsofMeasureforIngredients> AppUnitsofMeasureforIngredients { get; set; }
    }
}
