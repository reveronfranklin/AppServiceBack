using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class AutoAudit
    {
        public long AuditId { get; set; }
        public DateTime? AuditDate { get; set; }
        public string AuditUserName { get; set; }
        public string TableName { get; set; }
        public string OldContent { get; set; }
        public string NewContent { get; set; }
    }
}
