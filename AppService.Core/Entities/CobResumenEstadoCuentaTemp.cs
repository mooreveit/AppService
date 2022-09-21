// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.CobResumenEstadoCuentaTemp
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class CobResumenEstadoCuentaTemp
  {
    public Decimal Id { get; set; }

    public string Cliente { get; set; }

    public string NombreCliente { get; set; }

    public int? Oficina { get; set; }

    public string NombreOficina { get; set; }

    public string Consultor { get; set; }

    public string NombreConsultor { get; set; }

    public Decimal Saldo { get; set; }

    public int? CodigoRango { get; set; }

    public string DescripcionRango { get; set; }
  }
}
