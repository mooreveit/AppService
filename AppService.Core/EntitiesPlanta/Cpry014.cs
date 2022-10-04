using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Cpry014
    {
        public decimal Recnum { get; set; }
        public long Orden { get; set; }
        public DateTime FechaArchivo { get; set; }
        public DateTime? FechaCalculo { get; set; }
        public DateTime? FechaTrans { get; set; }
        public DateTime? FechaDocket { get; set; }
        public DateTime? FechaPlaneacio { get; set; }
        public DateTime? FechaPrelimin { get; set; }
        public short DiasCalculo { get; set; }
        public short DiasTrans { get; set; }
        public short DiasDocket { get; set; }
        public short DiasPlaneacion { get; set; }
        public short DiasArchivo { get; set; }
        public string UsuarioArchivo { get; set; }
        public string UsuarioCalculo { get; set; }
        public string UsuarioTranscr { get; set; }
        public string UsuarioDocket { get; set; }
        public string UsuarioPlaneac { get; set; }
        public string Anulada { get; set; }
        public string CicloCompleto { get; set; }
        public short TotalDias { get; set; }
        public DateTime? FecharPrelim { get; set; }
        public string UsuariorPrelim { get; set; }
        public short? ImprDocket { get; set; }
    }
}
