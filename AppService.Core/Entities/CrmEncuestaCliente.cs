// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.CrmEncuestaCliente
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class CrmEncuestaCliente
  {
    public Decimal IdSatisfaccion { get; set; }

    public string IdCliente { get; set; }

    public string IdConsultor { get; set; }

    public short Ano { get; set; }

    public short Mes { get; set; }

    public short NetPromoterScore { get; set; }

    public short CustomerSatisfaction { get; set; }

    public short CustomerEffortScore { get; set; }

    public string Observaciones { get; set; }

    public string Usuario { get; set; }

    public DateTime Fecha { get; set; }
  }
}
