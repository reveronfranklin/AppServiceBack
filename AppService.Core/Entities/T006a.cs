using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class T006a
    {
        public T006a()
        {
         
            MtrProducto = new HashSet<MtrProducto>();
        }

        public string Mandt { get; set; }
        public string Spras { get; set; }
        public string Msehi { get; set; }
        public string Mseh3 { get; set; }
        public string Mseh6 { get; set; }
        public string Mseht { get; set; }
        public string Msehl { get; set; }


        public virtual ICollection<MtrProducto> MtrProducto { get; set; }
    }
}
