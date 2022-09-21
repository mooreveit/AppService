// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.TPaSysfile
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class TPaSysfile
  {
    public int Id { get; set; }

    public string DestinatarioFuncional { get; set; }

    public string CopiaFuncional { get; set; }

    public string SegundaCopiaFuncional { get; set; }

    public string DestinatarioTecnico { get; set; }

    public string CopiaTecnico { get; set; }

    public string UsuarioCreacion { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public string UsuarioModifico { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public Decimal? ConsecutivoOrdenPlantilla { get; set; }
  }
}
