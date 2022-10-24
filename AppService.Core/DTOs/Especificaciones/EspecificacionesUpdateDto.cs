using System.Collections.Generic;

namespace AppService.Core.DTOs.Especificaciones
{
    public class EspecificacionesUpdateDto
    {

        public PartesFilter PartesFilter { get; set; }
        public List<PartesGetDto> partesGetDto { get; set; }
        public List<AppVariablesEspecificacionesGeneralGetDto> appVariablesEspecificacionesGeneralGetDto { get; set; }
    }
}
