// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.GssUsuarioPlantillaServicio
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

namespace AppService.Core.Entities
{
  public class GssUsuarioPlantillaServicio
  {
    public int IdUsuarioPlantillaServicio { get; set; }

    public int IdUsuario { get; set; }

    public int IdServicio { get; set; }

    public int IdVariable { get; set; }

    public virtual GssServicios IdServicioNavigation { get; set; }

    public virtual GssVariable IdVariableNavigation { get; set; }
  }
}
