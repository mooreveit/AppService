// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.SegUsuario
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
  public class SegUsuario
  {
    public SegUsuario()
    {
      this.GssAprobacionServicio = (ICollection<AppService.Core.Entities.GssAprobacionServicio>) new HashSet<AppService.Core.Entities.GssAprobacionServicio>();
      this.GssUsuarioCompañia = (ICollection<AppService.Core.Entities.GssUsuarioCompañia>) new HashSet<AppService.Core.Entities.GssUsuarioCompañia>();
      this.SegUsuarioRol = (ICollection<AppService.Core.Entities.SegUsuarioRol>) new HashSet<AppService.Core.Entities.SegUsuarioRol>();
    }

    public int IdUsuario { get; set; }

    public string NombreUsuario { get; set; }

    public string Usuario { get; set; }

    public string Clave { get; set; }

    public bool Inactivo { get; set; }

    public DateTime? FechaCambio { get; set; }

    public int? ConteoExpira { get; set; }

    public int? ConteoBloquea { get; set; }

    public string Email { get; set; }

    public string Ficha { get; set; }

    public double? An8 { get; set; }

    public string ClasificacionUsuario { get; set; }

    public string Imei1 { get; set; }

    public string EquipoImei1 { get; set; }

    public string Imei2 { get; set; }

    public string EquipoImei2 { get; set; }

    public string Imei3 { get; set; }

    public string EquipoImei3 { get; set; }

    public string FlagDisenador { get; set; }

    public virtual ICollection<AppService.Core.Entities.GssAprobacionServicio> GssAprobacionServicio { get; set; }

    public virtual ICollection<AppService.Core.Entities.GssUsuarioCompañia> GssUsuarioCompañia { get; set; }

    public virtual ICollection<AppService.Core.Entities.SegUsuarioRol> SegUsuarioRol { get; set; }
  }
}
