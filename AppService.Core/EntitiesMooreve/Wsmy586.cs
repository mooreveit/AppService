using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy586
    {
        public decimal Id { get; set; }
        public decimal IdTipoDocumento { get; set; }
        public decimal ClienteLegacy { get; set; }
        public decimal ClienteJde { get; set; }
        public string NombreArchivo { get; set; }
        public byte[] ArchivoFisico { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioModifico { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
