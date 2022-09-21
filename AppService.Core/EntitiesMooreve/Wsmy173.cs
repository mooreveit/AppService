using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy173
    {
        public int IdExcepcion { get; set; }
        public DateTime? VigenteDesde { get; set; }
        public DateTime? VigenteHasta { get; set; }
        public string FactorVendedor { get; set; }
        public decimal? ValorVendedor { get; set; }
        public string SignoVendedor { get; set; }
        public string FactorTeamLeader { get; set; }
        public decimal? ValorTeamLeader { get; set; }
        public string SignoTeamLeader { get; set; }
        public string FactorGteOficina { get; set; }
        public decimal? ValorGteOficina { get; set; }
        public string SignoGteOficina { get; set; }
        public string FactorGteRegion { get; set; }
        public decimal? ValorGteRegion { get; set; }
        public string SignoGteRegion { get; set; }
        public string FactorGteOp { get; set; }
        public decimal? ValorGteOp { get; set; }
        public string SignoGteOp { get; set; }
        public string FactorGteIc { get; set; }
        public decimal? ValorGteIc { get; set; }
        public string SignoGteIc { get; set; }
        public string FactorCic { get; set; }
        public decimal? ValorCic { get; set; }
        public string SignoCic { get; set; }
        public string UsuarioRed { get; set; }
        public string NombreMaquina { get; set; }
        public string UsuarioSistema { get; set; }
        public string Observaciones { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public int? IdExcepcionRemplaza { get; set; }
        public string FlagIncluye { get; set; }
        public string FlagEliminada { get; set; }
        public string FactorCoordinadorJobbing { get; set; }
        public decimal? ValorCoordinadorJobbing { get; set; }
        public string SignoCoordinadorJobbing { get; set; }
    }
}
