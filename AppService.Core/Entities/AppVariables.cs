using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class AppVariables
    {
        public AppVariables()
        {
            AppDetailQuotesConversionUnit = new HashSet<AppDetailQuotesConversionUnit>();
            AppProductVariableSearchText = new HashSet<AppProductVariableSearchText>();
            AppRecipes = new HashSet<AppRecipes>();
            AppTemplateConversionUnit = new HashSet<AppTemplateConversionUnit>();
            AppVariableSearch = new HashSet<AppVariableSearch>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int TipoVariable { get; set; }
        public string UserCreate { get; set; }
        public string UserUpdate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool Entero { get; set; }

        public virtual ICollection<AppDetailQuotesConversionUnit> AppDetailQuotesConversionUnit { get; set; }
        public virtual ICollection<AppProductVariableSearchText> AppProductVariableSearchText { get; set; }
        public virtual ICollection<AppRecipes> AppRecipes { get; set; }
        public virtual ICollection<AppTemplateConversionUnit> AppTemplateConversionUnit { get; set; }
        public virtual ICollection<AppVariableSearch> AppVariableSearch { get; set; }
    }
}
