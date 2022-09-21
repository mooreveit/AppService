// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.TPaTiposDeVariables
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
  public class TPaTiposDeVariables
  {
    public TPaTiposDeVariables() => this.TPaVariables = (ICollection<AppService.Core.Entities.TPaVariables>) new HashSet<AppService.Core.Entities.TPaVariables>();

    public Decimal Id { get; set; }

    public int IdTipoVariable { get; set; }

    public string Descripcion { get; set; }

    public string Calculo { get; set; }

    public string Entrada { get; set; }

    public string Constante { get; set; }

    public string Busqueda { get; set; }

    public string Acumulador { get; set; }

    public string AcumuladorGeneral { get; set; }

    public string UsuarioCreacion { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public string UsuarioModifico { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public virtual ICollection<AppService.Core.Entities.TPaVariables> TPaVariables { get; set; }
  }
}
