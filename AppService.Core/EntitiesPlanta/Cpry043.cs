using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Cpry043
    {
        public decimal Recnum { get; set; }
        public short CodigoMaquina { get; set; }
        public short TipoDeMaquina { get; set; }
        public string Descripcion { get; set; }
        public int Capacidad { get; set; }
        public string ImprimeColecta { get; set; }
        public string Abreviado { get; set; }
        public short Turnos { get; set; }
        public decimal HorasTrabajo { get; set; }
        public int AnchoRodillo1 { get; set; }
        public int AnchoRodillo2 { get; set; }
        public decimal HorasXOrden { get; set; }
        public string UsaContador { get; set; }
        public decimal PorcIndirectos { get; set; }
        public string TituloReporte { get; set; }
        public long ObjVelocidad { get; set; }
        public decimal PorcDirectos { get; set; }
        public decimal PorcRodada { get; set; }
        public decimal PorcPrep { get; set; }
        public string TituloGrupo { get; set; }
        public decimal HorasxordenCon { get; set; }
        public decimal PorcIndCon { get; set; }
        public long ObjVelCon { get; set; }
        public decimal PorcDirCon { get; set; }
        public decimal PorcRodCon { get; set; }
        public decimal PorcPreCon { get; set; }
        public long VelocidadNom { get; set; }
        public string FlagDoblaPren { get; set; }
        public short? DiasHistoricos { get; set; }
        public decimal? Eficiencia { get; set; }
        public decimal? Bshora { get; set; }
        public string FlagManualauto { get; set; }
        public string Periodo { get; set; }
        public string Pplana { get; set; }
        public short? Diasdisp { get; set; }
        public decimal? Rbshora { get; set; }
    }
}
