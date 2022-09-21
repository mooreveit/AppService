using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Core.DTOs
{
    public class AppGeneralQuotesCreateDto
    {

                
        public string IdCliente { get; set; }
        public decimal IdDireccionFacturar { get; set; }
        public decimal IdDireccionEntregar { get; set; }
        public short IdCondPago { get; set; }
        public long IdContacto { get; set; }

        public long IdMtrTipoMoneda { get; set; }
        public string OrdenCompra { get; set; }
        public DateTime Fecha { get; set; }
        public string Observaciones { get; set; }
        public string UsuarioActualiza { get; set; }
      
        public bool FijarPrecioBs { get; set; }
        public string Rif { get; set; }
        public string RazonSocial { get; set; }
        public string Direccion { get; set; }
        public decimal IdMunicipio { get; set; }


    }
}
