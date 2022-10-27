using System.Collections.Generic;

namespace AppService.Core.DTOs.Especificaciones
{
    public class EspecificacionesGetDto
    {
        public short IdTipoOrden { get; set; }
        public List<PartesGetDto> ListPartesGetDto { get; set; }
        public List<TintasValidasGetDto> ListTintasValidasGetDto { get; set; }
        public List<AppVariablesEspecificacionesGeneralGetDto> AppVariablesEspecificacionesGeneralGetDto { get; set; }

    }
}
