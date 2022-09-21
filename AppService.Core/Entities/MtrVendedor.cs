// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.MtrVendedor
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public class MtrVendedor
    {
        public MtrVendedor()
        {
            this.AppGeneralQuotes = (ICollection<AppService.Core.Entities.AppGeneralQuotes>)new HashSet<AppService.Core.Entities.AppGeneralQuotes>();
            this.OfdCotizacion = (ICollection<AppService.Core.Entities.OfdCotizacion>)new HashSet<AppService.Core.Entities.OfdCotizacion>();
        }

        public Decimal Recnum { get; set; }

        public string Codigo { get; set; }

        public string Nombre { get; set; }

        public short ClaseVendedor { get; set; }

        public string Supervisor { get; set; }

        public short Grupo { get; set; }

        public Decimal ComisionImpres { get; set; }

        public Decimal ComisionStock { get; set; }

        public Decimal ComisionComprd { get; set; }

        public Decimal ComisionServ { get; set; }

        public string ComisionOrden { get; set; }

        public string ComisionFactur { get; set; }

        public string FlagCambio { get; set; }

        public string Categoria { get; set; }

        public short CodDivision { get; set; }

        public string Password { get; set; }

        public long Pedido { get; set; }

        public short OrdenRep { get; set; }

        public short Posicion { get; set; }

        public string NombAbreviado { get; set; }

        public short CodigoOverride { get; set; }

        public short ExtTelefonica { get; set; }

        public string TlfCelular { get; set; }

        public short NroDeClientes { get; set; }

        public string Activo { get; set; }

        public string CodigoGrupo { get; set; }

        public string FlagSupervisor { get; set; }

        public string FlagDeGerente { get; set; }

        public string Usuario { get; set; }

        public int CotCorrelativo { get; set; }

        public short Ordenado { get; set; }

        public short Pais { get; set; }

        public short Club300Asistid { get; set; }

        public short PuntosDelClub { get; set; }

        public string EMail { get; set; }

        public short CompanyBeeper { get; set; }

        public string UnidadBeeper { get; set; }

        public short Oficina { get; set; }

        public string CodigoRegion { get; set; }

        public string Ficha { get; set; }

        public string FlagRetirado { get; set; }

        public DateTime? FechaRetiro { get; set; }

        public string Garantia { get; set; }

        public Decimal Comision { get; set; }

        public Decimal Override { get; set; }

        public short NroVendedor { get; set; }

        public string FlagReplicar { get; set; }

        public short Consecutivo { get; set; }

        public string GerenteRegion { get; set; }

        public string Asignacion { get; set; }

        public string Cobrador { get; set; }

        public string FreeLance { get; set; }

        public string GerenteOficina { get; set; }

        public string FlagGerenteOf { get; set; }

        public DateTime? FechaIngreso { get; set; }

        public string FlagRevisar { get; set; }

        public string FlagCalculo { get; set; }

        public string FlagForaneo { get; set; }

        public short? OfiRefer { get; set; }

        public string FlagAdmin { get; set; }

        public string FlagIc { get; set; }

        public double? An8 { get; set; }

        public string TlfCelularold { get; set; }

        public string CotizadorPlus { get; set; }

        public string IdOficinaFisica { get; set; }

        public string ProduccionInterna { get; set; }

        public string GrupoVendedoresSap { get; set; }

        public string IdOficinaMixProduct { get; set; }
        public int IdUsuarioOdoo { get; set; }

        public virtual MtrOficina OficinaNavigation { get; set; }

        public virtual ICollection<AppService.Core.Entities.AppGeneralQuotes> AppGeneralQuotes { get; set; }

        public virtual ICollection<AppService.Core.Entities.OfdCotizacion> OfdCotizacion { get; set; }
    }
}
