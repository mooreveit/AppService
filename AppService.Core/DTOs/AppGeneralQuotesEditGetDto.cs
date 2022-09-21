// Decompiled with JetBrains decompiler
// Type: AppService.Core.DTOs.AppGeneralQuotesEditGetDto
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.DTOs
{
  public class AppGeneralQuotesEditGetDto
  {
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

    public string NombreContacto { get; set; }

    public string EmailContacto { get; set; }

    public string ObservacionPostergar { get; set; }

    public Decimal IdDireccionFacturar { get; set; }

    public Decimal IdDireccionEntregar { get; set; }

    public long IdMtrTipoMoneda { get; set; }

    public string OrdenCompra { get; set; }

    public string UsuarioActualiza { get; set; }

    public DateTime FechaActualiza { get; set; }

    public string UserCreate { get; set; }

    public string UserUpdate { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string Cotizacion { get; set; }

    public bool FijarPrecioBs { get; set; }

    public string Rif { get; set; }

    public string RazonSocial { get; set; }

    public string Direccion { get; set; }

    public string FechaString { get; set; }

    public bool PermiteAdicionarDetalle { get; set; }

    public Decimal? PorcFlete { get; set; }

    public Decimal IdMunicipio { get; set; }

    public string descripcionMunicipio { get; set; }

    public bool IntegrarCotizacion { get; set; }

    public long Orden { get; set; }

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

    public AppStatusQuoteGetDto AppStatusQuoteGetDto { get; set; }

    public MtrClienteDto MtrClienteDto { get; set; }

    public MtrDireccionesDto MtrDireccionesFacturarDto { get; set; }

    public MtrDireccionesDto MtrDireccionesEntregarDto { get; set; }

    public MtrContactosDto MtrContactosDto { get; set; }

    public CondicionPagoDto CondicionPagoDto { get; set; }
  }
}
