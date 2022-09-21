// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.DataInicial
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class DataInicial
  {
    public Decimal Id { get; set; }

    public string Data { get; set; }

    public string Archivo { get; set; }

    public Decimal? Lote { get; set; }

    public Decimal? OrdenArchivo { get; set; }
  }
}
