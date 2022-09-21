using System;
using AppService.Core.DataContratosStock;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AppService.Infrastructure.DataContratosStock
{
    public partial class ContratosStockContext : DbContext
    {
        public ContratosStockContext()
        {
        }

        public ContratosStockContext(DbContextOptions<ContratosStockContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Anulaciones> Anulaciones { get; set; }
        public virtual DbSet<AprobacionCredito> AprobacionCredito { get; set; }
        public virtual DbSet<AprobacionMcyCredito> AprobacionMcyCredito { get; set; }
        public virtual DbSet<Civy023UltimosPrecios> Civy023UltimosPrecios { get; set; }
        public virtual DbSet<CobranzasCcsAprobacionCredito> CobranzasCcsAprobacionCredito { get; set; }
        public virtual DbSet<ConsultaCivy023FechaUlt> ConsultaCivy023FechaUlt { get; set; }
        public virtual DbSet<ConsultaCob> ConsultaCob { get; set; }
        public virtual DbSet<ConsultaEtiquetas> ConsultaEtiquetas { get; set; }
        public virtual DbSet<ConsultaFrontLog> ConsultaFrontLog { get; set; }
        public virtual DbSet<ConsultaOrdImpcomercial> ConsultaOrdImpcomercial { get; set; }
        public virtual DbSet<ConsultaOrdenesEtiqPrecioVolumen> ConsultaOrdenesEtiqPrecioVolumen { get; set; }
        public virtual DbSet<Consultaajdunto> Consultaajdunto { get; set; }
        public virtual DbSet<Consultacliente> Consultacliente { get; set; }
        public virtual DbSet<Consultaproducto> Consultaproducto { get; set; }
        public virtual DbSet<ConsultasPuertoOrdas> ConsultasPuertoOrdas { get; set; }
        public virtual DbSet<ContadorOrdenesMesCurso> ContadorOrdenesMesCurso { get; set; }
        public virtual DbSet<Correlativos> Correlativos { get; set; }
        public virtual DbSet<DatosAdjuntos> DatosAdjuntos { get; set; }
        public virtual DbSet<DatosCliente> DatosCliente { get; set; }
        public virtual DbSet<DatosClienteLog> DatosClienteLog { get; set; }
        public virtual DbSet<DatosProductos> DatosProductos { get; set; }
        public virtual DbSet<DatosProductos2> DatosProductos2 { get; set; }
        public virtual DbSet<EmailAdministradora> EmailAdministradora { get; set; }
        public virtual DbSet<EmailSupervisor> EmailSupervisor { get; set; }
        public virtual DbSet<EmailVendedores> EmailVendedores { get; set; }
        public virtual DbSet<Escaneado> Escaneado { get; set; }
        public virtual DbSet<EstadisticasAprobacionCobranzas> EstadisticasAprobacionCobranzas { get; set; }
        public virtual DbSet<EstadisticasCeos> EstadisticasCeos { get; set; }
        public virtual DbSet<EstatusOrdenes> EstatusOrdenes { get; set; }
        public virtual DbSet<ItemCotizacion> ItemCotizacion { get; set; }
        public virtual DbSet<MaestraVendedores> MaestraVendedores { get; set; }
        public virtual DbSet<MontoOrdenes> MontoOrdenes { get; set; }
        public virtual DbSet<OrdenesAdministradoras> OrdenesAdministradoras { get; set; }
        public virtual DbSet<OrdenesBarquisimeto> OrdenesBarquisimeto { get; set; }
        public virtual DbSet<OrdenesCaracas> OrdenesCaracas { get; set; }
        public virtual DbSet<OrdenesCobranzas> OrdenesCobranzas { get; set; }
        public virtual DbSet<OrdenesEnElDia> OrdenesEnElDia { get; set; }
        public virtual DbSet<OrdenesEtiquetas> OrdenesEtiquetas { get; set; }
        public virtual DbSet<OrdenesMaracay> OrdenesMaracay { get; set; }
        public virtual DbSet<OrdenesPlanta> OrdenesPlanta { get; set; }
        public virtual DbSet<OrdenesProcesadas> OrdenesProcesadas { get; set; }
        public virtual DbSet<OrdenesRechazadas> OrdenesRechazadas { get; set; }
        public virtual DbSet<OrdenesRechazadasAdmin> OrdenesRechazadasAdmin { get; set; }
        public virtual DbSet<OrdenesRechazadasSup> OrdenesRechazadasSup { get; set; }
        public virtual DbSet<OrdenesStockMesEnCurso> OrdenesStockMesEnCurso { get; set; }
        public virtual DbSet<OrdenesValencia> OrdenesValencia { get; set; }
        public virtual DbSet<OrdenesVentas> OrdenesVentas { get; set; }
        public virtual DbSet<Pqc01> Pqc01 { get; set; }
        public virtual DbSet<PtoOrdaz> PtoOrdaz { get; set; }
        public virtual DbSet<PuertoLaCruz> PuertoLaCruz { get; set; }
        public virtual DbSet<QueryDatosClienteAc01> QueryDatosClienteAc01 { get; set; }
        public virtual DbSet<QueryDatosClienteAc02> QueryDatosClienteAc02 { get; set; }
        public virtual DbSet<QueryEstadistAac01> QueryEstadistAac01 { get; set; }
        public virtual DbSet<QueryEstadistAac02> QueryEstadistAac02 { get; set; }
        public virtual DbSet<QueryEstadistAac03> QueryEstadistAac03 { get; set; }
        public virtual DbSet<QueryEstatusOrd01> QueryEstatusOrd01 { get; set; }
        public virtual DbSet<ReactivarCeos> ReactivarCeos { get; set; }
        public virtual DbSet<Rechazos> Rechazos { get; set; }
        public virtual DbSet<RechazosA> RechazosA { get; set; }
        public virtual DbSet<RechazosCeos> RechazosCeos { get; set; }
        public virtual DbSet<RevisionArchivosAdjuntos> RevisionArchivosAdjuntos { get; set; }
        public virtual DbSet<StatusOrdenesStock> StatusOrdenesStock { get; set; }
        public virtual DbSet<TotalGeneralOrden01> TotalGeneralOrden01 { get; set; }
        public virtual DbSet<TotalXOrden> TotalXOrden { get; set; }
        public virtual DbSet<TotalXOrden2> TotalXOrden2 { get; set; }
        public virtual DbSet<VDiccionariocontratosstock> VDiccionariocontratosstock { get; set; }
        public virtual DbSet<VInvetarioReconversion> VInvetarioReconversion { get; set; }
        public virtual DbSet<View1> View1 { get; set; }

       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Anulaciones>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Orden)
                    .HasName("dep_Anulacionesorden");

                entity.Property(e => e.Estatus)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaHora)
                    .HasColumnName("Fecha_Hora")
                    .HasColumnType("datetime");

                entity.Property(e => e.NumCot)
                    .HasColumnName("Num_Cot")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Orden)
                    .HasColumnName("ORDEN")
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("(0)")
                    .HasComment("NUMERO DE LA ORDEN");

                entity.Property(e => e.OrigenAnulacion)
                    .HasColumnName("ORIGEN_ANULACION")
                    .HasDefaultValueSql("(0)")
                    .HasComment("ORIEGEN DE LA ANULACION");

                entity.Property(e => e.TipoAnulacion)
                    .HasColumnName("TIPO_ANULACION")
                    .HasDefaultValueSql("(0)")
                    .HasComment("TIPO DE ANULACION");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<AprobacionCredito>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Aprobacion Credito");

                entity.Property(e => e.CodOfic)
                    .HasColumnName("Cod_Ofic")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Monto).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Rmonto)
                    .HasColumnName("RMonto")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.UnidadesTrib)
                    .HasColumnName("Unidades_Trib")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<AprobacionMcyCredito>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Aprobacion Mcy Credito");

                entity.Property(e => e.ClienteNuevo)
                    .HasColumnName("Cliente_Nuevo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodVend)
                    .HasColumnName("Cod_vend")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoClient)
                    .HasColumnName("Codigo_Client")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FecGrab)
                    .HasColumnName("Fec_Grab")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.NomCliente)
                    .HasColumnName("Nom_Cliente")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumCot)
                    .HasColumnName("Num_Cot")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Oficina)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VentaTot).HasColumnName("Venta_Tot");
            });

            modelBuilder.Entity<Civy023UltimosPrecios>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CIVY023 ULTIMOS PRECIOS");

                entity.Property(e => e.Cant)
                    .HasColumnName("CANT")
                    .HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Cant1)
                    .HasColumnName("CANT1")
                    .HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Cant2)
                    .HasColumnName("CANT2")
                    .HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Cant3)
                    .HasColumnName("CANT3")
                    .HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Cant4)
                    .HasColumnName("CANT4")
                    .HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Cant5)
                    .HasColumnName("CANT5")
                    .HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Codigo)
                    .HasColumnName("CODIGO")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaVigencia)
                    .HasColumnName("FECHA_VIGENCIA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.PrecLista)
                    .HasColumnName("PREC_LISTA")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PrecLista1)
                    .HasColumnName("PREC_LISTA_$")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.PrecLista11)
                    .HasColumnName("PREC_LISTA1")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PrecLista1d)
                    .HasColumnName("PREC_LISTA1D")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PrecLista2)
                    .HasColumnName("PREC_LISTA2")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PrecLista2d)
                    .HasColumnName("PREC_LISTA2D")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PrecLista3)
                    .HasColumnName("PREC_LISTA3")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PrecLista3d)
                    .HasColumnName("PREC_LISTA3D")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PrecLista4)
                    .HasColumnName("PREC_LISTA4")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PrecLista4d)
                    .HasColumnName("PREC_LISTA4D")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PrecLista5)
                    .HasColumnName("PREC_LISTA5")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PrecLista5d)
                    .HasColumnName("PREC_LISTA5D")
                    .HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<CobranzasCcsAprobacionCredito>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Cobranzas CCS Aprobacion Credito");

                entity.Property(e => e.ClienteNuevo)
                    .HasColumnName("Cliente_Nuevo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodVend)
                    .HasColumnName("Cod_vend")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoClient)
                    .HasColumnName("Codigo_Client")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FecGrab)
                    .HasColumnName("Fec_Grab")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.NomCliente)
                    .HasColumnName("Nom_Cliente")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumCot)
                    .HasColumnName("Num_Cot")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Oficina)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VentaTot).HasColumnName("Venta_Tot");
            });

            modelBuilder.Entity<ConsultaCivy023FechaUlt>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Consulta CIVY023 FECHA ULT");

                entity.Property(e => e.Codigo)
                    .HasColumnName("CODIGO")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EchaVigencia)
                    .HasColumnName("ECHA_VIGENCIA")
                    .HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<ConsultaCob>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CONSULTA_COB", "VEMCYSIDG");

                entity.Property(e => e.AprobCob)
                    .HasColumnName("Aprob_Cob")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CantXCaja)
                    .HasColumnName("Cant_x_Caja")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoClient)
                    .HasColumnName("Codigo_Client")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FecAproCob)
                    .HasColumnName("Fec_Apro_Cob")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecGrab)
                    .HasColumnName("Fec_Grab")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.NomCliente)
                    .HasColumnName("Nom_Cliente")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumCot)
                    .HasColumnName("Num_Cot")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Orden).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.VentaTot).HasColumnName("Venta_Tot");

                entity.Property(e => e.VentaUnit).HasColumnName("Venta_Unit");
            });

            modelBuilder.Entity<ConsultaEtiquetas>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Consulta Etiquetas");

                entity.Property(e => e.CantMill).HasColumnName("Cant_Mill");

                entity.Property(e => e.CodVend)
                    .HasColumnName("Cod_vend")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FecGrab)
                    .HasColumnName("Fec_Grab")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.NumCot)
                    .HasColumnName("Num_Cot")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ValorLista).HasColumnName("Valor_Lista");

                entity.Property(e => e.VentaUnit).HasColumnName("Venta_Unit");
            });

            modelBuilder.Entity<ConsultaFrontLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CONSULTA FRONT LOG");

                entity.Property(e => e.AfectaBacklog)
                    .HasColumnName("Afecta_Backlog")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cajas).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CantFormas)
                    .HasColumnName("Cant_Formas")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CantMill).HasColumnName("Cant_Mill");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estatus)
                    .HasColumnName("ESTATUS")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ListaTot).HasColumnName("Lista_Tot");

                entity.Property(e => e.NumCot)
                    .HasColumnName("Num_Cot")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Oficina)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VentaTot).HasColumnName("Venta_Tot");
            });

            modelBuilder.Entity<ConsultaOrdImpcomercial>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CONSULTA_ORD_IMPCOMERCIAL");

                entity.Property(e => e.AprobAdmin)
                    .HasColumnName("Aprob_Admin")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AprobCob)
                    .HasColumnName("Aprob_Cob")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AprobCont)
                    .HasColumnName("Aprob_Cont")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AprobP)
                    .HasColumnName("Aprob_P")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClienteNuevo)
                    .HasColumnName("Cliente_Nuevo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodVend)
                    .HasColumnName("Cod_vend")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoClient)
                    .HasColumnName("Codigo_Client")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Contacto)
                    .HasColumnName("contacto")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DescTipoPago)
                    .HasColumnName("Desc_Tipo_Pago")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.DescripProduc)
                    .IsRequired()
                    .HasColumnName("Descrip_Produc")
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DirecEnt)
                    .HasColumnName("Direc_Ent")
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DirecFact)
                    .HasColumnName("Direc_Fact")
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Dolares)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Eliminado)
                    .HasColumnName("ELIMINADO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EnviarEmail)
                    .HasColumnName("Enviar_email")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EstatusCerrado)
                    .HasColumnName("Estatus_Cerrado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FecAproCob)
                    .HasColumnName("Fec_Apro_Cob")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecAproP)
                    .HasColumnName("Fec_Apro_P")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecCob)
                    .HasColumnName("Fec_Cob")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FecDol)
                    .HasColumnName("Fec_Dol")
                    .HasColumnType("datetime");

                entity.Property(e => e.FecGrab)
                    .HasColumnName("Fec_Grab")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecOrd)
                    .HasColumnName("Fec_Ord")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaAprobAdm)
                    .HasColumnName("Fecha_Aprob_Adm")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaAprobCont)
                    .HasColumnName("Fecha_Aprob_Cont")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaDespacho)
                    .HasColumnName("Fecha_Despacho")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaEntrega)
                    .HasColumnName("Fecha_Entrega")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaFactura)
                    .HasColumnName("Fecha_Factura")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaPasada)
                    .HasColumnName("Fecha_Pasada")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaRecibCliente)
                    .HasColumnName("Fecha_Recib_Cliente")
                    .HasMaxLength(26)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GrabCliente)
                    .HasColumnName("Grab_Cliente")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdDireccion)
                    .HasColumnName("Id_Direccion")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NoAsignacion)
                    .HasColumnName("No_Asignacion")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomCliente)
                    .HasColumnName("Nom_Cliente")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomEnt)
                    .HasColumnName("Nom_Ent")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NombFact)
                    .HasColumnName("Nomb_Fact")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumCot)
                    .HasColumnName("Num_Cot")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ObservCliente)
                    .HasColumnName("Observ_Cliente")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Oficina)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrdCompra)
                    .HasColumnName("Ord_compra")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Orden).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PtoReferencia)
                    .HasColumnName("Pto_Referencia")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RboCob)
                    .HasColumnName("Rbo_Cob")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RifEnt)
                    .HasColumnName("Rif_Ent")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RifFact)
                    .HasColumnName("Rif_Fact")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SiColetilla)
                    .HasColumnName("Si_Coletilla")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SiIndexacion)
                    .HasColumnName("Si_Indexacion")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SinRif)
                    .HasColumnName("Sin_Rif")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoPago)
                    .HasColumnName("Tipo_Pago")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoProducto)
                    .HasColumnName("TIPO_PRODUCTO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Unidad)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VentaTot).HasColumnName("Venta_Tot");

                entity.Property(e => e.VentaUnit).HasColumnName("Venta_Unit");
            });

            modelBuilder.Entity<ConsultaOrdenesEtiqPrecioVolumen>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CONSULTA ORDENES ETIQ PRECIO VOLUMEN");

                entity.Property(e => e.Año).HasColumnName("año");

                entity.Property(e => e.Cant)
                    .HasColumnName("CANT")
                    .HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Cant1)
                    .HasColumnName("CANT1")
                    .HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Cant2)
                    .HasColumnName("CANT2")
                    .HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Cant3)
                    .HasColumnName("CANT3")
                    .HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Cant4)
                    .HasColumnName("CANT4")
                    .HasColumnType("decimal(10, 0)");

                entity.Property(e => e.CantMill).HasColumnName("Cant_Mill");

                entity.Property(e => e.CodVend)
                    .HasColumnName("Cod_vend")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FecGrab)
                    .HasColumnName("Fec_Grab")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaVigencia)
                    .HasColumnName("FECHA_VIGENCIA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.NumCot)
                    .HasColumnName("Num_Cot")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PrecLista)
                    .HasColumnName("PREC_LISTA")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PrecLista1)
                    .HasColumnName("PREC_LISTA1")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PrecLista2)
                    .HasColumnName("PREC_LISTA2")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PrecLista3)
                    .HasColumnName("PREC_LISTA3")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PrecLista4)
                    .HasColumnName("PREC_LISTA4")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ValorLista).HasColumnName("Valor_Lista");

                entity.Property(e => e.VentaUnit).HasColumnName("Venta_Unit");
            });

            modelBuilder.Entity<Consultaajdunto>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CONSULTAAJDUNTO");

                entity.Property(e => e.Blob)
                    .HasColumnName("BLOB")
                    .HasColumnType("image");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasColumnName("codigo")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Consultacliente>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CONSULTACLIENTE");

                entity.Property(e => e.AprobCob)
                    .HasColumnName("Aprob_Cob")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AprobP)
                    .HasColumnName("Aprob_P")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodVend)
                    .HasColumnName("Cod_vend")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoClient)
                    .HasColumnName("Codigo_Client")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DirecEnt)
                    .HasColumnName("Direc_Ent")
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DirecFact)
                    .HasColumnName("Direc_Fact")
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Dolares)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FecAproCob)
                    .HasColumnName("Fec_Apro_Cob")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FecAproP)
                    .HasColumnName("Fec_Apro_P")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecCob)
                    .HasColumnName("Fec_Cob")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FecDol)
                    .HasColumnName("Fec_Dol")
                    .HasColumnType("datetime");

                entity.Property(e => e.FecGrab)
                    .HasColumnName("Fec_Grab")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FecOrd)
                    .HasColumnName("Fec_Ord")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaEntrega)
                    .HasColumnName("Fecha_Entrega")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.NomCliente)
                    .HasColumnName("Nom_Cliente")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomEnt)
                    .HasColumnName("Nom_Ent")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NombFact)
                    .HasColumnName("Nomb_Fact")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumCot)
                    .HasColumnName("Num_Cot")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ObservCliente)
                    .HasColumnName("Observ_Cliente")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Oficina)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrdCompra)
                    .HasColumnName("Ord_compra")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Orden).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RboCob)
                    .HasColumnName("Rbo_Cob")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RifEnt)
                    .HasColumnName("Rif_Ent")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RifFact)
                    .HasColumnName("Rif_Fact")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SiColetilla)
                    .HasColumnName("Si_Coletilla")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SiIndexacion)
                    .HasColumnName("Si_Indexacion")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoPago)
                    .HasColumnName("Tipo_Pago")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Unidad)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Consultaproducto>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CONSULTAPRODUCTO");

                entity.Property(e => e.Cajas).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CantDesp)
                    .HasColumnName("Cant_desp")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CantFormas)
                    .HasColumnName("Cant_Formas")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CantMill).HasColumnName("Cant_Mill");

                entity.Property(e => e.CantXCaja)
                    .HasColumnName("Cant_x_Caja")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Instrucciones)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ListaTot).HasColumnName("Lista_Tot");

                entity.Property(e => e.NumCot)
                    .HasColumnName("Num_Cot")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PrecDol).HasColumnName("Prec_Dol");

                entity.Property(e => e.Remision)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TotListDol).HasColumnName("Tot_List_Dol");

                entity.Property(e => e.TotVentDol).HasColumnName("Tot_Vent_Dol");

                entity.Property(e => e.ValListaDol).HasColumnName("Val_Lista_Dol");

                entity.Property(e => e.ValorLista).HasColumnName("Valor_Lista");

                entity.Property(e => e.VentaTot).HasColumnName("Venta_Tot");

                entity.Property(e => e.VentaUnit).HasColumnName("Venta_Unit");
            });

            modelBuilder.Entity<ConsultasPuertoOrdas>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CONSULTAS PUERTO ORDAS");

                entity.Property(e => e.AprobAdmin)
                    .HasColumnName("Aprob_Admin")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AprobCob)
                    .HasColumnName("Aprob_Cob")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AprobCont)
                    .HasColumnName("Aprob_Cont")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AprobP)
                    .HasColumnName("Aprob_P")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClienteNuevo)
                    .HasColumnName("Cliente_Nuevo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodVend)
                    .HasColumnName("Cod_vend")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoClient)
                    .HasColumnName("Codigo_Client")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DirecEnt)
                    .HasColumnName("Direc_Ent")
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DirecFact)
                    .HasColumnName("Direc_Fact")
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Dolares)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Expr1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FecAproCob)
                    .HasColumnName("Fec_Apro_Cob")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecAproP)
                    .HasColumnName("Fec_Apro_P")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecCob)
                    .HasColumnName("Fec_Cob")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FecDol)
                    .HasColumnName("Fec_Dol")
                    .HasColumnType("datetime");

                entity.Property(e => e.FecGrab)
                    .HasColumnName("Fec_Grab")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecOrd)
                    .HasColumnName("Fec_Ord")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaAprobAdm)
                    .HasColumnName("Fecha_Aprob_Adm")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaAprobCont)
                    .HasColumnName("Fecha_Aprob_Cont")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaEntrega)
                    .HasColumnName("Fecha_Entrega")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.NoAsignacion)
                    .HasColumnName("No_Asignacion")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomCliente)
                    .HasColumnName("Nom_Cliente")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomEnt)
                    .HasColumnName("Nom_Ent")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NombFact)
                    .HasColumnName("Nomb_Fact")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumCot)
                    .HasColumnName("Num_Cot")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ObservCliente)
                    .HasColumnName("Observ_Cliente")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Oficina)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrdCompra)
                    .HasColumnName("Ord_compra")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Orden).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PtoReferencia)
                    .HasColumnName("Pto_Referencia")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RboCob)
                    .HasColumnName("Rbo_Cob")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RifEnt)
                    .HasColumnName("Rif_Ent")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RifFact)
                    .HasColumnName("Rif_Fact")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SiColetilla)
                    .HasColumnName("Si_Coletilla")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SiIndexacion)
                    .HasColumnName("Si_Indexacion")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SinRif)
                    .HasColumnName("Sin_Rif")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoPago)
                    .HasColumnName("Tipo_Pago")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Unidad)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ContadorOrdenesMesCurso>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CONTADOR_ORDENES_MES_CURSO");

                entity.Property(e => e.FecAproCob)
                    .HasColumnName("Fec_Apro_Cob")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.NumCot)
                    .HasColumnName("Num_Cot")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Correlativos>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Correlativos");

                entity.Property(e => e.CodVend)
                    .HasColumnName("Cod_vend")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Correlativo)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DatosAdjuntos>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("_DatosAdjuntos");

                entity.HasIndex(e => e.Fecha)
                    .HasName("IX__DatosAdjuntos_1");

                entity.HasIndex(e => e.NumCot)
                    .HasName("IX__DatosAdjuntos");

                entity.Property(e => e.Blob)
                    .HasColumnName("BLOB")
                    .HasColumnType("image");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasColumnName("codigo")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Fecha).HasColumnType("smalldatetime");

                entity.Property(e => e.NumCot)
                    .HasColumnName("num_cot")
                    .HasComputedColumnSql("(convert(int,[codigo]))");
            });

            modelBuilder.Entity<DatosCliente>(entity =>
            {
                entity.HasKey(e => e.NumCot);

                entity.HasIndex(e => e.CodVend)
                    .HasName("IX_DatosCliente_3");

                entity.HasIndex(e => e.CotizacionGeneral)
                    .HasName("IX_DatosCliente_4");

                entity.HasIndex(e => e.FecGrab)
                    .HasName("IX_DatosCliente_2");

                entity.HasIndex(e => e.NumCot)
                    .HasName("IX_DatosCliente");

                entity.HasIndex(e => e.Orden)
                    .HasName("IX_DatosClienteOrden");

                entity.HasIndex(e => e.RifFact)
                    .HasName("IX_DatosCliente_1");

                entity.HasIndex(e => new { e.CotizacionGeneral, e.Orden })
                    .HasName("IX_DatosCliente_5");

                entity.Property(e => e.NumCot)
                    .HasColumnName("Num_Cot")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.An8entregar).HasColumnName("AN8ENTREGAR");

                entity.Property(e => e.An8facturar).HasColumnName("AN8FACTURAR");

                entity.Property(e => e.AprobAdmin)
                    .HasColumnName("Aprob_Admin")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AprobCob)
                    .HasColumnName("Aprob_Cob")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AprobCont)
                    .HasColumnName("Aprob_Cont")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AprobP)
                    .HasColumnName("Aprob_P")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClienteNuevo)
                    .HasColumnName("Cliente_Nuevo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodRetencion).HasColumnName("COD_RETENCION");

                entity.Property(e => e.CodTeleop)
                    .HasColumnName("Cod_teleop")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')")
                    .HasComment("Codigo de teleoperadora");

                entity.Property(e => e.CodVend)
                    .HasColumnName("Cod_vend")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodigoClient)
                    .HasColumnName("Codigo_Client")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Contacto)
                    .HasColumnName("contacto")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CotizacionGeneral).HasMaxLength(13);

                entity.Property(e => e.CotizacionOriginal)
                    .HasColumnName("COTIZACION_ORIGINAL")
                    .HasMaxLength(18);

                entity.Property(e => e.DescTipoPago)
                    .HasColumnName("Desc_Tipo_Pago")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.DirecEnt)
                    .HasColumnName("Direc_Ent")
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DirecFact)
                    .HasColumnName("Direc_Fact")
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Dolares)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EnviarEmail)
                    .HasColumnName("Enviar_email")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Estado)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EstadoEntregar).HasMaxLength(2);

                entity.Property(e => e.EstadoFacturar).HasMaxLength(2);

                entity.Property(e => e.FecAproCob)
                    .HasColumnName("Fec_Apro_Cob")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecAproP)
                    .HasColumnName("Fec_Apro_P")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecCob)
                    .HasColumnName("Fec_Cob")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.FecDol)
                    .HasColumnName("Fec_Dol")
                    .HasColumnType("datetime");

                entity.Property(e => e.FecGrab)
                    .HasColumnName("Fec_Grab")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecOrd)
                    .HasColumnName("Fec_Ord")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.FechaAprobAdm)
                    .HasColumnName("Fecha_Aprob_Adm")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaAprobCont)
                    .HasColumnName("Fecha_Aprob_Cont")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaDespacho)
                    .HasColumnName("Fecha_Despacho")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaEntrega)
                    .HasColumnName("Fecha_Entrega")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaFactura)
                    .HasColumnName("Fecha_Factura")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaPasada)
                    .HasColumnName("Fecha_Pasada")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaRecibCliente)
                    .HasColumnName("Fecha_Recib_Cliente")
                    .HasMaxLength(26)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagCombo)
                    .HasColumnName("flag_combo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FlagSinAdj)
                    .HasColumnName("FLAG_SIN_ADJ")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GrabCliente)
                    .HasColumnName("GRAB_CLIENTE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdContactos)
                    .HasColumnName("ID_CONTACTOS")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdDireccion)
                    .HasColumnName("Id_Direccion")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdDireccionEntregar)
                    .HasColumnName("Id_direccionEntregar")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.MunicipioEntregar).HasMaxLength(2);

                entity.Property(e => e.MunicipioFacturar).HasMaxLength(2);

                entity.Property(e => e.NoAsignacion)
                    .HasColumnName("No_Asignacion")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NomCliente)
                    .HasColumnName("Nom_Cliente")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomEnt)
                    .HasColumnName("Nom_Ent")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NombFact)
                    .HasColumnName("Nomb_Fact")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ObsRetencion)
                    .HasColumnName("OBS_RETENCION")
                    .HasMaxLength(250);

                entity.Property(e => e.ObserSaca)
                    .HasColumnName("obser_saca")
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ObservCliente)
                    .HasColumnName("Observ_Cliente")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Oficina)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrdCompra)
                    .HasColumnName("Ord_compra")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Orden).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PtoReferencia)
                    .HasColumnName("Pto_Referencia")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RboCob)
                    .HasColumnName("Rbo_Cob")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RequiereNe)
                    .HasColumnName("REQUIERE_NE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RifEnt)
                    .HasColumnName("Rif_Ent")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RifFact)
                    .HasColumnName("Rif_Fact")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Rtasa).HasColumnName("RTasa");

                entity.Property(e => e.SiColetilla)
                    .HasColumnName("Si_Coletilla")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('X')");

                entity.Property(e => e.SiIndexacion)
                    .HasColumnName("Si_Indexacion")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('X')");

                entity.Property(e => e.SinRif)
                    .HasColumnName("Sin_Rif")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Solaprob)
                    .HasColumnName("SOLAPROB")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Solaprob2)
                    .HasColumnName("SOLAPROB2")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StatusOrden)
                    .HasColumnName("STATUS_ORDEN")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoPago)
                    .HasColumnName("Tipo_Pago")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Unidad)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Vendedoric)
                    .HasColumnName("VENDEDORIC")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("FLAG VENDEDOR IMPRESION COMERCIAL");
            });

            modelBuilder.Entity<DatosClienteLog>(entity =>
            {
                entity.HasNoKey();
               

                entity.HasIndex(e => e.CodVend)
                    .HasName("IX_DatosClienteLog_1");

                entity.HasIndex(e => e.NumCot)
                    .HasName("IX_DatosClienteLog");

                entity.HasIndex(e => e.Orden)
                    .HasName("dep_DatosClienteLogorden");

                entity.Property(e => e.An8entregar).HasColumnName("AN8ENTREGAR");

                entity.Property(e => e.An8facturar).HasColumnName("AN8FACTURAR");

                entity.Property(e => e.AprobAdmin)
                    .HasColumnName("Aprob_Admin")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AprobCob)
                    .HasColumnName("Aprob_Cob")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AprobCont)
                    .HasColumnName("Aprob_Cont")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AprobP)
                    .HasColumnName("Aprob_P")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClienteNuevo)
                    .HasColumnName("Cliente_Nuevo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodRetencion).HasColumnName("COD_RETENCION");

                entity.Property(e => e.CodTeleop)
                    .HasColumnName("Cod_teleop")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodVend)
                    .HasColumnName("Cod_vend")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoClient)
                    .HasColumnName("Codigo_Client")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Contacto)
                    .HasColumnName("contacto")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CotizacionGeneral).HasMaxLength(13);

                entity.Property(e => e.CotizacionOriginal)
                    .HasColumnName("COTIZACION_ORIGINAL")
                    .HasMaxLength(18);

                entity.Property(e => e.DescTipoPago)
                    .HasColumnName("Desc_Tipo_Pago")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.DirecEnt)
                    .HasColumnName("Direc_Ent")
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DirecFact)
                    .HasColumnName("Direc_Fact")
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Dolares)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EnviarEmail)
                    .HasColumnName("Enviar_email")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EstadoEntregar).HasMaxLength(2);

                entity.Property(e => e.EstadoFacturar).HasMaxLength(2);

                entity.Property(e => e.FecAproCob)
                    .HasColumnName("Fec_Apro_Cob")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecAproP)
                    .HasColumnName("Fec_Apro_P")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecCob)
                    .HasColumnName("Fec_Cob")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FecDol)
                    .HasColumnName("Fec_Dol")
                    .HasColumnType("datetime");

                entity.Property(e => e.FecGrab)
                    .HasColumnName("Fec_Grab")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecOrd)
                    .HasColumnName("Fec_Ord")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaAprobAdm)
                    .HasColumnName("Fecha_Aprob_Adm")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaAprobCont)
                    .HasColumnName("Fecha_Aprob_Cont")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaDespacho)
                    .HasColumnName("Fecha_Despacho")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaEliminado).HasColumnType("datetime");

                entity.Property(e => e.FechaEntrega)
                    .HasColumnName("Fecha_Entrega")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaFactura)
                    .HasColumnName("Fecha_Factura")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaPasada)
                    .HasColumnName("Fecha_Pasada")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaRecibCliente)
                    .HasColumnName("Fecha_Recib_Cliente")
                    .HasMaxLength(26)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagCombo)
                    .HasColumnName("flag_combo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagSinAdj)
                    .HasColumnName("FLAG_SIN_ADJ")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GrabCliente)
                    .HasColumnName("GRAB_CLIENTE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdContactos)
                    .HasColumnName("ID_CONTACTOS")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdDireccion)
                    .HasColumnName("Id_Direccion")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdDireccionEntregar)
                    .HasColumnName("Id_direccionEntregar")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.MunicipioEntregar).HasMaxLength(2);

                entity.Property(e => e.MunicipioFacturar).HasMaxLength(2);

                entity.Property(e => e.NoAsignacion)
                    .HasColumnName("No_Asignacion")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomCliente)
                    .HasColumnName("Nom_Cliente")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomEnt)
                    .HasColumnName("Nom_Ent")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NombFact)
                    .HasColumnName("Nomb_Fact")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumCot)
                    .HasColumnName("Num_Cot")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ObsRetencion)
                    .HasColumnName("OBS_RETENCION")
                    .HasMaxLength(250);

                entity.Property(e => e.ObserSaca)
                    .HasColumnName("obser_saca")
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ObservCliente)
                    .HasColumnName("Observ_Cliente")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Oficina)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrdCompra)
                    .HasColumnName("Ord_compra")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Orden).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PtoReferencia)
                    .HasColumnName("Pto_Referencia")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RboCob)
                    .HasColumnName("Rbo_Cob")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RequiereNe)
                    .HasColumnName("REQUIERE_NE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RifEnt)
                    .HasColumnName("Rif_Ent")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RifFact)
                    .HasColumnName("Rif_Fact")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Rtasa).HasColumnName("RTasa");

                entity.Property(e => e.SiColetilla)
                    .HasColumnName("Si_Coletilla")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SiIndexacion)
                    .HasColumnName("Si_Indexacion")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SinRif)
                    .HasColumnName("Sin_Rif")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Solaprob)
                    .HasColumnName("SOLAPROB")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Solaprob2)
                    .HasColumnName("SOLAPROB2")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StatusOrden)
                    .HasColumnName("STATUS_ORDEN")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoPago)
                    .HasColumnName("Tipo_Pago")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Unidad)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioElimino).HasMaxLength(50);

                entity.Property(e => e.Vendedoric)
                    .HasColumnName("VENDEDORIC")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DatosProductos>(entity =>
            {
               // entity.HasNoKey();
                entity.HasKey(e => e.Recnum);
                entity.ToTable("Datos Productos");

                entity.HasIndex(e => new { e.CotizacionGeneral, e.Codigo })
                    .HasName("IX_Datos Productos");

                entity.HasIndex(e => new { e.NumCot, e.Codigo })
                    .HasName("cotizacion-producto")
                    .IsUnique();

                entity.HasIndex(e => new { e.CantXCaja, e.VentaUnit, e.NumCot, e.UnidadCosteo, e.Codigo })
                    .HasName("IX_DatosProductosCodigoCot");

                entity.HasIndex(e => new { e.CantXCaja, e.UnidadCosteo, e.NumCot, e.VentaUnit, e.Codigo, e.CotizacionGeneral })
                    .HasName("ix_DatosProductosCodigoCotizacionGeneral");

                entity.Property(e => e.BsMcFinan)
                    .HasColumnName("BS_MC_FINAN")
                    .HasColumnType("decimal(20, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BsMcPapel)
                    .HasColumnName("BS_MC_PAPEL")
                    .HasColumnType("decimal(20, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cajas).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CantDesp)
                    .HasColumnName("Cant_desp")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CantFormas)
                    .HasColumnName("Cant_Formas")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CantMill).HasColumnName("Cant_Mill");

                entity.Property(e => e.CantV19)
                    .HasColumnName("Cant_V19")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CantXCaja)
                    .HasColumnName("Cant_x_Caja")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Concesion).HasColumnType("decimal(20, 2)");

                entity.Property(e => e.CotizacionGeneral).HasMaxLength(13);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EnviarEmail)
                    .HasColumnName("Enviar_email")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Excepcion)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("Orden con Excepcion de comision");

                entity.Property(e => e.FechaReorden).HasColumnType("smalldatetime");

                entity.Property(e => e.Fiscal)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Instrucciones)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ListaTot)
                    .HasColumnName("Lista_Tot")
                    .HasColumnType("decimal(20, 2)");

                entity.Property(e => e.LongitudMascara).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MarcaConcesion)
                    .HasColumnName("Marca_Concesion")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumCot)
                    .HasColumnName("Num_Cot")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NumeroControlDesde)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroControlHasta)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroFormatoDesde)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumeroFormatoHasta)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumeroSerieControlDesde)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroSerieControlHasta)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroSerieFormatoDesde)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumeroSerieFormatoHasta)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PiesCuadrado).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PorcCom)
                    .HasColumnName("PORC_COM")
                    .HasColumnType("numeric(4, 2)");

                entity.Property(e => e.PorcComRegulada)
                    .HasColumnType("numeric(5, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PorcMcFinan)
                    .HasColumnName("PORC_MC_FINAN")
                    .HasColumnType("decimal(20, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PorcMcPapel)
                    .HasColumnName("PORC_MC_PAPEL")
                    .HasColumnType("decimal(20, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PorcRespSocial)
                    .HasColumnType("numeric(5, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PrecDol)
                    .HasColumnName("Prec_Dol")
                    .HasColumnType("decimal(20, 2)");

                entity.Property(e => e.RbsMcFinan)
                    .HasColumnName("RBS_MC_FINAN")
                    .HasColumnType("decimal(20, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RbsMcPapel)
                    .HasColumnName("RBS_MC_PAPEL")
                    .HasColumnType("decimal(20, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RecWsmy469)
                    .HasColumnName("RecWSMY469")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Recnum)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Remision)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RlistaTot)
                    .HasColumnName("RLista_Tot")
                    .HasColumnType("decimal(20, 2)");

                entity.Property(e => e.RvalorLista)
                    .HasColumnName("RValor_Lista")
                    .HasColumnType("decimal(20, 2)");

                entity.Property(e => e.RventaTot)
                    .HasColumnName("RVenta_Tot")
                    .HasColumnType("decimal(20, 2)");

                entity.Property(e => e.RventaUnit)
                    .HasColumnName("RVenta_Unit")
                    .HasColumnType("decimal(20, 2)");

                entity.Property(e => e.TipoDocumento)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoIva)
                    .HasColumnName("tipo_iva")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotListDol)
                    .HasColumnName("Tot_List_Dol")
                    .HasColumnType("decimal(20, 2)");

                entity.Property(e => e.TotVentDol)
                    .HasColumnName("Tot_Vent_Dol")
                    .HasColumnType("decimal(20, 2)");

                entity.Property(e => e.UnidadCosteo)
                    .HasColumnName("Unidad_Costeo")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ValListaDol)
                    .HasColumnName("Val_Lista_Dol")
                    .HasColumnType("decimal(20, 2)");

                entity.Property(e => e.ValorLista)
                    .HasColumnName("Valor_Lista")
                    .HasColumnType("decimal(20, 2)");

                entity.Property(e => e.VentaTot)
                    .HasColumnName("Venta_Tot")
                    .HasColumnType("decimal(20, 2)");

                entity.Property(e => e.VentaUnit)
                    .HasColumnName("Venta_Unit")
                    .HasColumnType("decimal(20, 2)");
            });

            modelBuilder.Entity<DatosProductos2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Datos Productos 2");

                entity.Property(e => e.Cajas).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CantDesp)
                    .HasColumnName("Cant_desp")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CantFormas)
                    .HasColumnName("Cant_Formas")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CantMill).HasColumnName("Cant_Mill");

                entity.Property(e => e.CantXCaja)
                    .HasColumnName("Cant_x_Caja")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Instrucciones)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ListaTot).HasColumnName("Lista_Tot");

                entity.Property(e => e.NumCot)
                    .HasColumnName("Num_Cot")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PrecDol).HasColumnName("Prec_Dol");

                entity.Property(e => e.Remision)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TotListDol).HasColumnName("Tot_List_Dol");

                entity.Property(e => e.TotVentDol).HasColumnName("Tot_Vent_Dol");

                entity.Property(e => e.UnidadCosteo)
                    .HasColumnName("Unidad_Costeo")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ValListaDol).HasColumnName("Val_Lista_Dol");

                entity.Property(e => e.ValorLista).HasColumnName("Valor_Lista");

                entity.Property(e => e.VentaTot).HasColumnName("Venta_Tot");

                entity.Property(e => e.VentaUnit).HasColumnName("Venta_Unit");
            });

            modelBuilder.Entity<EmailAdministradora>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("emailAdministradora");

                entity.Property(e => e.EmailAdmin)
                    .HasColumnName("email_Admin")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NombreAdm)
                    .HasColumnName("Nombre_Adm")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Oficina)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<EmailSupervisor>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Email Supervisor");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasColumnName("CODIGO")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EMail)
                    .HasColumnName("E_MAIL")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaRetiro)
                    .HasColumnName("FECHA_RETIRO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FlagDeGerente)
                    .HasColumnName("FLAG_DE_GERENTE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagSupervisor)
                    .HasColumnName("FLAG_SUPERVISOR")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<EmailVendedores>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Email Vendedores");

                entity.Property(e => e.Codigo)
                    .HasColumnName("CODIGO")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EMail)
                    .HasColumnName("E_MAIL")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaRetiro)
                    .HasColumnName("FECHA_RETIRO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Nombre)
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Oficina)
                    .HasColumnName("OFICINA")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Supervisor)
                    .HasColumnName("SUPERVISOR")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Escaneado>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Escanea)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EstAdmin)
                    .IsRequired()
                    .HasColumnName("Est_Admin")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Oficina)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<EstadisticasAprobacionCobranzas>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Estadisticas Aprobacion Cobranzas");

                entity.Property(e => e.Dias).HasColumnName("DIAS");

                entity.Property(e => e.FecAproCob)
                    .HasColumnName("Fec_Apro_Cob")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecGrab)
                    .HasColumnName("Fec_Grab")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaAprobAdm)
                    .HasColumnName("Fecha_Aprob_Adm")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.NomCliente)
                    .HasColumnName("Nom_Cliente")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumCot)
                    .HasColumnName("Num_Cot")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Oficina)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<EstadisticasCeos>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ESTADISTICAS CEOS");

                entity.Property(e => e.AprobAdmin)
                    .HasColumnName("Aprob_Admin")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AprobCob)
                    .HasColumnName("Aprob_Cob")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AprobCont)
                    .HasColumnName("Aprob_Cont")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AprobP)
                    .HasColumnName("Aprob_P")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClienteNuevo)
                    .HasColumnName("Cliente_Nuevo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodVend)
                    .HasColumnName("Cod_vend")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoClient)
                    .HasColumnName("Codigo_Client")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DirecEnt)
                    .HasColumnName("Direc_Ent")
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DirecFact)
                    .HasColumnName("Direc_Fact")
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Dolares)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Expr1).HasColumnType("smalldatetime");

                entity.Property(e => e.Expr2)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FecAproCob)
                    .HasColumnName("Fec_Apro_Cob")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecAproP)
                    .HasColumnName("Fec_Apro_P")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecCob)
                    .HasColumnName("Fec_Cob")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FecDol)
                    .HasColumnName("Fec_Dol")
                    .HasColumnType("datetime");

                entity.Property(e => e.FecGrab)
                    .HasColumnName("Fec_Grab")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecOrd)
                    .HasColumnName("Fec_Ord")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaAprobAdm)
                    .HasColumnName("Fecha_Aprob_Adm")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaAprobCont)
                    .HasColumnName("Fecha_Aprob_Cont")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaEntrega)
                    .HasColumnName("Fecha_Entrega")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.NoAsignacion)
                    .HasColumnName("No_Asignacion")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomCliente)
                    .HasColumnName("Nom_Cliente")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomEnt)
                    .HasColumnName("Nom_Ent")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NombFact)
                    .HasColumnName("Nomb_Fact")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumCot)
                    .HasColumnName("Num_Cot")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ObservCliente)
                    .HasColumnName("Observ_Cliente")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Oficina)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrdCompra)
                    .HasColumnName("Ord_compra")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Orden).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PtoReferencia)
                    .HasColumnName("Pto_Referencia")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RboCob)
                    .HasColumnName("Rbo_Cob")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RifEnt)
                    .HasColumnName("Rif_Ent")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RifFact)
                    .HasColumnName("Rif_Fact")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SiColetilla)
                    .HasColumnName("Si_Coletilla")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SiIndexacion)
                    .HasColumnName("Si_Indexacion")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SinRif)
                    .HasColumnName("Sin_Rif")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoPago)
                    .HasColumnName("Tipo_Pago")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Unidad)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<EstatusOrdenes>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Estatus Ordenes");

                entity.Property(e => e.AfectaBacklog)
                    .HasColumnName("Afecta_Backlog")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoEstatus)
                    .HasColumnName("Codigo_Estatus")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagEnviado)
                    .HasColumnName("Flag_Enviado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagModifica).HasMaxLength(1);
            });

            modelBuilder.Entity<ItemCotizacion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Item_cotizacion");

                entity.Property(e => e.NumCot)
                    .HasColumnName("Num_Cot")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<MaestraVendedores>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Maestra_vendedores");

                entity.Property(e => e.Activo)
                    .HasColumnName("ACTIVO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Asignacion)
                    .HasColumnName("ASIGNACION")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClaseVendedor)
                    .HasColumnName("CLASE_VENDEDOR")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Cobrador)
                    .HasColumnName("COBRADOR")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Codigo)
                    .HasColumnName("CODIGO")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoGrupo)
                    .HasColumnName("CODIGO_GRUPO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoRegion)
                    .HasColumnName("CODIGO_REGION")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Comision)
                    .HasColumnName("COMISION")
                    .HasColumnType("numeric(6, 2)");

                entity.Property(e => e.EMail)
                    .HasColumnName("E_MAIL")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaRetiro)
                    .HasColumnName("FECHA_RETIRO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Ficha)
                    .HasColumnName("FICHA")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagDeGerente)
                    .HasColumnName("FLAG_DE_GERENTE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagRetirado)
                    .HasColumnName("FLAG_RETIRADO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagSupervisor)
                    .HasColumnName("FLAG_SUPERVISOR")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FreeLance)
                    .HasColumnName("FREE_LANCE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Garantia)
                    .HasColumnName("GARANTIA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GerenteRegion)
                    .HasColumnName("GERENTE_REGION")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Grupo)
                    .HasColumnName("GRUPO")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Nombre)
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NroVendedor)
                    .HasColumnName("NRO_VENDEDOR")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.Oficina)
                    .HasColumnName("OFICINA")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Override)
                    .HasColumnName("OVERRIDE")
                    .HasColumnType("numeric(6, 2)");

                entity.Property(e => e.Supervisor)
                    .HasColumnName("SUPERVISOR")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TlfCelular)
                    .HasColumnName("TLF_CELULAR")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Usuario)
                    .HasColumnName("USUARIO")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<MontoOrdenes>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Monto Ordenes");

                entity.Property(e => e.FecGrab)
                    .HasColumnName("Fec_Grab")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ListaTot).HasColumnName("Lista_Tot");

                entity.Property(e => e.NumCot)
                    .HasColumnName("Num_Cot")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Oficina)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VentaTot).HasColumnName("Venta_Tot");
            });

            modelBuilder.Entity<OrdenesAdministradoras>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ORDENES ADMINISTRADORAS");

                entity.Property(e => e.AprobAdmin)
                    .HasColumnName("Aprob_Admin")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AprobCob)
                    .HasColumnName("Aprob_Cob")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AprobCont)
                    .HasColumnName("Aprob_Cont")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AprobP)
                    .HasColumnName("Aprob_P")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClienteNuevo)
                    .HasColumnName("Cliente_Nuevo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodVend)
                    .HasColumnName("Cod_vend")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoClient)
                    .HasColumnName("Codigo_Client")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DirecEnt)
                    .HasColumnName("Direc_Ent")
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DirecFact)
                    .HasColumnName("Direc_Fact")
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Dolares)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FecAproCob)
                    .HasColumnName("Fec_Apro_Cob")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecAproP)
                    .HasColumnName("Fec_Apro_P")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecCob)
                    .HasColumnName("Fec_Cob")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FecDol)
                    .HasColumnName("Fec_Dol")
                    .HasColumnType("datetime");

                entity.Property(e => e.FecGrab)
                    .HasColumnName("Fec_Grab")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecOrd)
                    .HasColumnName("Fec_Ord")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaAprobAdm)
                    .HasColumnName("Fecha_Aprob_Adm")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaAprobCont)
                    .HasColumnName("Fecha_Aprob_Cont")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaDespacho)
                    .HasColumnName("Fecha_Despacho")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaEntrega)
                    .HasColumnName("Fecha_Entrega")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaFactura)
                    .HasColumnName("Fecha_Factura")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaPasada)
                    .HasColumnName("Fecha_Pasada")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaRecibCliente)
                    .HasColumnName("Fecha_Recib_Cliente")
                    .HasMaxLength(26)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NoAsignacion)
                    .HasColumnName("No_Asignacion")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomCliente)
                    .HasColumnName("Nom_Cliente")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomEnt)
                    .HasColumnName("Nom_Ent")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NombFact)
                    .HasColumnName("Nomb_Fact")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumCot)
                    .HasColumnName("Num_Cot")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ObservCliente)
                    .HasColumnName("Observ_Cliente")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Oficina)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrdCompra)
                    .HasColumnName("Ord_compra")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Orden).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PtoReferencia)
                    .HasColumnName("Pto_Referencia")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RboCob)
                    .HasColumnName("Rbo_Cob")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RifEnt)
                    .HasColumnName("Rif_Ent")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RifFact)
                    .HasColumnName("Rif_Fact")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SiColetilla)
                    .HasColumnName("Si_Coletilla")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SiIndexacion)
                    .HasColumnName("Si_Indexacion")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SinRif)
                    .HasColumnName("Sin_Rif")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoPago)
                    .HasColumnName("Tipo_Pago")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Unidad)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<OrdenesBarquisimeto>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ORDENES BARQUISIMETO");

                entity.Property(e => e.AprobAdmin)
                    .HasColumnName("Aprob_Admin")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AprobCob)
                    .HasColumnName("Aprob_Cob")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AprobCont)
                    .HasColumnName("Aprob_Cont")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AprobP)
                    .HasColumnName("Aprob_P")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClienteNuevo)
                    .HasColumnName("Cliente_Nuevo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodVend)
                    .HasColumnName("Cod_vend")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoClient)
                    .HasColumnName("Codigo_Client")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DirecEnt)
                    .HasColumnName("Direc_Ent")
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DirecFact)
                    .HasColumnName("Direc_Fact")
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Dolares)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Expr1).HasColumnType("smalldatetime");

                entity.Property(e => e.FecAproCob)
                    .HasColumnName("Fec_Apro_Cob")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecAproP)
                    .HasColumnName("Fec_Apro_P")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecCob)
                    .HasColumnName("Fec_Cob")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FecDol)
                    .HasColumnName("Fec_Dol")
                    .HasColumnType("datetime");

                entity.Property(e => e.FecGrab)
                    .HasColumnName("Fec_Grab")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecOrd)
                    .HasColumnName("Fec_Ord")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaAprobAdm)
                    .HasColumnName("Fecha_Aprob_Adm")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaAprobCont)
                    .HasColumnName("Fecha_Aprob_Cont")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaEntrega)
                    .HasColumnName("Fecha_Entrega")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.NoAsignacion)
                    .HasColumnName("No_Asignacion")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomCliente)
                    .HasColumnName("Nom_Cliente")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomEnt)
                    .HasColumnName("Nom_Ent")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NombFact)
                    .HasColumnName("Nomb_Fact")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumCot)
                    .HasColumnName("Num_Cot")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ObservCliente)
                    .HasColumnName("Observ_Cliente")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Oficina)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrdCompra)
                    .HasColumnName("Ord_compra")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Orden).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PtoReferencia)
                    .HasColumnName("Pto_Referencia")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RboCob)
                    .HasColumnName("Rbo_Cob")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RifEnt)
                    .HasColumnName("Rif_Ent")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RifFact)
                    .HasColumnName("Rif_Fact")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SiColetilla)
                    .HasColumnName("Si_Coletilla")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SiIndexacion)
                    .HasColumnName("Si_Indexacion")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SinRif)
                    .HasColumnName("Sin_Rif")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoPago)
                    .HasColumnName("Tipo_Pago")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Unidad)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<OrdenesCaracas>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ORDENES CARACAS");

                entity.Property(e => e.AprobAdmin)
                    .HasColumnName("Aprob_Admin")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AprobCob)
                    .HasColumnName("Aprob_Cob")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AprobCont)
                    .HasColumnName("Aprob_Cont")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AprobP)
                    .HasColumnName("Aprob_P")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClienteNuevo)
                    .HasColumnName("Cliente_Nuevo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodVend)
                    .HasColumnName("Cod_vend")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoClient)
                    .HasColumnName("Codigo_Client")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DirecEnt)
                    .HasColumnName("Direc_Ent")
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DirecFact)
                    .HasColumnName("Direc_Fact")
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Dolares)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Expr1).HasColumnType("smalldatetime");

                entity.Property(e => e.FecAproCob)
                    .HasColumnName("Fec_Apro_Cob")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecAproP)
                    .HasColumnName("Fec_Apro_P")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecCob)
                    .HasColumnName("Fec_Cob")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FecDol)
                    .HasColumnName("Fec_Dol")
                    .HasColumnType("datetime");

                entity.Property(e => e.FecGrab)
                    .HasColumnName("Fec_Grab")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecOrd)
                    .HasColumnName("Fec_Ord")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaAprobAdm)
                    .HasColumnName("Fecha_Aprob_Adm")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaAprobCont)
                    .HasColumnName("Fecha_Aprob_Cont")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaEntrega)
                    .HasColumnName("Fecha_Entrega")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.NoAsignacion)
                    .HasColumnName("No_Asignacion")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomCliente)
                    .HasColumnName("Nom_Cliente")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomEnt)
                    .HasColumnName("Nom_Ent")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NombFact)
                    .HasColumnName("Nomb_Fact")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumCot)
                    .HasColumnName("Num_Cot")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ObservCliente)
                    .HasColumnName("Observ_Cliente")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Oficina)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrdCompra)
                    .HasColumnName("Ord_compra")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Orden).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PtoReferencia)
                    .HasColumnName("Pto_Referencia")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RboCob)
                    .HasColumnName("Rbo_Cob")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RifEnt)
                    .HasColumnName("Rif_Ent")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RifFact)
                    .HasColumnName("Rif_Fact")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SiColetilla)
                    .HasColumnName("Si_Coletilla")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SiIndexacion)
                    .HasColumnName("Si_Indexacion")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SinRif)
                    .HasColumnName("Sin_Rif")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoPago)
                    .HasColumnName("Tipo_Pago")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Unidad)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<OrdenesCobranzas>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ORDENES COBRANZAS");

                entity.Property(e => e.AprobAdmin)
                    .HasColumnName("Aprob_Admin")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AprobCob)
                    .HasColumnName("Aprob_Cob")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AprobCont)
                    .HasColumnName("Aprob_Cont")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AprobP)
                    .HasColumnName("Aprob_P")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClienteNuevo)
                    .HasColumnName("Cliente_Nuevo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodVend)
                    .HasColumnName("Cod_vend")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoClient)
                    .HasColumnName("Codigo_Client")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DirecEnt)
                    .HasColumnName("Direc_Ent")
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DirecFact)
                    .HasColumnName("Direc_Fact")
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Dolares)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FecAproCob)
                    .HasColumnName("Fec_Apro_Cob")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecAproP)
                    .HasColumnName("Fec_Apro_P")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecCob)
                    .HasColumnName("Fec_Cob")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FecDol)
                    .HasColumnName("Fec_Dol")
                    .HasColumnType("datetime");

                entity.Property(e => e.FecGrab)
                    .HasColumnName("Fec_Grab")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecOrd)
                    .HasColumnName("Fec_Ord")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaAprobAdm)
                    .HasColumnName("Fecha_Aprob_Adm")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaAprobCont)
                    .HasColumnName("Fecha_Aprob_Cont")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaDespacho)
                    .HasColumnName("Fecha_Despacho")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaEntrega)
                    .HasColumnName("Fecha_Entrega")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaFactura)
                    .HasColumnName("Fecha_Factura")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaPasada)
                    .HasColumnName("Fecha_Pasada")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaRecibCliente)
                    .HasColumnName("Fecha_Recib_Cliente")
                    .HasMaxLength(26)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NoAsignacion)
                    .HasColumnName("No_Asignacion")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomCliente)
                    .HasColumnName("Nom_Cliente")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomEnt)
                    .HasColumnName("Nom_Ent")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NombFact)
                    .HasColumnName("Nomb_Fact")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumCot)
                    .HasColumnName("Num_Cot")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ObservCliente)
                    .HasColumnName("Observ_Cliente")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Oficina)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrdCompra)
                    .HasColumnName("Ord_compra")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Orden).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PtoReferencia)
                    .HasColumnName("Pto_Referencia")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RboCob)
                    .HasColumnName("Rbo_Cob")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RifEnt)
                    .HasColumnName("Rif_Ent")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RifFact)
                    .HasColumnName("Rif_Fact")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SiColetilla)
                    .HasColumnName("Si_Coletilla")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SiIndexacion)
                    .HasColumnName("Si_Indexacion")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SinRif)
                    .HasColumnName("Sin_Rif")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoPago)
                    .HasColumnName("Tipo_Pago")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Unidad)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<OrdenesEnElDia>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Ordenes en el Dia");

                entity.Property(e => e.AprobAdmin)
                    .HasColumnName("Aprob_Admin")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AprobCob)
                    .HasColumnName("Aprob_Cob")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AprobCont)
                    .HasColumnName("Aprob_Cont")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodVend)
                    .HasColumnName("Cod_vend")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cotizacion).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Estado)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FecAproCob)
                    .HasColumnName("Fec_Apro_Cob")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecAproP)
                    .HasColumnName("Fec_Apro_P")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecGrab)
                    .HasColumnName("Fec_Grab")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecOrd)
                    .HasColumnName("Fec_Ord")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaAprobAdm)
                    .HasColumnName("Fecha_Aprob_Adm")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaAprobCont)
                    .HasColumnName("Fecha_Aprob_Cont")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaDespacho)
                    .HasColumnName("Fecha_Despacho")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaEntrega)
                    .HasColumnName("Fecha_Entrega")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaFactura)
                    .HasColumnName("Fecha_Factura")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaPasada)
                    .HasColumnName("Fecha_Pasada")
                    .HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<OrdenesEtiquetas>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ORDENES ETIQUETAS");

                entity.Property(e => e.CantMill).HasColumnName("Cant_Mill");

                entity.Property(e => e.CodVend)
                    .HasColumnName("Cod_vend")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomCliente)
                    .HasColumnName("Nom_Cliente")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumCot)
                    .HasColumnName("Num_Cot")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ValorLista).HasColumnName("Valor_Lista");

                entity.Property(e => e.VentaUnit).HasColumnName("Venta_Unit");
            });

            modelBuilder.Entity<OrdenesMaracay>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ORDENES MARACAY");

                entity.Property(e => e.AprobAdmin)
                    .HasColumnName("Aprob_Admin")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AprobCob)
                    .HasColumnName("Aprob_Cob")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AprobCont)
                    .HasColumnName("Aprob_Cont")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AprobP)
                    .HasColumnName("Aprob_P")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClienteNuevo)
                    .HasColumnName("Cliente_Nuevo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodVend)
                    .HasColumnName("Cod_vend")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoClient)
                    .HasColumnName("Codigo_Client")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DirecEnt)
                    .HasColumnName("Direc_Ent")
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DirecFact)
                    .HasColumnName("Direc_Fact")
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Dolares)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Expr1).HasColumnType("smalldatetime");

                entity.Property(e => e.FecAproCob)
                    .HasColumnName("Fec_Apro_Cob")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecAproP)
                    .HasColumnName("Fec_Apro_P")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecCob)
                    .HasColumnName("Fec_Cob")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FecDol)
                    .HasColumnName("Fec_Dol")
                    .HasColumnType("datetime");

                entity.Property(e => e.FecGrab)
                    .HasColumnName("Fec_Grab")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecOrd)
                    .HasColumnName("Fec_Ord")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaAprobAdm)
                    .HasColumnName("Fecha_Aprob_Adm")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaAprobCont)
                    .HasColumnName("Fecha_Aprob_Cont")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaDespacho)
                    .HasColumnName("Fecha_Despacho")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaEntrega)
                    .HasColumnName("Fecha_Entrega")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaFactura)
                    .HasColumnName("Fecha_Factura")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaPasada)
                    .HasColumnName("Fecha_Pasada")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaRecibCliente)
                    .HasColumnName("Fecha_Recib_Cliente")
                    .HasMaxLength(26)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NoAsignacion)
                    .HasColumnName("No_Asignacion")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomCliente)
                    .HasColumnName("Nom_Cliente")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomEnt)
                    .HasColumnName("Nom_Ent")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NombFact)
                    .HasColumnName("Nomb_Fact")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumCot)
                    .HasColumnName("Num_Cot")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ObservCliente)
                    .HasColumnName("Observ_Cliente")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Oficina)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrdCompra)
                    .HasColumnName("Ord_compra")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Orden).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PtoReferencia)
                    .HasColumnName("Pto_Referencia")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RboCob)
                    .HasColumnName("Rbo_Cob")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RifEnt)
                    .HasColumnName("Rif_Ent")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RifFact)
                    .HasColumnName("Rif_Fact")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SiColetilla)
                    .HasColumnName("Si_Coletilla")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SiIndexacion)
                    .HasColumnName("Si_Indexacion")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SinRif)
                    .HasColumnName("Sin_Rif")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoPago)
                    .HasColumnName("Tipo_Pago")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Unidad)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<OrdenesPlanta>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ORDENES PLANTA");

                entity.Property(e => e.AprobAdmin)
                    .HasColumnName("Aprob_Admin")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AprobCob)
                    .HasColumnName("Aprob_Cob")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AprobCont)
                    .HasColumnName("Aprob_Cont")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AprobP)
                    .HasColumnName("Aprob_P")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClienteNuevo)
                    .HasColumnName("Cliente_Nuevo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodVend)
                    .HasColumnName("Cod_vend")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoClient)
                    .HasColumnName("Codigo_Client")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DirecEnt)
                    .HasColumnName("Direc_Ent")
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DirecFact)
                    .HasColumnName("Direc_Fact")
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Dolares)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FecAproCob)
                    .HasColumnName("Fec_Apro_Cob")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecAproP)
                    .HasColumnName("Fec_Apro_P")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecCob)
                    .HasColumnName("Fec_Cob")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FecDol)
                    .HasColumnName("Fec_Dol")
                    .HasColumnType("datetime");

                entity.Property(e => e.FecGrab)
                    .HasColumnName("Fec_Grab")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecOrd)
                    .HasColumnName("Fec_Ord")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaAprobAdm)
                    .HasColumnName("Fecha_Aprob_Adm")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaAprobCont)
                    .HasColumnName("Fecha_Aprob_Cont")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaDespacho)
                    .HasColumnName("Fecha_Despacho")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaEntrega)
                    .HasColumnName("Fecha_Entrega")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaFactura)
                    .HasColumnName("Fecha_Factura")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaPasada)
                    .HasColumnName("Fecha_Pasada")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaRecibCliente)
                    .HasColumnName("Fecha_Recib_Cliente")
                    .HasMaxLength(26)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NoAsignacion)
                    .HasColumnName("No_Asignacion")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomCliente)
                    .HasColumnName("Nom_Cliente")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomEnt)
                    .HasColumnName("Nom_Ent")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NombFact)
                    .HasColumnName("Nomb_Fact")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumCot)
                    .HasColumnName("Num_Cot")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ObservCliente)
                    .HasColumnName("Observ_Cliente")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Oficina)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrdCompra)
                    .HasColumnName("Ord_compra")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Orden).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PtoReferencia)
                    .HasColumnName("Pto_Referencia")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RboCob)
                    .HasColumnName("Rbo_Cob")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RifEnt)
                    .HasColumnName("Rif_Ent")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RifFact)
                    .HasColumnName("Rif_Fact")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SiColetilla)
                    .HasColumnName("Si_Coletilla")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SiIndexacion)
                    .HasColumnName("Si_Indexacion")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SinRif)
                    .HasColumnName("Sin_Rif")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoPago)
                    .HasColumnName("Tipo_Pago")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Unidad)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<OrdenesProcesadas>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ORDENES_PROCESADAS");

                entity.Property(e => e.AprobAdmin)
                    .HasColumnName("Aprob_Admin")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AprobCob)
                    .HasColumnName("Aprob_Cob")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AprobCont)
                    .HasColumnName("Aprob_Cont")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AprobP)
                    .HasColumnName("Aprob_P")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClienteNuevo)
                    .HasColumnName("Cliente_Nuevo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodVend)
                    .HasColumnName("Cod_vend")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoClient)
                    .HasColumnName("Codigo_Client")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Contacto)
                    .HasColumnName("contacto")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DescTipoPago)
                    .HasColumnName("Desc_Tipo_Pago")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DirecEnt)
                    .HasColumnName("Direc_Ent")
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DirecFact)
                    .HasColumnName("Direc_Fact")
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Dolares)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EnviarEmail)
                    .HasColumnName("Enviar_email")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EstatusCerrado)
                    .HasColumnName("Estatus_Cerrado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FecAproCob)
                    .HasColumnName("Fec_Apro_Cob")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecAproP)
                    .HasColumnName("Fec_Apro_P")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecCob)
                    .HasColumnName("Fec_Cob")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FecDol)
                    .HasColumnName("Fec_Dol")
                    .HasColumnType("datetime");

                entity.Property(e => e.FecGrab)
                    .HasColumnName("Fec_Grab")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecOrd)
                    .HasColumnName("Fec_Ord")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaAprobAdm)
                    .HasColumnName("Fecha_Aprob_Adm")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaAprobCont)
                    .HasColumnName("Fecha_Aprob_Cont")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaDespacho)
                    .HasColumnName("Fecha_Despacho")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaEntrega)
                    .HasColumnName("Fecha_Entrega")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaFactura)
                    .HasColumnName("Fecha_Factura")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaPasada)
                    .HasColumnName("Fecha_Pasada")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaRecibCliente)
                    .HasColumnName("Fecha_Recib_Cliente")
                    .HasMaxLength(26)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GrabCliente)
                    .HasColumnName("Grab_Cliente")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdDireccion)
                    .HasColumnName("Id_Direccion")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NoAsignacion)
                    .HasColumnName("No_Asignacion")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomCliente)
                    .HasColumnName("Nom_Cliente")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomEnt)
                    .HasColumnName("Nom_Ent")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NombFact)
                    .HasColumnName("Nomb_Fact")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumCot)
                    .HasColumnName("Num_Cot")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ObservCliente)
                    .HasColumnName("Observ_Cliente")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Oficina)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrdCompra)
                    .HasColumnName("Ord_compra")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Orden).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PtoReferencia)
                    .HasColumnName("Pto_Referencia")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RboCob)
                    .HasColumnName("Rbo_Cob")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RifEnt)
                    .HasColumnName("Rif_Ent")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RifFact)
                    .HasColumnName("Rif_Fact")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SiColetilla)
                    .HasColumnName("Si_Coletilla")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SiIndexacion)
                    .HasColumnName("Si_Indexacion")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SinRif)
                    .HasColumnName("Sin_Rif")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoPago)
                    .HasColumnName("Tipo_Pago")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Unidad)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<OrdenesRechazadas>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ORDENES RECHAZADAS");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EmailVendedor)
                    .HasColumnName("email_vendedor")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumCot)
                    .HasColumnName("Num_Cot")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<OrdenesRechazadasAdmin>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ORDENES RECHAZADAS ADMIN");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EmailAdmin)
                    .HasColumnName("email_Admin")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumCot)
                    .HasColumnName("Num_Cot")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<OrdenesRechazadasSup>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ORDENES RECHAZADAS SUP");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasColumnName("CODIGO")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Emailsup)
                    .HasColumnName("emailsup")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumCot)
                    .HasColumnName("Num_Cot")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Supervisor)
                    .HasColumnName("SUPERVISOR")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<OrdenesStockMesEnCurso>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ORDENES STOCK MES EN CURSO");

                entity.Property(e => e.AprobAdmin)
                    .HasColumnName("Aprob_Admin")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AprobCob)
                    .HasColumnName("Aprob_Cob")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AprobCont)
                    .HasColumnName("Aprob_Cont")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AprobP)
                    .HasColumnName("Aprob_P")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClienteNuevo)
                    .HasColumnName("Cliente_Nuevo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodVend)
                    .HasColumnName("Cod_vend")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoClient)
                    .HasColumnName("Codigo_Client")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DirecEnt)
                    .HasColumnName("Direc_Ent")
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DirecFact)
                    .HasColumnName("Direc_Fact")
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Dolares)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FecAproCob)
                    .HasColumnName("Fec_Apro_Cob")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecAproP)
                    .HasColumnName("Fec_Apro_P")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecCob)
                    .HasColumnName("Fec_Cob")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FecDol)
                    .HasColumnName("Fec_Dol")
                    .HasColumnType("datetime");

                entity.Property(e => e.FecGrab)
                    .HasColumnName("Fec_Grab")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecOrd)
                    .HasColumnName("Fec_Ord")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaAprobAdm)
                    .HasColumnName("Fecha_Aprob_Adm")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaAprobCont)
                    .HasColumnName("Fecha_Aprob_Cont")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaDespacho)
                    .HasColumnName("Fecha_Despacho")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaEntrega)
                    .HasColumnName("Fecha_Entrega")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaFactura)
                    .HasColumnName("Fecha_Factura")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaPasada)
                    .HasColumnName("Fecha_Pasada")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaRecibCliente)
                    .HasColumnName("Fecha_Recib_Cliente")
                    .HasMaxLength(26)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NoAsignacion)
                    .HasColumnName("No_Asignacion")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomCliente)
                    .HasColumnName("Nom_Cliente")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomEnt)
                    .HasColumnName("Nom_Ent")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NombFact)
                    .HasColumnName("Nomb_Fact")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumCot)
                    .HasColumnName("Num_Cot")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ObservCliente)
                    .HasColumnName("Observ_Cliente")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Oficina)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrdCompra)
                    .HasColumnName("Ord_compra")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Orden).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PrecDol).HasColumnName("Prec_Dol");

                entity.Property(e => e.PtoReferencia)
                    .HasColumnName("Pto_Referencia")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RboCob)
                    .HasColumnName("Rbo_Cob")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RifEnt)
                    .HasColumnName("Rif_Ent")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RifFact)
                    .HasColumnName("Rif_Fact")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SiColetilla)
                    .HasColumnName("Si_Coletilla")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SiIndexacion)
                    .HasColumnName("Si_Indexacion")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SinRif)
                    .HasColumnName("Sin_Rif")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoPago)
                    .HasColumnName("Tipo_Pago")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Unidad)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ValorLista).HasColumnName("Valor_Lista");

                entity.Property(e => e.VentaTot).HasColumnName("Venta_Tot");
            });

            modelBuilder.Entity<OrdenesValencia>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ORDENES VALENCIA");

                entity.Property(e => e.AprobAdmin)
                    .HasColumnName("Aprob_Admin")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AprobCob)
                    .HasColumnName("Aprob_Cob")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AprobCont)
                    .HasColumnName("Aprob_Cont")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AprobP)
                    .HasColumnName("Aprob_P")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClienteNuevo)
                    .HasColumnName("Cliente_Nuevo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodVend)
                    .HasColumnName("Cod_vend")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoClient)
                    .HasColumnName("Codigo_Client")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DirecEnt)
                    .HasColumnName("Direc_Ent")
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DirecFact)
                    .HasColumnName("Direc_Fact")
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Dolares)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Expr1).HasColumnType("smalldatetime");

                entity.Property(e => e.FecAproCob)
                    .HasColumnName("Fec_Apro_Cob")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecAproP)
                    .HasColumnName("Fec_Apro_P")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecCob)
                    .HasColumnName("Fec_Cob")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FecDol)
                    .HasColumnName("Fec_Dol")
                    .HasColumnType("datetime");

                entity.Property(e => e.FecGrab)
                    .HasColumnName("Fec_Grab")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecOrd)
                    .HasColumnName("Fec_Ord")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaAprobAdm)
                    .HasColumnName("Fecha_Aprob_Adm")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaAprobCont)
                    .HasColumnName("Fecha_Aprob_Cont")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaEntrega)
                    .HasColumnName("Fecha_Entrega")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.NoAsignacion)
                    .HasColumnName("No_Asignacion")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomCliente)
                    .HasColumnName("Nom_Cliente")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomEnt)
                    .HasColumnName("Nom_Ent")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NombFact)
                    .HasColumnName("Nomb_Fact")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumCot)
                    .HasColumnName("Num_Cot")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ObservCliente)
                    .HasColumnName("Observ_Cliente")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Oficina)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrdCompra)
                    .HasColumnName("Ord_compra")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Orden).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PtoReferencia)
                    .HasColumnName("Pto_Referencia")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RboCob)
                    .HasColumnName("Rbo_Cob")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RifEnt)
                    .HasColumnName("Rif_Ent")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RifFact)
                    .HasColumnName("Rif_Fact")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SiColetilla)
                    .HasColumnName("Si_Coletilla")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SiIndexacion)
                    .HasColumnName("Si_Indexacion")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SinRif)
                    .HasColumnName("Sin_Rif")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoPago)
                    .HasColumnName("Tipo_Pago")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Unidad)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<OrdenesVentas>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ORDENES VENTAS");

                entity.Property(e => e.AprobAdmin)
                    .HasColumnName("Aprob_Admin")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AprobCob)
                    .HasColumnName("Aprob_Cob")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AprobCont)
                    .HasColumnName("Aprob_Cont")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AprobP)
                    .HasColumnName("Aprob_P")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClienteNuevo)
                    .HasColumnName("Cliente_Nuevo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodVend)
                    .HasColumnName("Cod_vend")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoClient)
                    .HasColumnName("Codigo_Client")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DirecEnt)
                    .HasColumnName("Direc_Ent")
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DirecFact)
                    .HasColumnName("Direc_Fact")
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Dolares)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FecAproCob)
                    .HasColumnName("Fec_Apro_Cob")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecAproP)
                    .HasColumnName("Fec_Apro_P")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecCob)
                    .HasColumnName("Fec_Cob")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FecDol)
                    .HasColumnName("Fec_Dol")
                    .HasColumnType("datetime");

                entity.Property(e => e.FecGrab)
                    .HasColumnName("Fec_Grab")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecOrd)
                    .HasColumnName("Fec_Ord")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaAprobAdm)
                    .HasColumnName("Fecha_Aprob_Adm")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaAprobCont)
                    .HasColumnName("Fecha_Aprob_Cont")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaEntrega)
                    .HasColumnName("Fecha_Entrega")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.NoAsignacion)
                    .HasColumnName("No_Asignacion")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomCliente)
                    .HasColumnName("Nom_Cliente")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomEnt)
                    .HasColumnName("Nom_Ent")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NombFact)
                    .HasColumnName("Nomb_Fact")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumCot)
                    .HasColumnName("Num_Cot")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ObservCliente)
                    .HasColumnName("Observ_Cliente")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Oficina)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrdCompra)
                    .HasColumnName("Ord_compra")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Orden).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PtoReferencia)
                    .HasColumnName("Pto_Referencia")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RboCob)
                    .HasColumnName("Rbo_Cob")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RifEnt)
                    .HasColumnName("Rif_Ent")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RifFact)
                    .HasColumnName("Rif_Fact")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SiColetilla)
                    .HasColumnName("Si_Coletilla")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SiIndexacion)
                    .HasColumnName("Si_Indexacion")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SinRif)
                    .HasColumnName("Sin_Rif")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoPago)
                    .HasColumnName("Tipo_Pago")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Unidad)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Pqc01>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pqc01");

                entity.Property(e => e.Cajas).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CantDesp)
                    .HasColumnName("Cant_desp")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CantFormas)
                    .HasColumnName("Cant_Formas")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CantMill).HasColumnName("Cant_Mill");

                entity.Property(e => e.CantXCaja)
                    .HasColumnName("Cant_x_Caja")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Instrucciones)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ListaTot).HasColumnName("Lista_Tot");

                entity.Property(e => e.NumCot)
                    .HasColumnName("Num_Cot")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PrecDol).HasColumnName("Prec_Dol");

                entity.Property(e => e.Remision)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TotListDol).HasColumnName("Tot_List_Dol");

                entity.Property(e => e.TotVentDol).HasColumnName("Tot_Vent_Dol");

                entity.Property(e => e.UnidadCosteo)
                    .HasColumnName("Unidad_Costeo")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ValListaDol).HasColumnName("Val_Lista_Dol");

                entity.Property(e => e.ValorLista).HasColumnName("Valor_Lista");

                entity.Property(e => e.VentaTot).HasColumnName("Venta_Tot");

                entity.Property(e => e.VentaUnit).HasColumnName("Venta_Unit");
            });

            modelBuilder.Entity<PtoOrdaz>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PTO ORDAZ");

                entity.Property(e => e.AprobAdmin)
                    .HasColumnName("Aprob_Admin")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AprobCob)
                    .HasColumnName("Aprob_Cob")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AprobCont)
                    .HasColumnName("Aprob_Cont")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AprobP)
                    .HasColumnName("Aprob_P")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClienteNuevo)
                    .HasColumnName("Cliente_Nuevo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodVend)
                    .HasColumnName("Cod_vend")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoClient)
                    .HasColumnName("Codigo_Client")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DirecEnt)
                    .HasColumnName("Direc_Ent")
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DirecFact)
                    .HasColumnName("Direc_Fact")
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Dolares)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Expr1).HasColumnType("smalldatetime");

                entity.Property(e => e.FecAproCob)
                    .HasColumnName("Fec_Apro_Cob")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecAproP)
                    .HasColumnName("Fec_Apro_P")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecCob)
                    .HasColumnName("Fec_Cob")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FecDol)
                    .HasColumnName("Fec_Dol")
                    .HasColumnType("datetime");

                entity.Property(e => e.FecGrab)
                    .HasColumnName("Fec_Grab")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecOrd)
                    .HasColumnName("Fec_Ord")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaAprobAdm)
                    .HasColumnName("Fecha_Aprob_Adm")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaAprobCont)
                    .HasColumnName("Fecha_Aprob_Cont")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaEntrega)
                    .HasColumnName("Fecha_Entrega")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.NoAsignacion)
                    .HasColumnName("No_Asignacion")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomCliente)
                    .HasColumnName("Nom_Cliente")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomEnt)
                    .HasColumnName("Nom_Ent")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NombFact)
                    .HasColumnName("Nomb_Fact")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumCot)
                    .HasColumnName("Num_Cot")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ObservCliente)
                    .HasColumnName("Observ_Cliente")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Oficina)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrdCompra)
                    .HasColumnName("Ord_compra")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Orden).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PtoReferencia)
                    .HasColumnName("Pto_Referencia")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RboCob)
                    .HasColumnName("Rbo_Cob")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RifEnt)
                    .HasColumnName("Rif_Ent")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RifFact)
                    .HasColumnName("Rif_Fact")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SiColetilla)
                    .HasColumnName("Si_Coletilla")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SiIndexacion)
                    .HasColumnName("Si_Indexacion")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SinRif)
                    .HasColumnName("Sin_Rif")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoPago)
                    .HasColumnName("Tipo_Pago")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Unidad)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PuertoLaCruz>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PUERTO LA CRUZ");

                entity.Property(e => e.AprobAdmin)
                    .HasColumnName("Aprob_Admin")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AprobCob)
                    .HasColumnName("Aprob_Cob")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AprobCont)
                    .HasColumnName("Aprob_Cont")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AprobP)
                    .HasColumnName("Aprob_P")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClienteNuevo)
                    .HasColumnName("Cliente_Nuevo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodVend)
                    .HasColumnName("Cod_vend")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoClient)
                    .HasColumnName("Codigo_Client")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DirecEnt)
                    .HasColumnName("Direc_Ent")
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DirecFact)
                    .HasColumnName("Direc_Fact")
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Dolares)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Expr1).HasColumnType("smalldatetime");

                entity.Property(e => e.FecAproCob)
                    .HasColumnName("Fec_Apro_Cob")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecAproP)
                    .HasColumnName("Fec_Apro_P")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecCob)
                    .HasColumnName("Fec_Cob")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FecDol)
                    .HasColumnName("Fec_Dol")
                    .HasColumnType("datetime");

                entity.Property(e => e.FecGrab)
                    .HasColumnName("Fec_Grab")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecOrd)
                    .HasColumnName("Fec_Ord")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaAprobAdm)
                    .HasColumnName("Fecha_Aprob_Adm")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaAprobCont)
                    .HasColumnName("Fecha_Aprob_Cont")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaEntrega)
                    .HasColumnName("Fecha_Entrega")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.NoAsignacion)
                    .HasColumnName("No_Asignacion")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomCliente)
                    .HasColumnName("Nom_Cliente")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomEnt)
                    .HasColumnName("Nom_Ent")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NombFact)
                    .HasColumnName("Nomb_Fact")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumCot)
                    .HasColumnName("Num_Cot")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ObservCliente)
                    .HasColumnName("Observ_Cliente")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Oficina)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrdCompra)
                    .HasColumnName("Ord_compra")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Orden).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PtoReferencia)
                    .HasColumnName("Pto_Referencia")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RboCob)
                    .HasColumnName("Rbo_Cob")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RifEnt)
                    .HasColumnName("Rif_Ent")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RifFact)
                    .HasColumnName("Rif_Fact")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SiColetilla)
                    .HasColumnName("Si_Coletilla")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SiIndexacion)
                    .HasColumnName("Si_Indexacion")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SinRif)
                    .HasColumnName("Sin_Rif")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoPago)
                    .HasColumnName("Tipo_Pago")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Unidad)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<QueryDatosClienteAc01>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Query_DatosCliente_AC01");

                entity.Property(e => e.CodVend)
                    .HasColumnName("Cod_vend")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoClient)
                    .HasColumnName("Codigo_Client")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DescTipoPago)
                    .HasColumnName("Desc_Tipo_Pago")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.DirecEnt)
                    .HasColumnName("Direc_Ent")
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DirecFact)
                    .HasColumnName("Direc_Fact")
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FecGrab)
                    .HasColumnName("Fec_Grab")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecOrd)
                    .HasColumnName("Fec_Ord")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomCliente)
                    .HasColumnName("Nom_Cliente")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomEnt)
                    .HasColumnName("Nom_Ent")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomOficina)
                    .HasColumnName("NOM_OFICINA")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NombFact)
                    .HasColumnName("Nomb_Fact")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumCot)
                    .HasColumnName("Num_Cot")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ObserSaca)
                    .HasColumnName("obser_saca")
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ObservCliente)
                    .HasColumnName("Observ_Cliente")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Oficina)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RifEnt)
                    .HasColumnName("Rif_Ent")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RifFact)
                    .HasColumnName("Rif_Fact")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoPago)
                    .HasColumnName("Tipo_Pago")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<QueryDatosClienteAc02>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Query_DatosCliente_AC02");

                entity.Property(e => e.CodVend)
                    .HasColumnName("Cod_vend")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoClient)
                    .HasColumnName("Codigo_Client")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FecGrab)
                    .HasColumnName("Fec_Grab")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.NomCliente)
                    .HasColumnName("Nom_Cliente")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomOficina)
                    .IsRequired()
                    .HasColumnName("NOM_OFICINA")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NumCot)
                    .HasColumnName("Num_Cot")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Oficina)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<QueryEstadistAac01>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QUERY_ESTADIST_AAC_01");

                entity.Property(e => e.AprobCob1)
                    .HasColumnName("Aprob_Cob1")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FecAproCob)
                    .HasColumnName("Fec_Apro_Cob")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecGrab)
                    .HasColumnName("Fec_Grab")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.NumCot)
                    .HasColumnName("Num_Cot")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<QueryEstadistAac02>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QUERY_ESTADIST_AAC_02");

                entity.Property(e => e.AprobCxc)
                    .HasColumnName("Aprob_CXC")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FecAproCob)
                    .HasColumnName("Fec_Apro_Cob")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.NumCot)
                    .HasColumnName("Num_Cot")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<QueryEstadistAac03>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QUERY_ESTADIST_AAC_03");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FecAproCob)
                    .HasColumnName("Fec_Apro_Cob")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdMotivo)
                    .HasColumnName("ID_MOTIVO")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.NumCot)
                    .HasColumnName("Num_Cot")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<QueryEstatusOrd01>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Query_Estatus_Ord_01");

                entity.Property(e => e.CodigoEstatus)
                    .HasColumnName("Codigo_Estatus")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ReactivarCeos>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Orden)
                    .HasName("dep_ReactivarCeosorden");

                entity.Property(e => e.AnoReactivacion)
                    .HasColumnName("ano_reactivacion")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DiaReactivacion)
                    .HasColumnName("dia_reactivacion")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.MesReactivacion)
                    .HasColumnName("mes_reactivacion")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.MotivoReactivacion)
                    .HasColumnName("motivo_reactivacion")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumCot)
                    .HasColumnName("num_cot")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Orden)
                    .HasColumnName("orden")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Usuario)
                    .HasColumnName("usuario")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Rechazos>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.EstacionR)
                    .HasColumnName("ESTACION_R")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FecAproCob)
                    .HasColumnName("Fec_Apro_Cob")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecAproP)
                    .HasColumnName("Fec_Apro_P")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaAprobCont)
                    .HasColumnName("Fecha_Aprob_Cont")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaHora)
                    .HasColumnName("Fecha_Hora")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaPasada)
                    .HasColumnName("Fecha_Pasada")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Motivo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumCot)
                    .HasColumnName("Num_Cot")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoProduct)
                    .HasColumnName("TIPO_PRODUCT")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<RechazosA>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RECHAZOS_A");

                entity.Property(e => e.EstacionR)
                    .HasColumnName("ESTACION_R")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FecAproCob)
                    .HasColumnName("Fec_Apro_Cob")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecAproP)
                    .HasColumnName("Fec_Apro_P")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaAprobCont)
                    .HasColumnName("Fecha_Aprob_Cont")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaHora)
                    .HasColumnName("Fecha_Hora")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaPasada)
                    .HasColumnName("Fecha_Pasada")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Motivo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumCot)
                    .HasColumnName("Num_Cot")
                    .HasMaxLength(10);

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoProduct)
                    .HasColumnName("TIPO_PRODUCT")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<RechazosCeos>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RechazosCEOS");

                entity.Property(e => e.FechaHora)
                    .HasColumnName("Fecha_Hora")
                    .HasColumnType("datetime");

                entity.Property(e => e.Motivo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumCot)
                    .HasColumnName("Num_Cot")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Usuario)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<RevisionArchivosAdjuntos>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RevisionArchivosAdjuntos");

                entity.Property(e => e.Blob)
                    .HasColumnName("BLOB")
                    .HasColumnType("image");

                entity.Property(e => e.CodVend)
                    .HasColumnName("Cod_vend")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Codigo)
                    .HasColumnName("codigo")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoClient)
                    .HasColumnName("Codigo_Client")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.NomCliente)
                    .HasColumnName("Nom_Cliente")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<StatusOrdenesStock>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("STATUS ORDENES STOCK");

                entity.Property(e => e.CodVend)
                    .HasColumnName("Cod_vend")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FecAproCob)
                    .HasColumnName("Fec_Apro_Cob")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecAproP)
                    .HasColumnName("Fec_Apro_P")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecGrab)
                    .HasColumnName("Fec_Grab")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaAprobAdm)
                    .HasColumnName("Fecha_Aprob_Adm")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaDespacho)
                    .HasColumnName("Fecha_Despacho")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaFactura)
                    .HasColumnName("Fecha_Factura")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaRecibCliente)
                    .HasColumnName("Fecha_Recib_Cliente")
                    .HasMaxLength(26)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomCliente)
                    .HasColumnName("Nom_Cliente")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumCot)
                    .HasColumnName("Num_Cot")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Oficina)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TotalGeneralOrden01>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Total_General_Orden_01");

                entity.Property(e => e.TotalLista).HasColumnName("Total_Lista");

                entity.Property(e => e.TotalVenta).HasColumnName("Total_Venta");
            });

            modelBuilder.Entity<TotalXOrden>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Total_x_Orden");

                entity.Property(e => e.CodVend)
                    .HasColumnName("Cod_vend")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoClient)
                    .HasColumnName("Codigo_Client")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FecAproCob)
                    .HasColumnName("Fec_Apro_Cob")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecAproP)
                    .HasColumnName("Fec_Apro_P")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FecGrab)
                    .HasColumnName("Fec_Grab")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.NomCliente)
                    .HasColumnName("Nom_Cliente")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumCot)
                    .HasColumnName("Num_Cot")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TotalLista)
                    .HasColumnName("Total_Lista")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.TotalListaDol)
                    .HasColumnName("Total_Lista_dol")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.TotalMillares).HasColumnName("Total_Millares");

                entity.Property(e => e.TotalVenta)
                    .HasColumnName("Total_Venta")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.TotalVentaDol)
                    .HasColumnName("Total_Venta_dol")
                    .HasColumnType("decimal(38, 2)");
            });

            modelBuilder.Entity<TotalXOrden2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Total_x_Orden2");

                entity.Property(e => e.Cliente)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Conc).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Cotizacion).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Estado)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Grabada).HasColumnType("smalldatetime");

                entity.Property(e => e.Lista).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.ListaDol)
                    .HasColumnName("Lista dol")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Vend)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Venta).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.VentaDol)
                    .HasColumnName("Venta_dol")
                    .HasColumnType("decimal(38, 2)");
            });

            modelBuilder.Entity<VDiccionariocontratosstock>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_DICCIONARIOCONTRATOSSTOCK");

                entity.Property(e => e.Basededatos)
                    .IsRequired()
                    .HasColumnName("basededatos")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Field).HasMaxLength(128);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Length).HasColumnName("length");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(128);

                entity.Property(e => e.Smallid).HasColumnName("smallid");

                entity.Property(e => e.TipoTabla)
                    .IsRequired()
                    .HasColumnName("tipo_tabla")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Type).HasMaxLength(128);

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasColumnType("sql_variant");

                entity.Property(e => e.Xprec).HasColumnName("xprec");

                entity.Property(e => e.Xscale).HasColumnName("xscale");

                entity.Property(e => e.Xtype).HasColumnName("xtype");
            });

            modelBuilder.Entity<VInvetarioReconversion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_InvetarioReconversion");

                entity.Property(e => e.Basededatos)
                    .IsRequired()
                    .HasColumnName("basededatos")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Field).HasMaxLength(128);

                entity.Property(e => e.Length).HasColumnName("length");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(128);

                entity.Property(e => e.Type).HasMaxLength(128);

                entity.Property(e => e.Xprec).HasColumnName("xprec");

                entity.Property(e => e.Xscale).HasColumnName("xscale");
            });

            modelBuilder.Entity<View1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW1");

                entity.Property(e => e.Concesion).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.McAprob)
                    .HasColumnName("MC_Aprob")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.McFinan)
                    .HasColumnName("MC_Finan")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ValidaMc)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
