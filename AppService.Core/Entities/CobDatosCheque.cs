// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.CobDatosCheque
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class CobDatosCheque
  {
    public long Documento { get; set; }

    public string IdBanco { get; set; }

    public string IdTipoTransaccion { get; set; }

    public Decimal MontoCheque { get; set; }

    public long NumCheque { get; set; }

    public DateTime FechaCheque { get; set; }

    public Decimal? RmontoCheque { get; set; }

    public virtual CobGeneralCobranza DocumentoNavigation { get; set; }
  }
}
