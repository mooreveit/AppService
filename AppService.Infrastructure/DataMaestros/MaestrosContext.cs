using System;
using AppService.Core.EntitiesMaestros;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AppService.Infrastructure.DataMaestros
{
    public partial class IMaestrosContext : DbContext
    {
        public IMaestrosContext()
        {
        }

        public IMaestrosContext(DbContextOptions<IMaestrosContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Almacenes> Almacenes { get; set; }
        public virtual DbSet<Celular> Celular { get; set; }
        public virtual DbSet<Ciudades> Ciudades { get; set; }
        public virtual DbSet<Ciudadesold> Ciudadesold { get; set; }
        public virtual DbSet<Ciudadeswivy005> Ciudadeswivy005 { get; set; }
        public virtual DbSet<Ciudadweb> Ciudadweb { get; set; }
        public virtual DbSet<Civy004> Civy004 { get; set; }
        public virtual DbSet<Civy004Csmy036> Civy004Csmy036 { get; set; }
        public virtual DbSet<Civy004web> Civy004web { get; set; }
        public virtual DbSet<Civy004web2> Civy004web2 { get; set; }
        public virtual DbSet<Civy023> Civy023 { get; set; }
        public virtual DbSet<Civy023a> Civy023a { get; set; }
        public virtual DbSet<Civy023c> Civy023c { get; set; }
        public virtual DbSet<ComparativoCsmy005Maracay> ComparativoCsmy005Maracay { get; set; }
        public virtual DbSet<ConsultaCivy023> ConsultaCivy023 { get; set; }
        public virtual DbSet<ConsultaWivy003> ConsultaWivy003 { get; set; }
        public virtual DbSet<CopiaCsmy005> CopiaCsmy005 { get; set; }
        public virtual DbSet<Csmy005> Csmy005 { get; set; }
        public virtual DbSet<Csmy036> Csmy036 { get; set; }
        public virtual DbSet<Csmy036bketiqueta> Csmy036bketiqueta { get; set; }
        public virtual DbSet<Csmy036c> Csmy036c { get; set; }
        public virtual DbSet<Csmy036web> Csmy036web { get; set; }
        public virtual DbSet<Csmy037> Csmy037 { get; set; }
        public virtual DbSet<Csmy038> Csmy038 { get; set; }
        public virtual DbSet<Csmy074> Csmy074 { get; set; }
        public virtual DbSet<Csmy075> Csmy075 { get; set; }
        public virtual DbSet<Email> Email { get; set; }
        public virtual DbSet<Emailhistorico> Emailhistorico { get; set; }
        public virtual DbSet<Estadosweb> Estadosweb { get; set; }
        public virtual DbSet<F0006> F0006 { get; set; }
        public virtual DbSet<F0101> F0101 { get; set; }
        public virtual DbSet<F0401> F0401 { get; set; }
        public virtual DbSet<FechaVigenciaCivy023> FechaVigenciaCivy023 { get; set; }
        public virtual DbSet<GerenteOfic> GerenteOfic { get; set; }
        public virtual DbSet<Kilos> Kilos { get; set; }
        public virtual DbSet<Listado> Listado { get; set; }
        public virtual DbSet<Municipiosweb> Municipiosweb { get; set; }
        public virtual DbSet<Ordenesdepuradas> Ordenesdepuradas { get; set; }
        public virtual DbSet<Passeproveedores> Passeproveedores { get; set; }
        public virtual DbSet<Printers> Printers { get; set; }
        public virtual DbSet<ProdStock> ProdStock { get; set; }
        public virtual DbSet<Productos> Productos { get; set; }
        public virtual DbSet<PromedioDelDolarPorMes> PromedioDelDolarPorMes { get; set; }
        public virtual DbSet<Proveedores> Proveedores { get; set; }
        public virtual DbSet<Prueba> Prueba { get; set; }
        public virtual DbSet<QueryCsmy03601> QueryCsmy03601 { get; set; }
        public virtual DbSet<Rutas> Rutas { get; set; }
        public virtual DbSet<SectorWeb> SectorWeb { get; set; }
        public virtual DbSet<Supervisor> Supervisor { get; set; }
        public virtual DbSet<Sysfile> Sysfile { get; set; }
        public virtual DbSet<Tasadolar> Tasadolar { get; set; }
        public virtual DbSet<Tasadolarstock> Tasadolarstock { get; set; }
        public virtual DbSet<TipoProducto> TipoProducto { get; set; }
        public virtual DbSet<TipoProductofr> TipoProductofr { get; set; }
        public virtual DbSet<VDiccionariomaestros> VDiccionariomaestros { get; set; }
        public virtual DbSet<VEmail> VEmail { get; set; }
        public virtual DbSet<VF47122> VF47122 { get; set; }
        public virtual DbSet<VInvetarioReconversion> VInvetarioReconversion { get; set; }
        public virtual DbSet<VProductos> VProductos { get; set; }
        public virtual DbSet<Vendjde> Vendjde { get; set; }
        public virtual DbSet<Vistaclientesweb> Vistaclientesweb { get; set; }
        public virtual DbSet<Wary008> Wary008 { get; set; }
        public virtual DbSet<Wary011> Wary011 { get; set; }
        public virtual DbSet<Wary041> Wary041 { get; set; }
        public virtual DbSet<Wary088> Wary088 { get; set; }
        public virtual DbSet<Wary089> Wary089 { get; set; }
        public virtual DbSet<Wary091> Wary091 { get; set; }
        public virtual DbSet<Winy030> Winy030 { get; set; }
        public virtual DbSet<Wivy001> Wivy001 { get; set; }
        public virtual DbSet<Wivy001audi> Wivy001audi { get; set; }
        public virtual DbSet<Wivy002> Wivy002 { get; set; }
        public virtual DbSet<Wivy003> Wivy003 { get; set; }
        public virtual DbSet<Wivy005> Wivy005 { get; set; }
        public virtual DbSet<Wivy006> Wivy006 { get; set; }
        public virtual DbSet<Wivy007> Wivy007 { get; set; }
        public virtual DbSet<Wivy008> Wivy008 { get; set; }
        public virtual DbSet<Wivy009> Wivy009 { get; set; }
        public virtual DbSet<Wivy010> Wivy010 { get; set; }
        public virtual DbSet<Wivy011> Wivy011 { get; set; }
        public virtual DbSet<Wivy012> Wivy012 { get; set; }
        public virtual DbSet<Wivy013> Wivy013 { get; set; }
        public virtual DbSet<Wivy015> Wivy015 { get; set; }
        public virtual DbSet<Wivy016> Wivy016 { get; set; }
        public virtual DbSet<Wivy019> Wivy019 { get; set; }
        public virtual DbSet<Wivy020> Wivy020 { get; set; }
        public virtual DbSet<Wivy021> Wivy021 { get; set; }
        public virtual DbSet<Wivy026> Wivy026 { get; set; }
        public virtual DbSet<Wivy027> Wivy027 { get; set; }
        public virtual DbSet<Wivy030> Wivy030 { get; set; }
        public virtual DbSet<Wivy030bk> Wivy030bk { get; set; }
        public virtual DbSet<Wivy031> Wivy031 { get; set; }
        public virtual DbSet<Wivy031bk> Wivy031bk { get; set; }
        public virtual DbSet<Wivy035> Wivy035 { get; set; }
        public virtual DbSet<Wivy044> Wivy044 { get; set; }
        public virtual DbSet<Wivy045> Wivy045 { get; set; }
        public virtual DbSet<Wivy045bk> Wivy045bk { get; set; }
        public virtual DbSet<Woey079> Woey079 { get; set; }
        public virtual DbSet<Wppy001> Wppy001 { get; set; }
        public virtual DbSet<Wppy002> Wppy002 { get; set; }
        public virtual DbSet<Wppy003> Wppy003 { get; set; }
        public virtual DbSet<Wppy007> Wppy007 { get; set; }
        public virtual DbSet<Wppy010> Wppy010 { get; set; }
        public virtual DbSet<Wppy022> Wppy022 { get; set; }
        public virtual DbSet<Wsmy003> Wsmy003 { get; set; }
        public virtual DbSet<Wsmy006> Wsmy006 { get; set; }
        public virtual DbSet<Wsmy060> Wsmy060 { get; set; }
        public virtual DbSet<Wsmy063> Wsmy063 { get; set; }
        public virtual DbSet<Wsmy123> Wsmy123 { get; set; }
        public virtual DbSet<Wsmy177> Wsmy177 { get; set; }
        public virtual DbSet<Wsmy273> Wsmy273 { get; set; }
        public virtual DbSet<Wsmy281> Wsmy281 { get; set; }
        public virtual DbSet<Wssy030> Wssy030 { get; set; }
        public virtual DbSet<Wssy031> Wssy031 { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=.;Database=Maestros;User Id=userweb;Password=userweb2003;MultipleActiveResultSets=true");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Almacenes>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ALMACENES");

                entity.HasIndex(e => e.Almacen)
                    .HasName("IX_ALMACENES");

                entity.Property(e => e.AfectaMargen)
                    .HasColumnName("Afecta_margen")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Almacen)
                    .HasColumnName("ALMACEN")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.AlmacenExistencia).HasMaxLength(1);

                entity.Property(e => e.Bl)
                    .HasColumnName("BL")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Bodega)
                    .HasColumnName("BODEGA")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasColumnName("TIPO")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Ubicaciones)
                    .HasMaxLength(8000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Celular>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("celular");

                entity.Property(e => e.TlfCelular)
                    .HasColumnName("tlf_celular")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Ciudades>(entity =>
            {
                entity.HasKey(e => e.CodigoCiudad);

                entity.ToTable("CIUDADES");

                entity.Property(e => e.CodigoCiudad)
                    .HasColumnName("CODIGO_CIUDAD")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoEstado)
                    .IsRequired()
                    .HasColumnName("CODIGO_ESTADO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoMcpo)
                    .IsRequired()
                    .HasColumnName("CODIGO_MCPO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Ciudadesold>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CIUDADESOLD");

                entity.Property(e => e.CodigoCiudad)
                    .HasColumnName("CODIGO_CIUDAD")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoMcpo)
                    .HasColumnName("CODIGO_MCPO")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NombreCiudad)
                    .HasColumnName("NOMBRE_CIUDAD")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Ciudadeswivy005>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CIUDADESWIVY005");

                entity.Property(e => e.CodigoCiudad)
                    .HasColumnName("CODIGO_CIUDAD")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoMcpo)
                    .HasColumnName("CODIGO_MCPO")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NombreCiudad)
                    .HasColumnName("NOMBRE_CIUDAD")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Ciudadweb>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Ciudadweb");

                entity.Property(e => e.CodigoCiudad)
                    .HasColumnName("CODIGO_CIUDAD")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoEstado)
                    .HasColumnName("CODIGO_ESTADO")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoMcpo)
                    .HasColumnName("CODIGO_MCPO")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Civy004>(entity =>
            {
                entity.HasKey(e => e.Producto)
                    .HasName("CIVY004_INDEX01");

                entity.ToTable("CIVY004");

                entity.HasIndex(e => e.Recnum)
                    .HasName("CIVY004_INDEX00")
                    .IsUnique();

                entity.HasIndex(e => new { e.Descripcion, e.Producto })
                    .HasName("CIVY004_INDEX04")
                    .IsUnique();

                entity.HasIndex(e => new { e.OrigenProducto, e.Producto })
                    .HasName("CIVY004_INDEX05")
                    .IsUnique();

                entity.HasIndex(e => new { e.TipoProducto, e.Producto })
                    .HasName("CIVY004_INDEX02")
                    .IsUnique();

                entity.HasIndex(e => new { e.LineaProducto, e.FamiliaProduct, e.Producto })
                    .HasName("CIVY004_INDEX03")
                    .IsUnique();

                entity.Property(e => e.Producto)
                    .HasColumnName("PRODUCTO")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CantidadXCaja)
                    .HasColumnName("CANTIDAD_X_CAJA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CodJde)
                    .HasColumnName("COD_JDE")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Comprometido)
                    .HasColumnName("COMPROMETIDO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CosPromActual)
                    .HasColumnName("COS_PROM_ACTUAL")
                    .HasColumnType("decimal(12, 4)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CostPromDolar)
                    .HasColumnName("COST_PROM_DOLAR")
                    .HasColumnType("decimal(12, 4)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Costo).HasColumnType("numeric(13, 2)");

                entity.Property(e => e.CostoPromFin)
                    .HasColumnName("COSTO_PROM_FIN")
                    .HasColumnType("decimal(12, 4)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CostoPromIni)
                    .HasColumnName("COSTO_PROM_INI")
                    .HasColumnType("decimal(12, 4)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CostoPromReva)
                    .HasColumnName("COSTO_PROM_REVA")
                    .HasColumnType("decimal(12, 4)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CostoSap).HasColumnType("numeric(13, 2)");

                entity.Property(e => e.CtdMaximaVta)
                    .HasColumnName("CTD_MAXIMA_VTA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CuentaInv)
                    .HasColumnName("CUENTA_INV")
                    .HasColumnType("decimal(16, 6)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CuentaVar)
                    .HasColumnName("CUENTA_VAR")
                    .HasColumnType("decimal(16, 6)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DiasEntrega)
                    .HasColumnName("DIAS_ENTREGA")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Eliminado)
                    .IsRequired()
                    .HasColumnName("ELIMINADO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Estimado)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ExiInicioMes)
                    .HasColumnName("EXI_INICIO_MES")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ExisDiaAnter)
                    .HasColumnName("EXIS_DIA_ANTER")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ExisFinMes)
                    .HasColumnName("EXIS_FIN_MES")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ExistActual)
                    .HasColumnName("EXIST_ACTUAL")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ExistMaxima)
                    .HasColumnName("EXIST_MAXIMA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ExistMinima)
                    .HasColumnName("EXIST_MINIMA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.FamiliaProduct)
                    .IsRequired()
                    .HasColumnName("FAMILIA_PRODUCT")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FechaListaPrecio).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaUltCompr)
                    .HasColumnName("FECHA_ULT_COMPR")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaUltFact)
                    .HasColumnName("FECHA_ULT_FACT")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlagObsoleto)
                    .IsRequired()
                    .HasColumnName("FLAG_OBSOLETO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.IdSolicitudCosto).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdSolicitudCostoMaximo).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdSolicitudCostoMinimo).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdSolicitudCostoPromedio).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdSolicitudCostoSap).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ImpPorConsumo)
                    .IsRequired()
                    .HasColumnName("IMP_POR_CONSUMO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.KilosPorEmpaq)
                    .HasColumnName("KILOS_POR_EMPAQ")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LineaProducto)
                    .IsRequired()
                    .HasColumnName("LINEA_PRODUCTO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ListFinMes)
                    .HasColumnName("LIST_FIN_MES")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ListInicioMes)
                    .HasColumnName("LIST_INICIO_MES")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ManejaInv)
                    .HasColumnName("MANEJA_INV")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Medida)
                    .IsRequired()
                    .HasColumnName("MEDIDA")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.MetodoPrecio)
                    .IsRequired()
                    .HasColumnName("METODO_PRECIO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.OrigenProducto)
                    .IsRequired()
                    .HasColumnName("ORIGEN_PRODUCTO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.OtroFactor)
                    .HasColumnName("OTRO_FACTOR")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Partes)
                    .HasColumnName("PARTES")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Pies2Catalogo).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PorcCosto)
                    .HasColumnName("PORC_COSTO")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PorcDescuentoMrStock).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PorcListaMrStock).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PorcMarkup)
                    .HasColumnName("PORC_MARKUP")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PreListActual)
                    .HasColumnName("PRE_LIST_ACTUAL")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PrecioMaximoUnidad)
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PrecioMinimoUnidad)
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PrecioSugerido)
                    .IsRequired()
                    .HasColumnName("PRECIO_SUGERIDO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Proveedor)
                    .HasColumnName("PROVEEDOR")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PtoReorden)
                    .HasColumnName("PTO_REORDEN")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RetenerCredito)
                    .HasColumnName("RETENER_CREDITO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SalidaPendien)
                    .HasColumnName("SALIDA_PENDIEN")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TipoPapel)
                    .IsRequired()
                    .HasColumnName("TIPO_PAPEL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TipoProducto)
                    .IsRequired()
                    .HasColumnName("TIPO_PRODUCTO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.UnidadCosteo)
                    .HasColumnName("UNIDAD_COSTEO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Unidadesxbulto)
                    .HasColumnName("UNIDADESXBULTO")
                    .HasColumnType("decimal(14, 0)");

                entity.Property(e => e.ValExisActual)
                    .HasColumnName("VAL_EXIS_ACTUAL")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValFinMes)
                    .HasColumnName("VAL_FIN_MES")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValInicioMes)
                    .HasColumnName("VAL_INICIO_MES")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<Civy004Csmy036>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Civy004_Csmy036");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FamiliaProduct)
                    .HasColumnName("FAMILIA_PRODUCT")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LineaIncoming)
                    .HasColumnName("LINEA_INCOMING")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.LineaProducto)
                    .HasColumnName("LINEA_PRODUCTO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Medida)
                    .HasColumnName("MEDIDA")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrigenProducto)
                    .HasColumnName("ORIGEN_PRODUCTO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Producto)
                    .HasColumnName("PRODUCTO")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoProducto)
                    .HasColumnName("TIPO_PRODUCTO")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.UnidadCosteo)
                    .HasColumnName("UNIDAD_COSTEO")
                    .HasColumnType("numeric(2, 0)");
            });

            modelBuilder.Entity<Civy004web>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CIVY004WEB");

                entity.Property(e => e.CantidadXCaja).HasColumnName("CANTIDAD_X_CAJA");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Eliminado)
                    .IsRequired()
                    .HasColumnName("ELIMINADO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LineaProducto)
                    .IsRequired()
                    .HasColumnName("LINEA_PRODUCTO")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Medida)
                    .IsRequired()
                    .HasColumnName("MEDIDA")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PreListActual)
                    .HasColumnName("PRE_LIST_ACTUAL")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Producto)
                    .HasColumnName("PRODUCTO")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.TipoProducto)
                    .IsRequired()
                    .HasColumnName("TIPO_PRODUCTO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UnidadCosteo).HasColumnName("UNIDAD_COSTEO");
            });

            modelBuilder.Entity<Civy004web2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CIVY004WEB2");

                entity.Property(e => e.CantidadXCaja).HasColumnName("CANTIDAD_X_CAJA");

                entity.Property(e => e.CodResponsable).HasColumnName("COD_RESPONSABLE");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Eliminado)
                    .IsRequired()
                    .HasColumnName("ELIMINADO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FechaVigencia)
                    .HasColumnName("FECHA_VIGENCIA")
                    .HasColumnType("datetime");

                entity.Property(e => e.LineaProducto)
                    .IsRequired()
                    .HasColumnName("LINEA_PRODUCTO")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Medida)
                    .IsRequired()
                    .HasColumnName("MEDIDA")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PreListActual)
                    .HasColumnName("PRE_LIST_ACTUAL")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PrecLista)
                    .HasColumnName("PREC_LISTA_$")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Producto)
                    .HasColumnName("PRODUCTO")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.TipoProducto)
                    .IsRequired()
                    .HasColumnName("TIPO_PRODUCTO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UnidadCosteo).HasColumnName("UNIDAD_COSTEO");
            });

            modelBuilder.Entity<Civy023>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("civy023");

                entity.Property(e => e.Cant).HasColumnName("CANT");

                entity.Property(e => e.Cant1).HasColumnName("CANT1");

                entity.Property(e => e.Cant2).HasColumnName("CANT2");

                entity.Property(e => e.Cant3).HasColumnName("CANT3");

                entity.Property(e => e.Cant4).HasColumnName("CANT4");

                entity.Property(e => e.Cant5).HasColumnName("CANT5");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasColumnName("CODIGO")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.FechaVigencia)
                    .HasColumnName("FECHA_VIGENCIA")
                    .HasColumnType("datetime");

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

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Civy023a>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CIVY023A");

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

                entity.Property(e => e.RecordNumber).HasColumnName("RECORD_NUMBER");

                entity.Property(e => e.RprecLista)
                    .HasColumnName("RPREC_LISTA")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.RprecLista1)
                    .HasColumnName("RPREC_LISTA1")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.RprecLista2)
                    .HasColumnName("RPREC_LISTA2")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.RprecLista3)
                    .HasColumnName("RPREC_LISTA3")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.RprecLista4)
                    .HasColumnName("RPREC_LISTA4")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.RprecLista5)
                    .HasColumnName("RPREC_LISTA5")
                    .HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<Civy023c>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CIVY023C");

                entity.Property(e => e.Cant)
                    .HasColumnName("CANT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Cant1)
                    .HasColumnName("CANT1")
                    .HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Cant2)
                    .HasColumnName("CANT2")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Cant3)
                    .HasColumnName("CANT3")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Cant4)
                    .HasColumnName("CANT4")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Cant5)
                    .HasColumnName("CANT5")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Cliente)
                    .HasColumnName("CLIENTE")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

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
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PrecLista1)
                    .HasColumnName("PREC_LISTA1")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PrecLista1d)
                    .HasColumnName("PREC_LISTA1D")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PrecLista2)
                    .HasColumnName("PREC_LISTA2")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PrecLista2d)
                    .HasColumnName("PREC_LISTA2D")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PrecLista3)
                    .HasColumnName("PREC_LISTA3")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PrecLista3d)
                    .HasColumnName("PREC_LISTA3D")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PrecLista4)
                    .HasColumnName("PREC_LISTA4")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PrecLista4d)
                    .HasColumnName("PREC_LISTA4D")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PrecLista5)
                    .HasColumnName("PREC_LISTA5")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PrecLista5d)
                    .HasColumnName("PREC_LISTA5D")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PrecListad)
                    .HasColumnName("PREC_LISTAD")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.RecordNumber).HasColumnName("RECORD_NUMBER");

                entity.Property(e => e.Rif)
                    .HasColumnName("RIF")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ComparativoCsmy005Maracay>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("COMPARATIVO_CSMY005_MARACAY");

                entity.Property(e => e.Asignacion)
                    .HasColumnName("ASIGNACION")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AsignacionActual)
                    .HasColumnName("ASIGNACION_ACTUAL")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cobrador)
                    .HasColumnName("COBRADOR")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CobradorActual)
                    .HasColumnName("COBRADOR_ACTUAL")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Codigo)
                    .HasColumnName("CODIGO")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagRetirado)
                    .HasColumnName("FLAG_RETIRADO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

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
            });

            modelBuilder.Entity<ConsultaCivy023>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Consulta CIVY023");

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
                    .IsUnicode(false);

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

            modelBuilder.Entity<ConsultaWivy003>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CONSULTA_WIVY003");

                entity.Property(e => e.Codigo)
                    .HasColumnName("CODIGO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CopiaCsmy005>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("copia_CSMY005");

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

                entity.Property(e => e.Categoria)
                    .HasColumnName("CATEGORIA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClaseVendedor)
                    .HasColumnName("CLASE_VENDEDOR")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Club300Asistid)
                    .HasColumnName("CLUB300_ASISTID")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Cobrador)
                    .HasColumnName("COBRADOR")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodDivision)
                    .HasColumnName("COD_DIVISION")
                    .HasColumnType("decimal(2, 0)");

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

                entity.Property(e => e.CodigoOverride)
                    .HasColumnName("CODIGO_OVERRIDE")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.CodigoRegion)
                    .HasColumnName("CODIGO_REGION")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Comision)
                    .HasColumnName("COMISION")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ComisionComprd)
                    .HasColumnName("COMISION_COMPRD")
                    .HasColumnType("decimal(4, 2)");

                entity.Property(e => e.ComisionFactur)
                    .HasColumnName("COMISION_FACTUR")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ComisionImpres)
                    .HasColumnName("COMISION_IMPRES")
                    .HasColumnType("decimal(4, 2)");

                entity.Property(e => e.ComisionOrden)
                    .HasColumnName("COMISION_ORDEN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ComisionServ)
                    .HasColumnName("COMISION_SERV")
                    .HasColumnType("decimal(4, 2)");

                entity.Property(e => e.ComisionStock)
                    .HasColumnName("COMISION_STOCK")
                    .HasColumnType("decimal(4, 2)");

                entity.Property(e => e.CompanyBeeper)
                    .HasColumnName("COMPANY_BEEPER")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.Consecutivo)
                    .HasColumnName("CONSECUTIVO")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.CotCorrelativo)
                    .HasColumnName("COT_CORRELATIVO")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.EMail)
                    .HasColumnName("E_MAIL")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ExtTelefonica)
                    .HasColumnName("EXT_TELEFONICA")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.FechaRetiro)
                    .HasColumnName("FECHA_RETIRO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Ficha)
                    .HasColumnName("FICHA")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagCambio)
                    .HasColumnName("FLAG_CAMBIO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagDeGerente)
                    .HasColumnName("FLAG_DE_GERENTE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagGerenteOf)
                    .HasColumnName("FLAG_GERENTE_OF")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagReplicar)
                    .HasColumnName("FLAG_REPLICAR")
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

                entity.Property(e => e.GerenteOficina)
                    .HasColumnName("GERENTE_OFICINA")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GerenteRegion)
                    .HasColumnName("GERENTE_REGION")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Grupo)
                    .HasColumnName("GRUPO")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.NombAbreviado)
                    .HasColumnName("NOMB_ABREVIADO")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NroDeClientes)
                    .HasColumnName("NRO_DE_CLIENTES")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.NroVendedor)
                    .HasColumnName("NRO_VENDEDOR")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.Oficina)
                    .HasColumnName("OFICINA")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrdenRep)
                    .HasColumnName("ORDEN_REP")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.Ordenado)
                    .HasColumnName("ORDENADO")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Override)
                    .HasColumnName("OVERRIDE")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Pais)
                    .HasColumnName("PAIS")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Password)
                    .HasColumnName("@PASSWORD")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Pedido)
                    .HasColumnName("PEDIDO")
                    .HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Posicion)
                    .HasColumnName("POSICION")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.PuntosDelClub)
                    .HasColumnName("PUNTOS_DEL_CLUB")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.RecordNumber).HasColumnName("RECORD_NUMBER");

                entity.Property(e => e.Rowguid).HasColumnName("rowguid");

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

                entity.Property(e => e.UnidadBeeper)
                    .HasColumnName("UNIDAD_BEEPER")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Usuario)
                    .HasColumnName("USUARIO")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Csmy005>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("CSMY005_INDEX01");

                entity.ToTable("CSMY005");

                entity.HasIndex(e => e.Cobrador)
                    .HasName("IX_CSMY005")
                    .IsUnique();

                entity.HasIndex(e => e.Recnum)
                    .HasName("CSMY005_INDEX00")
                    .IsUnique();

                entity.HasIndex(e => new { e.Nombre, e.Codigo })
                    .HasName("CSMY005_INDEX05")
                    .IsUnique();

                entity.HasIndex(e => new { e.Supervisor, e.Codigo })
                    .HasName("CSMY005_INDEX02")
                    .IsUnique();

                entity.HasIndex(e => new { e.Nombre, e.Oficina, e.Codigo })
                    .HasName("_dta_index_CSMY005_32_585769144__K2_3_38");

                entity.HasIndex(e => new { e.Grupo, e.OrdenRep, e.Posicion, e.Codigo })
                    .HasName("CSMY005_INDEX04")
                    .IsUnique();

                entity.Property(e => e.Codigo)
                    .HasColumnName("CODIGO")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Activo)
                    .IsRequired()
                    .HasColumnName("ACTIVO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.An8).HasColumnName("AN8");

                entity.Property(e => e.Asignacion)
                    .IsRequired()
                    .HasColumnName("ASIGNACION")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Categoria)
                    .IsRequired()
                    .HasColumnName("CATEGORIA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ClaseVendedor).HasColumnName("CLASE_VENDEDOR");

                entity.Property(e => e.Club300Asistid).HasColumnName("CLUB300_ASISTID");

                entity.Property(e => e.Cobrador)
                    .IsRequired()
                    .HasColumnName("COBRADOR")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CodDivision).HasColumnName("COD_DIVISION");

                entity.Property(e => e.CodigoGrupo)
                    .IsRequired()
                    .HasColumnName("CODIGO_GRUPO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CodigoOverride).HasColumnName("CODIGO_OVERRIDE");

                entity.Property(e => e.CodigoRegion)
                    .IsRequired()
                    .HasColumnName("CODIGO_REGION")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Comision)
                    .HasColumnName("COMISION")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ComisionComprd)
                    .HasColumnName("COMISION_COMPRD")
                    .HasColumnType("decimal(4, 2)");

                entity.Property(e => e.ComisionFactur)
                    .IsRequired()
                    .HasColumnName("COMISION_FACTUR")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ComisionImpres)
                    .HasColumnName("COMISION_IMPRES")
                    .HasColumnType("decimal(4, 2)");

                entity.Property(e => e.ComisionOrden)
                    .IsRequired()
                    .HasColumnName("COMISION_ORDEN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ComisionServ)
                    .HasColumnName("COMISION_SERV")
                    .HasColumnType("decimal(4, 2)");

                entity.Property(e => e.ComisionStock)
                    .HasColumnName("COMISION_STOCK")
                    .HasColumnType("decimal(4, 2)");

                entity.Property(e => e.CompanyBeeper).HasColumnName("COMPANY_BEEPER");

                entity.Property(e => e.Consecutivo).HasColumnName("CONSECUTIVO");

                entity.Property(e => e.CotCorrelativo).HasColumnName("COT_CORRELATIVO");

                entity.Property(e => e.CotizadorPlus).HasMaxLength(1);

                entity.Property(e => e.EMail)
                    .IsRequired()
                    .HasColumnName("E_MAIL")
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ExtTelefonica).HasColumnName("EXT_TELEFONICA");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnName("FECHA_INGRESO")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaRetiro)
                    .HasColumnName("FECHA_RETIRO")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ficha)
                    .IsRequired()
                    .HasColumnName("FICHA")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagAdmin)
                    .HasColumnName("FLAG_ADMIN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('X')")
                    .HasComment("INDICADOR RETENCIÓN OBLIGADA EN ESTACIÓN DE LA ADMINISTRADORA");

                entity.Property(e => e.FlagCalculo)
                    .HasColumnName("FLAG_CALCULO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('X')")
                    .HasComment("IDENTIFICADOR RETENCIÓN OBLIGADA EN ESTACIÓN DE CALCULO");

                entity.Property(e => e.FlagCambio)
                    .IsRequired()
                    .HasColumnName("FLAG_CAMBIO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagDeGerente)
                    .IsRequired()
                    .HasColumnName("FLAG_DE_GERENTE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagForaneo)
                    .HasColumnName("FLAG_FORANEO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FlagGerenteOf)
                    .IsRequired()
                    .HasColumnName("FLAG_GERENTE_OF")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagIc)
                    .HasColumnName("FLAG_IC")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("IDENTIFICACIÓN DE VENDEDORES IC");

                entity.Property(e => e.FlagReplicar)
                    .IsRequired()
                    .HasColumnName("FLAG_REPLICAR")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagRetirado)
                    .IsRequired()
                    .HasColumnName("FLAG_RETIRADO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagRevisar)
                    .HasColumnName("FLAG_REVISAR")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagSupervisor)
                    .IsRequired()
                    .HasColumnName("FLAG_SUPERVISOR")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FreeLance)
                    .IsRequired()
                    .HasColumnName("FREE_LANCE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Garantia)
                    .IsRequired()
                    .HasColumnName("GARANTIA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.GerenteOficina)
                    .IsRequired()
                    .HasColumnName("GERENTE_OFICINA")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.GerenteRegion)
                    .IsRequired()
                    .HasColumnName("GERENTE_REGION")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Grupo).HasColumnName("GRUPO");

                entity.Property(e => e.GrupoVendedoresSap).HasMaxLength(3);

                entity.Property(e => e.IdOficinaFisica).HasMaxLength(2);

                entity.Property(e => e.IdOficinaMixProduct).HasMaxLength(4);

                entity.Property(e => e.NombAbreviado)
                    .IsRequired()
                    .HasColumnName("NOMB_ABREVIADO")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NroDeClientes).HasColumnName("NRO_DE_CLIENTES");

                entity.Property(e => e.NroVendedor).HasColumnName("NRO_VENDEDOR");

                entity.Property(e => e.OfiRefer)
                    .HasColumnName("OFI_REFER")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Oficina)
                    .IsRequired()
                    .HasColumnName("OFICINA")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.OrdenRep).HasColumnName("ORDEN_REP");

                entity.Property(e => e.Ordenado).HasColumnName("ORDENADO");

                entity.Property(e => e.Override)
                    .HasColumnName("OVERRIDE")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Pais).HasColumnName("PAIS");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("@PASSWORD")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Pedido).HasColumnName("PEDIDO");

                entity.Property(e => e.Posicion).HasColumnName("POSICION");

                entity.Property(e => e.ProduccionInterna)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PuntosDelClub).HasColumnName("PUNTOS_DEL_CLUB");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Supervisor)
                    .IsRequired()
                    .HasColumnName("SUPERVISOR")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TlfCelular)
                    .IsRequired()
                    .HasColumnName("TLF_CELULAR")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TlfCelularold)
                    .HasColumnName("TLF_CELULAROld")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UnidadBeeper)
                    .IsRequired()
                    .HasColumnName("UNIDAD_BEEPER")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasColumnName("USUARIO")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Csmy036>(entity =>
            {
                entity.HasKey(e => e.CodigoProduct)
                    .HasName("CSMY036_INDEX01");

                entity.ToTable("CSMY036");

                entity.HasIndex(e => e.Idsubcategoria)
                    .HasName("IX_CSMY036");

                entity.HasIndex(e => e.Recnum)
                    .HasName("CSMY036_INDEX00")
                    .IsUnique();

                entity.HasIndex(e => new { e.Nombre, e.Recnum })
                    .HasName("CSMY036_INDEX02")
                    .IsUnique();

                entity.Property(e => e.CodigoProduct)
                    .HasColumnName("CODIGO_PRODUCT")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Almacensap)
                    .HasColumnName("ALMACENSAP")
                    .HasMaxLength(4);

                entity.Property(e => e.CantidadXAnch).HasColumnName("CANTIDAD_X_ANCH");

                entity.Property(e => e.CategoriaDashBoard)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CodJde)
                    .HasColumnName("COD_JDE")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CodResponsable)
                    .HasColumnName("COD_RESPONSABLE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Codcorp)
                    .HasColumnName("CODCORP")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoCaja)
                    .HasMaxLength(6)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodprodRpg)
                    .HasColumnName("CODPROD_RPG")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Consecutivo)
                    .HasColumnName("consecutivo")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ConsecutivoTemporal)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CostoReposicion)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DescripVta)
                    .HasColumnName("DESCRIP_VTA")
                    .HasColumnType("text");

                entity.Property(e => e.DescripcionVentas).HasMaxLength(1000);

                entity.Property(e => e.FamiliaProduct)
                    .HasColumnName("FAMILIA_PRODUCT")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagCorp)
                    .HasColumnName("FLAG_CORP")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagCortoTiraje)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FlagDesact)
                    .HasColumnName("FLAG_DESACT")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagPrdIntern)
                    .HasColumnName("FLAG_PRD_INTERN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagPrecioMinimo).HasMaxLength(1);

                entity.Property(e => e.FlagRollo)
                    .HasColumnName("FLAG_ROLLO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Idsubcategoria)
                    .HasColumnName("IDSUBCATEGORIA")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.ImpPorConsumo)
                    .HasColumnName("IMP_POR_CONSUMO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LineaIncoming).HasColumnName("LINEA_INCOMING");

                entity.Property(e => e.LineaProducto)
                    .HasColumnName("LINEA_PRODUCTO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ManejaInv)
                    .HasColumnName("MANEJA_INV")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Miscelaneo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(65)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Numero).HasColumnName("NUMERO");

                entity.Property(e => e.PesoKilos)
                    .HasColumnType("decimal(7, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PiesCuadradoUnidad).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PorcCosto).HasColumnName("PORC_COSTO");

                entity.Property(e => e.PorcMcAprob)
                    .HasColumnName("PORC_MC_APROB")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Prefijo)
                    .HasColumnName("PREFIJO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PrintNoPrint)
                    .HasColumnName("Print_NoPrint")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Sufijo)
                    .HasColumnName("SUFIJO")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SujetoALote)
                    .HasColumnName("SUJETO_A_LOTE")
                    .HasMaxLength(1);

                entity.Property(e => e.TipoProducto).HasColumnName("TIPO_PRODUCTO");

                entity.Property(e => e.Titulo)
                    .HasColumnName("TITULO")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Titulo1)
                    .HasColumnName("TITULO1")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Titulo2)
                    .HasColumnName("TITULO2")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Titulo3)
                    .HasColumnName("TITULO3")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Titulo4)
                    .HasColumnName("TITULO4")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Titulo5)
                    .HasColumnName("TITULO5")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Titulo6)
                    .HasColumnName("TITULO6")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TituloPe)
                    .HasColumnName("TITULO_PE")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TituloVentas)
                    .HasColumnName("TITULO_VENTAS")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UnidadCosteo).HasColumnName("UNIDAD_COSTEO");

                entity.Property(e => e.Unidadsap)
                    .HasColumnName("UNIDADSAP")
                    .HasMaxLength(3);

                entity.Property(e => e.UnidadsapVenta)
                    .HasColumnName("UNIDADSAP_VENTA")
                    .HasMaxLength(3);

                entity.Property(e => e.UnidadsapVentainterna)
                    .HasColumnName("UNIDADSAP_VENTAINTERNA")
                    .HasMaxLength(3);

                entity.Property(e => e.Web)
                    .HasColumnName("WEB")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Csmy036bketiqueta>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CSMY036BKETIQUETA");

                entity.Property(e => e.Almacensap)
                    .HasColumnName("ALMACENSAP")
                    .HasMaxLength(4);

                entity.Property(e => e.CantidadXAnch).HasColumnName("CANTIDAD_X_ANCH");

                entity.Property(e => e.CategoriaDashBoard)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CodJde)
                    .HasColumnName("COD_JDE")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CodResponsable).HasColumnName("COD_RESPONSABLE");

                entity.Property(e => e.Codcorp)
                    .HasColumnName("CODCORP")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoCaja).HasMaxLength(6);

                entity.Property(e => e.CodigoProduct)
                    .IsRequired()
                    .HasColumnName("CODIGO_PRODUCT")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodprodRpg)
                    .HasColumnName("CODPROD_RPG")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Consecutivo)
                    .HasColumnName("consecutivo")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ConsecutivoTemporal).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CostoReposicion).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DescripVta)
                    .HasColumnName("DESCRIP_VTA")
                    .HasColumnType("text");

                entity.Property(e => e.DescripcionVentas).HasMaxLength(1000);

                entity.Property(e => e.FamiliaProduct)
                    .HasColumnName("FAMILIA_PRODUCT")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagCorp)
                    .HasColumnName("FLAG_CORP")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagCortoTiraje).HasMaxLength(1);

                entity.Property(e => e.FlagDesact)
                    .HasColumnName("FLAG_DESACT")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagPrdIntern)
                    .HasColumnName("FLAG_PRD_INTERN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagPrecioMinimo).HasMaxLength(1);

                entity.Property(e => e.FlagRollo)
                    .HasColumnName("FLAG_ROLLO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Idsubcategoria)
                    .HasColumnName("IDSUBCATEGORIA")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.ImpPorConsumo)
                    .HasColumnName("IMP_POR_CONSUMO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LineaIncoming).HasColumnName("LINEA_INCOMING");

                entity.Property(e => e.LineaProducto)
                    .HasColumnName("LINEA_PRODUCTO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ManejaInv)
                    .HasColumnName("MANEJA_INV")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Miscelaneo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(65)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Numero).HasColumnName("NUMERO");

                entity.Property(e => e.PesoKilos).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.PiesCuadradoUnidad).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PorcCosto).HasColumnName("PORC_COSTO");

                entity.Property(e => e.PorcMcAprob)
                    .HasColumnName("PORC_MC_APROB")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Prefijo)
                    .HasColumnName("PREFIJO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PrintNoPrint)
                    .HasColumnName("Print_NoPrint")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)");

                entity.Property(e => e.Sufijo)
                    .HasColumnName("SUFIJO")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SujetoALote)
                    .HasColumnName("SUJETO_A_LOTE")
                    .HasMaxLength(1);

                entity.Property(e => e.TipoProducto).HasColumnName("TIPO_PRODUCTO");

                entity.Property(e => e.Titulo)
                    .HasColumnName("TITULO")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Titulo1)
                    .HasColumnName("TITULO1")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Titulo2)
                    .HasColumnName("TITULO2")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Titulo3)
                    .HasColumnName("TITULO3")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Titulo4)
                    .HasColumnName("TITULO4")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Titulo5).HasColumnName("TITULO5");

                entity.Property(e => e.Titulo6).HasColumnName("TITULO6");

                entity.Property(e => e.TituloPe)
                    .HasColumnName("TITULO_PE")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TituloVentas)
                    .HasColumnName("TITULO_VENTAS")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UnidadCosteo).HasColumnName("UNIDAD_COSTEO");

                entity.Property(e => e.Unidadsap)
                    .HasColumnName("UNIDADSAP")
                    .HasMaxLength(3);

                entity.Property(e => e.UnidadsapVenta)
                    .HasColumnName("UNIDADSAP_VENTA")
                    .HasMaxLength(3);

                entity.Property(e => e.UnidadsapVentainterna)
                    .HasColumnName("UNIDADSAP_VENTAINTERNA")
                    .HasMaxLength(3);

                entity.Property(e => e.Web)
                    .HasColumnName("WEB")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Csmy036c>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CSMY036C");

                entity.Property(e => e.Cliente).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Flag)
                    .HasColumnName("flag")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Producto)
                    .HasColumnName("producto")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Rif)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Csmy036web>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CSMY036WEB");

                entity.Property(e => e.CantidadXAnch)
                    .HasColumnName("CANTIDAD_X_ANCH")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.Codcorp)
                    .HasColumnName("CODCORP")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoProduct)
                    .HasColumnName("CODIGO_PRODUCT")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CodprodRpg)
                    .HasColumnName("CODPROD_RPG")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DescripVta)
                    .HasColumnName("DESCRIP_VTA")
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FamiliaProduct)
                    .HasColumnName("FAMILIA_PRODUCT")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.FlagCorp)
                    .HasColumnName("FLAG_CORP")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagDesact)
                    .HasColumnName("FLAG_DESACT")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagPrdIntern)
                    .HasColumnName("FLAG_PRD_INTERN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ImpPorConsumo)
                    .HasColumnName("IMP_POR_CONSUMO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LineaIncoming)
                    .HasColumnName("LINEA_INCOMING")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.LineaProducto)
                    .HasColumnName("LINEA_PRODUCTO")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.LineaYFamilia)
                    .HasColumnName("LINEA_Y_FAMILIA")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(65)
                    .IsUnicode(false);

                entity.Property(e => e.Numero)
                    .HasColumnName("NUMERO")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.PorcCosto)
                    .HasColumnName("PORC_COSTO")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.Prefijo)
                    .HasColumnName("PREFIJO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RecordNumber).HasColumnName("RECORD_NUMBER");

                entity.Property(e => e.Rowguid).HasColumnName("rowguid");

                entity.Property(e => e.Sufijo)
                    .HasColumnName("SUFIJO")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoProducto)
                    .HasColumnName("TIPO_PRODUCTO")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.UnidadCosteo)
                    .HasColumnName("UNIDAD_COSTEO")
                    .HasColumnType("numeric(4, 0)");
            });

            modelBuilder.Entity<Csmy037>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("CSMY037_INDEX01");

                entity.ToTable("CSMY037");

                entity.HasIndex(e => e.Recnum)
                    .HasName("CSMY037_INDEX00")
                    .IsUnique();

                entity.Property(e => e.Codigo)
                    .HasColumnName("CODIGO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagModifList)
                    .HasColumnName("FLAG_MODIF_LIST")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Csmy038>(entity =>
            {
                entity.HasKey(e => new { e.Codigo, e.Usuario });

                entity.ToTable("CSMY038");

                entity.Property(e => e.Codigo)
                    .HasColumnName("codigo")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Usuario)
                    .HasColumnName("USUARIO")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Csmy074>(entity =>
            {
                entity.HasKey(e => e.LineaProducto)
                    .HasName("CSMY074_INDEX01");

                entity.ToTable("CSMY074");

                entity.HasIndex(e => e.Recnum)
                    .HasName("CSMY074_INDEX00")
                    .IsUnique();

                entity.HasIndex(e => new { e.Descripcion, e.LineaProducto })
                    .HasName("CSMY074_INDEX02")
                    .IsUnique();

                entity.Property(e => e.LineaProducto)
                    .HasColumnName("LINEA_PRODUCTO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.BencobPorc)
                    .HasColumnName("BENCOB_PORC")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Cpic)
                    .HasColumnName("CPIC")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Cpig)
                    .HasColumnName("CPIG")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Cpnic)
                    .HasColumnName("CPNIC")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Cpnig)
                    .HasColumnName("CPNIG")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CumisupPorc)
                    .HasColumnName("CUMISUP_PORC")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Elpic)
                    .HasColumnName("ELPIC")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Elpig)
                    .HasColumnName("ELPIG")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Elpnic)
                    .HasColumnName("ELPNIC")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Elpnig)
                    .HasColumnName("ELPNIG")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.FechaBencobPo)
                    .HasColumnName("FECHA_BENCOB_PO")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCumisupP)
                    .HasColumnName("FECHA_CUMISUP_P")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaFletePor)
                    .HasColumnName("FECHA_FLETE_POR")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaImpPorc)
                    .HasColumnName("FECHA_IMP_PORC")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaOtros1)
                    .HasColumnName("FECHA_OTROS1")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaOtros2)
                    .HasColumnName("FECHA_OTROS2")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaOtros3)
                    .HasColumnName("FECHA_OTROS3")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaOtros4)
                    .HasColumnName("FECHA_OTROS4")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaRoyPorc)
                    .HasColumnName("FECHA_ROY_PORC")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaRoyalMto)
                    .HasColumnName("FECHA_ROYAL_MTO")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaRoyalPor)
                    .HasColumnName("FECHA_ROYAL_POR")
                    .HasColumnType("datetime");

                entity.Property(e => e.FletePorc)
                    .HasColumnName("FLETE_PORC")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ImpPorc)
                    .HasColumnName("IMP_PORC")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ObsBencobPorc)
                    .IsRequired()
                    .HasColumnName("OBS_BENCOB_PORC")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ObsCumisupPor)
                    .IsRequired()
                    .HasColumnName("OBS_CUMISUP_POR")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ObsFletePorc)
                    .IsRequired()
                    .HasColumnName("OBS_FLETE_PORC")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ObsImpPorc)
                    .IsRequired()
                    .HasColumnName("OBS_IMP_PORC")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ObsOtros1)
                    .IsRequired()
                    .HasColumnName("OBS_OTROS1")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ObsOtros2)
                    .IsRequired()
                    .HasColumnName("OBS_OTROS2")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ObsOtros3)
                    .IsRequired()
                    .HasColumnName("OBS_OTROS3")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ObsOtros4)
                    .IsRequired()
                    .HasColumnName("OBS_OTROS4")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ObsRoyPorc)
                    .IsRequired()
                    .HasColumnName("OBS_ROY_PORC")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ObsRoyalMto)
                    .IsRequired()
                    .HasColumnName("OBS_ROYAL_MTO")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ObsRoyalPorc)
                    .IsRequired()
                    .HasColumnName("OBS_ROYAL_PORC")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Otros1)
                    .HasColumnName("OTROS1")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Otros2)
                    .HasColumnName("OTROS2")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Otros3)
                    .HasColumnName("OTROS3")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Otros4)
                    .HasColumnName("OTROS4")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RoyPorc)
                    .HasColumnName("ROY_PORC")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RoyaltyMonto)
                    .HasColumnName("ROYALTY_MONTO")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RoyaltyPorc)
                    .HasColumnName("ROYALTY_PORC")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<Csmy075>(entity =>
            {
                entity.HasKey(e => new { e.LineaProducto, e.FamiliaProduct })
                    .HasName("CSMY075_INDEX01");

                entity.ToTable("CSMY075");

                entity.HasIndex(e => e.Recnum)
                    .HasName("CSMY075_INDEX00")
                    .IsUnique();

                entity.Property(e => e.LineaProducto)
                    .HasColumnName("LINEA_PRODUCTO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FamiliaProduct)
                    .HasColumnName("FAMILIA_PRODUCT")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PorcPrecInter)
                    .HasColumnName("PORC_PREC_INTER")
                    .HasColumnType("decimal(8, 4)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TituloCalendar)
                    .HasColumnName("TITULO_CALENDAR")
                    .HasMaxLength(90)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Email>(entity =>
            {
                entity.ToTable("EMAIL");

                entity.HasIndex(e => e.Batch)
                    .HasName("IX_EMAIL_4");

                entity.HasIndex(e => e.FechaCreado)
                    .HasName("IX_EMAIL_3");

                entity.HasIndex(e => e.FechaEnvio)
                    .HasName("IX_EMAIL_5");

                entity.HasIndex(e => e.IdFile)
                    .HasName("IX_EMAIL_2");

                entity.HasIndex(e => new { e.Depurar, e.Email1 })
                    .HasName("IX_EMAIL");

                entity.HasIndex(e => new { e.Depurar, e.IdCarta })
                    .HasName("IX_EMAIL_1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("prueba")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Batch).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CodCliente)
                    .HasColumnName("COD_CLIENTE")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("Codigo de Cliente");

                entity.Property(e => e.Copia)
                    .HasColumnName("copia")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CopiaOculta)
                    .HasColumnName("copia_oculta")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Depurar)
                    .HasColumnName("depurar")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Email1)
                    .HasColumnName("email")
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FechaCreado)
                    .HasColumnName("fecha_creado")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaEnvio)
                    .HasColumnName("fecha_envio")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.HoraCreado)
                    .HasColumnName("hora_creado")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HoraEnvio)
                    .HasColumnName("hora_envio")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdCarta)
                    .HasColumnName("id_carta")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IdFile)
                    .HasColumnName("Id_File")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NsfFile)
                    .HasColumnName("Nsf_File")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Password)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Path)
                    .HasColumnName("PATH")
                    .HasMaxLength(120)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Subject)
                    .HasColumnName("SUBJECT")
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Texto)
                    .HasColumnName("texto")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TipoBody)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Text')");
            });

            modelBuilder.Entity<Emailhistorico>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EMAILHISTORICO");

                entity.Property(e => e.Batch).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CodCliente)
                    .HasColumnName("COD_CLIENTE")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Copia).HasColumnName("copia");

                entity.Property(e => e.CopiaOculta).HasColumnName("copia_oculta");

                entity.Property(e => e.Depurar)
                    .HasColumnName("depurar")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(250);

                entity.Property(e => e.FechaCreado)
                    .HasColumnName("fecha_creado")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaEnvio)
                    .HasColumnName("fecha_envio")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.HoraCreado)
                    .HasColumnName("hora_creado")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HoraEnvio)
                    .HasColumnName("hora_envio")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdCarta).HasColumnName("id_carta");

                entity.Property(e => e.IdFile)
                    .HasColumnName("Id_File")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.NsfFile)
                    .HasColumnName("Nsf_File")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Password)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Path)
                    .HasColumnName("PATH")
                    .HasMaxLength(120);

                entity.Property(e => e.Subject)
                    .HasColumnName("SUBJECT")
                    .HasMaxLength(250);

                entity.Property(e => e.Texto).HasColumnName("texto");

                entity.Property(e => e.TipoBody)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Estadosweb>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ESTADOSWEB");

                entity.Property(e => e.CapitalEstado)
                    .HasColumnName("CAPITAL_ESTADO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoEstado)
                    .HasColumnName("CODIGO_ESTADO")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NombreEstado)
                    .HasColumnName("NOMBRE_ESTADO")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<F0006>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Mcadds)
                    .HasColumnName("MCADDS")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Mcalcl)
                    .HasColumnName("MCALCL")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Mcals)
                    .HasColumnName("MCALS")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Mcan8).HasColumnName("MCAN8");

                entity.Property(e => e.Mcan8o).HasColumnName("MCAN8O");

                entity.Property(e => e.Mcanpa).HasColumnName("MCANPA");

                entity.Property(e => e.Mcapsb)
                    .HasColumnName("MCAPSB")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Mcbptp)
                    .HasColumnName("MCBPTP")
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.Mcbtyp)
                    .HasColumnName("MCBTYP")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Mccac).HasColumnName("MCCAC");

                entity.Property(e => e.Mccc01)
                    .HasColumnName("MCCC01")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Mccc02)
                    .HasColumnName("MCCC02")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Mccc03)
                    .HasColumnName("MCCC03")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Mccc04)
                    .HasColumnName("MCCC04")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Mccc05)
                    .HasColumnName("MCCC05")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Mccc06)
                    .HasColumnName("MCCC06")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Mccc07)
                    .HasColumnName("MCCC07")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Mccc08)
                    .HasColumnName("MCCC08")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Mccc09)
                    .HasColumnName("MCCC09")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Mccc10)
                    .HasColumnName("MCCC10")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Mccert)
                    .HasColumnName("MCCERT")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Mccnty)
                    .HasColumnName("MCCNTY")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Mcco)
                    .HasColumnName("MCCO")
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Mcct)
                    .HasColumnName("MCCT")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Mcd1j)
                    .HasColumnName("MCD1J")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Mcd2j)
                    .HasColumnName("MCD2J")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Mcd3j)
                    .HasColumnName("MCD3J")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Mcd4j)
                    .HasColumnName("MCD4J")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Mcd5j)
                    .HasColumnName("MCD5J")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Mcd6j)
                    .HasColumnName("MCD6J")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Mcdc)
                    .HasColumnName("MCDC")
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.Mcdl01)
                    .HasColumnName("MCDL01")
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Mcdl02)
                    .HasColumnName("MCDL02")
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Mcdl03)
                    .HasColumnName("MCDL03")
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Mcdl04)
                    .HasColumnName("MCDL04")
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Mceeo)
                    .HasColumnName("MCEEO")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Mcerc)
                    .HasColumnName("MCERC")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Mcexr1)
                    .HasColumnName("MCEXR1")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Mcfmod)
                    .HasColumnName("MCFMOD")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Mcfpdj)
                    .HasColumnName("MCFPDJ")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Mcglba)
                    .HasColumnName("MCGLBA")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Mcinta)
                    .HasColumnName("MCINTA")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Mcintl)
                    .HasColumnName("MCINTL")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Mciss)
                    .HasColumnName("MCISS")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Mcjobn)
                    .HasColumnName("MCJOBN")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Mcldm)
                    .HasColumnName("MCLDM")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Mclf).HasColumnName("MCLF");

                entity.Property(e => e.Mclmth)
                    .HasColumnName("MCLMTH")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Mcmcu)
                    .IsRequired()
                    .HasColumnName("MCMCU")
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.Mcmcus)
                    .HasColumnName("MCMCUS")
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.Mcnd01)
                    .HasColumnName("MCND01")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Mcnd02)
                    .HasColumnName("MCND02")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Mcnd03)
                    .HasColumnName("MCND03")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Mcnd04)
                    .HasColumnName("MCND04")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Mcnd05)
                    .HasColumnName("MCND05")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Mcnd06)
                    .HasColumnName("MCND06")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Mcnd07)
                    .HasColumnName("MCND07")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Mcnd08)
                    .HasColumnName("MCND08")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Mcnd09)
                    .HasColumnName("MCND09")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Mcnd10)
                    .HasColumnName("MCND10")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Mcobj1)
                    .HasColumnName("MCOBJ1")
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Mcobj2)
                    .HasColumnName("MCOBJ2")
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Mcobj3)
                    .HasColumnName("MCOBJ3")
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Mcpac).HasColumnName("MCPAC");

                entity.Property(e => e.Mcpc).HasColumnName("MCPC");

                entity.Property(e => e.Mcpca).HasColumnName("MCPCA");

                entity.Property(e => e.Mcpcc).HasColumnName("MCPCC");

                entity.Property(e => e.Mcpecc)
                    .HasColumnName("MCPECC")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Mcpid)
                    .HasColumnName("MCPID")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Mcrp01)
                    .HasColumnName("MCRP01")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Mcrp02)
                    .HasColumnName("MCRP02")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Mcrp03)
                    .HasColumnName("MCRP03")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Mcrp04)
                    .HasColumnName("MCRP04")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Mcrp05)
                    .HasColumnName("MCRP05")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Mcrp06)
                    .HasColumnName("MCRP06")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Mcrp07)
                    .HasColumnName("MCRP07")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Mcrp08)
                    .HasColumnName("MCRP08")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Mcrp09)
                    .HasColumnName("MCRP09")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Mcrp10)
                    .HasColumnName("MCRP10")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Mcrp11)
                    .HasColumnName("MCRP11")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Mcrp12)
                    .HasColumnName("MCRP12")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Mcrp13)
                    .HasColumnName("MCRP13")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Mcrp14)
                    .HasColumnName("MCRP14")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Mcrp15)
                    .HasColumnName("MCRP15")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Mcrp16)
                    .HasColumnName("MCRP16")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Mcrp17)
                    .HasColumnName("MCRP17")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Mcrp18)
                    .HasColumnName("MCRP18")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Mcrp19)
                    .HasColumnName("MCRP19")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Mcrp20)
                    .HasColumnName("MCRP20")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Mcrp21)
                    .HasColumnName("MCRP21")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Mcrp22)
                    .HasColumnName("MCRP22")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Mcrp23)
                    .HasColumnName("MCRP23")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Mcrp24)
                    .HasColumnName("MCRP24")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Mcrp25)
                    .HasColumnName("MCRP25")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Mcrp26)
                    .HasColumnName("MCRP26")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Mcrp27)
                    .HasColumnName("MCRP27")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Mcrp28)
                    .HasColumnName("MCRP28")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Mcrp29)
                    .HasColumnName("MCRP29")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Mcrp30)
                    .HasColumnName("MCRP30")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Mcsbli)
                    .HasColumnName("MCSBLI")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Mcstyl)
                    .HasColumnName("MCSTYL")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Mcsub1)
                    .HasColumnName("MCSUB1")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Mcta)
                    .HasColumnName("MCTA")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Mctc01)
                    .HasColumnName("MCTC01")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Mctc02)
                    .HasColumnName("MCTC02")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Mctc03)
                    .HasColumnName("MCTC03")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Mctc04)
                    .HasColumnName("MCTC04")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Mctc05)
                    .HasColumnName("MCTC05")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Mctc06)
                    .HasColumnName("MCTC06")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Mctc07)
                    .HasColumnName("MCTC07")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Mctc08)
                    .HasColumnName("MCTC08")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Mctc09)
                    .HasColumnName("MCTC09")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Mctc10)
                    .HasColumnName("MCTC10")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Mctou).HasColumnName("MCTOU");

                entity.Property(e => e.Mctsbu)
                    .HasColumnName("MCTSBU")
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.Mctxa1)
                    .HasColumnName("MCTXA1")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Mctxjs).HasColumnName("MCTXJS");

                entity.Property(e => e.Mcupmj)
                    .HasColumnName("MCUPMJ")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Mcupmt).HasColumnName("MCUPMT");

                entity.Property(e => e.Mcuser)
                    .HasColumnName("MCUSER")
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<F0101>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Abab3)
                    .HasColumnName("ABAB3")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Abac01)
                    .HasColumnName("ABAC01")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Abac02)
                    .HasColumnName("ABAC02")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Abac03)
                    .HasColumnName("ABAC03")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Abac04)
                    .HasColumnName("ABAC04")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Abac05)
                    .HasColumnName("ABAC05")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Abac06)
                    .HasColumnName("ABAC06")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Abac07)
                    .HasColumnName("ABAC07")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Abac08)
                    .HasColumnName("ABAC08")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Abac09)
                    .HasColumnName("ABAC09")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Abac10)
                    .HasColumnName("ABAC10")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Abac11)
                    .HasColumnName("ABAC11")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Abac12)
                    .HasColumnName("ABAC12")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Abac13)
                    .HasColumnName("ABAC13")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Abac14)
                    .HasColumnName("ABAC14")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Abac15)
                    .HasColumnName("ABAC15")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Abac16)
                    .HasColumnName("ABAC16")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Abac17)
                    .HasColumnName("ABAC17")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Abac18)
                    .HasColumnName("ABAC18")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Abac19)
                    .HasColumnName("ABAC19")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Abac20)
                    .HasColumnName("ABAC20")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Abac21)
                    .HasColumnName("ABAC21")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Abac22)
                    .HasColumnName("ABAC22")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Abac23)
                    .HasColumnName("ABAC23")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Abac24)
                    .HasColumnName("ABAC24")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Abac25)
                    .HasColumnName("ABAC25")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Abac26)
                    .HasColumnName("ABAC26")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Abac27)
                    .HasColumnName("ABAC27")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Abac28)
                    .HasColumnName("ABAC28")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Abac29)
                    .HasColumnName("ABAC29")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Abac30)
                    .HasColumnName("ABAC30")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Abactin)
                    .HasColumnName("ABACTIN")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Abaempgp)
                    .HasColumnName("ABAEMPGP")
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Abalky)
                    .HasColumnName("ABALKY")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Abalp1)
                    .HasColumnName("ABALP1")
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.Abalph)
                    .HasColumnName("ABALPH")
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.Aban8).HasColumnName("ABAN8");

                entity.Property(e => e.Aban81).HasColumnName("ABAN81");

                entity.Property(e => e.Aban82).HasColumnName("ABAN82");

                entity.Property(e => e.Aban83).HasColumnName("ABAN83");

                entity.Property(e => e.Aban84).HasColumnName("ABAN84");

                entity.Property(e => e.Aban85).HasColumnName("ABAN85");

                entity.Property(e => e.Aban86).HasColumnName("ABAN86");

                entity.Property(e => e.Abat1)
                    .HasColumnName("ABAT1")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Abat2)
                    .HasColumnName("ABAT2")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Abat3)
                    .HasColumnName("ABAT3")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Abat4)
                    .HasColumnName("ABAT4")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Abat5)
                    .HasColumnName("ABAT5")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Abate)
                    .HasColumnName("ABATE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Abatp)
                    .HasColumnName("ABATP")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Abatpr)
                    .HasColumnName("ABATPR")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Abatr)
                    .HasColumnName("ABATR")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Abcaad).HasColumnName("ABCAAD");

                entity.Property(e => e.Abclass01)
                    .HasColumnName("ABCLASS01")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Abclass02)
                    .HasColumnName("ABCLASS02")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Abclass03)
                    .HasColumnName("ABCLASS03")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Abclass04)
                    .HasColumnName("ABCLASS04")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Abclass05)
                    .HasColumnName("ABCLASS05")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Abcm)
                    .HasColumnName("ABCM")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Abdc)
                    .HasColumnName("ABDC")
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.Abduns)
                    .HasColumnName("ABDUNS")
                    .HasMaxLength(13)
                    .IsFixedLength();

                entity.Property(e => e.Abeftb)
                    .HasColumnName("ABEFTB")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Abexchg)
                    .HasColumnName("ABEXCHG")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Abglba)
                    .HasColumnName("ABGLBA")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Abgrowthr).HasColumnName("ABGROWTHR");

                entity.Property(e => e.Abjobn)
                    .HasColumnName("ABJOBN")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Ablngp)
                    .HasColumnName("ABLNGP")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Abmcu)
                    .HasColumnName("ABMCU")
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.Abmsga)
                    .HasColumnName("ABMSGA")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Abnoe).HasColumnName("ABNOE");

                entity.Property(e => e.Abpdi)
                    .HasColumnName("ABPDI")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Abperrs).HasColumnName("ABPERRS");

                entity.Property(e => e.Abpid)
                    .HasColumnName("ABPID")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Abprgf)
                    .HasColumnName("ABPRGF")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Abpti).HasColumnName("ABPTI");

                entity.Property(e => e.Abrevrng)
                    .HasColumnName("ABREVRNG")
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Abrmk)
                    .HasColumnName("ABRMK")
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Absbli)
                    .HasColumnName("ABSBLI")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Absccltp)
                    .HasColumnName("ABSCCLTP")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Absic)
                    .HasColumnName("ABSIC")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Absyncs).HasColumnName("ABSYNCS");

                entity.Property(e => e.Abtax)
                    .HasColumnName("ABTAX")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Abtaxc)
                    .HasColumnName("ABTAXC")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Abticker)
                    .HasColumnName("ABTICKER")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Abtx2)
                    .HasColumnName("ABTX2")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Abtxct)
                    .HasColumnName("ABTXCT")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Abupmj)
                    .HasColumnName("ABUPMJ")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Abupmt).HasColumnName("ABUPMT");

                entity.Property(e => e.Aburab).HasColumnName("ABURAB");

                entity.Property(e => e.Aburat).HasColumnName("ABURAT");

                entity.Property(e => e.Aburcd)
                    .HasColumnName("ABURCD")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Aburdt)
                    .HasColumnName("ABURDT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Aburrf)
                    .HasColumnName("ABURRF")
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.Abuser)
                    .HasColumnName("ABUSER")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Abyearstar)
                    .HasColumnName("ABYEARSTAR")
                    .HasMaxLength(15)
                    .IsFixedLength();
            });

            modelBuilder.Entity<F0401>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.A6ab1)
                    .HasColumnName("A6AB1")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.A6aba1).HasColumnName("A6ABA1");

                entity.Property(e => e.A6abam).HasColumnName("A6ABAM");

                entity.Property(e => e.A6aidp)
                    .HasColumnName("A6AIDP")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.A6an8).HasColumnName("A6AN8");

                entity.Property(e => e.A6an8r).HasColumnName("A6AN8R");

                entity.Property(e => e.A6ancr).HasColumnName("A6ANCR");

                entity.Property(e => e.A6apc)
                    .HasColumnName("A6APC")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.A6appd).HasColumnName("A6APPD");

                entity.Property(e => e.A6aprc).HasColumnName("A6APRC");

                entity.Property(e => e.A6asn)
                    .HasColumnName("A6ASN")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.A6ato)
                    .HasColumnName("A6ATO")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.A6avch)
                    .HasColumnName("A6AVCH")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.A6aypd).HasColumnName("A6AYPD");

                entity.Property(e => e.A6badt)
                    .HasColumnName("A6BADT")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.A6cars).HasColumnName("A6CARS");

                entity.Property(e => e.A6cpgp)
                    .HasColumnName("A6CPGP")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.A6crca)
                    .HasColumnName("A6CRCA")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.A6crmd)
                    .HasColumnName("A6CRMD")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.A6crrp)
                    .HasColumnName("A6CRRP")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.A6dcap).HasColumnName("A6DCAP");

                entity.Property(e => e.A6del1)
                    .HasColumnName("A6DEL1")
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.A6del2)
                    .HasColumnName("A6DEL2")
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.A6dtap)
                    .HasColumnName("A6DTAP")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.A6edad).HasColumnName("A6EDAD");

                entity.Property(e => e.A6edci)
                    .HasColumnName("A6EDCI")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.A6edf1)
                    .HasColumnName("A6EDF1")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.A6edf2)
                    .HasColumnName("A6EDF2")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.A6edii)
                    .HasColumnName("A6EDII")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.A6edpm)
                    .HasColumnName("A6EDPM")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.A6edqd).HasColumnName("A6EDQD");

                entity.Property(e => e.A6exr2)
                    .HasColumnName("A6EXR2")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.A6exr3)
                    .HasColumnName("A6EXR3")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.A6fld).HasColumnName("A6FLD");

                entity.Property(e => e.A6frth)
                    .HasColumnName("A6FRTH")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.A6hdpy)
                    .HasColumnName("A6HDPY")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.A6hold)
                    .HasColumnName("A6HOLD")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.A6inmg)
                    .HasColumnName("A6INMG")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.A6invc).HasColumnName("A6INVC");

                entity.Property(e => e.A6jobn)
                    .HasColumnName("A6JOBN")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.A6kcop)
                    .HasColumnName("A6KCOP")
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.A6ltdt).HasColumnName("A6LTDT");

                entity.Property(e => e.A6maxo).HasColumnName("A6MAXO");

                entity.Property(e => e.A6mcup)
                    .HasColumnName("A6MCUP")
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.A6mino).HasColumnName("A6MINO");

                entity.Property(e => e.A6mnsc)
                    .HasColumnName("A6MNSC")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.A6obap)
                    .HasColumnName("A6OBAP")
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.A6ortp)
                    .HasColumnName("A6ORTP")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.A6pcwh).HasColumnName("A6PCWH");

                entity.Property(e => e.A6pid)
                    .HasColumnName("A6PID")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.A6plst)
                    .HasColumnName("A6PLST")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.A6prp5)
                    .HasColumnName("A6PRP5")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.A6pyin)
                    .HasColumnName("A6PYIN")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.A6rout)
                    .HasColumnName("A6ROUT")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.A6rvnt)
                    .HasColumnName("A6RVNT")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.A6sck)
                    .HasColumnName("A6SCK")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.A6snto).HasColumnName("A6SNTO");

                entity.Property(e => e.A6sqnl)
                    .HasColumnName("A6SQNL")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.A6stop)
                    .HasColumnName("A6STOP")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.A6tawh).HasColumnName("A6TAWH");

                entity.Property(e => e.A6trap)
                    .HasColumnName("A6TRAP")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.A6txa2)
                    .HasColumnName("A6TXA2")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.A6txa3)
                    .HasColumnName("A6TXA3")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.A6upmj)
                    .HasColumnName("A6UPMJ")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.A6upmt).HasColumnName("A6UPMT");

                entity.Property(e => e.A6urab).HasColumnName("A6URAB");

                entity.Property(e => e.A6urat).HasColumnName("A6URAT");

                entity.Property(e => e.A6urcd)
                    .HasColumnName("A6URCD")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.A6urdt)
                    .HasColumnName("A6URDT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.A6urrf)
                    .HasColumnName("A6URRF")
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.A6user)
                    .HasColumnName("A6USER")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.A6vi01)
                    .HasColumnName("A6VI01")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.A6vi02)
                    .HasColumnName("A6VI02")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.A6vi03)
                    .HasColumnName("A6VI03")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.A6vi04)
                    .HasColumnName("A6VI04")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.A6vi05)
                    .HasColumnName("A6VI05")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.A6vumd)
                    .HasColumnName("A6VUMD")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.A6wumd)
                    .HasColumnName("A6WUMD")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.A6zon)
                    .HasColumnName("A6ZON")
                    .HasMaxLength(3)
                    .IsFixedLength();
            });

            modelBuilder.Entity<FechaVigenciaCivy023>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Fecha_VigenciaCIVY023");

                entity.Property(e => e.Codigo)
                    .HasColumnName("CODIGO")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Expr1).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<GerenteOfic>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GERENTE_OFIC");

                entity.Property(e => e.CodigoOficina)
                    .HasColumnName("CODIGO_OFICINA")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.CodigoVendedor)
                    .HasColumnName("CODIGO_VENDEDOR")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Override)
                    .HasColumnName("OVERRIDE")
                    .HasColumnType("numeric(6, 2)");
            });

            modelBuilder.Entity<Kilos>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("kilos");

                entity.Property(e => e.CodigoProducto)
                    .HasColumnName("CODIGO PRODUCTO")
                    .HasMaxLength(255);

                entity.Property(e => e.KgCaja).HasColumnName("KG CAJA");
            });

            modelBuilder.Entity<Listado>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("listado");

                entity.Property(e => e.Cant1).HasColumnName("CANT_1");

                entity.Property(e => e.Cant2).HasColumnName("CANT_2");

                entity.Property(e => e.Cant3)
                    .HasColumnName("CANT_3")
                    .HasMaxLength(255);

                entity.Property(e => e.Cant4)
                    .HasColumnName("CANT_4")
                    .HasMaxLength(255);

                entity.Property(e => e.Codigo)
                    .HasColumnName("CODIGO")
                    .HasMaxLength(255);

                entity.Property(e => e.Fecha)
                    .HasColumnName("FECHA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Precio1).HasColumnName("PRECIO_1");

                entity.Property(e => e.Precio2).HasColumnName("PRECIO_2");

                entity.Property(e => e.Precio3)
                    .HasColumnName("PRECIO_3")
                    .HasMaxLength(255);

                entity.Property(e => e.Precio4)
                    .HasColumnName("PRECIO_4")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Municipiosweb>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MUNICIPIOSWEB");

                entity.Property(e => e.CapitalMcpo)
                    .HasColumnName("CAPITAL_MCPO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoEstado)
                    .HasColumnName("CODIGO_ESTADO")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoMcpo)
                    .HasColumnName("CODIGO_MCPO")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DescMunicipio)
                    .HasColumnName("DESC_MUNICIPIO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EdoMcpo)
                    .HasColumnName("EDO_MCPO")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.PosicionRuta)
                    .HasColumnName("POSICION_RUTA")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ZonaDespacho)
                    .HasColumnName("ZONA_DESPACHO")
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ordenesdepuradas>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ordenesdepuradas");

                entity.Property(e => e.Orden)
                    .HasColumnName("orden")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Passeproveedores>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("passeproveedores");

                entity.Property(e => e.Categoria).HasColumnName("CATEGORIA");

                entity.Property(e => e.Clasificacion).HasColumnName("CLASIFICACION");

                entity.Property(e => e.CodPostal)
                    .IsRequired()
                    .HasColumnName("COD_POSTAL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Codigo).HasColumnName("CODIGO");

                entity.Property(e => e.CodigoCiudad).HasColumnName("CODIGO_CIUDAD");

                entity.Property(e => e.CodigoEstado).HasColumnName("CODIGO_ESTADO");

                entity.Property(e => e.CodigoJde).HasColumnName("codigo_jde");

                entity.Property(e => e.CodigoPais).HasColumnName("CODIGO_PAIS");

                entity.Property(e => e.Compania).HasColumnName("COMPANIA");

                entity.Property(e => e.Direccion1)
                    .IsRequired()
                    .HasColumnName("DIRECCION1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion2)
                    .IsRequired()
                    .HasColumnName("DIRECCION2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion3)
                    .IsRequired()
                    .HasColumnName("DIRECCION3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("EMAIL")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Especial)
                    .IsRequired()
                    .HasColumnName("ESPECIAL")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .IsRequired()
                    .HasColumnName("FAX")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FechaEva)
                    .HasColumnName("FECHA_EVA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnName("FECHA_INGRESO")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaUpdate)
                    .HasColumnName("FECHA_UPDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FormaPago).HasColumnName("FORMA_PAGO");

                entity.Property(e => e.ImpAcumulado)
                    .HasColumnName("IMP_ACUMULADO")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.MontoAcumulado)
                    .HasColumnName("MONTO_ACUMULADO")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.NombreCheque)
                    .IsRequired()
                    .HasColumnName("NOMBRE_CHEQUE")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones)
                    .HasColumnName("OBSERVACIONES")
                    .HasColumnType("text");

                entity.Property(e => e.Origen)
                    .IsRequired()
                    .HasColumnName("ORIGEN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PasoSql)
                    .IsRequired()
                    .HasColumnName("PASO_SQL")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Persona)
                    .IsRequired()
                    .HasColumnName("PERSONA")
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.PorcRet)
                    .HasColumnName("PORC_RET")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Rif)
                    .IsRequired()
                    .HasColumnName("RIF")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.TipoImpueto).HasColumnName("TIPO_IMPUETO");

                entity.Property(e => e.Tipopersona).HasColumnName("TIPOPERSONA");

                entity.Property(e => e.Tlf)
                    .IsRequired()
                    .HasColumnName("TLF")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.UltimaCompra)
                    .HasColumnName("ULTIMA_COMPRA")
                    .HasColumnType("datetime");

                entity.Property(e => e.UltimoBs)
                    .HasColumnName("ULTIMO_BS")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.UltimoDolares)
                    .HasColumnName("ULTIMO_DOLARES")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.UltimoProducto)
                    .IsRequired()
                    .HasColumnName("ULTIMO_PRODUCTO")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Printers>(entity =>
            {
                entity.HasKey(e => e.Recnum)
                    .HasName("PRINTERS_INDEX00");

                entity.ToTable("PRINTERS");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Conexion)
                    .IsRequired()
                    .HasColumnName("CONEXION")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Modelo)
                    .IsRequired()
                    .HasColumnName("MODELO")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Puerto)
                    .IsRequired()
                    .HasColumnName("PUERTO")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Servidor)
                    .IsRequired()
                    .HasColumnName("SERVIDOR")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Ubicacion)
                    .IsRequired()
                    .HasColumnName("UBICACION")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<ProdStock>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ProdStock");

                entity.Property(e => e.LineaProducto)
                    .HasColumnName("LINEA_PRODUCTO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Producto)
                    .HasColumnName("PRODUCTO")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Productos>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Bl)
                    .HasColumnName("BL")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Szaitm)
                    .HasColumnName("SZAITM")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Szdsc1)
                    .HasColumnName("SZDSC1")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Szdsc2)
                    .HasColumnName("SZDSC2")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Szedbt)
                    .HasColumnName("SZEDBT")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Szedln)
                    .HasColumnName("SZEDLN")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Szedtn)
                    .HasColumnName("SZEDTN")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Szedus)
                    .HasColumnName("SZEDUS")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Szglpt)
                    .HasColumnName("SZGLPT")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Szitm)
                    .HasColumnName("SZITM")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Szlitm)
                    .HasColumnName("SZLITM")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Szlnty)
                    .HasColumnName("SZLNTY")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Szmcu)
                    .HasColumnName("SZMCU")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Szroqi)
                    .HasColumnName("SZROQI")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Szsrp1)
                    .HasColumnName("SZSRP1")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Szsrp2)
                    .HasColumnName("SZSRP2")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Szsrp3)
                    .HasColumnName("SZSRP3")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Szsrp4)
                    .HasColumnName("SZSRP4")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Szsrp5)
                    .HasColumnName("SZSRP5")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Szsrp6)
                    .HasColumnName("SZSRP6")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Szsrp7)
                    .HasColumnName("SZSRP7")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Szsrtx)
                    .HasColumnName("SZSRTX")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Szstkt)
                    .HasColumnName("SZSTKT")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Szuom1)
                    .HasColumnName("SZUOM1")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Szuom3)
                    .HasColumnName("SZUOM3")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Szuom4)
                    .HasColumnName("SZUOM4")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Szuvm1)
                    .HasColumnName("SZUVM1")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Szuwum)
                    .HasColumnName("SZUWUM")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Tipoinv)
                    .HasColumnName("TIPOINV")
                    .HasMaxLength(8000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PromedioDelDolarPorMes>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Promedio_del_dolar_por_mes");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("index_453576654")
                    .IsUnique();

                entity.Property(e => e.Ano).HasColumnName("ANO");

                entity.Property(e => e.Mes).HasColumnName("MES");

                entity.Property(e => e.Promedio).HasColumnName("PROMEDIO");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Proveedores>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("proveedores");

                entity.Property(e => e.Codigo)
                    .HasColumnName("CODIGO")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Codigoislr)
                    .HasColumnName("CODIGOISLR")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Conceptoiva)
                    .HasColumnName("CONCEPTOIVA")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Conceptoretencion)
                    .HasColumnName("CONCEPTORETENCION")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion1)
                    .HasColumnName("DIRECCION1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion2)
                    .HasColumnName("DIRECCION2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasColumnName("FAX")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.FechaIngreso)
                    .HasColumnName("FECHA_INGRESO")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Nombre)
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Origen)
                    .HasColumnName("ORIGEN")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.PersonaContacto)
                    .HasColumnName("PERSONA CONTACTO")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Rif)
                    .HasColumnName("RIF")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Tlf)
                    .HasColumnName("TLF")
                    .HasMaxLength(8000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Prueba>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("prueba");

                entity.Property(e => e.Prueba1)
                    .HasColumnName("prueba")
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<QueryCsmy03601>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QUERY_CSMY036_01");

                entity.Property(e => e.Codigo)
                    .HasColumnName("CODIGO")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Familia)
                    .HasColumnName("FAMILIA")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Linea)
                    .HasColumnName("LINEA")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(65)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Producto)
                    .HasColumnName("PRODUCTO")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Titulo)
                    .HasColumnName("TITULO")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Rutas>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RUTAS");

                entity.Property(e => e.CodigoEstado)
                    .HasColumnName("CODIGO_ESTADO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoMcpo)
                    .HasColumnName("CODIGO_MCPO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PosicionRuta)
                    .HasColumnName("POSICION_RUTA")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.ZonaDespacho)
                    .HasColumnName("ZONA_DESPACHO")
                    .HasColumnType("decimal(2, 0)");
            });

            modelBuilder.Entity<SectorWeb>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SECTOR_WEB");

                entity.Property(e => e.NombreSector)
                    .HasColumnName("NOMBRE_SECTOR")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Sector)
                    .HasColumnName("SECTOR")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasColumnName("TIPO")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Supervisor>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SUPERVISOR");

                entity.Property(e => e.Codigo)
                    .HasColumnName("CODIGO")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("CODIGO DEL VENDEDOR");

                entity.Property(e => e.Override)
                    .HasColumnName("OVERRIDE")
                    .HasColumnType("numeric(6, 2)");
            });

            modelBuilder.Entity<Sysfile>(entity =>
            {
                entity.HasKey(e => e.CodigoCia)
                    .HasName("SYSFILE_INDEX01");

                entity.ToTable("SYSFILE");

                entity.HasIndex(e => e.Recnum)
                    .HasName("SYSFILE_INDEX00")
                    .IsUnique();

                entity.HasIndex(e => new { e.Mescon, e.Anocon })
                    .HasName("SYSFILE_INDEX02")
                    .IsUnique();

                entity.Property(e => e.CodigoCia)
                    .HasColumnName("CODIGO_CIA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Anocon)
                    .HasColumnName("ANOCON")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CapitalBs)
                    .HasColumnName("CAPITAL_BS")
                    .HasColumnType("decimal(14, 2)");

                entity.Property(e => e.CodigoOficina).HasColumnName("CODIGO_OFICINA");

                entity.Property(e => e.CompanyName)
                    .HasColumnName("COMPANY_NAME")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LargoPagina).HasColumnName("LARGO_PAGINA");

                entity.Property(e => e.Mark)
                    .HasColumnName("MARK")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Mescon)
                    .HasColumnName("MESCON")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PolizaSeguro)
                    .HasColumnName("POLIZA_SEGURO")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.PorcIva)
                    .HasColumnName("PORC_IVA")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Region)
                    .HasColumnName("REGION")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Rif)
                    .HasColumnName("RIF")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SaltoPagina).HasColumnName("SALTO_PAGINA");
            });

            modelBuilder.Entity<Tasadolar>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Tasadolar");

                entity.Property(e => e.Cambio).HasColumnName("CAMBIO");

                entity.Property(e => e.Fecha)
                    .HasColumnName("FECHA")
                    .HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<Tasadolarstock>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("tasadolarstock");

                entity.Property(e => e.Cambio).HasColumnName("CAMBIO");

                entity.Property(e => e.Fecha)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TipoProducto>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TIPO_PRODUCTO");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Tipo)
                    .HasColumnName("TIPO")
                    .HasColumnType("decimal(2, 0)");
            });

            modelBuilder.Entity<TipoProductofr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tipo_Productofr");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Tipo).HasColumnType("numeric(2, 0)");
            });

            modelBuilder.Entity<VDiccionariomaestros>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_DICCIONARIOMAESTROS");

                entity.Property(e => e.Basededatos)
                    .IsRequired()
                    .HasColumnName("basededatos")
                    .HasMaxLength(8)
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

            modelBuilder.Entity<VEmail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_EMAIL");

                entity.Property(e => e.Copia)
                    .HasColumnName("copia")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CopiaOculta)
                    .HasColumnName("copia_oculta")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Depurar)
                    .HasColumnName("depurar")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaCreado)
                    .HasColumnName("fecha_creado")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaEnvio)
                    .HasColumnName("fecha_envio")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.HoraCreado)
                    .HasColumnName("hora_creado")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HoraEnvio)
                    .HasColumnName("hora_envio")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdCarta).HasColumnName("id_carta");

                entity.Property(e => e.IdFile)
                    .HasColumnName("Id_File")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NsfFile)
                    .HasColumnName("Nsf_File")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Password)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Path)
                    .HasColumnName("PATH")
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Subject)
                    .HasColumnName("SUBJECT")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Texto)
                    .HasColumnName("texto")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<VF47122>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_f47122");

                entity.Property(e => e.Aitm)
                    .HasColumnName("AITM")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.An8).HasColumnName("AN8");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasColumnName("CODIGO")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Dct)
                    .IsRequired()
                    .HasColumnName("DCT")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Dgl)
                    .IsRequired()
                    .HasColumnName("DGL")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Doc).HasColumnName("DOC");

                entity.Property(e => e.Eder)
                    .IsRequired()
                    .HasColumnName("EDER")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Edln).HasColumnName("EDLN");

                entity.Property(e => e.Edsq).HasColumnName("EDSQ");

                entity.Property(e => e.Edst).HasColumnName("EDST");

                entity.Property(e => e.Edty).HasColumnName("EDTY");

                entity.Property(e => e.Kco)
                    .IsRequired()
                    .HasColumnName("KCO")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Kseq).HasColumnName("KSEQ");

                entity.Property(e => e.Ldsc).HasColumnName("LDSC");

                entity.Property(e => e.Litm)
                    .HasColumnName("litm")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Locn)
                    .IsRequired()
                    .HasColumnName("LOCN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Lotn).HasColumnName("LOTN");

                entity.Property(e => e.Mcu)
                    .IsRequired()
                    .HasColumnName("MCU")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Mmej)
                    .IsRequired()
                    .HasColumnName("MMEJ")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Pacd)
                    .IsRequired()
                    .HasColumnName("PACD")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Paid).HasColumnName("PAID");

                entity.Property(e => e.Trdj)
                    .IsRequired()
                    .HasColumnName("TRDJ")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Trex)
                    .IsRequired()
                    .HasColumnName("TREX")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Trno).HasColumnName("TRNO");

                entity.Property(e => e.Trqt)
                    .HasColumnName("TRQT")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Trum)
                    .IsRequired()
                    .HasColumnName("TRUM")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Uncs).HasColumnName("UNCS");

                entity.Property(e => e.Unidad)
                    .IsRequired()
                    .HasColumnName("UNIDAD")
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VInvetarioReconversion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_InvetarioReconversion");

                entity.Property(e => e.Basededatos)
                    .IsRequired()
                    .HasColumnName("basededatos")
                    .HasMaxLength(8)
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

            modelBuilder.Entity<VProductos>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_Productos");

                entity.Property(e => e.CantidadXCaja).HasColumnName("CANTIDAD_X_CAJA");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Producto)
                    .IsRequired()
                    .HasColumnName("PRODUCTO")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.UnidadCosteo).HasColumnName("UNIDAD_COSTEO");
            });

            modelBuilder.Entity<Vendjde>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("vendjde");

                entity.Property(e => e.Activo)
                    .HasColumnName("ACTIVO")
                    .HasMaxLength(255);

                entity.Property(e => e.Cobrador)
                    .HasColumnName("COBRADOR")
                    .HasMaxLength(255);

                entity.Property(e => e.Codigo)
                    .HasColumnName("CODIGO")
                    .HasMaxLength(255);

                entity.Property(e => e.NomOficina)
                    .HasColumnName("NOM_OFICINA")
                    .HasMaxLength(255);

                entity.Property(e => e.Nombre)
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(255);

                entity.Property(e => e.Oficina).HasColumnName("OFICINA");
            });

            modelBuilder.Entity<Vistaclientesweb>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VISTACLIENTESWEB");

                entity.Property(e => e.Asignacion).HasColumnName("ASIGNACION");

                entity.Property(e => e.Cobrador)
                    .HasColumnName("COBRADOR")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodArea)
                    .HasColumnName("COD_AREA")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodEstado)
                    .HasColumnName("COD_ESTADO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Codigo).HasColumnName("CODIGO");

                entity.Property(e => e.Direccion)
                    .HasColumnName("DIRECCION")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Direccion1)
                    .HasColumnName("DIRECCION1")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Direccion2)
                    .HasColumnName("DIRECCION2")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LCredito).HasColumnName("L_CREDITO");

                entity.Property(e => e.Municipio)
                    .HasColumnName("MUNICIPIO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomOficina)
                    .HasColumnName("NOM_OFICINA")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomSupervisor)
                    .HasColumnName("NOM_SUPERVISOR")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomVendedor)
                    .HasColumnName("NOM_VENDEDOR")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NombreRegion)
                    .HasColumnName("NOMBRE_REGION")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Observacion)
                    .HasColumnName("OBSERVACION")
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RamoNegocio)
                    .HasColumnName("RAMO_NEGOCIO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Rif)
                    .HasColumnName("RIF")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Saldoact).HasColumnName("SALDOACT");

                entity.Property(e => e.SectorNegocio)
                    .HasColumnName("SECTOR_NEGOCIO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sucursal).HasColumnName("SUCURSAL");

                entity.Property(e => e.Supervisor)
                    .HasColumnName("SUPERVISOR")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Telefono)
                    .HasColumnName("TELEFONO")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Tipo)
                    .HasColumnName("TIPO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoNegocio)
                    .HasColumnName("TIPO_NEGOCIO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoPago)
                    .HasColumnName("TIPO_PAGO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UltCompra)
                    .HasColumnName("ULT_COMPRA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Vendedor)
                    .HasColumnName("VENDEDOR")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Wary008>(entity =>
            {
                entity.HasKey(e => e.TipoRif)
                    .HasName("WARY008_INDEX01");

                entity.ToTable("WARY008");

                entity.HasIndex(e => e.DesTipRif)
                    .HasName("WARY008_INDEX02")
                    .IsUnique();

                entity.HasIndex(e => e.Recnum)
                    .HasName("WARY008_INDEX00")
                    .IsUnique();

                entity.Property(e => e.TipoRif)
                    .HasColumnName("TIPO_RIF")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DesTipRif)
                    .IsRequired()
                    .HasColumnName("DES_TIP_RIF")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Wary011>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("WARY011_INDEX01");

                entity.ToTable("WARY011");

                entity.HasIndex(e => e.Nombre)
                    .HasName("WARY011_INDEX02")
                    .IsUnique();

                entity.HasIndex(e => e.Recnum)
                    .HasName("WARY011_INDEX00")
                    .IsUnique();

                entity.Property(e => e.Codigo)
                    .HasColumnName("CODIGO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Wary041>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("WARY041_INDEX01");

                entity.ToTable("WARY041");

                entity.HasIndex(e => e.Descripcion)
                    .HasName("WARY041_INDEX02")
                    .IsUnique();

                entity.HasIndex(e => e.Recnum)
                    .HasName("WARY041_INDEX00")
                    .IsUnique();

                entity.Property(e => e.Codigo)
                    .HasColumnName("CODIGO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Wary088>(entity =>
            {
                entity.HasKey(e => new { e.TipoRif, e.NumeroRif, e.ZonaRif })
                    .HasName("WARY088_INDEX01");

                entity.ToTable("WARY088");

                entity.HasIndex(e => e.Recnum)
                    .HasName("WARY088_INDEX00")
                    .IsUnique();

                entity.Property(e => e.TipoRif)
                    .HasColumnName("TIPO_RIF")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NumeroRif)
                    .HasColumnName("NUMERO_RIF")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ZonaRif)
                    .HasColumnName("ZONA_RIF")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ClienteMatriz)
                    .HasColumnName("CLIENTE_MATRIZ")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CodCiudad)
                    .HasColumnName("COD_CIUDAD")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CodigoPostal)
                    .HasColumnName("CODIGO_POSTAL")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Direccion1)
                    .IsRequired()
                    .HasColumnName("DIRECCION1")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Direccion2)
                    .IsRequired()
                    .HasColumnName("DIRECCION2")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DocPendiente)
                    .IsRequired()
                    .HasColumnName("DOC_PENDIENTE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaExp)
                    .HasColumnName("FECHA_EXP")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaModif)
                    .HasColumnName("FECHA_MODIF")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaStatus)
                    .HasColumnName("FECHA_STATUS")
                    .HasColumnType("datetime");

                entity.Property(e => e.Nit)
                    .HasColumnName("NIT")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RazonSocial)
                    .IsRequired()
                    .HasColumnName("RAZON_SOCIAL")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.UltimoItem)
                    .HasColumnName("ULTIMO_ITEM")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<Wary089>(entity =>
            {
                entity.HasKey(e => new { e.TipoRif, e.NumeroRif, e.ZonaRif, e.Cliente })
                    .HasName("WARY089_INDEX01");

                entity.ToTable("WARY089");

                entity.HasIndex(e => e.Recnum)
                    .HasName("WARY089_INDEX00")
                    .IsUnique();

                entity.HasIndex(e => new { e.Cliente, e.Recnum })
                    .HasName("WARY089_INDEX02")
                    .IsUnique();

                entity.Property(e => e.TipoRif)
                    .HasColumnName("TIPO_RIF")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NumeroRif)
                    .HasColumnName("NUMERO_RIF")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ZonaRif)
                    .HasColumnName("ZONA_RIF")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Cliente)
                    .HasColumnName("CLIENTE")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Matriz)
                    .IsRequired()
                    .HasColumnName("MATRIZ")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Wary091>(entity =>
            {
                entity.HasKey(e => new { e.TipoRif, e.NumeroRif, e.ZonaRif, e.Item })
                    .HasName("WARY091_INDEX01");

                entity.ToTable("WARY091");

                entity.HasIndex(e => e.Recnum)
                    .HasName("WARY091_INDEX00")
                    .IsUnique();

                entity.Property(e => e.TipoRif)
                    .HasColumnName("TIPO_RIF")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NumeroRif)
                    .HasColumnName("NUMERO_RIF")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ZonaRif)
                    .HasColumnName("ZONA_RIF")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Item)
                    .HasColumnName("ITEM")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Nit)
                    .HasColumnName("NIT")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RazonSocial)
                    .IsRequired()
                    .HasColumnName("RAZON_SOCIAL")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Winy030>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("winy030");

                entity.Property(e => e.Cambio)
                    .HasColumnName("CAMBIO")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Fecha)
                    .HasColumnName("FECHA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Wivy001>(entity =>
            {
                entity.HasKey(e => new { e.Compania, e.Codigo })
                    .HasName("WIVY001_INDEX01");

                entity.ToTable("WIVY001");

                entity.HasIndex(e => e.Recnum)
                    .HasName("WIVY001_INDEX00")
                    .IsUnique();

                entity.HasIndex(e => new { e.Codigo, e.Recnum })
                    .HasName("WIVY001_INDEX07")
                    .IsUnique();

                entity.HasIndex(e => new { e.Nombre, e.Recnum })
                    .HasName("WIVY001_INDEX06")
                    .IsUnique();

                entity.HasIndex(e => new { e.Rif, e.Recnum })
                    .HasName("WIVY001_INDEX08")
                    .IsUnique();

                entity.HasIndex(e => new { e.Compania, e.Categoria, e.Codigo })
                    .HasName("WIVY001_INDEX03")
                    .IsUnique();

                entity.HasIndex(e => new { e.Compania, e.CodigoCiudad, e.Codigo })
                    .HasName("WIVY001_INDEX04")
                    .IsUnique();

                entity.HasIndex(e => new { e.Compania, e.Nombre, e.Recnum })
                    .HasName("WIVY001_INDEX02")
                    .IsUnique();

                entity.HasIndex(e => new { e.Compania, e.Categoria, e.Nombre, e.Recnum })
                    .HasName("WIVY001_INDEX05")
                    .IsUnique();

                entity.Property(e => e.Compania)
                    .HasColumnName("COMPANIA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Codigo)
                    .HasColumnName("CODIGO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Categoria)
                    .HasColumnName("CATEGORIA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Clasificacion)
                    .HasColumnName("CLASIFICACION")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CodPostal)
                    .IsRequired()
                    .HasColumnName("COD_POSTAL")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CodigoCiudad)
                    .HasColumnName("CODIGO_CIUDAD")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CodigoEstado)
                    .HasColumnName("CODIGO_ESTADO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CodigoJde).HasColumnName("codigo_jde");

                entity.Property(e => e.CodigoPais)
                    .HasColumnName("CODIGO_PAIS")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Direccion1)
                    .IsRequired()
                    .HasColumnName("DIRECCION1")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Direccion2)
                    .IsRequired()
                    .HasColumnName("DIRECCION2")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Direccion3)
                    .IsRequired()
                    .HasColumnName("DIRECCION3")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("EMAIL")
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Especial)
                    .IsRequired()
                    .HasColumnName("ESPECIAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Fax)
                    .IsRequired()
                    .HasColumnName("FAX")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FechaEva)
                    .HasColumnName("FECHA_EVA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnName("FECHA_INGRESO")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaUpdate)
                    .HasColumnName("FECHA_UPDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FormaPago)
                    .HasColumnName("FORMA_PAGO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ImpAcumulado)
                    .HasColumnName("IMP_ACUMULADO")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.MontoAcumulado)
                    .HasColumnName("MONTO_ACUMULADO")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NombreCheque)
                    .IsRequired()
                    .HasColumnName("NOMBRE_CHEQUE")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Observaciones)
                    .HasColumnName("OBSERVACIONES")
                    .HasColumnType("text");

                entity.Property(e => e.Origen)
                    .IsRequired()
                    .HasColumnName("ORIGEN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PasoSql)
                    .IsRequired()
                    .HasColumnName("PASO_SQL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Persona)
                    .IsRequired()
                    .HasColumnName("PERSONA")
                    .HasMaxLength(55)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PorcRet)
                    .HasColumnName("PORC_RET")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Rif)
                    .IsRequired()
                    .HasColumnName("RIF")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TipoImpueto)
                    .HasColumnName("TIPO_IMPUETO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Tipopersona)
                    .HasColumnName("TIPOPERSONA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Tlf)
                    .IsRequired()
                    .HasColumnName("TLF")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.UltimaCompra)
                    .HasColumnName("ULTIMA_COMPRA")
                    .HasColumnType("datetime");

                entity.Property(e => e.UltimoBs)
                    .HasColumnName("ULTIMO_BS")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.UltimoDolares)
                    .HasColumnName("ULTIMO_DOLARES")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.UltimoProducto)
                    .IsRequired()
                    .HasColumnName("ULTIMO_PRODUCTO")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Wivy001audi>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("wivy001audi");

                entity.Property(e => e.Categoria).HasColumnName("CATEGORIA");

                entity.Property(e => e.Clasificacion).HasColumnName("CLASIFICACION");

                entity.Property(e => e.CodPostal)
                    .IsRequired()
                    .HasColumnName("COD_POSTAL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Codigo).HasColumnName("CODIGO");

                entity.Property(e => e.CodigoCiudad).HasColumnName("CODIGO_CIUDAD");

                entity.Property(e => e.CodigoEstado).HasColumnName("CODIGO_ESTADO");

                entity.Property(e => e.CodigoJde).HasColumnName("codigo_jde");

                entity.Property(e => e.CodigoPais).HasColumnName("CODIGO_PAIS");

                entity.Property(e => e.Compania).HasColumnName("COMPANIA");

                entity.Property(e => e.Direccion1)
                    .IsRequired()
                    .HasColumnName("DIRECCION1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion2)
                    .IsRequired()
                    .HasColumnName("DIRECCION2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion3)
                    .IsRequired()
                    .HasColumnName("DIRECCION3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("EMAIL")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Especial)
                    .IsRequired()
                    .HasColumnName("ESPECIAL")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .IsRequired()
                    .HasColumnName("FAX")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FechaEva)
                    .HasColumnName("FECHA_EVA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnName("FECHA_INGRESO")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaUpdate)
                    .HasColumnName("FECHA_UPDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FormaPago).HasColumnName("FORMA_PAGO");

                entity.Property(e => e.ImpAcumulado)
                    .HasColumnName("IMP_ACUMULADO")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.MontoAcumulado)
                    .HasColumnName("MONTO_ACUMULADO")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.NombreCheque)
                    .IsRequired()
                    .HasColumnName("NOMBRE_CHEQUE")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones)
                    .HasColumnName("OBSERVACIONES")
                    .HasColumnType("text");

                entity.Property(e => e.Origen)
                    .IsRequired()
                    .HasColumnName("ORIGEN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PasoSql)
                    .IsRequired()
                    .HasColumnName("PASO_SQL")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Persona)
                    .IsRequired()
                    .HasColumnName("PERSONA")
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.PorcRet)
                    .HasColumnName("PORC_RET")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Rif)
                    .IsRequired()
                    .HasColumnName("RIF")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.TipoImpueto).HasColumnName("TIPO_IMPUETO");

                entity.Property(e => e.Tipopersona).HasColumnName("TIPOPERSONA");

                entity.Property(e => e.Tlf)
                    .IsRequired()
                    .HasColumnName("TLF")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.UltimaCompra)
                    .HasColumnName("ULTIMA_COMPRA")
                    .HasColumnType("datetime");

                entity.Property(e => e.UltimoBs)
                    .HasColumnName("ULTIMO_BS")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.UltimoDolares)
                    .HasColumnName("ULTIMO_DOLARES")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.UltimoProducto)
                    .IsRequired()
                    .HasColumnName("ULTIMO_PRODUCTO")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Wivy002>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("WIVY002_INDEX01");

                entity.ToTable("WIVY002");

                entity.HasIndex(e => e.Recnum)
                    .HasName("WIVY002_INDEX00")
                    .IsUnique();

                entity.HasIndex(e => new { e.Descripcion, e.Recnum })
                    .HasName("WIVY002_INDEX02")
                    .IsUnique();

                entity.Property(e => e.Codigo)
                    .HasColumnName("CODIGO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CodigoJde)
                    .HasColumnName("CODIGO_JDE")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Comprador)
                    .IsRequired()
                    .HasColumnName("COMPRADOR")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Wivy003>(entity =>
            {
                entity.HasKey(e => e.Recnum);

                entity.ToTable("WIVY003");

                entity.HasIndex(e => e.Descripcion)
                    .HasName("WIVY003_INDEX02")
                    .IsUnique();

                entity.HasIndex(e => e.Recnum)
                    .HasName("WIVY003_INDEX00")
                    .IsUnique();

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AprobCredM)
                    .HasColumnName("APROB_CRED_M")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodJde)
                    .HasColumnName("COD_JDE")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Codigo)
                    .HasColumnName("CODIGO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DiasVcto)
                    .HasColumnName("DIAS_VCTO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Inactivo)
                    .HasColumnName("inactivo")
                    .HasMaxLength(1)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PorcRequerido).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.RequiereLimiteCredito)
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Wivy005>(entity =>
            {
                entity.HasKey(e => e.CodigoCiudad)
                    .HasName("WIVY005_INDEX01");

                entity.ToTable("WIVY005");

                entity.HasIndex(e => e.Recnum)
                    .HasName("WIVY005_INDEX00")
                    .IsUnique();

                entity.HasIndex(e => new { e.NombreCiudad, e.CodigoCiudad })
                    .HasName("WIVY005_INDEX02")
                    .IsUnique();

                entity.Property(e => e.CodigoCiudad)
                    .HasColumnName("CODIGO_CIUDAD")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CodigoMcpo)
                    .HasColumnName("CODIGO_MCPO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.NombreCiudad)
                    .IsRequired()
                    .HasColumnName("NOMBRE_CIUDAD")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Wivy006>(entity =>
            {
                entity.HasKey(e => e.CodigoEstado)
                    .HasName("WIVY006_INDEX01");

                entity.ToTable("WIVY006");

                entity.HasIndex(e => e.NombreEstado)
                    .HasName("WIVY006_INDEX02")
                    .IsUnique();

                entity.HasIndex(e => e.Recnum)
                    .HasName("WIVY006_INDEX00")
                    .IsUnique();

                entity.Property(e => e.CodigoEstado)
                    .HasColumnName("CODIGO_ESTADO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CodigoRegion)
                    .IsRequired()
                    .HasColumnName("CODIGO_REGION")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NombreEstado)
                    .IsRequired()
                    .HasColumnName("NOMBRE_ESTADO")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Wivy007>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("WIVY007_INDEX01");

                entity.ToTable("WIVY007");

                entity.HasIndex(e => e.Nombre)
                    .HasName("WIVY007_INDEX02")
                    .IsUnique();

                entity.HasIndex(e => e.Recnum)
                    .HasName("WIVY007_INDEX00")
                    .IsUnique();

                entity.Property(e => e.Codigo)
                    .HasColumnName("CODIGO")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('\" \"')");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasColumnName("LOGIN")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Wivy008>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("WIVY008_INDEX01");

                entity.ToTable("WIVY008");

                entity.HasIndex(e => e.Descripcion)
                    .HasName("WIVY008_INDEX02")
                    .IsUnique();

                entity.HasIndex(e => e.Recnum)
                    .HasName("WIVY008_INDEX00")
                    .IsUnique();

                entity.Property(e => e.Codigo)
                    .HasColumnName("CODIGO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Wivy009>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("WIVY009_INDEX01");

                entity.ToTable("WIVY009");

                entity.HasIndex(e => e.Descripcion)
                    .HasName("WIVY009_INDEX02")
                    .IsUnique();

                entity.HasIndex(e => e.Recnum)
                    .HasName("WIVY009_INDEX00")
                    .IsUnique();

                entity.Property(e => e.Codigo)
                    .HasColumnName("CODIGO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NoUsar)
                    .HasColumnName("NO_USAR")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Wivy010>(entity =>
            {
                entity.HasKey(e => e.NroReq)
                    .HasName("WIVY010_INDEX01");

                entity.ToTable("WIVY010");

                entity.HasIndex(e => e.Recnum)
                    .HasName("WIVY010_INDEX00")
                    .IsUnique();

                entity.HasIndex(e => new { e.FechaRecCompr, e.Recnum })
                    .HasName("WIVY010_INDEX05")
                    .IsUnique();

                entity.HasIndex(e => new { e.Dpto, e.FechaRecCompr, e.NroReq })
                    .HasName("WIVY010_INDEX04")
                    .IsUnique();

                entity.HasIndex(e => new { e.ReqCompleta, e.FechaAnulada, e.NroReq })
                    .HasName("WIVY010_INDEX03")
                    .IsUnique();

                entity.HasIndex(e => new { e.Comprador, e.FlagRecorrido, e.FechaRecCompr, e.NroReq })
                    .HasName("WIVY010_INDEX06")
                    .IsUnique();

                entity.HasIndex(e => new { e.ReqCompleta, e.FechaAnulada, e.Comprador, e.NroReq })
                    .HasName("WIVY010_INDEX02")
                    .IsUnique();

                entity.Property(e => e.NroReq)
                    .HasColumnName("NRO_REQ")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Comprador)
                    .IsRequired()
                    .HasColumnName("COMPRADOR")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CondPago)
                    .HasColumnName("COND_PAGO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Destino)
                    .IsRequired()
                    .HasColumnName("DESTINO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Dpto)
                    .IsRequired()
                    .HasColumnName("DPTO")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FechaAnulada)
                    .HasColumnName("FECHA_ANULADA")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.FechaColocada)
                    .HasColumnName("FECHA_COLOCADA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaElaborada)
                    .HasColumnName("FECHA_ELABORADA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaEstimada)
                    .HasColumnName("FECHA_ESTIMADA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaGrabada)
                    .HasColumnName("FECHA_GRABADA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaRecCompr)
                    .HasColumnName("FECHA_REC_COMPR")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.FechaRequerida)
                    .HasColumnName("FECHA_REQUERIDA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaUltRecep)
                    .HasColumnName("FECHA_ULT_RECEP")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlagRecorrido)
                    .IsRequired()
                    .HasColumnName("FLAG_RECORRIDO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FleteBs)
                    .HasColumnName("FLETE_BS")
                    .HasColumnType("decimal(8, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.FleteMoneda)
                    .HasColumnName("FLETE_MONEDA")
                    .HasColumnType("decimal(8, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Moneda)
                    .IsRequired()
                    .HasColumnName("MONEDA")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Motivo1)
                    .IsRequired()
                    .HasColumnName("MOTIVO1")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Motivo2)
                    .IsRequired()
                    .HasColumnName("MOTIVO2")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NoRecibidaPlanta)
                    .HasColumnName("NO_RECIBIDA_PLANTA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NroCer)
                    .IsRequired()
                    .HasColumnName("NRO_CER")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Observaciones)
                    .HasColumnName("OBSERVACIONES")
                    .HasColumnType("text");

                entity.Property(e => e.Origen)
                    .IsRequired()
                    .HasColumnName("ORIGEN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ReqAlmacen)
                    .IsRequired()
                    .HasColumnName("REQ_ALMACEN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ReqCompleta)
                    .IsRequired()
                    .HasColumnName("REQ_COMPLETA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SinProcesar)
                    .HasColumnName("SIN_PROCESAR")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Solicitante)
                    .IsRequired()
                    .HasColumnName("SOLICITANTE")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Tasa)
                    .HasColumnName("TASA")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TipoSolicitud)
                    .IsRequired()
                    .HasColumnName("TIPO_SOLICITUD")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TipoTransporte)
                    .HasColumnName("TIPO_TRANSPORTE")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.UltimoItem)
                    .HasColumnName("ULTIMO_ITEM")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Urgente)
                    .IsRequired()
                    .HasColumnName("URGENTE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Wivy011>(entity =>
            {
                entity.HasKey(e => new { e.NroReq, e.Item })
                    .HasName("WIVY011_INDEX01");

                entity.ToTable("WIVY011");

                entity.HasIndex(e => e.Recnum)
                    .HasName("WIVY011_INDEX00")
                    .IsUnique();

                entity.HasIndex(e => new { e.ItemCompleto, e.CodigoProducto, e.Recnum })
                    .HasName("WIVY011_INDEX02")
                    .IsUnique();

                entity.HasIndex(e => new { e.ItemCompleto, e.NroReq, e.Item })
                    .HasName("WIVY011_INDEX04")
                    .IsUnique();

                entity.HasIndex(e => new { e.Solicitante, e.NroReq, e.Item })
                    .HasName("WIVY011_INDEX06")
                    .IsUnique();

                entity.HasIndex(e => new { e.CodigoProducto, e.ItemCompleto, e.Ancho, e.Recnum })
                    .HasName("WIVY011_INDEX07")
                    .IsUnique();

                entity.HasIndex(e => new { e.FlagRecorrido, e.GrupAprobacion, e.NroReq, e.Item })
                    .HasName("WIVY011_INDEX05")
                    .IsUnique();

                entity.HasIndex(e => new { e.ItemCompleto, e.Proveedor, e.NroReq, e.Recnum })
                    .HasName("WIVY011_INDEX03")
                    .IsUnique();

                entity.Property(e => e.NroReq)
                    .HasColumnName("NRO_REQ")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Item)
                    .HasColumnName("ITEM")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AOUltCompra)
                    .HasColumnName("A#O_ULT_COMPRA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Ancho)
                    .HasColumnName("ANCHO")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CantidadPedida)
                    .HasColumnName("CANTIDAD_PEDIDA")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CantidadRecibi)
                    .HasColumnName("CANTIDAD_RECIBI")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CodigoProducto)
                    .IsRequired()
                    .HasColumnName("CODIGO_PRODUCTO")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Comprador)
                    .IsRequired()
                    .HasColumnName("COMPRADOR")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CtdRecibidaIr)
                    .HasColumnName("CTD_RECIBIDA_IR")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Descripcion1)
                    .IsRequired()
                    .HasColumnName("DESCRIPCION1")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Descripcion2)
                    .IsRequired()
                    .HasColumnName("DESCRIPCION2")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Descripcion3)
                    .IsRequired()
                    .HasColumnName("DESCRIPCION3")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FechaAnulada)
                    .HasColumnName("FECHA_ANULADA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaColocada)
                    .HasColumnName("FECHA_COLOCADA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCotiza)
                    .HasColumnName("FECHA_COTIZA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaEstimada)
                    .HasColumnName("FECHA_ESTIMADA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaRecCompr)
                    .HasColumnName("FECHA_REC_COMPR")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaRecibida)
                    .HasColumnName("FECHA_RECIBIDA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaRequerida)
                    .HasColumnName("FECHA_REQUERIDA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlagRecorrido)
                    .IsRequired()
                    .HasColumnName("FLAG_RECORRIDO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.GrupAprobacion)
                    .HasColumnName("GRUP_APROBACION")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ItemCompleto)
                    .IsRequired()
                    .HasColumnName("ITEM_COMPLETO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.MesUltCompra)
                    .HasColumnName("MES_ULT_COMPRA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Observacion)
                    .HasColumnName("OBSERVACION")
                    .HasColumnType("text");

                entity.Property(e => e.PrecioUnitBs)
                    .HasColumnName("PRECIO_UNIT_BS")
                    .HasColumnType("decimal(14, 4)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PrecioUnitDo)
                    .HasColumnName("PRECIO_UNIT_DO")
                    .HasColumnType("decimal(14, 4)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Proveedor)
                    .HasColumnName("PROVEEDOR")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Solicitante)
                    .IsRequired()
                    .HasColumnName("SOLICITANTE")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TipoComercio)
                    .HasColumnName("TIPO_COMERCIO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.UltProv)
                    .HasColumnName("ULT_PROV")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.UltPunitBs)
                    .HasColumnName("ULT_PUNIT_BS")
                    .HasColumnType("decimal(14, 4)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.UltPunitDo)
                    .HasColumnName("ULT_PUNIT_DO")
                    .HasColumnType("decimal(14, 4)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Unidad)
                    .IsRequired()
                    .HasColumnName("UNIDAD")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Wivy012>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("WIVY012_INDEX01");

                entity.ToTable("WIVY012");

                entity.HasIndex(e => e.Descripcion)
                    .HasName("WIVY012_INDEX02")
                    .IsUnique();

                entity.HasIndex(e => e.Recnum)
                    .HasName("WIVY012_INDEX00")
                    .IsUnique();

                entity.Property(e => e.Codigo)
                    .HasColumnName("CODIGO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Comentario1)
                    .IsRequired()
                    .HasColumnName("COMENTARIO1")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Comentario2)
                    .IsRequired()
                    .HasColumnName("COMENTARIO2")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Wivy013>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("WIVY013_INDEX01");

                entity.ToTable("WIVY013");

                entity.HasIndex(e => e.Recnum)
                    .HasName("WIVY013_INDEX00")
                    .IsUnique();

                entity.HasIndex(e => new { e.UnidadDesde, e.UnidadHasta })
                    .HasName("WIVY013_INDEX02")
                    .IsUnique();

                entity.Property(e => e.Codigo)
                    .HasColumnName("CODIGO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Factor)
                    .HasColumnName("FACTOR")
                    .HasColumnType("decimal(14, 6)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Operando)
                    .IsRequired()
                    .HasColumnName("OPERANDO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.UnidadDesde)
                    .IsRequired()
                    .HasColumnName("UNIDAD_DESDE")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.UnidadHasta)
                    .IsRequired()
                    .HasColumnName("UNIDAD_HASTA")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Wivy015>(entity =>
            {
                entity.HasKey(e => new { e.FechaRecepcion, e.Codigo, e.Recnum })
                    .HasName("WIVY015_INDEX01");

                entity.ToTable("WIVY015");

                entity.HasIndex(e => e.Recnum)
                    .HasName("WIVY015_INDEX00")
                    .IsUnique();

                entity.HasIndex(e => new { e.NroIr, e.Recnum })
                    .HasName("WIVY015_INDEX02")
                    .IsUnique();

                entity.Property(e => e.FechaRecepcion)
                    .HasColumnName("FECHA_RECEPCION")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.Codigo)
                    .HasColumnName("CODIGO")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BsUnitario)
                    .HasColumnName("BS_UNITARIO")
                    .HasColumnType("decimal(14, 4)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CtdRecibida)
                    .HasColumnName("CTD_RECIBIDA")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Descripcion1)
                    .IsRequired()
                    .HasColumnName("DESCRIPCION1")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DoUnitario)
                    .HasColumnName("DO_UNITARIO")
                    .HasColumnType("decimal(14, 4)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.FormaPago)
                    .HasColumnName("FORMA_PAGO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ItemOc)
                    .HasColumnName("ITEM_OC")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ItemRc)
                    .HasColumnName("ITEM_RC")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Mescon)
                    .HasColumnName("MESCON")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.NroIr)
                    .HasColumnName("NRO_IR")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.NroOc)
                    .HasColumnName("NRO_OC")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.NroReq)
                    .HasColumnName("NRO_REQ")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Proveedor)
                    .HasColumnName("PROVEEDOR")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<Wivy016>(entity =>
            {
                entity.HasKey(e => e.CodigoMoneda)
                    .HasName("WIVY016_INDEX01");

                entity.ToTable("WIVY016");

                entity.HasIndex(e => e.Descripcion)
                    .HasName("WIVY016_INDEX02")
                    .IsUnique();

                entity.HasIndex(e => e.Recnum)
                    .HasName("WIVY016_INDEX00")
                    .IsUnique();

                entity.Property(e => e.CodigoMoneda)
                    .HasColumnName("CODIGO_MONEDA")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Tasa)
                    .HasColumnName("TASA")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<Wivy019>(entity =>
            {
                entity.HasKey(e => e.NroOc)
                    .HasName("WIVY019_INDEX01");

                entity.ToTable("WIVY019");

                entity.HasIndex(e => e.Recnum)
                    .HasName("WIVY019_INDEX00")
                    .IsUnique();

                entity.HasIndex(e => new { e.OrdenCompleta, e.FechaAnulada, e.NroOc })
                    .HasName("WIVY019_INDEX03")
                    .IsUnique();

                entity.HasIndex(e => new { e.OrdenCompleta, e.Proveedor, e.NroOc })
                    .HasName("WIVY019_INDEX04")
                    .IsUnique();

                entity.HasIndex(e => new { e.Proveedor, e.FechaElaborada, e.Recnum })
                    .HasName("WIVY019_INDEX08")
                    .IsUnique();

                entity.HasIndex(e => new { e.OrdenCompleta, e.FechaAnulada, e.Comprador, e.NroOc })
                    .HasName("WIVY019_INDEX02")
                    .IsUnique();

                entity.HasIndex(e => new { e.OrdenCompleta, e.FechaAnulada, e.FechaColocada, e.NroOc })
                    .HasName("WIVY019_INDEX07")
                    .IsUnique();

                entity.HasIndex(e => new { e.OrdenCompleta, e.FechaAnulada, e.FechaEnvFirma, e.NroOc })
                    .HasName("WIVY019_INDEX05")
                    .IsUnique();

                entity.HasIndex(e => new { e.OrdenCompleta, e.FechaAnulada, e.FechaRecFirma, e.NroOc })
                    .HasName("WIVY019_INDEX06")
                    .IsUnique();

                entity.Property(e => e.NroOc)
                    .HasColumnName("NRO_OC")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Comprador)
                    .IsRequired()
                    .HasColumnName("COMPRADOR")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CondPago)
                    .HasColumnName("COND_PAGO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CostoFlete)
                    .HasColumnName("COSTO_FLETE")
                    .HasColumnType("decimal(8, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Dpto)
                    .IsRequired()
                    .HasColumnName("DPTO")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FechaAnulada)
                    .HasColumnName("FECHA_ANULADA")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.FechaColocada)
                    .HasColumnName("FECHA_COLOCADA")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.FechaElaborada)
                    .HasColumnName("FECHA_ELABORADA")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.FechaEmbarque)
                    .HasColumnName("FECHA_EMBARQUE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaEnvFirma)
                    .HasColumnName("FECHA_ENV_FIRMA")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.FechaEstimada)
                    .HasColumnName("FECHA_ESTIMADA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaNotifica)
                    .HasColumnName("FECHA_NOTIFICA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaRecFirma)
                    .HasColumnName("FECHA_REC_FIRMA")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.FechaSoliAuto)
                    .HasColumnName("FECHA_SOLI_AUTO")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaUltRecep)
                    .HasColumnName("FECHA_ULT_RECEP")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fletes)
                    .IsRequired()
                    .HasColumnName("FLETES")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Moneda)
                    .IsRequired()
                    .HasColumnName("MONEDA")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.MontoTotal)
                    .HasColumnName("MONTO_TOTAL")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.NombreProv)
                    .IsRequired()
                    .HasColumnName("NOMBRE_PROV")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NroAutorizacio)
                    .IsRequired()
                    .HasColumnName("NRO_AUTORIZACIO")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Observaciones)
                    .HasColumnName("OBSERVACIONES")
                    .HasColumnType("text");

                entity.Property(e => e.OrdenAbierta)
                    .HasColumnName("ORDEN_ABIERTA")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.OrdenCompleta)
                    .IsRequired()
                    .HasColumnName("ORDEN_COMPLETA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Origen)
                    .IsRequired()
                    .HasColumnName("ORIGEN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ProvAduanal)
                    .HasColumnName("PROV_ADUANAL")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Proveedor)
                    .HasColumnName("PROVEEDOR")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Tasa)
                    .HasColumnName("TASA")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TipoOc)
                    .IsRequired()
                    .HasColumnName("TIPO_OC")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('NO')");

                entity.Property(e => e.TipoTransporte)
                    .HasColumnName("TIPO_TRANSPORTE")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.UltItemGastos)
                    .HasColumnName("ULT_ITEM_GASTOS")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.UltimoItem)
                    .HasColumnName("ULTIMO_ITEM")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<Wivy020>(entity =>
            {
                entity.HasKey(e => new { e.NroOc, e.Item })
                    .HasName("WIVY020_INDEX01");

                entity.ToTable("WIVY020");

                entity.HasIndex(e => e.Recnum)
                    .HasName("WIVY020_INDEX00")
                    .IsUnique();

                entity.HasIndex(e => new { e.NroRc, e.ItemRc, e.Recnum })
                    .HasName("WIVY020_INDEX02")
                    .IsUnique();

                entity.Property(e => e.NroOc)
                    .HasColumnName("NRO_OC")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Item)
                    .HasColumnName("ITEM")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ItemRc)
                    .HasColumnName("ITEM_RC")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.NroRc)
                    .HasColumnName("NRO_RC")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Wivy021>(entity =>
            {
                entity.HasKey(e => new { e.NroDoc, e.Item })
                    .HasName("WIVY021_INDEX01");

                entity.ToTable("WIVY021");

                entity.HasIndex(e => e.Recnum)
                    .HasName("WIVY021_INDEX00")
                    .IsUnique();

                entity.Property(e => e.NroDoc)
                    .HasColumnName("NRO_DOC")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Item)
                    .HasColumnName("ITEM")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(55)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Monto)
                    .HasColumnName("MONTO")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Wivy026>(entity =>
            {
                entity.HasKey(e => e.NroIr)
                    .HasName("WIVY026_INDEX01");

                entity.ToTable("WIVY026");

                entity.HasIndex(e => e.Recnum)
                    .HasName("WIVY026_INDEX00")
                    .IsUnique();

                entity.HasIndex(e => new { e.Proveedor, e.Recnum })
                    .HasName("WIVY026_INDEX03")
                    .IsUnique();

                entity.HasIndex(e => new { e.TipoAlmacen, e.Recnum })
                    .HasName("WIVY026_INDEX02")
                    .IsUnique();

                entity.Property(e => e.NroIr)
                    .HasColumnName("NRO_IR")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.FechaEmision)
                    .HasColumnName("FECHA_EMISION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaRecepcion)
                    .HasColumnName("FECHA_RECEPCION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FormaPago)
                    .HasColumnName("FORMA_PAGO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Mescon)
                    .HasColumnName("MESCON")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.NotaEntrega)
                    .IsRequired()
                    .HasColumnName("NOTA_ENTREGA")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NroFactura)
                    .IsRequired()
                    .HasColumnName("NRO_FACTURA")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Observacion)
                    .HasColumnName("OBSERVACION")
                    .HasColumnType("text");

                entity.Property(e => e.Proveedor)
                    .HasColumnName("PROVEEDOR")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TipoAlmacen)
                    .IsRequired()
                    .HasColumnName("TIPO_ALMACEN")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Wivy027>(entity =>
            {
                entity.HasKey(e => new { e.NroIr, e.Item })
                    .HasName("WIVY027_INDEX01");

                entity.ToTable("WIVY027");

                entity.HasIndex(e => e.Recnum)
                    .HasName("WIVY027_INDEX00")
                    .IsUnique();

                entity.HasIndex(e => new { e.Codigo, e.Recnum })
                    .HasName("WIVY027_INDEX02")
                    .IsUnique();

                entity.HasIndex(e => new { e.NroOc, e.Recnum })
                    .HasName("WIVY027_INDEX06")
                    .IsUnique();

                entity.HasIndex(e => new { e.Codigo, e.NroIr, e.Recnum })
                    .HasName("WIVY027_INDEX05")
                    .IsUnique();

                entity.HasIndex(e => new { e.NroReq, e.ItemRc, e.Recnum })
                    .HasName("WIVY027_INDEX04")
                    .IsUnique();

                entity.Property(e => e.NroIr)
                    .HasColumnName("NRO_IR")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Item)
                    .HasColumnName("ITEM")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.BsUnitario)
                    .HasColumnName("BS_UNITARIO")
                    .HasColumnType("decimal(14, 4)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasColumnName("CODIGO")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CtdRecibida)
                    .HasColumnName("CTD_RECIBIDA")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Descripcion1)
                    .IsRequired()
                    .HasColumnName("DESCRIPCION1")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DoUnitario)
                    .HasColumnName("DO_UNITARIO")
                    .HasColumnType("decimal(14, 4)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ItemOc)
                    .HasColumnName("ITEM_OC")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ItemRc)
                    .HasColumnName("ITEM_RC")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.NroOc)
                    .HasColumnName("NRO_OC")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.NroReq)
                    .HasColumnName("NRO_REQ")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ProductoCli)
                    .HasColumnName("PRODUCTO_CLI")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Wivy030>(entity =>
            {
                entity.HasKey(e => e.NroIr)
                    .HasName("WIVY030_INDEX01");

                entity.ToTable("WIVY030");

                entity.HasIndex(e => e.Recnum)
                    .HasName("WIVY030_INDEX00")
                    .IsUnique();

                entity.Property(e => e.NroIr)
                    .HasColumnName("NRO_IR")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CondicionPago)
                    .HasColumnName("CONDICION_PAGO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.FaControl)
                    .HasColumnName("FA_CONTROL")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Factura)
                    .IsRequired()
                    .HasColumnName("FACTURA")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FechaEmision)
                    .HasColumnName("FECHA_EMISION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnName("FECHA_INGRESO")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaVcto)
                    .HasColumnName("FECHA_VCTO")
                    .HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NotaEntrega)
                    .IsRequired()
                    .HasColumnName("NOTA_ENTREGA")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Observacion)
                    .HasColumnName("OBSERVACION")
                    .HasColumnType("text");

                entity.Property(e => e.Pasar)
                    .IsRequired()
                    .HasColumnName("PASAR")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PorcIva)
                    .HasColumnName("PORC_IVA")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PorcRetIva)
                    .HasColumnName("PORC_RET_IVA")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Prefijo)
                    .IsRequired()
                    .HasColumnName("PREFIJO")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Proveedor)
                    .HasColumnName("PROVEEDOR")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Sufijo)
                    .IsRequired()
                    .HasColumnName("SUFIJO")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TipoPago)
                    .HasColumnName("TIPO_PAGO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TotalCredito)
                    .HasColumnName("TOTAL_CREDITO")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TotalDebito)
                    .HasColumnName("TOTAL_DEBITO")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.UltimoItem)
                    .HasColumnName("ULTIMO_ITEM")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<Wivy030bk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("wivy030bk");

                entity.Property(e => e.CondicionPago).HasColumnName("CONDICION_PAGO");

                entity.Property(e => e.FaControl).HasColumnName("FA_CONTROL");

                entity.Property(e => e.Factura)
                    .IsRequired()
                    .HasColumnName("FACTURA")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechaEmision)
                    .HasColumnName("FECHA_EMISION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnName("FECHA_INGRESO")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaVcto)
                    .HasColumnName("FECHA_VCTO")
                    .HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.NotaEntrega)
                    .IsRequired()
                    .HasColumnName("NOTA_ENTREGA")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NroIr).HasColumnName("NRO_IR");

                entity.Property(e => e.Observacion)
                    .HasColumnName("OBSERVACION")
                    .HasColumnType("text");

                entity.Property(e => e.Pasar)
                    .IsRequired()
                    .HasColumnName("PASAR")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PorcIva)
                    .HasColumnName("PORC_IVA")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.PorcRetIva)
                    .HasColumnName("PORC_RET_IVA")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Prefijo)
                    .IsRequired()
                    .HasColumnName("PREFIJO")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Proveedor).HasColumnName("PROVEEDOR");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Sufijo)
                    .IsRequired()
                    .HasColumnName("SUFIJO")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.TipoPago).HasColumnName("TIPO_PAGO");

                entity.Property(e => e.TotalCredito)
                    .HasColumnName("TOTAL_CREDITO")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.TotalDebito)
                    .HasColumnName("TOTAL_DEBITO")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.UltimoItem).HasColumnName("ULTIMO_ITEM");
            });

            modelBuilder.Entity<Wivy031>(entity =>
            {
                entity.HasKey(e => new { e.NroIr, e.Item })
                    .HasName("WIVY031_INDEX01");

                entity.ToTable("WIVY031");

                entity.HasIndex(e => e.Recnum)
                    .HasName("WIVY031_INDEX00")
                    .IsUnique();

                entity.Property(e => e.NroIr)
                    .HasColumnName("NRO_IR")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Item)
                    .HasColumnName("ITEM")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Auxiliar)
                    .HasColumnName("AUXILIAR")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Ccosto)
                    .HasColumnName("CCOSTO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CodContrapart)
                    .IsRequired()
                    .HasColumnName("COD_CONTRAPART")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Concepto)
                    .IsRequired()
                    .HasColumnName("CONCEPTO")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CtdRecibida)
                    .HasColumnName("CTD_RECIBIDA")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ItemIr)
                    .HasColumnName("ITEM_IR")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Mayor)
                    .HasColumnName("MAYOR")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.MontoCredito)
                    .HasColumnName("MONTO_CREDITO")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.MontoDebito)
                    .HasColumnName("MONTO_DEBITO")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.NroOc)
                    .HasColumnName("NRO_OC")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.NumeroAplicar)
                    .HasColumnName("NUMERO_APLICAR")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TipoAplicar)
                    .IsRequired()
                    .HasColumnName("TIPO_APLICAR")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TipoPago)
                    .HasColumnName("TIPO_PAGO")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<Wivy031bk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("wivy031bk");

                entity.Property(e => e.Auxiliar).HasColumnName("AUXILIAR");

                entity.Property(e => e.Ccosto).HasColumnName("CCOSTO");

                entity.Property(e => e.CodContrapart)
                    .IsRequired()
                    .HasColumnName("COD_CONTRAPART")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Concepto)
                    .IsRequired()
                    .HasColumnName("CONCEPTO")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CtdRecibida)
                    .HasColumnName("CTD_RECIBIDA")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Item).HasColumnName("ITEM");

                entity.Property(e => e.ItemIr).HasColumnName("ITEM_IR");

                entity.Property(e => e.Mayor).HasColumnName("MAYOR");

                entity.Property(e => e.MontoCredito)
                    .HasColumnName("MONTO_CREDITO")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.MontoDebito)
                    .HasColumnName("MONTO_DEBITO")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.NroIr).HasColumnName("NRO_IR");

                entity.Property(e => e.NroOc).HasColumnName("NRO_OC");

                entity.Property(e => e.NumeroAplicar).HasColumnName("NUMERO_APLICAR");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TipoAplicar)
                    .IsRequired()
                    .HasColumnName("TIPO_APLICAR")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TipoPago).HasColumnName("TIPO_PAGO");
            });

            modelBuilder.Entity<Wivy035>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("WIVY035_INDEX01");

                entity.ToTable("WIVY035");

                entity.HasIndex(e => e.Descripcion)
                    .HasName("WIVY035_INDEX02")
                    .IsUnique();

                entity.HasIndex(e => e.Recnum)
                    .HasName("WIVY035_INDEX00")
                    .IsUnique();

                entity.Property(e => e.Codigo)
                    .HasColumnName("CODIGO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Wivy044>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WIVY044");

                entity.Property(e => e.CantidadPedida)
                    .HasColumnName("CANTIDAD_PEDIDA")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CantidadRecibi)
                    .HasColumnName("CANTIDAD_RECIBI")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Departamento)
                    .IsRequired()
                    .HasColumnName("DEPARTAMENTO")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion1)
                    .IsRequired()
                    .HasColumnName("DESCRIPCION1")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaColocada)
                    .HasColumnName("FECHA_COLOCADA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaElaborada)
                    .HasColumnName("FECHA_ELABORADA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaEnvFirma)
                    .HasColumnName("FECHA_ENV_FIRMA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaEstimada)
                    .HasColumnName("FECHA_ESTIMADA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaRecFirma)
                    .HasColumnName("FECHA_REC_FIRMA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ItemCompleto)
                    .IsRequired()
                    .HasColumnName("ITEM_COMPLETO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemReq)
                    .HasColumnName("ITEM_REQ")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Marca)
                    .HasColumnName("MARCA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NombreProv)
                    .HasColumnName("NOMBRE_PROV")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NroOc)
                    .HasColumnName("NRO_OC")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NroReq)
                    .HasColumnName("NRO_REQ")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.OrdenCompleta)
                    .IsRequired()
                    .HasColumnName("ORDEN_COMPLETA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Origen)
                    .IsRequired()
                    .HasColumnName("ORIGEN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Unidad)
                    .IsRequired()
                    .HasColumnName("UNIDAD")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Wivy045>(entity =>
            {
                entity.HasKey(e => e.TipoOc)
                    .HasName("WIVY045_INDEX01");

                entity.ToTable("WIVY045");

                entity.HasIndex(e => e.Recnum)
                    .HasName("WIVY045_INDEX00")
                    .IsUnique();

                entity.Property(e => e.TipoOc)
                    .HasColumnName("TIPO_OC")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DescTipoOc)
                    .HasColumnName("DESC_TIPO_OC")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Wivy045bk>(entity =>
            {
                entity.HasKey(e => e.TipoOc)
                    .HasName("PK_WIVY045");

                entity.ToTable("WIVY045bk");

                entity.Property(e => e.TipoOc)
                    .HasColumnName("TIPO_OC")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DescTipoOc)
                    .HasColumnName("DESC_TIPO_OC")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RecNum)
                    .HasColumnName("REC_NUM")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Woey079>(entity =>
            {
                entity.HasKey(e => e.CodigoDtipo)
                    .HasName("WOEY079_INDEX01");

                entity.ToTable("WOEY079");

                entity.HasIndex(e => e.DescriDtipo)
                    .HasName("WOEY079_INDEX02")
                    .IsUnique();

                entity.HasIndex(e => e.Recnum)
                    .HasName("WOEY079_INDEX00")
                    .IsUnique();

                entity.Property(e => e.CodigoDtipo)
                    .HasColumnName("CODIGO_DTIPO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CodigoGtipo)
                    .HasColumnName("CODIGO_GTIPO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.DescriDtipo)
                    .IsRequired()
                    .HasColumnName("DESCRI_DTIPO")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Wppy001>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("WPPY001_INDEX01");

                entity.ToTable("WPPY001");

                entity.HasIndex(e => e.Recnum)
                    .HasName("WPPY001_INDEX00")
                    .IsUnique();

                entity.HasIndex(e => new { e.Descripcion, e.Recnum })
                    .HasName("WPPY001_INDEX02")
                    .IsUnique();

                entity.HasIndex(e => new { e.Dimension, e.Codigo })
                    .HasName("WPPY001_INDEX08")
                    .IsUnique();

                entity.HasIndex(e => new { e.NroParte, e.Codigo })
                    .HasName("WPPY001_INDEX07")
                    .IsUnique();

                entity.HasIndex(e => new { e.Categoria, e.Codigo, e.Recnum })
                    .HasName("WPPY001_INDEX03")
                    .IsUnique();

                entity.HasIndex(e => new { e.MaqUso, e.Codigo, e.Recnum })
                    .HasName("WPPY001_INDEX06")
                    .IsUnique();

                entity.HasIndex(e => new { e.Ubicacion, e.Codigo, e.Recnum })
                    .HasName("WPPY001_INDEX04")
                    .IsUnique();

                entity.HasIndex(e => new { e.Invmay, e.Invaux, e.Invcco, e.Codigo, e.Recnum })
                    .HasName("WPPY001_INDEX05")
                    .IsUnique();

                entity.Property(e => e.Codigo)
                    .HasColumnName("CODIGO")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Abc)
                    .IsRequired()
                    .HasColumnName("ABC")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CantOrdenar)
                    .HasColumnName("CANT_ORDENAR")
                    .HasColumnType("decimal(12, 4)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Categoria)
                    .HasColumnName("CATEGORIA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Conaux)
                    .HasColumnName("CONAUX")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Concco)
                    .HasColumnName("CONCCO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Conmay)
                    .HasColumnName("CONMAY")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ConsPromedio)
                    .HasColumnName("CONS_PROMEDIO")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CostoDolar)
                    .HasColumnName("COSTO_DOLAR")
                    .HasColumnType("decimal(14, 4)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CostoProm)
                    .HasColumnName("COSTO_PROM")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CtdMinDesp)
                    .HasColumnName("CTD_MIN_DESP")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CtdUnd)
                    .HasColumnName("CTD_UND")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(56)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Descripcion2)
                    .IsRequired()
                    .HasColumnName("DESCRIPCION2")
                    .HasMaxLength(56)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DiasEntrega)
                    .HasColumnName("DIAS_ENTREGA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Dimension)
                    .IsRequired()
                    .HasColumnName("DIMENSION")
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FUltCompra)
                    .HasColumnName("F_ULT_COMPRA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FUltSalida)
                    .HasColumnName("F_ULT_SALIDA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaAbc)
                    .HasColumnName("FECHA_ABC")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaInicial)
                    .HasColumnName("FECHA_INICIAL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Invaux)
                    .HasColumnName("INVAUX")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Invcco)
                    .HasColumnName("INVCCO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Invmay)
                    .HasColumnName("INVMAY")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.MaqUso)
                    .HasColumnName("MAQ_USO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Maximo)
                    .HasColumnName("MAXIMO")
                    .HasColumnType("decimal(12, 4)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Minimo)
                    .HasColumnName("MINIMO")
                    .HasColumnType("decimal(12, 4)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.NroParte)
                    .IsRequired()
                    .HasColumnName("NRO_PARTE")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Origen)
                    .IsRequired()
                    .HasColumnName("ORIGEN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Peso)
                    .HasColumnName("PESO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Porcentaje)
                    .HasColumnName("PORCENTAJE")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PuntoReorden)
                    .HasColumnName("PUNTO_REORDEN")
                    .HasColumnType("decimal(12, 4)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Qactual)
                    .HasColumnName("QACTUAL")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Qentano)
                    .HasColumnName("QENTANO")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Qiniano)
                    .HasColumnName("QINIANO")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Qsalano)
                    .HasColumnName("QSALANO")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Ubicacion)
                    .IsRequired()
                    .HasColumnName("UBICACION")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.UltCosto)
                    .HasColumnName("ULT_COSTO")
                    .HasColumnType("decimal(14, 4)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.UltProvee)
                    .HasColumnName("ULT_PROVEE")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Unidad)
                    .IsRequired()
                    .HasColumnName("UNIDAD")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Wppy002>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("WPPY002_INDEX01");

                entity.ToTable("WPPY002");

                entity.HasIndex(e => e.Descripcion)
                    .HasName("WPPY002_INDEX02")
                    .IsUnique();

                entity.HasIndex(e => e.Recnum)
                    .HasName("WPPY002_INDEX00")
                    .IsUnique();

                entity.Property(e => e.Codigo)
                    .HasColumnName("CODIGO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TipoNegocio)
                    .HasColumnName("TIPO_NEGOCIO")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<Wppy003>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("WPPY003_INDEX01");

                entity.ToTable("WPPY003");

                entity.HasIndex(e => e.Recnum)
                    .HasName("WPPY003_INDEX00")
                    .IsUnique();

                entity.HasIndex(e => new { e.CodigoOficina, e.Codigo })
                    .HasName("WPPY003_INDEX03")
                    .IsUnique();

                entity.HasIndex(e => new { e.Descripcion, e.Codigo })
                    .HasName("WPPY003_INDEX02")
                    .IsUnique();

                entity.Property(e => e.Codigo)
                    .HasColumnName("CODIGO")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CodigoOficina)
                    .HasColumnName("CODIGO_OFICINA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Grupo)
                    .HasColumnName("GRUPO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Wppy007>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("WPPY007_INDEX01");

                entity.ToTable("WPPY007");

                entity.HasIndex(e => e.Recnum)
                    .HasName("WPPY007_INDEX00")
                    .IsUnique();

                entity.Property(e => e.Codigo)
                    .HasColumnName("CODIGO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Wppy010>(entity =>
            {
                entity.HasKey(e => e.FechaHasta)
                    .HasName("WPPY010_INDEX01");

                entity.ToTable("WPPY010");

                entity.HasIndex(e => e.Mescon)
                    .HasName("WPPY010_INDEX02")
                    .IsUnique();

                entity.HasIndex(e => e.Recnum)
                    .HasName("WPPY010_INDEX00")
                    .IsUnique();

                entity.Property(e => e.FechaHasta)
                    .HasColumnName("FECHA_HASTA")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.Mescon)
                    .HasColumnName("MESCON")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Wppy022>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.ToTable("WPPY022");

                entity.HasIndex(e => e.Descripcion)
                    .HasName("IX_WPPY022")
                    .IsUnique();

                entity.HasIndex(e => e.Recnum)
                    .HasName("WPPY022_INDEX00")
                    .IsUnique();

                entity.Property(e => e.Codigo)
                    .HasColumnName("CODIGO")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ParaCotizador)
                    .HasColumnName("PARA_COTIZADOR")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Unidadsap)
                    .HasColumnName("UNIDADSAP")
                    .HasMaxLength(3);
            });

            modelBuilder.Entity<Wsmy003>(entity =>
            {
                entity.HasKey(e => new { e.Region, e.Grupo, e.Zona, e.Asignacion, e.Recnum })
                    .HasName("WSMY003_INDEX01");

                entity.ToTable("WSMY003");

                entity.HasIndex(e => e.Codigo)
                    .HasName("WSMY003_INDEX03")
                    .IsUnique();

                entity.HasIndex(e => e.Recnum)
                    .HasName("WSMY003_INDEX00")
                    .IsUnique();

                entity.HasIndex(e => new { e.Clave, e.Recnum })
                    .HasName("WSMY003_INDEX02")
                    .IsUnique();

                entity.HasIndex(e => new { e.Nombre, e.Recnum })
                    .HasName("WSMY003_INDEX11")
                    .IsUnique();

                entity.HasIndex(e => new { e.Asignacion, e.Zona, e.Recnum })
                    .HasName("WSMY003_INDEX05")
                    .IsUnique();

                entity.HasIndex(e => new { e.Telex, e.Sucursal, e.Recnum })
                    .HasName("WSMY003_INDEX07")
                    .IsUnique();

                entity.HasIndex(e => new { e.Asignacion, e.Region, e.Zona, e.Recnum })
                    .HasName("WSMY003_INDEX06")
                    .IsUnique();

                entity.HasIndex(e => new { e.GeoMunParr, e.Cobrador, e.Codigo, e.Recnum })
                    .HasName("WSMY003_INDEX04")
                    .IsUnique();

                entity.HasIndex(e => new { e.Region, e.Zona, e.Grupo, e.Recnum })
                    .HasName("WSMY003_INDEX09")
                    .IsUnique();

                entity.HasIndex(e => new { e.Region, e.Grupo, e.Zona, e.Tipo, e.Recnum })
                    .HasName("WSMY003_INDEX08")
                    .IsUnique();

                entity.HasIndex(e => new { e.Telex, e.Sucursal, e.Region, e.Grupo, e.Zona, e.Codigo, e.Recnum })
                    .HasName("WSMY003_INDEX10")
                    .IsUnique();

                entity.Property(e => e.Region)
                    .HasColumnName("REGION")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Grupo)
                    .HasColumnName("GRUPO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Zona)
                    .HasColumnName("ZONA")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Asignacion)
                    .HasColumnName("ASIGNACION")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ActividadEco)
                    .IsRequired()
                    .HasColumnName("ACTIVIDAD_ECO")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Canal)
                    .IsRequired()
                    .HasColumnName("CANAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CapitalSoc)
                    .HasColumnName("CAPITAL_SOC")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Ciudad)
                    .IsRequired()
                    .HasColumnName("CIUDAD")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasColumnName("CLAVE")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ClientContado)
                    .IsRequired()
                    .HasColumnName("CLIENT_CONTADO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Cobrador)
                    .HasColumnName("COBRADOR")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CodArea)
                    .IsRequired()
                    .HasColumnName("COD_AREA")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CodEstado)
                    .IsRequired()
                    .HasColumnName("COD_ESTADO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CodMcpo)
                    .IsRequired()
                    .HasColumnName("COD_MCPO")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CodPostal)
                    .IsRequired()
                    .HasColumnName("COD_POSTAL")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CodProv)
                    .IsRequired()
                    .HasColumnName("COD_PROV")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Codigo)
                    .HasColumnName("CODIGO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CondPago)
                    .HasColumnName("COND_PAGO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ContEspecial)
                    .IsRequired()
                    .HasColumnName("CONT_ESPECIAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CteMatriz)
                    .IsRequired()
                    .HasColumnName("CTE_MATRIZ")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DiaCobroJu)
                    .IsRequired()
                    .HasColumnName("DIA_COBRO_JU")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DiaCobroLu)
                    .IsRequired()
                    .HasColumnName("DIA_COBRO_LU")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DiaCobroMa)
                    .IsRequired()
                    .HasColumnName("DIA_COBRO_MA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DiaCobroMi)
                    .IsRequired()
                    .HasColumnName("DIA_COBRO_MI")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DiaCobroSa)
                    .IsRequired()
                    .HasColumnName("DIA_COBRO_SA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DiaCobroVi)
                    .IsRequired()
                    .HasColumnName("DIA_COBRO_VI")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasColumnName("DIRECCION")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Direccion1)
                    .IsRequired()
                    .HasColumnName("DIRECCION1")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Direccion2)
                    .IsRequired()
                    .HasColumnName("DIRECCION2")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Especial)
                    .IsRequired()
                    .HasColumnName("ESPECIAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("ESTADO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Fax)
                    .HasColumnName("FAX")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.FechaCambio)
                    .HasColumnName("FECHA_CAMBIO")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCerrado)
                    .HasColumnName("FECHA_CERRADO")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaInactivo)
                    .HasColumnName("FECHA_INACTIVO")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaReactivad)
                    .HasColumnName("FECHA_REACTIVAD")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaVenRegm)
                    .IsRequired()
                    .HasColumnName("FECHA_VEN_REGM")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagCambio)
                    .IsRequired()
                    .HasColumnName("FLAG_CAMBIO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagCerrado)
                    .IsRequired()
                    .HasColumnName("FLAG_CERRADO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagInactivo)
                    .IsRequired()
                    .HasColumnName("FLAG_INACTIVO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.GeoEstado)
                    .IsRequired()
                    .HasColumnName("GEO_ESTADO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.GeoMunParr)
                    .IsRequired()
                    .HasColumnName("GEO_MUN_PARR")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.LCredito)
                    .HasColumnName("L_CREDITO")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LimiteCredUt)
                    .HasColumnName("LIMITE_CRED_UT")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Municipio)
                    .IsRequired()
                    .HasColumnName("MUNICIPIO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Observacion)
                    .IsRequired()
                    .HasColumnName("OBSERVACION")
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ObservacionW)
                    .HasColumnName("OBSERVACION_W")
                    .HasColumnType("text");

                entity.Property(e => e.PaginaWeb)
                    .IsRequired()
                    .HasColumnName("PAGINA_WEB")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Parada)
                    .IsRequired()
                    .HasColumnName("PARADA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PromHistorico)
                    .HasColumnName("PROM_HISTORICO")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RamoNegocio)
                    .IsRequired()
                    .HasColumnName("RAMO_NEGOCIO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Rif)
                    .IsRequired()
                    .HasColumnName("RIF")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Saldoact)
                    .HasColumnName("SALDOACT")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SectorNegocio)
                    .IsRequired()
                    .HasColumnName("SECTOR_NEGOCIO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Solvencia)
                    .IsRequired()
                    .HasColumnName("SOLVENCIA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Sucursal)
                    .HasColumnName("SUCURSAL")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SumaHistorico)
                    .HasColumnName("SUMA_HISTORICO")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SumaProceso)
                    .HasColumnName("SUMA_PROCESO")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TImpuesto)
                    .HasColumnName("T_IMPUESTO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Telefono)
                    .HasColumnName("TELEFONO")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Telex)
                    .HasColumnName("TELEX")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasColumnName("TIPO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TipoNegocio)
                    .HasColumnName("TIPO_NEGOCIO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.TipoPago)
                    .IsRequired()
                    .HasColumnName("TIPO_PAGO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.UltCompra)
                    .HasColumnName("ULT_COMPRA")
                    .HasColumnType("datetime");

                entity.Property(e => e.UsuarioMod)
                    .IsRequired()
                    .HasColumnName("USUARIO_MOD")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Vendedor)
                    .IsRequired()
                    .HasColumnName("VENDEDOR")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Wsmy006>(entity =>
            {
                entity.HasKey(e => e.CodCategoria);

                entity.ToTable("WSMY006");

                entity.HasIndex(e => e.CodCategoria)
                    .HasName("IX_WSMY006")
                    .IsUnique();

                entity.Property(e => e.CodCategoria)
                    .HasColumnName("COD_CATEGORIA")
                    .ValueGeneratedNever();

                entity.Property(e => e.DesCategoria)
                    .HasColumnName("DES_CATEGORIA")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EquipoActualizacion).HasMaxLength(100);

                entity.Property(e => e.FechaActualizacion).HasColumnType("datetime");

                entity.Property(e => e.FlagComision)
                    .HasColumnName("FLAG_COMISION")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagDeGerente)
                    .HasColumnName("FLAG_DE_GERENTE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagDesactivo)
                    .HasColumnName("FLAG_DESACTIVO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagEstadisti)
                    .HasColumnName("FLAG_ESTADISTI")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagGerenteOf)
                    .HasColumnName("FLAG_GERENTE_OF")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagNoAprob)
                    .HasColumnName("FLAG_NO_APROB")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagSupervisor)
                    .HasColumnName("FLAG_SUPERVISOR")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagVendedor)
                    .HasColumnName("FLAG_VENDEDOR")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UsuarioActualiza).HasMaxLength(40);
            });

            modelBuilder.Entity<Wsmy060>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("WSMY060_INDEX01");

                entity.ToTable("WSMY060");

                entity.HasIndex(e => e.Recnum)
                    .HasName("WSMY060_INDEX00")
                    .IsUnique();

                entity.Property(e => e.Codigo)
                    .HasColumnName("CODIGO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FechaCambio)
                    .HasColumnName("FECHA_CAMBIO")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.NombreEstado)
                    .IsRequired()
                    .HasColumnName("NOMBRE_ESTADO")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Wsmy063>(entity =>
            {
                entity.HasKey(e => e.Tipo)
                    .HasName("WSMY063_INDEX01");

                entity.ToTable("WSMY063");

                entity.HasIndex(e => e.Recnum)
                    .HasName("WSMY063_INDEX00")
                    .IsUnique();

                entity.Property(e => e.Tipo)
                    .HasColumnName("TIPO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FechaCambio)
                    .HasColumnName("FECHA_CAMBIO")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.NombreTipo)
                    .IsRequired()
                    .HasColumnName("NOMBRE_TIPO")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TipoLegacy)
                    .HasMaxLength(3)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Wsmy123>(entity =>
            {
                entity.HasKey(e => e.CodOficina)
                    .HasName("WSMY123_INDEX01");

                entity.ToTable("WSMY123");

                entity.HasIndex(e => e.NomOficina)
                    .HasName("WSMY123_INDEX02")
                    .IsUnique();

                entity.HasIndex(e => e.Recnum)
                    .HasName("WSMY123_INDEX00")
                    .IsUnique();

                entity.Property(e => e.CodOficina)
                    .HasColumnName("COD_OFICINA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Abreviado).HasMaxLength(3);

                entity.Property(e => e.AdministradoraEmail)
                    .HasColumnName("Administradora_email")
                    .HasMaxLength(50);

                entity.Property(e => e.Analista2Email)
                    .HasColumnName("Analista2_email")
                    .HasMaxLength(50);

                entity.Property(e => e.AnalistaEmail)
                    .HasColumnName("Analista_email")
                    .HasMaxLength(50);

                entity.Property(e => e.Canal)
                    .HasColumnName("CANAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CarpetaDiseno)
                    .HasColumnName("CARPETA_DISENO")
                    .HasMaxLength(50);

                entity.Property(e => e.ClienteNacionales)
                    .HasColumnName("CLIENTE_NACIONALES")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodOficina2)
                    .IsRequired()
                    .HasColumnName("COD_OFICINA2")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CodigoJde)
                    .HasColumnName("CODIGO_JDE")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoParroq)
                    .HasColumnName("CODIGO_PARROQ")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.DataManagerEmail)
                    .HasColumnName("DataManager_email")
                    .HasMaxLength(50);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasColumnName("DIRECCION")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Direccion2)
                    .IsRequired()
                    .HasColumnName("DIRECCION2")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("ESTADO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Fax)
                    .IsRequired()
                    .HasColumnName("FAX")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.GerenteOficina)
                    .IsRequired()
                    .HasColumnName("GERENTE_OFICINA")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Idtitulo)
                    .HasColumnName("IDTITULO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Municipio)
                    .IsRequired()
                    .HasColumnName("MUNICIPIO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NomOficina)
                    .IsRequired()
                    .HasColumnName("NOM_OFICINA")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.OficinaActiva)
                    .HasColumnName("OFICINA_ACTIVA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OficinaSap)
                    .HasColumnName("OFICINA_SAP")
                    .HasMaxLength(4);

                entity.Property(e => e.Override)
                    .HasColumnName("OVERRIDE")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PAusente)
                    .HasColumnName("P_AUSENTE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')")
                    .HasComment("FLAG QUE IDENTIFICA AUSENCIA DEL PLANEADOR DE OFICINA");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Region)
                    .IsRequired()
                    .HasColumnName("REGION")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SinImpuesto)
                    .HasColumnName("SIN_IMPUESTO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasColumnName("TELEFONO")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.UsuarioAdministradora).HasMaxLength(50);

                entity.Property(e => e.UsuarioAnalista).HasMaxLength(50);

                entity.Property(e => e.VisibleReporte)
                    .HasColumnName("Visible_Reporte")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ZonaVentaSap)
                    .HasColumnName("ZONA_VENTA_SAP")
                    .HasMaxLength(6);
            });

            modelBuilder.Entity<Wsmy177>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WSMY177");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PorcComision)
                    .HasColumnName("PORC_COMISION")
                    .HasColumnType("numeric(6, 2)");

                entity.Property(e => e.RecordNumber).HasColumnName("RECORD_NUMBER");

                entity.Property(e => e.TipoProducto)
                    .HasColumnName("TIPO_PRODUCTO")
                    .HasColumnType("decimal(2, 0)");
            });

            modelBuilder.Entity<Wsmy273>(entity =>
            {
                entity.HasKey(e => e.CodigoEstatus);

                entity.ToTable("WSMY273");

                entity.Property(e => e.CodigoEstatus)
                    .HasColumnName("Codigo_Estatus")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.AfectaBacklog)
                    .HasColumnName("Afecta_Backlog")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AfectaCotizacion)
                    .HasColumnName("Afecta_cotizacion")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EstatusCerrado)
                    .HasColumnName("Estatus_Cerrado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagAnulado)
                    .HasColumnName("Flag_anulado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FlagAsignaciones).HasMaxLength(1);

                entity.Property(e => e.FlagCalculo)
                    .HasColumnName("Flag_calculo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FlagComp)
                    .HasColumnName("flag_comp")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FlagCotizador)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FlagEditar)
                    .HasColumnName("Flag_editar")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FlagEnAprob)
                    .HasColumnName("flag_en_aprob")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FlagEnviado)
                    .HasColumnName("Flag_Enviado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagListoCotizar)
                    .HasColumnName("flag_listo_cotizar")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FlagRechazo)
                    .HasColumnName("flag_rechazo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FlagSolicitudAnulada).HasMaxLength(1);

                entity.Property(e => e.FlagSolicitudPorAprobar).HasMaxLength(1);

                entity.Property(e => e.FlagSolicitudProcesada).HasMaxLength(1);

                entity.Property(e => e.FlagSolicitudRechazada).HasMaxLength(1);

                entity.Property(e => e.IdAprb)
                    .HasColumnName("ID_APRB")
                    .HasDefaultValueSql("((0))")
                    .HasComment("IDENTIFCACIÓN DEL ID DE ESTACIÓN RELACIONADO CON ESTADOS DE RECHAZOS");

                entity.Property(e => e.IdComp)
                    .HasColumnName("ID_COMP")
                    .HasDefaultValueSql("((0))")
                    .HasComment("ORDEN DE ESTACIONES EN COMPLEMENTO");

                entity.Property(e => e.Inactivo)
                    .HasColumnName("INACTIVO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')")
                    .HasComment("IDENTIFICA SI LA ESTACIÓN SE ENCUENTRA ACTIV");

                entity.Property(e => e.Responsable)
                    .HasMaxLength(40)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ResponsableEst)
                    .HasMaxLength(40)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Wsmy281>(entity =>
            {
                entity.HasKey(e => e.Email);

                entity.ToTable("WSMY281");

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Wssy030>(entity =>
            {
                entity.HasKey(e => e.CodigoRegion)
                    .HasName("WSSY030_INDEX01");

                entity.ToTable("WSSY030");

                entity.HasIndex(e => e.NombreRegion)
                    .HasName("WSSY030_INDEX03")
                    .IsUnique();

                entity.HasIndex(e => e.Recnum)
                    .HasName("WSSY030_INDEX00")
                    .IsUnique();

                entity.HasIndex(e => new { e.GerenteRegion, e.Recnum })
                    .HasName("WSSY030_INDEX02")
                    .IsUnique();

                entity.Property(e => e.CodigoRegion)
                    .HasColumnName("CODIGO_REGION")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CodigoJde)
                    .HasColumnName("CODIGO_JDE")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.GerenteRegion)
                    .IsRequired()
                    .HasColumnName("GERENTE_REGION")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NombreRegion)
                    .IsRequired()
                    .HasColumnName("NOMBRE_REGION")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.OverrideRegion)
                    .HasColumnName("OVERRIDE_REGION")
                    .HasColumnType("decimal(14, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Wssy031>(entity =>
            {
                entity.HasKey(e => e.CodigoMcpo)
                    .HasName("WSSY031_INDEX01");

                entity.ToTable("WSSY031");

                entity.HasIndex(e => e.Recnum)
                    .HasName("WSSY031_INDEX00")
                    .IsUnique();

                entity.HasIndex(e => new { e.NombreMcpo, e.CodigoMcpo })
                    .HasName("WSSY031_INDEX02")
                    .IsUnique();

                entity.Property(e => e.CodigoMcpo)
                    .HasColumnName("CODIGO_MCPO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CodigoEstado)
                    .HasColumnName("CODIGO_ESTADO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.NombreMcpo)
                    .IsRequired()
                    .HasColumnName("NOMBRE_MCPO")
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
