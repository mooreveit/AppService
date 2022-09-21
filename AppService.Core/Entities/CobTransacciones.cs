// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.CobTransacciones
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
  public class CobTransacciones
  {
    public CobTransacciones() => this.CobGrabacionCobranzas = (ICollection<AppService.Core.Entities.CobGrabacionCobranzas>) new HashSet<AppService.Core.Entities.CobGrabacionCobranzas>();

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

    public Decimal BsHolgura { get; set; }

    public bool FlagRepiteImpuesto { get; set; }

    public virtual ICollection<AppService.Core.Entities.CobGrabacionCobranzas> CobGrabacionCobranzas { get; set; }
  }
}
