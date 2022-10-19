using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMateriales
{
    public partial class Wimy028
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
        public long Orden { get; set; }
        public DateTime? Feccon { get; set; }
        public long Nrfact { get; set; }
        public long Nrnotaentrega { get; set; }
        public string Unidad { get; set; }
        public string LoteProveedor { get; set; }
        public string TipoPapel { get; set; }
        public string Gramaje { get; set; }
        public string Color { get; set; }
        public string Transaccion { get; set; }
        public long Cantidad { get; set; }
        public string ES { get; set; }
        public int NroReporte { get; set; }
        public short CausaAjuste { get; set; }
        public short AloContable { get; set; }
        public short MesContable { get; set; }
        public string Listar { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string PasoSql { get; set; }
    }
}
