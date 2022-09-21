// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.CrmVisitaFrecuencia
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System.Collections.Generic;

namespace AppService.Core.Entities
{
  public class CrmVisitaFrecuencia
  {
    public CrmVisitaFrecuencia() => this.CrmVisitaSemana = (ICollection<AppService.Core.Entities.CrmVisitaSemana>) new HashSet<AppService.Core.Entities.CrmVisitaSemana>();

    public short IdFrecuencia { get; set; }

    public string NombreFrecuencia { get; set; }

    public virtual ICollection<AppService.Core.Entities.CrmVisitaSemana> CrmVisitaSemana { get; set; }
  }
}
