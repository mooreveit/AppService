using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class VTransito
    {
        public short? AlmacenReceptor { get; set; }
        public short Bodega { get; set; }
        public short CodTransaccion { get; set; }
        public int Comprobante { get; set; }
        public string Producto { get; set; }
        public int? Cantidad { get; set; }
        public int? CantidadRecibida { get; set; }
        public int? Diferencia { get; set; }
        public string Actualizado { get; set; }
        public string Observaciones { get; set; }
        public string Ajustado { get; set; }
    }
}
