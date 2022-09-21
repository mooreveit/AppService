// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.CobPagosRetenciones
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class CobPagosRetenciones
  {
    public long Id { get; set; }

    public long IdCobranza { get; set; }

    public int IdTransaccion { get; set; }

    public Decimal Porcentaje { get; set; }

    public Decimal Monto { get; set; }

    public DateTime FechaCrea { get; set; }

    public bool FlagComprobanteNo { get; set; }

    public string NroComprobante { get; set; }

    public DateTime FechaComprobante { get; set; }

    public Decimal? Rmonto { get; set; }

    public string DocumentoSap { get; set; }

    public string EjercicioDocumentoSap { get; set; }

    public virtual CobGrabacionCobranzas IdCobranzaNavigation { get; set; }
  }
}
