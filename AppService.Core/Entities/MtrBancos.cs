// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.MtrBancos
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class MtrBancos
  {
    public Decimal Recnum { get; set; }

    public string Codigo { get; set; }

    public string Nombre { get; set; }

    public string CodContable { get; set; }

    public string AplicaImp { get; set; }

    public string TraAsociada { get; set; }

    public string ProdGenerico { get; set; }

    public string TraJde { get; set; }

    public bool FlagActivo { get; set; }

    public bool FlagIngreso { get; set; }

    public bool FlagEgreso { get; set; }

    public int IdTipoCuentaDestino { get; set; }

    public virtual MtrTipoCuentaDestino IdTipoCuentaDestinoNavigation { get; set; }
  }
}
