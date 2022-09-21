// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.OfdRolTipoDocumento
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

namespace AppService.Core.Entities
{
  public class OfdRolTipoDocumento
  {
    public long IdRolTipoDocumento { get; set; }

    public int IdRol { get; set; }

    public short IdTipoDocumento { get; set; }

    public virtual SegRol IdRolNavigation { get; set; }

    public virtual OfdTipoDocumento IdTipoDocumentoNavigation { get; set; }
  }
}
