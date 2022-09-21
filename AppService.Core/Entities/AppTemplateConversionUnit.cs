// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.AppTemplateConversionUnit
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class AppTemplateConversionUnit
  {
    public int Id { get; set; }

    public int AppUnitIdSince { get; set; }

    public int AppUnitIdUntil { get; set; }

    public int AppVariableId { get; set; }

    public string Description { get; set; }

    public Decimal? Value { get; set; }

    public string Formula { get; set; }

    public string FormulaValue { get; set; }

    public bool? SumValue { get; set; }

    public int? OrderCalculate { get; set; }

    public string Code { get; set; }

    public Decimal? Min { get; set; }

    public Decimal? Max { get; set; }

    public virtual AppUnits AppUnitIdSinceNavigation { get; set; }

    public virtual AppUnits AppUnitIdUntilNavigation { get; set; }

    public virtual AppVariables AppVariable { get; set; }
  }
}
