using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class CobAvisosCobroTemp
    {
        public decimal Id { get; set; }
        public string Cliente { get; set; }
        public string Usuario { get; set; }
        public string NombreArchivo { get; set; }
        public byte[] Archivo { get; set; }
        public bool Procesado { get; set; }
        public byte[] ArchivotTiff { get; set; }
        public string Html { get; set; }
    }
}
