using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Core.DTOs
{
    public class AppRecipesCreateDto
    {

        
        public int? AppproductsId { get; set; }
        public int? AppVariableId { get; set; }
        public string Description { get; set; }
        public int? AppIngredientsId { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? TotalCost { get; set; }
        public string Formula { get; set; }
        public int OrderCalculate { get; set; }

        public bool SumValue { get; set; }
        public bool IncludeInSearch { get; set; }
        public int Secuencia { get; set; }
        public bool AfectaCosto { get; set; }

    }
}
