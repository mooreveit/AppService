using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMC
{
    public partial class PlantillaPreset
    {
        public decimal Id { get; set; }
        public string CodProducto { get; set; }
        public string Ordenreferencia { get; set; }
        public string Orden { get; set; }
        public string Basica { get; set; }
        public string Opuesta { get; set; }
        public decimal? Partes { get; set; }
        public string Papel { get; set; }
        public string Grupopapel { get; set; }
        public decimal? Cantitintas { get; set; }
        public decimal? Cambioscomposicion { get; set; }
        public decimal? Cantfranjastransfertape { get; set; }
        public string Tienecarbonspot { get; set; }
        public string Talonextra { get; set; }
        public string Carbon { get; set; }
        public string Medidaopuestacarbon { get; set; }
        public string Nombreproducto { get; set; }
        public decimal? Millares { get; set; }
        public decimal? PrecioMaximoMillar { get; set; }
        public decimal? IdSolicitud { get; set; }
    }
}
