// Decompiled with JetBrains decompiler
// Type: AppService.Core.Map.MapAppGeneralQuote
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using AppService.Core.DTOs;
using AppService.Core.Entities;
using System;

namespace AppService.Core.Map
{
  public static class MapAppGeneralQuote
  {
    public static AppGeneralQuotesEditGetDto MapAppAppGeneralQuoteToAppGeneralQuotesEditGetDto(
      AppGeneralQuotes origen)
    {
      return new AppGeneralQuotesEditGetDto()
      {
        Id = origen.Id,
        IdVendedor = origen.IdVendedor,
        IdCliente = origen.IdCliente,
        Fecha = origen.Fecha,
        Observaciones = origen.Observaciones,
        DiasVigencia = origen.DiasVigencia,
        FechaCaducidad = origen.FechaCaducidad,
        FechaPostergada = origen.FechaPostergada,
        IdEstatus = origen.IdEstatus,
        IdCondPago = origen.IdCondPago,
        IdContacto = origen.IdContacto,
        NombreContacto = origen.IdContactoNavigation.Nombre,
        EmailContacto = origen.IdContactoNavigation.Email,
        ObservacionPostergar = origen.ObservacionPostergar,
        IdDireccionFacturar = origen.IdDireccionFacturar,
        IdDireccionEntregar = origen.IdDireccionEntregar,
        IdMtrTipoMoneda = origen.IdMtrTipoMoneda.Value,
        OrdenCompra = origen.OrdenCompra,
        UsuarioActualiza = origen.UsuarioActualiza,
        FechaActualiza = origen.FechaActualiza,
        UserCreate = origen.UserCreate,
        UserUpdate = origen.UserUpdate,
        CreatedAt = origen.CreatedAt,
        UpdatedAt = new DateTime?(origen.CreatedAt),
        Cotizacion = origen.Cotizacion,
        Rif = origen.Rif,
        RazonSocial = origen.RazonSocial,
        Direccion = origen.Direccion,
        FechaString = origen.Fecha.ToString("dd/MM/yyyy"),
        IdMunicipio = origen.IdMunicipio.Value,
        IntegrarCotizacion = origen.IntegrarCotizacion.Value,
        Orden = origen.Orden.Value,
        Actualizar = origen.Actualizar,
        EnviarAlCliente = origen.EnviarAlCliente,
        EnviarAprobacionPrecio = origen.EnviarAprobacionPrecio,
        GanarPerder = origen.GanarPerder,
        Postergar = origen.Postergar,
        Eliminar = origen.Eliminar,
        Cancel = origen.Cancel,
        ExistQuotes = origen.ExistQuotes,
        Imprimir = origen.Imprimir,
        RetornarAGrabacion = origen.RetornarAGrabacion
      };
    }
  }
}
