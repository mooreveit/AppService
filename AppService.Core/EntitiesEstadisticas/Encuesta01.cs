using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class Encuesta01
    {
        public int Recnum { get; set; }
        /// <summary>
        /// CODIGO DE OFICINA
        /// </summary>
        public decimal? CodOficina { get; set; }
        /// <summary>
        /// NOMBRE OFICINA
        /// </summary>
        public string Oficina { get; set; }
        /// <summary>
        /// CODIGO DEL VENDEDOR
        /// </summary>
        public string CodVendedor { get; set; }
        /// <summary>
        /// NOMBRE VENDEDOR
        /// </summary>
        public string Vendedor { get; set; }
        /// <summary>
        /// CODIGO DEL CLIENTE
        /// </summary>
        public decimal CodCliente { get; set; }
        /// <summary>
        /// NOMBRE DEL CLIENTE
        /// </summary>
        public string Cliente { get; set; }
        /// <summary>
        /// NUMERO REGISTRO TRIBUTARIO
        /// </summary>
        public string Rif { get; set; }
        /// <summary>
        /// NUMERO DE ORDEN
        /// </summary>
        public decimal Orden { get; set; }
        /// <summary>
        /// Tipo de orden
        /// </summary>
        public string Tipo { get; set; }
        /// <summary>
        /// Fecha de despacho
        /// </summary>
        public DateTime FechaEntrega { get; set; }
        /// <summary>
        /// CALIDAD DEL PRODUCTO (MUY BUENO)
        /// </summary>
        public string Cp1 { get; set; }
        /// <summary>
        /// CALIDAD DEL PRODUCTO (BUENO)
        /// </summary>
        public string Cp2 { get; set; }
        /// <summary>
        /// CALIDAD DEL PRODUCTO (REGULAR)
        /// </summary>
        public string Cp3 { get; set; }
        /// <summary>
        /// CALIDAD DEL PRODUCTO (MALO)
        /// </summary>
        public string Cp4 { get; set; }
        /// <summary>
        /// Observaciones Calidad del Producto
        /// </summary>
        public string ObservacionesCp { get; set; }
        /// <summary>
        /// TIEMPO DE ENTREGA (MUY BUENO)
        /// </summary>
        public string Te1 { get; set; }
        /// <summary>
        /// TIEMPO DE ENTREGA (BUENO)
        /// </summary>
        public string Te2 { get; set; }
        /// <summary>
        /// TIEMPO DE ENTREGA (REGULAR)
        /// </summary>
        public string Te3 { get; set; }
        /// <summary>
        /// TIEMPO DE ENTREGA (MALO)
        /// </summary>
        public string Te4 { get; set; }
        /// <summary>
        /// Observaciones Tiempo de Entrega
        /// </summary>
        public string ObservacionesTe { get; set; }
        /// <summary>
        /// SERVICIO DEL VENDEDOR (MUY BUENO)
        /// </summary>
        public string Sv1 { get; set; }
        /// <summary>
        /// SERVICIO DEL VENDEDOR (BUENO)
        /// </summary>
        public string Sv2 { get; set; }
        /// <summary>
        /// SERVICIO DEL VENDEDOR (REGULAR)
        /// </summary>
        public string Sv3 { get; set; }
        /// <summary>
        /// SERVICIO DEL VENDEDOR (MALO)
        /// </summary>
        public string Sv4 { get; set; }
        /// <summary>
        /// Observaciones Servicio del Vendedor
        /// </summary>
        public string ObservacionesSv { get; set; }
        /// <summary>
        /// SERVICIO DEL TRANSPORTISTA (MUY BUENO)
        /// </summary>
        public string St1 { get; set; }
        /// <summary>
        /// SERVICIO DEL TRANSPORTISTA (BUENO)
        /// </summary>
        public string St2 { get; set; }
        /// <summary>
        /// SERVICIO DEL TRANSPORTISTA (REGULAR)
        /// </summary>
        public string St3 { get; set; }
        /// <summary>
        /// SERVICIO DEL TRANSPORTISTA (MALO)
        /// </summary>
        public string St4 { get; set; }
        /// <summary>
        /// Observaciones Servicio TRansporte
        /// </summary>
        public string ObservacionesSt { get; set; }
        public string ObservacionesGnrl { get; set; }
        /// <summary>
        /// FECHA REALIZACIÓN DE LA ENCUESTA
        /// </summary>
        public DateTime FechaEncuesta { get; set; }
        public string Efectiva { get; set; }
        public string EncuestaCliente { get; set; }
        public long Rnc { get; set; }
        public DateTime? FechaReg { get; set; }
    }
}
