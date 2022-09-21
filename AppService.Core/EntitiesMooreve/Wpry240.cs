using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wpry240
    {
        public Wpry240()
        {
            Wpry241 = new HashSet<Wpry241>();
        }

        public int Recnum { get; set; }
        public string Cotizacion { get; set; }
        public int Renglon { get; set; }
        public int Propuesta { get; set; }
        public int IdParte { get; set; }
        public string IdPapel { get; set; }
        public int IdConstruccion { get; set; }
        public decimal LargoCm { get; set; }
        public decimal AnchoCm { get; set; }
        public decimal Cantidad { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int? MedidaBase { get; set; }
        public int? MedidaOpuesta { get; set; }
        public string FrasesMarginales { get; set; }
        public bool FlagPlaneadaIcpp { get; set; }
        public long Orden { get; set; }
        public string TipoPapel { get; set; }
        public string Gramaje { get; set; }

        public virtual Wsmy501 CotizacionNavigation { get; set; }
        public virtual Wpry242 IdConstruccionNavigation { get; set; }
        public virtual ICollection<Wpry241> Wpry241 { get; set; }
    }
}
