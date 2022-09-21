// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.CrmVisitaSemana
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

namespace AppService.Core.Entities
{
  public class CrmVisitaSemana
  {
    public short IdSemana { get; set; }

    public string NombreSemana { get; set; }

    public string AbreviadoSemana { get; set; }

    public short IdFrecuencia { get; set; }

    public virtual CrmVisitaFrecuencia IdFrecuenciaNavigation { get; set; }
  }
}
