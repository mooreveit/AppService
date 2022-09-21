using System.Collections.Generic;

namespace AppService.Core.EntitiesFacturacion
{
    public partial class Winy243
    {
        public Winy243()
        {
            Winy245 = new HashSet<Winy245>();
        }

        public decimal Recnum { get; set; }
        public string CodigoEstado { get; set; }
        public string CodigoMcpo { get; set; }
        public string DescMunicipio { get; set; }
        public string CapitalMcpo { get; set; }
        public short ZonaDespacho { get; set; }
        public short PosicionRuta { get; set; }
        public string EdoMcpo { get; set; }
        public string CodigoJde { get; set; }
        public int? Kilometros { get; set; }
        public short IdOficinaFisica { get; set; }
        public short IdGrupoOficina { get; set; }
        public decimal? PorcFlete { get; set; }
        public string NombreEstado { get; set; }
        public decimal IdEstado { get; set; }
        public virtual Winy242 CodigoEstadoNavigation { get; set; }
        public virtual ICollection<Winy245> Winy245 { get; set; }
    }
}
