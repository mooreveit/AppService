// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.OfdCotizacion
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
  public class OfdCotizacion
  {
    public OfdCotizacion() => this.OfdRenglon = (ICollection<AppService.Core.Entities.OfdRenglon>) new HashSet<AppService.Core.Entities.OfdRenglon>();

    public long IdCotizacion { get; set; }

    public string Cotizacion { get; set; }

    public string IdVendedor { get; set; }

    public string IdCliente { get; set; }

    public string IdProspecto { get; set; }

    public DateTime Fecha { get; set; }

    public string ObsvCotizacion { get; set; }

    public short DiasVigencia { get; set; }

    public DateTime? FechaCaducidad { get; set; }

    public DateTime? FechaPostergada { get; set; }

    public int IdEstatus { get; set; }

    public short IdCondPago { get; set; }

    public long IdContacto { get; set; }

    public string ObservacionPostergar { get; set; }

    public string UsuarioActualiza { get; set; }

    public DateTime FechaActualiza { get; set; }

    public Decimal IdDireccionFacturar { get; set; }

    public Decimal IdDireccionEntregar { get; set; }

    public string OrdenCompra { get; set; }

    public short IdMedio { get; set; }

    public bool FlagValidado { get; set; }

    public virtual MtrContactos IdContactoNavigation { get; set; }

    public virtual MtrVendedor IdVendedorNavigation { get; set; }

    public virtual ICollection<AppService.Core.Entities.OfdRenglon> OfdRenglon { get; set; }
  }
}
