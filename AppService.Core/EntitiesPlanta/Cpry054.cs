using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Cpry054
    {
        public decimal Recnum { get; set; }
        public int NoComprobante { get; set; }
        public string TipoOrden { get; set; }
        public long JobId { get; set; }
        public long Orden { get; set; }
        public DateTime FechaProduccio { get; set; }
        public short HoraProduccion { get; set; }
        public short DeptoRecibido { get; set; }
        public int CantidadProd { get; set; }
        public int NoFactura { get; set; }
        public DateTime? FechaFactura { get; set; }
        public int CantFacturada { get; set; }
        public int Cliente { get; set; }
        public string TotalParcial { get; set; }
        public string Vendedor { get; set; }
        public string Supervisor { get; set; }
        public DateTime? FecRecPlaneac { get; set; }
        public string FlagTipoJob { get; set; }
        public int Cajas { get; set; }
        public short MotivoEliminad { get; set; }
        public DateTime? FechaEliminada { get; set; }
        public string UserElimina { get; set; }
    }
}
