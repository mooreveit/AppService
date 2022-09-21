// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.CobExcepcion
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class CobExcepcion
  {
    public int IdExcepcion { get; set; }

    public long Documento { get; set; }

    public DateTime FechaLm { get; set; }

    public string Motivo { get; set; }

    public DateTime FechaRegistro { get; set; }

    public string UsuarioRegistro { get; set; }

    public virtual CobGeneralCobranza DocumentoNavigation { get; set; }
  }
}
