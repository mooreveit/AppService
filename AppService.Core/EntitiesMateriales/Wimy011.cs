using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMateriales
{
    public partial class Wimy011
    {
        public decimal Recnum { get; set; }
        public int Bobina { get; set; }
        public int Rollo { get; set; }
        public string Codigo { get; set; }
        public DateTime? FechaTransac { get; set; }
        public string Ubicacion { get; set; }
        public short Diametro { get; set; }
        public decimal Ancho { get; set; }
        public int Proveedor { get; set; }
        public long OrdenCompra { get; set; }
        public DateTime? Fecrec { get; set; }
        public int Nroir { get; set; }
        public decimal CostoFactura { get; set; }
        public long AsigDocket { get; set; }
        public int Orden { get; set; }
        public DateTime? Feccon { get; set; }
        public string Nrfact { get; set; }
        public long Nrnotaentrega { get; set; }
        public string Unidad { get; set; }
        public string LoteProveedor { get; set; }
        public string TipoPapel { get; set; }
        public string Gramaje { get; set; }
        public string Color { get; set; }
        public long Salini { get; set; }
        public long Entradas { get; set; }
        public long Salidas { get; set; }
        public long Saldo { get; set; }
        public int Hijos { get; set; }
        public long KilosTransa { get; set; }
        public int NroReporte { get; set; }
        public int Programacion { get; set; }
        public string TicketImpreso { get; set; }
        public string UsuarioCrea { get; set; }
        public string UsuarioModif { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModif { get; set; }
        public string PasoSql { get; set; }
        public short Item { get; set; }
        public short ItemIr { get; set; }
        public int RolloProveedor { get; set; }
    }
}
