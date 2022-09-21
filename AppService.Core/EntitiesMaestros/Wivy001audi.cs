using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMaestros
{
    public partial class Wivy001audi
    {
        public decimal Recnum { get; set; }
        public short Compania { get; set; }
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Direccion1 { get; set; }
        public string Direccion2 { get; set; }
        public string Direccion3 { get; set; }
        public short CodigoPais { get; set; }
        public short CodigoCiudad { get; set; }
        public short CodigoEstado { get; set; }
        public string Origen { get; set; }
        public short Categoria { get; set; }
        public string Rif { get; set; }
        public string CodPostal { get; set; }
        public string Tlf { get; set; }
        public string Fax { get; set; }
        public string Persona { get; set; }
        public short FormaPago { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public DateTime? FechaUpdate { get; set; }
        public DateTime? UltimaCompra { get; set; }
        public string UltimoProducto { get; set; }
        public decimal UltimoBs { get; set; }
        public decimal UltimoDolares { get; set; }
        public string Observaciones { get; set; }
        public short Status { get; set; }
        public short Clasificacion { get; set; }
        public DateTime? FechaEva { get; set; }
        public string NombreCheque { get; set; }
        public decimal MontoAcumulado { get; set; }
        public decimal ImpAcumulado { get; set; }
        public string Especial { get; set; }
        public decimal PorcRet { get; set; }
        public string Email { get; set; }
        public short TipoImpueto { get; set; }
        public string PasoSql { get; set; }
        public short Tipopersona { get; set; }
        public double? CodigoJde { get; set; }
    }
}
