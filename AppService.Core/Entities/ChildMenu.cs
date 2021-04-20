using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class ChildMenu
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }
        public int PageMenuId { get; set; }
    }
}
