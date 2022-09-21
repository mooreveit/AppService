// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.GssTipoDocumento
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
  public class GssTipoDocumento
  {
    public GssTipoDocumento() => this.GssAdjuntoTarea = (ICollection<AppService.Core.Entities.GssAdjuntoTarea>) new HashSet<AppService.Core.Entities.GssAdjuntoTarea>();

    public short IdTipoDocumento { get; set; }

    public string NombreDocumento { get; set; }

    public bool Inactivo { get; set; }

    public int IdUsuarioCreacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public int IdUsuarioModificacion { get; set; }

    public DateTime FechaModificacion { get; set; }

    public virtual ICollection<AppService.Core.Entities.GssAdjuntoTarea> GssAdjuntoTarea { get; set; }
  }
}
