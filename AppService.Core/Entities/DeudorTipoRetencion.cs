// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.DeudorTipoRetencion
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class DeudorTipoRetencion
  {
    public Decimal Id { get; set; }

    public string Cliente { get; set; }

    public string Nombre { get; set; }

    public string TipoRetencion { get; set; }

    public string IndicadorRetencion { get; set; }
  }
}
