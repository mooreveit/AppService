// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.CatAuditoriaCalculo
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class CatAuditoriaCalculo
  {
    public long CatAuditoriaCalculoId { get; set; }

    public string EntradaCalculo { get; set; }

    public Decimal IdCalculo { get; set; }

    public Decimal Item { get; set; }

    public string IdVariables { get; set; }

    public string NombreVariable { get; set; }

    public string Formula { get; set; }

    public string Valor { get; set; }

    public Decimal OrdenCalculo { get; set; }

    public string Query { get; set; }

    public string Codigo { get; set; }

    public string DescripcionFormula { get; set; }
  }
}
