using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class CneCredenciales
    {
        public int? IdOrg { get; set; }
        public int? Cedula { get; set; }
        public string Nac { get; set; }
        public string ApellNomb { get; set; }
        public int? Cargo { get; set; }
        public string DescripSort { get; set; }
        public int? Edo { get; set; }
        public string EstadosNombre { get; set; }
        public int? Mun { get; set; }
        public string NombreMun { get; set; }
        public int? Paq { get; set; }
        public string ParroquiasNombre { get; set; }
        public int? Centro { get; set; }
        public int? CentroNuevo { get; set; }
        public string Nombres { get; set; }
        public string Direccion { get; set; }
        public int? Mesa { get; set; }
        public int? CentrosCapa { get; set; }
        public short? Sorteo { get; set; }
        public int? Ruta { get; set; }
        public int? Ensamble { get; set; }
        public long RecNum { get; set; }
        public int? Caja { get; set; }
        public long? IndiceRegistro { get; set; }
        public string CedulaTexto { get; set; }
        public string FlagUltimoCaja { get; set; }
        public string IdentificadorHoja { get; set; }
        public string MensajeCentroCapa { get; set; }
    }
}
