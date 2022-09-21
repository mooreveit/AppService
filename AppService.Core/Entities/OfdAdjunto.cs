// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.OfdAdjunto
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
  public class OfdAdjunto
  {
    public OfdAdjunto() => this.OfdAdjuntoCriterio = (ICollection<AppService.Core.Entities.OfdAdjuntoCriterio>) new HashSet<AppService.Core.Entities.OfdAdjuntoCriterio>();

    public long IdAdjunto { get; set; }

    public short IdTipoDocumento { get; set; }

    public string NombreArchivo { get; set; }

    public byte[] Archivo { get; set; }

    public string IdUsuarioCreacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public long? IdAdjuntoCotizadorPluss { get; set; }

    public virtual ICollection<AppService.Core.Entities.OfdAdjuntoCriterio> OfdAdjuntoCriterio { get; set; }
  }
}
