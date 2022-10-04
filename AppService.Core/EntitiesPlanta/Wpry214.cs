using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Wpry214
    {
        public decimal Recnum { get; set; }
        public short Item { get; set; }
        public long Orden { get; set; }
        public string Cliente { get; set; }
        public int Cantidad { get; set; }
        public short Partes { get; set; }
        public string Producto { get; set; }
        public int Ancho { get; set; }
        public int Largo { get; set; }
        public string Tinta1 { get; set; }
        public string Tinta2 { get; set; }
        public string Tinta3 { get; set; }
        public string Tinta4 { get; set; }
        public string Tinta5 { get; set; }
        public string Tinta1r { get; set; }
        public string Tinta2r { get; set; }
        public string Tinta3r { get; set; }
        public string Tinta4r { get; set; }
        public string Tinta5r { get; set; }
        public DateTime? FechaProgMaq { get; set; }
        public DateTime? FechaProgOrd { get; set; }
        public string Maq { get; set; }
        public string DobladoRollo { get; set; }
        public DateTime? FechaDesde { get; set; }
        public DateTime? FechaHasta { get; set; }
        public string EnPreliminares { get; set; }
        public short CtdTintasFte { get; set; }
    }
}
