using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class AppProductVariableSearchText
    {
        public int Id { get; set; }
        public int? AppProductId { get; set; }
        public int? AppVariableId { get; set; }
        public string SearchText { get; set; }

        public virtual AppProducts AppProduct { get; set; }
        public virtual AppVariables AppVariable { get; set; }
    }
}
