﻿using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy501
    {
        public Wsmy501()
        {
            Wpry229 = new HashSet<Wpry229>();
            Wpry232 = new HashSet<Wpry232>();
            Wpry240 = new HashSet<Wpry240>();
            Wpry241 = new HashSet<Wpry241>();
            Wsmy502 = new HashSet<Wsmy502>();
        }

        public string Cotizacion { get; set; }
        public string CodVendedor { get; set; }
        public string CodCliente { get; set; }
        public string Prospecto { get; set; }
        public DateTime? Fecha { get; set; }
        public string Observaciones { get; set; }
        public DateTime? FechaCaducidad { get; set; }
        public DateTime? FechaPostergada { get; set; }
        public int? Estatus { get; set; }
        public string RazonSocial { get; set; }
        public int? Tipo { get; set; }
        public int? Sector { get; set; }
        public int? Ramo { get; set; }
        public string EmailCliente { get; set; }
        public string Rif { get; set; }
        public int? Condicion { get; set; }
        public int? IdContacto { get; set; }
        public string ObservacionPostergar { get; set; }
        public DateTime? FechaEnEspera { get; set; }
        public DateTime? FechaCerrada { get; set; }
        public string UsuarioActualiza { get; set; }
        public DateTime? FechaActualiza { get; set; }
        public string NombreContacto { get; set; }
        public string TelefonoContacto { get; set; }
        public string EmailContacto { get; set; }
        public decimal? IdDireccion { get; set; }
        public string DireccionFacturar { get; set; }
        public string DireccionEntregar { get; set; }
        public string FlagWebSite { get; set; }
        public string RifEntregar { get; set; }
        public string OrdenCompra { get; set; }
        public short? IdMedio { get; set; }
        public string FlagActualizado { get; set; }
        public decimal? IdDireccionEntregar { get; set; }
        public string EstadoFacturar { get; set; }
        public string MunicipioFacturar { get; set; }
        public string EstadoEntregar { get; set; }
        public string MunicipioEntregar { get; set; }
        public bool? FlagValidado { get; set; }
        public DateTime? FechaReactivacion { get; set; }
        public string IdClienteProspecto { get; set; }
        public decimal? IdsolicitudCredito { get; set; }
        public string UltimoEvaluadorCredito { get; set; }
        public bool? EvaluadaAdministradora { get; set; }
        public bool? CambioPrecio { get; set; }
        public bool? Noreplicar { get; set; }
        public string IdTipoTransaccion { get; set; }
        public bool? NegocioEnUsd { get; set; }
        public bool? FijarPrecioBs { get; set; }
        public bool? FijarPrecioBsAprobado { get; set; }
        public DateTime? FechaPago { get; set; }
        public string ObservacionPago { get; set; }
        public decimal Id { get; set; }
        public decimal? TasaExcepcion { get; set; }
        public bool? ImprimirFacturaEnUsd { get; set; }
        public int Proximo { get; set; }
        public bool OrigenExterno { get; set; }

        public virtual ICollection<Wpry229> Wpry229 { get; set; }
        public virtual ICollection<Wpry232> Wpry232 { get; set; }
        public virtual ICollection<Wpry240> Wpry240 { get; set; }
        public virtual ICollection<Wpry241> Wpry241 { get; set; }
        public virtual ICollection<Wsmy502> Wsmy502 { get; set; }
    }
}
