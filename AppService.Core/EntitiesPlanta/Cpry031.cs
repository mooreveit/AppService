using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Cpry031
    {
        public decimal Recnum { get; set; }
        public string CodigoProducto { get; set; }
        public string TipoDeOrden { get; set; }
        public string Planeacion { get; set; }
        public string Arte { get; set; }
        public string Foto { get; set; }
        public string Prensas { get; set; }
        public string Colectoras { get; set; }
        public string Bcs { get; set; }
        public string Acabado { get; set; }
        public string Embarque { get; set; }
        public short? DiasPlaneacion { get; set; }
        public short? DiasArte { get; set; }
        public short? DiasFoto { get; set; }
        public short? DiasPrensas { get; set; }
        public short? DiasColectoras { get; set; }
        public short? DiasBcs { get; set; }
        public short? DiasAcabado { get; set; }
        public short? DiasEmbarque { get; set; }
        public short? CriticoPlaneac { get; set; }
        public short? CriticoArte { get; set; }
        public short? CriticoFoto { get; set; }
        public short? CriticoPrensas { get; set; }
        public short? CriticoColecto { get; set; }
        public short? CriticoBcs { get; set; }
        public short? CriticoAcabado { get; set; }
        public short? CriticoEmbarq { get; set; }
        public short Idtitulo { get; set; }
        public short Codigooficina { get; set; }
    }
}
