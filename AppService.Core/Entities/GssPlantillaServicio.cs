// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.GssPlantillaServicio
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
  public class GssPlantillaServicio
  {
    public GssPlantillaServicio() => this.GssTareaPlantillaServicio = (ICollection<AppService.Core.Entities.GssTareaPlantillaServicio>) new HashSet<AppService.Core.Entities.GssTareaPlantillaServicio>();

    public int IdPlantillaServicio { get; set; }

    public int IdServicio { get; set; }

    public int IdVariable { get; set; }

    public string FuncionBusqueda { get; set; }

    public short Secuencia { get; set; }

    public bool Requerido { get; set; }

    public bool Activo { get; set; }

    public bool? OcultaDuplicado { get; set; }

    public DateTime FechaCambio { get; set; }

    public int UsuarioCambio { get; set; }

    public virtual GssServicios IdServicioNavigation { get; set; }

    public virtual GssVariable IdVariableNavigation { get; set; }

    public virtual ICollection<AppService.Core.Entities.GssTareaPlantillaServicio> GssTareaPlantillaServicio { get; set; }
  }
}
