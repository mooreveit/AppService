// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.CreResponsableAprobarExcepcion
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class CreResponsableAprobarExcepcion
  {
    public Decimal Id { get; set; }

    public string Usuario { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public string UsuarioCreacion { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public DateTime? UsuarioModificacion { get; set; }
  }
}
