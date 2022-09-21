﻿// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.Cpry010
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class Cpry010
  {
    public Decimal Recnum { get; set; }

    public long JobId { get; set; }

    public long Orden { get; set; }

    public short Pais { get; set; }

    public string SupervVentas { get; set; }

    public string Vendedor { get; set; }

    public DateTime? FechaerPrelim { get; set; }

    public DateTime? FechasrPrelim { get; set; }

    public DateTime? FechaerDiseno { get; set; }

    public DateTime? FechasrDiseno { get; set; }

    public DateTime? FechaerNegativ { get; set; }

    public DateTime? FechasrNegativ { get; set; }

    public DateTime? FechaerPrensas { get; set; }

    public DateTime? FechasrPrensas { get; set; }

    public DateTime? FechaerColecto { get; set; }

    public DateTime? FechasrColecto { get; set; }

    public DateTime? FechaerBcs { get; set; }

    public DateTime? FechasrBcs { get; set; }

    public DateTime? FechaerAcabado { get; set; }

    public DateTime? FechasrAcabado { get; set; }

    public DateTime? FechaerEmbarqu { get; set; }

    public DateTime? FechasrEmbarqu { get; set; }

    public DateTime? FechaerFactura { get; set; }

    public DateTime? FechaOrdEntry { get; set; }

    public DateTime? FechasEstPrel { get; set; }

    public DateTime? FechaeEstDise { get; set; }

    public DateTime? FechasEstDise { get; set; }

    public DateTime? FechaeEstNega { get; set; }

    public DateTime? FechasEstNega { get; set; }

    public DateTime? FechaeEstPren { get; set; }

    public DateTime? FechasEstPren { get; set; }

    public DateTime? FechaeEstCole { get; set; }

    public DateTime? FechasEstCole { get; set; }

    public DateTime? FechaeEstBcs { get; set; }

    public DateTime? FechasEstBcs { get; set; }

    public DateTime? FechaeEstAcab { get; set; }

    public DateTime? FechasEstAcab { get; set; }

    public DateTime? FechaeEstEmba { get; set; }

    public DateTime? FechasEstEmba { get; set; }

    public DateTime? FechaeEstFact { get; set; }

    public DateTime? FechasEstFact { get; set; }

    public DateTime? FechaeEstEntr { get; set; }

    public DateTime? FechaRetenido { get; set; }

    public string FlagPlaneac { get; set; }

    public string FlagDiseno { get; set; }

    public string FlagFoto { get; set; }

    public string FlagPrensas { get; set; }

    public string FlagColectora { get; set; }

    public string FlagBcs { get; set; }

    public string FlagAcabado { get; set; }

    public string FlagEmbarque { get; set; }

    public long? CantPlan { get; set; }

    public long? CantArte { get; set; }

    public long? CantFoto { get; set; }

    public long? CantPrensa { get; set; }

    public long? CantColect { get; set; }

    public long? CantBcs { get; set; }

    public long? CantAcabado { get; set; }

    public long? CantEmbarque { get; set; }

    public long? CantFactura { get; set; }

    public short? DiasPlaneacion { get; set; }

    public short? DiasArte { get; set; }

    public short? DiasFoto { get; set; }

    public short? DiasPrensa { get; set; }

    public short? DiasColectora { get; set; }

    public short? DiasBcs { get; set; }

    public short? DiasAcabado { get; set; }

    public short? DiasEmbarque { get; set; }

    public long? CantProgramada { get; set; }

    public short NoPrensa { get; set; }

    public short NoColectora { get; set; }

    public short? CodBacklogRet { get; set; }

    public Decimal? PiesPrensa { get; set; }

    public Decimal? PiesColect { get; set; }

    public Decimal? Lista { get; set; }

    public Decimal? Venta { get; set; }

    public int? NumeroFactura { get; set; }

    public DateTime FechaFactura { get; set; }

    public string TipoProduccion { get; set; }

    public short? DiasRetPlanea { get; set; }

    public short? DiasRetArte { get; set; }

    public short? DiasRetFoto { get; set; }

    public short? DiasRetPrensa { get; set; }

    public short? DiasRetColect { get; set; }

    public short? DiasRetBcs { get; set; }

    public short? DiasRetAcabad { get; set; }

    public short? DiasRetEmbarq { get; set; }

    public string StatusDelJob { get; set; }

    public DateTime FechaEntrega { get; set; }

    public int? ReoperacionNo { get; set; }

    public short? ReopSolicPor { get; set; }

    public string ResponsaReoper { get; set; }

    public string OrigenReoperac { get; set; }

    public short? CausaReoperaci { get; set; }

    public short? ArregloReopera { get; set; }

    public string CodigoCaja { get; set; }

    public int? CantCajaUtili { get; set; }

    public int? FormPorCaja { get; set; }

    public string Remanente { get; set; }

    public int? CantidRemanent { get; set; }

    public string FlagEtiqImpre { get; set; }

    public long? FormInicial { get; set; }

    public short TipoOrden { get; set; }

    public int? NoAnulacion { get; set; }

    public short? PartesAReope { get; set; }

    public string Obser { get; set; }

    public string ProduInmediata { get; set; }

    public short LineaProduccio { get; set; }

    public short? TipoCaja { get; set; }

    public string JobAutomatico { get; set; }

    public string Observaciones { get; set; }

    public string FlagRetenido { get; set; }

    public string LugarProducir { get; set; }

    public int Cliente { get; set; }

    public long? CantAProducir { get; set; }

    public string Fiscal { get; set; }

    public string Cotizacion { get; set; }

    public string Elimina { get; set; }

    public DateTime? FecRealOrden { get; set; }

    public DateTime? NuevaFechaEnt { get; set; }

    public string FlagPlaneado { get; set; }

    public long? CtdEntregada { get; set; }

    public string Programada { get; set; }

    public DateTime? FechaArchivo { get; set; }

    public long? CtdFactAdelan { get; set; }

    public long? NuevaCtd { get; set; }

    public long? JobRestar { get; set; }

    public Decimal? PrecioLista { get; set; }

    public Decimal? PrecioVenta { get; set; }

    public string PasoSql { get; set; }

    public string FlagSoportev { get; set; }

    public Decimal? PiesPlanPren { get; set; }

    public Decimal? PiesPlanCole { get; set; }

    public Decimal? PiesArtePren { get; set; }

    public Decimal? PiesArteCole { get; set; }

    public Decimal? PiesFotoPren { get; set; }

    public Decimal? PiesFotoCole { get; set; }

    public Decimal? PiesPrensPren { get; set; }

    public Decimal? PiesPrensCole { get; set; }

    public string UsuarioRet { get; set; }

    public DateTime? FechaRet { get; set; }

    public Decimal? Rlista { get; set; }

    public Decimal? Rventa { get; set; }

    public Decimal? Rpreciolista { get; set; }

    public Decimal? Rprecioventa { get; set; }

    public string Combinacion { get; set; }
  }
}
