// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.TPaPlantillaEntradas
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class TPaPlantillaEntradas
  {
    public Decimal Id { get; set; }

    public int LineaNegocio { get; set; }

    public string IdVariables { get; set; }

    public int Item { get; set; }

    public string DescripcionVariable { get; set; }

    public string Valor { get; set; }

    public string Observaciones { get; set; }

    public string FuncionDeBusqueda { get; set; }

    public string FuncionDeValidacion { get; set; }

    public virtual TPaVariables IdVariablesNavigation { get; set; }

    public virtual TPaModeloCalculo LineaNegocioNavigation { get; set; }
  }
}
