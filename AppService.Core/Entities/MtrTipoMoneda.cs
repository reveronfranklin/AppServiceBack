using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class MtrTipoMoneda
    {
        public MtrTipoMoneda()
        {
            AppGeneralQuotes = new HashSet<AppGeneralQuotes>();
            AppIngredientsPrymaryMtrMoneda = new HashSet<AppIngredients>();
            AppIngredientsSecundaryMtrMoneda = new HashSet<AppIngredients>();
            AppProductsPrymaryMtrMoneda = new HashSet<AppProducts>();
            AppProductsSecundaryMtrMoneda = new HashSet<AppProducts>();
            CobGeneralCobranza = new HashSet<CobGeneralCobranza>();
        }

        public long Id { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<AppGeneralQuotes> AppGeneralQuotes { get; set; }
        public virtual ICollection<AppIngredients> AppIngredientsPrymaryMtrMoneda { get; set; }
        public virtual ICollection<AppIngredients> AppIngredientsSecundaryMtrMoneda { get; set; }
        public virtual ICollection<AppProducts> AppProductsPrymaryMtrMoneda { get; set; }
        public virtual ICollection<AppProducts> AppProductsSecundaryMtrMoneda { get; set; }
        public virtual ICollection<CobGeneralCobranza> CobGeneralCobranza { get; set; }
    }
}
