using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy437
    {
        public Wsmy437()
        {
            Auxiliarcuota = new HashSet<Auxiliarcuota>();
            Wsmy670 = new HashSet<Wsmy670>();
            Wsmy670Log = new HashSet<Wsmy670Log>();
            Wsmy692 = new HashSet<Wsmy692>();
            Wsmy696 = new HashSet<Wsmy696>();
        }

        public int IdSubCategoria { get; set; }
        public string Descripcion { get; set; }
        public int? IdCategoria { get; set; }
        public int? IdProductoCuota { get; set; }
        public string ValidaMc { get; set; }
        public int? DiasCorreo { get; set; }
        public decimal? PorcCypj { get; set; }
        public decimal? PorcCypjminimo { get; set; }
        public string TipoMaterialSap { get; set; }
        public string GrupoArticulo { get; set; }
        public string Sector { get; set; }
        public string Imputacion { get; set; }
        public string TipoPosicion { get; set; }
        public string GrupoMaterial { get; set; }
        public string GrupoMaterial1 { get; set; }
        public string GrupoMaterial2 { get; set; }
        public string GrupoMaterial3 { get; set; }
        public string CentroDeBeneficio { get; set; }
        public string IndicadorAbc { get; set; }
        public string PlanificacionNecesidades { get; set; }
        public string CategoriaValoracion { get; set; }
        public string TipoValoracion { get; set; }
        public string IndicadorControldePrecios { get; set; }
        public decimal? PorcCypjgob { get; set; }
        public decimal? PorcCypjgobMinimo { get; set; }
        public int? IdTablaFlatComision { get; set; }
        public int? IdCuotaComision { get; set; }

        public virtual Wsmy436 IdCategoriaNavigation { get; set; }
        public virtual Wsmy438 IdProductoCuotaNavigation { get; set; }
        public virtual ICollection<Auxiliarcuota> Auxiliarcuota { get; set; }
        public virtual ICollection<Wsmy670> Wsmy670 { get; set; }
        public virtual ICollection<Wsmy670Log> Wsmy670Log { get; set; }
        public virtual ICollection<Wsmy692> Wsmy692 { get; set; }
        public virtual ICollection<Wsmy696> Wsmy696 { get; set; }
    }
}
