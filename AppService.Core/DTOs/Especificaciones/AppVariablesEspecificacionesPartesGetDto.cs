namespace AppService.Core.DTOs.Especificaciones
{
    public class AppVariablesEspecificacionesPartesGetDto
    {

        public int Id { get; set; }
        public int CodAplicacion { get; set; }
        public string IdVariable { get; set; }
        public string NombreVariable { get; set; }
        public string FlagObligatorio { get; set; }
        public string FlagGralParte { get; set; }
        public int Orden { get; set; }
        public System.Collections.Generic.List<AppValoresVariablesEspecificacionesPartesGetDto> AppValoresVariablesEspecificacionesPartesGetDto { get; set; }

    }
}
