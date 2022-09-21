// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.CobTipoTransaccionRespaldoAntesEliminarColettilla
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

namespace AppService.Core.Entities
{
  public class CobTipoTransaccionRespaldoAntesEliminarColettilla
  {
    public string IdTipoTransaccion { get; set; }

    public string NombreTipoTransaccion { get; set; }

    public bool FlagActivaVerificacion { get; set; }

    public bool FlagImpuesto { get; set; }

    public bool FlagCotizador { get; set; }

    public string IdTipoPagoSap { get; set; }

    public string ColetillaIva { get; set; }
  }
}
