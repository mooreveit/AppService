using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wpry227
    {
        public int Recnum { get; set; }
        public long Orden { get; set; }
        public long Job { get; set; }
        public int IdTipoSolicitud { get; set; }
        public string TipoSolicitud { get; set; }
        public int CodCliente { get; set; }
        public string Cliente { get; set; }
        public int CodOficina { get; set; }
        public string Oficina { get; set; }
        public string CodVendedor { get; set; }
        public string Vendedor { get; set; }
        public int CodMotivo { get; set; }
        public string Motivo { get; set; }
        public short Dia { get; set; }
        public short Mes { get; set; }
        public short Ano { get; set; }
        public short Trimestre { get; set; }
        public short TotalSolicitudes { get; set; }
        public short AprobadoSoporteVenta { get; set; }
        public short RechazadoSoporteVenta { get; set; }
        public short AprobadoProduccion { get; set; }
        public short RechazadoProduccion { get; set; }
        public string Usuario { get; set; }
    }
}
