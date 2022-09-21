using System;

namespace AppService.Core.DTOs.Odoo.Cotizaciones.Recibir
{
    public class DetailUpdateDto
    {

        public int Id { get; set; }
        public int GeneralId { get; set; }
        public string Cotizacion { get; set; }
        public int IdProducto { get; set; }
        public string NombreComercialProducto { get; set; }
        public int IdEstatus { get; set; }
        public decimal CantidadSolicitada { get; set; }
        public decimal Precio { get; set; }
        public decimal Total { get; set; }
        public int IdUnidad { get; set; }
        public string Observaciones { get; set; }

        public bool SolicitarPrecio { get; set; }
        public string ObsSolicitud { get; set; }


        public Decimal MedidaBasica { get; set; }
        public Decimal MedidaOpuesta { get; set; }

        public string UsuarioActualiza { get; set; }


    }
}
