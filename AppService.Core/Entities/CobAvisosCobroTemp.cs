// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.CobAvisosCobroTemp
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class CobAvisosCobroTemp
  {
    public Decimal Id { get; set; }

    public string Cliente { get; set; }

    public string Usuario { get; set; }

    public string NombreArchivo { get; set; }

    public byte[] Archivo { get; set; }

    public bool Procesado { get; set; }

    public byte[] ArchivotTiff { get; set; }

    public string Html { get; set; }
  }
}
