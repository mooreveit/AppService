using System.Collections.Generic;

namespace AppService.Core.DTOs.Especificaciones
{
    public class PartesGetDto
    {
        public string Cotizacion { get; set; }
        public int Renglon { get; set; }
        public int Propuesta { get; set; }
        public int IdParte { get; set; }
        public string IdPapel { get; set; }
        public string MedidaBasica { get; set; }
        public string MedidaOpuesta { get; set; }
        public string FrasesMarginales { get; set; }
        public string TipoPapel { get; set; }
        public string Gramaje { get; set; }
        public List<PapelesTipoGramaje> PapelesValidos { get; set; }
        public List<TintasGetDto> ListTintasGetDto { get; set; }



    }
}
