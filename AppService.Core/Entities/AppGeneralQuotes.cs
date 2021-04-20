using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class AppGeneralQuotes
    {
        public AppGeneralQuotes()
        {
            AppDetailQuotes = new HashSet<AppDetailQuotes>();
        }


        public int Id { get; set; }
        public string IdVendedor { get; set; }
        public string IdCliente { get; set; }
        public DateTime Fecha { get; set; }
        public string Observaciones { get; set; }
        public int DiasVigencia { get; set; }
        public DateTime FechaCaducidad { get; set; }
        public DateTime? FechaPostergada { get; set; }
        public int IdEstatus { get; set; }
        public short IdCondPago { get; set; }
        public long IdContacto { get; set; }
        public string ObservacionPostergar { get; set; }
        public decimal IdDireccionFacturar { get; set; }
        public decimal IdDireccionEntregar { get; set; }
        public string OrdenCompra { get; set; }
        public string UsuarioActualiza { get; set; }
        public DateTime FechaActualiza { get; set; }
        public string UserCreate { get; set; }
        public string UserUpdate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string Cotizacion { get; set; }
        public string SearchText { get; set; }
        public int Proximo { get; set; }
        public long IdMtrTipoMoneda { get; set; }

        public bool FijarPrecioBs { get; set; }
        public string Rif { get; set; }
        public string RazonSocial { get; set; }
        public string Direccion { get; set; }

        public decimal? IdMunicipio { get; set; }
        public string DescripcionMunicipio { get; set; }


        public virtual MtrCliente IdClienteNavigation { get; set; }
       // public virtual Wivy003 IdCondPagoNavigation { get; set; }
        public virtual MtrContactos IdContactoNavigation { get; set; }
        public virtual MtrDirecciones IdDireccionEntregarNavigation { get; set; }
        public virtual MtrDirecciones IdDireccionFacturarNavigation { get; set; }
        public virtual AppStatusQuote IdEstatusNavigation { get; set; }
        public virtual MtrVendedor IdVendedorNavigation { get; set; }
        public virtual MtrTipoMoneda IdMtrTipoMonedaNavigation { get; set; }
        public virtual ICollection<AppDetailQuotes> AppDetailQuotes { get; set; }
    }

   
}

