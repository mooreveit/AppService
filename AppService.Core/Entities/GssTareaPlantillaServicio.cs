// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.GssTareaPlantillaServicio
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class GssTareaPlantillaServicio
  {
    public long IdTareaPlantillaServicio { get; set; }

    public long IdTarea { get; set; }

    public int IdPlantillaServicio { get; set; }

    public int IdVariable { get; set; }

    public string ValorEntrada { get; set; }

    public string ValorSalida { get; set; }

    public string MensajeBusqueda { get; set; }

    public short Secuencia { get; set; }

    public bool? Requerido { get; set; }

    public DateTime FechaCambio { get; set; }

    public int UsuarioCambio { get; set; }

    public virtual GssPlantillaServicio IdPlantillaServicioNavigation { get; set; }

    public virtual GssTarea IdTareaNavigation { get; set; }
  }
}
