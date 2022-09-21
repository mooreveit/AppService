// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.CobGrabacionCobranzas
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
  public class CobGrabacionCobranzas
  {
    public CobGrabacionCobranzas() => this.CobPagosRetenciones = (ICollection<AppService.Core.Entities.CobPagosRetenciones>) new HashSet<AppService.Core.Entities.CobPagosRetenciones>();

    public long Id { get; set; }

    public long? Documento { get; set; }

    public string Transaccion { get; set; }

    public Decimal DocAfecta { get; set; }

    public Decimal? Monto { get; set; }

    public string Cotizacion { get; set; }

    public double Rpdoc { get; set; }

    public string Rpdct { get; set; }

    public string Rpkco { get; set; }

    public string Rpsfx { get; set; }

    public string DocAfectaSap { get; set; }

    public Decimal? Rmonto { get; set; }

    public string DocumentoSap { get; set; }

    public string EjercicioDocumentoSap { get; set; }

    public bool? PagoCorrespondeIva { get; set; }

    public bool PasoIntegridadInterfase { get; set; }

    public string ErrorMessage { get; set; }

    public string ObjectSend { get; set; }

    public bool? PagoDeMas { get; set; }

    public Decimal? TasaBancoCentral { get; set; }

    public Decimal? MontoBs { get; set; }

    public DateTime? FechaTasa { get; set; }

    public Decimal? RmontoBs { get; set; }

    public Decimal? RtasaBancoCentral { get; set; }

    public Decimal? MontoReconvertido { get; set; }

    public virtual CobGeneralCobranza DocumentoNavigation { get; set; }

    public virtual CobTransacciones TransaccionNavigation { get; set; }

    public virtual ICollection<AppService.Core.Entities.CobPagosRetenciones> CobPagosRetenciones { get; set; }
  }
}
