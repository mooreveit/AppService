using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Wpry038
    {
        public decimal Recnum { get; set; }
        public long Orden { get; set; }
        public string Cliente { get; set; }
        public string TipoOrden { get; set; }
        public string DescripcionPro { get; set; }
        public short CtdCopys { get; set; }
        public string StatusOrden { get; set; }
        public string FechaArchivo { get; set; }
        public string FechaCalculo { get; set; }
        public short DiasCalculo { get; set; }
        public string UsuarioCalculo { get; set; }
        public string FechaTrans { get; set; }
        public short DiasTrans { get; set; }
        public string UsuarioTrans { get; set; }
        public string FechaDocket { get; set; }
        public short DiasDocket { get; set; }
        public string UsuarioDocket { get; set; }
        public string FechaPlan { get; set; }
        public short DiasPlan { get; set; }
        public string UsuarioPlan { get; set; }
        public string FechaPrelimin { get; set; }
        public short DiasArchivo { get; set; }
        public short DiasTotal { get; set; }
        public string CodProducto { get; set; }
        public DateTime? FechaDesde { get; set; }
        public DateTime? FechaHasta { get; set; }
        public short DiasHabiles { get; set; }
    }
}
