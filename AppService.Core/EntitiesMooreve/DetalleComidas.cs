using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class DetalleComidas
    {
        public long? Cantidad { get; set; }
        public long Ficha { get; set; }
        public string Empleado { get; set; }
        public DateTime Fecha { get; set; }
        public string CodigoDepartamento { get; set; }
        public string Departamento { get; set; }
        public string CuentaContable { get; set; }
        public int? Excepcion { get; set; }
    }
}
