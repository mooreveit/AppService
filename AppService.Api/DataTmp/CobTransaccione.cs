using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class CobTransaccione
    {
        public CobTransaccione()
        {
            CobGrabacionCobranzas = new HashSet<CobGrabacionCobranza>();
        }

        public int IdTransacccionCobranzas { get; set; }
        public string Transaccion { get; set; }
        public string NombreTransaccion { get; set; }
        public bool Efectivo { get; set; }
        public bool DocumentoMadre { get; set; }
        public bool Impuesto { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public bool Inactivo { get; set; }
        public string CuentaContable { get; set; }
        public string TransLegacy { get; set; }
        public bool Anticipo { get; set; }
        public string TipoSap { get; set; }
        public string CuentaSap { get; set; }
        public short DigitosValidar { get; set; }
        public decimal BsHolgura { get; set; }
        public bool FlagRepiteImpuesto { get; set; }

        public virtual ICollection<CobGrabacionCobranza> CobGrabacionCobranzas { get; set; }
    }
}
