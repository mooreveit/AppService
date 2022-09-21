// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.CatSysfile
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

namespace AppService.Core.Entities
{
  public class CatSysfile
  {
    public int CatSysfileId { get; set; }

    public string FechaPublicacion { get; set; }

    public string FechaModificacionMateriales { get; set; }

    public bool? InactivarConsultaPrecios { get; set; }

    public int? IdPrograma { get; set; }
  }
}
