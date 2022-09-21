using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy555
    {
        public long Id { get; set; }
        public string Compañia { get; set; }
        public string TipoLibro { get; set; }
        public int Año { get; set; }
        public int Mes { get; set; }
        public byte Forecast { get; set; }
        public string CuentaHfm { get; set; }
        public string Responsable { get; set; }
        public string Archivo { get; set; }
        public DateTime? FechaAdjunto { get; set; }
        public string RutaServidor { get; set; }
        public string RutaArchivo { get; set; }
    }
}
