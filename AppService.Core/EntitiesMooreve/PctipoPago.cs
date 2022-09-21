using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class PctipoPago
    {
        public PctipoPago()
        {
            PccomisionesTemporal = new HashSet<PccomisionesTemporal>();
            Pchistorico = new HashSet<Pchistorico>();
            Pctemporal = new HashSet<Pctemporal>();
        }

        public int Id { get; set; }
        public string TipoPago { get; set; }
        public string Descripcion { get; set; }
        public bool FlagCalcular { get; set; }
        public bool? AplicaGerente { get; set; }
        public string ConceptoNominaPago { get; set; }
        public string ConceptoNominaDescuento { get; set; }

        public virtual ICollection<PccomisionesTemporal> PccomisionesTemporal { get; set; }
        public virtual ICollection<Pchistorico> Pchistorico { get; set; }
        public virtual ICollection<Pctemporal> Pctemporal { get; set; }
    }
}
