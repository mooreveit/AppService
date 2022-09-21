using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Activos
    {
        public string ActivosId { get; set; }
        public string Descripcion { get; set; }
        public string ClasifactivosId { get; set; }
        public string FechaCompra { get; set; }
        public string FechaComApi { get; set; }
        public string FechaDepreciacion { get; set; }
        public string FechaDepApi { get; set; }
        public string MetodoDepreciacion { get; set; }
        public string VidaUtil { get; set; }
        public string Costo { get; set; }
        public string Cantidad { get; set; }
        public string CostoUnitario { get; set; }
        public string ValorRescate { get; set; }
        public string CentroCostoId { get; set; }
        public string UbicacionId { get; set; }
        public string ProveedorId { get; set; }
        public string Observaciones { get; set; }
        public string ObrasId { get; set; }
    }
}
