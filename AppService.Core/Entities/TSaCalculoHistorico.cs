// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.TSaCalculoHistorico
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class TSaCalculoHistorico
  {
    public Decimal Id { get; set; }

    public Decimal IdSolicitud { get; set; }

    public int LineaNegocio { get; set; }

    public string IdVariables { get; set; }

    public int Item { get; set; }

    public string Formula { get; set; }

    public Decimal? OrdenCalculo { get; set; }

    public Decimal? Valor { get; set; }

    public string DescripcionFormula { get; set; }

    public DateTime? FechaCalculo { get; set; }

    public string Orden { get; set; }

    public string Producto { get; set; }

    public string Qry { get; set; }

    public Decimal? TiempoEjecucion { get; set; }
  }
}
