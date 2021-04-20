using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class Company
    {
        public Company()
        {
            User = new HashSet<User>();
        }

        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Logo { get; set; }

        public virtual ICollection<User> User { get; set; }
    }
}
