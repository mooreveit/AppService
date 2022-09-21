using System;
using System.Collections.Generic;

namespace AppService.Core.DTOs.Odoo.Cotizaciones.Recibir
{
    public class GeneralGetDto
    {


        public int Id { get; set; }
        public string Cotizacion { get; set; }
        public string IdCliente { get; set; }
        public decimal IdDireccionFacturar { get; set; }
        public decimal IdDireccionEntregar { get; set; }
        public short IdCondPago { get; set; }
        public long IdContacto { get; set; }

        public long IdMtrTipoMoneda { get; set; }
        public string OrdenCompra { get; set; }
        public DateTime Fecha { get; set; }
        public string Observaciones { get; set; }
        public string Rif { get; set; }
        public string RazonSocial { get; set; }
        public string Direccion { get; set; }
        public decimal IdMunicipio { get; set; }
        public List<DetailGetDto> Details { get; set; }




    }
}
