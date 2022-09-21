// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.AppGeneralQuotes
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
  public class AppGeneralQuotes
  {
    public AppGeneralQuotes() => this.AppDetailQuotes = (ICollection<AppService.Core.Entities.AppDetailQuotes>) new HashSet<AppService.Core.Entities.AppDetailQuotes>();

    public int Id { get; set; }

    public string IdVendedor { get; set; }

    public string IdCliente { get; set; }

    public DateTime Fecha { get; set; }

    public string Observaciones { get; set; }

    public int DiasVigencia { get; set; }

    public DateTime FechaCaducidad { get; set; }

    public DateTime? FechaPostergada { get; set; }

    public int IdEstatus { get; set; }

    public short IdCondPago { get; set; }

    public long IdContacto { get; set; }

    public string ObservacionPostergar { get; set; }

    public Decimal IdDireccionFacturar { get; set; }

    public Decimal IdDireccionEntregar { get; set; }

    public string OrdenCompra { get; set; }

    public string UsuarioActualiza { get; set; }

    public DateTime FechaActualiza { get; set; }

    public string UserCreate { get; set; }

    public string UserUpdate { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string Cotizacion { get; set; }

    public string SearchText { get; set; }

    public int? Proximo { get; set; }

    public long? IdMtrTipoMoneda { get; set; }

    public bool? FijarPrecioBs { get; set; }

    public string Rif { get; set; }

    public string RazonSocial { get; set; }

    public string Direccion { get; set; }

    public Decimal? IdMunicipio { get; set; }

    public string DescripcionMunicipio { get; set; }

    public bool? IntegrarCotizacion { get; set; }

    public long? Orden { get; set; }

    public long? OrdenAnterior { get; set; }

    public bool Actualizar { get; set; }

    public bool EnviarAlCliente { get; set; }

    public bool EnviarAprobacionPrecio { get; set; }

    public bool GanarPerder { get; set; }

    public bool Postergar { get; set; }

    public bool Eliminar { get; set; }

    public bool Cancel { get; set; }

    public bool ExistQuotes { get; set; }

    public bool Imprimir { get; set; }

    public bool RetornarAGrabacion { get; set; }

    public bool TieneOrden { get; set; }

    public virtual MtrCliente IdClienteNavigation { get; set; }

    public virtual MtrContactos IdContactoNavigation { get; set; }

    public virtual AppStatusQuote IdEstatusNavigation { get; set; }

    public virtual MtrTipoMoneda IdMtrTipoMonedaNavigation { get; set; }

    public virtual MtrVendedor IdVendedorNavigation { get; set; }

    public virtual ICollection<AppService.Core.Entities.AppDetailQuotes> AppDetailQuotes { get; set; }
  }
}
