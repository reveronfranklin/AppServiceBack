using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class OfdMaestroVoBo
    {
        public OfdMaestroVoBo()
        {
            OfdVoBoDiseno = new HashSet<OfdVoBoDiseno>();
        }

        public short IdVoBo { get; set; }
        public short IdEstacion { get; set; }
        public short Orden { get; set; }
        public string Instruccion { get; set; }
        public string IdUsuario { get; set; }
        public DateTime FechaRegistro { get; set; }

        public virtual ICollection<OfdVoBoDiseno> OfdVoBoDiseno { get; set; }
    }
}
