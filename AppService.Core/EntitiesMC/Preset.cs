using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMC
{
    public partial class Preset
    {
        public decimal Id { get; set; }
        public string CodProducto { get; set; }
        public string Orden { get; set; }
        public string Basica { get; set; }
        public string Opuesta { get; set; }
        public string Partes { get; set; }
        public string Papel { get; set; }
        public string Grupopapel { get; set; }
        public string Cantitintas { get; set; }
        public string Cambioscomposicion { get; set; }
        public string Cantfranjastransfertape { get; set; }
        public string Tienecarbonspot { get; set; }
        public string Talonextra { get; set; }
        public string Carbon { get; set; }
        public string Medidaopuestacarbon { get; set; }
        public string Nombreproducto { get; set; }
        public string Millares { get; set; }
        public string FormasUndFact { get; set; }
    }
}
