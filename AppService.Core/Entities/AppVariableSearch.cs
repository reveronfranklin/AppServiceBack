using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class AppVariableSearch
    {
        public int Id { get; set; }
        public int? AppSubCategoryId { get; set; }
        public int? AppVariableId { get; set; }
        public string SearchText { get; set; }

        public virtual AppSubCategory AppSubCategory { get; set; }
        public virtual AppVariables AppVariable { get; set; }
    }
}
