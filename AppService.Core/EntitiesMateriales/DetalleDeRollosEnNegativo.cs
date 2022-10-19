using System;

namespace AppService.Core.EntitiesMateriales
{
    public partial class DetalleDeRollosEnNegativo
    {
        public decimal? AloContable { get; set; }
        public decimal? MesContable { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string ES { get; set; }
        public decimal? Cantidad { get; set; }
        public string Transaccion { get; set; }
        public DateTime? FechaTransac { get; set; }
        public decimal? NroReporte { get; set; }
        public string Usuario { get; set; }
    }
}
