// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.MtrEmpleado
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class MtrEmpleado
  {
    public string IdEmpleado { get; set; }

    public string NombreEmpleado { get; set; }

    public string TipoNomina { get; set; }

    public string Cedula { get; set; }

    public string Rif { get; set; }

    public string Direccion1 { get; set; }

    public string Direccion2 { get; set; }

    public string TelefonoHabitacion { get; set; }

    public string SexoEmpleado { get; set; }

    public DateTime? FechaNacimiento { get; set; }

    public DateTime? FechaIngreso { get; set; }

    public string IdDepartamento { get; set; }

    public string IdCargo { get; set; }

    public string Categoria1 { get; set; }

    public string Categoria2 { get; set; }

    public string Categoria3 { get; set; }

    public string IdSupervisor { get; set; }

    public string IdGrupo { get; set; }

    public string Email { get; set; }

    public DateTime? FechaRetiro { get; set; }

    public string TelefonoCelular { get; set; }

    public string Cuenta { get; set; }
  }
}
