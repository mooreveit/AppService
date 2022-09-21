// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.PrcObjetosProcesos
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
  public class PrcObjetosProcesos
  {
    public PrcObjetosProcesos() => this.PrcUsuarioProcesos = (ICollection<AppService.Core.Entities.PrcUsuarioProcesos>) new HashSet<AppService.Core.Entities.PrcUsuarioProcesos>();

    public Decimal Id { get; set; }

    public string Servidor { get; set; }

    public string BaseDatos { get; set; }

    public string Objeto { get; set; }

    public string Descripcion { get; set; }

    public DateTime FechaRegistro { get; set; }

    public string UsuarioRegistro { get; set; }

    public Decimal ColaDeTrabajo { get; set; }

    public virtual ICollection<AppService.Core.Entities.PrcUsuarioProcesos> PrcUsuarioProcesos { get; set; }
  }
}
