using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class AppSubCategory
    {
        public AppSubCategory()
        {
            AppProducts = new HashSet<AppProducts>();
            AppVariableSearch = new HashSet<AppVariableSearch>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public int AppCategoryId { get; set; }

        public virtual AppCategory AppCategory { get; set; }
        public virtual ICollection<AppProducts> AppProducts { get; set; }
        public virtual ICollection<AppVariableSearch> AppVariableSearch { get; set; }
    }
}
