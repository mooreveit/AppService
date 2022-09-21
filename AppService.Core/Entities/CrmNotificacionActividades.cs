// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.CrmNotificacionActividades
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class CrmNotificacionActividades
  {
    public Decimal IdNotificacion { get; set; }

    public long IdSeguimiento { get; set; }

    public string Para { get; set; }

    public string Cc { get; set; }

    public string Cuerpo { get; set; }

    public DateTime FechaHoraEnvio { get; set; }
  }
}
