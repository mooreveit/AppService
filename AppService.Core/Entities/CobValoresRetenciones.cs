// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.CobValoresRetenciones
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class CobValoresRetenciones
  {
    public long IdTransaccion { get; set; }

    public string Valores { get; set; }

    public bool FlagRango { get; set; }

    public bool FlagValorFijo { get; set; }

    public bool FlagRetieneSobreImp { get; set; }

    public string UsuarioRegistro { get; set; }

    public DateTime FechaRegistro { get; set; }

    public string UsuarioModifica { get; set; }

    public DateTime? FechaModifica { get; set; }
  }
}
