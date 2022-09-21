using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class InventarioTablas
    {
        public string Base { get; set; }
        public string NombreTabla { get; set; }
        public string Campo { get; set; }
        public string Fk { get; set; }
        public double? Eliminar { get; set; }
        public double? Registros { get; set; }
        public bool? BuscaOrden { get; set; }
        public bool? ClaveNumeroTexto { get; set; }
        public int Id { get; set; }
        public int? Secuencia { get; set; }
    }
}
