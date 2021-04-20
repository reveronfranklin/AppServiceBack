using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Core.DTOs
{
    class AppProductVariableSearchTextDto
    {

        public int Id { get; set; }
        public int? AppProductId { get; set; }
        public int? AppVariableId { get; set; }
        public string SearchText { get; set; }

    }
}
