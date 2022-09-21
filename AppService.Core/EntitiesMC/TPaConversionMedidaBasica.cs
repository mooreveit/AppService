using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMC
{
    public partial class TPaConversionMedidaBasica
    {
        public int Id { get; set; }
        public decimal Medida { get; set; }
        public decimal? FactorConversion { get; set; }
        public string MedidaString { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioModifico { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
