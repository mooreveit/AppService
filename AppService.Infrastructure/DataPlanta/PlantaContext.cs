using AppService.Core.EntitiesPlanta;
using Microsoft.EntityFrameworkCore;

namespace AppService.Infrastructure.DataPlanta
{
    public partial class PlantaContext : DbContext
    {
        public PlantaContext()
        {
        }

        public PlantaContext(DbContextOptions<PlantaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Auditorium> Auditoria { get; set; }
        public virtual DbSet<Backlog> Backlogs { get; set; }
        public virtual DbSet<BacklogEstacion> BacklogEstacions { get; set; }
        public virtual DbSet<BacklogFiscal> BacklogFiscals { get; set; }
        public virtual DbSet<BacklogFiscalNoFiscal> BacklogFiscalNoFiscals { get; set; }
        public virtual DbSet<CantColore> CantColores { get; set; }
        public virtual DbSet<Cashroll> Cashrolls { get; set; }
        public virtual DbSet<Ceosporfacturarcliente> Ceosporfacturarclientes { get; set; }
        public virtual DbSet<Ceosporfacturarclientedetalle> Ceosporfacturarclientedetalles { get; set; }
        public virtual DbSet<Civy004V> Civy004Vs { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Clientesenproceso> Clientesenprocesos { get; set; }
        public virtual DbSet<Combinacion> Combinacions { get; set; }
        public virtual DbSet<Cpry006> Cpry006s { get; set; }
        public virtual DbSet<Cpry010> Cpry010 { get; set; }
        public virtual DbSet<Cpry010Jjbk> Cpry010Jjbks { get; set; }
        public virtual DbSet<Cpry010fr> Cpry010frs { get; set; }
        public virtual DbSet<Cpry011> Cpry011 { get; set; }
        public virtual DbSet<Cpry012> Cpry012 { get; set; }
        public virtual DbSet<Cpry012antesReconversion> Cpry012antesReconversions { get; set; }
        public virtual DbSet<Cpry013> Cpry013 { get; set; }
        public virtual DbSet<Cpry014> Cpry014 { get; set; }
        public virtual DbSet<Cpry014a> Cpry014as { get; set; }
        public virtual DbSet<Cpry016> Cpry016s { get; set; }
        public virtual DbSet<Cpry024> Cpry024s { get; set; }
        public virtual DbSet<Cpry029> Cpry029s { get; set; }
        public virtual DbSet<Cpry030> Cpry030s { get; set; }
        public virtual DbSet<Cpry031> Cpry031s { get; set; }
        public virtual DbSet<Cpry033> Cpry033s { get; set; }
        public virtual DbSet<Cpry034> Cpry034s { get; set; }
        public virtual DbSet<Cpry035> Cpry035s { get; set; }
        public virtual DbSet<Cpry043> Cpry043s { get; set; }
        public virtual DbSet<Cpry047> Cpry047s { get; set; }
        public virtual DbSet<Cpry051> Cpry051s { get; set; }
        public virtual DbSet<Cpry054> Cpry054s { get; set; }
        public virtual DbSet<Cpry058> Cpry058s { get; set; }
        public virtual DbSet<Cpry059> Cpry059s { get; set; }
        public virtual DbSet<Cpry060> Cpry060s { get; set; }
        public virtual DbSet<Cpry061> Cpry061s { get; set; }
        public virtual DbSet<Cpry092> Cpry092s { get; set; }
        public virtual DbSet<Cpry093> Cpry093s { get; set; }
        public virtual DbSet<Cpry096> Cpry096s { get; set; }
        public virtual DbSet<Cpry097> Cpry097s { get; set; }
        public virtual DbSet<Cpry098> Cpry098s { get; set; }
        public virtual DbSet<Cpry099> Cpry099s { get; set; }
        public virtual DbSet<Cpry100> Cpry100s { get; set; }
        public virtual DbSet<Cpry102> Cpry102s { get; set; }
        public virtual DbSet<Cpry105> Cpry105s { get; set; }
        public virtual DbSet<Cpry106> Cpry106s { get; set; }
        public virtual DbSet<Cpry107> Cpry107s { get; set; }
        public virtual DbSet<Cpry108> Cpry108s { get; set; }
        public virtual DbSet<Cpry109> Cpry109s { get; set; }
        public virtual DbSet<Cpry110> Cpry110s { get; set; }
        public virtual DbSet<Cpry113a> Cpry113as { get; set; }
        public virtual DbSet<Cpry114> Cpry114s { get; set; }
        public virtual DbSet<Cpry178> Cpry178s { get; set; }
        public virtual DbSet<Cpry179> Cpry179s { get; set; }
        public virtual DbSet<Cpry180> Cpry180s { get; set; }
        public virtual DbSet<Cpry205> Cpry205s { get; set; }
        public virtual DbSet<Cpry216> Cpry216s { get; set; }
        public virtual DbSet<Cpry217> Cpry217s { get; set; }
        public virtual DbSet<Cpry218> Cpry218s { get; set; }
        public virtual DbSet<Cpry219> Cpry219s { get; set; }
        public virtual DbSet<Cpry220> Cpry220s { get; set; }
        public virtual DbSet<Cpry221> Cpry221s { get; set; }
        public virtual DbSet<Cpry223> Cpry223s { get; set; }
        public virtual DbSet<Cpry224> Cpry224s { get; set; }
        public virtual DbSet<Cpry225> Cpry225s { get; set; }
        public virtual DbSet<Cpry226> Cpry226s { get; set; }
        public virtual DbSet<Cpry227> Cpry227s { get; set; }
        public virtual DbSet<Cpry228> Cpry228s { get; set; }
        public virtual DbSet<Cpry229> Cpry229s { get; set; }
        public virtual DbSet<Cpry241> Cpry241s { get; set; }
        public virtual DbSet<Cpry250> Cpry250s { get; set; }
        public virtual DbSet<Crmy005> Crmy005s { get; set; }
        public virtual DbSet<Csmy003V> Csmy003Vs { get; set; }
        public virtual DbSet<Csmy019> Csmy019 { get; set; }
        public virtual DbSet<Csmy020> Csmy020 { get; set; }
        public virtual DbSet<Csmy021> Csmy021 { get; set; }
        public virtual DbSet<Csmy022> Csmy022 { get; set; }
        public virtual DbSet<Csmy022a> Csmy022as { get; set; }
        public virtual DbSet<Csmy023> Csmy023s { get; set; }
        public virtual DbSet<Csmy076> Csmy076s { get; set; }
        public virtual DbSet<Csmy078> Csmy078s { get; set; }
        public virtual DbSet<Csmy091> Csmy091s { get; set; }
        public virtual DbSet<DatosclienteV> DatosclienteVs { get; set; }
        public virtual DbSet<DatosproductosV> DatosproductosVs { get; set; }
        public virtual DbSet<DetalleBacklogEstacion> DetalleBacklogEstacions { get; set; }
        public virtual DbSet<DetalleBacklogEstacionEstimado> DetalleBacklogEstacionEstimados { get; set; }
        public virtual DbSet<DiasAdministradora> DiasAdministradoras { get; set; }
        public virtual DbSet<Dwtinta> Dwtintas { get; set; }
        public virtual DbSet<FechasErrada> FechasErradas { get; set; }
        public virtual DbSet<HistoricoAprobacionCredito> HistoricoAprobacionCreditos { get; set; }
        public virtual DbSet<Impporfacturarcliente> Impporfacturarclientes { get; set; }
        public virtual DbSet<InventarioEnProceso> InventarioEnProcesos { get; set; }
        public virtual DbSet<InventarioJobDirecto> InventarioJobDirectos { get; set; }
        public virtual DbSet<JobDepurar> JobDepurars { get; set; }
        public virtual DbSet<JobPasar> JobPasars { get; set; }
        public virtual DbSet<Orden> Ordens { get; set; }
        public virtual DbSet<Pendienteporclientesimpdetallado> Pendienteporclientesimpdetallados { get; set; }
        public virtual DbSet<Pendienteporclientesstockdetallado> Pendienteporclientesstockdetallados { get; set; }
        public virtual DbSet<Peps085c> Peps085cs { get; set; }
        public virtual DbSet<PorcTerminacion> PorcTerminacions { get; set; }
        public virtual DbSet<PostVentaImpreso> PostVentaImpresos { get; set; }
        public virtual DbSet<PostVentaStock> PostVentaStocks { get; set; }
        public virtual DbSet<Prensa> Prensas { get; set; }
        public virtual DbSet<ProgramacionDetalleBacklogEstacionEstimado> ProgramacionDetalleBacklogEstacionEstimados { get; set; }
        public virtual DbSet<Pruedol> Pruedols { get; set; }
        public virtual DbSet<QueryEstadisticas01> QueryEstadisticas01s { get; set; }
        public virtual DbSet<QueryOpCeo> QueryOpCeos { get; set; }
        public virtual DbSet<QueryOpImp> QueryOpImps { get; set; }
        public virtual DbSet<QueryOpStock> QueryOpStocks { get; set; }
        public virtual DbSet<SaldoTransxcliente> SaldoTransxclientes { get; set; }
        public virtual DbSet<Stockporfacturarcliente> Stockporfacturarclientes { get; set; }
        public virtual DbSet<Sysfile> Sysfiles { get; set; }
        public virtual DbSet<TctOficina> TctOficinas { get; set; }
        public virtual DbSet<Tctimpreso> Tctimpresos { get; set; }
        public virtual DbSet<Tctstock> Tctstocks { get; set; }
        public virtual DbSet<TintasComune> TintasComunes { get; set; }
        public virtual DbSet<TurnosPorPrensaEstimacion> TurnosPorPrensaEstimacions { get; set; }
        public virtual DbSet<UnidadTributariaB> UnidadTributariaBs { get; set; }
        public virtual DbSet<VBacklogCliente> VBacklogClientes { get; set; }
        public virtual DbSet<VBacklogGeneral> VBacklogGenerals { get; set; }
        public virtual DbSet<VBacklogPapel> VBacklogPapels { get; set; }
        public virtual DbSet<VCantidadOrdene> VCantidadOrdenes { get; set; }
        public virtual DbSet<VCaracteristica> VCaracteristicas { get; set; }
        public virtual DbSet<VDiccionarioplantum> VDiccionarioplanta { get; set; }
        public virtual DbSet<VEstadisticasPlaneacion> VEstadisticasPlaneacions { get; set; }
        public virtual DbSet<VFacturacionPendienteDePasaraJde> VFacturacionPendienteDePasaraJdes { get; set; }
        public virtual DbSet<VFechaEntrega> VFechaEntregas { get; set; }
        public virtual DbSet<VFiscalsinnumeracion> VFiscalsinnumeracions { get; set; }
        public virtual DbSet<VInvetarioReconversion> VInvetarioReconversions { get; set; }
        public virtual DbSet<VOrdene> VOrdenes { get; set; }
        public virtual DbSet<VOrdenesMala> VOrdenesMalas { get; set; }
        public virtual DbSet<VReorden> VReordens { get; set; }
        public virtual DbSet<VTintasordene> VTintasordenes { get; set; }
        public virtual DbSet<VistaCapacidadColectora> VistaCapacidadColectoras { get; set; }
        public virtual DbSet<VistaCapacidadPrensa> VistaCapacidadPrensas { get; set; }
        public virtual DbSet<VistaNproductosOrden> VistaNproductosOrdens { get; set; }
        public virtual DbSet<VistaResumenCp> VistaResumenCps { get; set; }
        public virtual DbSet<Wpry015> Wpry015s { get; set; }
        public virtual DbSet<Wpry032> Wpry032s { get; set; }
        public virtual DbSet<Wpry038> Wpry038s { get; set; }
        public virtual DbSet<Wpry039> Wpry039s { get; set; }
        public virtual DbSet<Wpry040> Wpry040s { get; set; }
        public virtual DbSet<Wpry041> Wpry041s { get; set; }
        public virtual DbSet<Wpry045> Wpry045s { get; set; }
        public virtual DbSet<Wpry053> Wpry053s { get; set; }
        public virtual DbSet<Wpry055> Wpry055s { get; set; }
        public virtual DbSet<Wpry062> Wpry062s { get; set; }
        public virtual DbSet<Wpry063> Wpry063s { get; set; }
        public virtual DbSet<Wpry064> Wpry064s { get; set; }
        public virtual DbSet<Wpry065> Wpry065s { get; set; }
        public virtual DbSet<Wpry066> Wpry066s { get; set; }
        public virtual DbSet<Wpry067> Wpry067s { get; set; }
        public virtual DbSet<Wpry069> Wpry069s { get; set; }
        public virtual DbSet<Wpry070> Wpry070s { get; set; }
        public virtual DbSet<Wpry071> Wpry071s { get; set; }
        public virtual DbSet<Wpry072> Wpry072s { get; set; }
        public virtual DbSet<Wpry073> Wpry073s { get; set; }
        public virtual DbSet<Wpry080> Wpry080s { get; set; }
        public virtual DbSet<Wpry083> Wpry083s { get; set; }
        public virtual DbSet<Wpry084> Wpry084s { get; set; }
        public virtual DbSet<Wpry090> Wpry090s { get; set; }
        public virtual DbSet<Wpry090tmp> Wpry090tmps { get; set; }
        public virtual DbSet<Wpry094> Wpry094s { get; set; }
        public virtual DbSet<Wpry152> Wpry152s { get; set; }
        public virtual DbSet<Wpry155> Wpry155s { get; set; }
        public virtual DbSet<Wpry181> Wpry181s { get; set; }
        public virtual DbSet<Wpry204> Wpry204s { get; set; }
        public virtual DbSet<Wpry206> Wpry206s { get; set; }
        public virtual DbSet<Wpry214> Wpry214s { get; set; }
        public virtual DbSet<Wpry215> Wpry215s { get; set; }
        public virtual DbSet<Wpry227> Wpry227s { get; set; }
        public virtual DbSet<Wtmy226> Wtmy226s { get; set; }
        public virtual DbSet<_92015157> _92015157s { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        //        optionsBuilder.UseSqlServer("Server=172.28.107.19\\FSVEMCYN03D;Database=Planta;User Id=userweb;Password=userweb2003;MultipleActiveResultSets=true");
        //    }
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Modern_Spanish_CI_AS");

            modelBuilder.Entity<Auditorium>(entity =>
            {
                entity.HasIndex(e => e.Orden, "dep_auditoriaorden");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Campo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estacion)
                    .HasMaxLength(30)
                    .HasColumnName("estacion")
                    .IsFixedLength();

                entity.Property(e => e.Fecha).HasColumnType("smalldatetime");

                entity.Property(e => e.Orden).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Tabla)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Usuario).HasMaxLength(50);

                entity.Property(e => e.ValorInical).HasMaxLength(50);

                entity.Property(e => e.Valorfinal).HasMaxLength(50);
            });

            modelBuilder.Entity<Backlog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Backlog");

                entity.HasIndex(e => e.Orden, "dep_backlogorden");

                entity.Property(e => e.CantFacturada)
                    .HasColumnType("decimal(30, 0)")
                    .HasColumnName("cant_facturada");

                entity.Property(e => e.CantPedida)
                    .HasColumnType("decimal(30, 0)")
                    .HasColumnName("cant_pedida");

                entity.Property(e => e.CantProg)
                    .HasColumnType("decimal(30, 0)")
                    .HasColumnName("cant_prog");

                entity.Property(e => e.Cantidadxcaja)
                    .HasColumnType("decimal(30, 0)")
                    .HasColumnName("cantidadxcaja");

                entity.Property(e => e.CodProducto)
                    .HasMaxLength(50)
                    .HasColumnName("cod_producto");

                entity.Property(e => e.CodResponsable)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("COD_RESPONSABLE");

                entity.Property(e => e.CodVendedor)
                    .HasMaxLength(50)
                    .HasColumnName("cod_vendedor");

                entity.Property(e => e.DescEstacion)
                    .HasMaxLength(50)
                    .HasColumnName("desc_estacion");

                entity.Property(e => e.DescLinea)
                    .HasMaxLength(50)
                    .HasColumnName("desc_linea");

                entity.Property(e => e.DescStatus)
                    .HasMaxLength(50)
                    .HasColumnName("desc_status");

                entity.Property(e => e.DescripcionProducto)
                    .HasMaxLength(50)
                    .HasColumnName("descripcion_producto");

                entity.Property(e => e.DiasDeAtrazo)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("dias_de_atrazo");

                entity.Property(e => e.FechaPedido)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_pedido");

                entity.Property(e => e.FechaProg)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_prog");

                entity.Property(e => e.NombreCliente)
                    .HasMaxLength(80)
                    .HasColumnName("nombre_cliente");

                entity.Property(e => e.NombreVendedor)
                    .HasMaxLength(50)
                    .HasColumnName("nombre_vendedor");

                entity.Property(e => e.NumeroPedido)
                    .HasMaxLength(50)
                    .HasColumnName("numero_pedido");

                entity.Property(e => e.Orden)
                    .HasMaxLength(50)
                    .HasColumnName("orden");

                entity.Property(e => e.RtotalVenta)
                    .HasColumnType("decimal(30, 0)")
                    .HasColumnName("RTotal_venta");

                entity.Property(e => e.TipoProducto)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("tipo_producto")
                    .IsFixedLength();

                entity.Property(e => e.TotalVenta)
                    .HasColumnType("decimal(30, 0)")
                    .HasColumnName("Total_venta");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(50)
                    .HasColumnName("usuario");
            });

            modelBuilder.Entity<BacklogEstacion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BacklogEstacion");

                entity.Property(e => e.Estacion)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaEntrega)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_entrega");

                entity.Property(e => e.JobId).HasColumnName("job_id");

                entity.Property(e => e.Orden).HasColumnName("orden");
            });

            modelBuilder.Entity<BacklogFiscal>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BacklogFiscal");

                entity.Property(e => e.Anulada)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ANULADA")
                    .IsFixedLength();

                entity.Property(e => e.CantOrdenada).HasColumnName("CANT_ORDENADA");

                entity.Property(e => e.ClaseOrden)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CLASE_ORDEN")
                    .IsFixedLength();

                entity.Property(e => e.DescProducto)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESC_PRODUCTO")
                    .IsFixedLength();

                entity.Property(e => e.FecRegVentas)
                    .HasColumnType("datetime")
                    .HasColumnName("FEC_REG_VENTAS");

                entity.Property(e => e.FechaEntrega)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ENTREGA");

                entity.Property(e => e.FechaOrdenAnterior)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ORDEN_ANTERIOR");

                entity.Property(e => e.FechaRet)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_RET");

                entity.Property(e => e.FechaUltimaFactura)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ULTIMA_FACTURA");

                entity.Property(e => e.Fiscal)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FISCAL")
                    .IsFixedLength();

                entity.Property(e => e.FlagAcabado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_ACABADO")
                    .IsFixedLength();

                entity.Property(e => e.FlagColectora)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_COLECTORA")
                    .IsFixedLength();

                entity.Property(e => e.FlagDiseno)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_DISENO")
                    .IsFixedLength();

                entity.Property(e => e.FlagEmbarque)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_EMBARQUE")
                    .IsFixedLength();

                entity.Property(e => e.FlagFoto)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_FOTO")
                    .IsFixedLength();

                entity.Property(e => e.FlagPlaneac)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_PLANEAC")
                    .IsFixedLength();

                entity.Property(e => e.FlagPrensas)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_PRENSAS")
                    .IsFixedLength();

                entity.Property(e => e.FlagRetenido)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_RETENIDO")
                    .IsFixedLength();

                entity.Property(e => e.JobId).HasColumnName("JOB_ID");

                entity.Property(e => e.NombreCliente)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_CLIENTE")
                    .IsFixedLength();

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.OrdenAnterior).HasColumnName("ORDEN_ANTERIOR");

                entity.Property(e => e.PorcMcFinansc)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("PORC_MC_FINANSC");

                entity.Property(e => e.PrecioVenta)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("PRECIO_VENTA");

                entity.Property(e => e.TotalVenta)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("TOTAL_VENTA");

                entity.Property(e => e.UsuarioRetiene)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_RETIENE");
            });

            modelBuilder.Entity<BacklogFiscalNoFiscal>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BacklogFiscalNoFiscal");

                entity.Property(e => e.Anulada)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ANULADA")
                    .IsFixedLength();

                entity.Property(e => e.CantOrdenada).HasColumnName("CANT_ORDENADA");

                entity.Property(e => e.ClaseOrden)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CLASE_ORDEN")
                    .IsFixedLength();

                entity.Property(e => e.DescProducto)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESC_PRODUCTO")
                    .IsFixedLength();

                entity.Property(e => e.FecRegVentas)
                    .HasColumnType("datetime")
                    .HasColumnName("FEC_REG_VENTAS");

                entity.Property(e => e.FechaEntrega)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ENTREGA");

                entity.Property(e => e.FechaOrdenAnterior)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ORDEN_ANTERIOR");

                entity.Property(e => e.FechaRet)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_RET");

                entity.Property(e => e.FechaUltimaFactura)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ULTIMA_FACTURA");

                entity.Property(e => e.Fiscal)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FISCAL")
                    .IsFixedLength();

                entity.Property(e => e.FlagAcabado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_ACABADO")
                    .IsFixedLength();

                entity.Property(e => e.FlagColectora)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_COLECTORA")
                    .IsFixedLength();

                entity.Property(e => e.FlagDiseno)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_DISENO")
                    .IsFixedLength();

                entity.Property(e => e.FlagEmbarque)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_EMBARQUE")
                    .IsFixedLength();

                entity.Property(e => e.FlagFoto)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_FOTO")
                    .IsFixedLength();

                entity.Property(e => e.FlagPlaneac)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_PLANEAC")
                    .IsFixedLength();

                entity.Property(e => e.FlagPrensas)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_PRENSAS")
                    .IsFixedLength();

                entity.Property(e => e.FlagRetenido)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_RETENIDO")
                    .IsFixedLength();

                entity.Property(e => e.JobId).HasColumnName("JOB_ID");

                entity.Property(e => e.NombreCliente)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_CLIENTE")
                    .IsFixedLength();

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.OrdenAnterior).HasColumnName("ORDEN_ANTERIOR");

                entity.Property(e => e.PorcMcFinansc)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("PORC_MC_FINANSC");

                entity.Property(e => e.PrecioVenta)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("PRECIO_VENTA");

                entity.Property(e => e.TotalVenta)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("TOTAL_VENTA");

                entity.Property(e => e.UsuarioRetiene)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_RETIENE");
            });

            modelBuilder.Entity<CantColore>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CantColores");

                entity.Property(e => e.Color).HasMaxLength(6);
            });

            modelBuilder.Entity<Cashroll>(entity =>
            {
                entity.HasKey(e => e.Recnum)
                    .HasName("CASHROLL_INDEX00");

                entity.ToTable("CASHROLL");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Texto)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("TEXTO")
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Ceosporfacturarcliente>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CEOSPORFACTURARCLIENTE");

                entity.Property(e => e.CodigoClient)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Codigo_Client")
                    .IsFixedLength();

                entity.Property(e => e.PorFacturar)
                    .HasColumnType("decimal(38, 2)")
                    .HasColumnName("POR_FACTURAR");
            });

            modelBuilder.Entity<Ceosporfacturarclientedetalle>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CEOSPORFACTURARCLIENTEDETALLE");

                entity.Property(e => e.AfectaBacklog)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Afecta_Backlog")
                    .IsFixedLength();

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoClient)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Codigo_Client")
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumCot)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Num_Cot");

                entity.Property(e => e.Orden)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("orden");

                entity.Property(e => e.VentaTot)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Venta_Tot");
            });

            modelBuilder.Entity<Civy004V>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CIVY004_V");

                entity.Property(e => e.CantidadXCaja)
                    .HasColumnType("decimal(6, 0)")
                    .HasColumnName("CANTIDAD_X_CAJA");

                entity.Property(e => e.Comprometido)
                    .HasColumnType("decimal(8, 0)")
                    .HasColumnName("COMPROMETIDO");

                entity.Property(e => e.CosPromActual)
                    .HasColumnType("decimal(12, 4)")
                    .HasColumnName("COS_PROM_ACTUAL");

                entity.Property(e => e.CostPromDolar)
                    .HasColumnType("decimal(12, 4)")
                    .HasColumnName("COST_PROM_DOLAR");

                entity.Property(e => e.CostoPromFin)
                    .HasColumnType("decimal(12, 4)")
                    .HasColumnName("COSTO_PROM_FIN");

                entity.Property(e => e.CostoPromIni)
                    .HasColumnType("decimal(12, 4)")
                    .HasColumnName("COSTO_PROM_INI");

                entity.Property(e => e.CostoPromReva)
                    .HasColumnType("decimal(12, 4)")
                    .HasColumnName("COSTO_PROM_REVA");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION")
                    .IsFixedLength();

                entity.Property(e => e.Eliminado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ELIMINADO")
                    .IsFixedLength();

                entity.Property(e => e.ExiInicioMes)
                    .HasColumnType("decimal(8, 0)")
                    .HasColumnName("EXI_INICIO_MES");

                entity.Property(e => e.ExisDiaAnter)
                    .HasColumnType("decimal(8, 0)")
                    .HasColumnName("EXIS_DIA_ANTER");

                entity.Property(e => e.ExisFinMes)
                    .HasColumnType("decimal(8, 0)")
                    .HasColumnName("EXIS_FIN_MES");

                entity.Property(e => e.ExistActual)
                    .HasColumnType("decimal(8, 0)")
                    .HasColumnName("EXIST_ACTUAL");

                entity.Property(e => e.ExistMaxima)
                    .HasColumnType("decimal(8, 0)")
                    .HasColumnName("EXIST_MAXIMA");

                entity.Property(e => e.ExistMinima)
                    .HasColumnType("decimal(8, 0)")
                    .HasColumnName("EXIST_MINIMA");

                entity.Property(e => e.FamiliaProduct)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("FAMILIA_PRODUCT")
                    .IsFixedLength();

                entity.Property(e => e.FechaUltCompr)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FECHA_ULT_COMPR");

                entity.Property(e => e.FechaUltFact)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FECHA_ULT_FACT");

                entity.Property(e => e.FlagObsoleto)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_OBSOLETO")
                    .IsFixedLength();

                entity.Property(e => e.ImpPorConsumo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IMP_POR_CONSUMO")
                    .IsFixedLength();

                entity.Property(e => e.LineaFamilia)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LINEA_FAMILIA")
                    .IsFixedLength();

                entity.Property(e => e.LineaProducto)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("LINEA_PRODUCTO")
                    .IsFixedLength();

                entity.Property(e => e.ListFinMes)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("LIST_FIN_MES");

                entity.Property(e => e.ListInicioMes)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("LIST_INICIO_MES");

                entity.Property(e => e.Medida)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MEDIDA")
                    .IsFixedLength();

                entity.Property(e => e.MetodoPrecio)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("METODO_PRECIO")
                    .IsFixedLength();

                entity.Property(e => e.OrigenProducto)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ORIGEN_PRODUCTO")
                    .IsFixedLength();

                entity.Property(e => e.OtroFactor)
                    .HasColumnType("decimal(6, 0)")
                    .HasColumnName("OTRO_FACTOR");

                entity.Property(e => e.Partes)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("PARTES");

                entity.Property(e => e.PorcCosto)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("PORC_COSTO");

                entity.Property(e => e.PorcMarkup)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("PORC_MARKUP");

                entity.Property(e => e.PreListActual)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("PRE_LIST_ACTUAL");

                entity.Property(e => e.PrecioSugerido)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PRECIO_SUGERIDO")
                    .IsFixedLength();

                entity.Property(e => e.Producto)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("PRODUCTO")
                    .IsFixedLength();

                entity.Property(e => e.Proveedor)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("PROVEEDOR");

                entity.Property(e => e.PtoReorden)
                    .HasColumnType("decimal(8, 0)")
                    .HasColumnName("PTO_REORDEN");

                entity.Property(e => e.RecordNumber)
                    .HasColumnType("decimal(8, 0)")
                    .HasColumnName("RECORD_NUMBER");

                entity.Property(e => e.SalidaPendien)
                    .HasColumnType("decimal(8, 0)")
                    .HasColumnName("SALIDA_PENDIEN");

                entity.Property(e => e.TipoPapel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_PAPEL")
                    .IsFixedLength();

                entity.Property(e => e.TipoProducto)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_PRODUCTO")
                    .IsFixedLength();

                entity.Property(e => e.UnidadCosteo)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("UNIDAD_COSTEO");

                entity.Property(e => e.ValExisActual)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("VAL_EXIS_ACTUAL");

                entity.Property(e => e.ValFinMes)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("VAL_FIN_MES");

                entity.Property(e => e.ValInicioMes)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("VAL_INICIO_MES");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.Cliente1);

                entity.Property(e => e.Cliente1)
                    .ValueGeneratedNever()
                    .HasColumnName("cliente");
            });

            modelBuilder.Entity<Clientesenproceso>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CLIENTESENPROCESO");

                entity.Property(e => e.Ceos)
                    .HasColumnType("decimal(38, 2)")
                    .HasColumnName("CEOS");

                entity.Property(e => e.CodJde).HasColumnName("cod_jde");

                entity.Property(e => e.CodJdePadre).HasColumnName("Cod_jdePadre");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DiasCalle).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.EdoCuentaTrans)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("EDO_CUENTA_TRANS");

                entity.Property(e => e.FacturacionPendienteContabilizar).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Imp)
                    .HasColumnType("numeric(38, 6)")
                    .HasColumnName("IMP");

                entity.Property(e => e.Inactivo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LimiteCreditoBs)
                    .HasColumnType("numeric(35, 5)")
                    .HasColumnName("LIMITE_CREDITO_BS");

                entity.Property(e => e.LimiteCreditoUt)
                    .HasColumnType("numeric(16, 2)")
                    .HasColumnName("LIMITE_CREDITO_UT");

                entity.Property(e => e.LimiteVsSaldo).HasColumnType("numeric(36, 5)");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PorFacturar)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("POR_FACTURAR");

                entity.Property(e => e.SaldoLimiteCred)
                    .HasColumnType("numeric(36, 5)")
                    .HasColumnName("SALDO_LIMITE_CRED");

                entity.Property(e => e.Stock)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("STOCK");

                entity.Property(e => e.UtBs)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("UT_BS");
            });

            modelBuilder.Entity<Combinacion>(entity =>
            {
                entity.ToTable("Combinacion");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CantTintas).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Combinacion1)
                    .HasMaxLength(50)
                    .HasColumnName("Combinacion");

                entity.Property(e => e.Comun)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Cpry006>(entity =>
            {
                entity.HasKey(e => e.CentroCost)
                    .HasName("CPRY006_INDEX01");

                entity.ToTable("CPRY006");

                entity.HasIndex(e => e.Recnum, "CPRY006_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.CentroCost)
                    .ValueGeneratedNever()
                    .HasColumnName("CENTRO_COST");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ProcesoTermina).HasColumnName("PROCESO_TERMINA");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.TiempoProceso).HasColumnName("TIEMPO_PROCESO");
            });

            modelBuilder.Entity<Cpry010>(entity =>
            {
                entity.HasKey(e => e.JobId)
                    .HasName("CPRY010_INDEX01");

                entity.ToTable("CPRY010");

                entity.HasIndex(e => e.Recnum, "CPRY010_INDEX00")
                    .IsUnique()
                    .HasFillFactor(70);

                entity.HasIndex(e => new { e.Pais, e.LineaProduccio, e.JobId }, "CPRY010_INDEX02")
                    .IsUnique()
                    .HasFillFactor(70);

                entity.HasIndex(e => new { e.SupervVentas, e.Vendedor, e.JobId }, "CPRY010_INDEX03")
                    .IsUnique()
                    .HasFillFactor(70);

                entity.HasIndex(e => new { e.NoPrensa, e.JobId }, "CPRY010_INDEX04")
                    .IsUnique()
                    .HasFillFactor(70);

                entity.HasIndex(e => new { e.NoColectora, e.JobId }, "CPRY010_INDEX05")
                    .IsUnique()
                    .HasFillFactor(70);

                entity.HasIndex(e => new { e.FechaFactura, e.JobId }, "CPRY010_INDEX06")
                    .IsUnique()
                    .HasFillFactor(70);

                entity.HasIndex(e => new { e.Vendedor, e.JobId }, "CPRY010_INDEX07")
                    .IsUnique()
                    .HasFillFactor(70);

                entity.HasIndex(e => new { e.Orden, e.JobId }, "CPRY010_INDEX08")
                    .IsUnique()
                    .HasFillFactor(70);

                entity.HasIndex(e => new { e.TipoOrden, e.Orden, e.JobId }, "CPRY010_INDEX09")
                    .IsUnique()
                    .HasFillFactor(70);

                entity.HasIndex(e => new { e.Cliente, e.JobId }, "CPRY010_INDEX10")
                    .IsUnique()
                    .HasFillFactor(70);

                entity.HasIndex(e => new { e.FechaEntrega, e.Recnum }, "CPRY010_INDEX11")
                    .IsUnique()
                    .HasFillFactor(70);

                entity.HasIndex(e => new { e.FechasrPrensas, e.Orden, e.Recnum }, "CPRY010_INDEX12")
                    .IsUnique()
                    .HasFillFactor(70);

                entity.HasIndex(e => new { e.Orden, e.FechaEntrega, e.JobId }, "CPRY010_INDEX13")
                    .IsUnique()
                    .HasFillFactor(70);

                entity.HasIndex(e => e.Recnum, "IX_CPRY010")
                    .HasFillFactor(70);

                entity.HasIndex(e => e.Cliente, "IX_CPRY010_1");

                entity.HasIndex(e => e.Orden, "dep_cpry010orden");

                entity.Property(e => e.JobId)
                    .ValueGeneratedNever()
                    .HasColumnName("JOB_ID");

                entity.Property(e => e.ArregloReopera).HasColumnName("ARREGLO_REOPERA");

                entity.Property(e => e.CantAProducir).HasColumnName("CANT_A_PRODUCIR");

                entity.Property(e => e.CantAcabado)
                    .HasColumnName("CANT_ACABADO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CantArte)
                    .HasColumnName("CANT_ARTE")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CantBcs)
                    .HasColumnName("CANT_BCS")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CantCajaUtili).HasColumnName("CANT_CAJA_UTILI");

                entity.Property(e => e.CantColect)
                    .HasColumnName("CANT_COLECT")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CantEmbarque)
                    .HasColumnName("CANT_EMBARQUE")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CantFactura)
                    .HasColumnName("CANT_FACTURA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CantFoto)
                    .HasColumnName("CANT_FOTO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CantPlan)
                    .HasColumnName("CANT_PLAN")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CantPrensa)
                    .HasColumnName("CANT_PRENSA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CantProgramada).HasColumnName("CANT_PROGRAMADA");

                entity.Property(e => e.CantidRemanent).HasColumnName("CANTID_REMANENT");

                entity.Property(e => e.CausaReoperaci).HasColumnName("CAUSA_REOPERACI");

                entity.Property(e => e.Cliente).HasColumnName("CLIENTE");

                entity.Property(e => e.CodBacklogRet).HasColumnName("COD_BACKLOG_RET");

                entity.Property(e => e.CodigoCaja)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO_CAJA")
                    .IsFixedLength();

                entity.Property(e => e.Combinacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COMBINACION");

                entity.Property(e => e.Cotizacion)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("COTIZACION")
                    .IsFixedLength();

                entity.Property(e => e.CtdEntregada).HasColumnName("CTD_ENTREGADA");

                entity.Property(e => e.CtdEntregadaini)
                    .HasColumnName("CTD_ENTREGADAINI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CtdFactAdelan).HasColumnName("CTD_FACT_ADELAN");

                entity.Property(e => e.DiasAcabado).HasColumnName("DIAS_ACABADO");

                entity.Property(e => e.DiasArte).HasColumnName("DIAS_ARTE");

                entity.Property(e => e.DiasBcs).HasColumnName("DIAS_BCS");

                entity.Property(e => e.DiasColectora).HasColumnName("DIAS_COLECTORA");

                entity.Property(e => e.DiasEmbarque).HasColumnName("DIAS_EMBARQUE");

                entity.Property(e => e.DiasFoto).HasColumnName("DIAS_FOTO");

                entity.Property(e => e.DiasPlaneacion).HasColumnName("DIAS_PLANEACION");

                entity.Property(e => e.DiasPrensa).HasColumnName("DIAS_PRENSA");

                entity.Property(e => e.DiasRetAcabad).HasColumnName("DIAS_RET_ACABAD");

                entity.Property(e => e.DiasRetArte).HasColumnName("DIAS_RET_ARTE");

                entity.Property(e => e.DiasRetBcs).HasColumnName("DIAS_RET_BCS");

                entity.Property(e => e.DiasRetColect).HasColumnName("DIAS_RET_COLECT");

                entity.Property(e => e.DiasRetEmbarq).HasColumnName("DIAS_RET_EMBARQ");

                entity.Property(e => e.DiasRetFoto).HasColumnName("DIAS_RET_FOTO");

                entity.Property(e => e.DiasRetPlanea).HasColumnName("DIAS_RET_PLANEA");

                entity.Property(e => e.DiasRetPrensa).HasColumnName("DIAS_RET_PRENSA");

                entity.Property(e => e.Elimina)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ELIMINA")
                    .IsFixedLength();

                entity.Property(e => e.FecRealOrden)
                    .HasColumnType("datetime")
                    .HasColumnName("FEC_REAL_ORDEN");

                entity.Property(e => e.FechaArchivo)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ARCHIVO");

                entity.Property(e => e.FechaEntrega)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ENTREGA")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.FechaFactura)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_FACTURA")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.FechaOrdEntry)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ORD_ENTRY");

                entity.Property(e => e.FechaRet)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_RET");

                entity.Property(e => e.FechaRetenido)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_RETENIDO");

                entity.Property(e => e.FechaeEstAcab)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAE_EST_ACAB");

                entity.Property(e => e.FechaeEstBcs)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAE_EST_BCS");

                entity.Property(e => e.FechaeEstCole)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAE_EST_COLE");

                entity.Property(e => e.FechaeEstDise)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAE_EST_DISE");

                entity.Property(e => e.FechaeEstEmba)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAE_EST_EMBA");

                entity.Property(e => e.FechaeEstEntr)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAE_EST_ENTR");

                entity.Property(e => e.FechaeEstFact)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAE_EST_FACT");

                entity.Property(e => e.FechaeEstNega)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAE_EST_NEGA");

                entity.Property(e => e.FechaeEstPren)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAE_EST_PREN");

                entity.Property(e => e.FechaerAcabado)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAER_ACABADO");

                entity.Property(e => e.FechaerBcs)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAER_BCS");

                entity.Property(e => e.FechaerColecto)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAER_COLECTO");

                entity.Property(e => e.FechaerDiseno)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAER_DISENO");

                entity.Property(e => e.FechaerEmbarqu)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAER_EMBARQU");

                entity.Property(e => e.FechaerFactura)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAER_FACTURA");

                entity.Property(e => e.FechaerNegativ)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAER_NEGATIV");

                entity.Property(e => e.FechaerPrelim)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAER_PRELIM");

                entity.Property(e => e.FechaerPrensas)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAER_PRENSAS");

                entity.Property(e => e.FechasEstAcab)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAS_EST_ACAB");

                entity.Property(e => e.FechasEstBcs)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAS_EST_BCS");

                entity.Property(e => e.FechasEstCole)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAS_EST_COLE");

                entity.Property(e => e.FechasEstDise)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAS_EST_DISE");

                entity.Property(e => e.FechasEstEmba)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAS_EST_EMBA");

                entity.Property(e => e.FechasEstFact)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAS_EST_FACT");

                entity.Property(e => e.FechasEstNega)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAS_EST_NEGA");

                entity.Property(e => e.FechasEstPrel)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAS_EST_PREL");

                entity.Property(e => e.FechasEstPren)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAS_EST_PREN");

                entity.Property(e => e.FechasrAcabado)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHASR_ACABADO");

                entity.Property(e => e.FechasrBcs)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHASR_BCS");

                entity.Property(e => e.FechasrColecto)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHASR_COLECTO");

                entity.Property(e => e.FechasrDiseno)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHASR_DISENO");

                entity.Property(e => e.FechasrEmbarqu)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHASR_EMBARQU");

                entity.Property(e => e.FechasrNegativ)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHASR_NEGATIV");

                entity.Property(e => e.FechasrPrelim)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHASR_PRELIM");

                entity.Property(e => e.FechasrPrensas)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHASR_PRENSAS")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.Fiscal)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FISCAL")
                    .IsFixedLength();

                entity.Property(e => e.FlagAcabado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_ACABADO")
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.FlagBcs)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_BCS")
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.FlagColectora)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_COLECTORA")
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.FlagDiseno)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_DISENO")
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.FlagEmbarque)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_EMBARQUE")
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.FlagEtiqImpre)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_ETIQ_IMPRE")
                    .IsFixedLength();

                entity.Property(e => e.FlagFoto)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_FOTO")
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.FlagPlaneac)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_PLANEAC")
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.FlagPlaneado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_PLANEADO")
                    .IsFixedLength();

                entity.Property(e => e.FlagPrensas)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_PRENSAS")
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.FlagRetenido)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_RETENIDO")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.FlagSoportev)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_SOPORTEV")
                    .IsFixedLength();

                entity.Property(e => e.FormInicial).HasColumnName("FORM_INICIAL");

                entity.Property(e => e.FormPorCaja).HasColumnName("FORM_POR_CAJA");

                entity.Property(e => e.JobAutomatico)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("JOB_AUTOMATICO")
                    .IsFixedLength();

                entity.Property(e => e.JobRestar).HasColumnName("JOB_RESTAR");

                entity.Property(e => e.LineaProduccio).HasColumnName("LINEA_PRODUCCIO");

                entity.Property(e => e.Lista)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("LISTA");

                entity.Property(e => e.LugarProducir)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("LUGAR_PRODUCIR")
                    .IsFixedLength();

                entity.Property(e => e.NoAnulacion).HasColumnName("NO_ANULACION");

                entity.Property(e => e.NoColectora).HasColumnName("NO_COLECTORA");

                entity.Property(e => e.NoPrensa).HasColumnName("NO_PRENSA");

                entity.Property(e => e.NuevaCtd).HasColumnName("NUEVA_CTD");

                entity.Property(e => e.NuevaFechaEnt)
                    .HasColumnType("datetime")
                    .HasColumnName("NUEVA_FECHA_ENT");

                entity.Property(e => e.NumeroFactura).HasColumnName("NUMERO_FACTURA");

                entity.Property(e => e.Obser)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("OBSER")
                    .IsFixedLength();

                entity.Property(e => e.Observaciones)
                    .HasColumnType("text")
                    .HasColumnName("OBSERVACIONES");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.OrigenReoperac)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ORIGEN_REOPERAC")
                    .IsFixedLength();

                entity.Property(e => e.Pais).HasColumnName("PAIS");

                entity.Property(e => e.PartesAReope).HasColumnName("PARTES_A_REOPE");

                entity.Property(e => e.PasoSql)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PASO_SQL")
                    .IsFixedLength();

                entity.Property(e => e.PiesArteCole)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("PIES_ARTE_COLE");

                entity.Property(e => e.PiesArtePren)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("PIES_ARTE_PREN");

                entity.Property(e => e.PiesColect)
                    .HasColumnType("decimal(16, 4)")
                    .HasColumnName("PIES_COLECT");

                entity.Property(e => e.PiesFotoCole)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("PIES_FOTO_COLE");

                entity.Property(e => e.PiesFotoPren)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("PIES_FOTO_PREN");

                entity.Property(e => e.PiesPlanCole)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("PIES_PLAN_COLE");

                entity.Property(e => e.PiesPlanPren)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("PIES_PLAN_PREN");

                entity.Property(e => e.PiesPrensCole)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("PIES_PRENS_COLE");

                entity.Property(e => e.PiesPrensPren)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("PIES_PRENS_PREN");

                entity.Property(e => e.PiesPrensa)
                    .HasColumnType("decimal(16, 4)")
                    .HasColumnName("PIES_PRENSA");

                entity.Property(e => e.PrecioLista)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("PRECIO_LISTA");

                entity.Property(e => e.PrecioVenta)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("PRECIO_VENTA");

                entity.Property(e => e.ProduInmediata)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PRODU_INMEDIATA")
                    .IsFixedLength();

                entity.Property(e => e.Programada)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PROGRAMADA")
                    .IsFixedLength();

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Remanente)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REMANENTE")
                    .IsFixedLength();

                entity.Property(e => e.ReopSolicPor).HasColumnName("REOP_SOLIC_POR");

                entity.Property(e => e.ReoperacionNo).HasColumnName("REOPERACION_NO");

                entity.Property(e => e.ResponsaReoper)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("RESPONSA_REOPER")
                    .IsFixedLength();

                entity.Property(e => e.Rlista)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RLISTA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Rpreciolista)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RPRECIOLISTA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Rprecioventa)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RPRECIOVENTA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Rventa)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RVENTA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.StatusDelJob)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS_DEL_JOB")
                    .IsFixedLength();

                entity.Property(e => e.SupervVentas)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SUPERV_VENTAS")
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.TipoCaja).HasColumnName("TIPO_CAJA");

                entity.Property(e => e.TipoOrden).HasColumnName("TIPO_ORDEN");

                entity.Property(e => e.TipoProduccion)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_PRODUCCION")
                    .IsFixedLength();

                entity.Property(e => e.UsuarioRet)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_RET");

                entity.Property(e => e.Vendedor)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("VENDEDOR")
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.Venta)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("VENTA");
            });

            modelBuilder.Entity<Cpry010Jjbk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cpry010JJBK");

                entity.Property(e => e.ArregloReopera).HasColumnName("ARREGLO_REOPERA");

                entity.Property(e => e.CantAProducir).HasColumnName("CANT_A_PRODUCIR");

                entity.Property(e => e.CantAcabado).HasColumnName("CANT_ACABADO");

                entity.Property(e => e.CantArte).HasColumnName("CANT_ARTE");

                entity.Property(e => e.CantBcs).HasColumnName("CANT_BCS");

                entity.Property(e => e.CantCajaUtili).HasColumnName("CANT_CAJA_UTILI");

                entity.Property(e => e.CantColect).HasColumnName("CANT_COLECT");

                entity.Property(e => e.CantEmbarque).HasColumnName("CANT_EMBARQUE");

                entity.Property(e => e.CantFactura).HasColumnName("CANT_FACTURA");

                entity.Property(e => e.CantFoto).HasColumnName("CANT_FOTO");

                entity.Property(e => e.CantPlan).HasColumnName("CANT_PLAN");

                entity.Property(e => e.CantPrensa).HasColumnName("CANT_PRENSA");

                entity.Property(e => e.CantProgramada).HasColumnName("CANT_PROGRAMADA");

                entity.Property(e => e.CantidRemanent).HasColumnName("CANTID_REMANENT");

                entity.Property(e => e.CausaReoperaci).HasColumnName("CAUSA_REOPERACI");

                entity.Property(e => e.Cliente).HasColumnName("CLIENTE");

                entity.Property(e => e.CodBacklogRet).HasColumnName("COD_BACKLOG_RET");

                entity.Property(e => e.CodigoCaja)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO_CAJA")
                    .IsFixedLength();

                entity.Property(e => e.Combinacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COMBINACION");

                entity.Property(e => e.Cotizacion)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("COTIZACION")
                    .IsFixedLength();

                entity.Property(e => e.CtdEntregada).HasColumnName("CTD_ENTREGADA");

                entity.Property(e => e.CtdEntregadaini).HasColumnName("CTD_ENTREGADAINI");

                entity.Property(e => e.CtdFactAdelan).HasColumnName("CTD_FACT_ADELAN");

                entity.Property(e => e.DiasAcabado).HasColumnName("DIAS_ACABADO");

                entity.Property(e => e.DiasArte).HasColumnName("DIAS_ARTE");

                entity.Property(e => e.DiasBcs).HasColumnName("DIAS_BCS");

                entity.Property(e => e.DiasColectora).HasColumnName("DIAS_COLECTORA");

                entity.Property(e => e.DiasEmbarque).HasColumnName("DIAS_EMBARQUE");

                entity.Property(e => e.DiasFoto).HasColumnName("DIAS_FOTO");

                entity.Property(e => e.DiasPlaneacion).HasColumnName("DIAS_PLANEACION");

                entity.Property(e => e.DiasPrensa).HasColumnName("DIAS_PRENSA");

                entity.Property(e => e.DiasRetAcabad).HasColumnName("DIAS_RET_ACABAD");

                entity.Property(e => e.DiasRetArte).HasColumnName("DIAS_RET_ARTE");

                entity.Property(e => e.DiasRetBcs).HasColumnName("DIAS_RET_BCS");

                entity.Property(e => e.DiasRetColect).HasColumnName("DIAS_RET_COLECT");

                entity.Property(e => e.DiasRetEmbarq).HasColumnName("DIAS_RET_EMBARQ");

                entity.Property(e => e.DiasRetFoto).HasColumnName("DIAS_RET_FOTO");

                entity.Property(e => e.DiasRetPlanea).HasColumnName("DIAS_RET_PLANEA");

                entity.Property(e => e.DiasRetPrensa).HasColumnName("DIAS_RET_PRENSA");

                entity.Property(e => e.Elimina)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ELIMINA")
                    .IsFixedLength();

                entity.Property(e => e.FecRealOrden)
                    .HasColumnType("datetime")
                    .HasColumnName("FEC_REAL_ORDEN");

                entity.Property(e => e.FechaArchivo)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ARCHIVO");

                entity.Property(e => e.FechaEntrega)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ENTREGA");

                entity.Property(e => e.FechaFactura)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_FACTURA");

                entity.Property(e => e.FechaOrdEntry)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ORD_ENTRY");

                entity.Property(e => e.FechaRet)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_RET");

                entity.Property(e => e.FechaRetenido)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_RETENIDO");

                entity.Property(e => e.FechaeEstAcab)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAE_EST_ACAB");

                entity.Property(e => e.FechaeEstBcs)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAE_EST_BCS");

                entity.Property(e => e.FechaeEstCole)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAE_EST_COLE");

                entity.Property(e => e.FechaeEstDise)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAE_EST_DISE");

                entity.Property(e => e.FechaeEstEmba)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAE_EST_EMBA");

                entity.Property(e => e.FechaeEstEntr)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAE_EST_ENTR");

                entity.Property(e => e.FechaeEstFact)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAE_EST_FACT");

                entity.Property(e => e.FechaeEstNega)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAE_EST_NEGA");

                entity.Property(e => e.FechaeEstPren)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAE_EST_PREN");

                entity.Property(e => e.FechaerAcabado)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAER_ACABADO");

                entity.Property(e => e.FechaerBcs)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAER_BCS");

                entity.Property(e => e.FechaerColecto)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAER_COLECTO");

                entity.Property(e => e.FechaerDiseno)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAER_DISENO");

                entity.Property(e => e.FechaerEmbarqu)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAER_EMBARQU");

                entity.Property(e => e.FechaerFactura)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAER_FACTURA");

                entity.Property(e => e.FechaerNegativ)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAER_NEGATIV");

                entity.Property(e => e.FechaerPrelim)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAER_PRELIM");

                entity.Property(e => e.FechaerPrensas)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAER_PRENSAS");

                entity.Property(e => e.FechasEstAcab)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAS_EST_ACAB");

                entity.Property(e => e.FechasEstBcs)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAS_EST_BCS");

                entity.Property(e => e.FechasEstCole)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAS_EST_COLE");

                entity.Property(e => e.FechasEstDise)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAS_EST_DISE");

                entity.Property(e => e.FechasEstEmba)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAS_EST_EMBA");

                entity.Property(e => e.FechasEstFact)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAS_EST_FACT");

                entity.Property(e => e.FechasEstNega)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAS_EST_NEGA");

                entity.Property(e => e.FechasEstPrel)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAS_EST_PREL");

                entity.Property(e => e.FechasEstPren)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAS_EST_PREN");

                entity.Property(e => e.FechasrAcabado)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHASR_ACABADO");

                entity.Property(e => e.FechasrBcs)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHASR_BCS");

                entity.Property(e => e.FechasrColecto)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHASR_COLECTO");

                entity.Property(e => e.FechasrDiseno)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHASR_DISENO");

                entity.Property(e => e.FechasrEmbarqu)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHASR_EMBARQU");

                entity.Property(e => e.FechasrNegativ)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHASR_NEGATIV");

                entity.Property(e => e.FechasrPrelim)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHASR_PRELIM");

                entity.Property(e => e.FechasrPrensas)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHASR_PRENSAS");

                entity.Property(e => e.Fiscal)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FISCAL")
                    .IsFixedLength();

                entity.Property(e => e.FlagAcabado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_ACABADO")
                    .IsFixedLength();

                entity.Property(e => e.FlagBcs)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_BCS")
                    .IsFixedLength();

                entity.Property(e => e.FlagColectora)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_COLECTORA")
                    .IsFixedLength();

                entity.Property(e => e.FlagDiseno)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_DISENO")
                    .IsFixedLength();

                entity.Property(e => e.FlagEmbarque)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_EMBARQUE")
                    .IsFixedLength();

                entity.Property(e => e.FlagEtiqImpre)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_ETIQ_IMPRE")
                    .IsFixedLength();

                entity.Property(e => e.FlagFoto)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_FOTO")
                    .IsFixedLength();

                entity.Property(e => e.FlagPlaneac)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_PLANEAC")
                    .IsFixedLength();

                entity.Property(e => e.FlagPlaneado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_PLANEADO")
                    .IsFixedLength();

                entity.Property(e => e.FlagPrensas)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_PRENSAS")
                    .IsFixedLength();

                entity.Property(e => e.FlagRetenido)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_RETENIDO")
                    .IsFixedLength();

                entity.Property(e => e.FlagSoportev)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_SOPORTEV")
                    .IsFixedLength();

                entity.Property(e => e.FormInicial).HasColumnName("FORM_INICIAL");

                entity.Property(e => e.FormPorCaja).HasColumnName("FORM_POR_CAJA");

                entity.Property(e => e.JobAutomatico)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("JOB_AUTOMATICO")
                    .IsFixedLength();

                entity.Property(e => e.JobId).HasColumnName("JOB_ID");

                entity.Property(e => e.JobRestar).HasColumnName("JOB_RESTAR");

                entity.Property(e => e.LineaProduccio).HasColumnName("LINEA_PRODUCCIO");

                entity.Property(e => e.Lista)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("LISTA");

                entity.Property(e => e.LugarProducir)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("LUGAR_PRODUCIR")
                    .IsFixedLength();

                entity.Property(e => e.NoAnulacion).HasColumnName("NO_ANULACION");

                entity.Property(e => e.NoColectora).HasColumnName("NO_COLECTORA");

                entity.Property(e => e.NoPrensa).HasColumnName("NO_PRENSA");

                entity.Property(e => e.NuevaCtd).HasColumnName("NUEVA_CTD");

                entity.Property(e => e.NuevaFechaEnt)
                    .HasColumnType("datetime")
                    .HasColumnName("NUEVA_FECHA_ENT");

                entity.Property(e => e.NumeroFactura).HasColumnName("NUMERO_FACTURA");

                entity.Property(e => e.Obser)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("OBSER")
                    .IsFixedLength();

                entity.Property(e => e.Observaciones)
                    .HasColumnType("text")
                    .HasColumnName("OBSERVACIONES");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.OrigenReoperac)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ORIGEN_REOPERAC")
                    .IsFixedLength();

                entity.Property(e => e.Pais).HasColumnName("PAIS");

                entity.Property(e => e.PartesAReope).HasColumnName("PARTES_A_REOPE");

                entity.Property(e => e.PasoSql)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PASO_SQL")
                    .IsFixedLength();

                entity.Property(e => e.PiesArteCole)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("PIES_ARTE_COLE");

                entity.Property(e => e.PiesArtePren)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("PIES_ARTE_PREN");

                entity.Property(e => e.PiesColect)
                    .HasColumnType("decimal(16, 4)")
                    .HasColumnName("PIES_COLECT");

                entity.Property(e => e.PiesFotoCole)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("PIES_FOTO_COLE");

                entity.Property(e => e.PiesFotoPren)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("PIES_FOTO_PREN");

                entity.Property(e => e.PiesPlanCole)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("PIES_PLAN_COLE");

                entity.Property(e => e.PiesPlanPren)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("PIES_PLAN_PREN");

                entity.Property(e => e.PiesPrensCole)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("PIES_PRENS_COLE");

                entity.Property(e => e.PiesPrensPren)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("PIES_PRENS_PREN");

                entity.Property(e => e.PiesPrensa)
                    .HasColumnType("decimal(16, 4)")
                    .HasColumnName("PIES_PRENSA");

                entity.Property(e => e.PrecioLista)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("PRECIO_LISTA");

                entity.Property(e => e.PrecioVenta)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("PRECIO_VENTA");

                entity.Property(e => e.ProduInmediata)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PRODU_INMEDIATA")
                    .IsFixedLength();

                entity.Property(e => e.Programada)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PROGRAMADA")
                    .IsFixedLength();

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Remanente)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REMANENTE")
                    .IsFixedLength();

                entity.Property(e => e.ReopSolicPor).HasColumnName("REOP_SOLIC_POR");

                entity.Property(e => e.ReoperacionNo).HasColumnName("REOPERACION_NO");

                entity.Property(e => e.ResponsaReoper)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("RESPONSA_REOPER")
                    .IsFixedLength();

                entity.Property(e => e.Rlista)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RLISTA");

                entity.Property(e => e.Rpreciolista)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RPRECIOLISTA");

                entity.Property(e => e.Rprecioventa)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RPRECIOVENTA");

                entity.Property(e => e.Rventa)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RVENTA");

                entity.Property(e => e.StatusDelJob)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS_DEL_JOB")
                    .IsFixedLength();

                entity.Property(e => e.SupervVentas)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SUPERV_VENTAS")
                    .IsFixedLength();

                entity.Property(e => e.TipoCaja).HasColumnName("TIPO_CAJA");

                entity.Property(e => e.TipoOrden).HasColumnName("TIPO_ORDEN");

                entity.Property(e => e.TipoProduccion)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_PRODUCCION")
                    .IsFixedLength();

                entity.Property(e => e.UsuarioRet)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_RET");

                entity.Property(e => e.Vendedor)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("VENDEDOR")
                    .IsFixedLength();

                entity.Property(e => e.Venta)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("VENTA");
            });

            modelBuilder.Entity<Cpry010fr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CPRY010FR");

                entity.Property(e => e.ArregloReopera).HasColumnName("ARREGLO_REOPERA");

                entity.Property(e => e.CantAProducir).HasColumnName("CANT_A_PRODUCIR");

                entity.Property(e => e.CantAcabado).HasColumnName("CANT_ACABADO");

                entity.Property(e => e.CantArte).HasColumnName("CANT_ARTE");

                entity.Property(e => e.CantBcs).HasColumnName("CANT_BCS");

                entity.Property(e => e.CantCajaUtili).HasColumnName("CANT_CAJA_UTILI");

                entity.Property(e => e.CantColect).HasColumnName("CANT_COLECT");

                entity.Property(e => e.CantEmbarque).HasColumnName("CANT_EMBARQUE");

                entity.Property(e => e.CantFactura).HasColumnName("CANT_FACTURA");

                entity.Property(e => e.CantFoto).HasColumnName("CANT_FOTO");

                entity.Property(e => e.CantPlan).HasColumnName("CANT_PLAN");

                entity.Property(e => e.CantPrensa).HasColumnName("CANT_PRENSA");

                entity.Property(e => e.CantProgramada).HasColumnName("CANT_PROGRAMADA");

                entity.Property(e => e.CantidRemanent).HasColumnName("CANTID_REMANENT");

                entity.Property(e => e.CausaReoperaci).HasColumnName("CAUSA_REOPERACI");

                entity.Property(e => e.Cliente).HasColumnName("CLIENTE");

                entity.Property(e => e.CodBacklogRet).HasColumnName("COD_BACKLOG_RET");

                entity.Property(e => e.CodigoCaja)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO_CAJA")
                    .IsFixedLength();

                entity.Property(e => e.Combinacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COMBINACION");

                entity.Property(e => e.Cotizacion)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("COTIZACION")
                    .IsFixedLength();

                entity.Property(e => e.CtdEntregada).HasColumnName("CTD_ENTREGADA");

                entity.Property(e => e.CtdEntregadaini).HasColumnName("CTD_ENTREGADAINI");

                entity.Property(e => e.CtdFactAdelan).HasColumnName("CTD_FACT_ADELAN");

                entity.Property(e => e.DiasAcabado).HasColumnName("DIAS_ACABADO");

                entity.Property(e => e.DiasArte).HasColumnName("DIAS_ARTE");

                entity.Property(e => e.DiasBcs).HasColumnName("DIAS_BCS");

                entity.Property(e => e.DiasColectora).HasColumnName("DIAS_COLECTORA");

                entity.Property(e => e.DiasEmbarque).HasColumnName("DIAS_EMBARQUE");

                entity.Property(e => e.DiasFoto).HasColumnName("DIAS_FOTO");

                entity.Property(e => e.DiasPlaneacion).HasColumnName("DIAS_PLANEACION");

                entity.Property(e => e.DiasPrensa).HasColumnName("DIAS_PRENSA");

                entity.Property(e => e.DiasRetAcabad).HasColumnName("DIAS_RET_ACABAD");

                entity.Property(e => e.DiasRetArte).HasColumnName("DIAS_RET_ARTE");

                entity.Property(e => e.DiasRetBcs).HasColumnName("DIAS_RET_BCS");

                entity.Property(e => e.DiasRetColect).HasColumnName("DIAS_RET_COLECT");

                entity.Property(e => e.DiasRetEmbarq).HasColumnName("DIAS_RET_EMBARQ");

                entity.Property(e => e.DiasRetFoto).HasColumnName("DIAS_RET_FOTO");

                entity.Property(e => e.DiasRetPlanea).HasColumnName("DIAS_RET_PLANEA");

                entity.Property(e => e.DiasRetPrensa).HasColumnName("DIAS_RET_PRENSA");

                entity.Property(e => e.Elimina)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ELIMINA")
                    .IsFixedLength();

                entity.Property(e => e.FecRealOrden)
                    .HasColumnType("datetime")
                    .HasColumnName("FEC_REAL_ORDEN");

                entity.Property(e => e.FechaArchivo)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ARCHIVO");

                entity.Property(e => e.FechaEntrega)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ENTREGA");

                entity.Property(e => e.FechaFactura)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_FACTURA");

                entity.Property(e => e.FechaOrdEntry)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ORD_ENTRY");

                entity.Property(e => e.FechaRet)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_RET");

                entity.Property(e => e.FechaRetenido)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_RETENIDO");

                entity.Property(e => e.FechaeEstAcab)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAE_EST_ACAB");

                entity.Property(e => e.FechaeEstBcs)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAE_EST_BCS");

                entity.Property(e => e.FechaeEstCole)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAE_EST_COLE");

                entity.Property(e => e.FechaeEstDise)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAE_EST_DISE");

                entity.Property(e => e.FechaeEstEmba)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAE_EST_EMBA");

                entity.Property(e => e.FechaeEstEntr)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAE_EST_ENTR");

                entity.Property(e => e.FechaeEstFact)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAE_EST_FACT");

                entity.Property(e => e.FechaeEstNega)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAE_EST_NEGA");

                entity.Property(e => e.FechaeEstPren)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAE_EST_PREN");

                entity.Property(e => e.FechaerAcabado)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAER_ACABADO");

                entity.Property(e => e.FechaerBcs)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAER_BCS");

                entity.Property(e => e.FechaerColecto)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAER_COLECTO");

                entity.Property(e => e.FechaerDiseno)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAER_DISENO");

                entity.Property(e => e.FechaerEmbarqu)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAER_EMBARQU");

                entity.Property(e => e.FechaerFactura)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAER_FACTURA");

                entity.Property(e => e.FechaerNegativ)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAER_NEGATIV");

                entity.Property(e => e.FechaerPrelim)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAER_PRELIM");

                entity.Property(e => e.FechaerPrensas)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAER_PRENSAS");

                entity.Property(e => e.FechasEstAcab)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAS_EST_ACAB");

                entity.Property(e => e.FechasEstBcs)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAS_EST_BCS");

                entity.Property(e => e.FechasEstCole)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAS_EST_COLE");

                entity.Property(e => e.FechasEstDise)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAS_EST_DISE");

                entity.Property(e => e.FechasEstEmba)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAS_EST_EMBA");

                entity.Property(e => e.FechasEstFact)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAS_EST_FACT");

                entity.Property(e => e.FechasEstNega)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAS_EST_NEGA");

                entity.Property(e => e.FechasEstPrel)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAS_EST_PREL");

                entity.Property(e => e.FechasEstPren)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAS_EST_PREN");

                entity.Property(e => e.FechasrAcabado)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHASR_ACABADO");

                entity.Property(e => e.FechasrBcs)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHASR_BCS");

                entity.Property(e => e.FechasrColecto)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHASR_COLECTO");

                entity.Property(e => e.FechasrDiseno)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHASR_DISENO");

                entity.Property(e => e.FechasrEmbarqu)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHASR_EMBARQU");

                entity.Property(e => e.FechasrNegativ)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHASR_NEGATIV");

                entity.Property(e => e.FechasrPrelim)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHASR_PRELIM");

                entity.Property(e => e.FechasrPrensas)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHASR_PRENSAS");

                entity.Property(e => e.Fiscal)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FISCAL")
                    .IsFixedLength();

                entity.Property(e => e.FlagAcabado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_ACABADO")
                    .IsFixedLength();

                entity.Property(e => e.FlagBcs)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_BCS")
                    .IsFixedLength();

                entity.Property(e => e.FlagColectora)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_COLECTORA")
                    .IsFixedLength();

                entity.Property(e => e.FlagDiseno)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_DISENO")
                    .IsFixedLength();

                entity.Property(e => e.FlagEmbarque)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_EMBARQUE")
                    .IsFixedLength();

                entity.Property(e => e.FlagEtiqImpre)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_ETIQ_IMPRE")
                    .IsFixedLength();

                entity.Property(e => e.FlagFoto)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_FOTO")
                    .IsFixedLength();

                entity.Property(e => e.FlagPlaneac)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_PLANEAC")
                    .IsFixedLength();

                entity.Property(e => e.FlagPlaneado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_PLANEADO")
                    .IsFixedLength();

                entity.Property(e => e.FlagPrensas)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_PRENSAS")
                    .IsFixedLength();

                entity.Property(e => e.FlagRetenido)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_RETENIDO")
                    .IsFixedLength();

                entity.Property(e => e.FlagSoportev)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_SOPORTEV")
                    .IsFixedLength();

                entity.Property(e => e.FormInicial).HasColumnName("FORM_INICIAL");

                entity.Property(e => e.FormPorCaja).HasColumnName("FORM_POR_CAJA");

                entity.Property(e => e.JobAutomatico)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("JOB_AUTOMATICO")
                    .IsFixedLength();

                entity.Property(e => e.JobId).HasColumnName("JOB_ID");

                entity.Property(e => e.JobRestar).HasColumnName("JOB_RESTAR");

                entity.Property(e => e.LineaProduccio).HasColumnName("LINEA_PRODUCCIO");

                entity.Property(e => e.Lista)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("LISTA");

                entity.Property(e => e.LugarProducir)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("LUGAR_PRODUCIR")
                    .IsFixedLength();

                entity.Property(e => e.NoAnulacion).HasColumnName("NO_ANULACION");

                entity.Property(e => e.NoColectora).HasColumnName("NO_COLECTORA");

                entity.Property(e => e.NoPrensa).HasColumnName("NO_PRENSA");

                entity.Property(e => e.NuevaCtd).HasColumnName("NUEVA_CTD");

                entity.Property(e => e.NuevaFechaEnt)
                    .HasColumnType("datetime")
                    .HasColumnName("NUEVA_FECHA_ENT");

                entity.Property(e => e.NumeroFactura).HasColumnName("NUMERO_FACTURA");

                entity.Property(e => e.Obser)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("OBSER")
                    .IsFixedLength();

                entity.Property(e => e.Observaciones)
                    .HasColumnType("text")
                    .HasColumnName("OBSERVACIONES");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.OrigenReoperac)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ORIGEN_REOPERAC")
                    .IsFixedLength();

                entity.Property(e => e.Pais).HasColumnName("PAIS");

                entity.Property(e => e.PartesAReope).HasColumnName("PARTES_A_REOPE");

                entity.Property(e => e.PasoSql)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PASO_SQL")
                    .IsFixedLength();

                entity.Property(e => e.PiesArteCole)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("PIES_ARTE_COLE");

                entity.Property(e => e.PiesArtePren)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("PIES_ARTE_PREN");

                entity.Property(e => e.PiesColect)
                    .HasColumnType("decimal(16, 4)")
                    .HasColumnName("PIES_COLECT");

                entity.Property(e => e.PiesFotoCole)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("PIES_FOTO_COLE");

                entity.Property(e => e.PiesFotoPren)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("PIES_FOTO_PREN");

                entity.Property(e => e.PiesPlanCole)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("PIES_PLAN_COLE");

                entity.Property(e => e.PiesPlanPren)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("PIES_PLAN_PREN");

                entity.Property(e => e.PiesPrensCole)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("PIES_PRENS_COLE");

                entity.Property(e => e.PiesPrensPren)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("PIES_PRENS_PREN");

                entity.Property(e => e.PiesPrensa)
                    .HasColumnType("decimal(16, 4)")
                    .HasColumnName("PIES_PRENSA");

                entity.Property(e => e.PrecioLista)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("PRECIO_LISTA");

                entity.Property(e => e.PrecioVenta)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("PRECIO_VENTA");

                entity.Property(e => e.ProduInmediata)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PRODU_INMEDIATA")
                    .IsFixedLength();

                entity.Property(e => e.Programada)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PROGRAMADA")
                    .IsFixedLength();

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Remanente)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REMANENTE")
                    .IsFixedLength();

                entity.Property(e => e.ReopSolicPor).HasColumnName("REOP_SOLIC_POR");

                entity.Property(e => e.ReoperacionNo).HasColumnName("REOPERACION_NO");

                entity.Property(e => e.ResponsaReoper)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("RESPONSA_REOPER")
                    .IsFixedLength();

                entity.Property(e => e.Rlista)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RLISTA");

                entity.Property(e => e.Rpreciolista)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RPRECIOLISTA");

                entity.Property(e => e.Rprecioventa)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RPRECIOVENTA");

                entity.Property(e => e.Rventa)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RVENTA");

                entity.Property(e => e.StatusDelJob)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS_DEL_JOB")
                    .IsFixedLength();

                entity.Property(e => e.SupervVentas)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SUPERV_VENTAS")
                    .IsFixedLength();

                entity.Property(e => e.TipoCaja).HasColumnName("TIPO_CAJA");

                entity.Property(e => e.TipoOrden).HasColumnName("TIPO_ORDEN");

                entity.Property(e => e.TipoProduccion)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_PRODUCCION")
                    .IsFixedLength();

                entity.Property(e => e.UsuarioRet)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_RET");

                entity.Property(e => e.Vendedor)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("VENDEDOR")
                    .IsFixedLength();

                entity.Property(e => e.Venta)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("VENTA");
            });

            modelBuilder.Entity<Cpry011>(entity =>
            {
                entity.HasKey(e => e.JobId)
                    .HasName("CPRY011_INDEX01");

                entity.ToTable("CPRY011");

                entity.HasIndex(e => e.Recnum, "CPRY011_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.Pais, e.LineaProduccio, e.JobId }, "CPRY011_INDEX02")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.SupervVentas, e.Vendedor, e.JobId }, "CPRY011_INDEX03")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.NoPrensa, e.JobId }, "CPRY011_INDEX04")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.NoColectora, e.JobId }, "CPRY011_INDEX05")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.FechaFactura, e.JobId }, "CPRY011_INDEX06")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.Vendedor, e.JobId }, "CPRY011_INDEX07")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.Orden, e.JobId }, "CPRY011_INDEX08")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.TipoOrden, e.Orden, e.JobId }, "CPRY011_INDEX09")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.Cliente, e.JobId }, "CPRY011_INDEX10")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.FechasrPrensas, e.Orden, e.Recnum }, "CPRY011_INDEX11")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.Elimina, e.Recnum }, "CPRY011_INDEX12")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => e.Orden, "dep_cpry011orden");

                entity.Property(e => e.JobId)
                    .ValueGeneratedNever()
                    .HasColumnName("JOB_ID");

                entity.Property(e => e.ArregloReopera)
                    .HasColumnName("ARREGLO_REOPERA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CantAProducir)
                    .HasColumnName("CANT_A_PRODUCIR")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CantAcabado)
                    .HasColumnName("CANT_ACABADO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CantArte)
                    .HasColumnName("CANT_ARTE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CantBcs)
                    .HasColumnName("CANT_BCS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CantCajaUtili)
                    .HasColumnName("CANT_CAJA_UTILI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CantColect)
                    .HasColumnName("CANT_COLECT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CantEmbarque)
                    .HasColumnName("CANT_EMBARQUE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CantFactura)
                    .HasColumnName("CANT_FACTURA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CantFoto)
                    .HasColumnName("CANT_FOTO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CantPlan)
                    .HasColumnName("CANT_PLAN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CantPrensa)
                    .HasColumnName("CANT_PRENSA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CantProgramada)
                    .HasColumnName("CANT_PROGRAMADA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CantidRemanent)
                    .HasColumnName("CANTID_REMANENT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CausaReoperaci)
                    .HasColumnName("CAUSA_REOPERACI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cliente)
                    .HasColumnName("CLIENTE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CodBacklogRet)
                    .HasColumnName("COD_BACKLOG_RET")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CodigoCaja)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO_CAJA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Combinacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COMBINACION");

                entity.Property(e => e.Cotizacion)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("COTIZACION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CtdEntregada)
                    .HasColumnName("CTD_ENTREGADA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CtdEntregadaini)
                    .HasColumnName("CTD_ENTREGADAINI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CtdFactAdelan)
                    .HasColumnName("CTD_FACT_ADELAN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DiasAcabado)
                    .HasColumnName("DIAS_ACABADO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DiasArte)
                    .HasColumnName("DIAS_ARTE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DiasBcs)
                    .HasColumnName("DIAS_BCS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DiasColectora)
                    .HasColumnName("DIAS_COLECTORA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DiasEmbarque)
                    .HasColumnName("DIAS_EMBARQUE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DiasFoto)
                    .HasColumnName("DIAS_FOTO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DiasPlaneacion)
                    .HasColumnName("DIAS_PLANEACION")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DiasPrensa)
                    .HasColumnName("DIAS_PRENSA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DiasRetAcabad)
                    .HasColumnName("DIAS_RET_ACABAD")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DiasRetArte)
                    .HasColumnName("DIAS_RET_ARTE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DiasRetBcs)
                    .HasColumnName("DIAS_RET_BCS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DiasRetColect)
                    .HasColumnName("DIAS_RET_COLECT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DiasRetEmbarq)
                    .HasColumnName("DIAS_RET_EMBARQ")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DiasRetFoto)
                    .HasColumnName("DIAS_RET_FOTO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DiasRetPlanea)
                    .HasColumnName("DIAS_RET_PLANEA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DiasRetPrensa)
                    .HasColumnName("DIAS_RET_PRENSA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Elimina)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ELIMINA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Eliminado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ELIMINADO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FecRealOrden)
                    .HasColumnType("datetime")
                    .HasColumnName("FEC_REAL_ORDEN");

                entity.Property(e => e.FechaArchivo)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ARCHIVO");

                entity.Property(e => e.FechaCancela)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_CANCELA");

                entity.Property(e => e.FechaEntrega)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ENTREGA");

                entity.Property(e => e.FechaFactura)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_FACTURA")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.FechaOrdEntry)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ORD_ENTRY");

                entity.Property(e => e.FechaRet)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_RET");

                entity.Property(e => e.FechaRetenido)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_RETENIDO");

                entity.Property(e => e.FechaeEstAcab)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAE_EST_ACAB");

                entity.Property(e => e.FechaeEstBcs)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAE_EST_BCS");

                entity.Property(e => e.FechaeEstCole)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAE_EST_COLE");

                entity.Property(e => e.FechaeEstDise)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAE_EST_DISE");

                entity.Property(e => e.FechaeEstEmba)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAE_EST_EMBA");

                entity.Property(e => e.FechaeEstEntr)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAE_EST_ENTR");

                entity.Property(e => e.FechaeEstFact)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAE_EST_FACT");

                entity.Property(e => e.FechaeEstNega)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAE_EST_NEGA");

                entity.Property(e => e.FechaeEstPren)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAE_EST_PREN");

                entity.Property(e => e.FechaerAcabado)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAER_ACABADO");

                entity.Property(e => e.FechaerBcs)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAER_BCS");

                entity.Property(e => e.FechaerColecto)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAER_COLECTO");

                entity.Property(e => e.FechaerDiseno)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAER_DISENO");

                entity.Property(e => e.FechaerEmbarqu)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAER_EMBARQU");

                entity.Property(e => e.FechaerFactura)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAER_FACTURA");

                entity.Property(e => e.FechaerNegativ)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAER_NEGATIV");

                entity.Property(e => e.FechaerPrelim)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAER_PRELIM");

                entity.Property(e => e.FechaerPrensas)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAER_PRENSAS");

                entity.Property(e => e.FechasEstAcab)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAS_EST_ACAB");

                entity.Property(e => e.FechasEstBcs)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAS_EST_BCS");

                entity.Property(e => e.FechasEstCole)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAS_EST_COLE");

                entity.Property(e => e.FechasEstDise)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAS_EST_DISE");

                entity.Property(e => e.FechasEstEmba)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAS_EST_EMBA");

                entity.Property(e => e.FechasEstFact)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAS_EST_FACT");

                entity.Property(e => e.FechasEstNega)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAS_EST_NEGA");

                entity.Property(e => e.FechasEstPrel)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAS_EST_PREL");

                entity.Property(e => e.FechasEstPren)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAS_EST_PREN");

                entity.Property(e => e.FechasrAcabado)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHASR_ACABADO");

                entity.Property(e => e.FechasrBcs)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHASR_BCS");

                entity.Property(e => e.FechasrColecto)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHASR_COLECTO");

                entity.Property(e => e.FechasrDiseno)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHASR_DISENO");

                entity.Property(e => e.FechasrEmbarqu)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHASR_EMBARQU");

                entity.Property(e => e.FechasrNegativ)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHASR_NEGATIV");

                entity.Property(e => e.FechasrPrelim)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHASR_PRELIM");

                entity.Property(e => e.FechasrPrensas)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHASR_PRENSAS");

                entity.Property(e => e.Fiscal)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FISCAL")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagAcabado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_ACABADO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagBcs)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_BCS")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagColectora)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_COLECTORA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagDiseno)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_DISENO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagEmbarque)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_EMBARQUE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagEtiqImpre)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_ETIQ_IMPRE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagFoto)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_FOTO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagPlaneac)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_PLANEAC")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagPlaneado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_PLANEADO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagPrensas)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_PRENSAS")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagRetenido)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_RETENIDO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FormInicial)
                    .HasColumnName("FORM_INICIAL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FormPorCaja)
                    .HasColumnName("FORM_POR_CAJA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.JobAutomatico)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("JOB_AUTOMATICO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.LineaProduccio)
                    .HasColumnName("LINEA_PRODUCCIO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Lista)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("LISTA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LugarProducir)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("LUGAR_PRODUCIR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NoAnulacion)
                    .HasColumnName("NO_ANULACION")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NoColectora)
                    .HasColumnName("NO_COLECTORA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NoPrensa)
                    .HasColumnName("NO_PRENSA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NuevaFechaEnt)
                    .HasColumnType("datetime")
                    .HasColumnName("NUEVA_FECHA_ENT");

                entity.Property(e => e.NumeroFactura)
                    .HasColumnName("NUMERO_FACTURA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Obser)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("OBSER")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Observaciones)
                    .HasColumnType("text")
                    .HasColumnName("OBSERVACIONES");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.OrigenReoperac)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ORIGEN_REOPERAC")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Pais).HasColumnName("PAIS");

                entity.Property(e => e.PartesAReope)
                    .HasColumnName("PARTES_A_REOPE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PiesColect)
                    .HasColumnType("decimal(16, 4)")
                    .HasColumnName("PIES_COLECT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PiesPrensa)
                    .HasColumnType("decimal(16, 4)")
                    .HasColumnName("PIES_PRENSA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProduInmediata)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PRODU_INMEDIATA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Programada)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PROGRAMADA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Remanente)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REMANENTE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ReopSolicPor)
                    .HasColumnName("REOP_SOLIC_POR")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReoperacionNo)
                    .HasColumnName("REOPERACION_NO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ResponsaReoper)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("RESPONSA_REOPER")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Rlista)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RLISTA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rpreciolista)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RPRECIOLISTA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rprecioventa)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RPRECIOVENTA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rventa)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RVENTA");

                entity.Property(e => e.StatusDelJob)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS_DEL_JOB")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SupervVentas)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SUPERV_VENTAS")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TipoCaja)
                    .HasColumnName("TIPO_CAJA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TipoOrden)
                    .HasColumnName("TIPO_ORDEN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TipoProduccion)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_PRODUCCION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.UsuarioCancelo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_CANCELO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.UsuarioRet)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_RET");

                entity.Property(e => e.Vendedor)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("VENDEDOR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Venta)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("VENTA")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Cpry012>(entity =>
            {
                entity.HasKey(e => new { e.TipoOrden, e.FecRegVentas, e.Orden, e.Recnum })
                    .HasName("CPRY012_INDEX02");

                entity.ToTable("CPRY012");

                entity.HasIndex(e => new { e.Cliente, e.Fiscal }, "<Name of Missing Index, sysname,>")
                    .HasFillFactor(70);

                entity.HasIndex(e => e.Recnum, "CPRY012_INDEX00")
                    .IsUnique()
                    .HasFillFactor(70);

                entity.HasIndex(e => e.Orden, "CPRY012_INDEX01")
                    .IsUnique()
                    .HasFillFactor(70);

                entity.HasIndex(e => new { e.NoTransmision, e.Recnum }, "CPRY012_INDEX03")
                    .IsUnique()
                    .HasFillFactor(70);

                entity.HasIndex(e => e.Cotizacion, "CPRY012_INDEX04")
                    .IsUnique()
                    .HasFillFactor(70);

                entity.HasIndex(e => new { e.VinetaImpresa, e.Orden, e.Recnum }, "CPRY012_INDEX05")
                    .IsUnique()
                    .HasFillFactor(70);

                entity.HasIndex(e => new { e.NombreCliente, e.Orden, e.Recnum }, "CPRY012_INDEX06")
                    .IsUnique()
                    .HasFillFactor(70);

                entity.HasIndex(e => new { e.CodProducto, e.FechaArchivo, e.Recnum }, "CPRY012_INDEX07")
                    .IsUnique()
                    .HasFillFactor(70);

                entity.HasIndex(e => new { e.FechaArchivo, e.Recnum }, "CPRY012_INDEX08")
                    .IsUnique()
                    .HasFillFactor(70);

                entity.HasIndex(e => new { e.Anticipo, e.LineaAnt, e.Recnum }, "CPRY012_INDEX09")
                    .IsUnique()
                    .HasFillFactor(70);

                entity.HasIndex(e => new { e.PorcMc, e.Recnum }, "CPRY012_INDEX10")
                    .IsUnique()
                    .HasFillFactor(70);

                entity.HasIndex(e => new { e.Idcalendar2, e.Recnum }, "CPRY012_INDEX11")
                    .IsUnique()
                    .HasFillFactor(70);

                entity.HasIndex(e => e.IdSolicitud, "IX_CPRY012")
                    .HasFillFactor(70);

                entity.HasIndex(e => e.IdSolicitud, "IX_CPRY012_1")
                    .HasFillFactor(70);

                entity.HasIndex(e => new { e.Orden, e.CodProducto }, "IX_CPRY012_2")
                    .HasFillFactor(70);

                entity.HasIndex(e => e.IdSolicitud, "IX_CPRY012_3")
                    .HasFillFactor(70);

                entity.HasIndex(e => e.Cliente, "IX_CPRY012_4")
                    .HasFillFactor(70);

                entity.HasIndex(e => new { e.CodProducto, e.Orden }, "_dta_index_CPRY012_24_2044586372__K19_K2_6")
                    .HasFillFactor(70);

                entity.HasIndex(e => e.FecRecibPlant, "dep_CPRY012_FEC_RECIB_PLANT")
                    .HasFillFactor(70);

                entity.HasIndex(e => e.Orden, "dep_cpry012orden")
                    .HasFillFactor(70);

                entity.Property(e => e.TipoOrden)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_ORDEN")
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.FecRegVentas)
                    .HasColumnType("datetime")
                    .HasColumnName("FEC_REG_VENTAS")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Adelantada)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ADELANTADA");

                entity.Property(e => e.An8entregar)
                    .HasColumnType("decimal(14, 0)")
                    .HasColumnName("AN8ENTREGAR")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.An8facturar)
                    .HasColumnType("decimal(14, 0)")
                    .HasColumnName("AN8FACTURAR")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AnchosPts1)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANCHOS_PTS1")
                    .IsFixedLength();

                entity.Property(e => e.AnchosPts2)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANCHOS_PTS2")
                    .IsFixedLength();

                entity.Property(e => e.AnchosRod1)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ANCHOS_ROD1")
                    .IsFixedLength();

                entity.Property(e => e.AnchosRod2)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ANCHOS_ROD2")
                    .IsFixedLength();

                entity.Property(e => e.Anticipo).HasColumnName("ANTICIPO");

                entity.Property(e => e.AnticipoJde)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("ANTICIPO_JDE")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Anulada)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ANULADA")
                    .IsFixedLength();

                entity.Property(e => e.AutorizaAde)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTORIZA_ADE");

                entity.Property(e => e.BsMcFinan)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("BS_MC_FINAN")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.BsMcFinanE)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("BS_MC_FINAN_E");

                entity.Property(e => e.BsMcFinansc)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("BS_MC_FINANSC")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.BsMcFinansce)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("BS_MC_FINANSCE");

                entity.Property(e => e.BsMcPapel)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("BS_MC_PAPEL")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.BsMcPapelE)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("BS_MC_PAPEL_E");

                entity.Property(e => e.BsMcPapelsc)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("BS_MC_PAPELSC");

                entity.Property(e => e.BsMcPapelsce)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("BS_MC_PAPELSCE");

                entity.Property(e => e.CambioCompo)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("CAMBIO_COMPO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CantAProducir).HasColumnName("CANT_A_PRODUCIR");

                entity.Property(e => e.CantCajas).HasColumnName("CANT_CAJAS");

                entity.Property(e => e.CantFacturada).HasColumnName("CANT_FACTURADA");

                entity.Property(e => e.CantOrdenada).HasColumnName("CANT_ORDENADA");

                entity.Property(e => e.CantProducida).HasColumnName("CANT_PRODUCIDA");

                entity.Property(e => e.CantProgramada).HasColumnName("CANT_PROGRAMADA");

                entity.Property(e => e.CantXCajas).HasColumnName("CANT_X_CAJAS");

                entity.Property(e => e.CantXPaq).HasColumnName("CANT_X_PAQ");

                entity.Property(e => e.CantidadRodada)
                    .HasColumnType("decimal(14, 0)")
                    .HasColumnName("CANTIDAD_RODADA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ClaseOrden)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CLASE_ORDEN")
                    .IsFixedLength();

                entity.Property(e => e.Cliente).HasColumnName("CLIENTE");

                entity.Property(e => e.CodAplicacion)
                    .HasColumnName("COD_APLICACION")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CodBacklogRet).HasColumnName("COD_BACKLOG_RET");

                entity.Property(e => e.CodProducto)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("COD_PRODUCTO")
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.CodTeleop)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("COD_TELEOP")
                    .IsFixedLength();

                entity.Property(e => e.Comision)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("COMISION");

                entity.Property(e => e.CondPago).HasColumnName("COND_PAGO");

                entity.Property(e => e.CondicionProdu)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CONDICION_PRODU")
                    .IsFixedLength();

                entity.Property(e => e.ConsArchivo).HasColumnName("CONS_ARCHIVO");

                entity.Property(e => e.Cortado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CORTADO")
                    .IsFixedLength();

                entity.Property(e => e.CostoSap)
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cotizacion)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("COTIZACION")
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.CtdEntregada).HasColumnName("CTD_ENTREGADA");

                entity.Property(e => e.CtdNc).HasColumnName("CTD_NC");

                entity.Property(e => e.CteEntregar)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("CTE_ENTREGAR")
                    .IsFixedLength();

                entity.Property(e => e.CteFacturar)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("CTE_FACTURAR")
                    .IsFixedLength();

                entity.Property(e => e.CuarTintaFte)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CUAR_TINTA_FTE")
                    .IsFixedLength();

                entity.Property(e => e.DescProducto)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESC_PRODUCTO")
                    .IsFixedLength();

                entity.Property(e => e.DirecEntregar)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("DIREC_ENTREGAR")
                    .IsFixedLength();

                entity.Property(e => e.DirecEntregar2)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("DIREC_ENTREGAR2")
                    .IsFixedLength();

                entity.Property(e => e.DirecEntregar3)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("DIREC_ENTREGAR3")
                    .IsFixedLength();

                entity.Property(e => e.DirecFacturar)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("DIREC_FACTURAR")
                    .IsFixedLength();

                entity.Property(e => e.DirecFacturar2)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("DIREC_FACTURAR2")
                    .IsFixedLength();

                entity.Property(e => e.DirecFacturar3)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("DIREC_FACTURAR3")
                    .IsFixedLength();

                entity.Property(e => e.Doblez)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DOBLEZ")
                    .IsFixedLength();

                entity.Property(e => e.EmbReverso)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("EMB_REVERSO")
                    .IsFixedLength();

                entity.Property(e => e.EmpacarEn)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("EMPACAR_EN")
                    .IsFixedLength();

                entity.Property(e => e.EngomaCarbCol)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ENGOMA_CARB_COL")
                    .IsFixedLength();

                entity.Property(e => e.EngomaCarbPre)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ENGOMA_CARB_PRE")
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ESTADO")
                    .IsFixedLength();

                entity.Property(e => e.EstadoEntregar).HasMaxLength(2);

                entity.Property(e => e.EstadoFacturar).HasMaxLength(2);

                entity.Property(e => e.Excepcion)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("EXCEPCION")
                    .IsFixedLength();

                entity.Property(e => e.FacturaDolar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FACTURA_DOLAR")
                    .IsFixedLength();

                entity.Property(e => e.FamiliaProduct)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("FAMILIA_PRODUCT")
                    .IsFixedLength();

                entity.Property(e => e.FecCierreOrd)
                    .HasColumnType("datetime")
                    .HasColumnName("FEC_CIERRE_ORD");

                entity.Property(e => e.FecComproClte)
                    .HasColumnType("datetime")
                    .HasColumnName("FEC_COMPRO_CLTE");

                entity.Property(e => e.FecCreditos)
                    .HasColumnType("datetime")
                    .HasColumnName("FEC_CREDITOS");

                entity.Property(e => e.FecProgramada)
                    .HasColumnType("datetime")
                    .HasColumnName("FEC_PROGRAMADA");

                entity.Property(e => e.FecRecibPlant)
                    .HasColumnType("datetime")
                    .HasColumnName("FEC_RECIB_PLANT");

                entity.Property(e => e.FecTransmision)
                    .HasColumnType("datetime")
                    .HasColumnName("FEC_TRANSMISION");

                entity.Property(e => e.FechaArchivo)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ARCHIVO")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.FechaCalculo)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_CALCULO");

                entity.Property(e => e.FechaDolar)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_DOLAR");

                entity.Property(e => e.FechaTasa).HasColumnType("datetime");

                entity.Property(e => e.Fiscal)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FISCAL")
                    .IsFixedLength();

                entity.Property(e => e.FlagActivo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_ACTIVO")
                    .IsFixedLength();

                entity.Property(e => e.FlagFactura)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_FACTURA")
                    .IsFixedLength();

                entity.Property(e => e.FlagProdInter)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_PROD_INTER")
                    .IsFixedLength();

                entity.Property(e => e.FlagSoportev)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_SOPORTEV")
                    .IsFixedLength();

                entity.Property(e => e.FlagV19)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_V19")
                    .IsFixedLength();

                entity.Property(e => e.FormasUndFact).HasColumnName("FORMAS_UND_FACT");

                entity.Property(e => e.GomaRegPtes)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GOMA_REG_PTES")
                    .IsFixedLength();

                entity.Property(e => e.IdCombinada).HasDefaultValueSql("((0))");

                entity.Property(e => e.IdDirEntregar).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IdDirFacturar).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IdSolicitud)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IdSolicitud2)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IdSolicitudCosto).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdSolicitudReoperacion).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Idcalendar)
                    .HasColumnName("IDCALENDAR")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Idcalendar2)
                    .IsRequired()
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("IDCALENDAR2")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Impout)
                    .HasColumnType("decimal(1, 0)")
                    .HasColumnName("IMPOUT")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Impresion)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IMPRESION")
                    .IsFixedLength();

                entity.Property(e => e.ImprimeDol)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IMPRIME_DOL")
                    .HasDefaultValueSql("('X')");

                entity.Property(e => e.Impvar)
                    .HasColumnType("decimal(1, 0)")
                    .HasColumnName("IMPVAR")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.InstFacturar)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("INST_FACTURAR")
                    .IsFixedLength();

                entity.Property(e => e.LineaAnt).HasColumnName("LINEA_ANT");

                entity.Property(e => e.LineaAntJde)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("LINEA_ANT_JDE")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LineaIncoming).HasColumnName("LINEA_INCOMING");

                entity.Property(e => e.LineaProducto)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("LINEA_PRODUCTO")
                    .IsFixedLength();

                entity.Property(e => e.ListaTotDolar)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("LISTA_TOT_DOLAR");

                entity.Property(e => e.ListaUnitDol)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("LISTA_UNIT_DOL");

                entity.Property(e => e.LugarEnviar)
                    .HasColumnType("text")
                    .HasColumnName("LUGAR_ENVIAR");

                entity.Property(e => e.LugarProducir)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("LUGAR_PRODUCIR")
                    .IsFixedLength();

                entity.Property(e => e.MedidaBase).HasColumnName("MEDIDA_BASE");

                entity.Property(e => e.MedidaVariable).HasColumnName("MEDIDA_VARIABLE");

                entity.Property(e => e.MunicipioEntregar).HasMaxLength(2);

                entity.Property(e => e.MunicipioFacturar).HasMaxLength(2);

                entity.Property(e => e.NoTransmision).HasColumnName("NO_TRANSMISION");

                entity.Property(e => e.Nocalculamc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NOCALCULAMC")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NombreCliente)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_CLIENTE")
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.NombreProducto)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_PRODUCTO")
                    .IsFixedLength();

                entity.Property(e => e.NuTintasFrent).HasColumnName("NU_TINTAS_FRENT");

                entity.Property(e => e.NuTintasResp).HasColumnName("NU_TINTAS_RESP");

                entity.Property(e => e.NumeroTiras).HasColumnName("NUMERO_TIRAS");

                entity.Property(e => e.OrdenAnterior).HasColumnName("ORDEN_ANTERIOR");

                entity.Property(e => e.OrdenComb)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ORDEN_COMB")
                    .IsFixedLength();

                entity.Property(e => e.PCobranza)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("P_COBRANZA");

                entity.Property(e => e.POverger)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("P_OVERGER");

                entity.Property(e => e.POverride)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("P_OVERRIDE");

                entity.Property(e => e.POverrideCg)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("P_OVERRIDE_CG");

                entity.Property(e => e.POverrideG)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("P_OVERRIDE_G");

                entity.Property(e => e.POverrideGo)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("P_OVERRIDE_GO");

                entity.Property(e => e.Pais).HasColumnName("PAIS");

                entity.Property(e => e.PartesFormula).HasColumnName("PARTES_FORMULA");

                entity.Property(e => e.PartesTiras)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PARTES_TIRAS")
                    .IsFixedLength();

                entity.Property(e => e.Plantilla).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoncMargDer)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PONC_MARG_DER")
                    .IsFixedLength();

                entity.Property(e => e.PoncMargIzq)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PONC_MARG_IZQ")
                    .IsFixedLength();

                entity.Property(e => e.PoncheEsp)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PONCHE_ESP")
                    .IsFixedLength();

                entity.Property(e => e.PorcCom)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("PORC_COM");

                entity.Property(e => e.PorcComRegulada)
                    .HasColumnType("numeric(5, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PorcMc)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("PORC_MC");

                entity.Property(e => e.PorcMcFinan)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("PORC_MC_FINAN")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PorcMcFinanE)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("PORC_MC_FINAN_E");

                entity.Property(e => e.PorcMcFinansc)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("PORC_MC_FINANSC")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PorcMcMinimo).HasColumnType("numeric(5, 3)");

                entity.Property(e => e.PorcMcPapel)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("PORC_MC_PAPEL")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PorcMcPapelE)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("PORC_MC_PAPEL_E");

                entity.Property(e => e.PorcMcPapelsc)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("PORC_MC_PAPELSC")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PorcMcfinansce)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("PORC_MCFINANSCE");

                entity.Property(e => e.PorcMcpapelsce)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("PORC_MCPAPELSCE");

                entity.Property(e => e.PorcRespSocial)
                    .HasColumnType("numeric(5, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PosTirasF)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("POS_TIRAS_F")
                    .IsFixedLength();

                entity.Property(e => e.PosTirasR)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("POS_TIRAS_R")
                    .IsFixedLength();

                entity.Property(e => e.PrecioLista)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("PRECIO_LISTA");

                entity.Property(e => e.PrecioUnitarioUsd).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.PrecioVenta)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("PRECIO_VENTA");

                entity.Property(e => e.PrefColeEsp)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PREF_COLE_ESP")
                    .IsFixedLength();

                entity.Property(e => e.PrefColeStd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PREF_COLE_STD")
                    .IsFixedLength();

                entity.Property(e => e.PrefPrenEsp)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PREF_PREN_ESP")
                    .IsFixedLength();

                entity.Property(e => e.PrefPrenStd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PREF_PREN_STD")
                    .IsFixedLength();

                entity.Property(e => e.PrimTintaFte)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("PRIM_TINTA_FTE")
                    .IsFixedLength();

                entity.Property(e => e.PrimTintaResp)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("PRIM_TINTA_RESP")
                    .IsFixedLength();

                entity.Property(e => e.QuintTintaFte)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("QUINT_TINTA_FTE")
                    .IsFixedLength();

                entity.Property(e => e.RbsMcFinan)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RBS_MC_FINAN")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RbsMcFinanE)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RBS_MC_FINAN_E");

                entity.Property(e => e.RbsMcFinansc)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RBS_MC_FINANSC")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RbsMcFinansce)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RBS_MC_FINANSCE");

                entity.Property(e => e.RbsMcPapel)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RBS_MC_PAPEL")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RbsMcPapelE)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RBS_MC_PAPEL_E");

                entity.Property(e => e.RbsMcPapelsc)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RBS_MC_PAPELSC")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RbsMcPapelsce)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RBS_MC_PAPELSCE");

                entity.Property(e => e.Rcomision)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RCOMISION")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RecalcularMargen)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Refinado)
                    .HasColumnType("decimal(4, 2)")
                    .HasColumnName("REFINADO");

                entity.Property(e => e.RefinadoEn)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("REFINADO_EN")
                    .IsFixedLength();

                entity.Property(e => e.Regular)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REGULAR")
                    .IsFixedLength();

                entity.Property(e => e.RifEntregar)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("RIF_ENTREGAR")
                    .IsFixedLength();

                entity.Property(e => e.RifFacturar)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("RIF_FACTURAR")
                    .IsFixedLength();

                entity.Property(e => e.RifImprimir)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("RIF_IMPRIMIR")
                    .IsFixedLength();

                entity.Property(e => e.RollosCtd1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ROLLOS_CTD1");

                entity.Property(e => e.RollosCtd2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ROLLOS_CTD2");

                entity.Property(e => e.RollosCtd3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ROLLOS_CTD3");

                entity.Property(e => e.RollosPts1)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ROLLOS_PTS1")
                    .IsFixedLength();

                entity.Property(e => e.RollosPts2)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ROLLOS_PTS2")
                    .IsFixedLength();

                entity.Property(e => e.RollosPts3)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ROLLOS_PTS3")
                    .IsFixedLength();

                entity.Property(e => e.RollosRod1).HasColumnName("ROLLOS_ROD1");

                entity.Property(e => e.RollosRod2).HasColumnName("ROLLOS_ROD2");

                entity.Property(e => e.RollosRod3).HasColumnName("ROLLOS_ROD3");

                entity.Property(e => e.RprecioLista)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RPRECIO_LISTA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RprecioVenta)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RPRECIO_VENTA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Rtasa)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("RTASA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RtasaUsd)
                    .HasColumnType("numeric(20, 4)")
                    .HasColumnName("RTasaUsd")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RtotalLista)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RTOTAL_LISTA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RtotalListaEx)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RTOTAL_LISTA_EX")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RtotalVenta)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RTOTAL_VENTA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RtotalVentaEx)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RTOTAL_VENTA_EX")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SalidaPreCab)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SALIDA_PRE_CAB")
                    .IsFixedLength();

                entity.Property(e => e.SalidaPrePie)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SALIDA_PRE_PIE")
                    .IsFixedLength();

                entity.Property(e => e.SegTintaFte)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("SEG_TINTA_FTE")
                    .IsFixedLength();

                entity.Property(e => e.SegTintaResp)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("SEG_TINTA_RESP")
                    .IsFixedLength();

                entity.Property(e => e.SexTintaFte)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("SEX_TINTA_FTE")
                    .IsFixedLength();

                entity.Property(e => e.SiColetilla)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SI_COLETILLA")
                    .HasDefaultValueSql("('X')")
                    .IsFixedLength();

                entity.Property(e => e.SiDolares)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SI_DOLARES")
                    .HasDefaultValueSql("('X')")
                    .IsFixedLength();

                entity.Property(e => e.SiIndexado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SI_INDEXADO")
                    .IsFixedLength();

                entity.Property(e => e.Solido)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SOLIDO")
                    .IsFixedLength();

                entity.Property(e => e.StatusOrden)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("STATUS_ORDEN")
                    .IsFixedLength();

                entity.Property(e => e.Supervisor)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SUPERVISOR")
                    .IsFixedLength();

                entity.Property(e => e.Tabla).HasColumnName("TABLA");

                entity.Property(e => e.TalonExtra)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("TALON_EXTRA")
                    .IsFixedLength();

                entity.Property(e => e.Tasa)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("TASA");

                entity.Property(e => e.TasaUsd).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.TercTintaFte)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("TERC_TINTA_FTE")
                    .IsFixedLength();

                entity.Property(e => e.TercTintaResp)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("TERC_TINTA_RESP")
                    .IsFixedLength();

                entity.Property(e => e.TipoCaja)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_CAJA")
                    .IsFixedLength();

                entity.Property(e => e.TipoEmpaque)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_EMPAQUE")
                    .IsFixedLength();

                entity.Property(e => e.TipoProducto)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_PRODUCTO")
                    .IsFixedLength();

                entity.Property(e => e.TotalLista)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("TOTAL_LISTA");

                entity.Property(e => e.TotalListaExt)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("TOTAL_LISTA_EXT");

                entity.Property(e => e.TotalPropuestaUsd).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.TotalVenta)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("TOTAL_VENTA");

                entity.Property(e => e.TotalVentaExt)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("TOTAL_VENTA_EXT");

                entity.Property(e => e.TotalVentareconvertido)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("TOTAL_VENTAReconvertido");

                entity.Property(e => e.TranfTapeEf)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TRANF_TAPE_EF")
                    .IsFixedLength();

                entity.Property(e => e.TranfTapePerm)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TRANF_TAPE_PERM")
                    .IsFixedLength();

                entity.Property(e => e.TranfTapeRem)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TRANF_TAPE_REM")
                    .IsFixedLength();

                entity.Property(e => e.Vendedor)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("VENDEDOR")
                    .IsFixedLength();

                entity.Property(e => e.VentaTotDolar)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("VENTA_TOT_DOLAR");

                entity.Property(e => e.VentaUnitDol)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("VENTA_UNIT_DOL");

                entity.Property(e => e.VinetaImpresa)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("VINETA_IMPRESA")
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.Web)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("WEB")
                    .IsFixedLength();

                entity.Property(e => e.Ws)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("WS")
                    .HasDefaultValueSql("('HOST_NAME()')");

                entity.HasOne(d => d.ClienteNavigation)
                    .WithMany(p => p.Cpry012s)
                    .HasForeignKey(d => d.Cliente)
                    .HasConstraintName("FK_CPRY012_Clientes");
            });

            modelBuilder.Entity<Cpry012antesReconversion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CPRY012AntesReconversion");

                entity.Property(e => e.Adelantada)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ADELANTADA");

                entity.Property(e => e.An8entregar)
                    .HasColumnType("decimal(14, 0)")
                    .HasColumnName("AN8ENTREGAR");

                entity.Property(e => e.An8facturar)
                    .HasColumnType("decimal(14, 0)")
                    .HasColumnName("AN8FACTURAR");

                entity.Property(e => e.AnchosPts1)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANCHOS_PTS1")
                    .IsFixedLength();

                entity.Property(e => e.AnchosPts2)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANCHOS_PTS2")
                    .IsFixedLength();

                entity.Property(e => e.AnchosRod1)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ANCHOS_ROD1")
                    .IsFixedLength();

                entity.Property(e => e.AnchosRod2)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ANCHOS_ROD2")
                    .IsFixedLength();

                entity.Property(e => e.Anticipo).HasColumnName("ANTICIPO");

                entity.Property(e => e.AnticipoJde)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("ANTICIPO_JDE");

                entity.Property(e => e.Anulada)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ANULADA")
                    .IsFixedLength();

                entity.Property(e => e.AutorizaAde)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTORIZA_ADE");

                entity.Property(e => e.BsMcFinan)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("BS_MC_FINAN");

                entity.Property(e => e.BsMcFinanE)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("BS_MC_FINAN_E");

                entity.Property(e => e.BsMcFinansc)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("BS_MC_FINANSC");

                entity.Property(e => e.BsMcFinansce)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("BS_MC_FINANSCE");

                entity.Property(e => e.BsMcPapel)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("BS_MC_PAPEL");

                entity.Property(e => e.BsMcPapelE)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("BS_MC_PAPEL_E");

                entity.Property(e => e.BsMcPapelsc)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("BS_MC_PAPELSC");

                entity.Property(e => e.BsMcPapelsce)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("BS_MC_PAPELSCE");

                entity.Property(e => e.CambioCompo)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("CAMBIO_COMPO");

                entity.Property(e => e.CantAProducir).HasColumnName("CANT_A_PRODUCIR");

                entity.Property(e => e.CantCajas).HasColumnName("CANT_CAJAS");

                entity.Property(e => e.CantFacturada).HasColumnName("CANT_FACTURADA");

                entity.Property(e => e.CantOrdenada).HasColumnName("CANT_ORDENADA");

                entity.Property(e => e.CantProducida).HasColumnName("CANT_PRODUCIDA");

                entity.Property(e => e.CantProgramada).HasColumnName("CANT_PROGRAMADA");

                entity.Property(e => e.CantXCajas).HasColumnName("CANT_X_CAJAS");

                entity.Property(e => e.CantXPaq).HasColumnName("CANT_X_PAQ");

                entity.Property(e => e.CantidadRodada)
                    .HasColumnType("decimal(14, 0)")
                    .HasColumnName("CANTIDAD_RODADA");

                entity.Property(e => e.ClaseOrden)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CLASE_ORDEN")
                    .IsFixedLength();

                entity.Property(e => e.Cliente).HasColumnName("CLIENTE");

                entity.Property(e => e.CodAplicacion).HasColumnName("COD_APLICACION");

                entity.Property(e => e.CodBacklogRet).HasColumnName("COD_BACKLOG_RET");

                entity.Property(e => e.CodProducto)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("COD_PRODUCTO")
                    .IsFixedLength();

                entity.Property(e => e.CodTeleop)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("COD_TELEOP")
                    .IsFixedLength();

                entity.Property(e => e.Comision)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("COMISION");

                entity.Property(e => e.CondPago).HasColumnName("COND_PAGO");

                entity.Property(e => e.CondicionProdu)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CONDICION_PRODU")
                    .IsFixedLength();

                entity.Property(e => e.ConsArchivo).HasColumnName("CONS_ARCHIVO");

                entity.Property(e => e.Cortado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CORTADO")
                    .IsFixedLength();

                entity.Property(e => e.CostoSap).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Cotizacion)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("COTIZACION")
                    .IsFixedLength();

                entity.Property(e => e.CtdEntregada).HasColumnName("CTD_ENTREGADA");

                entity.Property(e => e.CtdNc).HasColumnName("CTD_NC");

                entity.Property(e => e.CteEntregar)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("CTE_ENTREGAR")
                    .IsFixedLength();

                entity.Property(e => e.CteFacturar)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("CTE_FACTURAR")
                    .IsFixedLength();

                entity.Property(e => e.CuarTintaFte)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CUAR_TINTA_FTE")
                    .IsFixedLength();

                entity.Property(e => e.DescProducto)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESC_PRODUCTO")
                    .IsFixedLength();

                entity.Property(e => e.DirecEntregar)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("DIREC_ENTREGAR")
                    .IsFixedLength();

                entity.Property(e => e.DirecEntregar2)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("DIREC_ENTREGAR2")
                    .IsFixedLength();

                entity.Property(e => e.DirecEntregar3)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("DIREC_ENTREGAR3")
                    .IsFixedLength();

                entity.Property(e => e.DirecFacturar)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("DIREC_FACTURAR")
                    .IsFixedLength();

                entity.Property(e => e.DirecFacturar2)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("DIREC_FACTURAR2")
                    .IsFixedLength();

                entity.Property(e => e.DirecFacturar3)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("DIREC_FACTURAR3")
                    .IsFixedLength();

                entity.Property(e => e.Doblez)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DOBLEZ")
                    .IsFixedLength();

                entity.Property(e => e.EmbReverso)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("EMB_REVERSO")
                    .IsFixedLength();

                entity.Property(e => e.EmpacarEn)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("EMPACAR_EN")
                    .IsFixedLength();

                entity.Property(e => e.EngomaCarbCol)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ENGOMA_CARB_COL")
                    .IsFixedLength();

                entity.Property(e => e.EngomaCarbPre)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ENGOMA_CARB_PRE")
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ESTADO")
                    .IsFixedLength();

                entity.Property(e => e.EstadoEntregar).HasMaxLength(2);

                entity.Property(e => e.EstadoFacturar).HasMaxLength(2);

                entity.Property(e => e.Excepcion)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("EXCEPCION")
                    .IsFixedLength();

                entity.Property(e => e.FacturaDolar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FACTURA_DOLAR")
                    .IsFixedLength();

                entity.Property(e => e.FamiliaProduct)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("FAMILIA_PRODUCT")
                    .IsFixedLength();

                entity.Property(e => e.FecCierreOrd)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FEC_CIERRE_ORD");

                entity.Property(e => e.FecComproClte)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FEC_COMPRO_CLTE");

                entity.Property(e => e.FecCreditos)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FEC_CREDITOS");

                entity.Property(e => e.FecProgramada)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FEC_PROGRAMADA");

                entity.Property(e => e.FecRecibPlant)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FEC_RECIB_PLANT");

                entity.Property(e => e.FecRegVentas)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FEC_REG_VENTAS");

                entity.Property(e => e.FecTransmision)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FEC_TRANSMISION");

                entity.Property(e => e.FechaArchivo)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FECHA_ARCHIVO");

                entity.Property(e => e.FechaCalculo)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FECHA_CALCULO");

                entity.Property(e => e.FechaDolar)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FECHA_DOLAR");

                entity.Property(e => e.FechaTasa).HasColumnType("smalldatetime");

                entity.Property(e => e.Fiscal)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FISCAL")
                    .IsFixedLength();

                entity.Property(e => e.FlagActivo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_ACTIVO")
                    .IsFixedLength();

                entity.Property(e => e.FlagFactura)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_FACTURA")
                    .IsFixedLength();

                entity.Property(e => e.FlagProdInter)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_PROD_INTER")
                    .IsFixedLength();

                entity.Property(e => e.FlagSoportev)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_SOPORTEV")
                    .IsFixedLength();

                entity.Property(e => e.FlagV19)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_V19")
                    .IsFixedLength();

                entity.Property(e => e.FormasUndFact).HasColumnName("FORMAS_UND_FACT");

                entity.Property(e => e.GomaRegPtes)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GOMA_REG_PTES")
                    .IsFixedLength();

                entity.Property(e => e.IdDirEntregar).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IdDirFacturar).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IdSolicitud).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IdSolicitud2).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IdSolicitudCosto).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IdSolicitudReoperacion).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Idcalendar).HasColumnName("IDCALENDAR");

                entity.Property(e => e.Idcalendar2)
                    .IsRequired()
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("IDCALENDAR2");

                entity.Property(e => e.Impout)
                    .HasColumnType("decimal(1, 0)")
                    .HasColumnName("IMPOUT");

                entity.Property(e => e.Impresion)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IMPRESION")
                    .IsFixedLength();

                entity.Property(e => e.ImprimeDol)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IMPRIME_DOL");

                entity.Property(e => e.Impvar)
                    .HasColumnType("decimal(1, 0)")
                    .HasColumnName("IMPVAR");

                entity.Property(e => e.InstFacturar)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("INST_FACTURAR")
                    .IsFixedLength();

                entity.Property(e => e.LineaAnt).HasColumnName("LINEA_ANT");

                entity.Property(e => e.LineaAntJde)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("LINEA_ANT_JDE");

                entity.Property(e => e.LineaIncoming).HasColumnName("LINEA_INCOMING");

                entity.Property(e => e.LineaProducto)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("LINEA_PRODUCTO")
                    .IsFixedLength();

                entity.Property(e => e.ListaTotDolar)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("LISTA_TOT_DOLAR");

                entity.Property(e => e.ListaUnitDol)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("LISTA_UNIT_DOL");

                entity.Property(e => e.LugarEnviar)
                    .HasColumnType("text")
                    .HasColumnName("LUGAR_ENVIAR");

                entity.Property(e => e.LugarProducir)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("LUGAR_PRODUCIR")
                    .IsFixedLength();

                entity.Property(e => e.MedidaBase).HasColumnName("MEDIDA_BASE");

                entity.Property(e => e.MedidaVariable).HasColumnName("MEDIDA_VARIABLE");

                entity.Property(e => e.MunicipioEntregar).HasMaxLength(2);

                entity.Property(e => e.MunicipioFacturar).HasMaxLength(2);

                entity.Property(e => e.NoTransmision).HasColumnName("NO_TRANSMISION");

                entity.Property(e => e.Nocalculamc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NOCALCULAMC");

                entity.Property(e => e.NombreCliente)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_CLIENTE")
                    .IsFixedLength();

                entity.Property(e => e.NombreProducto)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_PRODUCTO")
                    .IsFixedLength();

                entity.Property(e => e.NuTintasFrent).HasColumnName("NU_TINTAS_FRENT");

                entity.Property(e => e.NuTintasResp).HasColumnName("NU_TINTAS_RESP");

                entity.Property(e => e.NumeroTiras).HasColumnName("NUMERO_TIRAS");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.OrdenAnterior).HasColumnName("ORDEN_ANTERIOR");

                entity.Property(e => e.OrdenComb)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ORDEN_COMB")
                    .IsFixedLength();

                entity.Property(e => e.PCobranza)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("P_COBRANZA");

                entity.Property(e => e.POverger)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("P_OVERGER");

                entity.Property(e => e.POverride)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("P_OVERRIDE");

                entity.Property(e => e.POverrideCg)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("P_OVERRIDE_CG");

                entity.Property(e => e.POverrideG)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("P_OVERRIDE_G");

                entity.Property(e => e.POverrideGo)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("P_OVERRIDE_GO");

                entity.Property(e => e.Pais).HasColumnName("PAIS");

                entity.Property(e => e.PartesFormula).HasColumnName("PARTES_FORMULA");

                entity.Property(e => e.PartesTiras)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PARTES_TIRAS")
                    .IsFixedLength();

                entity.Property(e => e.PoncMargDer)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PONC_MARG_DER")
                    .IsFixedLength();

                entity.Property(e => e.PoncMargIzq)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PONC_MARG_IZQ")
                    .IsFixedLength();

                entity.Property(e => e.PoncheEsp)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PONCHE_ESP")
                    .IsFixedLength();

                entity.Property(e => e.PorcCom)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("PORC_COM");

                entity.Property(e => e.PorcComRegulada).HasColumnType("decimal(5, 3)");

                entity.Property(e => e.PorcMc)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("PORC_MC");

                entity.Property(e => e.PorcMcFinan)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("PORC_MC_FINAN");

                entity.Property(e => e.PorcMcFinanE)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("PORC_MC_FINAN_E");

                entity.Property(e => e.PorcMcFinansc)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("PORC_MC_FINANSC");

                entity.Property(e => e.PorcMcMinimo).HasColumnType("decimal(5, 3)");

                entity.Property(e => e.PorcMcPapel)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("PORC_MC_PAPEL");

                entity.Property(e => e.PorcMcPapelE)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("PORC_MC_PAPEL_E");

                entity.Property(e => e.PorcMcPapelsc)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("PORC_MC_PAPELSC");

                entity.Property(e => e.PorcMcfinansce)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("PORC_MCFINANSCE");

                entity.Property(e => e.PorcMcpapelsce)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("PORC_MCPAPELSCE");

                entity.Property(e => e.PorcRespSocial).HasColumnType("decimal(5, 3)");

                entity.Property(e => e.PosTirasF)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("POS_TIRAS_F")
                    .IsFixedLength();

                entity.Property(e => e.PosTirasR)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("POS_TIRAS_R")
                    .IsFixedLength();

                entity.Property(e => e.PrecioLista)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("PRECIO_LISTA");

                entity.Property(e => e.PrecioUnitarioUsd).HasColumnType("decimal(20, 4)");

                entity.Property(e => e.PrecioVenta)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("PRECIO_VENTA");

                entity.Property(e => e.PrefColeEsp)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PREF_COLE_ESP")
                    .IsFixedLength();

                entity.Property(e => e.PrefColeStd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PREF_COLE_STD")
                    .IsFixedLength();

                entity.Property(e => e.PrefPrenEsp)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PREF_PREN_ESP")
                    .IsFixedLength();

                entity.Property(e => e.PrefPrenStd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PREF_PREN_STD")
                    .IsFixedLength();

                entity.Property(e => e.PrimTintaFte)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("PRIM_TINTA_FTE")
                    .IsFixedLength();

                entity.Property(e => e.PrimTintaResp)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("PRIM_TINTA_RESP")
                    .IsFixedLength();

                entity.Property(e => e.QuintTintaFte)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("QUINT_TINTA_FTE")
                    .IsFixedLength();

                entity.Property(e => e.RbsMcFinan)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RBS_MC_FINAN");

                entity.Property(e => e.RbsMcFinanE)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RBS_MC_FINAN_E");

                entity.Property(e => e.RbsMcFinansc)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RBS_MC_FINANSC");

                entity.Property(e => e.RbsMcFinansce)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RBS_MC_FINANSCE");

                entity.Property(e => e.RbsMcPapel)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RBS_MC_PAPEL");

                entity.Property(e => e.RbsMcPapelE)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RBS_MC_PAPEL_E");

                entity.Property(e => e.RbsMcPapelsc)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RBS_MC_PAPELSC");

                entity.Property(e => e.RbsMcPapelsce)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RBS_MC_PAPELSCE");

                entity.Property(e => e.Rcomision)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RCOMISION");

                entity.Property(e => e.RecalcularMargen).HasMaxLength(1);

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Refinado)
                    .HasColumnType("decimal(4, 2)")
                    .HasColumnName("REFINADO");

                entity.Property(e => e.RefinadoEn)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("REFINADO_EN")
                    .IsFixedLength();

                entity.Property(e => e.Regular)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REGULAR")
                    .IsFixedLength();

                entity.Property(e => e.RifEntregar)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("RIF_ENTREGAR")
                    .IsFixedLength();

                entity.Property(e => e.RifFacturar)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("RIF_FACTURAR")
                    .IsFixedLength();

                entity.Property(e => e.RifImprimir)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("RIF_IMPRIMIR")
                    .IsFixedLength();

                entity.Property(e => e.RollosCtd1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ROLLOS_CTD1");

                entity.Property(e => e.RollosCtd2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ROLLOS_CTD2");

                entity.Property(e => e.RollosCtd3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ROLLOS_CTD3");

                entity.Property(e => e.RollosPts1)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ROLLOS_PTS1")
                    .IsFixedLength();

                entity.Property(e => e.RollosPts2)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ROLLOS_PTS2")
                    .IsFixedLength();

                entity.Property(e => e.RollosPts3)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ROLLOS_PTS3")
                    .IsFixedLength();

                entity.Property(e => e.RollosRod1).HasColumnName("ROLLOS_ROD1");

                entity.Property(e => e.RollosRod2).HasColumnName("ROLLOS_ROD2");

                entity.Property(e => e.RollosRod3).HasColumnName("ROLLOS_ROD3");

                entity.Property(e => e.RprecioLista)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RPRECIO_LISTA");

                entity.Property(e => e.RprecioVenta)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RPRECIO_VENTA");

                entity.Property(e => e.Rtasa)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("RTASA");

                entity.Property(e => e.RtotalLista)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RTOTAL_LISTA");

                entity.Property(e => e.RtotalListaEx)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RTOTAL_LISTA_EX");

                entity.Property(e => e.RtotalVenta)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RTOTAL_VENTA");

                entity.Property(e => e.RtotalVentaEx)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RTOTAL_VENTA_EX");

                entity.Property(e => e.SalidaPreCab)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SALIDA_PRE_CAB")
                    .IsFixedLength();

                entity.Property(e => e.SalidaPrePie)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SALIDA_PRE_PIE")
                    .IsFixedLength();

                entity.Property(e => e.SegTintaFte)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("SEG_TINTA_FTE")
                    .IsFixedLength();

                entity.Property(e => e.SegTintaResp)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("SEG_TINTA_RESP")
                    .IsFixedLength();

                entity.Property(e => e.SexTintaFte)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("SEX_TINTA_FTE")
                    .IsFixedLength();

                entity.Property(e => e.SiColetilla)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SI_COLETILLA")
                    .IsFixedLength();

                entity.Property(e => e.SiDolares)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SI_DOLARES")
                    .IsFixedLength();

                entity.Property(e => e.SiIndexado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SI_INDEXADO")
                    .IsFixedLength();

                entity.Property(e => e.Solido)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SOLIDO")
                    .IsFixedLength();

                entity.Property(e => e.StatusOrden)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("STATUS_ORDEN")
                    .IsFixedLength();

                entity.Property(e => e.Supervisor)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SUPERVISOR")
                    .IsFixedLength();

                entity.Property(e => e.Tabla).HasColumnName("TABLA");

                entity.Property(e => e.TalonExtra)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("TALON_EXTRA")
                    .IsFixedLength();

                entity.Property(e => e.Tasa)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("TASA");

                entity.Property(e => e.TasaUsd).HasColumnType("decimal(20, 4)");

                entity.Property(e => e.TercTintaFte)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("TERC_TINTA_FTE")
                    .IsFixedLength();

                entity.Property(e => e.TercTintaResp)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("TERC_TINTA_RESP")
                    .IsFixedLength();

                entity.Property(e => e.TipoCaja)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_CAJA")
                    .IsFixedLength();

                entity.Property(e => e.TipoEmpaque)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_EMPAQUE")
                    .IsFixedLength();

                entity.Property(e => e.TipoOrden)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_ORDEN")
                    .IsFixedLength();

                entity.Property(e => e.TipoProducto)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_PRODUCTO")
                    .IsFixedLength();

                entity.Property(e => e.TotalLista)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("TOTAL_LISTA");

                entity.Property(e => e.TotalListaExt)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("TOTAL_LISTA_EXT");

                entity.Property(e => e.TotalPropuestaUsd).HasColumnType("decimal(20, 4)");

                entity.Property(e => e.TotalVenta)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("TOTAL_VENTA");

                entity.Property(e => e.TotalVentaExt)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("TOTAL_VENTA_EXT");

                entity.Property(e => e.TotalVentareconvertido)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("TOTAL_VENTAReconvertido");

                entity.Property(e => e.TranfTapeEf)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TRANF_TAPE_EF")
                    .IsFixedLength();

                entity.Property(e => e.TranfTapePerm)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TRANF_TAPE_PERM")
                    .IsFixedLength();

                entity.Property(e => e.TranfTapeRem)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TRANF_TAPE_REM")
                    .IsFixedLength();

                entity.Property(e => e.Vendedor)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("VENDEDOR")
                    .IsFixedLength();

                entity.Property(e => e.VentaTotDolar)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("VENTA_TOT_DOLAR");

                entity.Property(e => e.VentaUnitDol)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("VENTA_UNIT_DOL");

                entity.Property(e => e.VinetaImpresa)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("VINETA_IMPRESA")
                    .IsFixedLength();

                entity.Property(e => e.Web)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("WEB")
                    .IsFixedLength();

                entity.Property(e => e.Ws)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("WS");
            });

            modelBuilder.Entity<Cpry013>(entity =>
            {
                entity.HasKey(e => e.Orden)
                    .HasName("CPRY013_INDEX01");

                entity.ToTable("CPRY013");

                entity.HasIndex(e => e.Recnum, "CPRY013_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.TipoOrden, e.FecRegVentas, e.Orden }, "CPRY013_INDEX02")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.NoTransmision, e.Recnum }, "CPRY013_INDEX03")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => e.Orden, "dep_cpry013orden");

                entity.Property(e => e.Orden)
                    .ValueGeneratedNever()
                    .HasColumnName("ORDEN");

                entity.Property(e => e.CantFacturada).HasColumnName("CANT_FACTURADA");

                entity.Property(e => e.CantOrdenada).HasColumnName("CANT_ORDENADA");

                entity.Property(e => e.CantProducida).HasColumnName("CANT_PRODUCIDA");

                entity.Property(e => e.CantProgramada).HasColumnName("CANT_PROGRAMADA");

                entity.Property(e => e.Cliente).HasColumnName("CLIENTE");

                entity.Property(e => e.CodBacklogRet).HasColumnName("COD_BACKLOG_RET");

                entity.Property(e => e.CodProducto)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("COD_PRODUCTO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CondicionProdu)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CONDICION_PRODU")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CuarTintaFte)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CUAR_TINTA_FTE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DescProducto)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DESC_PRODUCTO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ESTADO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FacturaDolar)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FACTURA_DOLAR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FamiliaProduct)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("FAMILIA_PRODUCT")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FecCierreOrd)
                    .HasColumnType("datetime")
                    .HasColumnName("FEC_CIERRE_ORD");

                entity.Property(e => e.FecComproClte)
                    .HasColumnType("datetime")
                    .HasColumnName("FEC_COMPRO_CLTE");

                entity.Property(e => e.FecCreditos)
                    .HasColumnType("datetime")
                    .HasColumnName("FEC_CREDITOS");

                entity.Property(e => e.FecProgramada)
                    .HasColumnType("datetime")
                    .HasColumnName("FEC_PROGRAMADA");

                entity.Property(e => e.FecRecibPlant)
                    .HasColumnType("datetime")
                    .HasColumnName("FEC_RECIB_PLANT");

                entity.Property(e => e.FecRegVentas)
                    .HasColumnType("datetime")
                    .HasColumnName("FEC_REG_VENTAS")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.FecTransmision)
                    .HasColumnType("datetime")
                    .HasColumnName("FEC_TRANSMISION");

                entity.Property(e => e.FlagActivo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_ACTIVO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagFactura)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_FACTURA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagProdInter)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_PROD_INTER")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.LineaIncoming).HasColumnName("LINEA_INCOMING");

                entity.Property(e => e.LineaProduccio)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("LINEA_PRODUCCIO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.LugarEnviar)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LUGAR_ENVIAR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.LugarProducir)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("LUGAR_PRODUCIR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.MedidaBase).HasColumnName("MEDIDA_BASE");

                entity.Property(e => e.MedidaVariable).HasColumnName("MEDIDA_VARIABLE");

                entity.Property(e => e.NoTransmision).HasColumnName("NO_TRANSMISION");

                entity.Property(e => e.NombreCliente)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_CLIENTE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NombreProducto)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_PRODUCTO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NuTintasFrent).HasColumnName("NU_TINTAS_FRENT");

                entity.Property(e => e.NuTintasResp).HasColumnName("NU_TINTAS_RESP");

                entity.Property(e => e.Pais).HasColumnName("PAIS");

                entity.Property(e => e.PartesFormula).HasColumnName("PARTES_FORMULA");

                entity.Property(e => e.PrecioLista)
                    .HasColumnType("decimal(12, 4)")
                    .HasColumnName("PRECIO_LISTA");

                entity.Property(e => e.PrecioVenta)
                    .HasColumnType("decimal(12, 4)")
                    .HasColumnName("PRECIO_VENTA");

                entity.Property(e => e.PrimTintaFte)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("PRIM_TINTA_FTE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PrimTintaResp)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("PRIM_TINTA_RESP")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.QuintTintaFte)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("QUINT_TINTA_FTE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.RprecioLista)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RPRECIO_LISTA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RprecioVenta)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RPRECIO_VENTA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RtotalLista)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RTOTAL_LISTA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RtotalListaEx)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RTOTAL_LISTA_EX")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RtotalVenta)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RTOTAL_VENTA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RtotalVentaEx)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RTOTAL_VENTA_EX")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SegTintaFte)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("SEG_TINTA_FTE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SegTintaResp)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("SEG_TINTA_RESP")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SexTintaFte)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("SEX_TINTA_FTE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Supervisor)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SUPERVISOR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TercTintaFte)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("TERC_TINTA_FTE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TercTintaResp)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("TERC_TINTA_RESP")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TipoEmpaque)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_EMPAQUE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TipoOrden)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_ORDEN")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TipoProducto)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_PRODUCTO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TotalLista)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("TOTAL_LISTA");

                entity.Property(e => e.TotalListaExt)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("TOTAL_LISTA_EXT");

                entity.Property(e => e.TotalVenta)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("TOTAL_VENTA");

                entity.Property(e => e.TotalVentaExt)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("TOTAL_VENTA_EXT");

                entity.Property(e => e.Vendedor)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("VENDEDOR")
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Cpry014>(entity =>
            {
                entity.HasKey(e => e.Orden)
                    .HasName("CPRY014_INDEX01");

                entity.ToTable("CPRY014");

                entity.HasIndex(e => e.Recnum, "CPRY014_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.CicloCompleto, e.Recnum }, "CPRY014_INDEX02")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.FechaArchivo, e.Orden, e.Recnum }, "CPRY014_INDEX03")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => e.Orden, "dep_cpry014orden");

                entity.Property(e => e.Orden)
                    .ValueGeneratedNever()
                    .HasColumnName("ORDEN");

                entity.Property(e => e.Anulada)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ANULADA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CicloCompleto)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CICLO_COMPLETO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DiasArchivo).HasColumnName("DIAS_ARCHIVO");

                entity.Property(e => e.DiasCalculo).HasColumnName("DIAS_CALCULO");

                entity.Property(e => e.DiasDocket).HasColumnName("DIAS_DOCKET");

                entity.Property(e => e.DiasPlaneacion).HasColumnName("DIAS_PLANEACION");

                entity.Property(e => e.DiasTrans).HasColumnName("DIAS_TRANS");

                entity.Property(e => e.FechaArchivo)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ARCHIVO")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.FechaCalculo)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_CALCULO");

                entity.Property(e => e.FechaDocket)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_DOCKET");

                entity.Property(e => e.FechaPlaneacio)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_PLANEACIO");

                entity.Property(e => e.FechaPrelimin)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_PRELIMIN");

                entity.Property(e => e.FechaTrans)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_TRANS");

                entity.Property(e => e.FecharPrelim)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAR_PRELIM");

                entity.Property(e => e.ImprDocket)
                    .HasColumnName("IMPR_DOCKET")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.TotalDias).HasColumnName("TOTAL_DIAS");

                entity.Property(e => e.UsuarioArchivo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_ARCHIVO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.UsuarioCalculo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_CALCULO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.UsuarioDocket)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_DOCKET")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.UsuarioPlaneac)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_PLANEAC")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.UsuarioTranscr)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_TRANSCR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.UsuariorPrelim)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USUARIOR_PRELIM");
            });

            modelBuilder.Entity<Cpry014a>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CPRY014A");

                entity.HasIndex(e => e.Orden, "dep_cpry014Aorden");

                entity.Property(e => e.Año)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("año");

                entity.Property(e => e.Estacion).HasMaxLength(50);

                entity.Property(e => e.Fecha)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.FechaUltimaActualizacion).HasColumnType("smalldatetime");

                entity.Property(e => e.Mes).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Orden).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(50)
                    .HasColumnName("usuario");

                entity.Property(e => e.UsuarioReporte).HasMaxLength(50);
            });

            modelBuilder.Entity<Cpry016>(entity =>
            {
                entity.HasKey(e => e.MedidaBasica)
                    .HasName("CPRY016_INDEX01");

                entity.ToTable("CPRY016");

                entity.HasIndex(e => e.Recnum, "CPRY016_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => e.MedidaDecimal, "CPRY016_INDEX02")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.MedidaBasica)
                    .ValueGeneratedNever()
                    .HasColumnName("MEDIDA_BASICA");

                entity.Property(e => e.CantSubMult).HasColumnName("CANT_SUB_MULT");

                entity.Property(e => e.MedidaCilindro).HasColumnName("MEDIDA_CILINDRO");

                entity.Property(e => e.MedidaDecimal)
                    .HasColumnType("decimal(6, 4)")
                    .HasColumnName("MEDIDA_DECIMAL");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");
            });

            modelBuilder.Entity<Cpry024>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("CPRY024_INDEX01");

                entity.ToTable("CPRY024");

                entity.HasIndex(e => e.Recnum, "CPRY024_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.Descripcion, e.Codigo }, "CPRY024_INDEX02")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.Codigo)
                    .ValueGeneratedNever()
                    .HasColumnName("CODIGO");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Fechaagrega)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAAGREGA");

                entity.Property(e => e.Fechamodifica)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAMODIFICA");

                entity.Property(e => e.Flaginactivo)
                    .HasMaxLength(1)
                    .HasColumnName("FLAGINACTIVO");

                entity.Property(e => e.Idcausa).HasColumnName("IDCAUSA");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Usuarioagrega)
                    .HasMaxLength(40)
                    .HasColumnName("USUARIOAGREGA");

                entity.Property(e => e.Usuariomodifica)
                    .HasMaxLength(40)
                    .HasColumnName("USUARIOMODIFICA");
            });

            modelBuilder.Entity<Cpry029>(entity =>
            {
                entity.HasKey(e => new { e.CodigoProducto, e.MedidaBasica, e.NoPrensa })
                    .HasName("CPRY029_INDEX01");

                entity.ToTable("CPRY029");

                entity.HasIndex(e => e.Recnum, "CPRY029_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.CodigoProducto)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO_PRODUCTO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.MedidaBasica).HasColumnName("MEDIDA_BASICA");

                entity.Property(e => e.NoPrensa).HasColumnName("NO_PRENSA");

                entity.Property(e => e.CantidadMillar).HasColumnName("CANTIDAD_MILLAR");

                entity.Property(e => e.CantidadTintas).HasColumnName("CANTIDAD_TINTAS");

                entity.Property(e => e.MedidaNoBasic).HasColumnName("MEDIDA_NO_BASIC");

                entity.Property(e => e.NoDePartes).HasColumnName("NO_DE_PARTES");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");
            });

            modelBuilder.Entity<Cpry030>(entity =>
            {
                entity.HasKey(e => new { e.CodigoProducto, e.MedidaBasica, e.NoColectora })
                    .HasName("CPRY030_INDEX01");

                entity.ToTable("CPRY030");

                entity.HasIndex(e => e.Recnum, "CPRY030_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.CodigoProducto)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO_PRODUCTO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.MedidaBasica).HasColumnName("MEDIDA_BASICA");

                entity.Property(e => e.NoColectora).HasColumnName("NO_COLECTORA");

                entity.Property(e => e.CantidadMinima).HasColumnName("CANTIDAD_MINIMA");

                entity.Property(e => e.MedidaNoBasic).HasColumnName("MEDIDA_NO_BASIC");

                entity.Property(e => e.NoDePartes).HasColumnName("NO_DE_PARTES");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");
            });

            modelBuilder.Entity<Cpry031>(entity =>
            {
                entity.HasKey(e => new { e.Idtitulo, e.Codigooficina })
                    .HasName("CPRY031_INDEX01");

                entity.ToTable("CPRY031");

                entity.HasIndex(e => e.Recnum, "CPRY031_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.Idtitulo).HasColumnName("IDTITULO");

                entity.Property(e => e.Codigooficina).HasColumnName("CODIGOOFICINA");

                entity.Property(e => e.Acabado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ACABADO")
                    .IsFixedLength();

                entity.Property(e => e.Arte)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ARTE")
                    .IsFixedLength();

                entity.Property(e => e.Bcs)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BCS")
                    .IsFixedLength();

                entity.Property(e => e.CodigoProducto)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO_PRODUCTO")
                    .IsFixedLength();

                entity.Property(e => e.Colectoras)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("COLECTORAS")
                    .IsFixedLength();

                entity.Property(e => e.CriticoAcabado).HasColumnName("CRITICO_ACABADO");

                entity.Property(e => e.CriticoArte).HasColumnName("CRITICO_ARTE");

                entity.Property(e => e.CriticoBcs).HasColumnName("CRITICO_BCS");

                entity.Property(e => e.CriticoColecto).HasColumnName("CRITICO_COLECTO");

                entity.Property(e => e.CriticoEmbarq).HasColumnName("CRITICO_EMBARQ");

                entity.Property(e => e.CriticoFoto).HasColumnName("CRITICO_FOTO");

                entity.Property(e => e.CriticoPlaneac).HasColumnName("CRITICO_PLANEAC");

                entity.Property(e => e.CriticoPrensas).HasColumnName("CRITICO_PRENSAS");

                entity.Property(e => e.DiasAcabado).HasColumnName("DIAS_ACABADO");

                entity.Property(e => e.DiasArte).HasColumnName("DIAS_ARTE");

                entity.Property(e => e.DiasBcs).HasColumnName("DIAS_BCS");

                entity.Property(e => e.DiasColectoras).HasColumnName("DIAS_COLECTORAS");

                entity.Property(e => e.DiasEmbarque).HasColumnName("DIAS_EMBARQUE");

                entity.Property(e => e.DiasFoto).HasColumnName("DIAS_FOTO");

                entity.Property(e => e.DiasPlaneacion).HasColumnName("DIAS_PLANEACION");

                entity.Property(e => e.DiasPrensas).HasColumnName("DIAS_PRENSAS");

                entity.Property(e => e.Embarque)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("EMBARQUE")
                    .IsFixedLength();

                entity.Property(e => e.Foto)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FOTO")
                    .IsFixedLength();

                entity.Property(e => e.Planeacion)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PLANEACION")
                    .IsFixedLength();

                entity.Property(e => e.Prensas)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PRENSAS")
                    .IsFixedLength();

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.TipoDeOrden)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_DE_ORDEN")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Cpry033>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("CPRY033_INDEX01");

                entity.ToTable("CPRY033");

                entity.HasIndex(e => e.Recnum, "CPRY033_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.Codigo)
                    .ValueGeneratedNever()
                    .HasColumnName("CODIGO");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");
            });

            modelBuilder.Entity<Cpry034>(entity =>
            {
                entity.HasKey(e => e.CentroCosto)
                    .HasName("CPRY034_INDEX01");

                entity.ToTable("CPRY034");

                entity.HasIndex(e => e.Recnum, "CPRY034_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.Nombre, e.CentroCosto }, "CPRY034_INDEX02")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.CentroCosto)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CENTRO_COSTO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CtaContable)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("CTA_CONTABLE");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");
            });

            modelBuilder.Entity<Cpry035>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("CPRY035_INDEX01");

                entity.ToTable("CPRY035");

                entity.HasIndex(e => e.Recnum, "CPRY035_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.Codigo)
                    .ValueGeneratedNever()
                    .HasColumnName("CODIGO");

                entity.Property(e => e.CantidadReserv).HasColumnName("CANTIDAD_RESERV");

                entity.Property(e => e.ConsSemesUnid).HasColumnName("CONS_SEMES_UNID");

                entity.Property(e => e.ConsSemesValo)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("CONS_SEMES_VALO");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.EntradMesUnid).HasColumnName("ENTRAD_MES_UNID");

                entity.Property(e => e.EntradMesVal)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("ENTRAD_MES_VAL");

                entity.Property(e => e.ExiFinMesUni).HasColumnName("EXI_FIN_MES_UNI");

                entity.Property(e => e.ExiFinMesVal)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("EXI_FIN_MES_VAL");

                entity.Property(e => e.ExiIniMesUni).HasColumnName("EXI_INI_MES_UNI");

                entity.Property(e => e.ExiIniMesVal)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("EXI_INI_MES_VAL");

                entity.Property(e => e.ExistActual).HasColumnName("EXIST_ACTUAL");

                entity.Property(e => e.ExistMaxima).HasColumnName("EXIST_MAXIMA");

                entity.Property(e => e.ExistMinima).HasColumnName("EXIST_MINIMA");

                entity.Property(e => e.Familia).HasColumnName("FAMILIA");

                entity.Property(e => e.Localiz)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("LOCALIZ")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Reorden).HasColumnName("REORDEN");

                entity.Property(e => e.SalidMesUnida).HasColumnName("SALID_MES_UNIDA");

                entity.Property(e => e.SalidMesValor)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("SALID_MES_VALOR");

                entity.Property(e => e.UltCompraCost).HasColumnName("ULT_COMPRA_COST");

                entity.Property(e => e.UltCompraFech)
                    .HasColumnType("datetime")
                    .HasColumnName("ULT_COMPRA_FECH");

                entity.Property(e => e.UltCompraUnid).HasColumnName("ULT_COMPRA_UNID");
            });

            modelBuilder.Entity<Cpry043>(entity =>
            {
                entity.HasKey(e => e.CodigoMaquina)
                    .HasName("CPRY043_INDEX01");

                entity.ToTable("CPRY043");

                entity.HasIndex(e => e.Recnum, "CPRY043_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => e.Descripcion, "CPRY043_INDEX02")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => e.Abreviado, "CPRY043_INDEX03")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.CodigoMaquina)
                    .ValueGeneratedNever()
                    .HasColumnName("CODIGO_MAQUINA");

                entity.Property(e => e.Abreviado)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("ABREVIADO")
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.AnchoRodillo1).HasColumnName("ANCHO_RODILLO1");

                entity.Property(e => e.AnchoRodillo2).HasColumnName("ANCHO_RODILLO2");

                entity.Property(e => e.Bshora)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("BSHORA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Capacidad).HasColumnName("CAPACIDAD");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DiasHistoricos).HasColumnName("DIAS_HISTORICOS");

                entity.Property(e => e.Diasdisp)
                    .HasColumnName("DIASDISP")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Eficiencia)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("EFICIENCIA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.FlagDoblaPren)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_DOBLA_PREN")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagManualauto)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_MANUALAUTO");

                entity.Property(e => e.HorasTrabajo)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("HORAS_TRABAJO");

                entity.Property(e => e.HorasXOrden)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("HORAS_X_ORDEN");

                entity.Property(e => e.HorasxordenCon)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("HORASXORDEN_CON");

                entity.Property(e => e.ImprimeColecta)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IMPRIME_COLECTA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ObjVelCon).HasColumnName("OBJ_VEL_CON");

                entity.Property(e => e.ObjVelocidad).HasColumnName("OBJ_VELOCIDAD");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PERIODO");

                entity.Property(e => e.PorcDirCon)
                    .HasColumnType("decimal(8, 4)")
                    .HasColumnName("PORC_DIR_CON");

                entity.Property(e => e.PorcDirectos)
                    .HasColumnType("decimal(8, 4)")
                    .HasColumnName("PORC_DIRECTOS");

                entity.Property(e => e.PorcIndCon)
                    .HasColumnType("decimal(8, 4)")
                    .HasColumnName("PORC_IND_CON");

                entity.Property(e => e.PorcIndirectos)
                    .HasColumnType("decimal(8, 4)")
                    .HasColumnName("PORC_INDIRECTOS");

                entity.Property(e => e.PorcPreCon)
                    .HasColumnType("decimal(8, 4)")
                    .HasColumnName("PORC_PRE_CON");

                entity.Property(e => e.PorcPrep)
                    .HasColumnType("decimal(8, 4)")
                    .HasColumnName("PORC_PREP");

                entity.Property(e => e.PorcRodCon)
                    .HasColumnType("decimal(8, 4)")
                    .HasColumnName("PORC_ROD_CON");

                entity.Property(e => e.PorcRodada)
                    .HasColumnType("decimal(8, 4)")
                    .HasColumnName("PORC_RODADA");

                entity.Property(e => e.Pplana)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PPLANA");

                entity.Property(e => e.Rbshora)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RBSHORA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.TipoDeMaquina).HasColumnName("TIPO_DE_MAQUINA");

                entity.Property(e => e.TituloGrupo)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("TITULO_GRUPO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TituloReporte)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("TITULO_REPORTE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Turnos).HasColumnName("TURNOS");

                entity.Property(e => e.UsaContador)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("USA_CONTADOR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.VelocidadNom).HasColumnName("VELOCIDAD_NOM");
            });

            modelBuilder.Entity<Cpry047>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("CPRY047_INDEX01");

                entity.ToTable("CPRY047");

                entity.HasIndex(e => e.Recnum, "CPRY047_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.Descripcion, e.Codigo }, "CPRY047_INDEX02")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.Codigo)
                    .ValueGeneratedNever()
                    .HasColumnName("CODIGO");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Responsable)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("RESPONSABLE")
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Cpry051>(entity =>
            {
                entity.HasKey(e => e.CodigoEmpleado)
                    .HasName("CPRY051_INDEX01");

                entity.ToTable("CPRY051");

                entity.HasIndex(e => e.Recnum, "CPRY051_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.Nombre, e.CodigoEmpleado }, "CPRY051_INDEX02")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.CodigoEmpleado)
                    .ValueGeneratedNever()
                    .HasColumnName("CODIGO_EMPLEADO");

                entity.Property(e => e.CtaContable)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("CTA_CONTABLE");

                entity.Property(e => e.Departamento).HasColumnName("DEPARTAMENTO");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");
            });

            modelBuilder.Entity<Cpry054>(entity =>
            {
                entity.HasKey(e => e.NoComprobante)
                    .HasName("CPRY054_INDEX01");

                entity.ToTable("CPRY054");

                entity.HasIndex(e => e.Recnum, "CPRY054_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.Orden, e.NoComprobante }, "CPRY054_INDEX02")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.TipoOrden, e.NoComprobante, e.Orden }, "CPRY054_INDEX03")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.Cliente, e.NoComprobante }, "CPRY054_INDEX04")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.FechaProduccio, e.NoComprobante }, "CPRY054_INDEX05")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.Orden, e.FechaProduccio, e.NoComprobante }, "CPRY054_INDEX06")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.NoComprobante)
                    .ValueGeneratedNever()
                    .HasColumnName("NO_COMPROBANTE");

                entity.Property(e => e.Cajas).HasColumnName("CAJAS");

                entity.Property(e => e.CantFacturada).HasColumnName("CANT_FACTURADA");

                entity.Property(e => e.CantidadProd).HasColumnName("CANTIDAD_PROD");

                entity.Property(e => e.Cliente).HasColumnName("CLIENTE");

                entity.Property(e => e.DeptoRecibido).HasColumnName("DEPTO_RECIBIDO");

                entity.Property(e => e.FecRecPlaneac)
                    .HasColumnType("datetime")
                    .HasColumnName("FEC_REC_PLANEAC");

                entity.Property(e => e.FechaEliminada)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ELIMINADA");

                entity.Property(e => e.FechaFactura)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_FACTURA");

                entity.Property(e => e.FechaProduccio)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_PRODUCCIO")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.FlagTipoJob)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_TIPO_JOB")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.HoraProduccion).HasColumnName("HORA_PRODUCCION");

                entity.Property(e => e.JobId).HasColumnName("JOB_ID");

                entity.Property(e => e.MotivoEliminad).HasColumnName("MOTIVO_ELIMINAD");

                entity.Property(e => e.NoFactura).HasColumnName("NO_FACTURA");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Supervisor)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SUPERVISOR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TipoOrden)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_ORDEN")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TotalParcial)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TOTAL_PARCIAL")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.UserElimina)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("USER_ELIMINA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Vendedor)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("VENDEDOR")
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Cpry058>(entity =>
            {
                entity.HasKey(e => new { e.JobId, e.Recnum })
                    .HasName("CPRY058_INDEX01");

                entity.ToTable("CPRY058");

                entity.HasIndex(e => e.Recnum, "CPRY058_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.Pais, e.LineaProduccio, e.Orden, e.JobId, e.Recnum }, "CPRY058_INDEX02")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.Pais, e.Orden, e.Recnum }, "CPRY058_INDEX03")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.JobId).HasColumnName("JOB_ID");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Factura).HasColumnName("FACTURA");

                entity.Property(e => e.FechaDespacho)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_DESPACHO");

                entity.Property(e => e.FechaFactura)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_FACTURA");

                entity.Property(e => e.FechaRecCte)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_REC_CTE");

                entity.Property(e => e.LineaProduccio)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("LINEA_PRODUCCIO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NoEntrega).HasColumnName("NO_ENTREGA");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.Pais).HasColumnName("PAIS");

                entity.Property(e => e.TipoDoc).HasColumnName("TIPO_DOC");
            });

            modelBuilder.Entity<Cpry059>(entity =>
            {
                entity.HasKey(e => new { e.Depto, e.LineaProduccio, e.Prensa, e.Orden, e.JobId })
                    .HasName("CPRY059_INDEX01");

                entity.ToTable("CPRY059");

                entity.HasIndex(e => e.Recnum, "CPRY059_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.Depto, e.Vendedor, e.LineaProduccio, e.JobId }, "CPRY059_INDEX02")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.Depto, e.FechaEntrega, e.Orden, e.Recnum }, "CPRY059_INDEX03")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.Depto, e.Prensa, e.FechaEntrega, e.Recnum }, "CPRY059_INDEX04")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.Depto, e.Orden, e.Recnum }, "CPRY059_INDEX05")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.Prensa, e.Orden, e.Recnum }, "CPRY059_INDEX06")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.Colect, e.Cantidad, e.Papel1, e.Papel2, e.JobId, e.Recnum }, "CPRY059_INDEX07")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.Depto).HasColumnName("DEPTO");

                entity.Property(e => e.LineaProduccio)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("LINEA_PRODUCCIO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Prensa).HasColumnName("PRENSA");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.JobId).HasColumnName("JOB_ID");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.Colect).HasColumnName("COLECT");

                entity.Property(e => e.FechaEntrad)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ENTRAD");

                entity.Property(e => e.FechaEntrega)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ENTREGA")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.Pais).HasColumnName("PAIS");

                entity.Property(e => e.Papel1)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("PAPEL1")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Papel2)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("PAPEL2")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.RvalorLista)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RVALOR_LISTA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RvalorVenta)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RVALOR_VENTA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorLista)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("VALOR_LISTA");

                entity.Property(e => e.ValorVenta)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("VALOR_VENTA");

                entity.Property(e => e.Vendedor).HasColumnName("VENDEDOR");
            });

            modelBuilder.Entity<Cpry060>(entity =>
            {
                entity.HasKey(e => new { e.CodigoMaquina, e.RolloDoblado, e.Recnum })
                    .HasName("CPRY060_INDEX01");

                entity.ToTable("CPRY060");

                entity.HasIndex(e => e.Recnum, "CPRY060_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.CodigoMaquina).HasColumnName("CODIGO_MAQUINA");

                entity.Property(e => e.RolloDoblado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ROLLO_DOBLADO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Anchos).HasColumnName("ANCHOS");

                entity.Property(e => e.Bolivares)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("BOLIVARES");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.LineaProd).HasColumnName("LINEA_PROD");

                entity.Property(e => e.MedidaBase).HasColumnName("MEDIDA_BASE");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.PartesFormula).HasColumnName("PARTES_FORMULA");

                entity.Property(e => e.Rbolivares)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("RBOLIVARES")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<Cpry061>(entity =>
            {
                entity.HasKey(e => new { e.Oficina, e.EdoRuptura, e.McpoRuptura, e.Recnum })
                    .HasName("CPRY061_INDEX01");

                entity.ToTable("CPRY061");

                entity.HasIndex(e => e.Recnum, "CPRY061_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.Oficina).HasColumnName("OFICINA");

                entity.Property(e => e.EdoRuptura)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("EDO_RUPTURA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.McpoRuptura)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("MCPO_RUPTURA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.Depto).HasColumnName("DEPTO");

                entity.Property(e => e.Edo)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("EDO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Estacion)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ESTACION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Job).HasColumnName("JOB");

                entity.Property(e => e.Mcpo)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("MCPO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.RvalorVenta)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RVALOR_VENTA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorVenta)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("VALOR_VENTA");
            });

            modelBuilder.Entity<Cpry092>(entity =>
            {
                entity.HasKey(e => e.LoginName)
                    .HasName("CPRY092_INDEX01");

                entity.ToTable("CPRY092");

                entity.HasIndex(e => e.Recnum, "CPRY092_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.LoginName)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("LOGIN_NAME")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("FULL_NAME")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NoDeEntrega).HasColumnName("NO_DE_ENTREGA");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");
            });

            modelBuilder.Entity<Cpry093>(entity =>
            {
                entity.HasKey(e => e.CodProducto)
                    .HasName("CPRY093_INDEX01");

                entity.ToTable("CPRY093");

                entity.HasIndex(e => e.Recnum, "CPRY093_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.Medida, e.CodProducto }, "CPRY093_INDEX02")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.CodProducto)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("COD_PRODUCTO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FechaVigencia)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_VIGENCIA");

                entity.Property(e => e.Medida)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("MEDIDA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NumeroPartes).HasColumnName("NUMERO_PARTES");

                entity.Property(e => e.PrecioIntercom)
                    .HasColumnType("decimal(12, 4)")
                    .HasColumnName("PRECIO_INTERCOM");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.RprecioInterco)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RPRECIO_INTERCO")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<Cpry096>(entity =>
            {
                entity.HasKey(e => e.NoPedido)
                    .HasName("CPRY096_INDEX01");

                entity.ToTable("CPRY096");

                entity.HasIndex(e => e.Recnum, "CPRY096_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.NoPedido)
                    .ValueGeneratedNever()
                    .HasColumnName("NO_PEDIDO");

                entity.Property(e => e.AnoExist)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ANO_EXIST")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CambioEnCopy)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CAMBIO_EN_COPY")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CambioEspecif)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CAMBIO_ESPECIF")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Cliente).HasColumnName("CLIENTE");

                entity.Property(e => e.CodDivision).HasColumnName("COD_DIVISION");

                entity.Property(e => e.Correlativo).HasColumnName("CORRELATIVO");

                entity.Property(e => e.CteEstablecido)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CTE_ESTABLECIDO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CteNuevo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CTE_NUEVO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DesctoGCantid)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DESCTO_G_CANTID")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Embarque)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EMBARQUE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Factura)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FACTURA$")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA");

                entity.Property(e => e.FechaEntrega)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ENTREGA");

                entity.Property(e => e.FlagImpres)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_IMPRES")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Grupo01).HasColumnName("GRUPO_01");

                entity.Property(e => e.Grupo02).HasColumnName("GRUPO_02");

                entity.Property(e => e.ImpAOctava)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IMP_A_OCTAVA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ImpoASextos)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IMPO_A_SEXTOS")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Impresor)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("IMPRESOR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.InstFacturar)
                    .IsRequired()
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("INST_FACTURAR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.LugarEnviar)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("LUGAR_ENVIAR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.MesExist).HasColumnName("MES_EXIST");

                entity.Property(e => e.NoDiseno)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("NO_DISENO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.OperBasica).HasColumnName("OPER_BASICA");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.OrdenAnterior)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("ORDEN_ANTERIOR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.OrdenCliente)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ORDEN_CLIENTE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.OrdenNueva)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ORDEN_NUEVA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PaisProcedenci).HasColumnName("PAIS_PROCEDENCI");

                entity.Property(e => e.Porcent01).HasColumnName("PORCENT_01");

                entity.Property(e => e.Porcent02).HasColumnName("PORCENT_02");

                entity.Property(e => e.Prueba)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PRUEBA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.RepetExacta)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REPET_EXACTA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.RepetLimitada)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REPET_LIMITADA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Superv01)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SUPERV_01")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Superv02)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SUPERV_02")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TipoNegocio)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_NEGOCIO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TipoOrden).HasColumnName("TIPO_ORDEN");

                entity.Property(e => e.Vendedor01)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("VENDEDOR_01")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Vendedor02)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("VENDEDOR_02")
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Cpry097>(entity =>
            {
                entity.HasKey(e => e.NoPedido)
                    .HasName("CPRY097_INDEX01");

                entity.ToTable("CPRY097");

                entity.HasIndex(e => e.Recnum, "CPRY097_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.NoPedido)
                    .ValueGeneratedNever()
                    .HasColumnName("NO_PEDIDO");

                entity.Property(e => e.CantOrdenada).HasColumnName("CANT_ORDENADA");

                entity.Property(e => e.CodProducto)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("COD_PRODUCTO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Correlativo).HasColumnName("CORRELATIVO");

                entity.Property(e => e.DescProducto)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DESC_PRODUCTO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.PrecioFactura)
                    .HasColumnType("decimal(12, 4)")
                    .HasColumnName("PRECIO_FACTURA");

                entity.Property(e => e.PrecioLista)
                    .HasColumnType("decimal(12, 4)")
                    .HasColumnName("PRECIO_LISTA");

                entity.Property(e => e.PrecioVenta)
                    .HasColumnType("decimal(12, 4)")
                    .HasColumnName("PRECIO_VENTA");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.RprecioFactura)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RPRECIO_FACTURA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RprecioLista)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RPRECIO_LISTA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RprecioVenta)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RPRECIO_VENTA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RtotalLista)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RTOTAL_LISTA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RtotalVenta)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RTOTAL_VENTA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TipoProducto)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_PRODUCTO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TotalLista)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("TOTAL_LISTA");

                entity.Property(e => e.TotalVenta)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("TOTAL_VENTA");

                entity.Property(e => e.UnidadFactura)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("UNIDAD_FACTURA")
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Cpry098>(entity =>
            {
                entity.HasKey(e => new { e.NoPedido, e.NoPartePapel })
                    .HasName("CPRY098_INDEX01");

                entity.ToTable("CPRY098");

                entity.HasIndex(e => e.Recnum, "CPRY098_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.NoPedido).HasColumnName("NO_PEDIDO");

                entity.Property(e => e.NoPartePapel).HasColumnName("NO_PARTE_PAPEL");

                entity.Property(e => e.ClasePapel).HasColumnName("CLASE_PAPEL");

                entity.Property(e => e.ColorCarbon)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("COLOR_CARBON")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ColorPapel).HasColumnName("COLOR_PAPEL");

                entity.Property(e => e.ConPrimTintar)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CON_PRIM_TINTAR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CondCuarTinta)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("COND_CUAR_TINTA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CondPrimTinta)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("COND_PRIM_TINTA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CondQuinTinta)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("COND_QUIN_TINTA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CondSegTinta)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("COND_SEG_TINTA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CondSegTintar)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("COND_SEG_TINTAR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CondSexTinta)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("COND_SEX_TINTA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CondTerTintar)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("COND_TER_TINTAR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CondTercTinta)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("COND_TERC_TINTA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Correlativo).HasColumnName("CORRELATIVO");

                entity.Property(e => e.CuarTintaFren)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CUAR_TINTA_FREN")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.MedTalonDer)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("MED_TALON_DER")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.MedTalonIzq)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("MED_TALON_IZQ")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.MedidaPapel).HasColumnName("MEDIDA_PAPEL");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.PerfHorizontal)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PERF_HORIZONTAL")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PerfVertical)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PERF_VERTICAL")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PesoPapel).HasColumnName("PESO_PAPEL");

                entity.Property(e => e.PrimTintaFte)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("PRIM_TINTA_FTE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PrimTintaResp)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("PRIM_TINTA_RESP")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.QuinTintaFren)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("QUIN_TINTA_FREN")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.SegTintaFrent)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("SEG_TINTA_FRENT")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SegTintaResp)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("SEG_TINTA_RESP")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SexTintaFren)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("SEX_TINTA_FREN")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TercTintaFren)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TERC_TINTA_FREN")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TercTintaResp)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TERC_TINTA_RESP")
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Cpry099>(entity =>
            {
                entity.HasKey(e => e.NoPedido)
                    .HasName("CPRY099_INDEX01");

                entity.ToTable("CPRY099");

                entity.HasIndex(e => e.Recnum, "CPRY099_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.NoPedido)
                    .ValueGeneratedNever()
                    .HasColumnName("NO_PEDIDO");

                entity.Property(e => e.AnchoFormula).HasColumnName("ANCHO_FORMULA");

                entity.Property(e => e.Caracterist01)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CARACTERIST_01")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Caracterist02)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CARACTERIST_02")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Caracterist03)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CARACTERIST_03")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Caracterist04)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CARACTERIST_04")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Caracterist05)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CARACTERIST_05")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Caracterist06)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CARACTERIST_06")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Caracterist07)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CARACTERIST_07")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Caracterist08)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CARACTERIST_08")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Caracterist09)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CARACTERIST_09")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Caracterist10)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CARACTERIST_10")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Caracterist11)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CARACTERIST_11")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Caracterist12)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CARACTERIST_12")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Caracterist13)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CARACTERIST_13")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Caracterist14)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CARACTERIST_14")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Correlativo).HasColumnName("CORRELATIVO");

                entity.Property(e => e.FcCantPonches)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("FC_CANT_PONCHES")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FcDiamPonches)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("FC_DIAM_PONCHES")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FcPoncheCac)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("FC_PONCHE_CAC")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FcPoncheClase)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("FC_PONCHE_CLASE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FcPoncheHojas)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("FC_PONCHE_HOJAS")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FcPonchePosic)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("FC_PONCHE_POSIC")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.LargoFormula).HasColumnName("LARGO_FORMULA");

                entity.Property(e => e.NumeroCarbImp)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NUMERO_CARB_IMP")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NumeroExtra)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NUMERO_EXTRA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NumeroPrefijo)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("NUMERO_PREFIJO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NumeroSubfijo)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("NUMERO_SUBFIJO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NumerosEnRojo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NUMEROS_EN_ROJO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.PartesFormula).HasColumnName("PARTES_FORMULA");

                entity.Property(e => e.PerfTalOpCab)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PERF_TAL_OP_CAB")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PerfTalonDer)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PERF_TALON_DER")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PerfTalonIzq)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PERF_TALON_IZQ")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PerfTalonNing)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PERF_TALON_NING")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PerfTalonOpac)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PERF_TALON_OPAC")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.SpeAcabEspec)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SPE_ACAB_ESPEC")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SpeAcabGrupos)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("SPE_ACAB_GRUPOS")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SpeAcabSuelto)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SPE_ACAB_SUELTO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SpeBlockEngom)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SPE_BLOCK_ENGOM")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SpeCaratEnvol)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SPE_CARAT_ENVOL")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SpeDevDibujo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SPE_DEV_DIBUJO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SpeEntrDibujo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SPE_ENTR_DIBUJO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SpeHaceDibujo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SPE_HACE_DIBUJO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SpeStokDibujo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SPE_STOK_DIBUJO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SpeTalonEngr)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SPE_TALON_ENGR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SujCarbEngom)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SUJ_CARB_ENGOM")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SujCarbonDer)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SUJ_CARBON_DER")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SujCarbonIzq)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SUJ_CARBON_IZQ")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SujCarbonSpd)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SUJ_CARBON_SPD")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SujOpacoDer)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SUJ_OPACO_DER")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SujOpacoEngom)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SUJ_OPACO_ENGOM")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SujOpacoIzq)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SUJ_OPACO_IZQ")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SujOpacoSpeed)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SUJ_OPACO_SPEED")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.WizCopyNoA)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("WIZ_COPY_NO_A")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.WizCopyNoDe)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("WIZ_COPY_NO_DE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.WizEmpaqRegul)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("WIZ_EMPAQ_REGUL")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.WizEmpaquePaq)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("WIZ_EMPAQUE_PAQ")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.WizPoncheArch)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("WIZ_PONCHE_ARCH")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.WizSbTiro)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("WIZ_SB_TIRO")
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Cpry100>(entity =>
            {
                entity.HasKey(e => e.NoPedido)
                    .HasName("CPRY100_INDEX01");

                entity.ToTable("CPRY100");

                entity.HasIndex(e => e.Recnum, "CPRY100_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.NoPedido)
                    .ValueGeneratedNever()
                    .HasColumnName("NO_PEDIDO");

                entity.Property(e => e.Correlativo).HasColumnName("CORRELATIVO");

                entity.Property(e => e.Instru01)
                    .IsRequired()
                    .HasMaxLength(55)
                    .IsUnicode(false)
                    .HasColumnName("INSTRU_01")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Instru02)
                    .IsRequired()
                    .HasMaxLength(74)
                    .IsUnicode(false)
                    .HasColumnName("INSTRU_02")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Instru03)
                    .IsRequired()
                    .HasMaxLength(74)
                    .IsUnicode(false)
                    .HasColumnName("INSTRU_03")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");
            });

            modelBuilder.Entity<Cpry102>(entity =>
            {
                entity.HasKey(e => new { e.JobContrato, e.JobIdProceso })
                    .HasName("CPRY102_INDEX01");

                entity.ToTable("CPRY102");

                entity.HasIndex(e => e.Recnum, "CPRY102_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.JobContrato).HasColumnName("JOB_CONTRATO");

                entity.Property(e => e.JobIdProceso).HasColumnName("JOB_ID_PROCESO");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.CodProducto)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("COD_PRODUCTO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.OrdenProceso).HasColumnName("ORDEN_PROCESO");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");
            });

            modelBuilder.Entity<Cpry105>(entity =>
            {
                entity.HasKey(e => new { e.CodigoMaquina, e.LineaProd, e.Anchos, e.RolloDoblado })
                    .HasName("CPRY105_INDEX01");

                entity.ToTable("CPRY105");

                entity.HasIndex(e => e.Recnum, "CPRY105_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.CodigoMaquina).HasColumnName("CODIGO_MAQUINA");

                entity.Property(e => e.LineaProd)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("LINEA_PROD")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Anchos).HasColumnName("ANCHOS");

                entity.Property(e => e.RolloDoblado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ROLLO_DOBLADO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Bsxhora).HasColumnName("BSXHORA");

                entity.Property(e => e.BsxhoraCon).HasColumnName("BSXHORA_CON");

                entity.Property(e => e.HorasXOrden)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("HORAS_X_ORDEN");

                entity.Property(e => e.ObjVelocidad)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("OBJ_VELOCIDAD");

                entity.Property(e => e.Piesxhora).HasColumnName("PIESXHORA");

                entity.Property(e => e.PiesxhoraCon).HasColumnName("PIESXHORA_CON");

                entity.Property(e => e.Rbsxhora)
                    .HasColumnName("RBSXHORA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RbsxhoraCon)
                    .HasColumnName("RBSXHORA_CON")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");
            });

            modelBuilder.Entity<Cpry106>(entity =>
            {
                entity.HasKey(e => e.Orden)
                    .HasName("CPRY106_INDEX01");

                entity.ToTable("CPRY106");

                entity.HasIndex(e => e.Recnum, "CPRY106_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.Cotizacion, e.Orden }, "CPRY106_INDEX02")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.FechaDeOrden, e.Recnum }, "CPRY106_INDEX03")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.Orden)
                    .ValueGeneratedNever()
                    .HasColumnName("ORDEN");

                entity.Property(e => e.AnoRegistro).HasColumnName("ANO_REGISTRO");

                entity.Property(e => e.Anticipo)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("ANTICIPO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AtencionA)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATENCION_A")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CantPonche).HasColumnName("CANT_PONCHE");

                entity.Property(e => e.CantidadOrigin).HasColumnName("CANTIDAD_ORIGIN");

                entity.Property(e => e.CargoResponsab)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CARGO_RESPONSAB")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ClasePonche).HasColumnName("CLASE_PONCHE");

                entity.Property(e => e.CodProduc)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("COD_PRODUC")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CodTeleop)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("COD_TELEOP")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CodigBarras)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CODIG_BARRAS")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ComentDeCredt)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("COMENT_DE_CREDT")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Concesion)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CONCESION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CORREO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Cotizacion)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("COTIZACION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Creditos)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CREDITOS")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DenBase).HasColumnName("DEN_BASE");

                entity.Property(e => e.DenDiamPonche).HasColumnName("DEN_DIAM_PONCHE");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DiaRegistro).HasColumnName("DIA_REGISTRO");

                entity.Property(e => e.DistanCcPonch)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("DISTAN_CC_PONCH")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Division).HasColumnName("DIVISION");

                entity.Property(e => e.EntBase).HasColumnName("ENT_BASE");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ESTADO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Excepcion)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("EXCEPCION")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.ExistenciaDura)
                    .HasColumnType("datetime")
                    .HasColumnName("EXISTENCIA_DURA");

                entity.Property(e => e.FamilProduc)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("FAMIL_PRODUC")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FechaAceptada)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ACEPTADA");

                entity.Property(e => e.FechaConcesion)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_CONCESION");

                entity.Property(e => e.FechaCredito)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_CREDITO");

                entity.Property(e => e.FechaDeOrden)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_DE_ORDEN")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.FechaNegocio)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_NEGOCIO");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_REGISTRO");

                entity.Property(e => e.FechaTasa)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_TASA");

                entity.Property(e => e.FechaTomado)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_TOMADO");

                entity.Property(e => e.FechaVendedor)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_VENDEDOR");

                entity.Property(e => e.FechaVenta)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_VENTA");

                entity.Property(e => e.FlagContrato).HasColumnName("FLAG_CONTRATO");

                entity.Property(e => e.FlagPrimEntre)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_PRIM_ENTRE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagReplicar)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_REPLICAR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FormasUndFact)
                    .HasColumnName("FORMAS_UND_FACT")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.GruposSpidiset).HasColumnName("GRUPOS_SPIDISET");

                entity.Property(e => e.InstruccProduc)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("INSTRUCC_PRODUC")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.KeenEdge)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("KEEN_EDGE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.LineaProduc)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("LINEA_PRODUC")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ListaOriginal)
                    .HasColumnType("decimal(14, 4)")
                    .HasColumnName("LISTA_ORIGINAL");

                entity.Property(e => e.ListaTotDol)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("LISTA_TOT_DOL");

                entity.Property(e => e.ListaUniDol)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("LISTA_UNI_DOL");

                entity.Property(e => e.MedidaEngrap)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MEDIDA_ENGRAP")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.MesRegistro).HasColumnName("MES_REGISTRO");

                entity.Property(e => e.Micr)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MICR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Nc)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NC")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NumBase).HasColumnName("NUM_BASE");

                entity.Property(e => e.NumDiamPonche).HasColumnName("NUM_DIAM_PONCHE");

                entity.Property(e => e.NumForma)
                    .HasColumnType("decimal(14, 4)")
                    .HasColumnName("NUM_FORMA");

                entity.Property(e => e.ObservaciRecha)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("OBSERVACI_RECHA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.OpcionAceptada).HasColumnName("OPCION_ACEPTADA");

                entity.Property(e => e.OperacionBasic).HasColumnName("OPERACION_BASIC");

                entity.Property(e => e.OrdenAnterior).HasColumnName("ORDEN_ANTERIOR");

                entity.Property(e => e.OrdenCompra)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("ORDEN_COMPRA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.OrdenSiguiente)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ORDEN_SIGUIENTE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PerMarDer)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("PER_MAR_DER")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PerMarIzq)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("PER_MAR_IZQ")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PerfTalonDer)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PERF_TALON_DER")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PerfTalonDern)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("PERF_TALON_DERN")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PerfTalonIzq)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PERF_TALON_IZQ")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PerfTalonIzqn)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("PERF_TALON_IZQN")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PerfTalonNin)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PERF_TALON_NIN")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PerfTalonOpac)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PERF_TALON_OPAC")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PersonaRespons)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("PERSONA_RESPONS")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PonchHojaNAl).HasColumnName("PONCH_HOJA_N_AL");

                entity.Property(e => e.PonchHojaNEl).HasColumnName("PONCH_HOJA_N_EL");

                entity.Property(e => e.PoncheEnHojas)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PONCHE_EN_HOJAS")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PorcCom)
                    .HasColumnType("numeric(4, 2)")
                    .HasColumnName("PORC_COM");

                entity.Property(e => e.PosicionPonche).HasColumnName("POSICION_PONCHE");

                entity.Property(e => e.PrfTalOpCarb)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PRF_TAL_OP_CARB")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ProcesoBcs)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PROCESO_BCS")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.RazonAceptada).HasColumnName("RAZON_ACEPTADA");

                entity.Property(e => e.Rechazada)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("RECHAZADA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Region)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REGION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Reinsercion)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REINSERCION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.RlistaOriginal)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RLISTA_ORIGINAL")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RventaOriginal)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RVENTA_ORIGINAL")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Seguridad)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SEGURIDAD")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SiColetilla)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SI_COLETILLA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SiDolares)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SI_DOLARES")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SiIndexado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SI_INDEXADO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SobrePago)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SOBRE_PAGO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SpdsetSuelto)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SPDSET_SUELTO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Speedmailer)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SPEEDMAILER")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SpotCarbon)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SPOT_CARBON")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SpsetCaratula)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SPSET_CARATULA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SpsetEngomado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SPSET_ENGOMADO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SpsetEngraOpu)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SPSET_ENGRA_OPU")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SpsetEngraTal)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SPSET_ENGRA_TAL")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SpsetEngrapad)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SPSET_ENGRAPAD")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SpsetGrupos)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SPSET_GRUPOS")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SujCarbEngoma)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SUJ_CARB_ENGOMA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SujCarbIzq)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SUJ_CARB_IZQ")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SujCarbSplk)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SUJ_CARB_SPLK")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SujCarbonDer)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SUJ_CARBON_DER")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SujOpacDer)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SUJ_OPAC_DER")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SujOpacIzq)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SUJ_OPAC_IZQ")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SujOpacSpfD)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SUJ_OPAC_SPF_D")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SujOpacSpfI)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SUJ_OPAC_SPF_I")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SujOpacSpflex)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SUJ_OPAC_SPFLEX")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SujOpacSplock)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SUJ_OPAC_SPLOCK")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Supervisor)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SUPERVISOR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TalonCabeza)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("TALON_CABEZA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TalonPie)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("TALON_PIE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TasaCambio)
                    .HasColumnType("decimal(14, 4)")
                    .HasColumnName("TASA_CAMBIO");

                entity.Property(e => e.TasaManual)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TASA_MANUAL")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TasaNegociacio)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("TASA_NEGOCIACIO");

                entity.Property(e => e.TipoProduc).HasColumnName("TIPO_PRODUC");

                entity.Property(e => e.TipoProduccion)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_PRODUCCION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TipoRechazo)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_RECHAZO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TransferTape)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TRANSFER_TAPE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Vendedor)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("VENDEDOR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.VentaOriginal)
                    .HasColumnType("decimal(14, 4)")
                    .HasColumnName("VENTA_ORIGINAL");

                entity.Property(e => e.VentaTotDol)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("VENTA_TOT_DOL");

                entity.Property(e => e.VentaUniDol)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("VENTA_UNI_DOL");

                entity.Property(e => e.WizPoncheArch)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("WIZ_PONCHE_ARCH")
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Cpry107>(entity =>
            {
                entity.HasKey(e => e.Orden)
                    .HasName("CPRY107_INDEX01");

                entity.ToTable("CPRY107");

                entity.HasIndex(e => e.Recnum, "CPRY107_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.Orden)
                    .ValueGeneratedNever()
                    .HasColumnName("ORDEN");

                entity.Property(e => e.Cantidad)
                    .HasColumnType("decimal(14, 4)")
                    .HasColumnName("CANTIDAD");

                entity.Property(e => e.Cantidad1)
                    .HasColumnType("decimal(14, 4)")
                    .HasColumnName("CANTIDAD1");

                entity.Property(e => e.Cantidad2)
                    .HasColumnType("decimal(14, 4)")
                    .HasColumnName("CANTIDAD2");

                entity.Property(e => e.Cantidad3)
                    .HasColumnType("decimal(14, 4)")
                    .HasColumnName("CANTIDAD3");

                entity.Property(e => e.CantidadOrigin)
                    .HasColumnType("decimal(14, 4)")
                    .HasColumnName("CANTIDAD_ORIGIN");

                entity.Property(e => e.Cliente).HasColumnName("CLIENTE");

                entity.Property(e => e.ClienteEntrega)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("CLIENTE_ENTREGA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ClienteFactura)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("CLIENTE_FACTURA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ClienteImprimi)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("CLIENTE_IMPRIMI")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ClienteMalo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CLIENTE_MALO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Comentarios)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("COMENTARIOS")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Comision1)
                    .HasColumnType("decimal(14, 4)")
                    .HasColumnName("COMISION1");

                entity.Property(e => e.Comision2)
                    .HasColumnType("decimal(14, 4)")
                    .HasColumnName("COMISION2");

                entity.Property(e => e.Comision3)
                    .HasColumnType("decimal(14, 4)")
                    .HasColumnName("COMISION3");

                entity.Property(e => e.CondPago).HasColumnName("COND_PAGO");

                entity.Property(e => e.Cotizacion)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("COTIZACION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("DIRECCION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Direccion1)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("DIRECCION1")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Direccion2)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("DIRECCION2")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccionEntr1)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("DIRECCION_ENTR1")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccionEntr2)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("DIRECCION_ENTR2")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccionEntre)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("DIRECCION_ENTRE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccionFact1)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("DIRECCION_FACT1")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccionFact2)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("DIRECCION_FACT2")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccionFactu)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("DIRECCION_FACTU")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ListaOriginal)
                    .HasColumnType("decimal(14, 4)")
                    .HasColumnName("LISTA_ORIGINAL");

                entity.Property(e => e.LugarAEnviar)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("LUGAR_A_ENVIAR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.LugarAEnviar1)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("LUGAR_A_ENVIAR1")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.LugarAEnviar2)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("LUGAR_A_ENVIAR2")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.MetodoLista)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("METODO_LISTA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Nuevo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NUEVO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PorcMc)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("PORC_MC");

                entity.Property(e => e.Rcomision1)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RCOMISION1")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Rcomision2)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RCOMISION2")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Rcomision3)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RCOMISION3")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.RifEntregar)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("RIF_ENTREGAR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.RifFacturar)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("RIF_FACTURAR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.RifImprimir)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("RIF_IMPRIMIR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.RlistaOriginal)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RLISTA_ORIGINAL")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RtotalLista)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RTOTAL_LISTA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RtotalLista1)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RTOTAL_LISTA1")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RtotalLista2)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RTOTAL_LISTA2")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RtotalLista3)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RTOTAL_LISTA3")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RtotalVenta)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RTOTAL_VENTA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RtotalVenta1)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RTOTAL_VENTA1")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RtotalVenta2)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RTOTAL_VENTA2")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RtotalVenta3)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RTOTAL_VENTA3")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RventaOriginal)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RVENTA_ORIGINAL")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TotalLista)
                    .HasColumnType("decimal(14, 4)")
                    .HasColumnName("TOTAL_LISTA");

                entity.Property(e => e.TotalLista1)
                    .HasColumnType("decimal(14, 4)")
                    .HasColumnName("TOTAL_LISTA1");

                entity.Property(e => e.TotalLista2)
                    .HasColumnType("decimal(14, 4)")
                    .HasColumnName("TOTAL_LISTA2");

                entity.Property(e => e.TotalLista3)
                    .HasColumnType("decimal(14, 4)")
                    .HasColumnName("TOTAL_LISTA3");

                entity.Property(e => e.TotalVenta)
                    .HasColumnType("decimal(14, 4)")
                    .HasColumnName("TOTAL_VENTA");

                entity.Property(e => e.TotalVenta1)
                    .HasColumnType("decimal(14, 4)")
                    .HasColumnName("TOTAL_VENTA1");

                entity.Property(e => e.TotalVenta2)
                    .HasColumnType("decimal(14, 4)")
                    .HasColumnName("TOTAL_VENTA2");

                entity.Property(e => e.TotalVenta3)
                    .HasColumnType("decimal(14, 4)")
                    .HasColumnName("TOTAL_VENTA3");

                entity.Property(e => e.VentaOriginal)
                    .HasColumnType("decimal(14, 4)")
                    .HasColumnName("VENTA_ORIGINAL");
            });

            modelBuilder.Entity<Cpry108>(entity =>
            {
                entity.HasKey(e => e.Orden)
                    .HasName("CPRY108_INDEX01");

                entity.ToTable("CPRY108");

                entity.HasIndex(e => e.Recnum, "CPRY108_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.Orden)
                    .ValueGeneratedNever()
                    .HasColumnName("ORDEN");

                entity.Property(e => e.ArchivoDiseno)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ARCHIVO_DISENO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.BajoTiro)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BAJO_TIRO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.BsMcFinan)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("BS_MC_FINAN")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.BsMcFinansc)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("BS_MC_FINANSC")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.BsMcPapel)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("BS_MC_PAPEL")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.BsMcPapelsc)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("BS_MC_PAPELSC")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Cambios)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CAMBIOS")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CambiosCopy)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CAMBIOS_COPY")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CambiosEspecif)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CAMBIOS_ESPECIF")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CantNumExt).HasColumnName("CANT_NUM_EXT");

                entity.Property(e => e.Cantidad1)
                    .HasColumnType("decimal(14, 4)")
                    .HasColumnName("CANTIDAD1");

                entity.Property(e => e.Cantidad2)
                    .HasColumnType("decimal(14, 4)")
                    .HasColumnName("CANTIDAD2");

                entity.Property(e => e.Cantidad3)
                    .HasColumnType("decimal(14, 4)")
                    .HasColumnName("CANTIDAD3");

                entity.Property(e => e.Cliente)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CLIENTE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CodigoProducto)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO_PRODUCTO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CondNumExtra)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("COND_NUM_EXTRA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Cotizacion)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("COTIZACION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DenNoBase).HasColumnName("DEN_NO_BASE");

                entity.Property(e => e.EfectosDArte)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("EFECTOS_D_ARTE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Embossing)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("EMBOSSING")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.EntNoBase).HasColumnName("ENT_NO_BASE");

                entity.Property(e => e.Faltante)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FALTANTE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FamiliaProduct)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("FAMILIA_PRODUCT")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Field71)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FIELD71");

                entity.Property(e => e.Fiscal)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FISCAL")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Foil)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FOIL")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FraseMarginal)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FRASE_MARGINAL")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ImpresioDCons)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IMPRESIO_D_CONS")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.LineaProducto)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("LINEA_PRODUCTO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Micr)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MICR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Muestra)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MUESTRA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NoForma)
                    .HasColumnType("decimal(14, 4)")
                    .HasColumnName("NO_FORMA");

                entity.Property(e => e.NombreDeForma)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_DE_FORMA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NuevaExacta)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NUEVA_EXACTA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NumCliDesde)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NUM_CLI_DESDE");

                entity.Property(e => e.NumCliHasta)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NUM_CLI_HASTA");

                entity.Property(e => e.NumEnCarbon).HasColumnName("NUM_EN_CARBON");

                entity.Property(e => e.NumEnRojo).HasColumnName("NUM_EN_ROJO");

                entity.Property(e => e.NumNoBase).HasColumnName("NUM_NO_BASE");

                entity.Property(e => e.NumeracionDe)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NUMERACION_DE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NumeracionHast)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NUMERACION_HAST")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Observaciones).HasColumnName("OBSERVACIONES");

                entity.Property(e => e.OrdenAnterior).HasColumnName("ORDEN_ANTERIOR");

                entity.Property(e => e.OrdenComb)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ORDEN_COMB")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Partes).HasColumnName("PARTES");

                entity.Property(e => e.PorcMcFinan)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("PORC_MC_FINAN")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PorcMcFinansc)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("PORC_MC_FINANSC")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PorcMcPapel)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("PORC_MC_PAPEL")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PorcMcPapelsc)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("PORC_MC_PAPELSC")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PosNum)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("POS_NUM")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PrecioListM1)
                    .HasColumnType("decimal(14, 4)")
                    .HasColumnName("PRECIO_LIST_M1");

                entity.Property(e => e.PrecioListaM2)
                    .HasColumnType("decimal(14, 4)")
                    .HasColumnName("PRECIO_LISTA_M2");

                entity.Property(e => e.PrecioListaM3)
                    .HasColumnType("decimal(14, 4)")
                    .HasColumnName("PRECIO_LISTA_M3");

                entity.Property(e => e.PrecioVentaM1)
                    .HasColumnType("decimal(14, 4)")
                    .HasColumnName("PRECIO_VENTA_M1");

                entity.Property(e => e.PrecioVentaM2)
                    .HasColumnType("decimal(14, 4)")
                    .HasColumnName("PRECIO_VENTA_M2");

                entity.Property(e => e.PrecioVentaM3)
                    .HasColumnType("decimal(14, 4)")
                    .HasColumnName("PRECIO_VENTA_M3");

                entity.Property(e => e.Prefijo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PREFIJO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PrefijoCli)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PREFIJO_CLI");

                entity.Property(e => e.Prueba)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PRUEBA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.RbsMcFinan)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RBS_MC_FINAN")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RbsMcFinansc)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RBS_MC_FINANSC")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RbsMcPapel)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RBS_MC_PAPEL")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RbsMcPapelsc)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RBS_MC_PAPELSC")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.RprecioListM1)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("RPRECIO_LIST_M1")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RprecioListM2)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("RPRECIO_LIST_M2")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RprecioListM3)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("RPRECIO_LIST_M3")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RprecioVentM1)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("RPRECIO_VENT_M1")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RprecioVentM2)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("RPRECIO_VENT_M2")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RprecioVentM3)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("RPRECIO_VENT_M3")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SobreTiro)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SOBRE_TIRO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Sufijo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SUFIJO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SufijoCli)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SUFIJO_CLI");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TipoNum)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_NUM")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TipoProducto).HasColumnName("TIPO_PRODUCTO");

                entity.Property(e => e.UnNumRojo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("UN_NUM_ROJO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.UnaPerforacion)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("UNA_PERFORACION")
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Cpry109>(entity =>
            {
                entity.HasKey(e => new { e.Orden, e.NoPartePapel })
                    .HasName("CPRY109_INDEX01");

                entity.ToTable("CPRY109");

                entity.HasIndex(e => e.Recnum, "CPRY109_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.NoPartePapel).HasColumnName("NO_PARTE_PAPEL");

                entity.Property(e => e.Abreviado)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ABREVIADO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.BasePapel).HasColumnName("BASE_PAPEL");

                entity.Property(e => e.Carbon)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CARBON")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CarbonSpot)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CARBON_SPOT")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Codcarbon)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CODCARBON")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CodigoPapel).HasColumnName("CODIGO_PAPEL");

                entity.Property(e => e.ColorPapel).HasColumnName("COLOR_PAPEL");

                entity.Property(e => e.Cotizacion)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("COTIZACION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DenMedIrreglr).HasColumnName("DEN_MED_IRREGLR");

                entity.Property(e => e.DenTalonDer).HasColumnName("DEN_TALON_DER");

                entity.Property(e => e.DenTalonIzq).HasColumnName("DEN_TALON_IZQ");

                entity.Property(e => e.EntMedIrreglr).HasColumnName("ENT_MED_IRREGLR");

                entity.Property(e => e.EntTalonDer).HasColumnName("ENT_TALON_DER");

                entity.Property(e => e.EntTalonIzq).HasColumnName("ENT_TALON_IZQ");

                entity.Property(e => e.FraseMarginal)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FRASE_MARGINAL")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Medcarbonent)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("MEDCARBONENT");

                entity.Property(e => e.MedidaCarrbon)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("MEDIDA_CARRBON")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NoForma)
                    .HasColumnType("decimal(14, 4)")
                    .HasColumnName("NO_FORMA");

                entity.Property(e => e.NumMedIrreglr).HasColumnName("NUM_MED_IRREGLR");

                entity.Property(e => e.NumTalonDer).HasColumnName("NUM_TALON_DER");

                entity.Property(e => e.NumTalonIzq).HasColumnName("NUM_TALON_IZQ");

                entity.Property(e => e.PerforacionHor).HasColumnName("PERFORACION_HOR");

                entity.Property(e => e.PerforacionVer).HasColumnName("PERFORACION_VER");

                entity.Property(e => e.PosicionTalon).HasColumnName("POSICION_TALON");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.TintaFrente1)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TINTA_FRENTE1")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TintaFrente2)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TINTA_FRENTE2")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TintaFrente3)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TINTA_FRENTE3")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TintaFrente4)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TINTA_FRENTE4")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TintaFrente5)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TINTA_FRENTE5")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TintaRespaldo1)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TINTA_RESPALDO1")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TintaRespaldo2)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TINTA_RESPALDO2")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TintaRespaldo3)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TINTA_RESPALDO3")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TintaRespaldo4)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("TINTA_RESPALDO4")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TintaRespaldo5)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("TINTA_RESPALDO5")
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Cpry110>(entity =>
            {
                entity.HasKey(e => new { e.Orden, e.Job })
                    .HasName("CPRY110_INDEX01");

                entity.ToTable("CPRY110");

                entity.HasIndex(e => e.Recnum, "CPRY110_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.Job)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("JOB")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Cantidad)
                    .HasColumnType("decimal(14, 4)")
                    .HasColumnName("CANTIDAD");

                entity.Property(e => e.Cotizacion)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("COTIZACION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA");

                entity.Property(e => e.FlagActivo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_ACTIVO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");
            });

            modelBuilder.Entity<Cpry113a>(entity =>
            {
                entity.HasKey(e => e.PapelMat)
                    .HasName("CPRY113_INDEX01");

                entity.ToTable("CPRY113a");

                entity.HasIndex(e => e.Recnum, "CPRY113_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.PapelMat)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("PAPEL_MAT")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CostoPapel)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("COSTO_PAPEL");

                entity.Property(e => e.CostoPapelDol)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("COSTO_PAPEL_DOL");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Eliminado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ELIMINADO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PapelFifo)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("PAPEL_FIFO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PapelLista)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("PAPEL_LISTA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.RcostoPapel)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RCOSTO_PAPEL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.TipoPapel)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_PAPEL")
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Cpry114>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CPRY114");

                entity.Property(e => e.CostoPapel)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("COSTO_PAPEL");

                entity.Property(e => e.CostoPapelDol)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("COSTO_PAPEL_DOL");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION")
                    .IsFixedLength();

                entity.Property(e => e.Eliminado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ELIMINADO")
                    .IsFixedLength();

                entity.Property(e => e.PapelFifo)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("PAPEL_FIFO")
                    .IsFixedLength();

                entity.Property(e => e.PapelLista)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("PAPEL_LISTA")
                    .IsFixedLength();

                entity.Property(e => e.PapelMat)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("PAPEL_MAT")
                    .IsFixedLength();

                entity.Property(e => e.RcostoPapel)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RCOSTO_PAPEL");

                entity.Property(e => e.RecordNumber)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECORD_NUMBER");

                entity.Property(e => e.TipoPapel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_PAPEL")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Cpry178>(entity =>
            {
                entity.HasKey(e => e.CodigoStatus)
                    .HasName("CPRY178_INDEX01");

                entity.ToTable("CPRY178");

                entity.HasIndex(e => e.Recnum, "CPRY178_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.CodigoStatus)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO_STATUS")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DescStatus)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DESC_STATUS")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Notct)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NOTCT");

                entity.Property(e => e.PararProceso)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PARAR_PROCESO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.RestarBacklog)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("RESTAR_BACKLOG")
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Cpry179>(entity =>
            {
                entity.HasKey(e => e.FechaFeriada)
                    .HasName("CPRY179_INDEX01");

                entity.ToTable("CPRY179");

                entity.HasIndex(e => e.Recnum, "CPRY179_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.FechaFeriada)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_FERIADA")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.MostrarBs)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MOSTRAR_BS")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Motivo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MOTIVO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");
            });

            modelBuilder.Entity<Cpry180>(entity =>
            {
                entity.HasKey(e => e.Recnum)
                    .HasName("CPRY180_INDEX00");

                entity.ToTable("CPRY180");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Ancho)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ANCHO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Cliente)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("CLIENTE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CodPapel)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("COD_PAPEL")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FechaEntrega)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ENTREGA");

                entity.Property(e => e.FechaOrden)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ORDEN");

                entity.Property(e => e.FechaSolicitud)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_SOLICITUD");

                entity.Property(e => e.FlagCarbon)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_CARBON")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Kilos)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("KILOS")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Maq)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MAQ")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Orden)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("ORDEN")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Partes)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PARTES")
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Cpry205>(entity =>
            {
                entity.HasKey(e => new { e.Orden, e.Recnum })
                    .HasName("CPRY205_INDEX01");

                entity.ToTable("CPRY205");

                entity.HasIndex(e => e.Recnum, "CPRY205_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => e.Orden, "dep_cpry205orden");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.CantidadA).HasColumnName("CANTIDAD_A");

                entity.Property(e => e.CantidadC).HasColumnName("CANTIDAD_C");

                entity.Property(e => e.CantidadE).HasColumnName("CANTIDAD_E");

                entity.Property(e => e.FlagAcabado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_ACABADO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagColectora)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_COLECTORA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagEmbarque)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_EMBARQUE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Job).HasColumnName("JOB");

                entity.Property(e => e.Linea)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("LINEA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Metodo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("METODO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NuevaFechaEnt)
                    .HasColumnType("datetime")
                    .HasColumnName("NUEVA_FECHA_ENT");

                entity.Property(e => e.Papel)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PAPEL")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Parte).HasColumnName("PARTE");

                entity.Property(e => e.Partes).HasColumnName("PARTES");

                entity.Property(e => e.Porcterminacion)
                    .HasColumnType("decimal(4, 2)")
                    .HasColumnName("PORCTERMINACION");

                entity.Property(e => e.PrecioLista)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("PRECIO_LISTA");

                entity.Property(e => e.Producto)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("PRODUCTO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.RprecioLista)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RPRECIO_LISTA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RvalorLista)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RVALOR_LISTA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TipoProducto).HasColumnName("TIPO_PRODUCTO");

                entity.Property(e => e.ValorLista)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("VALOR_LISTA");
            });

            modelBuilder.Entity<Cpry216>(entity =>
            {
                entity.HasKey(e => new { e.Orden, e.Recnum })
                    .HasName("CPRY216_INDEX01");

                entity.ToTable("CPRY216");

                entity.HasIndex(e => e.Recnum, "CPRY216_INDEX00")
                    .IsUnique()
                    .HasFillFactor(70);

                entity.HasIndex(e => e.Job, "CPRY216_INDEX02")
                    .IsUnique()
                    .HasFillFactor(70);

                entity.HasIndex(e => e.Orden, "dep_cpry216orden")
                    .HasFillFactor(70);

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.AtencionCte)
                    .HasColumnType("text")
                    .HasColumnName("ATENCION_CTE");

                entity.Property(e => e.Cantidad1).HasColumnName("CANTIDAD1");

                entity.Property(e => e.Cantidad2).HasColumnName("CANTIDAD2");

                entity.Property(e => e.Cantidad3).HasColumnName("CANTIDAD3");

                entity.Property(e => e.Cantidad4).HasColumnName("CANTIDAD4");

                entity.Property(e => e.Cantidad5).HasColumnName("CANTIDAD5");

                entity.Property(e => e.CantidadEntreg).HasColumnName("CANTIDAD_ENTREG");

                entity.Property(e => e.CodCliente).HasColumnName("COD_CLIENTE");

                entity.Property(e => e.CodOficina).HasColumnName("COD_OFICINA");

                entity.Property(e => e.CodRegion).HasColumnName("COD_REGION");

                entity.Property(e => e.CodigoGerente)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO_GERENTE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CodigoSuperv)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO_SUPERV")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CodigoVendedor)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO_VENDEDOR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Cotizacion)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("COTIZACION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Despacho)
                    .HasColumnType("text")
                    .HasColumnName("DESPACHO");

                entity.Property(e => e.DiasHabiles).HasColumnName("DIAS_HABILES");

                entity.Property(e => e.EnvioCarta8)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ENVIO_CARTA_8")
                    .IsFixedLength();

                entity.Property(e => e.Estacion1)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ESTACION1")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Estacion2)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ESTACION2")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Estacion3)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ESTACION3")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Estacion4)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ESTACION4")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Estacion5)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ESTACION5")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FecEstEsta1)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("FEC_EST_ESTA1")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FecEstEsta2)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("FEC_EST_ESTA2")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FecEstEsta3)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("FEC_EST_ESTA3")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FecEstEsta4)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("FEC_EST_ESTA4")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FecEstEsta5)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("FEC_EST_ESTA5")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FechaArchivo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("FECHA_ARCHIVO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FechaDespacho)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("FECHA_DESPACHO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FechaFactura)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("FECHA_FACTURA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FechaNueva)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("FECHA_NUEVA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FechaOrden)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("FECHA_ORDEN")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FechaPrometida)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("FECHA_PROMETIDA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FormasPdtes).HasColumnName("FORMAS_PDTES");

                entity.Property(e => e.FormasPedida).HasColumnName("FORMAS_PEDIDA");

                entity.Property(e => e.GerenteRegion)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("GERENTE_REGION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ImpStock)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IMP_STOCK")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Job).HasColumnName("JOB");

                entity.Property(e => e.ListaTotal)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("LISTA_TOTAL");

                entity.Property(e => e.ListaUnitario)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("LISTA_UNITARIO");

                entity.Property(e => e.NombreCliente)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_CLIENTE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NombreForma)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_FORMA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NombreGteReg)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_GTE_REG")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NombreOficina)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_OFICINA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NombreRegion)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_REGION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NombreSuperv)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_SUPERV")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NombreVendedor)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_VENDEDOR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Planificacion)
                    .HasColumnType("text")
                    .HasColumnName("PLANIFICACION");

                entity.Property(e => e.Reoperacion)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("REOPERACION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.RlistaTotal)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RLISTA_TOTAL")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RlistaUnitario)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RLISTA_UNITARIO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RventaTotal)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RVENTA_TOTAL")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RventaUnitario)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RVENTA_UNITARIO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.StatusOrden)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("STATUS_ORDEN")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SugerenciaAten)
                    .HasColumnType("text")
                    .HasColumnName("SUGERENCIA_ATEN");

                entity.Property(e => e.SugerenciaDesp)
                    .HasColumnType("text")
                    .HasColumnName("SUGERENCIA_DESP");

                entity.Property(e => e.SugerenciaPlan)
                    .HasColumnType("text")
                    .HasColumnName("SUGERENCIA_PLAN");

                entity.Property(e => e.VentaTotal)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("VENTA_TOTAL");

                entity.Property(e => e.VentaUnitario)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("VENTA_UNITARIO");
            });

            modelBuilder.Entity<Cpry217>(entity =>
            {
                entity.HasKey(e => new { e.Origen, e.Grupo, e.Tipo, e.Numero, e.Recnum })
                    .HasName("CPRY217_INDEX01");

                entity.ToTable("CPRY217");

                entity.HasIndex(e => e.Recnum, "CPRY217_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.CausaError, e.Numero, e.Recnum }, "CPRY217_INDEX02")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.Mes, e.Grupo, e.Ficha, e.Numero, e.Recnum }, "CPRY217_INDEX03")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.Origen)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ORIGEN")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Grupo).HasColumnName("GRUPO");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TIPO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Numero).HasColumnName("NUMERO");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.CausaError).HasColumnName("CAUSA_ERROR");

                entity.Property(e => e.Costo)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("COSTO");

                entity.Property(e => e.Dpto)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("DPTO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA");

                entity.Property(e => e.Ficha).HasColumnName("FICHA");

                entity.Property(e => e.Mes).HasColumnName("MES");

                entity.Property(e => e.NroIq).HasColumnName("NRO_IQ");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.Porcentaje).HasColumnName("PORCENTAJE");

                entity.Property(e => e.Rcosto)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RCOSTO")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<Cpry218>(entity =>
            {
                entity.HasKey(e => e.CodOrigen)
                    .HasName("CPRY218_INDEX01");

                entity.ToTable("CPRY218");

                entity.HasIndex(e => e.Recnum, "CPRY218_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.CodOrigen)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("COD_ORIGEN")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DesOrigen)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DES_ORIGEN")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Prueba)
                    .HasColumnType("text")
                    .HasColumnName("PRUEBA");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");
            });

            modelBuilder.Entity<Cpry219>(entity =>
            {
                entity.HasKey(e => new { e.OrigenReporte, e.GrupoDpto, e.TipoReporte })
                    .HasName("CPRY219_INDEX01");

                entity.ToTable("CPRY219");

                entity.HasIndex(e => e.Recnum, "CPRY219_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.OrigenReporte)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ORIGEN_REPORTE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.GrupoDpto).HasColumnName("GRUPO_DPTO");

                entity.Property(e => e.TipoReporte)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_REPORTE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.BsAbril)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("BS_ABRIL");

                entity.Property(e => e.BsAcumulado)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("BS_ACUMULADO");

                entity.Property(e => e.BsAgosto)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("BS_AGOSTO");

                entity.Property(e => e.BsDiciembre)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("BS_DICIEMBRE");

                entity.Property(e => e.BsEnero)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("BS_ENERO");

                entity.Property(e => e.BsFebrero)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("BS_FEBRERO");

                entity.Property(e => e.BsJulio)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("BS_JULIO");

                entity.Property(e => e.BsJunio)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("BS_JUNIO");

                entity.Property(e => e.BsMarzo)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("BS_MARZO");

                entity.Property(e => e.BsMayo)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("BS_MAYO");

                entity.Property(e => e.BsNoviembre)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("BS_NOVIEMBRE");

                entity.Property(e => e.BsOctubre)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("BS_OCTUBRE");

                entity.Property(e => e.BsSeptiembre)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("BS_SEPTIEMBRE");

                entity.Property(e => e.CantAbril).HasColumnName("CANT_ABRIL");

                entity.Property(e => e.CantAcumulada).HasColumnName("CANT_ACUMULADA");

                entity.Property(e => e.CantAgosto).HasColumnName("CANT_AGOSTO");

                entity.Property(e => e.CantDiciembre).HasColumnName("CANT_DICIEMBRE");

                entity.Property(e => e.CantEnero).HasColumnName("CANT_ENERO");

                entity.Property(e => e.CantFebrero).HasColumnName("CANT_FEBRERO");

                entity.Property(e => e.CantJulio).HasColumnName("CANT_JULIO");

                entity.Property(e => e.CantJunio).HasColumnName("CANT_JUNIO");

                entity.Property(e => e.CantMarzo).HasColumnName("CANT_MARZO");

                entity.Property(e => e.CantMayo).HasColumnName("CANT_MAYO");

                entity.Property(e => e.CantNoviembre).HasColumnName("CANT_NOVIEMBRE");

                entity.Property(e => e.CantOctubre).HasColumnName("CANT_OCTUBRE");

                entity.Property(e => e.CantSeptiembre).HasColumnName("CANT_SEPTIEMBRE");

                entity.Property(e => e.OrdProcesadas).HasColumnName("ORD_PROCESADAS");

                entity.Property(e => e.RbsAbril)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RBS_ABRIL")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RbsAcumulado)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RBS_ACUMULADO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RbsAgosto)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RBS_AGOSTO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RbsDiciembre)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RBS_DICIEMBRE")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RbsEnero)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RBS_ENERO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RbsFebrero)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RBS_FEBRERO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RbsJulio)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RBS_JULIO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RbsJunio)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RBS_JUNIO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RbsMarzo)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RBS_MARZO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RbsMayo)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RBS_MAYO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RbsNoviembre)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RBS_NOVIEMBRE")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RbsOctubre)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RBS_OCTUBRE")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RbsSeptiembre)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RBS_SEPTIEMBRE")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");
            });

            modelBuilder.Entity<Cpry220>(entity =>
            {
                entity.HasKey(e => new { e.Numero, e.Ficha })
                    .HasName("CPRY220_INDEX01");

                entity.ToTable("CPRY220");

                entity.HasIndex(e => e.Recnum, "CPRY220_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.Tipo, e.Grupo, e.TipoPapel, e.Numero, e.Recnum }, "CPRY220_INDEX02")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.Mayor, e.Sc, e.Ssc, e.Aux, e.Ccosto, e.Grupo, e.Numero, e.Recnum }, "CPRY220_INDEX03")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => e.Orden, "dep_cpry220orden");

                entity.Property(e => e.Numero).HasColumnName("NUMERO");

                entity.Property(e => e.Ficha).HasColumnName("FICHA");

                entity.Property(e => e.Aux)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("AUX")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Ccosto)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CCOSTO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Dpto)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("DPTO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Grupo).HasColumnName("GRUPO");

                entity.Property(e => e.Mayor)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MAYOR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Metodo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("METODO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.Porcentaje).HasColumnName("PORCENTAJE");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Sc)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SC")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Ssc)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SSC")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TIPO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TipoPapel)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_PAPEL")
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Cpry221>(entity =>
            {
                entity.HasKey(e => new { e.Numero, e.Ficha })
                    .HasName("CPRY221_INDEX01");

                entity.ToTable("CPRY221");

                entity.HasIndex(e => e.Recnum, "CPRY221_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.Tipo, e.Grupo, e.Numero, e.Ficha, e.Recnum }, "CPRY221_INDEX02")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => e.Orden, "dep_cpry221orden");

                entity.Property(e => e.Numero).HasColumnName("NUMERO");

                entity.Property(e => e.Ficha).HasColumnName("FICHA");

                entity.Property(e => e.Dpto)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("DPTO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Grupo).HasColumnName("GRUPO");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.Porcentaje).HasColumnName("PORCENTAJE");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TIPO")
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Cpry223>(entity =>
            {
                entity.HasKey(e => new { e.LineaProducto, e.UnaParteMulti, e.TipoPapel })
                    .HasName("CPRY223_INDEX01");

                entity.ToTable("CPRY223");

                entity.HasIndex(e => e.Recnum, "CPRY223_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.LineaProducto)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("LINEA_PRODUCTO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.UnaParteMulti)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("UNA_PARTE_MULTI")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TipoPapel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_PAPEL")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Partes).HasColumnName("PARTES");

                entity.Property(e => e.PorcCosto)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("PORC_COSTO");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");
            });

            modelBuilder.Entity<Cpry224>(entity =>
            {
                entity.HasKey(e => e.Grupo)
                    .HasName("CPRY224_INDEX01");

                entity.ToTable("CPRY224");

                entity.HasIndex(e => e.Recnum, "CPRY224_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.Descripcion, e.Grupo }, "CPRY224_INDEX02")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.Grupo)
                    .ValueGeneratedNever()
                    .HasColumnName("GRUPO");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");
            });

            modelBuilder.Entity<Cpry225>(entity =>
            {
                entity.HasKey(e => new { e.Grupo, e.Tipo })
                    .HasName("CPRY225_INDEX01");

                entity.ToTable("CPRY225");

                entity.HasIndex(e => e.Recnum, "CPRY225_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.Grupo).HasColumnName("GRUPO");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TIPO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Aux)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("AUX")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Ccosto)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CCOSTO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Mayor)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MAYOR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Sc)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SC")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Ssc)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SSC")
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Cpry226>(entity =>
            {
                entity.HasKey(e => e.Tipo)
                    .HasName("CPRY226_INDEX01");

                entity.ToTable("CPRY226");

                entity.HasIndex(e => e.Recnum, "CPRY226_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TIPO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.AuxMcpContr)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("AUX_MCP_CONTR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.AuxOpaContr)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("AUX_OPA_CONTR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CcoMcpContr)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CCO_MCP_CONTR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CcoOpaContr)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CCO_OPA_CONTR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.MayorMcpContr)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MAYOR_MCP_CONTR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.MayorOpaContr)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MAYOR_OPA_CONTR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.OrigenReporte)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ORIGEN_REPORTE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.ScMcpContr)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SC_MCP_CONTR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ScOpaContr)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SC_OPA_CONTR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SscMcpContr)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SSC_MCP_CONTR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SscOpaContr)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SSC_OPA_CONTR")
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Cpry227>(entity =>
            {
                entity.HasKey(e => new { e.Numero, e.Ficha })
                    .HasName("CPRY227_INDEX01");

                entity.ToTable("CPRY227");

                entity.HasIndex(e => e.Recnum, "CPRY227_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.Numero).HasColumnName("NUMERO");

                entity.Property(e => e.Ficha).HasColumnName("FICHA");

                entity.Property(e => e.Costo)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("COSTO");

                entity.Property(e => e.Dpto)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("DPTO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Porcentaje).HasColumnName("PORCENTAJE");

                entity.Property(e => e.Rcosto)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("RCOSTO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");
            });

            modelBuilder.Entity<Cpry228>(entity =>
            {
                entity.HasKey(e => e.Numero)
                    .HasName("CPRY228_INDEX01");

                entity.ToTable("CPRY228");

                entity.HasIndex(e => e.Recnum, "CPRY228_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.Tipo, e.Numero }, "CPRY228_INDEX02")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.FechaEmision, e.Tipo, e.Numero }, "CPRY228_INDEX03")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.Orden, e.Numero }, "CPRY228_INDEX04")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => e.Orden, "dep_cpry228orden");

                entity.Property(e => e.Numero)
                    .ValueGeneratedNever()
                    .HasColumnName("NUMERO");

                entity.Property(e => e.AccionesPreven)
                    .HasColumnType("text")
                    .HasColumnName("ACCIONES_PREVEN");

                entity.Property(e => e.AfectaColect)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AFECTA_COLECT")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.AfectaPrensa)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AFECTA_PRENSA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CantProgramada).HasColumnName("CANT_PROGRAMADA");

                entity.Property(e => e.CausaError).HasColumnName("CAUSA_ERROR");

                entity.Property(e => e.Comentarios)
                    .HasColumnType("text")
                    .HasColumnName("COMENTARIOS");

                entity.Property(e => e.CtdAReoperar).HasColumnName("CTD_A_REOPERAR");

                entity.Property(e => e.FechaActua)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ACTUA");

                entity.Property(e => e.FechaCreado)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_CREADO");

                entity.Property(e => e.FechaEmision)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_EMISION")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.MesConcurso).HasColumnName("MES_CONCURSO");

                entity.Property(e => e.NoCostear)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NO_COSTEAR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NroIq).HasColumnName("NRO_IQ");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.OrigenCausa)
                    .HasColumnType("text")
                    .HasColumnName("ORIGEN_CAUSA");

                entity.Property(e => e.OrigenReporte)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ORIGEN_REPORTE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Porcentajes).HasColumnName("PORCENTAJES");

                entity.Property(e => e.PteAReoperar).HasColumnName("PTE_A_REOPERAR");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TIPO")
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Cpry229>(entity =>
            {
                entity.HasKey(e => new { e.Numero, e.Fecha, e.Recnum })
                    .HasName("CPRY229_INDEX01");

                entity.ToTable("CPRY229");

                entity.HasIndex(e => e.Recnum, "CPRY229_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.Fecha, e.Numero, e.Recnum }, "CPRY229_INDEX02")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.Mescon, e.Contabilizado, e.Recnum }, "CPRY229_INDEX03")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.Mescon, e.Numero, e.Recnum }, "CPRY229_INDEX04")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.Numero).HasColumnName("NUMERO");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Automatico)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTOMATICO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CantidadRodada).HasColumnName("CANTIDAD_RODADA");

                entity.Property(e => e.Contabilizado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CONTABILIZADO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Costo)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("COSTO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Doblado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DOBLADO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Maq)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MAQ")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Mescon).HasColumnName("MESCON");

                entity.Property(e => e.Parte).HasColumnName("PARTE");

                entity.Property(e => e.PiesRodados).HasColumnName("PIES_RODADOS");

                entity.Property(e => e.Rcosto)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("RCOSTO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TipoMaquina)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_MAQUINA")
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Cpry241>(entity =>
            {
                entity.HasKey(e => new { e.FechaProgramad, e.Recnum })
                    .HasName("CPRY241_INDEX01");

                entity.ToTable("CPRY241");

                entity.HasIndex(e => e.Recnum, "CPRY241_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => e.Orden, "dep_cpry241orden");

                entity.Property(e => e.FechaProgramad)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_PROGRAMAD")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Cantidad)
                    .HasColumnType("decimal(12, 4)")
                    .HasColumnName("CANTIDAD");

                entity.Property(e => e.Cliente)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CLIENTE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DiasAtraso).HasColumnName("DIAS_ATRASO");

                entity.Property(e => e.Factura).HasColumnName("FACTURA");

                entity.Property(e => e.FechaFactura)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_FACTURA");

                entity.Property(e => e.Oficina).HasColumnName("OFICINA");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.Remision).HasColumnName("REMISION");
            });

            modelBuilder.Entity<Cpry250>(entity =>
            {
                entity.HasKey(e => new { e.Orden, e.NumCaja })
                    .HasName("CPRY250_INDEX01");

                entity.ToTable("CPRY250");

                entity.HasIndex(e => e.Recnum, "CPRY250_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => e.Orden, "dep_cpry250orden");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.NumCaja).HasColumnName("NUM_CAJA");

                entity.Property(e => e.Basica).HasColumnName("BASICA");

                entity.Property(e => e.CantCaja).HasColumnName("CANT_CAJA");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.CantidadFalta).HasColumnName("CANTIDAD_FALTA");

                entity.Property(e => e.Cliente).HasColumnName("CLIENTE");

                entity.Property(e => e.ClienteFactur)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("CLIENTE_FACTUR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CodProducto)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("COD_PRODUCTO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Desde)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DESDE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccionEmb1)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("DIRECCION_EMB1")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccionEmb2)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("DIRECCION_EMB2")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccionEmb3)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("DIRECCION_EMB3")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Hasta)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("HASTA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NombreForma)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_FORMA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NombreVendedor)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_VENDEDOR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NumFaltante).HasColumnName("NUM_FALTANTE");

                entity.Property(e => e.Opuesta).HasColumnName("OPUESTA");

                entity.Property(e => e.OrdenCompra)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ORDEN_COMPRA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Partes).HasColumnName("PARTES");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");
            });

            modelBuilder.Entity<Crmy005>(entity =>
            {
                entity.HasKey(e => e.Codpapel)
                    .HasName("CRMY005_INDEX01");

                entity.ToTable("CRMY005");

                entity.HasIndex(e => e.Recnum, "CRMY005_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.Codpapel)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CODPAPEL")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Abreviado)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("ABREVIADO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.BaseReal)
                    .HasColumnType("decimal(8, 4)")
                    .HasColumnName("BASE_REAL");

                entity.Property(e => e.Despapel)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("DESPAPEL")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FactorResma)
                    .HasColumnType("decimal(8, 4)")
                    .HasColumnName("FACTOR_RESMA");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Refilado)
                    .HasColumnType("decimal(4, 2)")
                    .HasColumnName("REFILADO");

                entity.Property(e => e.TipoPapel)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_PAPEL")
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Csmy003V>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CSMY003_V");

                entity.Property(e => e.AreaCobranz)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Area_Cobranz")
                    .IsFixedLength();

                entity.Property(e => e.Asignacion)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Canal)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CANAL")
                    .IsFixedLength();

                entity.Property(e => e.CapitalSoc)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("CAPITAL_SOC");

                entity.Property(e => e.Categoria)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CierreEjerc)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CIERRE_EJERC");

                entity.Property(e => e.ClientContado)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Client_Contado")
                    .IsFixedLength();

                entity.Property(e => e.ClienteNuevo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Cliente_Nuevo")
                    .IsFixedLength();

                entity.Property(e => e.Cobrador)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodJde).HasColumnName("cod_jde");

                entity.Property(e => e.CodJdePadre).HasColumnName("Cod_jdePadre");

                entity.Property(e => e.CodMcpo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Cod_Mcpo")
                    .IsFixedLength();

                entity.Property(e => e.CodProveedor)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Cod_Proveedor")
                    .IsFixedLength();

                entity.Property(e => e.CodSubSegmento)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Cod_SubSegmento")
                    .IsFixedLength();

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoCiudad)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Codigo_Ciudad")
                    .IsFixedLength();

                entity.Property(e => e.CodigoEstado)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Codigo_Estado")
                    .IsFixedLength();

                entity.Property(e => e.CodigoMcpo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Codigo_Mcpo")
                    .IsFixedLength();

                entity.Property(e => e.CodigoNumerico).HasColumnName("codigo_numerico");

                entity.Property(e => e.CodigoParroq)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Codigo_Parroq")
                    .IsFixedLength();

                entity.Property(e => e.CodigoPostal)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Codigo_Postal")
                    .IsFixedLength();

                entity.Property(e => e.CodigoRegion)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Codigo_Region")
                    .IsFixedLength();

                entity.Property(e => e.CondPago)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("COND_PAGO");

                entity.Property(e => e.ContCarg1)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Cont_Carg_1")
                    .IsFixedLength();

                entity.Property(e => e.ContCarg2)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Cont_Carg_2")
                    .IsFixedLength();

                entity.Property(e => e.ContCarg3)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Cont_Carg_3")
                    .IsFixedLength();

                entity.Property(e => e.ContEmail1)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Cont_Email_1")
                    .IsFixedLength();

                entity.Property(e => e.ContEmail2)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Cont_Email_2")
                    .IsFixedLength();

                entity.Property(e => e.ContEmail3)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Cont_Email_3")
                    .IsFixedLength();

                entity.Property(e => e.ContEspecial)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Cont_Especial")
                    .IsFixedLength();

                entity.Property(e => e.ContFechNacm1)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Cont_FechNacm_1");

                entity.Property(e => e.ContFechNacm2)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Cont_FechNacm_2");

                entity.Property(e => e.ContFechNacm3)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Cont_FechNacm_3");

                entity.Property(e => e.ContNomb1)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Cont_Nomb_1")
                    .IsFixedLength();

                entity.Property(e => e.ContNomb2)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Cont_Nomb_2")
                    .IsFixedLength();

                entity.Property(e => e.ContNomb3)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Cont_Nomb_3")
                    .IsFixedLength();

                entity.Property(e => e.ContTelf1)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Cont_Telf_1")
                    .IsFixedLength();

                entity.Property(e => e.ContTelf2)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Cont_Telf_2")
                    .IsFixedLength();

                entity.Property(e => e.ContTelf3)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Cont_Telf_3")
                    .IsFixedLength();

                entity.Property(e => e.DepuraCod)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DEPURA_COD")
                    .IsFixedLength();

                entity.Property(e => e.Depurar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("depurar")
                    .IsFixedLength();

                entity.Property(e => e.DiaDeCobro)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Dia_de_Cobro")
                    .IsFixedLength();

                entity.Property(e => e.Direccion)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Direccion1)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Direccion2)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EMailClient)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("E_mail_Client")
                    .IsFixedLength();

                entity.Property(e => e.ExentoDeImpuesto)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Exento_de_Impuesto")
                    .IsFixedLength();

                entity.Property(e => e.Expr1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FApertura)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("F_Apertura");

                entity.Property(e => e.FModificacion)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("F_Modificacion");

                entity.Property(e => e.FUltmCompra)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("F_Ultm_Compra");

                entity.Property(e => e.Fax)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaCerrado)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Fecha_Cerrado");

                entity.Property(e => e.FechaInactivo)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Fecha_Inactivo");

                entity.Property(e => e.FechaLegal)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FECHA_LEGAL");

                entity.Property(e => e.FechaReactivado)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Fecha_Reactivado");

                entity.Property(e => e.FechaRiesgo)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FECHA_RIESGO");

                entity.Property(e => e.FlagCerrado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Flag_Cerrado")
                    .IsFixedLength();

                entity.Property(e => e.FlagInactivo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Flag_Inactivo")
                    .IsFixedLength();

                entity.Property(e => e.FlagMat)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Flag_Mat")
                    .IsFixedLength();

                entity.Property(e => e.FlagMod03)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagModificado)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Flag_Modificado")
                    .IsFixedLength();

                entity.Property(e => e.FlagNuevo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Flag_Nuevo")
                    .IsFixedLength();

                entity.Property(e => e.GiroNegocio)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Giro_Negocio")
                    .IsFixedLength();

                entity.Property(e => e.Grupo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GrupoCliente)
                    .HasColumnType("numeric(5, 0)")
                    .HasColumnName("GRUPO_CLIENTE");

                entity.Property(e => e.LCredito)
                    .HasColumnType("money")
                    .HasColumnName("L_Credito");

                entity.Property(e => e.Legal)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("LEGAL")
                    .IsFixedLength();

                entity.Property(e => e.LimiteCredUt)
                    .HasColumnType("numeric(16, 2)")
                    .HasColumnName("Limite_Cred_Ut");

                entity.Property(e => e.Nit)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NoRegTribut)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("No_Reg_Tribut")
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OficinaVenta)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Oficina_Venta")
                    .IsFixedLength();

                entity.Property(e => e.OrdenCompra)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Orden_Compra")
                    .IsFixedLength();

                entity.Property(e => e.PaginaWeb)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Pagina_Web")
                    .IsFixedLength();

                entity.Property(e => e.RepresLegal)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Repres_Legal")
                    .IsFixedLength();

                entity.Property(e => e.Riesgo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("RIESGO")
                    .IsFixedLength();

                entity.Property(e => e.RutCartero)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Rut_Cartero")
                    .IsFixedLength();

                entity.Property(e => e.Segmento)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SiDolares)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SubSegmentoa)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TImpuesto).HasColumnName("T_Impuesto");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Telefono1)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoNegocio)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Tipo_Negocio")
                    .IsFixedLength();

                entity.Property(e => e.UsuarioMod)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_MOD")
                    .IsFixedLength();

                entity.Property(e => e.Vendedor1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Zona)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Csmy019>(entity =>
            {
                entity.HasKey(e => new { e.Orden, e.Correlativo })
                    .HasName("CSMY019_INDEX01");

                entity.ToTable("CSMY019");

                entity.HasIndex(e => e.Recnum, "CSMY019_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.AnoRegist, e.MesRegist, e.DiaRegist, e.OrdenCambio, e.Orden, e.Correlativo }, "CSMY019_INDEX02")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.AnoRegist, e.Cliente, e.MesRegist, e.Orden, e.Recnum }, "CSMY019_INDEX03")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.AnoRegist, e.MesRegist, e.OrdenCambio, e.Orden, e.Correlativo }, "CSMY019_INDEX04")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.AnoRegist, e.MesRegist, e.Vendedor01, e.Orden, e.Correlativo }, "CSMY019_INDEX05")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.Vendedor01, e.AnoRegist, e.MesRegist, e.Recnum }, "CSMY019_INDEX06")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.Cliente, e.Orden, e.Correlativo }, "CSMY019_INDEX07")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.AnoExist, e.MesExist, e.Cliente, e.Recnum }, "CSMY019_INDEX08")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.AnoRegist, e.TotalVenta, e.Recnum }, "CSMY019_INDEX09")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.AnoRegist, e.MesRegist, e.Orden, e.Correlativo, e.Fecha }, "CSMY019_INDEX10")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.Vendedor01, e.Orden, e.Recnum }, "CSMY019_INDEX11")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => e.Orden, "dep_csmy019orden");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.Correlativo).HasColumnName("CORRELATIVO");

                entity.Property(e => e.An8entregar)
                    .HasColumnType("decimal(14, 0)")
                    .HasColumnName("AN8ENTREGAR")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.An8facturar)
                    .HasColumnType("decimal(14, 0)")
                    .HasColumnName("AN8FACTURAR")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AnoExist).HasColumnName("ANO_EXIST");

                entity.Property(e => e.AnoOrden).HasColumnName("ANO_ORDEN");

                entity.Property(e => e.AnoRegist).HasColumnName("ANO_REGIST");

                entity.Property(e => e.Bajotiro)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BAJOTIRO")
                    .IsFixedLength();

                entity.Property(e => e.CambioEnCopy)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CAMBIO_EN_COPY")
                    .IsFixedLength();

                entity.Property(e => e.CambioEspecif)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CAMBIO_ESPECIF")
                    .IsFixedLength();

                entity.Property(e => e.Cargo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CARGO")
                    .IsFixedLength();

                entity.Property(e => e.ClaseOrden)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CLASE_ORDEN")
                    .IsFixedLength();

                entity.Property(e => e.Cliente).HasColumnName("CLIENTE");

                entity.Property(e => e.CodDivision).HasColumnName("COD_DIVISION");

                entity.Property(e => e.Comision)
                    .HasColumnType("decimal(4, 2)")
                    .HasColumnName("COMISION");

                entity.Property(e => e.Competidor).HasColumnName("COMPETIDOR");

                entity.Property(e => e.Cotizacion)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("COTIZACION")
                    .IsFixedLength();

                entity.Property(e => e.CteEntregar)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("CTE_ENTREGAR")
                    .IsFixedLength();

                entity.Property(e => e.CteEstablecido)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CTE_ESTABLECIDO")
                    .IsFixedLength();

                entity.Property(e => e.CteFacturar)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("CTE_FACTURAR")
                    .IsFixedLength();

                entity.Property(e => e.CteNuevo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CTE_NUEVO")
                    .IsFixedLength();

                entity.Property(e => e.DesctoGCantid)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DESCTO_G_CANTID")
                    .IsFixedLength();

                entity.Property(e => e.DiaOrden).HasColumnName("DIA_ORDEN");

                entity.Property(e => e.DiaRegist).HasColumnName("DIA_REGIST");

                entity.Property(e => e.DirecEntregar)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("DIREC_ENTREGAR")
                    .IsFixedLength();

                entity.Property(e => e.DirecEntregar2)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("DIREC_ENTREGAR2")
                    .IsFixedLength();

                entity.Property(e => e.DirecEntregar3)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("DIREC_ENTREGAR3")
                    .IsFixedLength();

                entity.Property(e => e.DirecFacturar)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("DIREC_FACTURAR")
                    .IsFixedLength();

                entity.Property(e => e.DirecFacturar2)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("DIREC_FACTURAR2")
                    .IsFixedLength();

                entity.Property(e => e.DirecFacturar3)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("DIREC_FACTURAR3")
                    .IsFixedLength();

                entity.Property(e => e.Embarque)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("EMBARQUE")
                    .IsFixedLength();

                entity.Property(e => e.Factura)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FACTURA$")
                    .IsFixedLength();

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.FechaEntrega)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ENTREGA");

                entity.Property(e => e.Fiscal)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FISCAL")
                    .IsFixedLength();

                entity.Property(e => e.FlagTransm)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_TRANSM")
                    .IsFixedLength();

                entity.Property(e => e.FlagV19)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_V19")
                    .IsFixedLength();

                entity.Property(e => e.Grupo01).HasColumnName("GRUPO_01");

                entity.Property(e => e.Grupo02).HasColumnName("GRUPO_02");

                entity.Property(e => e.ImpAOctava)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IMP_A_OCTAVA")
                    .IsFixedLength();

                entity.Property(e => e.ImpoASextos)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IMPO_A_SEXTOS")
                    .IsFixedLength();

                entity.Property(e => e.Impresor)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("IMPRESOR")
                    .IsFixedLength();

                entity.Property(e => e.InstFacturar)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("INST_FACTURAR")
                    .IsFixedLength();

                entity.Property(e => e.LugarEnviar)
                    .HasColumnType("text")
                    .HasColumnName("LUGAR_ENVIAR");

                entity.Property(e => e.MesAjuste).HasColumnName("MES_AJUSTE");

                entity.Property(e => e.MesExist).HasColumnName("MES_EXIST");

                entity.Property(e => e.MesOrden).HasColumnName("MES_ORDEN");

                entity.Property(e => e.MesRegist).HasColumnName("MES_REGIST");

                entity.Property(e => e.MetodoLista)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("METODO_LISTA")
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE")
                    .IsFixedLength();

                entity.Property(e => e.OperBasica).HasColumnName("OPER_BASICA");

                entity.Property(e => e.OrdAnulada)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ORD_ANULADA")
                    .IsFixedLength();

                entity.Property(e => e.OrdenAnterior).HasColumnName("ORDEN_ANTERIOR");

                entity.Property(e => e.OrdenCambio).HasColumnName("ORDEN_CAMBIO");

                entity.Property(e => e.OrdenCliente)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("ORDEN_CLIENTE")
                    .IsFixedLength();

                entity.Property(e => e.OrdenComb)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ORDEN_COMB")
                    .IsFixedLength();

                entity.Property(e => e.OrdenJobbing).HasColumnName("ORDEN_JOBBING");

                entity.Property(e => e.OrdenNueva)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ORDEN_NUEVA")
                    .IsFixedLength();

                entity.Property(e => e.PaisOrden).HasColumnName("PAIS_ORDEN");

                entity.Property(e => e.Parte).HasColumnName("PARTE");

                entity.Property(e => e.Porcent01).HasColumnName("PORCENT_01");

                entity.Property(e => e.Porcent02).HasColumnName("PORCENT_02");

                entity.Property(e => e.ProcesoBcs)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PROCESO_BCS")
                    .IsFixedLength();

                entity.Property(e => e.Prueba)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PRUEBA")
                    .IsFixedLength();

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.RepetExacta)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REPET_EXACTA")
                    .IsFixedLength();

                entity.Property(e => e.RepetLimitada)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REPET_LIMITADA")
                    .IsFixedLength();

                entity.Property(e => e.RifEntregar)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("RIF_ENTREGAR")
                    .IsFixedLength();

                entity.Property(e => e.RifFacturar)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("RIF_FACTURAR")
                    .IsFixedLength();

                entity.Property(e => e.RtotalLista)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RTOTAL_LISTA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RtotalVenta)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RTOTAL_VENTA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Sobretiro)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SOBRETIRO")
                    .IsFixedLength();

                entity.Property(e => e.StatusOrden)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("STATUS_ORDEN")
                    .IsFixedLength();

                entity.Property(e => e.SumaResta)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SUMA_RESTA")
                    .IsFixedLength();

                entity.Property(e => e.Superv01)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SUPERV_01")
                    .IsFixedLength();

                entity.Property(e => e.Superv02)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SUPERV_02")
                    .IsFixedLength();

                entity.Property(e => e.TipoNegocio)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_NEGOCIO")
                    .IsFixedLength();

                entity.Property(e => e.TipoOrden)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_ORDEN")
                    .IsFixedLength();

                entity.Property(e => e.TipoProduccion)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_PRODUCCION")
                    .IsFixedLength();

                entity.Property(e => e.TotalLista)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("TOTAL_LISTA");

                entity.Property(e => e.TotalVenta)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("TOTAL_VENTA");

                entity.Property(e => e.Vendedor01)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("VENDEDOR_01")
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.Vendedor02)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("VENDEDOR_02")
                    .IsFixedLength();

                entity.HasOne(d => d.ClienteNavigation)
                    .WithMany(p => p.Csmy019s)
                    .HasForeignKey(d => d.Cliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CSMY019_Clientes");
            });

            modelBuilder.Entity<Csmy020>(entity =>
            {
                entity.HasKey(e => new { e.Orden, e.Correlativo, e.Numero })
                    .HasName("CSMY020_INDEX01");

                entity.ToTable("CSMY020");

                entity.HasIndex(e => e.Recnum, "CSMY020_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.Orden, e.Correlativo, e.CodProducto, e.Numero }, "CSMY020_INDEX02")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.Orden, e.CodProducto, e.Correlativo, e.Recnum }, "CSMY020_INDEX03")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.CodProducto, e.Recnum }, "CSMY020_INDEX04")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.FechaOrden, e.LineaProduccio, e.Recnum }, "CSMY020_INDEX05")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => e.Orden, "dep_csmy020orden");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.Correlativo).HasColumnName("CORRELATIVO");

                entity.Property(e => e.Numero).HasColumnName("NUMERO");

                entity.Property(e => e.CantOrdenada).HasColumnName("CANT_ORDENADA");

                entity.Property(e => e.CodProducto)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("COD_PRODUCTO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Cotizacion)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("COTIZACION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DescForma)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DESC_FORMA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DescProducto)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DESC_PRODUCTO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FamiliaProduc)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("FAMILIA_PRODUC")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FechaOrden)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ORDEN")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.FechaTasa)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_TASA");

                entity.Property(e => e.ImpPorConsumo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IMP_POR_CONSUMO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.LineaIncoming).HasColumnName("LINEA_INCOMING");

                entity.Property(e => e.LineaProduccio)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("LINEA_PRODUCCIO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ListaTotDolar)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("LISTA_TOT_DOLAR");

                entity.Property(e => e.ListaUniDolar)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("LISTA_UNI_DOLAR");

                entity.Property(e => e.MetodoLista)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("METODO_LISTA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Parte).HasColumnName("PARTE");

                entity.Property(e => e.PrecioCompetid)
                    .HasColumnType("decimal(10, 4)")
                    .HasColumnName("PRECIO_COMPETID");

                entity.Property(e => e.PrecioFactura)
                    .HasColumnType("decimal(16, 4)")
                    .HasColumnName("PRECIO_FACTURA");

                entity.Property(e => e.PrecioLista)
                    .HasColumnType("decimal(16, 4)")
                    .HasColumnName("PRECIO_LISTA");

                entity.Property(e => e.PrecioVenta)
                    .HasColumnType("decimal(16, 4)")
                    .HasColumnName("PRECIO_VENTA");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.RprecioFactura)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RPRECIO_FACTURA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RprecioLista)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RPRECIO_LISTA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RprecioVenta)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RPRECIO_VENTA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RtasaNegociaci)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RTASA_NEGOCIACI")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RtotalLista)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RTOTAL_LISTA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RtotalVenta)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RTOTAL_VENTA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TasaNegociacio)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("TASA_NEGOCIACIO");

                entity.Property(e => e.TipoProducto)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_PRODUCTO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TotalLista)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("TOTAL_LISTA");

                entity.Property(e => e.TotalVenta)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("TOTAL_VENTA");

                entity.Property(e => e.UnidadFactura)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("UNIDAD_FACTURA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.VentaTotDolar)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("VENTA_TOT_DOLAR");

                entity.Property(e => e.VentaUniDolar)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("VENTA_UNI_DOLAR");
            });

            modelBuilder.Entity<Csmy021>(entity =>
            {
                entity.HasKey(e => new { e.Orden, e.Correlativo, e.NoPartePapel })
                    .HasName("CSMY021_INDEX01");

                entity.ToTable("CSMY021");

                entity.HasIndex(e => e.Recnum, "CSMY021_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => e.MedidaPapel, "IX_CSMY021")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.CodPapel, "IX_CSMY021_1")
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.NoPartePapel, e.Orden, e.CodPapel }, "_dta_index_CSMY021_24_1703677117__K4_K33_K37");

                entity.HasIndex(e => e.Orden, "dep_csmy021orden");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.Correlativo).HasColumnName("CORRELATIVO");

                entity.Property(e => e.NoPartePapel).HasColumnName("NO_PARTE_PAPEL");

                entity.Property(e => e.CarbSpot)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CARB_SPOT")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ClasePapel).HasColumnName("CLASE_PAPEL");

                entity.Property(e => e.CodCarbon)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("COD_CARBON")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CodPapel)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("COD_PAPEL")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ColorCarbon)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("COLOR_CARBON")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ColorPapel).HasColumnName("COLOR_PAPEL");

                entity.Property(e => e.ConPrimTintar)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CON_PRIM_TINTAR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CondCuarTinta)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("COND_CUAR_TINTA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CondPrimTinta)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("COND_PRIM_TINTA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CondQuinTinta)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("COND_QUIN_TINTA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CondSegTinta)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("COND_SEG_TINTA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CondSegTintar)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("COND_SEG_TINTAR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CondSexTinta)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("COND_SEX_TINTA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CondTerTintar)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("COND_TER_TINTAR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CondTercTinta)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("COND_TERC_TINTA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Cotizacion)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("COTIZACION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CuarTintaFren)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CUAR_TINTA_FREN")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CuarTintaResp)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CUAR_TINTA_RESP")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FraseMarginal)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("FRASE_MARGINAL");

                entity.Property(e => e.KilosCarbon)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("KILOS_CARBON");

                entity.Property(e => e.KilosPapel)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("KILOS_PAPEL");

                entity.Property(e => e.MedMatPapDec)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("MED_MAT_PAP_DEC");

                entity.Property(e => e.MedTalonDer)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("MED_TALON_DER")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.MedTalonIzq)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("MED_TALON_IZQ")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Medcarbonent)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("MEDCARBONENT");

                entity.Property(e => e.MedidaCarbon)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("MEDIDA_CARBON")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.MedidaMatPap).HasColumnName("MEDIDA_MAT_PAP");

                entity.Property(e => e.MedidaPapel).HasColumnName("MEDIDA_PAPEL");

                entity.Property(e => e.Parte).HasColumnName("PARTE");

                entity.Property(e => e.PerfHorizontal)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PERF_HORIZONTAL")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PerfVertical)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PERF_VERTICAL")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PesoPapel).HasColumnName("PESO_PAPEL");

                entity.Property(e => e.PosTalon)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("POS_TALON")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PrecioPapel)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("PRECIO_PAPEL");

                entity.Property(e => e.PrimTintaFte)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("PRIM_TINTA_FTE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PrimTintaResp)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("PRIM_TINTA_RESP")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Prueba)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PRUEBA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.QuinTintaFren)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("QUIN_TINTA_FREN")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.QuinTintaResp)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("QUIN_TINTA_RESP")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.RprecioPapel)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RPRECIO_PAPEL")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SegTintaFrent)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("SEG_TINTA_FRENT")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SegTintaResp)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("SEG_TINTA_RESP")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SexTintaFren)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("SEX_TINTA_FREN")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SexTintaResp)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("SEX_TINTA_RESP")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TalonExtra).HasColumnName("TALON_EXTRA");

                entity.Property(e => e.TercTintaFren)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("TERC_TINTA_FREN")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TercTintaResp)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("TERC_TINTA_RESP")
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Csmy022>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CSMY022");

                entity.HasIndex(e => e.Recnum, "CSMY022_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => e.Orden, "IX_CSMY022");

                entity.HasIndex(e => e.Orden, "dep_csmy022orden");

                entity.Property(e => e.AnchoFormula).HasColumnName("ANCHO_FORMULA");

                entity.Property(e => e.Caracterist01)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CARACTERIST_01")
                    .IsFixedLength();

                entity.Property(e => e.Caracterist02)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CARACTERIST_02")
                    .IsFixedLength();

                entity.Property(e => e.Caracterist03)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CARACTERIST_03")
                    .IsFixedLength();

                entity.Property(e => e.Caracterist04)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CARACTERIST_04")
                    .IsFixedLength();

                entity.Property(e => e.Caracterist05)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CARACTERIST_05")
                    .IsFixedLength();

                entity.Property(e => e.Caracterist06)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CARACTERIST_06")
                    .IsFixedLength();

                entity.Property(e => e.Caracterist07)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CARACTERIST_07")
                    .IsFixedLength();

                entity.Property(e => e.Caracterist08)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CARACTERIST_08")
                    .IsFixedLength();

                entity.Property(e => e.Caracterist09)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CARACTERIST_09")
                    .IsFixedLength();

                entity.Property(e => e.Caracterist10)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CARACTERIST_10")
                    .IsFixedLength();

                entity.Property(e => e.Caracterist11)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CARACTERIST_11")
                    .IsFixedLength();

                entity.Property(e => e.Caracterist12)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CARACTERIST_12")
                    .IsFixedLength();

                entity.Property(e => e.Caracterist13)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CARACTERIST_13")
                    .IsFixedLength();

                entity.Property(e => e.Caracterist14)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CARACTERIST_14")
                    .IsFixedLength();

                entity.Property(e => e.Caracterist15)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CARACTERIST_15")
                    .IsFixedLength();

                entity.Property(e => e.Correlativo).HasColumnName("CORRELATIVO");

                entity.Property(e => e.Cotizacion)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("COTIZACION")
                    .IsFixedLength();

                entity.Property(e => e.FcCantPonches)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("FC_CANT_PONCHES")
                    .IsFixedLength();

                entity.Property(e => e.FcDiamPonches)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("FC_DIAM_PONCHES")
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.FcPoncheCac)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("FC_PONCHE_CAC")
                    .IsFixedLength();

                entity.Property(e => e.FcPoncheClase)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("FC_PONCHE_CLASE")
                    .IsFixedLength();

                entity.Property(e => e.FcPoncheHojas)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("FC_PONCHE_HOJAS")
                    .IsFixedLength();

                entity.Property(e => e.FcPonchePosic)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("FC_PONCHE_POSIC")
                    .IsFixedLength();

                entity.Property(e => e.LargoFormula).HasColumnName("LARGO_FORMULA");

                entity.Property(e => e.MicrPartes)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MICR_PARTES")
                    .IsFixedLength();

                entity.Property(e => e.NumAceptaFalt)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NUM_ACEPTA_FALT")
                    .IsFixedLength();

                entity.Property(e => e.NumBarril)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NUM_BARRIL")
                    .IsFixedLength();

                entity.Property(e => e.NumCliDesde)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NUM_CLI_DESDE");

                entity.Property(e => e.NumCliHasta)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NUM_CLI_HASTA");

                entity.Property(e => e.NumIndividual)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NUM_INDIVIDUAL")
                    .IsFixedLength();

                entity.Property(e => e.NumPlana)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NUM_PLANA")
                    .IsFixedLength();

                entity.Property(e => e.NumPos)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("NUM_POS")
                    .IsFixedLength();

                entity.Property(e => e.NumPresion)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NUM_PRESION")
                    .IsFixedLength();

                entity.Property(e => e.NumeroExtra)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NUMERO_EXTRA")
                    .IsFixedLength();

                entity.Property(e => e.NumeroPrefijo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NUMERO_PREFIJO")
                    .IsFixedLength();

                entity.Property(e => e.NumeroSubfijo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NUMERO_SUBFIJO")
                    .IsFixedLength();

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.Parte).HasColumnName("PARTE");

                entity.Property(e => e.PartesFormula).HasColumnName("PARTES_FORMULA");

                entity.Property(e => e.PerfMargDer)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("PERF_MARG_DER")
                    .IsFixedLength();

                entity.Property(e => e.PerfMargIzq)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("PERF_MARG_IZQ")
                    .IsFixedLength();

                entity.Property(e => e.PerfTalOpCab)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PERF_TAL_OP_CAB")
                    .IsFixedLength();

                entity.Property(e => e.PerfTalonDer)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PERF_TALON_DER")
                    .IsFixedLength();

                entity.Property(e => e.PerfTalonDern)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("PERF_TALON_DERN")
                    .IsFixedLength();

                entity.Property(e => e.PerfTalonIzq)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PERF_TALON_IZQ")
                    .IsFixedLength();

                entity.Property(e => e.PerfTalonIzqn)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("PERF_TALON_IZQN")
                    .IsFixedLength();

                entity.Property(e => e.PerfTalonNing)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PERF_TALON_NING")
                    .IsFixedLength();

                entity.Property(e => e.PerfTalonOpac)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PERF_TALON_OPAC")
                    .IsFixedLength();

                entity.Property(e => e.PoncMargDer)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PONC_MARG_DER")
                    .IsFixedLength();

                entity.Property(e => e.PoncMargIzq)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PONC_MARG_IZQ")
                    .IsFixedLength();

                entity.Property(e => e.Prefijo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PREFIJO")
                    .IsFixedLength();

                entity.Property(e => e.PrefijoCli)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PREFIJO_CLI");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.SpeAcabEspec)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SPE_ACAB_ESPEC")
                    .IsFixedLength();

                entity.Property(e => e.SpeAcabGrupos)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("SPE_ACAB_GRUPOS")
                    .IsFixedLength();

                entity.Property(e => e.SpeAcabSuelto)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SPE_ACAB_SUELTO")
                    .IsFixedLength();

                entity.Property(e => e.SpeBlockEngom)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SPE_BLOCK_ENGOM")
                    .IsFixedLength();

                entity.Property(e => e.SpeCaratEnvol)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SPE_CARAT_ENVOL")
                    .IsFixedLength();

                entity.Property(e => e.SpeDevDibujo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SPE_DEV_DIBUJO")
                    .IsFixedLength();

                entity.Property(e => e.SpeEngr)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SPE_ENGR")
                    .IsFixedLength();

                entity.Property(e => e.SpeEntrDibujo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SPE_ENTR_DIBUJO")
                    .IsFixedLength();

                entity.Property(e => e.SpeHaceDibujo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SPE_HACE_DIBUJO")
                    .IsFixedLength();

                entity.Property(e => e.SpeStokDibujo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SPE_STOK_DIBUJO")
                    .IsFixedLength();

                entity.Property(e => e.SpeTalonEngr)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SPE_TALON_ENGR")
                    .IsFixedLength();

                entity.Property(e => e.SpeTalonOpues)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SPE_TALON_OPUES")
                    .IsFixedLength();

                entity.Property(e => e.Sufijo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SUFIJO")
                    .IsFixedLength();

                entity.Property(e => e.SufijoCli)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SUFIJO_CLI");

                entity.Property(e => e.SujCarbEngom)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SUJ_CARB_ENGOM")
                    .IsFixedLength();

                entity.Property(e => e.SujCarbonDer)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SUJ_CARBON_DER")
                    .IsFixedLength();

                entity.Property(e => e.SujCarbonIzq)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SUJ_CARBON_IZQ")
                    .IsFixedLength();

                entity.Property(e => e.SujCarbonSpd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SUJ_CARBON_SPD")
                    .IsFixedLength();

                entity.Property(e => e.SujOpacoDer)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SUJ_OPACO_DER")
                    .IsFixedLength();

                entity.Property(e => e.SujOpacoEngom)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SUJ_OPACO_ENGOM")
                    .IsFixedLength();

                entity.Property(e => e.SujOpacoIzq)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SUJ_OPACO_IZQ")
                    .IsFixedLength();

                entity.Property(e => e.SujOpacoSfd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SUJ_OPACO_SFD")
                    .IsFixedLength();

                entity.Property(e => e.SujOpacoSfi)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SUJ_OPACO_SFI")
                    .IsFixedLength();

                entity.Property(e => e.SujOpacoSflex)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SUJ_OPACO_SFLEX")
                    .IsFixedLength();

                entity.Property(e => e.SujOpacoSpeed)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SUJ_OPACO_SPEED")
                    .IsFixedLength();

                entity.Property(e => e.TalonCabeza)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("TALON_CABEZA")
                    .IsFixedLength();

                entity.Property(e => e.TalonPie)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("TALON_PIE")
                    .IsFixedLength();

                entity.Property(e => e.TintaIgual1)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("TINTA_IGUAL1")
                    .IsFixedLength();

                entity.Property(e => e.TintaIgual2)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("TINTA_IGUAL2")
                    .IsFixedLength();

                entity.Property(e => e.WizCopyNoA)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("WIZ_COPY_NO_A")
                    .IsFixedLength();

                entity.Property(e => e.WizCopyNoDe)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("WIZ_COPY_NO_DE")
                    .IsFixedLength();

                entity.Property(e => e.WizEmpaqRegul)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("WIZ_EMPAQ_REGUL")
                    .IsFixedLength();

                entity.Property(e => e.WizEmpaquePaq)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("WIZ_EMPAQUE_PAQ")
                    .IsFixedLength();

                entity.Property(e => e.WizPoncheArch)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("WIZ_PONCHE_ARCH")
                    .IsFixedLength();

                entity.Property(e => e.WizSbTiro)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("WIZ_SB_TIRO")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Csmy022a>(entity =>
            {
                entity.HasKey(e => new { e.Orden, e.Correlativo })
                    .HasName("CSMY022_INDEX01");

                entity.ToTable("CSMY022a");

                entity.HasIndex(e => e.Recnum, "CSMY022_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => e.Orden, "dep_csmy022aorden");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.Correlativo).HasColumnName("CORRELATIVO");

                entity.Property(e => e.AnchoFormula).HasColumnName("ANCHO_FORMULA");

                entity.Property(e => e.Caracterist01)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CARACTERIST_01")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Caracterist02)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CARACTERIST_02")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Caracterist03)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CARACTERIST_03")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Caracterist04)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CARACTERIST_04")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Caracterist05)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CARACTERIST_05")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Caracterist06)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CARACTERIST_06")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Caracterist07)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CARACTERIST_07")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Caracterist08)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CARACTERIST_08")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Caracterist09)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CARACTERIST_09")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Caracterist10)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CARACTERIST_10")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Caracterist11)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CARACTERIST_11")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Caracterist12)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CARACTERIST_12")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Caracterist13)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CARACTERIST_13")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Caracterist14)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CARACTERIST_14")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Caracterist15)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CARACTERIST_15")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Cotizacion)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("COTIZACION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FcCantPonches)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("FC_CANT_PONCHES")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FcDiamPonches)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("FC_DIAM_PONCHES")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FcPoncheCac)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("FC_PONCHE_CAC")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FcPoncheClase)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("FC_PONCHE_CLASE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FcPoncheHojas)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("FC_PONCHE_HOJAS")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FcPonchePosic)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("FC_PONCHE_POSIC")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.LargoFormula).HasColumnName("LARGO_FORMULA");

                entity.Property(e => e.MicrPartes)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MICR_PARTES")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NumAceptaFalt)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NUM_ACEPTA_FALT")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NumBarril)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NUM_BARRIL")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NumIndividual)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NUM_INDIVIDUAL")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NumPlana)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NUM_PLANA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NumPos)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("NUM_POS")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NumPresion)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NUM_PRESION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NumeroExtra)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NUMERO_EXTRA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NumeroPrefijo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NUMERO_PREFIJO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NumeroSubfijo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NUMERO_SUBFIJO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Parte).HasColumnName("PARTE");

                entity.Property(e => e.PartesFormula).HasColumnName("PARTES_FORMULA");

                entity.Property(e => e.PerfMargDer)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("PERF_MARG_DER")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PerfMargIzq)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("PERF_MARG_IZQ")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PerfTalOpCab)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PERF_TAL_OP_CAB")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PerfTalonDer)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PERF_TALON_DER")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PerfTalonDern)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("PERF_TALON_DERN")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PerfTalonIzq)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PERF_TALON_IZQ")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PerfTalonIzqn)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("PERF_TALON_IZQN")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PerfTalonNing)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PERF_TALON_NING")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PerfTalonOpac)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PERF_TALON_OPAC")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PoncMargDer)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PONC_MARG_DER")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PoncMargIzq)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PONC_MARG_IZQ")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Prefijo)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("PREFIJO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.SpeAcabEspec)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SPE_ACAB_ESPEC")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SpeAcabGrupos)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("SPE_ACAB_GRUPOS")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SpeAcabSuelto)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SPE_ACAB_SUELTO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SpeBlockEngom)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SPE_BLOCK_ENGOM")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SpeCaratEnvol)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SPE_CARAT_ENVOL")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SpeDevDibujo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SPE_DEV_DIBUJO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SpeEngr)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SPE_ENGR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SpeEntrDibujo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SPE_ENTR_DIBUJO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SpeHaceDibujo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SPE_HACE_DIBUJO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SpeStokDibujo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SPE_STOK_DIBUJO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SpeTalonEngr)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SPE_TALON_ENGR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SpeTalonOpues)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SPE_TALON_OPUES")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Sufijo)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SUFIJO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SujCarbEngom)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SUJ_CARB_ENGOM")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SujCarbonDer)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SUJ_CARBON_DER")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SujCarbonIzq)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SUJ_CARBON_IZQ")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SujCarbonSpd)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SUJ_CARBON_SPD")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SujOpacoDer)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SUJ_OPACO_DER")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SujOpacoEngom)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SUJ_OPACO_ENGOM")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SujOpacoIzq)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SUJ_OPACO_IZQ")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SujOpacoSfd)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SUJ_OPACO_SFD")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SujOpacoSfi)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SUJ_OPACO_SFI")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SujOpacoSflex)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SUJ_OPACO_SFLEX")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SujOpacoSpeed)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SUJ_OPACO_SPEED")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TalonCabeza)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("TALON_CABEZA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TalonPie)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("TALON_PIE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TintaIgual1)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("TINTA_IGUAL1")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TintaIgual2)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("TINTA_IGUAL2")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.WizCopyNoA)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("WIZ_COPY_NO_A")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.WizCopyNoDe)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("WIZ_COPY_NO_DE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.WizEmpaqRegul)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("WIZ_EMPAQ_REGUL")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.WizEmpaquePaq)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("WIZ_EMPAQUE_PAQ")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.WizPoncheArch)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("WIZ_PONCHE_ARCH")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.WizSbTiro)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("WIZ_SB_TIRO")
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Csmy023>(entity =>
            {
                entity.HasKey(e => new { e.Orden, e.Correlativo })
                    .HasName("CSMY023_INDEX01");

                entity.ToTable("CSMY023");

                entity.HasIndex(e => e.Recnum, "CSMY023_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => e.Orden, "dep_csmy023orden");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.Correlativo).HasColumnName("CORRELATIVO");

                entity.Property(e => e.Cotizacion)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("COTIZACION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Instru01)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("INSTRU_01")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Instru02)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("INSTRU_02")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Instru03)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("INSTRU_03")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Instru04)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("INSTRU_04")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Instru05)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("INSTRU_05")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Instru06)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("INSTRU_06")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Instru07)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("INSTRU_07")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Instru08)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("INSTRU_08")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Instru09)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("INSTRU_09")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Instru10)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("INSTRU_10")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Instru11)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("INSTRU_11")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Instru12)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("INSTRU_12")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Instru13)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("INSTRU_13")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Instru14)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("INSTRU_14")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Instru15)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("INSTRU_15")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Instru16)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("INSTRU_16")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Instru17)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("INSTRU_17")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Instru18)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("INSTRU_18")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Instru19)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("INSTRU_19")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Parte).HasColumnName("PARTE");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");
            });

            modelBuilder.Entity<Csmy076>(entity =>
            {
                entity.HasKey(e => new { e.CodProducto, e.Lista })
                    .HasName("CSMY076_INDEX01");

                entity.ToTable("CSMY076");

                entity.HasIndex(e => e.Recnum, "CSMY076_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.CodProducto)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("COD_PRODUCTO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Lista)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("LISTA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CantBlock)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CANT_BLOCK")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CantidadMinima).HasColumnName("CANTIDAD_MINIMA");

                entity.Property(e => e.CaratulaEnv)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CARATULA_ENV")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Engomado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ENGOMADO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Engrapado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ENGRAPADO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.HoyosArchivo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("HOYOS_ARCHIVO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.HoyosMarginal)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("HOYOS_MARGINAL")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NumCodBar)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NUM_COD_BAR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NumMicrPtes)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NUM_MICR_PTES")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Numeracion)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NUMERACION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PerfHorizontal)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PERF_HORIZONTAL")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PerfVertical)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PERF_VERTICAL")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.SFlex)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("S_FLEX")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SLock)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("S_LOCK")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Spot)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SPOT")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Suelto)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SUELTO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TamPosTalon)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TAM_POS_TALON")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TintasMaxFren).HasColumnName("TINTAS_MAX_FREN");

                entity.Property(e => e.TintasMaxResp).HasColumnName("TINTAS_MAX_RESP");

                entity.Property(e => e.TransferTape)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TRANSFER_TAPE")
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Csmy078>(entity =>
            {
                entity.HasKey(e => new { e.Orden, e.FechaEntrega })
                    .HasName("CSMY078_INDEX01");

                entity.ToTable("CSMY078");

                entity.HasIndex(e => e.Recnum, "CSMY078_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => e.Orden, "dep_csmy078orden");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.FechaEntrega)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ENTREGA")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.FlagActualizad)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_ACTUALIZAD")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.JobNo).HasColumnName("JOB_NO");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");
            });

            modelBuilder.Entity<Csmy091>(entity =>
            {
                entity.HasKey(e => e.Pais)
                    .HasName("CSMY091_INDEX01");

                entity.ToTable("CSMY091");

                entity.HasIndex(e => e.Recnum, "CSMY091_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.Pais)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PAIS")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CodCliente).HasColumnName("COD_CLIENTE");

                entity.Property(e => e.Concesion)
                    .HasColumnType("decimal(8, 4)")
                    .HasColumnName("CONCESION");

                entity.Property(e => e.CuentaCxcPais)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("CUENTA_CXC_PAIS");

                entity.Property(e => e.FactorCambio)
                    .HasColumnType("decimal(12, 6)")
                    .HasColumnName("FACTOR_CAMBIO");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");
            });

            modelBuilder.Entity<DatosclienteV>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DATOSCLIENTE_V");

                entity.Property(e => e.AfectaBacklog)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Afecta_Backlog")
                    .IsFixedLength();

                entity.Property(e => e.An8entregar).HasColumnName("AN8ENTREGAR");

                entity.Property(e => e.An8facturar).HasColumnName("AN8FACTURAR");

                entity.Property(e => e.AprobAdmin)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Aprob_Admin")
                    .IsFixedLength();

                entity.Property(e => e.AprobCob)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("Aprob_Cob")
                    .IsFixedLength();

                entity.Property(e => e.AprobCont)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("Aprob_Cont")
                    .IsFixedLength();

                entity.Property(e => e.AprobP)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("Aprob_P")
                    .IsFixedLength();

                entity.Property(e => e.ClienteNuevo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Cliente_Nuevo")
                    .IsFixedLength();

                entity.Property(e => e.CodRetencion).HasColumnName("COD_RETENCION");

                entity.Property(e => e.CodTeleop)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Cod_teleop")
                    .IsFixedLength();

                entity.Property(e => e.CodVend)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Cod_vend")
                    .IsFixedLength();

                entity.Property(e => e.CodigoClient)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Codigo_Client")
                    .IsFixedLength();

                entity.Property(e => e.Contacto)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("contacto")
                    .IsFixedLength();

                entity.Property(e => e.CotizacionGeneral).HasMaxLength(13);

                entity.Property(e => e.CotizacionOriginal)
                    .HasMaxLength(18)
                    .HasColumnName("COTIZACION_ORIGINAL");

                entity.Property(e => e.DescTipoPago)
                    .HasColumnType("numeric(2, 0)")
                    .HasColumnName("Desc_Tipo_Pago");

                entity.Property(e => e.DirecEnt)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("Direc_Ent")
                    .IsFixedLength();

                entity.Property(e => e.DirecFact)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("Direc_Fact")
                    .IsFixedLength();

                entity.Property(e => e.Dolares)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email")
                    .IsFixedLength();

                entity.Property(e => e.EnviarEmail)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Enviar_email")
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FecAproCob)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Fec_Apro_Cob");

                entity.Property(e => e.FecAproP)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Fec_Apro_P");

                entity.Property(e => e.FecCob)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Fec_Cob")
                    .IsFixedLength();

                entity.Property(e => e.FecDol)
                    .HasColumnType("datetime")
                    .HasColumnName("Fec_Dol");

                entity.Property(e => e.FecGrab)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Fec_Grab");

                entity.Property(e => e.FecOrd)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Fec_Ord")
                    .IsFixedLength();

                entity.Property(e => e.FechaAprobAdm)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Fecha_Aprob_Adm");

                entity.Property(e => e.FechaAprobCont)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Fecha_Aprob_Cont");

                entity.Property(e => e.FechaDespacho)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Fecha_Despacho")
                    .IsFixedLength();

                entity.Property(e => e.FechaEntrega)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Fecha_Entrega");

                entity.Property(e => e.FechaFactura)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Fecha_Factura")
                    .IsFixedLength();

                entity.Property(e => e.FechaPasada)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Fecha_Pasada");

                entity.Property(e => e.FechaRecibCliente)
                    .HasMaxLength(26)
                    .IsUnicode(false)
                    .HasColumnName("Fecha_Recib_Cliente")
                    .IsFixedLength();

                entity.Property(e => e.FlagCombo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("flag_combo")
                    .IsFixedLength();

                entity.Property(e => e.FlagSinAdj)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_SIN_ADJ")
                    .IsFixedLength();

                entity.Property(e => e.GrabCliente)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GRAB_CLIENTE")
                    .IsFixedLength();

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ID");

                entity.Property(e => e.IdContactos)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ID_CONTACTOS");

                entity.Property(e => e.IdDireccion)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Id_Direccion");

                entity.Property(e => e.NoAsignacion)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("No_Asignacion")
                    .IsFixedLength();

                entity.Property(e => e.NomCliente)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("Nom_Cliente")
                    .IsFixedLength();

                entity.Property(e => e.NomEnt)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("Nom_Ent")
                    .IsFixedLength();

                entity.Property(e => e.NombFact)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("Nomb_Fact")
                    .IsFixedLength();

                entity.Property(e => e.NumCot)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Num_Cot");

                entity.Property(e => e.ObsRetencion)
                    .HasMaxLength(250)
                    .HasColumnName("OBS_RETENCION");

                entity.Property(e => e.ObserSaca)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("obser_saca")
                    .IsFixedLength();

                entity.Property(e => e.ObservCliente)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Observ_Cliente")
                    .IsFixedLength();

                entity.Property(e => e.Oficina)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrdCompra)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Ord_compra")
                    .IsFixedLength();

                entity.Property(e => e.Orden).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PtoReferencia)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("Pto_Referencia")
                    .IsFixedLength();

                entity.Property(e => e.RboCob)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Rbo_Cob")
                    .IsFixedLength();

                entity.Property(e => e.RequiereNe)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REQUIERE_NE")
                    .IsFixedLength();

                entity.Property(e => e.RifEnt)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("Rif_Ent")
                    .IsFixedLength();

                entity.Property(e => e.RifFact)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("Rif_Fact")
                    .IsFixedLength();

                entity.Property(e => e.Rtasa).HasColumnName("RTasa");

                entity.Property(e => e.SiColetilla)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Si_Coletilla")
                    .IsFixedLength();

                entity.Property(e => e.SiIndexacion)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Si_Indexacion")
                    .IsFixedLength();

                entity.Property(e => e.SinRif)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Sin_Rif")
                    .IsFixedLength();

                entity.Property(e => e.Solaprob)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SOLAPROB")
                    .IsFixedLength();

                entity.Property(e => e.Solaprob2)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SOLAPROB2")
                    .IsFixedLength();

                entity.Property(e => e.StatusOrden)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("STATUS_ORDEN")
                    .IsFixedLength();

                entity.Property(e => e.TipoPago)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Tipo_Pago")
                    .IsFixedLength();

                entity.Property(e => e.Unidad)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Vendedoric)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("VENDEDORIC");
            });

            modelBuilder.Entity<DatosproductosV>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DATOSPRODUCTOS_V");

                entity.Property(e => e.BsMcFinan)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("BS_MC_FINAN");

                entity.Property(e => e.BsMcPapel)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("BS_MC_PAPEL");

                entity.Property(e => e.Cajas).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CantDesp)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Cant_desp");

                entity.Property(e => e.CantFormas)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Cant_Formas");

                entity.Property(e => e.CantMill).HasColumnName("Cant_Mill");

                entity.Property(e => e.CantV19).HasColumnName("Cant_V19");

                entity.Property(e => e.CantXCaja)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Cant_x_Caja");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Concesion).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CotizacionGeneral).HasMaxLength(13);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EnviarEmail)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Enviar_email")
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Excepcion)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

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
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Lista_Tot");

                entity.Property(e => e.LongitudMascara).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MarcaConcesion)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Marca_Concesion")
                    .IsFixedLength();

                entity.Property(e => e.NumCot)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Num_Cot");

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

                entity.Property(e => e.PorcCom)
                    .HasColumnType("numeric(4, 2)")
                    .HasColumnName("PORC_COM");

                entity.Property(e => e.PorcMcFinan)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("PORC_MC_FINAN");

                entity.Property(e => e.PorcMcPapel)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("PORC_MC_PAPEL");

                entity.Property(e => e.PrecDol)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Prec_Dol");

                entity.Property(e => e.RbsMcFinan)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RBS_MC_FINAN");

                entity.Property(e => e.RbsMcPapel)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RBS_MC_PAPEL");

                entity.Property(e => e.RecWsmy469)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("RecWSMY469");

                entity.Property(e => e.Remision)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RlistaTot)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("RLista_Tot");

                entity.Property(e => e.RvalorLista)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("RValor_Lista");

                entity.Property(e => e.RventaTot)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("RVenta_Tot");

                entity.Property(e => e.RventaUnit)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("RVenta_Unit");

                entity.Property(e => e.TipoDocumento)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoIva).HasColumnName("tipo_iva");

                entity.Property(e => e.TotListDol)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Tot_List_Dol");

                entity.Property(e => e.TotVentDol)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Tot_Vent_Dol");

                entity.Property(e => e.UnidadCosteo)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Unidad_Costeo");

                entity.Property(e => e.ValListaDol)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Val_Lista_Dol");

                entity.Property(e => e.ValorLista)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Valor_Lista");

                entity.Property(e => e.VentaTot)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Venta_Tot");

                entity.Property(e => e.VentaUnit)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Venta_Unit");
            });

            modelBuilder.Entity<DetalleBacklogEstacion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DetalleBacklogEstacion");

                entity.Property(e => e.Bsxhoramaq).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.CantidadProgramada).HasColumnType("numeric(21, 8)");

                entity.Property(e => e.Cliente)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodProducto)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Colectora)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Dias)
                    .HasColumnType("decimal(38, 18)")
                    .HasColumnName("dias");

                entity.Property(e => e.DiasEstacion).HasColumnType("decimal(38, 22)");

                entity.Property(e => e.Estacion)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Familia)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaEntrega)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_entrega");

                entity.Property(e => e.GrupoCalendario)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Horasxturno)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("horasxturno");

                entity.Property(e => e.IdCalendario)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.JobId).HasColumnName("JOB_ID");

                entity.Property(e => e.Linea)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LineaCalendario)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.Pendiente).HasColumnType("numeric(21, 8)");

                entity.Property(e => e.Pies).HasColumnType("decimal(17, 2)");

                entity.Property(e => e.Piesxhoramaq).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.PrecioVenta).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.PrecioVentaUsd).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.Prensa)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Titulo)
                    .HasMaxLength(90)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DetalleBacklogEstacionEstimado>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DetalleBacklogEstacionEstimado");

                entity.HasIndex(e => new { e.FechaEstimacionJuliana, e.Prensa }, "IX_DetalleBacklogEstacionEstimado");

                entity.HasIndex(e => e.Orden, "dep_DetalleBacklogEstacionEstimadoorden");

                entity.Property(e => e.AñoMesEntrega).HasColumnType("numeric(6, 0)");

                entity.Property(e => e.AñoMesEstimacion).HasColumnType("numeric(6, 0)");

                entity.Property(e => e.AñoMesUltimaProduccion).HasColumnType("numeric(6, 0)");

                entity.Property(e => e.Bsxhoramaq).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.CantidadProgramada).HasColumnType("numeric(21, 8)");

                entity.Property(e => e.Cliente)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodProducto)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Colectora)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cotizacion).HasMaxLength(20);

                entity.Property(e => e.Dias)
                    .HasColumnType("decimal(38, 19)")
                    .HasColumnName("dias");

                entity.Property(e => e.DiasEstacion).HasColumnType("decimal(38, 22)");

                entity.Property(e => e.Estacion)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estatus).HasMaxLength(50);

                entity.Property(e => e.Familia)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaEntrega)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_entrega");

                entity.Property(e => e.FechaEstimacion).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaEstimacionJuliana).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.FechaUltimaProduccionMes).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.GrupoCalendario)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Horasxturno)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("horasxturno");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdCalendario)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.JobId).HasColumnName("JOB_ID");

                entity.Property(e => e.Linea)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LineaCalendario)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.Origen).HasMaxLength(50);

                entity.Property(e => e.Papel).HasMaxLength(1);

                entity.Property(e => e.Pendiente).HasColumnType("numeric(21, 8)");

                entity.Property(e => e.Pies).HasColumnType("decimal(17, 2)");

                entity.Property(e => e.Piesxhoramaq).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.PrecioVenta).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.Prensa)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Rbsxhoramaq)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RBsxhoramaq");

                entity.Property(e => e.RprecioVenta)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("RPrecioVenta");

                entity.Property(e => e.Titulo)
                    .HasMaxLength(90)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DiasAdministradora>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DIAS ADMINISTRADORAS");

                entity.Property(e => e.Cliente)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("CLIENTE")
                    .IsFixedLength();

                entity.Property(e => e.DiasAdministradora1)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DIAS_ADMINISTRADORA");

                entity.Property(e => e.DiasVentas)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DIAS_VENTAS");

                entity.Property(e => e.FechaAprobAdm)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FECHA_APROB_ADM");

                entity.Property(e => e.Grabada)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("GRABADA");

                entity.Property(e => e.NombreVendedor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_VENDEDOR")
                    .IsFixedLength();

                entity.Property(e => e.Oficina)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("OFICINA")
                    .IsFixedLength();

                entity.Property(e => e.Orden)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ORDEN");

                entity.Property(e => e.Tomada)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("TOMADA");

                entity.Property(e => e.Web)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("WEB")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Dwtinta>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DWTINTAS");

                entity.HasIndex(e => e.Orden, "dep_DwTintasorden");

                entity.Property(e => e.CantTintas).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Color).HasMaxLength(6);

                entity.Property(e => e.Orden).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<FechasErrada>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("FECHAS ERRADAS");

                entity.Property(e => e.Ano).HasColumnName("ANO");

                entity.Property(e => e.DiasAdministradora)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DIAS_ADMINISTRADORA");

                entity.Property(e => e.DiasVentas)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DIAS_VENTAS");

                entity.Property(e => e.FechaAprobAdm)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FECHA_APROB_ADM");

                entity.Property(e => e.Grabada)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("GRABADA");

                entity.Property(e => e.Mes).HasColumnName("MES");

                entity.Property(e => e.NombreVendedor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_VENDEDOR")
                    .IsFixedLength();

                entity.Property(e => e.Oficina)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("OFICINA")
                    .IsFixedLength();

                entity.Property(e => e.Orden)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ORDEN");

                entity.Property(e => e.Tomada)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("TOMADA");
            });

            modelBuilder.Entity<HistoricoAprobacionCredito>(entity =>
            {
                entity.ToTable("HistoricoAprobacionCredito");

                entity.HasIndex(e => e.Cotizacion, "IX_HistoricoAprobacionCredito")
                    .HasFillFactor(80);

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Ceos)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("CEOS");

                entity.Property(e => e.CodJdePadre)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Cod_jdePadre");

                entity.Property(e => e.Codigo).HasMaxLength(10);

                entity.Property(e => e.Cotizacion).HasMaxLength(20);

                entity.Property(e => e.DiasCalle).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.EdoCuentaTrans)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("EDO_CUENTA_TRANS");

                entity.Property(e => e.Fecha).HasColumnType("smalldatetime");

                entity.Property(e => e.Imp)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("IMP");

                entity.Property(e => e.LimiteCreditoBs)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("LIMITE_CREDITO_BS");

                entity.Property(e => e.LimiteCreditoUt)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("LIMITE_CREDITO_UT");

                entity.Property(e => e.PorFacturar)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("POR_FACTURAR");

                entity.Property(e => e.Rimp)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("RIMP");

                entity.Property(e => e.RlimiteCreditoBs)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("RLIMITE_CREDITO_BS");

                entity.Property(e => e.RsaldoLimiteCred)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("RSALDO_LIMITE_CRED");

                entity.Property(e => e.RutBs)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("RUT_BS");

                entity.Property(e => e.SaldoLimiteCred)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("SALDO_LIMITE_CRED");

                entity.Property(e => e.Stock)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("STOCK");

                entity.Property(e => e.Usuario).HasMaxLength(50);

                entity.Property(e => e.UtBs)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("UT_BS");
            });

            modelBuilder.Entity<Impporfacturarcliente>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("IMPPORFACTURARCLIENTE");

                entity.Property(e => e.Cliente).HasColumnName("CLIENTE");

                entity.Property(e => e.PorFacturar)
                    .HasColumnType("numeric(38, 6)")
                    .HasColumnName("POR_FACTURAR");
            });

            modelBuilder.Entity<InventarioEnProceso>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("InventarioEnProceso");

                entity.Property(e => e.Año)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("AÑO");

                entity.Property(e => e.Mes)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("MES");

                entity.Property(e => e.Millares)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("MILLARES");

                entity.Property(e => e.Orden)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ORDEN");
            });

            modelBuilder.Entity<InventarioJobDirecto>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("InventarioJobDirecto");

                entity.Property(e => e.Cantidad).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.FechaProcesado).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.Job).HasDefaultValueSql("((0))");

                entity.Property(e => e.Producto)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<JobDepurar>(entity =>
            {
                entity.HasKey(e => e.Recnum);

                entity.ToTable("JobDepurar");

                entity.HasIndex(e => e.Job, "IX_JobDepurar");

                entity.Property(e => e.Recnum)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Job).HasColumnName("JOB");
            });

            modelBuilder.Entity<JobPasar>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("JobPasar");

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.Orden).HasColumnName("orden");

                entity.Property(e => e.Producto)
                    .HasMaxLength(12)
                    .HasColumnName("producto");
            });

            modelBuilder.Entity<Orden>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Orden");

                entity.HasIndex(e => e.Orden1, "dep_ordenorden");

                entity.Property(e => e.Orden1).HasColumnName("Orden");
            });

            modelBuilder.Entity<Pendienteporclientesimpdetallado>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PENDIENTEPORCLIENTESIMPDETALLADO");

                entity.Property(e => e.Cliente).HasColumnName("CLIENTE");

                entity.Property(e => e.Iva)
                    .HasColumnType("numeric(38, 6)")
                    .HasColumnName("IVA");

                entity.Property(e => e.PorFacturar)
                    .HasColumnType("numeric(38, 6)")
                    .HasColumnName("POR_FACTURAR");

                entity.Property(e => e.Porciva).HasColumnName("PORCIVA");
            });

            modelBuilder.Entity<Pendienteporclientesstockdetallado>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PENDIENTEPORCLIENTESSTOCKDETALLADO");

                entity.Property(e => e.Cliente).HasColumnName("CLIENTE");

                entity.Property(e => e.CodProducto)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("COD_PRODUCTO");

                entity.Property(e => e.Iva)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("IVA");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.PorFacturar)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("POR_FACTURAR");

                entity.Property(e => e.Porciva).HasColumnName("PORCIVA");
            });

            modelBuilder.Entity<Peps085c>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PEPS085C");

                entity.Property(e => e.Col001)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PorcTerminacion>(entity =>
            {
                entity.HasKey(e => new { e.Categoria, e.TipoPapel });

                entity.ToTable("PorcTerminacion");

                entity.Property(e => e.Categoria).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TipoPapel).HasMaxLength(1);

                entity.Property(e => e.DescripcionCategoria).HasMaxLength(50);

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PorcTerminacion1)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("PorcTerminacion");
            });

            modelBuilder.Entity<PostVentaImpreso>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PostVentaImpresos");

                entity.Property(e => e.Cliente)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("CLIENTE")
                    .IsFixedLength();

                entity.Property(e => e.CodCliente)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("COD_CLIENTE")
                    .IsFixedLength();

                entity.Property(e => e.CodOficina)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("COD_OFICINA");

                entity.Property(e => e.CodigoVendedor)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO_VENDEDOR")
                    .IsFixedLength();

                entity.Property(e => e.ContEmail1)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Cont_Email_1")
                    .IsFixedLength();

                entity.Property(e => e.ContEmail2)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Cont_Email_2")
                    .IsFixedLength();

                entity.Property(e => e.ContEmail3)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Cont_Email_3")
                    .IsFixedLength();

                entity.Property(e => e.ContNomb1)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Cont_Nomb_1")
                    .IsFixedLength();

                entity.Property(e => e.ContNomb2)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Cont_Nomb_2")
                    .IsFixedLength();

                entity.Property(e => e.ContNomb3)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Cont_Nomb_3")
                    .IsFixedLength();

                entity.Property(e => e.ContTelf1)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Cont_Telf_1")
                    .IsFixedLength();

                entity.Property(e => e.ContTelf2)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Cont_Telf_2")
                    .IsFixedLength();

                entity.Property(e => e.ContTelf3)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Cont_Telf_3")
                    .IsFixedLength();

                entity.Property(e => e.Entrega)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("ENTREGA");

                entity.Property(e => e.Fax)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NoRegTribut)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("No_Reg_Tribut")
                    .IsFixedLength();

                entity.Property(e => e.NombreVendedor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_VENDEDOR")
                    .IsFixedLength();

                entity.Property(e => e.Oficina)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("OFICINA")
                    .IsFixedLength();

                entity.Property(e => e.Orden)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ORDEN");

                entity.Property(e => e.RecordNumber)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("RECORD_NUMBER");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Telefono1)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PostVentaStock>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PostVentaStock");

                entity.Property(e => e.Cliente)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("CLIENTE")
                    .IsFixedLength();

                entity.Property(e => e.CodCliente)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("COD_CLIENTE")
                    .IsFixedLength();

                entity.Property(e => e.CodOficina)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("COD_OFICINA");

                entity.Property(e => e.CodigoVendedor)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO_VENDEDOR")
                    .IsFixedLength();

                entity.Property(e => e.ContEmail1)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Cont_Email_1")
                    .IsFixedLength();

                entity.Property(e => e.ContEmail2)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Cont_Email_2")
                    .IsFixedLength();

                entity.Property(e => e.ContEmail3)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Cont_Email_3")
                    .IsFixedLength();

                entity.Property(e => e.ContNomb1)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Cont_Nomb_1")
                    .IsFixedLength();

                entity.Property(e => e.ContNomb2)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Cont_Nomb_2")
                    .IsFixedLength();

                entity.Property(e => e.ContNomb3)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Cont_Nomb_3")
                    .IsFixedLength();

                entity.Property(e => e.ContTelf1)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Cont_Telf_1")
                    .IsFixedLength();

                entity.Property(e => e.ContTelf2)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Cont_Telf_2")
                    .IsFixedLength();

                entity.Property(e => e.ContTelf3)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Cont_Telf_3")
                    .IsFixedLength();

                entity.Property(e => e.Entrega)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("ENTREGA");

                entity.Property(e => e.Fax)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NoRegTribut)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("No_Reg_Tribut")
                    .IsFixedLength();

                entity.Property(e => e.NombreVendedor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_VENDEDOR")
                    .IsFixedLength();

                entity.Property(e => e.Oficina)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("OFICINA")
                    .IsFixedLength();

                entity.Property(e => e.Orden)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ORDEN");

                entity.Property(e => e.RecordNumber)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("RECORD_NUMBER");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Telefono1)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Prensa>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("prensa");
            });

            modelBuilder.Entity<ProgramacionDetalleBacklogEstacionEstimado>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ProgramacionDetalleBacklogEstacionEstimado");

                entity.HasIndex(e => new { e.FechaEstimacionJuliana, e.Prensa }, "IX_ProgramacionDetalleBacklogEstacionEstimado");

                entity.HasIndex(e => new { e.FechaEstimacionJuliana, e.IdJob }, "IX_ProgramacionDetalleBacklogEstacionEstimado_1");

                entity.HasIndex(e => new { e.FechaEstimacionJuliana, e.Prensa, e.Turno }, "IX_ProgramacionDetalleBacklogEstacionEstimado_2");

                entity.HasIndex(e => new { e.FechaEstimacionJuliana, e.IdJob }, "IX_ProgramacionDetalleBacklogEstacionEstimado_3");

                entity.Property(e => e.FechaDiaHabil).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.FechaEstimacionJuliana).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.HorasJob).HasColumnType("decimal(38, 19)");

                entity.Property(e => e.HorasJobProgramadas).HasColumnType("decimal(38, 19)");

                entity.Property(e => e.HorasXturno)
                    .HasColumnType("decimal(38, 19)")
                    .HasColumnName("HorasXTurno");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdJob).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Prensa).HasMaxLength(6);
            });

            modelBuilder.Entity<Pruedol>(entity =>
            {
                entity.HasKey(e => e.Recnum)
                    .HasName("PRUEDOL_INDEX00");

                entity.ToTable("PRUEDOL");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Lista).HasColumnName("LISTA");

                entity.Property(e => e.Parametro1)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PARAMETRO1")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Parametro2)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PARAMETRO2")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ValorFin1).HasColumnName("VALOR_FIN1");

                entity.Property(e => e.ValorFin2).HasColumnName("VALOR_FIN2");

                entity.Property(e => e.ValorIni1).HasColumnName("VALOR_INI1");

                entity.Property(e => e.ValorIni2).HasColumnName("VALOR_INI2");
            });

            modelBuilder.Entity<QueryEstadisticas01>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QUERY_ESTADISTICAS_01");

                entity.Property(e => e.Lista)
                    .HasColumnType("numeric(38, 2)")
                    .HasColumnName("LISTA");

                entity.Property(e => e.NomProducto)
                    .HasMaxLength(65)
                    .IsUnicode(false)
                    .HasColumnName("NOM_PRODUCTO")
                    .IsFixedLength();

                entity.Property(e => e.Orden)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("ORDEN");

                entity.Property(e => e.Producto)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("PRODUCTO")
                    .IsFixedLength();

                entity.Property(e => e.Venta)
                    .HasColumnType("numeric(38, 2)")
                    .HasColumnName("VENTA");
            });

            modelBuilder.Entity<QueryOpCeo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Query_Op_Ceos");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO")
                    .IsFixedLength();

                entity.Property(e => e.Concesion).HasColumnName("CONCESION");

                entity.Property(e => e.Cotizacion)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("COTIZACION");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Lista).HasColumnName("LISTA");

                entity.Property(e => e.PorFacturar).HasColumnName("POR_FACTURAR");

                entity.Property(e => e.Producto)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRODUCTO")
                    .IsFixedLength();

                entity.Property(e => e.Venta).HasColumnName("VENTA");
            });

            modelBuilder.Entity<QueryOpImp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Query_Op_Imp");

                entity.Property(e => e.Codigo).HasColumnName("CODIGO");

                entity.Property(e => e.Concesion)
                    .HasColumnType("decimal(38, 17)")
                    .HasColumnName("CONCESION");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(65)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION")
                    .IsFixedLength();

                entity.Property(e => e.Lista)
                    .HasColumnType("decimal(38, 2)")
                    .HasColumnName("LISTA");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.PorFacturar)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("POR_FACTURAR");

                entity.Property(e => e.Producto)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("PRODUCTO")
                    .IsFixedLength();

                entity.Property(e => e.Venta)
                    .HasColumnType("decimal(38, 2)")
                    .HasColumnName("VENTA");
            });

            modelBuilder.Entity<QueryOpStock>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Query_Op_Stock");

                entity.Property(e => e.Codigo).HasColumnName("CODIGO");

                entity.Property(e => e.Concesion)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("CONCESION");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION");

                entity.Property(e => e.Lista)
                    .HasColumnType("decimal(38, 2)")
                    .HasColumnName("LISTA");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.PorFacturar)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("POR_FACTURAR");

                entity.Property(e => e.Producto)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("PRODUCTO");

                entity.Property(e => e.Venta)
                    .HasColumnType("decimal(38, 2)")
                    .HasColumnName("VENTA");
            });

            modelBuilder.Entity<SaldoTransxcliente>(entity =>
            {
                entity.HasKey(e => e.CodCliente);

                entity.ToTable("SALDO_TRANSXCLIENTES");

                entity.HasIndex(e => e.CodCliente, "IX_SALDO_TRANSXCLIENTES")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.An8, "IX_SALDO_TRANSXCLIENTES_1")
                    .HasFillFactor(80);

                entity.Property(e => e.CodCliente)
                    .HasColumnType("numeric(6, 0)")
                    .HasColumnName("COD_CLIENTE");

                entity.Property(e => e.An8).HasColumnName("AN8");

                entity.Property(e => e.DiasCalle).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RsaldoTrans)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RSALDO_TRANS");

                entity.Property(e => e.SaldoTrans)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("SALDO_TRANS");
            });

            modelBuilder.Entity<Stockporfacturarcliente>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("STOCKPORFACTURARCLIENTE");

                entity.Property(e => e.Cliente).HasColumnName("CLIENTE");

                entity.Property(e => e.PorFacturar)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("POR_FACTURAR");
            });

            modelBuilder.Entity<Sysfile>(entity =>
            {
                entity.HasKey(e => e.Recnum)
                    .HasName("SYSFILE_INDEX00");

                entity.ToTable("SYSFILE");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Ano).HasColumnName("ANO");

                entity.Property(e => e.ColectDefault).HasColumnName("COLECT_DEFAULT");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COMPANY_NAME")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ConsArchivo).HasColumnName("CONS_ARCHIVO");

                entity.Property(e => e.Correlativo).HasColumnName("CORRELATIVO");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE");

                entity.Property(e => e.DiasCriteInac).HasColumnName("DIAS_CRITE_INAC");

                entity.Property(e => e.DiasFulfilment).HasColumnName("DIAS_FULFILMENT");

                entity.Property(e => e.JobIdActual).HasColumnName("JOB_ID_ACTUAL");

                entity.Property(e => e.LargoPagina).HasColumnName("LARGO_PAGINA");

                entity.Property(e => e.Mes).HasColumnName("MES");

                entity.Property(e => e.NoAnulacActua).HasColumnName("NO_ANULAC_ACTUA");

                entity.Property(e => e.NoComprobante).HasColumnName("NO_COMPROBANTE");

                entity.Property(e => e.NoDeEntrega).HasColumnName("NO_DE_ENTREGA");

                entity.Property(e => e.NoReopActual).HasColumnName("NO_REOP_ACTUAL");

                entity.Property(e => e.OrdInicial).HasColumnName("ORD_INICIAL");

                entity.Property(e => e.Pais).HasColumnName("PAIS");

                entity.Property(e => e.PorcColectMcp)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("PORC_COLECT_MCP");

                entity.Property(e => e.PorcColectOpa)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("PORC_COLECT_OPA");

                entity.Property(e => e.PorcPrensaMcp)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("PORC_PRENSA_MCP");

                entity.Property(e => e.PorcPrensaOpa)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("PORC_PRENSA_OPA");

                entity.Property(e => e.PrensaDefault).HasColumnName("PRENSA_DEFAULT");

                entity.Property(e => e.Proceso)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PROCESO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SaltoPagina).HasColumnName("SALTO_PAGINA");

                entity.Property(e => e.UltOrden).HasColumnName("ULT_ORDEN");

                entity.Property(e => e.UltimoCep)
                    .HasColumnType("decimal(14, 0)")
                    .HasColumnName("ULTIMO_CEP");
            });

            modelBuilder.Entity<TctOficina>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TCT_Oficinas");

                entity.Property(e => e.CodOficina)
                    .HasColumnType("numeric(2, 0)")
                    .HasColumnName("COD_OFICINA");

                entity.Property(e => e.NomOficina)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("NOM_OFICINA")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Tctimpreso>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TCTIMPRESOS");

                entity.HasIndex(e => e.Orden, "dep_TCTIMPRESOSorden");

                entity.Property(e => e.Acabado)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("ACABADO");

                entity.Property(e => e.Ano).HasColumnName("ANO");

                entity.Property(e => e.Archivo)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("ARCHIVO");

                entity.Property(e => e.Cliente)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("CLIENTE")
                    .IsFixedLength();

                entity.Property(e => e.CodCliente)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("COD_CLIENTE")
                    .IsFixedLength();

                entity.Property(e => e.CodOficina)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("COD_OFICINA");

                entity.Property(e => e.CodRegion)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("COD_REGION")
                    .IsFixedLength();

                entity.Property(e => e.CodResponsable)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("COD_RESPONSABLE");

                entity.Property(e => e.CodZona).HasColumnName("COD_ZONA");

                entity.Property(e => e.CodigoVendedor)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO_VENDEDOR")
                    .IsFixedLength();

                entity.Property(e => e.Colectora)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("COLECTORA");

                entity.Property(e => e.ContAcab).HasColumnName("CONT_ACAB");

                entity.Property(e => e.ContAtraso).HasColumnName("CONT_ATRASO");

                entity.Property(e => e.ContCole).HasColumnName("CONT_COLE");

                entity.Property(e => e.ContPrel).HasColumnName("CONT_PREL");

                entity.Property(e => e.ContPren).HasColumnName("CONT_PREN");

                entity.Property(e => e.DescripcionLinea)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION_LINEA")
                    .IsFixedLength();

                entity.Property(e => e.DiasAcabado)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DIAS_ACABADO");

                entity.Property(e => e.DiasAtraso)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DIAS_ATRASO");

                entity.Property(e => e.DiasColectora)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DIAS_COLECTORA");

                entity.Property(e => e.DiasCxc).HasColumnName("DIAS_CXC");

                entity.Property(e => e.DiasDespacho)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DIAS_DESPACHO");

                entity.Property(e => e.DiasFactura)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DIAS_FACTURA");

                entity.Property(e => e.DiasLogistica)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DIAS_LOGISTICA");

                entity.Property(e => e.DiasManufactura)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DIAS_MANUFACTURA");

                entity.Property(e => e.DiasMoore)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DIAS_MOORE");

                entity.Property(e => e.DiasParaEmbarcar)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DIAS_PARA_EMBARCAR");

                entity.Property(e => e.DiasPlan)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DIAS_PLAN");

                entity.Property(e => e.DiasPrel)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DIAS_PREL");

                entity.Property(e => e.DiasPrensas)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DIAS_PRENSAS");

                entity.Property(e => e.DiasProd)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DIAS_PROD");

                entity.Property(e => e.DiasRetAca)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DIAS_RET_ACA");

                entity.Property(e => e.DiasRetColec)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DIAS_RET_COLEC");

                entity.Property(e => e.DiasRetEmb)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DIAS_RET_EMB");

                entity.Property(e => e.DiasRetPlan)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DIAS_RET_PLAN");

                entity.Property(e => e.DiasRetPrel)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DIAS_RET_PREL");

                entity.Property(e => e.DiasRetPren)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DIAS_RET_PREN");

                entity.Property(e => e.DiasRetProg)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DIAS_RET_PROG");

                entity.Property(e => e.DiasVentas)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DIAS_VENTAS");

                entity.Property(e => e.Entrega)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("ENTREGA");

                entity.Property(e => e.Estado)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ESTADO")
                    .IsFixedLength();

                entity.Property(e => e.Factura)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FACTURA");

                entity.Property(e => e.Familia)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("FAMILIA")
                    .IsFixedLength();

                entity.Property(e => e.FechaEntradaCxc)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FECHA_ENTRADA_CXC");

                entity.Property(e => e.FechaRecibida)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_RECIBIDA");

                entity.Property(e => e.FechaSalidaCxc)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FECHA_SALIDA_CXC");

                entity.Property(e => e.Job)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("JOB");

                entity.Property(e => e.Linea)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("LINEA")
                    .IsFixedLength();

                entity.Property(e => e.LineaFamilia)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LINEA_FAMILIA")
                    .IsFixedLength();

                entity.Property(e => e.Mes).HasColumnName("MES");

                entity.Property(e => e.Municipio)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MUNICIPIO")
                    .IsFixedLength();

                entity.Property(e => e.NombreVendedor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_VENDEDOR")
                    .IsFixedLength();

                entity.Property(e => e.Oficina)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("OFICINA")
                    .IsFixedLength();

                entity.Property(e => e.Orden)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ORDEN");

                entity.Property(e => e.Planeacion)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("PLANEACION");

                entity.Property(e => e.Preliminares)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("PRELIMINARES");

                entity.Property(e => e.Prensas)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("PRENSAS");

                entity.Property(e => e.Programacion)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("PROGRAMACION");

                entity.Property(e => e.Prometida)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("PROMETIDA");

                entity.Property(e => e.RecordNumber)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("RECORD_NUMBER");

                entity.Property(e => e.Region)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("REGION")
                    .IsFixedLength();

                entity.Property(e => e.SalidaCamion)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("SALIDA_CAMION");

                entity.Property(e => e.StatusOrden)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("STATUS_ORDEN")
                    .IsFixedLength();

                entity.Property(e => e.Tomada)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("TOMADA");

                entity.Property(e => e.Web)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("WEB")
                    .IsFixedLength();

                entity.Property(e => e.ZonaDespacho)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ZONA_DESPACHO")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Tctstock>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TCTSTOCK");

                entity.HasIndex(e => e.Orden, "dep_TCTSTOCKorden");

                entity.Property(e => e.Ano).HasColumnName("ANO");

                entity.Property(e => e.AprobCobranza)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("APROB_COBRANZA");

                entity.Property(e => e.AprobPlanta)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("APROB_PLANTA");

                entity.Property(e => e.Cliente)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("CLIENTE")
                    .IsFixedLength();

                entity.Property(e => e.CodCliente)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("COD_CLIENTE")
                    .IsFixedLength();

                entity.Property(e => e.CodOficina)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("COD_OFICINA");

                entity.Property(e => e.CodRegion)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("COD_REGION")
                    .IsFixedLength();

                entity.Property(e => e.CodResponsable)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("COD_RESPONSABLE");

                entity.Property(e => e.CodZona).HasColumnName("COD_ZONA");

                entity.Property(e => e.CodigoVendedor)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO_VENDEDOR")
                    .IsFixedLength();

                entity.Property(e => e.ContAtraso).HasColumnName("CONT_ATRASO");

                entity.Property(e => e.DiasAdministradora)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DIAS_ADMINISTRADORA");

                entity.Property(e => e.DiasAtraso)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DIAS_ATRASO");

                entity.Property(e => e.DiasCobranza)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DIAS_COBRANZA");

                entity.Property(e => e.DiasCxc).HasColumnName("DIAS_CXC");

                entity.Property(e => e.DiasDespacho)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DIAS_DESPACHO");

                entity.Property(e => e.DiasFactura)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DIAS_FACTURA");

                entity.Property(e => e.DiasMoore)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DIAS_MOORE");

                entity.Property(e => e.DiasParaEmbarcar)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DIAS_PARA_EMBARCAR");

                entity.Property(e => e.DiasPlanta)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DIAS_PLANTA");

                entity.Property(e => e.DiasProd)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DIAS_PROD");

                entity.Property(e => e.DiasVentas)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DIAS_VENTAS");

                entity.Property(e => e.Entrega)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("ENTREGA");

                entity.Property(e => e.Estado)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ESTADO")
                    .IsFixedLength();

                entity.Property(e => e.Factura)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FACTURA");

                entity.Property(e => e.FechaAprobAdm)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FECHA_APROB_ADM");

                entity.Property(e => e.FechaEntradaCxc)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FECHA_ENTRADA_CXC");

                entity.Property(e => e.FechaSalidaCxc)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FECHA_SALIDA_CXC");

                entity.Property(e => e.Grabada)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("GRABADA");

                entity.Property(e => e.Mes).HasColumnName("MES");

                entity.Property(e => e.Municipio)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MUNICIPIO")
                    .IsFixedLength();

                entity.Property(e => e.NombreVendedor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_VENDEDOR")
                    .IsFixedLength();

                entity.Property(e => e.Oficina)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("OFICINA")
                    .IsFixedLength();

                entity.Property(e => e.Orden)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ORDEN");

                entity.Property(e => e.Producto)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PRODUCTO")
                    .IsFixedLength();

                entity.Property(e => e.Prometida)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("PROMETIDA");

                entity.Property(e => e.RecordNumber)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("RECORD_NUMBER");

                entity.Property(e => e.Region)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("REGION")
                    .IsFixedLength();

                entity.Property(e => e.SalidaCamion)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("SALIDA_CAMION");

                entity.Property(e => e.StatusOrden)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("STATUS_ORDEN")
                    .IsFixedLength();

                entity.Property(e => e.TipoProducto)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_PRODUCTO")
                    .IsFixedLength();

                entity.Property(e => e.Tomada)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("TOMADA");

                entity.Property(e => e.Web)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("WEB")
                    .IsFixedLength();

                entity.Property(e => e.ZonaDespacho)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ZONA_DESPACHO")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TintasComune>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CantTintas).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Combinacion).HasMaxLength(50);

                entity.Property(e => e.Comun).HasMaxLength(50);

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Primera).HasMaxLength(10);

                entity.Property(e => e.Segunda).HasMaxLength(10);

                entity.Property(e => e.Tercera).HasMaxLength(10);
            });

            modelBuilder.Entity<TurnosPorPrensaEstimacion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TurnosPorPrensaEstimacion");

                entity.Property(e => e.FechaDiaHabil).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.FechaEstimacionJuliana).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.HorasXturno)
                    .HasColumnType("decimal(38, 19)")
                    .HasColumnName("HorasXTurno");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Prensa).HasMaxLength(6);
            });

            modelBuilder.Entity<UnidadTributariaB>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Unidad_Tributaria_Bs");

                entity.Property(e => e.Fecha)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FECHA");

                entity.Property(e => e.FechaUpdate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FECHA_UPDATE");

                entity.Property(e => e.UtBs)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("UT_BS");
            });

            modelBuilder.Entity<VBacklogCliente>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_BacklogCliente");

                entity.Property(e => e.Categoria)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cliente).HasColumnName("CLIENTE");

                entity.Property(e => e.FechaEntrega)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_entrega");

                entity.Property(e => e.JobId).HasColumnName("JOB_ID");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.PorFacturar)
                    .HasColumnType("numeric(38, 6)")
                    .HasColumnName("POR_FACTURAR");

                entity.Property(e => e.Producto)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("PRODUCTO")
                    .IsFixedLength();

                entity.Property(e => e.SubCategoria)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VBacklogGeneral>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_backlogGeneral");

                entity.Property(e => e.Estacion)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaEntrega)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_entrega");

                entity.Property(e => e.JobId).HasColumnName("JOB_ID");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");
            });

            modelBuilder.Entity<VBacklogPapel>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_BacklogPapel");

                entity.Property(e => e.BsVenta).HasColumnType("numeric(33, 6)");

                entity.Property(e => e.Cliente)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Estacion).HasMaxLength(30);

                entity.Property(e => e.EstatusOrden)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FechaEntrega).HasColumnType("datetime");

                entity.Property(e => e.Genero)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdEstacion)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdEstatusOrden)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdPapel)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.JobRetenido)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.KilosPapel).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.Linea)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Millares).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Producto)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TipoPapel)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VCantidadOrdene>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_CantidadOrdenes");

                entity.Property(e => e.CodigoVendedor)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FechaArchivo)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ARCHIVO");

                entity.Property(e => e.NombreCliente)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.NombreOficina)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.NombreVendedor)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Oficina)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("OFICINA");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");
            });

            modelBuilder.Entity<VCaracteristica>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_CARACTERISTICAS");

                entity.Property(e => e.PApel)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("pAPEL");

                entity.Property(e => e.PartesFormula).HasColumnName("PARTES_FORMULA");

                entity.Property(e => e.TIpopaPel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("tIPOpaPEL");
            });

            modelBuilder.Entity<VDiccionarioplantum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_DICCIONARIOPLANTA");

                entity.Property(e => e.Basededatos)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("basededatos");

                entity.Property(e => e.Field).HasMaxLength(128);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Length).HasColumnName("length");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("name");

                entity.Property(e => e.Smallid).HasColumnName("smallid");

                entity.Property(e => e.TipoTabla)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tipo_tabla")
                    .IsFixedLength();

                entity.Property(e => e.Type).HasMaxLength(128);

                entity.Property(e => e.Value)
                    .HasColumnType("sql_variant")
                    .HasColumnName("value");

                entity.Property(e => e.Xprec).HasColumnName("xprec");

                entity.Property(e => e.Xscale).HasColumnName("xscale");

                entity.Property(e => e.Xtype).HasColumnName("xtype");
            });

            modelBuilder.Entity<VEstadisticasPlaneacion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_EstadisticasPlaneacion");

                entity.Property(e => e.Año).HasColumnName("año");

                entity.Property(e => e.Estacion)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Mes).HasColumnName("MES");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VFacturacionPendienteDePasaraJde>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_facturacionPendienteDePasaraJde");

                entity.Property(e => e.Cliente).HasColumnName("CLIENTE");

                entity.Property(e => e.PorFacturar)
                    .HasColumnType("decimal(38, 2)")
                    .HasColumnName("POR_FACTURAR");

                entity.Property(e => e.TotalParcial)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TOTAL_PARCIAL");
            });

            modelBuilder.Entity<VFechaEntrega>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_FechaEntrega");

                entity.Property(e => e.FechaEntrega)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_entrega");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");
            });

            modelBuilder.Entity<VFiscalsinnumeracion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_FISCALSINNUMERACION");

                entity.Property(e => e.Anulada)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ANULADA")
                    .IsFixedLength();

                entity.Property(e => e.CantOrdenada).HasColumnName("CANT_ORDENADA");

                entity.Property(e => e.CodProducto)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("COd_producto")
                    .IsFixedLength();

                entity.Property(e => e.Cotizacion)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("COTIZACION")
                    .IsFixedLength();

                entity.Property(e => e.DescProducto)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESC_PRODUCTO")
                    .IsFixedLength();

                entity.Property(e => e.FechaArchivo)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ARCHIVO");

                entity.Property(e => e.Fiscal)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FISCAL")
                    .IsFixedLength();

                entity.Property(e => e.NombreProducto)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_PRODUCTO")
                    .IsFixedLength();

                entity.Property(e => e.NumCliDesde)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NUM_CLI_DESDE");

                entity.Property(e => e.NumCliHasta)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NUM_CLI_HASTA");

                entity.Property(e => e.NumeroPrefijo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NUMERO_PREFIJO")
                    .IsFixedLength();

                entity.Property(e => e.NumeroSubfijo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NUMERO_SUBFIJO")
                    .IsFixedLength();

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.Prefijo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PREFIJO")
                    .IsFixedLength();

                entity.Property(e => e.PrefijoCli)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PREFIJO_CLI");

                entity.Property(e => e.RifImprimir)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("RIF_IMPRIMIR")
                    .IsFixedLength();

                entity.Property(e => e.Sufijo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SUFIJO")
                    .IsFixedLength();

                entity.Property(e => e.SufijoCli)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SUFIJO_CLI");

                entity.Property(e => e.Web)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("WEB")
                    .IsFixedLength();
            });

            modelBuilder.Entity<VInvetarioReconversion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_InvetarioReconversion");

                entity.Property(e => e.Basededatos)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("basededatos");

                entity.Property(e => e.Field).HasMaxLength(128);

                entity.Property(e => e.Length).HasColumnName("length");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("name");

                entity.Property(e => e.Type).HasMaxLength(128);

                entity.Property(e => e.Xprec).HasColumnName("xprec");

                entity.Property(e => e.Xscale).HasColumnName("xscale");
            });

            modelBuilder.Entity<VOrdene>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ordenes");

                entity.Property(e => e.CantFactura).HasColumnName("CANT_FACTURA");

                entity.Property(e => e.CantOrdenada).HasColumnName("CANT_ORDENADA");

                entity.Property(e => e.FechaEntrega)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ENTREGA");

                entity.Property(e => e.FechaFactura)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_FACTURA");

                entity.Property(e => e.FechaOrden)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ORDEN");

                entity.Property(e => e.FechaerEmbarqu)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAER_EMBARQU");

                entity.Property(e => e.FechasrEmbarqu)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHASR_EMBARQU");

                entity.Property(e => e.Historicobacklog)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("historicobacklog");

                entity.Property(e => e.JobId).HasColumnName("JOB_ID");

                entity.Property(e => e.NumeroFactura).HasColumnName("NUMERO_FACTURA");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.PrecioLista)
                    .HasColumnType("decimal(16, 4)")
                    .HasColumnName("PRECIO_LISTA");

                entity.Property(e => e.PrecioVenta)
                    .HasColumnType("decimal(16, 4)")
                    .HasColumnName("PRECIO_VENTA");

                entity.Property(e => e.TotalLista)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("TOTAL_LISTA");

                entity.Property(e => e.TotalVenta)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("TOTAL_VENTA");

                entity.Property(e => e.UsuarioCancelo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_CANCELO");
            });

            modelBuilder.Entity<VOrdenesMala>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_OrdenesMalas");

                entity.Property(e => e.Cantidad012).HasColumnName("Cantidad_012");

                entity.Property(e => e.Cantidad020).HasColumnName("Cantidad_020");
            });

            modelBuilder.Entity<VReorden>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_REORDEN");

                entity.Property(e => e.AnoOrden).HasColumnName("ANO_ORDEN");

                entity.Property(e => e.AnoReorden).HasColumnName("ANO_REORDEN");

                entity.Property(e => e.Cliente).HasColumnName("CLIENTE");

                entity.Property(e => e.EmailCliente)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL_CLIENTE");

                entity.Property(e => e.EmailVendedor)
                    .IsRequired()
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL_VENDEDOR");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA");

                entity.Property(e => e.MesOrden).HasColumnName("MES_ORDEN");

                entity.Property(e => e.MesReorden).HasColumnName("MES_REORDEN");

                entity.Property(e => e.NombreCliente)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_CLIENTE")
                    .IsFixedLength();

                entity.Property(e => e.NombreForma)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_FORMA")
                    .IsFixedLength();

                entity.Property(e => e.OficinaId)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.OrdenAnterior).HasColumnName("ORDEN_ANTERIOR");

                entity.Property(e => e.OrdenCliente)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("ORDEN_CLIENTE")
                    .IsFixedLength();

                entity.Property(e => e.SupervisorId)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Vendedor)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("VENDEDOR");

                entity.Property(e => e.VendedorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VTintasordene>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_TINTASORDENES");

                entity.Property(e => e.FlagNoContar)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.Tinta)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("TINTA");
            });

            modelBuilder.Entity<VistaCapacidadColectora>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vista_Capacidad_Colectoras");

                entity.Property(e => e.Anchos).HasColumnName("ANCHOS");

                entity.Property(e => e.DiasColeColect)
                    .HasColumnType("numeric(6, 2)")
                    .HasColumnName("DIAS_COLE_COLECT");

                entity.Property(e => e.DiasColePlan)
                    .HasColumnType("numeric(6, 2)")
                    .HasColumnName("DIAS_COLE_PLAN");

                entity.Property(e => e.DiasColePrel)
                    .HasColumnType("numeric(6, 2)")
                    .HasColumnName("DIAS_COLE_PREL");

                entity.Property(e => e.DiasColePrensa)
                    .HasColumnType("numeric(6, 2)")
                    .HasColumnName("DIAS_COLE_PRENSA");

                entity.Property(e => e.DiasColeProg)
                    .HasColumnType("numeric(6, 2)")
                    .HasColumnName("DIAS_COLE_PROG");

                entity.Property(e => e.DiasHistoricos).HasColumnName("DIAS_HISTORICOS");

                entity.Property(e => e.Familia)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("FAMILIA")
                    .IsFixedLength();

                entity.Property(e => e.FechaEntrega)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ENTREGA");

                entity.Property(e => e.FlagRetenido)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_RETENIDO")
                    .IsFixedLength();

                entity.Property(e => e.HorasTrabajo)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("HORAS_TRABAJO");

                entity.Property(e => e.Job).HasColumnName("JOB");

                entity.Property(e => e.Linea)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("LINEA")
                    .IsFixedLength();

                entity.Property(e => e.NombreColectora)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.PiesArteCole)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("PIES_ARTE_COLE");

                entity.Property(e => e.PiesColect)
                    .HasColumnType("decimal(16, 4)")
                    .HasColumnName("PIES_COLECT");

                entity.Property(e => e.PiesFotoCole)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("PIES_FOTO_COLE");

                entity.Property(e => e.PiesPlanCole)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("PIES_PLAN_COLE");

                entity.Property(e => e.PiesPrensCole)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("PIES_PRENS_COLE");

                entity.Property(e => e.PiesXHora)
                    .HasColumnType("decimal(38, 17)")
                    .HasColumnName("PIES_X_HORA");

                entity.Property(e => e.StatusOrden)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("STATUS_ORDEN")
                    .IsFixedLength();

                entity.Property(e => e.TipoOrden)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_ORDEN")
                    .IsFixedLength();
            });

            modelBuilder.Entity<VistaCapacidadPrensa>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vista_Capacidad_Prensas");

                entity.Property(e => e.Anchos).HasColumnName("ANCHOS");

                entity.Property(e => e.DiasHistoricos).HasColumnName("DIAS_HISTORICOS");

                entity.Property(e => e.DiasPrenPlan)
                    .HasColumnType("numeric(6, 2)")
                    .HasColumnName("DIAS_PREN_PLAN");

                entity.Property(e => e.DiasPrenPrel)
                    .HasColumnType("numeric(6, 2)")
                    .HasColumnName("DIAS_PREN_PREL");

                entity.Property(e => e.DiasPrenPrensa)
                    .HasColumnType("numeric(6, 2)")
                    .HasColumnName("DIAS_PREN_PRENSA");

                entity.Property(e => e.DiasPrenProg)
                    .HasColumnType("numeric(6, 2)")
                    .HasColumnName("DIAS_PREN_PROG");

                entity.Property(e => e.DiasTotVenta)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("DIAS_TOT_VENTA");

                entity.Property(e => e.Doblado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DOBLADO");

                entity.Property(e => e.Familia)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("FAMILIA")
                    .IsFixedLength();

                entity.Property(e => e.FechaEntrega)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ENTREGA");

                entity.Property(e => e.FlagRetenido)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_RETENIDO")
                    .IsFixedLength();

                entity.Property(e => e.HorasTrabajo)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("HORAS_TRABAJO");

                entity.Property(e => e.Job).HasColumnName("JOB");

                entity.Property(e => e.Linea)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("LINEA")
                    .IsFixedLength();

                entity.Property(e => e.NombrePrensa)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.PiesArtePren)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("PIES_ARTE_PREN");

                entity.Property(e => e.PiesFotoPren)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("PIES_FOTO_PREN");

                entity.Property(e => e.PiesPlanPren)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("PIES_PLAN_PREN");

                entity.Property(e => e.PiesPrensPren)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("PIES_PRENS_PREN");

                entity.Property(e => e.PiesXHora)
                    .HasColumnType("decimal(38, 17)")
                    .HasColumnName("PIES_X_HORA");

                entity.Property(e => e.StatusOrden)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("STATUS_ORDEN")
                    .IsFixedLength();

                entity.Property(e => e.TipoOrden)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_ORDEN")
                    .IsFixedLength();

                entity.Property(e => e.Venta)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("VENTA");

                entity.Property(e => e.VentaXHora)
                    .HasColumnType("decimal(38, 17)")
                    .HasColumnName("VENTA_X_HORA");
            });

            modelBuilder.Entity<VistaNproductosOrden>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VistaNProductosOrden");

                entity.Property(e => e.Nproductos).HasColumnName("NProductos");

                entity.Property(e => e.Orden).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<VistaResumenCp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VistaResumenCP");

                entity.Property(e => e.Anchos).HasColumnName("ANCHOS");

                entity.Property(e => e.Doblado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DOBLADO");

                entity.Property(e => e.Familia)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("FAMILIA")
                    .IsFixedLength();

                entity.Property(e => e.FechaEntrega)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ENTREGA");

                entity.Property(e => e.FlagRetenido)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_RETENIDO")
                    .IsFixedLength();

                entity.Property(e => e.HorasTrabajo)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("HORAS_TRABAJO");

                entity.Property(e => e.Job).HasColumnName("JOB");

                entity.Property(e => e.Linea)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("LINEA")
                    .IsFixedLength();

                entity.Property(e => e.NoColectora).HasColumnName("NO_COLECTORA");

                entity.Property(e => e.NoPrensa).HasColumnName("NO_PRENSA");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.PiesArteCole)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("PIES_ARTE_COLE");

                entity.Property(e => e.PiesArtePren)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("PIES_ARTE_PREN");

                entity.Property(e => e.PiesColect)
                    .HasColumnType("decimal(16, 4)")
                    .HasColumnName("PIES_COLECT");

                entity.Property(e => e.PiesFotoCole)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("PIES_FOTO_COLE");

                entity.Property(e => e.PiesFotoPren)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("PIES_FOTO_PREN");

                entity.Property(e => e.PiesPlanCole)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("PIES_PLAN_COLE");

                entity.Property(e => e.PiesPlanPren)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("PIES_PLAN_PREN");

                entity.Property(e => e.PiesPrensCole)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("PIES_PRENS_COLE");

                entity.Property(e => e.PiesPrensPren)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("PIES_PRENS_PREN");

                entity.Property(e => e.StatusOrden)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("STATUS_ORDEN")
                    .IsFixedLength();

                entity.Property(e => e.TipoOrden)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_ORDEN")
                    .IsFixedLength();

                entity.Property(e => e.Venta)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("VENTA");
            });

            modelBuilder.Entity<Wpry015>(entity =>
            {
                entity.HasKey(e => e.NombreUsuario)
                    .HasName("WPRY015_INDEX01");

                entity.ToTable("WPRY015");

                entity.HasIndex(e => e.Recnum, "WPRY015_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => e.UsuarioNovell, "WPRY015_INDEX02")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => e.Usuario2000, "WPRY015_INDEX03")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.NombreUsuario)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_USUARIO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Usuario2000)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_2000")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.UsuarioNovell)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_NOVELL")
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Wpry032>(entity =>
            {
                entity.HasKey(e => e.Recnum)
                    .HasName("WPRY032_INDEX00");

                entity.ToTable("WPRY032");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.AnoCerrado).HasColumnName("ANO_CERRADO");

                entity.Property(e => e.Clientes)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CLIENTES")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.InternasCcs)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("INTERNAS_CCS")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.InternasImp)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("INTERNAS_IMP")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.InternasStock)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("INTERNAS_STOCK")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.MesCerrado).HasColumnName("MES_CERRADO");

                entity.Property(e => e.MesesBacklogP)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("MESES_BACKLOG_P");

                entity.Property(e => e.PapelPlan)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PAPEL_PLAN")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PapelPrel)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PAPEL_PREL")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PapelPren)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PAPEL_PREN")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PapelProg)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PAPEL_PROG")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.UltAnulacion).HasColumnName("ULT_ANULACION");

                entity.Property(e => e.UltMotivo).HasColumnName("ULT_MOTIVO");

                entity.Property(e => e.UltProgr).HasColumnName("ULT_PROGR");
            });

            modelBuilder.Entity<Wpry038>(entity =>
            {
                entity.HasKey(e => e.Recnum)
                    .HasName("WPRY038_INDEX00");

                entity.ToTable("WPRY038");

                entity.HasIndex(e => e.Orden, "dep_WPRY038orden");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Cliente)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("CLIENTE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CodProducto)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("COD_PRODUCTO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CtdCopys).HasColumnName("CTD_COPYS");

                entity.Property(e => e.DescripcionPro)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION_PRO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DiasArchivo).HasColumnName("DIAS_ARCHIVO");

                entity.Property(e => e.DiasCalculo).HasColumnName("DIAS_CALCULO");

                entity.Property(e => e.DiasDocket).HasColumnName("DIAS_DOCKET");

                entity.Property(e => e.DiasHabiles).HasColumnName("DIAS_HABILES");

                entity.Property(e => e.DiasPlan).HasColumnName("DIAS_PLAN");

                entity.Property(e => e.DiasTotal).HasColumnName("DIAS_TOTAL");

                entity.Property(e => e.DiasTrans).HasColumnName("DIAS_TRANS");

                entity.Property(e => e.FechaArchivo)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("FECHA_ARCHIVO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FechaCalculo)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("FECHA_CALCULO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FechaDesde)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_DESDE");

                entity.Property(e => e.FechaDocket)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("FECHA_DOCKET")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FechaHasta)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_HASTA");

                entity.Property(e => e.FechaPlan)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("FECHA_PLAN")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FechaPrelimin)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("FECHA_PRELIMIN")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FechaTrans)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("FECHA_TRANS")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.StatusOrden)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("STATUS_ORDEN")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TipoOrden)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_ORDEN")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.UsuarioCalculo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_CALCULO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.UsuarioDocket)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_DOCKET")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.UsuarioPlan)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_PLAN")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.UsuarioTrans)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_TRANS")
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Wpry039>(entity =>
            {
                entity.HasKey(e => e.TipoOrden)
                    .HasName("WPRY039_INDEX01");

                entity.ToTable("WPRY039");

                entity.HasIndex(e => e.Recnum, "WPRY039_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.TipoOrden)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_ORDEN")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.Dias).HasColumnName("DIAS");

                entity.Property(e => e.DiasHabiles).HasColumnName("DIAS_HABILES");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");
            });

            modelBuilder.Entity<Wpry040>(entity =>
            {
                entity.HasKey(e => e.CodProducto)
                    .HasName("WPRY040_INDEX01");

                entity.ToTable("WPRY040");

                entity.HasIndex(e => e.Recnum, "WPRY040_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.CodProducto)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("COD_PRODUCTO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(65)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DiasHabiles).HasColumnName("DIAS_HABILES");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");
            });

            modelBuilder.Entity<Wpry041>(entity =>
            {
                entity.HasKey(e => new { e.Estacion, e.Operador })
                    .HasName("WPRY041_INDEX01");

                entity.ToTable("WPRY041");

                entity.HasIndex(e => e.Recnum, "WPRY041_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.Estacion)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ESTACION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Operador)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OPERADOR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Cantidad)
                    .HasColumnType("numeric(5, 0)")
                    .HasColumnName("CANTIDAD");

                entity.Property(e => e.CtdDias)
                    .HasColumnType("numeric(5, 0)")
                    .HasColumnName("CTD_DIAS");

                entity.Property(e => e.CtdProcTotal)
                    .HasColumnType("numeric(5, 0)")
                    .HasColumnName("CTD_PROC_TOTAL");

                entity.Property(e => e.DiasHabiles)
                    .HasColumnType("numeric(5, 0)")
                    .HasColumnName("DIAS_HABILES");

                entity.Property(e => e.DiasProcTotal)
                    .HasColumnType("numeric(5, 0)")
                    .HasColumnName("DIAS_PROC_TOTAL");

                entity.Property(e => e.Posicion)
                    .HasColumnType("numeric(5, 0)")
                    .HasColumnName("POSICION");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");
            });

            modelBuilder.Entity<Wpry045>(entity =>
            {
                entity.HasKey(e => new { e.CodigoPapel, e.Medida })
                    .HasName("WPRY045_INDEX01");

                entity.ToTable("WPRY045");

                entity.HasIndex(e => e.Recnum, "WPRY045_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.CodigoPapel)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO_PAPEL")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Medida)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("MEDIDA");

                entity.Property(e => e.Ccs)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CCS")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Clientes)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CLIENTES")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DiasEntrega).HasColumnName("DIAS_ENTREGA");

                entity.Property(e => e.Dif1).HasColumnName("DIF_1");

                entity.Property(e => e.Dif2).HasColumnName("DIF_2");

                entity.Property(e => e.ExistDisp).HasColumnName("EXIST_DISP");

                entity.Property(e => e.IntImp)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("INT_IMP")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.KilosBacklog).HasColumnName("KILOS_BACKLOG");

                entity.Property(e => e.KilosTransito).HasColumnName("KILOS_TRANSITO");

                entity.Property(e => e.MesesDespacho).HasColumnName("MESES_DESPACHO");

                entity.Property(e => e.Plan)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PLAN")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Prel)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PREL")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Pren)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PREN")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Prog)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PROG")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ProyeccionExis).HasColumnName("PROYECCION_EXIS");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.StockCpo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STOCK_CPO")
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Wpry053>(entity =>
            {
                entity.HasKey(e => new { e.Usuario, e.Recnum })
                    .HasName("WPRY053_INDEX01");

                entity.ToTable("WPRY053");

                entity.HasIndex(e => e.Recnum, "WPRY053_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => e.Orden, "dep_WPRY053orden");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.AcumulaColecto)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ACUMULA_COLECTO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.AcumulaPrensas)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ACUMULA_PRENSAS")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Cliente)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("CLIENTE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Colectora)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("COLECTORA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CtdPendiente)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("CTD_PENDIENTE");

                entity.Property(e => e.CtdProgramada)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("CTD_PROGRAMADA");

                entity.Property(e => e.Depto)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("DEPTO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Diareal).HasColumnName("DIAREAL");

                entity.Property(e => e.DiasAtrasoEst).HasColumnName("DIAS_ATRASO_EST");

                entity.Property(e => e.DiasAtrasoGen).HasColumnName("DIAS_ATRASO_GEN");

                entity.Property(e => e.DiasEstacion)
                    .HasColumnName("DIAS_ESTACION")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Estacion)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ESTACION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FechaDesde)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_DESDE");

                entity.Property(e => e.FechaEst)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_EST");

                entity.Property(e => e.FechaHasta)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_HASTA");

                entity.Property(e => e.FechaOrden)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ORDEN");

                entity.Property(e => e.FechaOrdenPro)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ORDEN_PRO");

                entity.Property(e => e.FechaProgEsta)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_PROG_ESTA");

                entity.Property(e => e.Fechareal)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAREAL");

                entity.Property(e => e.Job).HasColumnName("JOB");

                entity.Property(e => e.Linea)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("LINEA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Lista)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("LISTA");

                entity.Property(e => e.MaqSort).HasColumnName("MAQ_SORT");

                entity.Property(e => e.MillPdte)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("MILL_PDTE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.MillProg)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("MILL_PROG")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Orden)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("ORDEN");

                entity.Property(e => e.Partes).HasColumnName("PARTES");

                entity.Property(e => e.PorcMc)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("PORC_MC")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Prensa)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("PRENSA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Programada)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PROGRAMADA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Reoperacion)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REOPERACION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.RestarBacklog).HasColumnName("RESTAR_BACKLOG");

                entity.Property(e => e.Rollitos).HasColumnName("ROLLITOS");

                entity.Property(e => e.RvalorMc)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RVALOR_MC")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("STATUS")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TotalDiasProg)
                    .HasColumnName("TOTAL_DIAS_PROG")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorMc)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("VALOR_MC")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Venta).HasColumnName("VENTA");
            });

            modelBuilder.Entity<Wpry055>(entity =>
            {
                entity.HasKey(e => new { e.Usuario, e.Recnum })
                    .HasName("WPRY055_INDEX01");

                entity.ToTable("WPRY055");

                entity.HasIndex(e => e.Recnum, "WPRY055_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.Estacion, e.Orden, e.Recnum }, "WPRY055_INDEX02")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.Usuario)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.CantidadOrden).HasColumnName("CANTIDAD_ORDEN");

                entity.Property(e => e.Cliente)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("CLIENTE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Colectora)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("COLECTORA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CondPago)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COND_PAGO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ContarOrden).HasColumnName("CONTAR_ORDEN");

                entity.Property(e => e.CtdPendiente)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("CTD_PENDIENTE");

                entity.Property(e => e.CtdProgramada)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("CTD_PROGRAMADA");

                entity.Property(e => e.Depto)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DEPTO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DiasAtrasoEst).HasColumnName("DIAS_ATRASO_EST");

                entity.Property(e => e.DiasAtrasoGen).HasColumnName("DIAS_ATRASO_GEN");

                entity.Property(e => e.DolTotOrden)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("DOL_TOT_ORDEN");

                entity.Property(e => e.DolUnit)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("DOL_UNIT");

                entity.Property(e => e.Estacion)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ESTACION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FechaOrden)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ORDEN");

                entity.Property(e => e.FechaOrdenPro)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ORDEN_PRO");

                entity.Property(e => e.FechaProgEsta)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_PROG_ESTA");

                entity.Property(e => e.Job).HasColumnName("JOB");

                entity.Property(e => e.Linea)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("LINEA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Lista).HasColumnName("LISTA");

                entity.Property(e => e.MaqSort).HasColumnName("MAQ_SORT");

                entity.Property(e => e.MillOrden)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("MILL_ORDEN")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.MillPdte)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("MILL_PDTE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.MillProg)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("MILL_PROG")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Oficina)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OFICINA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.Partes).HasColumnName("PARTES");

                entity.Property(e => e.Prensa)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("PRENSA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Programada)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PROGRAMADA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.RestarBacklog).HasColumnName("RESTAR_BACKLOG");

                entity.Property(e => e.Rtasa)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("RTASA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SiDolar)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SI_DOLAR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("STATUS")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Tasa)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("TASA");

                entity.Property(e => e.Vendedor)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("VENDEDOR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Venta).HasColumnName("VENTA");
            });

            modelBuilder.Entity<Wpry062>(entity =>
            {
                entity.HasKey(e => new { e.Orden, e.Recnum })
                    .HasName("WPRY062_INDEX01");

                entity.ToTable("WPRY062");

                entity.HasIndex(e => e.Recnum, "WPRY062_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.Orden, e.Tipo, e.Recnum }, "WPRY062_INDEX02")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.Ano, e.Mes, e.Recnum }, "WPRY062_INDEX03")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => e.Orden, "dep_WPRY062orden");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Ano).HasColumnName("ANO");

                entity.Property(e => e.Anulado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ANULADO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CodAnulacion).HasColumnName("COD_ANULACION");

                entity.Property(e => e.CodProducto)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("COD_PRODUCTO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FechaAct)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ACT");

                entity.Property(e => e.FechaAnulacion)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ANULACION");

                entity.Property(e => e.FlagSms)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_SMS")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Hora)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("HORA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Mes).HasColumnName("MES");

                entity.Property(e => e.NroAnulacion).HasColumnName("NRO_ANULACION");

                entity.Property(e => e.Observacion1)
                    .IsRequired()
                    .HasMaxLength(55)
                    .IsUnicode(false)
                    .HasColumnName("OBSERVACION1")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Observacion2)
                    .IsRequired()
                    .HasMaxLength(55)
                    .IsUnicode(false)
                    .HasColumnName("OBSERVACION2")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Persona)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PERSONA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPO")
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Wpry063>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("WPRY063_INDEX01");

                entity.ToTable("WPRY063");

                entity.HasIndex(e => e.Recnum, "WPRY063_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.Codigo)
                    .ValueGeneratedNever()
                    .HasColumnName("CODIGO");

                entity.Property(e => e.MotivoAnulacio)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("MOTIVO_ANULACIO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");
            });

            modelBuilder.Entity<Wpry064>(entity =>
            {
                entity.HasKey(e => e.Recnum)
                    .HasName("WPRY064_INDEX00");

                entity.ToTable("WPRY064");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Causa)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CAUSA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Cliente)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("CLIENTE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CodCausa).HasColumnName("COD_CAUSA");

                entity.Property(e => e.CodigoProducto)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO_PRODUCTO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Comentarios)
                    .HasColumnType("text")
                    .HasColumnName("COMENTARIOS");

                entity.Property(e => e.Costo)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("COSTO");

                entity.Property(e => e.DescProducto)
                    .IsRequired()
                    .HasMaxLength(65)
                    .IsUnicode(false)
                    .HasColumnName("DESC_PRODUCTO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Familia)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("FAMILIA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FechaDesde)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_DESDE");

                entity.Property(e => e.FechaEmision)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_EMISION");

                entity.Property(e => e.FechaHasta)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_HASTA");

                entity.Property(e => e.Ficha).HasColumnName("FICHA");

                entity.Property(e => e.Iq).HasColumnName("IQ");

                entity.Property(e => e.Linea)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("LINEA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NombreDocket)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_DOCKET")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NombreForma)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_FORMA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NroReporte).HasColumnName("NRO_REPORTE");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.Porcentaje)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("PORCENTAJE");

                entity.Property(e => e.Rcosto)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RCOSTO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Responsable)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RESPONSABLE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Seccion)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("SECCION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TIPO")
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Wpry065>(entity =>
            {
                entity.HasKey(e => e.Recnum)
                    .HasName("WPRY065_INDEX00");

                entity.ToTable("WPRY065");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Causa)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CAUSA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Cliente)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("CLIENTE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CodCausa).HasColumnName("COD_CAUSA");

                entity.Property(e => e.CodigoProducto)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO_PRODUCTO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Comentarios)
                    .HasColumnType("text")
                    .HasColumnName("COMENTARIOS");

                entity.Property(e => e.Costo)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("COSTO");

                entity.Property(e => e.DescProducto)
                    .IsRequired()
                    .HasMaxLength(65)
                    .IsUnicode(false)
                    .HasColumnName("DESC_PRODUCTO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Familia)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("FAMILIA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FechaDesde)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_DESDE");

                entity.Property(e => e.FechaEmision)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_EMISION");

                entity.Property(e => e.FechaHasta)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_HASTA");

                entity.Property(e => e.FechaRodada)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_RODADA");

                entity.Property(e => e.Ficha).HasColumnName("FICHA");

                entity.Property(e => e.Iq).HasColumnName("IQ");

                entity.Property(e => e.Linea)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("LINEA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.MesConcurso).HasColumnName("MES_CONCURSO");

                entity.Property(e => e.Mescon).HasColumnName("MESCON");

                entity.Property(e => e.NroReporte).HasColumnName("NRO_REPORTE");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.PiesRodadosC).HasColumnName("PIES_RODADOS_C");

                entity.Property(e => e.PiesRodadosP).HasColumnName("PIES_RODADOS_P");

                entity.Property(e => e.Porcentaje)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("PORCENTAJE");

                entity.Property(e => e.Rcosto)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RCOSTO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Responsable)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RESPONSABLE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Seccion)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("SECCION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TIPO")
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Wpry066>(entity =>
            {
                entity.HasKey(e => new { e.Orden, e.Recnum })
                    .HasName("WPRY066_INDEX01");

                entity.ToTable("WPRY066");

                entity.HasIndex(e => e.Recnum, "WPRY066_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.AreaActual)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("AREA_ACTUAL")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Cliente).HasColumnName("CLIENTE");

                entity.Property(e => e.Colectora)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("COLECTORA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Concesion)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("CONCESION");

                entity.Property(e => e.Cotizacion)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("COTIZACION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CtdDespachada).HasColumnName("CTD_DESPACHADA");

                entity.Property(e => e.CtdEstacion).HasColumnName("CTD_ESTACION");

                entity.Property(e => e.CtdFacturada).HasColumnName("CTD_FACTURADA");

                entity.Property(e => e.CtdProgramada).HasColumnName("CTD_PROGRAMADA");

                entity.Property(e => e.CteFacturar)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("CTE_FACTURAR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DiasAtraso).HasColumnName("DIAS_ATRASO");

                entity.Property(e => e.Dolares)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DOLARES")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FechaEntrada)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ENTRADA");

                entity.Property(e => e.FechaFactura)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_FACTURA");

                entity.Property(e => e.FechaProgramad)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_PROGRAMAD");

                entity.Property(e => e.Job).HasColumnName("JOB");

                entity.Property(e => e.ListaTotal)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("LISTA_TOTAL");

                entity.Property(e => e.NombreForma)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_FORMA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PlantaFactura)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PLANTA_FACTURA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Prensa)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("PRENSA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Retenido)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("RETENIDO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.RlistaTotal)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RLISTA_TOTAL")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RventaTotal)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RVENTA_TOTAL")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Vendedor)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("VENDEDOR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.VentaTotal)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("VENTA_TOTAL");
            });

            modelBuilder.Entity<Wpry067>(entity =>
            {
                entity.HasKey(e => new { e.Depto, e.LineaProduccio, e.Prensa, e.Orden, e.JobId })
                    .HasName("WPRY067_INDEX01");

                entity.ToTable("WPRY067");

                entity.HasIndex(e => e.Recnum, "WPRY067_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.Depto, e.Vendedor, e.LineaProduccio, e.JobId }, "WPRY067_INDEX02")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.Depto, e.FechaEntrega, e.Orden, e.Recnum }, "WPRY067_INDEX03")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.Depto, e.Prensa, e.FechaEntrega, e.Recnum }, "WPRY067_INDEX04")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.Depto, e.Orden, e.Recnum }, "WPRY067_INDEX05")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.Prensa, e.Orden, e.Recnum }, "WPRY067_INDEX06")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.Cantidad, e.Papel1, e.Papel2, e.Recnum }, "WPRY067_INDEX07")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.Depto).HasColumnName("DEPTO");

                entity.Property(e => e.LineaProduccio)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("LINEA_PRODUCCIO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Prensa).HasColumnName("PRENSA");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.JobId).HasColumnName("JOB_ID");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.Colect).HasColumnName("COLECT");

                entity.Property(e => e.FechaEntrad)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ENTRAD");

                entity.Property(e => e.FechaEntrega)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ENTREGA")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.Pais).HasColumnName("PAIS");

                entity.Property(e => e.Papel1)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("PAPEL1")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Papel2)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("PAPEL2")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.RvalorLista)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RVALOR_LISTA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RvalorVenta)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RVALOR_VENTA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorLista)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("VALOR_LISTA");

                entity.Property(e => e.ValorVenta)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("VALOR_VENTA");

                entity.Property(e => e.Vendedor)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("VENDEDOR")
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Wpry069>(entity =>
            {
                entity.HasKey(e => e.Orden)
                    .HasName("WPRY069_INDEX01");

                entity.ToTable("WPRY069");

                entity.HasIndex(e => e.Recnum, "WPRY069_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.Orden)
                    .ValueGeneratedNever()
                    .HasColumnName("ORDEN");

                entity.Property(e => e.Consecutivo).HasColumnName("CONSECUTIVO");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");
            });

            modelBuilder.Entity<Wpry070>(entity =>
            {
                entity.HasKey(e => e.NroProg)
                    .HasName("WPRY070_INDEX01");

                entity.ToTable("WPRY070");

                entity.HasIndex(e => e.Recnum, "WPRY070_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.NroProg)
                    .ValueGeneratedNever()
                    .HasColumnName("NRO_PROG");

                entity.Property(e => e.Actualizada)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ACTUALIZADA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Asignada)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ASIGNADA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DescMaquina)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("DESC_MAQUINA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA");

                entity.Property(e => e.FechaHoraInicioProg).HasColumnType("datetime");

                entity.Property(e => e.Fechainicioprog)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAINICIOPROG");

                entity.Property(e => e.Horaminutoprog)
                    .HasMaxLength(5)
                    .HasColumnName("HORAMINUTOPROG");

                entity.Property(e => e.Maquina).HasColumnName("MAQUINA");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.UltItem).HasColumnName("ULT_ITEM");
            });

            modelBuilder.Entity<Wpry071>(entity =>
            {
                entity.HasKey(e => new { e.NroProg, e.Orden, e.Item })
                    .HasName("WPRY071_INDEX01");

                entity.ToTable("WPRY071");

                entity.HasIndex(e => e.Recnum, "WPRY071_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.NroProg, e.Item }, "WPRY071_INDEX02")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => e.Orden, "dep_WPRY071orden");

                entity.Property(e => e.NroProg).HasColumnName("NRO_PROG");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.Item).HasColumnName("ITEM");

                entity.Property(e => e.Actualizada)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ACTUALIZADA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Actualizado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ACTUALIZADO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Ancho).HasColumnName("ANCHO");

                entity.Property(e => e.Anchodec)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANCHODEC");

                entity.Property(e => e.Anchotxt)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ANCHOTXT")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.Cliente)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("CLIENTE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CtdTintasFte).HasColumnName("CTD_TINTAS_FTE");

                entity.Property(e => e.DobladoRollo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DOBLADO_ROLLO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.EnPreliminares)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("EN_PRELIMINARES")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FechaDesde)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_DESDE");

                entity.Property(e => e.FechaHasta)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_HASTA");

                entity.Property(e => e.FechaProgMaq)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_PROG_MAQ");

                entity.Property(e => e.FechaProgOrd)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_PROG_ORD");

                entity.Property(e => e.Imprimir)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IMPRIMIR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Itemchange)
                    .HasColumnName("ITEMCHANGE")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Largo).HasColumnName("LARGO");

                entity.Property(e => e.Largodec)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("LARGODEC");

                entity.Property(e => e.Largotxt)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("LARGOTXT")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Maq)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MAQ")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Partes).HasColumnName("PARTES");

                entity.Property(e => e.Producto)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRODUCTO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Sort)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SORT")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Tinta1)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("TINTA1")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Tinta1r)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("TINTA1R")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Tinta2)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("TINTA2")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Tinta2r)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("TINTA2R")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Tinta3)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("TINTA3")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Tinta3r)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("TINTA3R")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Tinta4)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("TINTA4")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Tinta4r)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("TINTA4R")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Tinta5)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("TINTA5")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Tinta5r)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("TINTA5R")
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Wpry072>(entity =>
            {
                entity.HasKey(e => new { e.NroProg, e.Orden, e.Parte })
                    .HasName("WPRY072_INDEX01");

                entity.ToTable("WPRY072");

                entity.HasIndex(e => e.Recnum, "WPRY072_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => e.Orden, "dep_WPRY072orden");

                entity.Property(e => e.NroProg).HasColumnName("NRO_PROG");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.Parte).HasColumnName("PARTE");

                entity.Property(e => e.Ancho)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANCHO");

                entity.Property(e => e.AnchoCarbon)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANCHO_CARBON");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.CodigoCarbon)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO_CARBON")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CodigoPapel)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO_PAPEL")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Kilos)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("KILOS");

                entity.Property(e => e.KilosCarbon)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("KILOS_CARBON");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");
            });

            modelBuilder.Entity<Wpry073>(entity =>
            {
                entity.HasKey(e => e.TipoJob)
                    .HasName("WPRY073_INDEX01");

                entity.ToTable("WPRY073");

                entity.HasIndex(e => e.Recnum, "WPRY073_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.TipoJob)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_JOB")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.AfectaBacklog)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AFECTA_BACKLOG")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");
            });

            modelBuilder.Entity<Wpry080>(entity =>
            {
                entity.HasKey(e => new { e.Orden, e.Archivo })
                    .HasName("WPRY080_INDEX01");

                entity.ToTable("WPRY080");

                entity.HasIndex(e => e.Recnum, "WPRY080_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => e.Orden, "dep_WPRY080orden");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.Archivo)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ARCHIVO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CabezalesMax).HasColumnName("CABEZALES_MAX");

                entity.Property(e => e.Cliente)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("CLIENTE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Digitos).HasColumnName("DIGITOS");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_CREACION");

                entity.Property(e => e.FechaModif)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_MODIF");

                entity.Property(e => e.FormasRollo).HasColumnName("FORMAS_ROLLO");

                entity.Property(e => e.Literal)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("LITERAL")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Nulos).HasColumnName("NULOS");

                entity.Property(e => e.Partes).HasColumnName("PARTES");

                entity.Property(e => e.Posicion)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("POSICION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PrefijoNum)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("PREFIJO_NUM")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.RolloInicial).HasColumnName("ROLLO_INICIAL");

                entity.Property(e => e.Separacion).HasColumnName("SEPARACION");

                entity.Property(e => e.Texto)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("TEXTO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ValorFinal).HasColumnName("VALOR_FINAL");

                entity.Property(e => e.ValorInicial).HasColumnName("VALOR_INICIAL");
            });

            modelBuilder.Entity<Wpry083>(entity =>
            {
                entity.HasKey(e => e.Recnum)
                    .HasName("WPRY083_INDEX00");

                entity.ToTable("WPRY083");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.AnchoRodado).HasColumnName("ANCHO_RODADO");

                entity.Property(e => e.Ano).HasColumnName("ANO");

                entity.Property(e => e.Basica).HasColumnName("BASICA");

                entity.Property(e => e.Cliente)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("CLIENTE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CodigoPapel)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO_PAPEL")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("COLOR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.EmpacarEn)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("EMPACAR_EN")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FechaProd)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_PROD");

                entity.Property(e => e.FormasPedida).HasColumnName("FORMAS_PEDIDA");

                entity.Property(e => e.FormasRodada).HasColumnName("FORMAS_RODADA");

                entity.Property(e => e.Gramaje).HasColumnName("GRAMAJE");

                entity.Property(e => e.Kilos).HasColumnName("KILOS");

                entity.Property(e => e.Mes).HasColumnName("MES");

                entity.Property(e => e.NumInd)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NUM_IND")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NumPresion)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NUM_PRESION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Opuesta).HasColumnName("OPUESTA");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.TipoCaja)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_CAJA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TipoPapel)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_PAPEL")
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Wpry084>(entity =>
            {
                entity.HasKey(e => e.Orden)
                    .HasName("WPRY084_INDEX01");

                entity.ToTable("WPRY084");

                entity.HasIndex(e => e.Recnum, "WPRY084_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.Orden)
                    .ValueGeneratedNever()
                    .HasColumnName("ORDEN");

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CORREO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Cotizacion)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("COTIZACION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagEntPlanta)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_ENT_PLANTA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");
            });

            modelBuilder.Entity<Wpry090>(entity =>
            {
                entity.HasKey(e => new { e.Orden, e.Recnum })
                    .HasName("WPRY090_INDEX01");

                entity.ToTable("WPRY090");

                entity.HasIndex(e => e.Recnum, "WPRY090_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => e.Orden, "dep_WPRY090orden");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.CodigoProducto)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO_PRODUCTO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Cotizacion).HasMaxLength(13);

                entity.Property(e => e.Factura).HasColumnName("FACTURA");

                entity.Property(e => e.FechaAjustada)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_AJUSTADA");

                entity.Property(e => e.FechaFactura)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_FACTURA");

                entity.Property(e => e.FechaOrden)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ORDEN");

                entity.Property(e => e.FechaRenegocia)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_RENEGOCIA");

                entity.Property(e => e.FechaTasaNueva).HasColumnType("smalldatetime");

                entity.Property(e => e.Field44)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FIELD44");

                entity.Property(e => e.Hora)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("HORA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ImpStock)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IMP_STOCK")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ListaDolActua)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("LISTA_DOL_ACTUA");

                entity.Property(e => e.ListaDolaresR)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("LISTA_DOLARES_R");

                entity.Property(e => e.ListaUniActua)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("LISTA_UNI_ACTUA");

                entity.Property(e => e.ListaUniReneg)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("LISTA_UNI_RENEG");

                entity.Property(e => e.LtaTotActBs)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("LTA_TOT_ACT_BS");

                entity.Property(e => e.LtaTotActDol)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("LTA_TOT_ACT_DOL");

                entity.Property(e => e.LtaTotNueBs)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("LTA_TOT_NUE_BS");

                entity.Property(e => e.LtaTotNueDol)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("LTA_TOT_NUE_DOL");

                entity.Property(e => e.Nocalculamc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NOCALCULAMC");

                entity.Property(e => e.NuevaCantidad)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("NUEVA_CANTIDAD")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Oficina)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("OFICINA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PorcMcFinan)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("PORC_MC_FINAN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PorcMcFinansc)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("PORC_MC_FINANSC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PorcMcPapel)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("PORC_MC_PAPEL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PorcMcPapelsc)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("PORC_MC_PAPELSC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RlistaUniActu)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RLISTA_UNI_ACTU")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RlistaUniRene)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RLISTA_UNI_RENE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RltaTotActBs)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RLTA_TOT_ACT_BS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RltaTotNueBs)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RLTA_TOT_NUE_BS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RtasaActual)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("RTASA_ACTUAL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RtasaRenegocia)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("RTASA_RENEGOCIA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RventaUniActu)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RVENTA_UNI_ACTU")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RventaUniRene)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RVENTA_UNI_RENE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RvtaTotActBs)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RVTA_TOT_ACT_BS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RvtaTotNueBs)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RVTA_TOT_NUE_BS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TasaActual)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TASA_ACTUAL");

                entity.Property(e => e.TasaRenegocia)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TASA_RENEGOCIA");

                entity.Property(e => e.Ubicacion)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UBICACION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.VentaDolActua)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("VENTA_DOL_ACTUA");

                entity.Property(e => e.VentaDolaresR)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("VENTA_DOLARES_R");

                entity.Property(e => e.VentaUniActua)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("VENTA_UNI_ACTUA");

                entity.Property(e => e.VentaUniReneg)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("VENTA_UNI_RENEG");

                entity.Property(e => e.VtaTotActBs)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("VTA_TOT_ACT_BS");

                entity.Property(e => e.VtaTotActDol)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("VTA_TOT_ACT_DOL");

                entity.Property(e => e.VtaTotNueBs)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("VTA_TOT_NUE_BS");

                entity.Property(e => e.VtaTotNueDol)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("VTA_TOT_NUE_DOL");
            });

            modelBuilder.Entity<Wpry090tmp>(entity =>
            {
                entity.HasKey(e => new { e.Orden, e.Recnum })
                    .HasName("WPRY090tmp_INDEX01");

                entity.ToTable("WPRY090tmp");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.CodigoProducto)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO_PRODUCTO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Cotizacion).HasMaxLength(13);

                entity.Property(e => e.Factura).HasColumnName("FACTURA");

                entity.Property(e => e.FechaAjustada)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_AJUSTADA");

                entity.Property(e => e.FechaFactura)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_FACTURA");

                entity.Property(e => e.FechaOrden)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ORDEN");

                entity.Property(e => e.FechaRenegocia)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_RENEGOCIA");

                entity.Property(e => e.FechaTasaNueva).HasColumnType("smalldatetime");

                entity.Property(e => e.Field44)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FIELD44");

                entity.Property(e => e.Hora)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("HORA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ImpStock)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IMP_STOCK")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ListaDolActua)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("LISTA_DOL_ACTUA");

                entity.Property(e => e.ListaDolaresR)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("LISTA_DOLARES_R");

                entity.Property(e => e.ListaUniActua)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("LISTA_UNI_ACTUA");

                entity.Property(e => e.ListaUniReneg)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("LISTA_UNI_RENEG");

                entity.Property(e => e.LtaTotActBs)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("LTA_TOT_ACT_BS");

                entity.Property(e => e.LtaTotActDol)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("LTA_TOT_ACT_DOL");

                entity.Property(e => e.LtaTotNueBs)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("LTA_TOT_NUE_BS");

                entity.Property(e => e.LtaTotNueDol)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("LTA_TOT_NUE_DOL");

                entity.Property(e => e.Nocalculamc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NOCALCULAMC");

                entity.Property(e => e.NuevaCantidad)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("NUEVA_CANTIDAD")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Oficina)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("OFICINA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PorcMcFinan)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("PORC_MC_FINAN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PorcMcFinansc)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("PORC_MC_FINANSC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PorcMcPapel)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("PORC_MC_PAPEL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PorcMcPapelsc)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("PORC_MC_PAPELSC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RlistaUniActu)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RLISTA_UNI_ACTU")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RlistaUniRene)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RLISTA_UNI_RENE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RltaTotActBs)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RLTA_TOT_ACT_BS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RltaTotNueBs)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RLTA_TOT_NUE_BS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RtasaActual)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("RTASA_ACTUAL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RtasaRenegocia)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("RTASA_RENEGOCIA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RventaUniActu)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RVENTA_UNI_ACTU")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RventaUniRene)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RVENTA_UNI_RENE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RvtaTotActBs)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RVTA_TOT_ACT_BS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RvtaTotNueBs)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RVTA_TOT_NUE_BS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TasaActual)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TASA_ACTUAL");

                entity.Property(e => e.TasaRenegocia)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TASA_RENEGOCIA");

                entity.Property(e => e.Ubicacion)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UBICACION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.VentaDolActua)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("VENTA_DOL_ACTUA");

                entity.Property(e => e.VentaDolaresR)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("VENTA_DOLARES_R");

                entity.Property(e => e.VentaUniActua)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("VENTA_UNI_ACTUA");

                entity.Property(e => e.VentaUniReneg)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("VENTA_UNI_RENEG");

                entity.Property(e => e.VtaTotActBs)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("VTA_TOT_ACT_BS");

                entity.Property(e => e.VtaTotActDol)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("VTA_TOT_ACT_DOL");

                entity.Property(e => e.VtaTotNueBs)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("VTA_TOT_NUE_BS");

                entity.Property(e => e.VtaTotNueDol)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("VTA_TOT_NUE_DOL");
            });

            modelBuilder.Entity<Wpry094>(entity =>
            {
                entity.HasKey(e => e.Recnum)
                    .HasName("WPRY094_INDEX00");

                entity.ToTable("WPRY094");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.AnchosRodados)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ANCHOS_RODADOS")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Basica)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("BASICA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CarbonSpot)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CARBON_SPOT")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Cliente)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("CLIENTE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CodigoPapel)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO_PAPEL")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CodigoProducto)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO_PRODUCTO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Concesion)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("CONCESION");

                entity.Property(e => e.CtdPerfH).HasColumnName("CTD_PERF_H");

                entity.Property(e => e.CtdPerfV).HasColumnName("CTD_PERF_V");

                entity.Property(e => e.CtdTintasFte).HasColumnName("CTD_TINTAS_FTE");

                entity.Property(e => e.CtdTintasResp).HasColumnName("CTD_TINTAS_RESP");

                entity.Property(e => e.FechaArchDesd)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ARCH_DESD");

                entity.Property(e => e.FechaArchHast)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ARCH_HAST");

                entity.Property(e => e.FechaOrden)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ORDEN");

                entity.Property(e => e.Formas).HasColumnName("FORMAS");

                entity.Property(e => e.FormasXRollo).HasColumnName("FORMAS_X_ROLLO");

                entity.Property(e => e.Frente1)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("FRENTE1")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Frente2)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("FRENTE2")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Frente3)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("FRENTE3")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Frente4)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("FRENTE4")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Frente5)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("FRENTE5")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Frente6)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("FRENTE6")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Linea)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("LINEA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Lista)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("LISTA");

                entity.Property(e => e.MetodoPrecio)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("METODO_PRECIO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Opuesta)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("OPUESTA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.Parte).HasColumnName("PARTE");

                entity.Property(e => e.Resp1)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("RESP1")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Resp2)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("RESP2")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Resp3)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("RESP3")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Resp4)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("RESP4")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Resp5)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("RESP5")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Resp6)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("RESP6")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Rlista)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RLISTA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Rventa)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RVENTA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TipoPapel)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_PAPEL")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Venta)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("VENTA");
            });

            modelBuilder.Entity<Wpry152>(entity =>
            {
                entity.HasKey(e => new { e.Prefijo, e.Numero, e.CantidadXAnch, e.Sufijo })
                    .HasName("WPRY152_INDEX01");

                entity.ToTable("WPRY152");

                entity.HasIndex(e => e.Recnum, "WPRY152_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.Prefijo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PREFIJO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Numero).HasColumnName("NUMERO");

                entity.Property(e => e.CantidadXAnch).HasColumnName("CANTIDAD_X_ANCH");

                entity.Property(e => e.Sufijo)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SUFIJO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CantidadXLarg).HasColumnName("CANTIDAD_X_LARG");

                entity.Property(e => e.EtiquetaAncho)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ETIQUETA_ANCHO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.EtiquetaLargo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ETIQUETA_LARGO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.EtiquetaXVuel).HasColumnName("ETIQUETA_X_VUEL");

                entity.Property(e => e.LinerAnchoDob)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("LINER_ANCHO_DOB")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.LinerAnchoRol)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("LINER_ANCHO_ROL")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.LinerLargo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("LINER_LARGO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Nodisponible)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NODISPONIBLE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");
            });

            modelBuilder.Entity<Wpry155>(entity =>
            {
                entity.HasKey(e => new { e.NroProg, e.Itemchange })
                    .HasName("WPRY155_INDEX01");

                entity.ToTable("WPRY155");

                entity.HasIndex(e => e.Recnum, "WPRY155_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.NroProg).HasColumnName("NRO_PROG");

                entity.Property(e => e.Itemchange).HasColumnName("ITEMCHANGE");

                entity.Property(e => e.Actualizada)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ACTUALIZADA")
                    .IsFixedLength();

                entity.Property(e => e.Actualizado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ACTUALIZADO")
                    .IsFixedLength();

                entity.Property(e => e.Ancho).HasColumnName("ANCHO");

                entity.Property(e => e.Anchodec)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANCHODEC");

                entity.Property(e => e.Anchotxt)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ANCHOTXT")
                    .IsFixedLength();

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.Cliente)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("CLIENTE")
                    .IsFixedLength();

                entity.Property(e => e.CtdTintasFte).HasColumnName("CTD_TINTAS_FTE");

                entity.Property(e => e.DobladoRollo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DOBLADO_ROLLO")
                    .IsFixedLength();

                entity.Property(e => e.EnPreliminares)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("EN_PRELIMINARES")
                    .IsFixedLength();

                entity.Property(e => e.FechaDesde)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_DESDE");

                entity.Property(e => e.FechaHasta)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_HASTA");

                entity.Property(e => e.FechaProgMaq)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_PROG_MAQ");

                entity.Property(e => e.FechaProgOrd)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_PROG_ORD");

                entity.Property(e => e.Imprimir)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IMPRIMIR")
                    .IsFixedLength();

                entity.Property(e => e.Item).HasColumnName("ITEM");

                entity.Property(e => e.Largo).HasColumnName("LARGO");

                entity.Property(e => e.Largodec)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("LARGODEC");

                entity.Property(e => e.Largotxt)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("LARGOTXT")
                    .IsFixedLength();

                entity.Property(e => e.Maq)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MAQ")
                    .IsFixedLength();

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.Partes).HasColumnName("PARTES");

                entity.Property(e => e.Producto)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRODUCTO")
                    .IsFixedLength();

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Sort)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SORT")
                    .IsFixedLength();

                entity.Property(e => e.Tinta1)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("TINTA1")
                    .IsFixedLength();

                entity.Property(e => e.Tinta1r)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("TINTA1R")
                    .IsFixedLength();

                entity.Property(e => e.Tinta2)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("TINTA2")
                    .IsFixedLength();

                entity.Property(e => e.Tinta2r)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("TINTA2R")
                    .IsFixedLength();

                entity.Property(e => e.Tinta3)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("TINTA3")
                    .IsFixedLength();

                entity.Property(e => e.Tinta3r)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("TINTA3R")
                    .IsFixedLength();

                entity.Property(e => e.Tinta4)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("TINTA4")
                    .IsFixedLength();

                entity.Property(e => e.Tinta4r)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("TINTA4R")
                    .IsFixedLength();

                entity.Property(e => e.Tinta5)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("TINTA5")
                    .IsFixedLength();

                entity.Property(e => e.Tinta5r)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("TINTA5R")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Wpry181>(entity =>
            {
                entity.HasKey(e => e.Recnum)
                    .HasName("WPRY181_INDEX00");

                entity.ToTable("WPRY181");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.FecemiCart)
                    .HasColumnType("datetime")
                    .HasColumnName("FECEMI_CART");

                entity.Property(e => e.FecemiIq)
                    .HasColumnType("datetime")
                    .HasColumnName("FECEMI_IQ");

                entity.Property(e => e.FecemiIr)
                    .HasColumnType("datetime")
                    .HasColumnName("FECEMI_IR");

                entity.Property(e => e.FecrecCont)
                    .HasColumnType("datetime")
                    .HasColumnName("FECREC_CONT");

                entity.Property(e => e.FecrecPlan)
                    .HasColumnType("datetime")
                    .HasColumnName("FECREC_PLAN");

                entity.Property(e => e.FecrecProd)
                    .HasColumnType("datetime")
                    .HasColumnName("FECREC_PROD");

                entity.Property(e => e.JobId).HasColumnName("JOB_ID");

                entity.Property(e => e.NroIq).HasColumnName("NRO_IQ");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");
            });

            modelBuilder.Entity<Wpry204>(entity =>
            {
                entity.HasKey(e => new { e.Depto, e.LineaProduccio, e.Prensa, e.Orden, e.JobId })
                    .HasName("WPRY204_INDEX01");

                entity.ToTable("WPRY204");

                entity.HasIndex(e => e.Recnum, "WPRY204_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.Depto, e.Vendedor, e.LineaProduccio, e.JobId }, "WPRY204_INDEX02")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.Depto, e.FechaEntrega, e.Orden, e.Recnum }, "WPRY204_INDEX03")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.Depto, e.Prensa, e.FechaEntrega, e.Recnum }, "WPRY204_INDEX04")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.Depto, e.Orden, e.Recnum }, "WPRY204_INDEX05")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.Prensa, e.Orden, e.Recnum }, "WPRY204_INDEX06")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.Colect, e.Cantidad, e.Papel1, e.Papel2, e.JobId, e.Recnum }, "WPRY204_INDEX07")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.Depto).HasColumnName("DEPTO");

                entity.Property(e => e.LineaProduccio)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("LINEA_PRODUCCIO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Prensa).HasColumnName("PRENSA");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.JobId).HasColumnName("JOB_ID");

                entity.Property(e => e.Cambio)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("CAMBIO");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.Colect).HasColumnName("COLECT");

                entity.Property(e => e.FechaEntrad)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ENTRAD");

                entity.Property(e => e.FechaEntrega)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ENTREGA")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.Listabs)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("LISTABS");

                entity.Property(e => e.Pais).HasColumnName("PAIS");

                entity.Property(e => e.Papel1)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("PAPEL1")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Papel2)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("PAPEL2")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Rcambio)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("RCAMBIO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Rlistabs)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RLISTABS")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RvalorLista)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RVALOR_LISTA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RvalorVenta)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RVALOR_VENTA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Rventabs)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RVENTABS")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorLista)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("VALOR_LISTA");

                entity.Property(e => e.ValorVenta)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("VALOR_VENTA");

                entity.Property(e => e.Vendedor).HasColumnName("VENDEDOR");

                entity.Property(e => e.Ventabs)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("VENTABS");
            });

            modelBuilder.Entity<Wpry206>(entity =>
            {
                entity.HasKey(e => e.Recnum)
                    .HasName("WPRY206_INDEX00");

                entity.ToTable("WPRY206");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Anchos).HasColumnName("ANCHOS");

                entity.Property(e => e.CodigoOperacio).HasColumnName("CODIGO_OPERACIO");

                entity.Property(e => e.Doblado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DOBLADO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA");

                entity.Property(e => e.Formas).HasColumnName("FORMAS");

                entity.Property(e => e.Maq)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MAQ")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Mescon).HasColumnName("MESCON");

                entity.Property(e => e.Nroreo).HasColumnName("NROREO");

                entity.Property(e => e.Operador).HasColumnName("OPERADOR");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.Parte).HasColumnName("PARTE");

                entity.Property(e => e.PiesPlan).HasColumnName("PIES_PLAN");

                entity.Property(e => e.PiesRodados).HasColumnName("PIES_RODADOS");

                entity.Property(e => e.Producto).HasColumnName("PRODUCTO");

                entity.Property(e => e.Tiempo)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("TIEMPO");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Turno).HasColumnName("TURNO");
            });

            modelBuilder.Entity<Wpry214>(entity =>
            {
                entity.HasKey(e => e.Orden)
                    .HasName("WPRY214_INDEX01");

                entity.ToTable("WPRY214");

                entity.HasIndex(e => e.Recnum, "WPRY214_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => e.Item, "WPRY214_INDEX02")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.Orden)
                    .ValueGeneratedNever()
                    .HasColumnName("ORDEN");

                entity.Property(e => e.Ancho).HasColumnName("ANCHO");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.Cliente)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("CLIENTE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CtdTintasFte).HasColumnName("CTD_TINTAS_FTE");

                entity.Property(e => e.DobladoRollo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DOBLADO_ROLLO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.EnPreliminares)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("EN_PRELIMINARES")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FechaDesde)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_DESDE");

                entity.Property(e => e.FechaHasta)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_HASTA");

                entity.Property(e => e.FechaProgMaq)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_PROG_MAQ");

                entity.Property(e => e.FechaProgOrd)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_PROG_ORD");

                entity.Property(e => e.Item).HasColumnName("ITEM");

                entity.Property(e => e.Largo).HasColumnName("LARGO");

                entity.Property(e => e.Maq)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MAQ")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Partes).HasColumnName("PARTES");

                entity.Property(e => e.Producto)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRODUCTO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Tinta1)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("TINTA1")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Tinta1r)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("TINTA1R")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Tinta2)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("TINTA2")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Tinta2r)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("TINTA2R")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Tinta3)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("TINTA3")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Tinta3r)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("TINTA3R")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Tinta4)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("TINTA4")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Tinta4r)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("TINTA4R")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Tinta5)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("TINTA5")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Tinta5r)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("TINTA5R")
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Wpry215>(entity =>
            {
                entity.HasKey(e => new { e.Orden, e.Recnum })
                    .HasName("WPRY215_INDEX01");

                entity.ToTable("WPRY215");

                entity.HasIndex(e => e.Recnum, "WPRY215_INDEX00")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => e.Job, "WPRY215_INDEX02")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.Orden, e.Job }, "WPRY215_INDEX03")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.AtencionCte)
                    .HasColumnType("text")
                    .HasColumnName("ATENCION_CTE");

                entity.Property(e => e.Despacho)
                    .HasColumnType("text")
                    .HasColumnName("DESPACHO");

                entity.Property(e => e.Job).HasColumnName("JOB");

                entity.Property(e => e.Planificacion)
                    .HasColumnType("text")
                    .HasColumnName("PLANIFICACION");

                entity.Property(e => e.SugerenciaAten)
                    .HasColumnType("text")
                    .HasColumnName("SUGERENCIA_ATEN");

                entity.Property(e => e.SugerenciaDesp)
                    .HasColumnType("text")
                    .HasColumnName("SUGERENCIA_DESP");

                entity.Property(e => e.SugerenciaPlan)
                    .HasColumnType("text")
                    .HasColumnName("SUGERENCIA_PLAN");
            });

            modelBuilder.Entity<Wpry227>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WPRY227");

                entity.Property(e => e.CantFactura)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("CANT_FACTURA");

                entity.Property(e => e.CantOrdenada)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("CANT_ORDENADA");

                entity.Property(e => e.Cliente)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("cliente")
                    .IsFixedLength();

                entity.Property(e => e.Factura)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("FACTURA");

                entity.Property(e => e.FechaDespacho)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_DESPACHO");

                entity.Property(e => e.FechaEntrega)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ENTREGA");

                entity.Property(e => e.FechaFactura)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_FACTURA");

                entity.Property(e => e.FechaOrden)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ORDEN");

                entity.Property(e => e.FechaSalFact)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_SAL_FACT");

                entity.Property(e => e.FechaSalProd)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_SAL_PROD");

                entity.Property(e => e.Historicobacklog)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("HISTORICOBACKLOG")
                    .IsFixedLength();

                entity.Property(e => e.JobId)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("JOB_ID")
                    .IsFixedLength();

                entity.Property(e => e.Orden)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ORDEN");

                entity.Property(e => e.PrecioLista)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("PRECIO_LISTA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PrecioVenta)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("PRECIO_VENTA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Printnoprint)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRINTNOPRINT")
                    .IsFixedLength();

                entity.Property(e => e.RprecioLista)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("RPRECIO_LISTA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RprecioVenta)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("RPRECIO_VENTA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RvalorLista)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("RVALOR_LISTA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RvalorVenta)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("RVALOR_VENTA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ValorLista)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("VALOR_LISTA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorVenta)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("VALOR_VENTA")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<Wtmy226>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WTMY226");

                entity.Property(e => e.CantidadProg)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("cantidad_prog");

                entity.Property(e => e.CodEstacion)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("cod_estacion");

                entity.Property(e => e.CodProduc)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cod_produc")
                    .IsFixedLength();

                entity.Property(e => e.CodProveedor)
                    .HasMaxLength(50)
                    .HasColumnName("cod_proveedor");

                entity.Property(e => e.DescEstacion)
                    .HasMaxLength(50)
                    .HasColumnName("desc_estacion");

                entity.Property(e => e.DiasEntregaTerminada)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("dias_entrega_terminada");

                entity.Property(e => e.DiasRetrazo)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("dias_retrazo");

                entity.Property(e => e.FechaEntrega)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_entrega");

                entity.Property(e => e.FechaEstimada)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_estimada");

                entity.Property(e => e.FechaProg)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_prog");

                entity.Property(e => e.FechaTerminada)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_terminada");

                entity.Property(e => e.NomProveedor)
                    .HasMaxLength(50)
                    .HasColumnName("nom_proveedor");

                entity.Property(e => e.Orden)
                    .HasMaxLength(50)
                    .HasColumnName("orden");

                entity.Property(e => e.OrdenPlanta)
                    .HasMaxLength(50)
                    .HasColumnName("orden_planta");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<_92015157>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("92015157");

                entity.Property(e => e.Cliente)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Cliente    ");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
