// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.Marm
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class Marm
  {
    public string Mandt { get; set; }

    public string Matnr { get; set; }

    public string Meinh { get; set; }

    public Decimal Umrez { get; set; }

    public Decimal Umren { get; set; }

    public string Eannr { get; set; }

    public string Ean11 { get; set; }

    public string Numtp { get; set; }

    public Decimal Laeng { get; set; }

    public Decimal Breit { get; set; }

    public Decimal Hoehe { get; set; }

    public string Meabm { get; set; }

    public Decimal Volum { get; set; }

    public string Voleh { get; set; }

    public Decimal Brgew { get; set; }

    public string Gewei { get; set; }

    public string Mesub { get; set; }

    public string Atinn { get; set; }

    public string Mesrt { get; set; }

    public string Xfhdw { get; set; }

    public string Xbeww { get; set; }

    public string Kzwso { get; set; }

    public string Msehi { get; set; }

    public string BflmeMarm { get; set; }

    public string GtinVariant { get; set; }

    public Decimal NestFtr { get; set; }

    public byte MaxStack { get; set; }

    public Decimal Capause { get; set; }

    public string Ty2tq { get; set; }

    public virtual MtrProducto MatnrNavigation { get; set; }

    public virtual T006a MeinhNavigation { get; set; }
  }
}
