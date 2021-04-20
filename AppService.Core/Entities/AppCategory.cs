using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class AppCategory
    {
        public AppCategory()
        {
            AppSubCategory = new HashSet<AppSubCategory>();
        }

        public int Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<AppSubCategory> AppSubCategory { get; set; }
    }
}
