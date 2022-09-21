// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.GssAdjuntoTarea
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class GssAdjuntoTarea
  {
    public long IdAdjuntoTarea { get; set; }

    public long IdTarea { get; set; }

    public short IdTipoDocumento { get; set; }

    public string NombreArchivo { get; set; }

    public byte[] Archivo { get; set; }

    public int UsuarioCreacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public virtual GssTarea IdTareaNavigation { get; set; }

    public virtual GssTipoDocumento IdTipoDocumentoNavigation { get; set; }
  }
}
