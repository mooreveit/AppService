// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.MtrClienteProspecto
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class MtrClienteProspecto
  {
    public string IdCliente { get; set; }

    public string NombreCliente { get; set; }

    public string Direccion { get; set; }

    public string Rif { get; set; }

    public string IdVendedor { get; set; }

    public DateTime FechaCreacion { get; set; }
  }
}
