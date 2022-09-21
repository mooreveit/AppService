// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.OfdAdjuntoCriterio
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class OfdAdjuntoCriterio
  {
    public long IdAdjuntoCriterio { get; set; }

    public long IdAdjunto { get; set; }

    public short IdCriterioBusqueda { get; set; }

    public string Valor { get; set; }

    public string IdUsuarioCreacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public virtual OfdAdjunto IdAdjuntoNavigation { get; set; }

    public virtual OfdCriterioBusqueda IdCriterioBusquedaNavigation { get; set; }
  }
}
