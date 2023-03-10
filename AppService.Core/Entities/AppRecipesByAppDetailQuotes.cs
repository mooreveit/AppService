// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.AppRecipesByAppDetailQuotes
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class AppRecipesByAppDetailQuotes
  {
    public int Id { get; set; }

    public int CalculoId { get; set; }

    public int? AppproductsId { get; set; }

    public int? AppVariableId { get; set; }

    public string Description { get; set; }

    public int? AppIngredientsId { get; set; }

    public Decimal? Quantity { get; set; }

    public Decimal? TotalCost { get; set; }

    public string Formula { get; set; }

    public string FormulaValue { get; set; }

    public bool? SumValue { get; set; }

    public Decimal? OrderCalculate { get; set; }

    public string Code { get; set; }

    public bool? IncludeInSearch { get; set; }

    public int? Secuencia { get; set; }

    public bool? AfectaCosto { get; set; }

    public string VariablesSearchText { get; set; }

    public bool? TruncarEntero { get; set; }

    public bool? EsVariableDeEntrada { get; set; }
     public bool? RetornarElMayor { get; set; }
        public bool? RetornarElMenor { get; set; }


    public virtual AppIngredients AppIngredients { get; set; }

    public virtual AppVariables AppVariable { get; set; }

    public virtual AppProducts Appproducts { get; set; }
  }
}
