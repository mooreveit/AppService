using AppService.Core.EntitiesMateriales;
using Microsoft.EntityFrameworkCore;

namespace AppService.Infrastructure.DataMateriales
{
    public partial class MaterialesContext : DbContext
    {
        public MaterialesContext()
        {
        }

        public MaterialesContext(DbContextOptions<MaterialesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Af> Afs { get; set; }
        public virtual DbSet<Bobina> Bobinas { get; set; }
        public virtual DbSet<ConsultaPapel> ConsultaPapels { get; set; }
        public virtual DbSet<ConsumoPorCodigoFifo> ConsumoPorCodigoFifos { get; set; }
        public virtual DbSet<ConsumoPorCodigoFifo1> ConsumoPorCodigoFifos1 { get; set; }
        public virtual DbSet<ConsumoPorFechaCodigoFifo> ConsumoPorFechaCodigoFifos { get; set; }
        public virtual DbSet<ConsumoPorMaquinaMesYAño> ConsumoPorMaquinaMesYAños { get; set; }
        public virtual DbSet<ConsumoPorProveedor> ConsumoPorProveedors { get; set; }
        public virtual DbSet<ConsumosPorCodigoAnual> ConsumosPorCodigoAnuals { get; set; }
        public virtual DbSet<ConsumosPorCodigoDiario> ConsumosPorCodigoDiarios { get; set; }
        public virtual DbSet<ConsumosPorCodigoFechaYMaquina> ConsumosPorCodigoFechaYMaquinas { get; set; }
        public virtual DbSet<ConsumosPorCodigoMensual> ConsumosPorCodigoMensuals { get; set; }
        public virtual DbSet<ConsumosPorCodigoYAnchosDiario> ConsumosPorCodigoYAnchosDiarios { get; set; }
        public virtual DbSet<DetalleDeRollosEnNegativo> DetalleDeRollosEnNegativos { get; set; }
        public virtual DbSet<F0005> F0005s { get; set; }
        public virtual DbSet<F47122l> F47122ls { get; set; }
        public virtual DbSet<Material> Materials { get; set; }
        public virtual DbSet<Medida> Medidas { get; set; }
        public virtual DbSet<Movimientobobina> Movimientobobinas { get; set; }
        public virtual DbSet<Obsolesencium> Obsolesencia { get; set; }
        public virtual DbSet<PapelesCalibre> PapelesCalibres { get; set; }
        public virtual DbSet<TransaccionesPorMesYCodigo> TransaccionesPorMesYCodigos { get; set; }
        public virtual DbSet<Ubicacione> Ubicaciones { get; set; }
        public virtual DbSet<VConsumoPapelxLinea> VConsumoPapelxLineas { get; set; }
        public virtual DbSet<VDiccionariomateriale> VDiccionariomateriales { get; set; }
        public virtual DbSet<VF47122> VF47122s { get; set; }
        public virtual DbSet<VInvetarioReconversion> VInvetarioReconversions { get; set; }
        public virtual DbSet<VWivy001> VWivy001s { get; set; }
        public virtual DbSet<Vf4712> Vf4712s { get; set; }
        public virtual DbSet<Wimy001> Wimy001s { get; set; }
        public virtual DbSet<Wimy001Anterior> Wimy001Anteriors { get; set; }
        public virtual DbSet<Wimy002> Wimy002s { get; set; }
        public virtual DbSet<Wimy003> Wimy003s { get; set; }
        public virtual DbSet<Wimy004> Wimy004s { get; set; }
        public virtual DbSet<Wimy006> Wimy006s { get; set; }
        public virtual DbSet<Wimy007> Wimy007s { get; set; }
        public virtual DbSet<Wimy008> Wimy008s { get; set; }
        public virtual DbSet<Wimy009> Wimy009s { get; set; }
        public virtual DbSet<Wimy010> Wimy010s { get; set; }
        public virtual DbSet<Wimy011> Wimy011s { get; set; }
        public virtual DbSet<Wimy012> Wimy012s { get; set; }
        public virtual DbSet<Wimy013> Wimy013s { get; set; }
        public virtual DbSet<Wimy016> Wimy016s { get; set; }
        public virtual DbSet<Wimy017> Wimy017s { get; set; }
        public virtual DbSet<Wimy018> Wimy018s { get; set; }
        public virtual DbSet<Wimy019> Wimy019s { get; set; }
        public virtual DbSet<Wimy020> Wimy020s { get; set; }
        public virtual DbSet<Wimy021> Wimy021s { get; set; }
        public virtual DbSet<Wimy025> Wimy025s { get; set; }
        public virtual DbSet<Wimy027> Wimy027s { get; set; }
        public virtual DbSet<Wimy028> Wimy028s { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=172.28.107.19\\FSVEMCYN03D;Database=Materiales;User Id=userweb;Password=userweb2003;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Modern_Spanish_CI_AS");

            modelBuilder.Entity<Af>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AF");

                entity.Property(e => e.Activo)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("activo");

                entity.Property(e => e.Compra)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("compra");

                entity.Property(e => e.Dep)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("dep");
            });

            modelBuilder.Entity<Bobina>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BOBINAS");

                entity.Property(e => e.AloContable).HasColumnName("ALO_CONTABLE");

                entity.Property(e => e.Bobina1).HasColumnName("BOBINA");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO");

                entity.Property(e => e.FechaTransac)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_TRANSAC");

                entity.Property(e => e.MesContable).HasColumnName("MES_CONTABLE");

                entity.Property(e => e.Nroir).HasColumnName("NROIR");

                entity.Property(e => e.Rollo).HasColumnName("ROLLO");

                entity.Property(e => e.Transaccion)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("TRANSACCION");
            });

            modelBuilder.Entity<ConsultaPapel>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CONSULTA PAPEL");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("COLOR");

                entity.Property(e => e.DescMaterial1)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESC_MATERIAL1");

                entity.Property(e => e.Genero)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GENERO");

                entity.Property(e => e.Gramaje)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("GRAMAJE");

                entity.Property(e => e.TipoPapel)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_PAPEL");
            });

            modelBuilder.Entity<ConsumoPorCodigoFifo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CONSUMO POR CODIGO FIFO");

                entity.Property(e => e.AloContable)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("ALO_CONTABLE");

                entity.Property(e => e.Cantidad)
                    .HasColumnType("decimal(38, 0)")
                    .HasColumnName("cantidad");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO")
                    .IsFixedLength();

                entity.Property(e => e.Ctacon)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("CTACON")
                    .IsFixedLength();

                entity.Property(e => e.Ctainv)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("CTAINV")
                    .IsFixedLength();

                entity.Property(e => e.MesContable)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("MES_CONTABLE");
            });

            modelBuilder.Entity<ConsumoPorCodigoFifo1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CONSUMO_POR_CODIGO_FIFO");

                entity.Property(e => e.Cantidad)
                    .HasColumnType("decimal(38, 0)")
                    .HasColumnName("cantidad");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO")
                    .IsFixedLength();

                entity.Property(e => e.Ctacon)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("CTACON")
                    .IsFixedLength();

                entity.Property(e => e.Ctainv)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("CTAINV")
                    .IsFixedLength();

                entity.Property(e => e.FechaTransac)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FECHA_TRANSAC");
            });

            modelBuilder.Entity<ConsumoPorFechaCodigoFifo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CONSUMO POR FECHA CODIGO FIFO");

                entity.Property(e => e.Cantidad)
                    .HasColumnType("decimal(38, 0)")
                    .HasColumnName("cantidad");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO")
                    .IsFixedLength();

                entity.Property(e => e.Ctacon)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("CTACON")
                    .IsFixedLength();

                entity.Property(e => e.Ctainv)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("CTAINV")
                    .IsFixedLength();

                entity.Property(e => e.Expr1).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaTransac)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FECHA_TRANSAC");
            });

            modelBuilder.Entity<ConsumoPorMaquinaMesYAño>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CONSUMO POR MAQUINA MES Y AÑO");

                entity.Property(e => e.AloContable)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("ALO_CONTABLE");

                entity.Property(e => e.Ancho)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANCHO");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO")
                    .IsFixedLength();

                entity.Property(e => e.Kilos)
                    .HasColumnType("decimal(38, 0)")
                    .HasColumnName("KILOS");

                entity.Property(e => e.Maquina)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MAQUINA")
                    .IsFixedLength();

                entity.Property(e => e.MesContable)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("MES_CONTABLE");

                entity.Property(e => e.Ubicacion)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UBICACION")
                    .IsFixedLength();
            });

            modelBuilder.Entity<ConsumoPorProveedor>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CONSUMO POR PROVEEDOR");

                entity.Property(e => e.AloContable)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("ALO_CONTABLE");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO")
                    .IsFixedLength();

                entity.Property(e => e.Kilos)
                    .HasColumnType("decimal(38, 0)")
                    .HasColumnName("KILOS");

                entity.Property(e => e.MesContable)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("MES_CONTABLE");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE")
                    .IsFixedLength();

                entity.Property(e => e.Proveedor)
                    .HasColumnType("decimal(6, 0)")
                    .HasColumnName("PROVEEDOR");
            });

            modelBuilder.Entity<ConsumosPorCodigoAnual>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CONSUMOS POR CODIGO ANUAL");

                entity.Property(e => e.AloContable)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("ALO_CONTABLE");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO")
                    .IsFixedLength();

                entity.Property(e => e.Kilos)
                    .HasColumnType("decimal(38, 0)")
                    .HasColumnName("KILOS");
            });

            modelBuilder.Entity<ConsumosPorCodigoDiario>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CONSUMOS POR CODIGO DIARIO");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO")
                    .IsFixedLength();

                entity.Property(e => e.FechaTransac)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FECHA_TRANSAC");

                entity.Property(e => e.Kilos)
                    .HasColumnType("decimal(38, 0)")
                    .HasColumnName("KILOS");
            });

            modelBuilder.Entity<ConsumosPorCodigoFechaYMaquina>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CONSUMOS POR CODIGO FECHA Y MAQUINA");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO")
                    .IsFixedLength();

                entity.Property(e => e.FechaTransac)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FECHA_TRANSAC");

                entity.Property(e => e.Kilos)
                    .HasColumnType("decimal(38, 0)")
                    .HasColumnName("KILOS");

                entity.Property(e => e.Ubicacion)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UBICACION")
                    .IsFixedLength();
            });

            modelBuilder.Entity<ConsumosPorCodigoMensual>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CONSUMOS POR CODIGO MENSUAL");

                entity.Property(e => e.AloContable)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("ALO_CONTABLE");

                entity.Property(e => e.Ancho)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANCHO");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO")
                    .IsFixedLength();

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION")
                    .IsFixedLength();

                entity.Property(e => e.DescripcionGen)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION_GEN")
                    .IsFixedLength();

                entity.Property(e => e.Kilos)
                    .HasColumnType("decimal(38, 0)")
                    .HasColumnName("KILOS");

                entity.Property(e => e.MesContable)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("MES_CONTABLE");
            });

            modelBuilder.Entity<ConsumosPorCodigoYAnchosDiario>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CONSUMOS POR CODIGO Y ANCHOS DIARIO");

                entity.Property(e => e.Ancho)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANCHO");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO")
                    .IsFixedLength();

                entity.Property(e => e.FechaTransac)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FECHA_TRANSAC");

                entity.Property(e => e.Kilos)
                    .HasColumnType("decimal(38, 0)")
                    .HasColumnName("KILOS");
            });

            modelBuilder.Entity<DetalleDeRollosEnNegativo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DETALLE DE ROLLOS EN NEGATIVOS");

                entity.Property(e => e.AloContable)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("ALO_CONTABLE");

                entity.Property(e => e.Cantidad)
                    .HasColumnType("decimal(14, 0)")
                    .HasColumnName("CANTIDAD");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO")
                    .IsFixedLength();

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION")
                    .IsFixedLength();

                entity.Property(e => e.ES)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("E_S")
                    .IsFixedLength();

                entity.Property(e => e.FechaTransac)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FECHA_TRANSAC");

                entity.Property(e => e.MesContable)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("MES_CONTABLE");

                entity.Property(e => e.NroReporte)
                    .HasColumnType("decimal(6, 0)")
                    .HasColumnName("NRO_REPORTE");

                entity.Property(e => e.Transaccion)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("TRANSACCION")
                    .IsFixedLength();

                entity.Property(e => e.Usuario)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO")
                    .IsFixedLength();
            });

            modelBuilder.Entity<F0005>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("F0005");

                entity.Property(e => e.Drdl01)
                    .HasMaxLength(30)
                    .HasColumnName("DRDL01")
                    .IsFixedLength();

                entity.Property(e => e.Drdl02)
                    .HasMaxLength(30)
                    .HasColumnName("DRDL02")
                    .IsFixedLength();

                entity.Property(e => e.Drhrdc)
                    .HasMaxLength(1)
                    .HasColumnName("DRHRDC")
                    .IsFixedLength();

                entity.Property(e => e.Drjobn)
                    .HasMaxLength(10)
                    .HasColumnName("DRJOBN")
                    .IsFixedLength();

                entity.Property(e => e.Drky)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("DRKY")
                    .IsFixedLength();

                entity.Property(e => e.Drpid)
                    .HasMaxLength(10)
                    .HasColumnName("DRPID")
                    .IsFixedLength();

                entity.Property(e => e.Drrt)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("DRRT")
                    .IsFixedLength();

                entity.Property(e => e.Drsphd)
                    .HasMaxLength(10)
                    .HasColumnName("DRSPHD")
                    .IsFixedLength();

                entity.Property(e => e.Drsy)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("DRSY")
                    .IsFixedLength();

                entity.Property(e => e.Drudco)
                    .HasMaxLength(1)
                    .HasColumnName("DRUDCO")
                    .IsFixedLength();

                entity.Property(e => e.Drupmj)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("DRUPMJ");

                entity.Property(e => e.Drupmt).HasColumnName("DRUPMT");

                entity.Property(e => e.Druser)
                    .HasMaxLength(10)
                    .HasColumnName("DRUSER")
                    .IsFixedLength();
            });

            modelBuilder.Entity<F47122l>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("F47122L");

                entity.Property(e => e.An8)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("AN8");

                entity.Property(e => e.Dct)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("DCT");

                entity.Property(e => e.Dgl)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("DGL");

                entity.Property(e => e.Doc)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("DOC");

                entity.Property(e => e.Eder)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("EDER");

                entity.Property(e => e.Edln)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("EDLN");

                entity.Property(e => e.Edsq)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("EDSQ");

                entity.Property(e => e.Edst)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("EDST");

                entity.Property(e => e.Edty)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("EDTY");

                entity.Property(e => e.Kco)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("KCO");

                entity.Property(e => e.Kseq)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("KSEQ");

                entity.Property(e => e.Ldsc)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("LDSC");

                entity.Property(e => e.Litm)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("litm");

                entity.Property(e => e.Locn)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("LOCN");

                entity.Property(e => e.Lotn)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("LOTN");

                entity.Property(e => e.Mcu)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("MCU");

                entity.Property(e => e.Mmej)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("MMEJ");

                entity.Property(e => e.Pacd)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("PACD");

                entity.Property(e => e.Paid)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("PAID");

                entity.Property(e => e.Plot)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("PLOT");

                entity.Property(e => e.Trdj)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("TRDJ");

                entity.Property(e => e.Trex)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("TREX");

                entity.Property(e => e.Trno)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("TRNO");

                entity.Property(e => e.Trqt)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("TRQT");

                entity.Property(e => e.Trum)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("TRUM");

                entity.Property(e => e.Uncs)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("UNCS");
            });

            modelBuilder.Entity<Material>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("material");

                entity.Property(e => e.An8)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("AN8");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO");

                entity.Property(e => e.Dct)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("DCT");

                entity.Property(e => e.Dgl)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("DGL");

                entity.Property(e => e.Doc)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("DOC");

                entity.Property(e => e.Eder)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("EDER");

                entity.Property(e => e.Edln)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("EDLN");

                entity.Property(e => e.Edsq)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("EDSQ");

                entity.Property(e => e.Edst)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("EDST");

                entity.Property(e => e.Edty)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("EDTY");

                entity.Property(e => e.Kco)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("KCO");

                entity.Property(e => e.Kseq)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("KSEQ");

                entity.Property(e => e.Ldsc)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("LDSC");

                entity.Property(e => e.Litm)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("litm");

                entity.Property(e => e.Locn)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("LOCN");

                entity.Property(e => e.Lotn)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("LOTN");

                entity.Property(e => e.Mcu)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("MCU");

                entity.Property(e => e.Mmej)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("MMEJ");

                entity.Property(e => e.Pacd)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("PACD");

                entity.Property(e => e.Paid)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("PAID");

                entity.Property(e => e.Plot)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("PLOT");

                entity.Property(e => e.Trdj)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("TRDJ");

                entity.Property(e => e.Trex)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("TREX");

                entity.Property(e => e.Trno)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("TRNO");

                entity.Property(e => e.Trqt)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("TRQT");

                entity.Property(e => e.Trum)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("TRUM");

                entity.Property(e => e.Uncs)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("UNCS");
            });

            modelBuilder.Entity<Medida>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("medidas");

                entity.Property(e => e.Jde1)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("jde1");

                entity.Property(e => e.Jde2)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("jde2");

                entity.Property(e => e.Materiales)
                    .HasMaxLength(8000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Movimientobobina>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MOVIMIENTOBOBINA");

                entity.Property(e => e.AloContable).HasColumnName("ALO_CONTABLE");

                entity.Property(e => e.Ancho)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANCHO");

                entity.Property(e => e.Bobina).HasColumnName("BOBINA");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO");

                entity.Property(e => e.FechaTransac)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_TRANSAC");

                entity.Property(e => e.MesContable).HasColumnName("MES_CONTABLE");

                entity.Property(e => e.Nroir).HasColumnName("NROIR");

                entity.Property(e => e.Rollo).HasColumnName("ROLLO");

                entity.Property(e => e.Transaccion)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("TRANSACCION");
            });

            modelBuilder.Entity<Obsolesencium>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO");

                entity.Property(e => e.Fecha)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FECHA");

                entity.Property(e => e.Mesano)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("MESANO");

                entity.Property(e => e.Rollo).HasColumnName("ROLLO");

                entity.Property(e => e.RolloOld).HasColumnName("ROLLO_OLD");
            });

            modelBuilder.Entity<PapelesCalibre>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PapelesCalibre");

                entity.Property(e => e.Calibre).HasColumnType("numeric(18, 8)");

                entity.Property(e => e.Papel)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TransaccionesPorMesYCodigo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TRANSACCIONES POR MES Y CODIGO");

                entity.Property(e => e.AloContable)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("ALO_CONTABLE");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO")
                    .IsFixedLength();

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION")
                    .IsFixedLength();

                entity.Property(e => e.ES)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("E_S")
                    .IsFixedLength();

                entity.Property(e => e.Kilos)
                    .HasColumnType("decimal(38, 0)")
                    .HasColumnName("KILOS");

                entity.Property(e => e.MesContable)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("MES_CONTABLE");

                entity.Property(e => e.Transaccion)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("TRANSACCION")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Ubicacione>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Almacen)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("ALMACEN");

                entity.Property(e => e.Col004)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Jde)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("JDE");

                entity.Property(e => e.Materiales)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("MATERIALES");
            });

            modelBuilder.Entity<VConsumoPapelxLinea>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_ConsumoPapelxLinea");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.FechaTransac)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_TRANSAC");

                entity.Property(e => e.Linea)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("LINEA")
                    .IsFixedLength();

                entity.Property(e => e.TipoOrden)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_ORDEN")
                    .IsFixedLength();

                entity.Property(e => e.TipoProducto)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_PRODUCTO");

                entity.Property(e => e.Transaccion)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("TRANSACCION");

                entity.Property(e => e.Ubicacion)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("UBICACION");
            });

            modelBuilder.Entity<VDiccionariomateriale>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_DICCIONARIOMATERIALES");

                entity.Property(e => e.Basededatos)
                    .IsRequired()
                    .HasMaxLength(10)
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

            modelBuilder.Entity<VF47122>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_F47122");

                entity.Property(e => e.Aitm)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("AITM");

                entity.Property(e => e.An8).HasColumnName("AN8");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO");

                entity.Property(e => e.Dct)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("DCT");

                entity.Property(e => e.Dgl)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("DGL");

                entity.Property(e => e.Doc).HasColumnName("DOC");

                entity.Property(e => e.Eder)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("EDER");

                entity.Property(e => e.Edln).HasColumnName("EDLN");

                entity.Property(e => e.Edsq).HasColumnName("EDSQ");

                entity.Property(e => e.Edst).HasColumnName("EDST");

                entity.Property(e => e.Edty).HasColumnName("EDTY");

                entity.Property(e => e.Kco)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("KCO");

                entity.Property(e => e.Kseq).HasColumnName("KSEQ");

                entity.Property(e => e.Ldsc).HasColumnName("LDSC");

                entity.Property(e => e.Litm)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("litm");

                entity.Property(e => e.Locn)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("LOCN");

                entity.Property(e => e.Lotn).HasColumnName("LOTN");

                entity.Property(e => e.Mcu)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("MCU");

                entity.Property(e => e.Mmej)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MMEJ");

                entity.Property(e => e.Pacd)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("PACD");

                entity.Property(e => e.Paid).HasColumnName("PAID");

                entity.Property(e => e.Trdj)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("TRDJ");

                entity.Property(e => e.Trex)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("TREX");

                entity.Property(e => e.Trno).HasColumnName("TRNO");

                entity.Property(e => e.Trqt).HasColumnName("TRQT");

                entity.Property(e => e.Trum)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TRUM");

                entity.Property(e => e.Uncs).HasColumnName("UNCS");
            });

            modelBuilder.Entity<VInvetarioReconversion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_InvetarioReconversion");

                entity.Property(e => e.Basededatos)
                    .IsRequired()
                    .HasMaxLength(10)
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

            modelBuilder.Entity<VWivy001>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_wivy001");

                entity.Property(e => e.Categoria)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("CATEGORIA");

                entity.Property(e => e.Clasificacion)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("CLASIFICACION");

                entity.Property(e => e.CodPostal)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("COD_POSTAL")
                    .IsFixedLength();

                entity.Property(e => e.Codigo)
                    .HasColumnType("decimal(6, 0)")
                    .HasColumnName("CODIGO");

                entity.Property(e => e.CodigoCiudad)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("CODIGO_CIUDAD");

                entity.Property(e => e.CodigoEstado)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("CODIGO_ESTADO");

                entity.Property(e => e.CodigoPais)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("CODIGO_PAIS");

                entity.Property(e => e.Compania)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("COMPANIA");

                entity.Property(e => e.Direccion1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DIRECCION1")
                    .IsFixedLength();

                entity.Property(e => e.Direccion2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DIRECCION2")
                    .IsFixedLength();

                entity.Property(e => e.Direccion3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DIRECCION3")
                    .IsFixedLength();

                entity.Property(e => e.Email)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL")
                    .IsFixedLength();

                entity.Property(e => e.Especial)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ESPECIAL")
                    .IsFixedLength();

                entity.Property(e => e.Fax)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("FAX")
                    .IsFixedLength();

                entity.Property(e => e.FechaEva)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FECHA_EVA");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FECHA_INGRESO");

                entity.Property(e => e.FechaUpdate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FECHA_UPDATE");

                entity.Property(e => e.FormaPago)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("FORMA_PAGO");

                entity.Property(e => e.ImpAcumulado)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("IMP_ACUMULADO");

                entity.Property(e => e.MontoAcumulado)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MONTO_ACUMULADO");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE")
                    .IsFixedLength();

                entity.Property(e => e.NombreCheque)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_CHEQUE")
                    .IsFixedLength();

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("OBSERVACIONES")
                    .IsFixedLength();

                entity.Property(e => e.Origen)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ORIGEN")
                    .IsFixedLength();

                entity.Property(e => e.PasoSql)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PASO_SQL")
                    .IsFixedLength();

                entity.Property(e => e.Persona)
                    .HasMaxLength(55)
                    .IsUnicode(false)
                    .HasColumnName("PERSONA")
                    .IsFixedLength();

                entity.Property(e => e.PorcRet)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("PORC_RET");

                entity.Property(e => e.RecordNumber).HasColumnName("RECORD_NUMBER");

                entity.Property(e => e.Rif)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("RIF")
                    .IsFixedLength();

                entity.Property(e => e.Status)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("STATUS");

                entity.Property(e => e.TipoImpueto)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("TIPO_IMPUETO");

                entity.Property(e => e.Tlf)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("TLF")
                    .IsFixedLength();

                entity.Property(e => e.UltimaCompra)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("ULTIMA_COMPRA");

                entity.Property(e => e.UltimoBs)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("ULTIMO_BS");

                entity.Property(e => e.UltimoDolares)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("ULTIMO_DOLARES");

                entity.Property(e => e.UltimoProducto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ULTIMO_PRODUCTO")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Vf4712>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VF4712");

                entity.Property(e => e.Almjde)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("ALMJDE");

                entity.Property(e => e.An8)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("AN8");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO");

                entity.Property(e => e.Dct)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("DCT");

                entity.Property(e => e.Dgl)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("DGL");

                entity.Property(e => e.Doc)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("DOC");

                entity.Property(e => e.Eder)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("EDER");

                entity.Property(e => e.Edln)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("EDLN");

                entity.Property(e => e.Edsq)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("EDSQ");

                entity.Property(e => e.Edst)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("EDST");

                entity.Property(e => e.Edty)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("EDTY");

                entity.Property(e => e.Kco)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("KCO");

                entity.Property(e => e.Kseq)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("KSEQ");

                entity.Property(e => e.Ldsc)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("LDSC");

                entity.Property(e => e.Litm)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("litm");

                entity.Property(e => e.Locn)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("LOCN");

                entity.Property(e => e.Lotn)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("LOTN");

                entity.Property(e => e.Mcu)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("MCU");

                entity.Property(e => e.Mmej)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("MMEJ");

                entity.Property(e => e.Pacd)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("PACD");

                entity.Property(e => e.Paid)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("PAID");

                entity.Property(e => e.Plot)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("PLOT");

                entity.Property(e => e.Ro)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("RO");

                entity.Property(e => e.Trdj)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("TRDJ");

                entity.Property(e => e.Trex)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("TREX");

                entity.Property(e => e.Trno)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("TRNO");

                entity.Property(e => e.Trqt)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("TRQT");

                entity.Property(e => e.Trum)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("TRUM");

                entity.Property(e => e.Ubijde)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("UBIJDE");

                entity.Property(e => e.Uncs)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("UNCS");
            });

            modelBuilder.Entity<Wimy001>(entity =>
            {
                entity.HasKey(e => new { e.TipoPapel, e.Gramaje, e.Color })
                    .HasName("WIMY001_INDEX01");

                entity.ToTable("WIMY001");

                entity.HasIndex(e => e.Recnum, "WIMY001_INDEX00")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasIndex(e => e.Codigo, "WIMY001_INDEX02")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasIndex(e => new { e.EquiListPrec, e.Codigo }, "WIMY001_INDEX03")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.TipoPapel)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_PAPEL")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Gramaje)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("GRAMAJE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Color)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("COLOR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Calibre)
                    .HasColumnType("numeric(18, 8)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CategoriaValoracion).HasMaxLength(4);

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CostoValorado)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("COSTO_VALORADO");

                entity.Property(e => e.Critico).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ctacon)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("CTACON")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Ctainv)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("CTAINV")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CtdActual).HasColumnName("CTD_ACTUAL");

                entity.Property(e => e.CtdCompro).HasColumnName("CTD_COMPRO");

                entity.Property(e => e.DescCompras1)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESC_COMPRAS1")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DescCompras2)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESC_COMPRAS2")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DescCompras3)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESC_COMPRAS3")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DescMaterial1)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESC_MATERIAL1")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DescMaterial2)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESC_MATERIAL2")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DescVentas1)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESC_VENTAS1")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DescVentas2)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESC_VENTAS2")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Eliminado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ELIMINADO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.EquiListPrec)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EQUI_LIST_PREC")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FUltCompra)
                    .HasColumnType("datetime")
                    .HasColumnName("F_ULT_COMPRA");

                entity.Property(e => e.FUltEntrada)
                    .HasColumnType("datetime")
                    .HasColumnName("F_ULT_ENTRADA");

                entity.Property(e => e.FUltSalida)
                    .HasColumnType("datetime")
                    .HasColumnName("F_ULT_SALIDA");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_CREACION");

                entity.Property(e => e.FechaModifica)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_MODIFICA");

                entity.Property(e => e.Genero)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GENERO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.GrupoArticulo)
                    .HasMaxLength(10)
                    .HasColumnName("GRUPO_ARTICULO");

                entity.Property(e => e.Idcategoria)
                    .HasColumnName("IDCATEGORIA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Maximo).HasColumnName("MAXIMO");

                entity.Property(e => e.Minimo).HasColumnName("MINIMO");

                entity.Property(e => e.Observacion)
                    .HasColumnType("text")
                    .HasColumnName("OBSERVACION");

                entity.Property(e => e.Pplana)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PPLANA");

                entity.Property(e => e.PuntoReorden).HasColumnName("PUNTO_REORDEN");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.TiempoEntrega).HasColumnName("TIEMPO_ENTREGA");

                entity.Property(e => e.UltProveedor).HasColumnName("ULT_PROVEEDOR");

                entity.Property(e => e.UltimoCosto)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("ULTIMO_COSTO");

                entity.Property(e => e.Unidad)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("UNIDAD")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.UsuarioCreo)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_CREO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.UsuarioModif)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_MODIF")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Zonaalmcensap)
                    .HasMaxLength(3)
                    .HasColumnName("ZONAALMCENSAP");
            });

            modelBuilder.Entity<Wimy001Anterior>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WIMY001_anterior");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO")
                    .IsFixedLength();

                entity.Property(e => e.Color)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("COLOR")
                    .IsFixedLength();

                entity.Property(e => e.Ctacon)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("CTACON")
                    .IsFixedLength();

                entity.Property(e => e.Ctainv)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("CTAINV")
                    .IsFixedLength();

                entity.Property(e => e.CtdActual)
                    .HasColumnType("decimal(14, 0)")
                    .HasColumnName("CTD_ACTUAL");

                entity.Property(e => e.CtdCompro)
                    .HasColumnType("decimal(14, 0)")
                    .HasColumnName("CTD_COMPRO");

                entity.Property(e => e.DescCompras1)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESC_COMPRAS1")
                    .IsFixedLength();

                entity.Property(e => e.DescCompras2)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESC_COMPRAS2")
                    .IsFixedLength();

                entity.Property(e => e.DescCompras3)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESC_COMPRAS3")
                    .IsFixedLength();

                entity.Property(e => e.DescMaterial1)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESC_MATERIAL1")
                    .IsFixedLength();

                entity.Property(e => e.DescMaterial2)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESC_MATERIAL2")
                    .IsFixedLength();

                entity.Property(e => e.DescVentas1)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESC_VENTAS1")
                    .IsFixedLength();

                entity.Property(e => e.DescVentas2)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESC_VENTAS2")
                    .IsFixedLength();

                entity.Property(e => e.Eliminado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ELIMINADO")
                    .IsFixedLength();

                entity.Property(e => e.FUltCompra)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("F_ULT_COMPRA");

                entity.Property(e => e.FUltEntrada)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("F_ULT_ENTRADA");

                entity.Property(e => e.FUltSalida)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("F_ULT_SALIDA");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FECHA_CREACION");

                entity.Property(e => e.FechaModifica)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FECHA_MODIFICA");

                entity.Property(e => e.Genero)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GENERO")
                    .IsFixedLength();

                entity.Property(e => e.Gramaje)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("GRAMAJE")
                    .IsFixedLength();

                entity.Property(e => e.Maximo)
                    .HasColumnType("decimal(14, 0)")
                    .HasColumnName("MAXIMO");

                entity.Property(e => e.Minimo)
                    .HasColumnType("decimal(14, 0)")
                    .HasColumnName("MINIMO");

                entity.Property(e => e.Observacion)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("OBSERVACION")
                    .IsFixedLength();

                entity.Property(e => e.PuntoReorden)
                    .HasColumnType("decimal(14, 0)")
                    .HasColumnName("PUNTO_REORDEN");

                entity.Property(e => e.RecordNumber).HasColumnName("RECORD_NUMBER");

                entity.Property(e => e.TiempoEntrega)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("TIEMPO_ENTREGA");

                entity.Property(e => e.TipoPapel)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_PAPEL")
                    .IsFixedLength();

                entity.Property(e => e.UltProveedor)
                    .HasColumnType("decimal(6, 0)")
                    .HasColumnName("ULT_PROVEEDOR");

                entity.Property(e => e.Unidad)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("UNIDAD")
                    .IsFixedLength();

                entity.Property(e => e.UsuarioCreo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_CREO")
                    .IsFixedLength();

                entity.Property(e => e.UsuarioModif)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_MODIF")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Wimy002>(entity =>
            {
                entity.HasKey(e => e.Tipo)
                    .HasName("WIMY002_INDEX01");

                entity.ToTable("WIMY002");

                entity.HasIndex(e => e.Recnum, "WIMY002_INDEX00")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TIPO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Eliminado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ELIMINADO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_CREACION");

                entity.Property(e => e.FechaModifica)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_MODIFICA");

                entity.Property(e => e.Genero)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GENERO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");
            });

            modelBuilder.Entity<Wimy003>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("WIMY003_INDEX01");

                entity.ToTable("WIMY003");

                entity.HasIndex(e => e.Recnum, "WIMY003_INDEX00")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Codigo)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Brillo)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("BRILLO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("COLOR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Eliminado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ELIMINADO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_CREACION");

                entity.Property(e => e.FechaModifica)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_MODIFICA");

                entity.Property(e => e.Imagen)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("IMAGEN")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");
            });

            modelBuilder.Entity<Wimy004>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("WIMY004_INDEX01");

                entity.ToTable("WIMY004");

                entity.HasIndex(e => e.Recnum, "WIMY004_INDEX00")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Codigo)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.AfectaConsumo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AFECTA_CONSUMO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.AfectaFifo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AFECTA_FIFO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Eliminado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ELIMINADO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Es)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ES")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_CREACION");

                entity.Property(e => e.FechaModif)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_MODIF");

                entity.Property(e => e.GeneraHijo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GENERA_HIJO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.GeneraNuevoPa)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GENERA_NUEVO_PA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.SignoFifo).HasColumnName("SIGNO_FIFO");

                entity.Property(e => e.TransGenera)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("TRANS_GENERA")
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Wimy006>(entity =>
            {
                entity.HasKey(e => e.CodigoGenero)
                    .HasName("WIMY006_INDEX01");

                entity.ToTable("WIMY006");

                entity.HasIndex(e => e.Recnum, "WIMY006_INDEX00")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.CodigoGenero)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO_GENERO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DescripcionGen)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION_GEN")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_CREACION");

                entity.Property(e => e.FechaModifica)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_MODIFICA");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");
            });

            modelBuilder.Entity<Wimy007>(entity =>
            {
                entity.HasKey(e => e.CodigoZona)
                    .HasName("WIMY007_INDEX01");

                entity.ToTable("WIMY007");

                entity.HasIndex(e => e.Recnum, "WIMY007_INDEX00")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.CodigoZona)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO_ZONA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DescripcionZon)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION_ZON")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Eliminado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ELIMINADO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_CREACION");

                entity.Property(e => e.FechaModifica)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_MODIFICA");

                entity.Property(e => e.Maquina)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MAQUINA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.ValidarMaquina)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("VALIDAR_MAQUINA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ValidarPapel)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("VALIDAR_PAPEL")
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Wimy008>(entity =>
            {
                entity.HasKey(e => e.Rollo)
                    .HasName("WIMY008_INDEX01");

                entity.ToTable("WIMY008");

                entity.HasIndex(e => e.Recnum, "WIMY008_INDEX00")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasIndex(e => new { e.UsuarioModif, e.TicketImpreso, e.Rollo }, "WIMY008_INDEX02")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasIndex(e => new { e.Codigo, e.Ancho, e.FechaCreacion, e.Rollo }, "WIMY008_INDEX03")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasIndex(e => new { e.TicketImpreso, e.Rollo }, "WIMY008_INDEX04")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Rollo)
                    .ValueGeneratedNever()
                    .HasColumnName("ROLLO");

                entity.Property(e => e.Ancho)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANCHO");

                entity.Property(e => e.AsigDocket).HasColumnName("ASIG_DOCKET");

                entity.Property(e => e.Bobina).HasColumnName("BOBINA");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("COLOR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CostoFactura)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("COSTO_FACTURA");

                entity.Property(e => e.DescripcionGen)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION_GEN")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Desctipopapel)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("DESCTIPOPAPEL")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Diametro).HasColumnName("DIAMETRO");

                entity.Property(e => e.Entradas).HasColumnName("ENTRADAS");

                entity.Property(e => e.Feccon)
                    .HasColumnType("datetime")
                    .HasColumnName("FECCON");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_CREACION")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.FechaModif)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_MODIF");

                entity.Property(e => e.FechaTransac)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_TRANSAC");

                entity.Property(e => e.Fecrec)
                    .HasColumnType("datetime")
                    .HasColumnName("FECREC");

                entity.Property(e => e.GeneroPapel)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GENERO_PAPEL")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Gramaje)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("GRAMAJE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Hijos).HasColumnName("HIJOS");

                entity.Property(e => e.KilosTransa).HasColumnName("KILOS_TRANSA");

                entity.Property(e => e.LoteProveedor)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("LOTE_PROVEEDOR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Nrfact)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NRFACT")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Nrnotaentrega)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NRNOTAENTREGA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NroReporte).HasColumnName("NRO_REPORTE");

                entity.Property(e => e.Nroir).HasColumnName("NROIR");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.OrdenCompra).HasColumnName("ORDEN_COMPRA");

                entity.Property(e => e.PasoSql)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PASO_SQL")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Programacion).HasColumnName("PROGRAMACION");

                entity.Property(e => e.Proveedor).HasColumnName("PROVEEDOR");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.RolloProveedor).HasColumnName("ROLLO_PROVEEDOR");

                entity.Property(e => e.Saldo).HasColumnName("SALDO");

                entity.Property(e => e.Salidas).HasColumnName("SALIDAS");

                entity.Property(e => e.Salini).HasColumnName("SALINI");

                entity.Property(e => e.TicketImpreso)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TICKET_IMPRESO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TipoPapel)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_PAPEL")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Ubicacion)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UBICACION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Unidad)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("UNIDAD")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.UsuarioCrea)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_CREA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.UsuarioModif)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_MODIF")
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Wimy009>(entity =>
            {
                entity.HasKey(e => new { e.NroReporte, e.Rollo, e.Recnum })
                    .HasName("WIMY009_INDEX01");

                entity.ToTable("WIMY009");

                entity.HasIndex(e => e.Recnum, "WIMY009_INDEX00")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasIndex(e => new { e.Usuario, e.Listar, e.Transaccion, e.FechaTransac, e.Rollo, e.Recnum }, "WIMY009_INDEX02")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasIndex(e => new { e.AloContable, e.MesContable, e.Codigo, e.Recnum }, "WIMY009_INDEX03")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasIndex(e => new { e.PasoSql, e.Recnum }, "WIMY009_INDEX04")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasIndex(e => new { e.FechaTransac, e.Transaccion, e.Rollo, e.Recnum }, "WIMY009_INDEX05")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasIndex(e => new { e.Usuario, e.Listar, e.Transaccion, e.Nroir, e.Recnum }, "WIMY009_INDEX06")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.NroReporte).HasColumnName("NRO_REPORTE");

                entity.Property(e => e.Rollo).HasColumnName("ROLLO");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.AloContable).HasColumnName("ALO_CONTABLE");

                entity.Property(e => e.Ancho)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANCHO");

                entity.Property(e => e.AsigDocket).HasColumnName("ASIG_DOCKET");

                entity.Property(e => e.Bobina).HasColumnName("BOBINA");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.CausaAjuste).HasColumnName("CAUSA_AJUSTE");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("COLOR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CostoFactura)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("COSTO_FACTURA");

                entity.Property(e => e.Diametro).HasColumnName("DIAMETRO");

                entity.Property(e => e.ES)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("E_S")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Feccon)
                    .HasColumnType("datetime")
                    .HasColumnName("FECCON");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_CREACION");

                entity.Property(e => e.FechaTransac)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_TRANSAC")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.Fecrec)
                    .HasColumnType("datetime")
                    .HasColumnName("FECREC");

                entity.Property(e => e.Gramaje)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("GRAMAJE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Listar)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("LISTAR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.LoteProveedor)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("LOTE_PROVEEDOR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.MesContable).HasColumnName("MES_CONTABLE");

                entity.Property(e => e.NoUsar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NO_USAR")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nrfact).HasColumnName("NRFACT");

                entity.Property(e => e.Nrnotaentrega).HasColumnName("NRNOTAENTREGA");

                entity.Property(e => e.Nroir).HasColumnName("NROIR");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.OrdenCompra).HasColumnName("ORDEN_COMPRA");

                entity.Property(e => e.PasoSql)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PASO_SQL")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Proveedor).HasColumnName("PROVEEDOR");

                entity.Property(e => e.TipoPapel)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_PAPEL")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Transaccion)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("TRANSACCION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Ubicacion)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UBICACION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Unidad)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("UNIDAD")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO")
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Wimy010>(entity =>
            {
                entity.HasKey(e => e.Recnum)
                    .HasName("WIMY010_INDEX00");

                entity.ToTable("WIMY010");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.AnoCurso).HasColumnName("ANO_CURSO");

                entity.Property(e => e.FechaInv)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_INV");

                entity.Property(e => e.MesCurso).HasColumnName("MES_CURSO");

                entity.Property(e => e.UltAsignacion).HasColumnName("ULT_ASIGNACION");

                entity.Property(e => e.UltimoRollo).HasColumnName("ULTIMO_ROLLO");
            });

            modelBuilder.Entity<Wimy011>(entity =>
            {
                entity.HasKey(e => new { e.Nroir, e.Item, e.ItemIr, e.Recnum })
                    .HasName("WIMY011_INDEX01");

                entity.ToTable("WIMY011");

                entity.HasIndex(e => e.Recnum, "WIMY011_INDEX00")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasIndex(e => new { e.Nroir, e.ItemIr, e.Recnum }, "WIMY011_INDEX02")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Nroir).HasColumnName("NROIR");

                entity.Property(e => e.Item).HasColumnName("ITEM");

                entity.Property(e => e.ItemIr).HasColumnName("ITEM_IR");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Ancho)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANCHO");

                entity.Property(e => e.AsigDocket).HasColumnName("ASIG_DOCKET");

                entity.Property(e => e.Bobina).HasColumnName("BOBINA");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("COLOR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CostoFactura)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("COSTO_FACTURA");

                entity.Property(e => e.Diametro).HasColumnName("DIAMETRO");

                entity.Property(e => e.Entradas).HasColumnName("ENTRADAS");

                entity.Property(e => e.Feccon)
                    .HasColumnType("datetime")
                    .HasColumnName("FECCON");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_CREACION");

                entity.Property(e => e.FechaModif)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_MODIF");

                entity.Property(e => e.FechaTransac)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_TRANSAC");

                entity.Property(e => e.Fecrec)
                    .HasColumnType("datetime")
                    .HasColumnName("FECREC");

                entity.Property(e => e.Gramaje)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("GRAMAJE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Hijos).HasColumnName("HIJOS");

                entity.Property(e => e.KilosTransa).HasColumnName("KILOS_TRANSA");

                entity.Property(e => e.LoteProveedor)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("LOTE_PROVEEDOR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Nrfact)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NRFACT")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Nrnotaentrega).HasColumnName("NRNOTAENTREGA");

                entity.Property(e => e.NroReporte).HasColumnName("NRO_REPORTE");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.OrdenCompra).HasColumnName("ORDEN_COMPRA");

                entity.Property(e => e.PasoSql)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PASO_SQL")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Programacion).HasColumnName("PROGRAMACION");

                entity.Property(e => e.Proveedor).HasColumnName("PROVEEDOR");

                entity.Property(e => e.Rollo).HasColumnName("ROLLO");

                entity.Property(e => e.RolloProveedor).HasColumnName("ROLLO_PROVEEDOR");

                entity.Property(e => e.Saldo).HasColumnName("SALDO");

                entity.Property(e => e.Salidas).HasColumnName("SALIDAS");

                entity.Property(e => e.Salini).HasColumnName("SALINI");

                entity.Property(e => e.TicketImpreso)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TICKET_IMPRESO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TipoPapel)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_PAPEL")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Ubicacion)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UBICACION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Unidad)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("UNIDAD")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.UsuarioCrea)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_CREA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.UsuarioModif)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_MODIF")
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Wimy012>(entity =>
            {
                entity.HasKey(e => e.NroReporte)
                    .HasName("WIMY012_INDEX01");

                entity.ToTable("WIMY012");

                entity.HasIndex(e => e.Recnum, "WIMY012_INDEX00")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasIndex(e => new { e.Usuario, e.NroReporte }, "WIMY012_INDEX02")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasIndex(e => new { e.Actualizar, e.NroReporte }, "WIMY012_INDEX03")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.NroReporte)
                    .ValueGeneratedNever()
                    .HasColumnName("NRO_REPORTE");

                entity.Property(e => e.Actualizar)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ACTUALIZAR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA");

                entity.Property(e => e.Operador).HasColumnName("OPERADOR");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Transaccion)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("TRANSACCION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Turno).HasColumnName("TURNO");

                entity.Property(e => e.UltimoItem).HasColumnName("ULTIMO_ITEM");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO")
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Wimy013>(entity =>
            {
                entity.HasKey(e => new { e.NoReporte, e.Item })
                    .HasName("WIMY013_INDEX01");

                entity.ToTable("WIMY013");

                entity.HasIndex(e => e.Recnum, "WIMY013_INDEX00")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.NoReporte).HasColumnName("NO_REPORTE");

                entity.Property(e => e.Item).HasColumnName("ITEM");

                entity.Property(e => e.DiametroEntrad)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("DIAMETRO_ENTRAD");

                entity.Property(e => e.KgsEntrada).HasColumnName("KGS_ENTRADA");

                entity.Property(e => e.KgsSalida).HasColumnName("KGS_SALIDA");

                entity.Property(e => e.MedidaEntrada)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("MEDIDA_ENTRADA");

                entity.Property(e => e.MedidaSalida)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("MEDIDA_SALIDA");

                entity.Property(e => e.Orden1).HasColumnName("ORDEN1");

                entity.Property(e => e.Orden2).HasColumnName("ORDEN2");

                entity.Property(e => e.Orden3).HasColumnName("ORDEN3");

                entity.Property(e => e.Orden4).HasColumnName("ORDEN4");

                entity.Property(e => e.Orden5).HasColumnName("ORDEN5");

                entity.Property(e => e.Orden6).HasColumnName("ORDEN6");

                entity.Property(e => e.PapelEntrada)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("PAPEL_ENTRADA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PapelSalida)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("PAPEL_SALIDA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Programacion).HasColumnName("PROGRAMACION");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.RolloEntrada).HasColumnName("ROLLO_ENTRADA");

                entity.Property(e => e.RolloSalida).HasColumnName("ROLLO_SALIDA");

                entity.Property(e => e.Rolloadicional1).HasColumnName("ROLLOADICIONAL1");

                entity.Property(e => e.Rolloadicional2).HasColumnName("ROLLOADICIONAL2");

                entity.Property(e => e.Rolloadicional3).HasColumnName("ROLLOADICIONAL3");

                entity.Property(e => e.Rolloadicional4).HasColumnName("ROLLOADICIONAL4");

                entity.Property(e => e.Rolloadicional5).HasColumnName("ROLLOADICIONAL5");

                entity.Property(e => e.Rolloadicional6).HasColumnName("ROLLOADICIONAL6");

                entity.Property(e => e.Rolloadicional7).HasColumnName("ROLLOADICIONAL7");

                entity.Property(e => e.Rolloadicional8).HasColumnName("ROLLOADICIONAL8");

                entity.Property(e => e.UbicacionEntra)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UBICACION_ENTRA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.UbicacionSali)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UBICACION_SALI")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.UltimoRollo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ULTIMO_ROLLO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Ultrollo1)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ULTROLLO1")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Ultrollo2)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ULTROLLO2")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Ultrollo3)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ULTROLLO3")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Ultrollo4)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ULTROLLO4")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Ultrollo5)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ULTROLLO5")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Ultrollo6)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ULTROLLO6")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Ultrollo7)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ULTROLLO7")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Ultrollo8)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ULTROLLO8")
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Wimy016>(entity =>
            {
                entity.HasKey(e => e.NroReporte)
                    .HasName("WIMY016_INDEX01");

                entity.ToTable("WIMY016");

                entity.HasIndex(e => e.Recnum, "WIMY016_INDEX00")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.NroReporte)
                    .ValueGeneratedNever()
                    .HasColumnName("NRO_REPORTE");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");
            });

            modelBuilder.Entity<Wimy017>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("WIMY017_INDEX01");

                entity.ToTable("WIMY017");

                entity.HasIndex(e => e.Recnum, "WIMY017_INDEX00")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Codigo)
                    .ValueGeneratedNever()
                    .HasColumnName("CODIGO");

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

            modelBuilder.Entity<Wimy018>(entity =>
            {
                entity.HasKey(e => e.RolloEntrada)
                    .HasName("WIMY018_INDEX01");

                entity.ToTable("WIMY018");

                entity.HasIndex(e => e.Recnum, "WIMY018_INDEX00")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.RolloEntrada)
                    .ValueGeneratedNever()
                    .HasColumnName("ROLLO_ENTRADA");

                entity.Property(e => e.CausaAjuste).HasColumnName("CAUSA_AJUSTE");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA");

                entity.Property(e => e.KgsEntrada).HasColumnName("KGS_ENTRADA");

                entity.Property(e => e.KgsSalida).HasColumnName("KGS_SALIDA");

                entity.Property(e => e.MedidaEntrada)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("MEDIDA_ENTRADA");

                entity.Property(e => e.MedidaSalida)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("MEDIDA_SALIDA");

                entity.Property(e => e.PapelEntrada)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("PAPEL_ENTRADA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PapelSalida)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("PAPEL_SALIDA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Transaccion)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("TRANSACCION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ZonaEntrada)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ZONA_ENTRADA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ZonaSalida)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ZONA_SALIDA")
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Wimy019>(entity =>
            {
                entity.HasKey(e => e.NroAsignacion)
                    .HasName("WIMY019_INDEX01");

                entity.ToTable("WIMY019");

                entity.HasIndex(e => e.Recnum, "WIMY019_INDEX00")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.NroAsignacion)
                    .ValueGeneratedNever()
                    .HasColumnName("NRO_ASIGNACION");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.UltItem).HasColumnName("ULT_ITEM");
            });

            modelBuilder.Entity<Wimy020>(entity =>
            {
                entity.HasKey(e => new { e.NroAsignacion, e.Item, e.Rollo, e.Recnum })
                    .HasName("WIMY020_INDEX01")
                    .IsClustered(false);

                entity.ToTable("WIMY020");

                entity.HasIndex(e => e.Recnum, "WIMY020_INDEX00")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasIndex(e => new { e.Actualizar, e.Recnum }, "WIMY020_INDEX03")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasIndex(e => e.Rollo, "WIMY020_INDEX04")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.NroAsignacion).HasColumnName("NRO_ASIGNACION");

                entity.Property(e => e.Item).HasColumnName("ITEM");

                entity.Property(e => e.Rollo).HasColumnName("ROLLO");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Actualizar)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ACTUALIZAR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CodigoPapel)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO_PAPEL")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Combinada)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("COMBINADA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DescMaquina)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("DESC_MAQUINA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FechaConsumo)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_CONSUMO");

                entity.Property(e => e.KgsSobrante).HasColumnName("KGS_SOBRANTE");

                entity.Property(e => e.Kilos).HasColumnName("KILOS");

                entity.Property(e => e.Maquina).HasColumnName("MAQUINA");

                entity.Property(e => e.NuevaDescMaq)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("NUEVA_DESC_MAQ")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NuevaUbicacion)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("NUEVA_UBICACION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NvaMaquina).HasColumnName("NVA_MAQUINA");

                entity.Property(e => e.Orden1).HasColumnName("ORDEN1");

                entity.Property(e => e.Orden2).HasColumnName("ORDEN2");

                entity.Property(e => e.Orden3).HasColumnName("ORDEN3");

                entity.Property(e => e.Orden4).HasColumnName("ORDEN4");

                entity.Property(e => e.Orden5).HasColumnName("ORDEN5");

                entity.Property(e => e.Orden6).HasColumnName("ORDEN6");

                entity.Property(e => e.Programacion).HasColumnName("PROGRAMACION");

                entity.Property(e => e.Transaccion)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("TRANSACCION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.UbicacionAct)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UBICACION_ACT")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO")
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Wimy021>(entity =>
            {
                entity.HasKey(e => e.Rollo)
                    .HasName("WIMY021_INDEX01");

                entity.ToTable("WIMY021");

                entity.HasIndex(e => e.Recnum, "WIMY021_INDEX00")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasIndex(e => new { e.Codigo, e.Ancho, e.Feccon, e.Rollo }, "WIMY021_INDEX02")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasIndex(e => new { e.Bobina, e.Rollo }, "WIMY021_INDEX03")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Rollo)
                    .ValueGeneratedNever()
                    .HasColumnName("ROLLO");

                entity.Property(e => e.Ancho)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANCHO");

                entity.Property(e => e.AsigDocket).HasColumnName("ASIG_DOCKET");

                entity.Property(e => e.Bobina).HasColumnName("BOBINA");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("COLOR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CostoFactura)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("COSTO_FACTURA");

                entity.Property(e => e.DescripcionGen)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION_GEN")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Desctipopapel)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("DESCTIPOPAPEL")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Diametro).HasColumnName("DIAMETRO");

                entity.Property(e => e.Entradas).HasColumnName("ENTRADAS");

                entity.Property(e => e.Feccon)
                    .HasColumnType("datetime")
                    .HasColumnName("FECCON")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_CREACION");

                entity.Property(e => e.FechaModif)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_MODIF");

                entity.Property(e => e.FechaTransac)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_TRANSAC");

                entity.Property(e => e.Fecrec)
                    .HasColumnType("datetime")
                    .HasColumnName("FECREC");

                entity.Property(e => e.GeneroPapel)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GENERO_PAPEL")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Gramaje)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("GRAMAJE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Hijos).HasColumnName("HIJOS");

                entity.Property(e => e.KilosTransa).HasColumnName("KILOS_TRANSA");

                entity.Property(e => e.LoteProveedor)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("LOTE_PROVEEDOR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Nrfact)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NRFACT")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Nrnotaentrega)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NRNOTAENTREGA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NroReporte).HasColumnName("NRO_REPORTE");

                entity.Property(e => e.Nroir).HasColumnName("NROIR");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.OrdenCompra).HasColumnName("ORDEN_COMPRA");

                entity.Property(e => e.PasoSql)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PASO_SQL")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Programacion).HasColumnName("PROGRAMACION");

                entity.Property(e => e.Proveedor).HasColumnName("PROVEEDOR");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.RolloProveedor).HasColumnName("ROLLO_PROVEEDOR");

                entity.Property(e => e.Saldo).HasColumnName("SALDO");

                entity.Property(e => e.Salidas).HasColumnName("SALIDAS");

                entity.Property(e => e.Salini).HasColumnName("SALINI");

                entity.Property(e => e.TicketImpreso)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TICKET_IMPRESO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TipoPapel)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_PAPEL")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Ubicacion)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UBICACION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Unidad)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("UNIDAD")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.UsuarioCrea)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_CREA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.UsuarioModif)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_MODIF")
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Wimy025>(entity =>
            {
                entity.HasKey(e => new { e.Codigo, e.Ano })
                    .HasName("WIMY025_INDEX01");

                entity.ToTable("WIMY025");

                entity.HasIndex(e => e.Recnum, "WIMY025_INDEX00")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Codigo)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Ano).HasColumnName("ANO");

                entity.Property(e => e.AbrilEntradas).HasColumnName("ABRIL_ENTRADAS");

                entity.Property(e => e.AbrilFinal).HasColumnName("ABRIL_FINAL");

                entity.Property(e => e.AbrilInicio).HasColumnName("ABRIL_INICIO");

                entity.Property(e => e.AbrilSalidas).HasColumnName("ABRIL_SALIDAS");

                entity.Property(e => e.AgoEntradas).HasColumnName("AGO_ENTRADAS");

                entity.Property(e => e.AgoFinal).HasColumnName("AGO_FINAL");

                entity.Property(e => e.AgoInicio).HasColumnName("AGO_INICIO");

                entity.Property(e => e.AgoSalidas).HasColumnName("AGO_SALIDAS");

                entity.Property(e => e.DescripcionGen)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION_GEN")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Desctipopapel)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("DESCTIPOPAPEL")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DicEntradas).HasColumnName("DIC_ENTRADAS");

                entity.Property(e => e.DicFinal).HasColumnName("DIC_FINAL");

                entity.Property(e => e.DicInicio).HasColumnName("DIC_INICIO");

                entity.Property(e => e.DicSalidas).HasColumnName("DIC_SALIDAS");

                entity.Property(e => e.EneEntradas).HasColumnName("ENE_ENTRADAS");

                entity.Property(e => e.EneFinal).HasColumnName("ENE_FINAL");

                entity.Property(e => e.EneInicio).HasColumnName("ENE_INICIO");

                entity.Property(e => e.EneSalidas).HasColumnName("ENE_SALIDAS");

                entity.Property(e => e.FebEntradas).HasColumnName("FEB_ENTRADAS");

                entity.Property(e => e.FebFinal).HasColumnName("FEB_FINAL");

                entity.Property(e => e.FebInicio).HasColumnName("FEB_INICIO");

                entity.Property(e => e.FebSalidas).HasColumnName("FEB_SALIDAS");

                entity.Property(e => e.GeneroPapel)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GENERO_PAPEL")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.JulFinal).HasColumnName("JUL_FINAL");

                entity.Property(e => e.JulioEntradas).HasColumnName("JULIO_ENTRADAS");

                entity.Property(e => e.JulioInicio).HasColumnName("JULIO_INICIO");

                entity.Property(e => e.JulioSalidas).HasColumnName("JULIO_SALIDAS");

                entity.Property(e => e.JunioEntradas).HasColumnName("JUNIO_ENTRADAS");

                entity.Property(e => e.JunioFinal).HasColumnName("JUNIO_FINAL");

                entity.Property(e => e.JunioInicio).HasColumnName("JUNIO_INICIO");

                entity.Property(e => e.JunioSalidas).HasColumnName("JUNIO_SALIDAS");

                entity.Property(e => e.MarEntradas).HasColumnName("MAR_ENTRADAS");

                entity.Property(e => e.MarFinal).HasColumnName("MAR_FINAL");

                entity.Property(e => e.MarInicio).HasColumnName("MAR_INICIO");

                entity.Property(e => e.MarSalidas).HasColumnName("MAR_SALIDAS");

                entity.Property(e => e.MayoEntradas).HasColumnName("MAYO_ENTRADAS");

                entity.Property(e => e.MayoFinal).HasColumnName("MAYO_FINAL");

                entity.Property(e => e.MayoInicio).HasColumnName("MAYO_INICIO");

                entity.Property(e => e.MayoSalidas).HasColumnName("MAYO_SALIDAS");

                entity.Property(e => e.NovEntradas).HasColumnName("NOV_ENTRADAS");

                entity.Property(e => e.NovFinal).HasColumnName("NOV_FINAL");

                entity.Property(e => e.NovInicio).HasColumnName("NOV_INICIO");

                entity.Property(e => e.NovSalidas).HasColumnName("NOV_SALIDAS");

                entity.Property(e => e.OctEntradas).HasColumnName("OCT_ENTRADAS");

                entity.Property(e => e.OctFinal).HasColumnName("OCT_FINAL");

                entity.Property(e => e.OctInicio).HasColumnName("OCT_INICIO");

                entity.Property(e => e.OctSalidas).HasColumnName("OCT_SALIDAS");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.SepEntradas).HasColumnName("SEP_ENTRADAS");

                entity.Property(e => e.SepFinal).HasColumnName("SEP_FINAL");

                entity.Property(e => e.SepInicio).HasColumnName("SEP_INICIO");

                entity.Property(e => e.SepSalidas).HasColumnName("SEP_SALIDAS");

                entity.Property(e => e.TipoPapel)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_PAPEL")
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Wimy027>(entity =>
            {
                entity.HasKey(e => new { e.Orden, e.Recnum })
                    .HasName("WIMY027_INDEX01");

                entity.ToTable("WIMY027");

                entity.HasIndex(e => e.Recnum, "WIMY027_INDEX00")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.KilosAsignados).HasColumnName("KILOS_ASIGNADOS");

                entity.Property(e => e.KilosConsumido).HasColumnName("KILOS_CONSUMIDO");

                entity.Property(e => e.Rollo).HasColumnName("ROLLO");
            });

            modelBuilder.Entity<Wimy028>(entity =>
            {
                entity.HasKey(e => e.Recnum)
                    .HasName("WIMY028_INDEX00");

                entity.ToTable("WIMY028");

                entity.HasIndex(e => e.Orden, "dep_wimy028orden");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.AloContable).HasColumnName("ALO_CONTABLE");

                entity.Property(e => e.Ancho)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANCHO");

                entity.Property(e => e.AsigDocket).HasColumnName("ASIG_DOCKET");

                entity.Property(e => e.Bobina).HasColumnName("BOBINA");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.CausaAjuste).HasColumnName("CAUSA_AJUSTE");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("COLOR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CostoFactura)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("COSTO_FACTURA");

                entity.Property(e => e.Diametro).HasColumnName("DIAMETRO");

                entity.Property(e => e.ES)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("E_S")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Feccon)
                    .HasColumnType("datetime")
                    .HasColumnName("FECCON");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_CREACION");

                entity.Property(e => e.FechaTransac)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_TRANSAC");

                entity.Property(e => e.Fecrec)
                    .HasColumnType("datetime")
                    .HasColumnName("FECREC");

                entity.Property(e => e.Gramaje)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("GRAMAJE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Listar)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("LISTAR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.LoteProveedor)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("LOTE_PROVEEDOR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.MesContable).HasColumnName("MES_CONTABLE");

                entity.Property(e => e.Nrfact).HasColumnName("NRFACT");

                entity.Property(e => e.Nrnotaentrega).HasColumnName("NRNOTAENTREGA");

                entity.Property(e => e.NroReporte).HasColumnName("NRO_REPORTE");

                entity.Property(e => e.Nroir).HasColumnName("NROIR");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.OrdenCompra).HasColumnName("ORDEN_COMPRA");

                entity.Property(e => e.PasoSql)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PASO_SQL")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Proveedor).HasColumnName("PROVEEDOR");

                entity.Property(e => e.Rollo).HasColumnName("ROLLO");

                entity.Property(e => e.TipoPapel)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_PAPEL")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Transaccion)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("TRANSACCION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Ubicacion)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UBICACION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Unidad)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("UNIDAD")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO")
                    .HasDefaultValueSql("(' ')");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
