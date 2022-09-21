// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.MtrProductoPapeles
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class MtrProductoPapeles
  {
    public Decimal Id { get; set; }

    public string Producto { get; set; }

    public int Parte { get; set; }

    public string Papel { get; set; }

    public Decimal? Frecuencia { get; set; }

    public string Descripcion { get; set; }
  }
}
