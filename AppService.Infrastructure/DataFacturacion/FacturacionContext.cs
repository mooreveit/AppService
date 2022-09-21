using System;
using AppService.Core.EntitiesFacturacion;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AppService.Infrastructure.DataFacturacion
{
    public partial class FacturacionContext : DbContext
    {
        public FacturacionContext()
        {
        }

        public FacturacionContext(DbContextOptions<FacturacionContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Ajustar> Ajustar { get; set; }
        public virtual DbSet<Cary016> Cary016 { get; set; }
        public virtual DbSet<Cary028> Cary028 { get; set; }
        public virtual DbSet<Cary029> Cary029 { get; set; }
        public virtual DbSet<Cary031> Cary031 { get; set; }
        public virtual DbSet<Cary034> Cary034 { get; set; }
        public virtual DbSet<Ciny024> Ciny024 { get; set; }
        public virtual DbSet<Ciny034> Ciny034 { get; set; }
        public virtual DbSet<Ciny035> Ciny035 { get; set; }
        public virtual DbSet<Ciny037> Ciny037 { get; set; }
        public virtual DbSet<Ciny042> Ciny042 { get; set; }
        public virtual DbSet<Ciny052> Ciny052 { get; set; }
        public virtual DbSet<Ciny053> Ciny053 { get; set; }
        public virtual DbSet<Ciny055> Ciny055 { get; set; }
        public virtual DbSet<Ciny056> Ciny056 { get; set; }
        public virtual DbSet<Ciny057> Ciny057 { get; set; }
        public virtual DbSet<Ciny057anulada> Ciny057anulada { get; set; }
        public virtual DbSet<Ciny058> Ciny058 { get; set; }
        public virtual DbSet<Ciny059> Ciny059 { get; set; }
        public virtual DbSet<Ciny060> Ciny060 { get; set; }
        public virtual DbSet<Ciny061> Ciny061 { get; set; }
        public virtual DbSet<Ciny062> Ciny062 { get; set; }
        public virtual DbSet<Ciny064> Ciny064 { get; set; }
        public virtual DbSet<Ciny065> Ciny065 { get; set; }
        public virtual DbSet<Ciny066> Ciny066 { get; set; }
        public virtual DbSet<Ciny067> Ciny067 { get; set; }
        public virtual DbSet<Ciny100> Ciny100 { get; set; }
        public virtual DbSet<Ciny101> Ciny101 { get; set; }
        public virtual DbSet<Ciny102> Ciny102 { get; set; }
        public virtual DbSet<Ciny103> Ciny103 { get; set; }
        public virtual DbSet<Ciny105> Ciny105 { get; set; }
        public virtual DbSet<Ciny206> Ciny206 { get; set; }
        public virtual DbSet<Ciny207> Ciny207 { get; set; }
        public virtual DbSet<Ciny208> Ciny208 { get; set; }
        public virtual DbSet<Ciny216> Ciny216 { get; set; }
        public virtual DbSet<Civy004> Civy004 { get; set; }
        public virtual DbSet<CondicionPagoxcliente> CondicionPagoxcliente { get; set; }
        public virtual DbSet<ConversionFactura> ConversionFactura { get; set; }
        public virtual DbSet<CpMaxima> CpMaxima { get; set; }
        public virtual DbSet<CpMinima> CpMinima { get; set; }
        public virtual DbSet<CpPromedio> CpPromedio { get; set; }
        public virtual DbSet<Csmy0031> Csmy0031 { get; set; }
        public virtual DbSet<Facturadonodespacho> Facturadonodespacho { get; set; }
        public virtual DbSet<Facturas> Facturas { get; set; }
        public virtual DbSet<FacturasDistribuidores> FacturasDistribuidores { get; set; }
        public virtual DbSet<LogCary029> LogCary029 { get; set; }
        public virtual DbSet<LogSysfile> LogSysfile { get; set; }
        public virtual DbSet<MunicipioFlete> MunicipioFlete { get; set; }
        public virtual DbSet<Notas> Notas { get; set; }
        public virtual DbSet<Notascredito> Notascredito { get; set; }
        public virtual DbSet<QueryRelaclienteFact01> QueryRelaclienteFact01 { get; set; }
        public virtual DbSet<Recuperados> Recuperados { get; set; }
        public virtual DbSet<Relaclientefact> Relaclientefact { get; set; }
        public virtual DbSet<Remisiones> Remisiones { get; set; }
        public virtual DbSet<RepCobranzasLcCp> RepCobranzasLcCp { get; set; }
        public virtual DbSet<Sheet1> Sheet1 { get; set; }
        public virtual DbSet<Sysfile> Sysfile { get; set; }
        public virtual DbSet<Tipos> Tipos { get; set; }
        public virtual DbSet<VCiny056> VCiny056 { get; set; }
        public virtual DbSet<VCuadreFa> VCuadreFa { get; set; }
        public virtual DbSet<VCuadreNc> VCuadreNc { get; set; }
        public virtual DbSet<VDiccionariofacturacion> VDiccionariofacturacion { get; set; }
        public virtual DbSet<VFacturasFiscalesConImagen> VFacturasFiscalesConImagen { get; set; }
        public virtual DbSet<VFaltantes> VFaltantes { get; set; }
        public virtual DbSet<VInvetarioReconversion> VInvetarioReconversion { get; set; }
        public virtual DbSet<VNotas> VNotas { get; set; }
        public virtual DbSet<VNotasdeCreditoaRefacturar> VNotasdeCreditoaRefacturar { get; set; }
        public virtual DbSet<VProductosNoInventariados> VProductosNoInventariados { get; set; }
        public virtual DbSet<View1> View1 { get; set; }
        public virtual DbSet<Winy025> Winy025 { get; set; }
        public virtual DbSet<Winy026> Winy026 { get; set; }
        public virtual DbSet<Winy032> Winy032 { get; set; }
        public virtual DbSet<Winy242> Winy242 { get; set; }
        public virtual DbSet<Winy243> Winy243 { get; set; }
        public virtual DbSet<Winy244> Winy244 { get; set; }
        public virtual DbSet<Winy245> Winy245 { get; set; }
        public virtual DbSet<Wsmy0032> Wsmy0032 { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=.;Database=Facturacion;User Id=userweb;Password=userweb2003;MultipleActiveResultSets=true");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ajustar>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AJUSTAR");

                entity.Property(e => e.Articulo)
                    .HasColumnName("ARTICULO")
                    .HasMaxLength(255);

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.Cantreal).HasColumnName("CANTREAL");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.PlistaPrueba).HasColumnName("PLISTA_PRUEBA");

                entity.Property(e => e.Plistareal).HasColumnName("PLISTAREAL");

                entity.Property(e => e.PrecioLista).HasColumnName("PRECIO_LISTA");

                entity.Property(e => e.PrecioVenta).HasColumnName("PRECIO_VENTA");

                entity.Property(e => e.PventaPrueba).HasColumnName("PVENTA_PRUEBA");

                entity.Property(e => e.Pventareal).HasColumnName("PVENTAREAL");

                entity.Property(e => e.Recnum).HasColumnName("RECNUM");

                entity.Property(e => e.ValorLista).HasColumnName("VALOR_LISTA");

                entity.Property(e => e.ValorVenta).HasColumnName("VALOR_VENTA");
            });

            modelBuilder.Entity<Cary016>(entity =>
            {
                entity.HasKey(e => new { e.Factura, e.Letra, e.TotLetra, e.Cliente, e.Correlativo })
                    .HasName("CARY016_INDEX01");

                entity.ToTable("CARY016");

                entity.HasIndex(e => e.Recnum)
                    .HasName("CARY016_INDEX00")
                    .IsUnique();

                entity.HasIndex(e => new { e.FechaFactura, e.Recnum })
                    .HasName("CARY016_INDEX10")
                    .IsUnique();

                entity.HasIndex(e => new { e.CodTrans, e.Comprobante, e.FechaConfirma, e.Recnum })
                    .HasName("CARY016_INDEX08")
                    .IsUnique();

                entity.HasIndex(e => new { e.Factura, e.CodTrans, e.Cliente, e.Recnum })
                    .HasName("CARY016_INDEX07")
                    .IsUnique();

                entity.HasIndex(e => new { e.Cliente, e.Factura, e.Letra, e.TotLetra, e.FechaFactura, e.Correlativo })
                    .HasName("CARY016_INDEX05")
                    .IsUnique();

                entity.HasIndex(e => new { e.FechaConfirma, e.Comprobante, e.Cliente, e.Factura, e.Letra, e.Recnum })
                    .HasName("CARY016_INDEX06")
                    .IsUnique();

                entity.HasIndex(e => new { e.FechaConfirma, e.Factura, e.CodTrans, e.Letra, e.TotLetra, e.Recnum })
                    .HasName("CARY016_INDEX02")
                    .IsUnique();

                entity.HasIndex(e => new { e.Centro, e.Cliente, e.Factura, e.Letra, e.TotLetra, e.Correlativo, e.CodTrans })
                    .HasName("CARY016_INDEX04")
                    .IsUnique();

                entity.HasIndex(e => new { e.Pais, e.Cliente, e.Factura, e.Letra, e.TotLetra, e.Correlativo, e.CodTrans })
                    .HasName("CARY016_INDEX03")
                    .IsUnique();

                entity.HasIndex(e => new { e.Vendedor, e.Cliente, e.Factura, e.Letra, e.TotLetra, e.Correlativo, e.CodTrans, e.Recnum })
                    .HasName("CARY016_INDEX09")
                    .IsUnique();

                entity.Property(e => e.Factura)
                    .HasColumnName("FACTURA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Letra)
                    .HasColumnName("LETRA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TotLetra)
                    .HasColumnName("TOT_LETRA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Cliente)
                    .HasColumnName("CLIENTE")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Correlativo)
                    .HasColumnName("CORRELATIVO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Centro)
                    .HasColumnName("CENTRO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CodTrans)
                    .HasColumnName("COD_TRANS")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ComisPag)
                    .IsRequired()
                    .HasColumnName("COMIS_PAG")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Comprobante)
                    .HasColumnName("COMPROBANTE")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.FechaCobro)
                    .HasColumnName("FECHA_COBRO")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaConfirma)
                    .HasColumnName("FECHA_CONFIRMA")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.FechaFactura)
                    .HasColumnName("FECHA_FACTURA")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.FechaVenci)
                    .HasColumnName("FECHA_VENCI")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaVisita)
                    .HasColumnName("FECHA_VISITA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Impuesto)
                    .HasColumnName("IMPUESTO")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Linea)
                    .HasColumnName("LINEA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.MontoOrig)
                    .HasColumnName("MONTO_ORIG$")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.MontoOriginal)
                    .HasColumnName("MONTO_ORIGINAL")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.MontoPag)
                    .HasColumnName("MONTO_PAG$")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.MontoPagado)
                    .HasColumnName("MONTO_PAGADO")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Orden)
                    .HasColumnName("ORDEN")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.OtrosCargos)
                    .HasColumnName("OTROS_CARGOS")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.OtrosCargos1)
                    .HasColumnName("OTROS_CARGOS$")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.OtrosCreditos)
                    .HasColumnName("OTROS_CREDITOS")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.OtrosCreditos1)
                    .HasColumnName("OTROS_CREDITOS$")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Pais)
                    .HasColumnName("PAIS")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PorcConcesion)
                    .HasColumnName("PORC_CONCESION")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Recibo)
                    .HasColumnName("RECIBO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Saldo)
                    .HasColumnName("SALDO")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Saldo1)
                    .HasColumnName("SALDO$")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Supervisor)
                    .IsRequired()
                    .HasColumnName("SUPERVISOR")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TipoDocRecib)
                    .IsRequired()
                    .HasColumnName("TIPO_DOC_RECIB")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TipoProducto)
                    .IsRequired()
                    .HasColumnName("TIPO_PRODUCTO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Vendedor)
                    .IsRequired()
                    .HasColumnName("VENDEDOR")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Cary028>(entity =>
            {
                entity.HasKey(e => e.NotaCredito)
                    .HasName("CARY028_INDEX01");

                entity.ToTable("CARY028");

                entity.HasIndex(e => e.Orden)
                    .HasName("dep_cary028orden");

                entity.HasIndex(e => e.Recnum)
                    .HasName("CARY028_INDEX00")
                    .IsUnique();

                entity.HasIndex(e => new { e.Factura, e.NotaCredito })
                    .HasName("CARY028_INDEX05")
                    .IsUnique();

                entity.HasIndex(e => new { e.Fecha, e.NotaCredito })
                    .HasName("CARY028_INDEX02")
                    .IsUnique();

                entity.HasIndex(e => new { e.Iq, e.Fecha })
                    .HasName("IX_CARY028");

                entity.HasIndex(e => new { e.Motivo, e.NotaCredito })
                    .HasName("CARY028_INDEX04")
                    .IsUnique();

                entity.HasIndex(e => new { e.Orden, e.Recnum })
                    .HasName("CARY028_INDEX03")
                    .IsUnique();

                entity.HasIndex(e => new { e.FlagImpreso, e.NotaCredito, e.Recnum })
                    .HasName("CARY028_INDEX12")
                    .IsUnique();

                entity.Property(e => e.NotaCredito)
                    .HasColumnName("NOTA_CREDITO")
                    .ValueGeneratedNever();

                entity.Property(e => e.AfectaFactura)
                    .IsRequired()
                    .HasColumnName("AFECTA_FACTURA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.AfectaNota)
                    .IsRequired()
                    .HasColumnName("AFECTA_NOTA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Batch)
                    .HasColumnName("BATCH")
                    .HasColumnType("decimal(14, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CantResumen)
                    .HasColumnName("CANT_RESUMEN")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.CantRevive)
                    .HasColumnName("CANT_REVIVE")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Cliente).HasColumnName("CLIENTE");

                entity.Property(e => e.ColetillaInd1)
                    .HasColumnName("COLETILLA_IND1")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ColetillaInd2)
                    .HasColumnName("COLETILLA_IND2")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ColetillaInd3)
                    .HasColumnName("COLETILLA_IND3")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ColetillaInd4)
                    .HasColumnName("COLETILLA_IND4")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Contrapartida)
                    .IsRequired()
                    .HasColumnName("CONTRAPARTIDA")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CuentaContable)
                    .HasColumnName("CUENTA_CONTABLE")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.DescResumen1)
                    .HasColumnName("DESC_RESUMEN1")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.DescResumen2)
                    .HasColumnName("DESC_RESUMEN2")
                    .HasMaxLength(60)
                    .IsUnicode(false);

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

                entity.Property(e => e.Direccion3)
                    .HasColumnName("DIRECCION3")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.EstadoEntregar).HasMaxLength(2);

                entity.Property(e => e.EstadoFacturar).HasMaxLength(2);

                entity.Property(e => e.Factura).HasColumnName("FACTURA");

                entity.Property(e => e.Fecha)
                    .HasColumnName("FECHA")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.FechaFactura)
                    .HasColumnName("FECHA_FACTURA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlagAfecVende)
                    .IsRequired()
                    .HasColumnName("FLAG_AFEC_VENDE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagComision)
                    .IsRequired()
                    .HasColumnName("FLAG_COMISION")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagImpreso)
                    .IsRequired()
                    .HasColumnName("FLAG_IMPRESO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.IdDirEntregar).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IdDirFacturar).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ImpPorConsumo)
                    .HasColumnName("IMP_POR_CONSUMO")
                    .HasColumnType("decimal(14, 4)");

                entity.Property(e => e.ImpSobVentas)
                    .HasColumnName("IMP_SOB_VENTAS")
                    .HasColumnType("decimal(14, 4)");

                entity.Property(e => e.Impuesto)
                    .HasColumnName("IMPUESTO")
                    .HasColumnType("decimal(14, 4)");

                entity.Property(e => e.ImpuestoDol)
                    .HasColumnName("IMPUESTO_DOL")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Iq).HasColumnName("IQ");

                entity.Property(e => e.Ir).HasColumnName("IR");

                entity.Property(e => e.JobId).HasColumnName("JOB_ID");

                entity.Property(e => e.Motivo).HasColumnName("MOTIVO");

                entity.Property(e => e.MunicipioEntregar).HasMaxLength(2);

                entity.Property(e => e.MunicipioFacturar).HasMaxLength(2);

                entity.Property(e => e.NombreCliente)
                    .IsRequired()
                    .HasColumnName("NOMBRE_CLIENTE")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NroControl).HasColumnName("NRO_CONTROL");

                entity.Property(e => e.Nula)
                    .IsRequired()
                    .HasColumnName("NULA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ObsCobranzas1)
                    .HasColumnName("OBS_COBRANZAS1")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ObsCobranzas2)
                    .HasColumnName("OBS_COBRANZAS2")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ObsCobranzas3)
                    .HasColumnName("OBS_COBRANZAS3")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ObsCobranzas4)
                    .HasColumnName("OBS_COBRANZAS4")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Observacion1)
                    .IsRequired()
                    .HasColumnName("OBSERVACION1")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Observacion2)
                    .IsRequired()
                    .HasColumnName("OBSERVACION2")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Observacion3)
                    .IsRequired()
                    .HasColumnName("OBSERVACION3")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.PorcConcesion)
                    .HasColumnName("PORC_CONCESION")
                    .HasColumnType("decimal(8, 4)");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Responsable)
                    .IsRequired()
                    .HasColumnName("RESPONSABLE")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ReviveJob)
                    .IsRequired()
                    .HasColumnName("REVIVE_JOB")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Rif)
                    .IsRequired()
                    .HasColumnName("RIF")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Rif2)
                    .IsRequired()
                    .HasColumnName("RIF2")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.RimpPorConsum)
                    .HasColumnName("RIMP_POR_CONSUM")
                    .HasColumnType("decimal(14, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RimpSobVentas)
                    .HasColumnName("RIMP_SOB_VENTAS")
                    .HasColumnType("decimal(14, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rimpuesto)
                    .HasColumnName("RIMPUESTO")
                    .HasColumnType("decimal(14, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rvalor)
                    .HasColumnName("RVALOR")
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RvalorLista)
                    .HasColumnName("RVALOR_LISTA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Supervisor)
                    .IsRequired()
                    .HasColumnName("SUPERVISOR")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TasaImpuesto)
                    .HasColumnName("TASA_IMPUESTO")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.TipoCambio)
                    .HasColumnName("TIPO_CAMBIO")
                    .HasColumnType("decimal(10, 4)");

                entity.Property(e => e.TipoDoc).HasColumnName("TIPO_DOC");

                entity.Property(e => e.TipoProducto)
                    .IsRequired()
                    .HasColumnName("TIPO_PRODUCTO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.UndResumen)
                    .HasColumnName("UND_RESUMEN")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnidadFacturar).HasColumnName("UNIDAD_FACTURAR");

                entity.Property(e => e.Usuario)
                    .HasColumnName("USUARIO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Valor)
                    .HasColumnName("VALOR")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Valor1)
                    .HasColumnName("VALOR_$")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ValorLista)
                    .HasColumnName("VALOR_LISTA")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.ValorListad)
                    .HasColumnName("VALOR_LISTAD")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.ValorVentad)
                    .HasColumnName("VALOR_VENTAD")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Valorfactura)
                    .HasColumnName("VALORFACTURA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Vendedor)
                    .IsRequired()
                    .HasColumnName("VENDEDOR")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Cary029>(entity =>
            {
                entity.HasKey(e => new { e.NumeroNota, e.Recnum })
                    .HasName("CARY029_INDEX01");

                entity.ToTable("CARY029");

                entity.HasIndex(e => e.Orden)
                    .HasName("dep_cary029orden");

                entity.HasIndex(e => e.Recnum)
                    .HasName("CARY029_INDEX00")
                    .IsUnique();

                entity.HasIndex(e => new { e.Año, e.Mes })
                    .HasName("IX_CARY029");

                entity.HasIndex(e => new { e.FechaNota, e.Recnum })
                    .HasName("CARY029_INDEX03")
                    .IsUnique();

                entity.HasIndex(e => new { e.Año, e.Mes, e.CodProducto })
                    .HasName("IX_CARY029_2");

                entity.HasIndex(e => new { e.CodProducto, e.FechaNota, e.Recnum })
                    .HasName("CARY029_INDEX07")
                    .IsUnique();

                entity.HasIndex(e => new { e.FechaNota, e.NumeroNota, e.Recnum })
                    .HasName("CARY029_INDEX02")
                    .IsUnique();

                entity.HasIndex(e => new { e.Linea1, e.Partes, e.MetodoPrecio1, e.TipoPapel, e.Recnum })
                    .HasName("CARY029_INDEX09")
                    .IsUnique();

                entity.Property(e => e.NumeroNota).HasColumnName("NUMERO_NOTA");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Almacen)
                    .HasColumnName("ALMACEN")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Batch)
                    .HasColumnName("BATCH")
                    .HasColumnType("decimal(14, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BsMcFinan)
                    .HasColumnName("BS_MC_FINAN")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BsMcFinansc)
                    .HasColumnName("BS_MC_FINANSC")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BsMcPapel)
                    .HasColumnName("BS_MC_PAPEL")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BsMcPapelsc)
                    .HasColumnName("BS_MC_PAPELSC")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cantidad)
                    .HasColumnName("CANTIDAD")
                    .HasColumnType("decimal(12, 4)");

                entity.Property(e => e.CodProducto)
                    .IsRequired()
                    .HasColumnName("COD_PRODUCTO")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Comision)
                    .HasColumnName("COMISION")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Copy)
                    .HasColumnName("COPY")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Costo).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CtaConc)
                    .IsRequired()
                    .HasColumnName("CTA_CONC")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CtaLista)
                    .IsRequired()
                    .HasColumnName("CTA_LISTA")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Descripcion2)
                    .HasColumnName("DESCRIPCION2")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Estadisticas)
                    .IsRequired()
                    .HasColumnName("ESTADISTICAS")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Exento)
                    .HasColumnName("EXENTO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Familia)
                    .IsRequired()
                    .HasColumnName("FAMILIA")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FamiliaProducc)
                    .IsRequired()
                    .HasColumnName("FAMILIA_PRODUCC")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FechaNota)
                    .HasColumnName("FECHA_NOTA")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.FechaOrden)
                    .HasColumnName("FECHA_ORDEN")
                    .HasColumnType("datetime");

                entity.Property(e => e.FormasUnidad)
                    .HasColumnName("FORMAS_UNIDAD")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.IdSolicitudCosto).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdSolicitudCostoCpj)
                    .HasColumnName("IdSolicitudCosto_CPJ")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Idsolicitud)
                    .HasColumnName("idsolicitud")
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ImpPorConsumo)
                    .HasColumnName("IMP_POR_CONSUMO")
                    .HasColumnType("decimal(12, 4)");

                entity.Property(e => e.ImpSobVentas)
                    .HasColumnName("IMP_SOB_VENTAS")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ImpuestoDol)
                    .HasColumnName("IMPUESTO_DOL")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Iva)
                    .HasColumnName("IVA")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Ivarefact)
                    .HasColumnName("IVAREFACT")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.JobId)
                    .HasColumnName("JOB_ID")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Linea1)
                    .IsRequired()
                    .HasColumnName("LINEA1")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.LineaIncoming).HasColumnName("LINEA_INCOMING");

                entity.Property(e => e.LineaProduccio)
                    .IsRequired()
                    .HasColumnName("LINEA_PRODUCCIO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ListaUniDol)
                    .HasColumnName("LISTA_UNI_DOL")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.MetodoPrecio1)
                    .IsRequired()
                    .HasColumnName("METODO_PRECIO1")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Millares)
                    .HasColumnName("MILLARES")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Orden)
                    .HasColumnName("ORDEN")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Partes)
                    .IsRequired()
                    .HasColumnName("PARTES")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Pieslineales)
                    .HasColumnName("PIESLINEALES")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PorcMcFinan)
                    .HasColumnName("PORC_MC_FINAN")
                    .HasColumnType("decimal(8, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PorcMcFinansc)
                    .HasColumnName("PORC_MC_FINANSC")
                    .HasColumnType("decimal(8, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PorcMcPapel)
                    .HasColumnName("PORC_MC_PAPEL")
                    .HasColumnType("decimal(8, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PorcMcPapelsc)
                    .HasColumnName("PORC_MC_PAPELSC")
                    .HasColumnType("decimal(8, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PrecioVenta)
                    .HasColumnName("PRECIO_VENTA")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.Preciounidad)
                    .HasColumnName("PRECIOUNIDAD")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.RecalcularMargen).HasMaxLength(1);

                entity.Property(e => e.RimpPorConsum)
                    .HasColumnName("RIMP_POR_CONSUM")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.RimpSobVentas)
                    .HasColumnName("RIMP_SOB_VENTAS")
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Riva)
                    .HasColumnName("RIVA")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.RprecioVenta)
                    .HasColumnName("RPRECIO_VENTA")
                    .HasColumnType("decimal(20, 6)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rpreciounidad)
                    .HasColumnName("RPRECIOUNIDAD")
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RvalorLista)
                    .HasColumnName("RVALOR_LISTA")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.RvalorVenta)
                    .HasColumnName("RVALOR_VENTA")
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TipoCambio)
                    .HasColumnName("TIPO_CAMBIO")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.TipoDoc).HasColumnName("TIPO_DOC");

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

                entity.Property(e => e.TotalparcialFa)
                    .HasColumnName("TOTALPARCIAL_FA")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UnidadFacturar)
                    .HasColumnName("UNIDAD_FACTURAR")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Unidadesfact)
                    .HasColumnName("UNIDADESFACT")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Usuario)
                    .HasColumnName("USUARIO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Valor)
                    .HasColumnName("VALOR_$")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ValorLista)
                    .HasColumnName("VALOR_LISTA")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ValorListad)
                    .HasColumnName("VALOR_LISTAD")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.ValorVenta)
                    .HasColumnName("VALOR_VENTA")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ValorVentaCpj)
                    .HasColumnName("VALOR_VENTA_CPJ")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.ValorVentad)
                    .HasColumnName("VALOR_VENTAD")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.VentaUniDol)
                    .HasColumnName("VENTA_UNI_DOL")
                    .HasColumnType("decimal(16, 2)");
            });

            modelBuilder.Entity<Cary031>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("CARY031_INDEX01");

                entity.ToTable("CARY031");

                entity.HasIndex(e => e.Recnum)
                    .HasName("CARY031_INDEX00")
                    .IsUnique();

                entity.Property(e => e.Codigo)
                    .HasColumnName("CODIGO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AfectaVendedor)
                    .IsRequired()
                    .HasColumnName("AFECTA_VENDEDOR")
                    .HasMaxLength(1)
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

            modelBuilder.Entity<Cary034>(entity =>
            {
                entity.HasKey(e => new { e.CodigoCliente, e.FechaVigencia })
                    .HasName("CARY034_INDEX01");

                entity.ToTable("CARY034");

                entity.HasIndex(e => e.Recnum)
                    .HasName("CARY034_INDEX00")
                    .IsUnique();

                entity.Property(e => e.CodigoCliente)
                    .HasColumnName("CODIGO_CLIENTE")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.FechaVigencia)
                    .HasColumnName("FECHA_VIGENCIA")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.NoAutorizacion)
                    .IsRequired()
                    .HasColumnName("NO_AUTORIZACION")
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Ciny024>(entity =>
            {
                entity.HasKey(e => e.Recnum)
                    .HasName("CINY024_INDEX00");

                entity.ToTable("CINY024");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Cliente)
                    .IsRequired()
                    .HasColumnName("CLIENTE")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Concesion)
                    .HasColumnName("CONCESION")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CondicionPago)
                    .IsRequired()
                    .HasColumnName("CONDICION_PAGO")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Factura)
                    .HasColumnName("FACTURA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.FechaDesde)
                    .HasColumnName("FECHA_DESDE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaFactura)
                    .HasColumnName("FECHA_FACTURA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaHasta)
                    .HasColumnName("FECHA_HASTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Impuesto)
                    .HasColumnName("IMPUESTO")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Oficina)
                    .IsRequired()
                    .HasColumnName("OFICINA")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Orden)
                    .HasColumnName("ORDEN")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Remision)
                    .HasColumnName("REMISION")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Rimpuesto)
                    .HasColumnName("RIMPUESTO")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RvalorVenta)
                    .HasColumnName("RVALOR_VENTA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TotalFactura)
                    .HasColumnName("TOTAL_FACTURA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorVenta)
                    .HasColumnName("VALOR_VENTA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<Ciny034>(entity =>
            {
                entity.HasKey(e => new { e.Pais, e.LineaProduccio, e.FamiliaProducc })
                    .HasName("CINY034_INDEX01");

                entity.ToTable("CINY034");

                entity.HasIndex(e => e.Recnum)
                    .HasName("CINY034_INDEX00")
                    .IsUnique();

                entity.HasIndex(e => new { e.LineaProduccio, e.FamiliaProducc, e.Pais })
                    .HasName("CINY034_INDEX02")
                    .IsUnique();

                entity.Property(e => e.Pais)
                    .HasColumnName("PAIS")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.LineaProduccio)
                    .HasColumnName("LINEA_PRODUCCIO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FamiliaProducc)
                    .HasColumnName("FAMILIA_PRODUCC")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CtaConceJob)
                    .HasColumnName("CTA_CONCE_JOB")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CtaConcesion)
                    .HasColumnName("CTA_CONCESION")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CtaListaJob)
                    .HasColumnName("CTA_LISTA_JOB")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CtaVtaLista)
                    .HasColumnName("CTA_VTA_LISTA")
                    .HasColumnType("decimal(12, 2)")
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

            modelBuilder.Entity<Ciny035>(entity =>
            {
                entity.HasKey(e => new { e.TipoProducto, e.SumaResta })
                    .HasName("CINY035_INDEX01");

                entity.ToTable("CINY035");

                entity.HasIndex(e => e.Recnum)
                    .HasName("CINY035_INDEX00")
                    .IsUnique();

                entity.Property(e => e.TipoProducto)
                    .HasColumnName("TIPO_PRODUCTO")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SumaResta)
                    .HasColumnName("SUMA_RESTA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Campo)
                    .HasColumnName("CAMPO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.FechaDesde)
                    .HasColumnName("FECHA_DESDE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaHasta)
                    .HasColumnName("FECHA_HASTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Hora)
                    .IsRequired()
                    .HasColumnName("HORA")
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Lista)
                    .HasColumnName("LISTA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TasaDolar)
                    .HasColumnName("TASA_DOLAR")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Venta)
                    .HasColumnName("VENTA")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<Ciny037>(entity =>
            {
                entity.HasKey(e => new { e.TipoProducto, e.SumaResta })
                    .HasName("CINY037_INDEX01");

                entity.ToTable("CINY037");

                entity.HasIndex(e => e.Recnum)
                    .HasName("CINY037_INDEX00")
                    .IsUnique();

                entity.Property(e => e.TipoProducto)
                    .HasColumnName("TIPO_PRODUCTO")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SumaResta)
                    .HasColumnName("SUMA_RESTA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Campo)
                    .HasColumnName("CAMPO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.FechaDesde)
                    .HasColumnName("FECHA_DESDE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaHasta)
                    .HasColumnName("FECHA_HASTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Hora)
                    .IsRequired()
                    .HasColumnName("HORA")
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Lista)
                    .HasColumnName("LISTA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TasaDolar)
                    .HasColumnName("TASA_DOLAR")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Venta)
                    .HasColumnName("VENTA")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<Ciny042>(entity =>
            {
                entity.HasKey(e => new { e.FechaComprb, e.TipoComprb, e.NumeroComprb, e.CuentaContab })
                    .HasName("CINY042_INDEX01");

                entity.ToTable("CINY042");

                entity.HasIndex(e => e.Recnum)
                    .HasName("CINY042_INDEX00")
                    .IsUnique();

                entity.HasIndex(e => new { e.TipoComprb, e.CuentaContab })
                    .HasName("CINY042_INDEX02")
                    .IsUnique();

                entity.HasIndex(e => new { e.Cia, e.NumeroComprb, e.TipoComprb, e.Recnum })
                    .HasName("CINY042_INDEX03")
                    .IsUnique();

                entity.Property(e => e.FechaComprb)
                    .HasColumnName("FECHA_COMPRB")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.TipoComprb)
                    .HasColumnName("TIPO_COMPRB")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NumeroComprb)
                    .HasColumnName("NUMERO_COMPRB")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CuentaContab)
                    .HasColumnName("CUENTA_CONTAB")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Cia)
                    .IsRequired()
                    .HasColumnName("CIA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Concepto)
                    .IsRequired()
                    .HasColumnName("CONCEPTO")
                    .HasMaxLength(42)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Credito)
                    .HasColumnName("CREDITO")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Debito)
                    .HasColumnName("DEBITO")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Linea)
                    .HasColumnName("LINEA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Mescon)
                    .HasColumnName("MESCON")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Ciny052>(entity =>
            {
                entity.HasKey(e => e.Orden)
                    .HasName("CINY052_INDEX01");

                entity.ToTable("CINY052");

                entity.HasIndex(e => e.Recnum)
                    .HasName("CINY052_INDEX00")
                    .IsUnique();

                entity.Property(e => e.Orden)
                    .HasColumnName("ORDEN")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AnoFactura)
                    .HasColumnName("ANO_FACTURA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Anticipo)
                    .HasColumnName("ANTICIPO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Anulada)
                    .IsRequired()
                    .HasColumnName("ANULADA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Cajas)
                    .HasColumnName("CAJAS")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CentroFact)
                    .HasColumnName("CENTRO_FACT")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Cliente)
                    .HasColumnName("CLIENTE")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CodEdo)
                    .IsRequired()
                    .HasColumnName("COD_EDO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CodMcpo)
                    .IsRequired()
                    .HasColumnName("COD_MCPO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CodigoRepetici)
                    .HasColumnName("CODIGO_REPETICI")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CondicionPago)
                    .HasColumnName("CONDICION_PAGO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Copy)
                    .HasColumnName("COPY")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CredConta)
                    .IsRequired()
                    .HasColumnName("CRED_CONTA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Despachar)
                    .IsRequired()
                    .HasColumnName("DESPACHAR")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccFiscal)
                    .HasColumnName("DIRECC_FISCAL")
                    .HasColumnType("text");

                entity.Property(e => e.DireccionEmb1)
                    .IsRequired()
                    .HasColumnName("DIRECCION_EMB1")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccionEmb2)
                    .IsRequired()
                    .HasColumnName("DIRECCION_EMB2")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccionEmb3)
                    .IsRequired()
                    .HasColumnName("DIRECCION_EMB3")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccionFact1)
                    .IsRequired()
                    .HasColumnName("DIRECCION_FACT1")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccionFact2)
                    .IsRequired()
                    .HasColumnName("DIRECCION_FACT2")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccionFact3)
                    .IsRequired()
                    .HasColumnName("DIRECCION_FACT3")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Dolar)
                    .IsRequired()
                    .HasColumnName("DOLAR")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FactFinal)
                    .HasColumnName("FACT_FINAL")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Factura)
                    .HasColumnName("FACTURA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.FacturaRepetir)
                    .HasColumnName("FACTURA_REPETIR")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.FechaFactura)
                    .HasColumnName("FECHA_FACTURA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaRecibCli)
                    .HasColumnName("FECHA_RECIB_CLI")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fiscal)
                    .IsRequired()
                    .HasColumnName("FISCAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagComision)
                    .IsRequired()
                    .HasColumnName("FLAG_COMISION")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Flete)
                    .HasColumnName("FLETE")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Imp)
                    .HasColumnName("IMP")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LineaAnt)
                    .HasColumnName("LINEA_ANT")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.MesFactura)
                    .HasColumnName("MES_FACTURA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.MultiplesEmb)
                    .IsRequired()
                    .HasColumnName("MULTIPLES_EMB")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NcFacturar)
                    .HasColumnName("NC_FACTURAR")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.NitEmb)
                    .HasColumnName("NIT_EMB")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.NitFact)
                    .HasColumnName("NIT_FACT")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NombreEmb)
                    .IsRequired()
                    .HasColumnName("NOMBRE_EMB")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NombreFact)
                    .IsRequired()
                    .HasColumnName("NOMBRE_FACT")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Observacion1)
                    .IsRequired()
                    .HasColumnName("OBSERVACION1")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Observacion2)
                    .IsRequired()
                    .HasColumnName("OBSERVACION2")
                    .HasMaxLength(79)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Observacion3)
                    .IsRequired()
                    .HasColumnName("OBSERVACION3")
                    .HasMaxLength(79)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.OrdenCompra)
                    .IsRequired()
                    .HasColumnName("ORDEN_COMPRA")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.OtroGasto1)
                    .HasColumnName("OTRO_GASTO_1")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.OtroGasto1R)
                    .HasColumnName("OTRO_GASTO_1_R")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.OtroGasto2)
                    .HasColumnName("OTRO_GASTO_2")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Pais)
                    .HasColumnName("PAIS")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RegistroTribut)
                    .IsRequired()
                    .HasColumnName("REGISTRO_TRIBUT")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.RifEmb)
                    .IsRequired()
                    .HasColumnName("RIF_EMB")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.RifFact)
                    .IsRequired()
                    .HasColumnName("RIF_FACT")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SdoAnticipo)
                    .HasColumnName("SDO_ANTICIPO")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SdoAnticipoDo)
                    .HasColumnName("SDO_ANTICIPO_DO")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Seguro)
                    .HasColumnName("SEGURO")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Supervisor)
                    .IsRequired()
                    .HasColumnName("SUPERVISOR")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TasaAnticipo)
                    .HasColumnName("TASA_ANTICIPO")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TasaImpuesto)
                    .HasColumnName("TASA_IMPUESTO")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TipoCambio)
                    .HasColumnName("TIPO_CAMBIO")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TipoDoc)
                    .HasColumnName("TIPO_DOC")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TotalParcial)
                    .IsRequired()
                    .HasColumnName("TOTAL_PARCIAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Transmision)
                    .IsRequired()
                    .HasColumnName("TRANSMISION")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.UnidadFacturar)
                    .HasColumnName("UNIDAD_FACTURAR")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorLista)
                    .HasColumnName("VALOR_LISTA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorListaR)
                    .HasColumnName("VALOR_LISTA_R")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorListad)
                    .HasColumnName("VALOR_LISTAD")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorListadR)
                    .HasColumnName("VALOR_LISTAD_R")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorVenta)
                    .HasColumnName("VALOR_VENTA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorVentaR)
                    .HasColumnName("VALOR_VENTA_R")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorVentad)
                    .HasColumnName("VALOR_VENTAD")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorVentadR)
                    .HasColumnName("VALOR_VENTAD_R")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.VendGestion)
                    .IsRequired()
                    .HasColumnName("VEND_GESTION")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Vendedor)
                    .IsRequired()
                    .HasColumnName("VENDEDOR")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Ciny053>(entity =>
            {
                entity.HasKey(e => new { e.JobId, e.Recnum })
                    .HasName("CINY053_INDEX01");

                entity.ToTable("CINY053");

                entity.HasIndex(e => e.Recnum)
                    .HasName("CINY053_INDEX00")
                    .IsUnique();

                entity.HasIndex(e => new { e.Articulo, e.Orden })
                    .HasName("CINY053_INDEX03")
                    .IsUnique();

                entity.HasIndex(e => new { e.Orden, e.Recnum })
                    .HasName("CINY053_INDEX02")
                    .IsUnique();

                entity.Property(e => e.JobId)
                    .HasColumnName("JOB_ID")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Articulo)
                    .IsRequired()
                    .HasColumnName("ARTICULO")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Bultos)
                    .HasColumnName("BULTOS")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Cantidad)
                    .HasColumnName("CANTIDAD")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CantidadOfic)
                    .HasColumnName("CANTIDAD_OFIC")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CentroFact)
                    .HasColumnName("CENTRO_FACT")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CtdEntregar)
                    .HasColumnName("CTD_ENTREGAR")
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

                entity.Property(e => e.DireccionEmb)
                    .HasColumnName("DIRECCION_EMB")
                    .HasColumnType("text");

                entity.Property(e => e.DireccionFact)
                    .HasColumnName("DIRECCION_FACT")
                    .HasColumnType("text");

                entity.Property(e => e.EntNumDesde)
                    .HasColumnName("ENT_NUM_DESDE")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.EntNumHasta)
                    .HasColumnName("ENT_NUM_HASTA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.EntPrefDesde)
                    .IsRequired()
                    .HasColumnName("ENT_PREF_DESDE")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.EntPrefHasta)
                    .IsRequired()
                    .HasColumnName("ENT_PREF_HASTA")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.EntSufiDesde)
                    .IsRequired()
                    .HasColumnName("ENT_SUFI_DESDE")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.EntSufiHasta)
                    .IsRequired()
                    .HasColumnName("ENT_SUFI_HASTA")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Factura)
                    .HasColumnName("FACTURA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.FacturaAfecta)
                    .HasColumnName("FACTURA_AFECTA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Familia)
                    .IsRequired()
                    .HasColumnName("FAMILIA")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FamiliaProducc)
                    .IsRequired()
                    .HasColumnName("FAMILIA_PRODUCC")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FecComproClte)
                    .HasColumnName("FEC_COMPRO_CLTE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FecRecPlaneac)
                    .HasColumnName("FEC_REC_PLANEAC")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaFactura)
                    .HasColumnName("FECHA_FACTURA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaOfic)
                    .HasColumnName("FECHA_OFIC")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaOrden)
                    .HasColumnName("FECHA_ORDEN")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlagFaltante)
                    .IsRequired()
                    .HasColumnName("FLAG_FALTANTE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagImprenta)
                    .IsRequired()
                    .HasColumnName("FLAG_IMPRENTA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagRetenido)
                    .IsRequired()
                    .HasColumnName("FLAG_RETENIDO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagTipoJob)
                    .IsRequired()
                    .HasColumnName("FLAG_TIPO_JOB")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagTipoOrden)
                    .IsRequired()
                    .HasColumnName("FLAG_TIPO_ORDEN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FormasBajotiro)
                    .HasColumnName("FORMAS_BAJOTIRO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.FormasUnidad)
                    .HasColumnName("FORMAS_UNIDAD")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Impuesto1)
                    .HasColumnName("IMPUESTO_1")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Impuesto1R)
                    .HasColumnName("IMPUESTO_1_R")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Impuesto2)
                    .HasColumnName("IMPUESTO_2")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ImpuestoDol)
                    .HasColumnName("IMPUESTO_DOL")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ImpuestoDolR)
                    .HasColumnName("IMPUESTO_DOL_R")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Iva)
                    .HasColumnName("IVA")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Linea1)
                    .IsRequired()
                    .HasColumnName("LINEA1")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.LineaProduccio)
                    .IsRequired()
                    .HasColumnName("LINEA_PRODUCCIO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ListaUnitDol)
                    .HasColumnName("LISTA_UNIT_DOL")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ListaUnitDolr)
                    .HasColumnName("LISTA_UNIT_DOLR")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.MetodoPrecio1)
                    .IsRequired()
                    .HasColumnName("METODO_PRECIO1")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NoEntrega)
                    .HasColumnName("NO_ENTREGA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.NombreEmb)
                    .HasColumnName("NOMBRE_EMB")
                    .HasColumnType("text");

                entity.Property(e => e.NombreFact)
                    .HasColumnName("NOMBRE_FACT")
                    .HasColumnType("text");

                entity.Property(e => e.NumeroDesde)
                    .HasColumnName("NUMERO_DESDE")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.NumeroHasta)
                    .HasColumnName("NUMERO_HASTA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Orden)
                    .HasColumnName("ORDEN")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.OrigenProducto)
                    .IsRequired()
                    .HasColumnName("ORIGEN_PRODUCTO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Pais)
                    .IsRequired()
                    .HasColumnName("PAIS")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Partes)
                    .IsRequired()
                    .HasColumnName("PARTES")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PrecioLista)
                    .HasColumnName("PRECIO_LISTA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PrecioListaR)
                    .HasColumnName("PRECIO_LISTA_R")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PrecioVenta)
                    .HasColumnName("PRECIO_VENTA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PrecioVentaR)
                    .HasColumnName("PRECIO_VENTA_R")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PrefijoDesde)
                    .IsRequired()
                    .HasColumnName("PREFIJO_DESDE")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PrefijoHasta)
                    .IsRequired()
                    .HasColumnName("PREFIJO_HASTA")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.RemisionOfic)
                    .HasColumnName("REMISION_OFIC")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RifEmb)
                    .IsRequired()
                    .HasColumnName("RIF_EMB")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.RifFact)
                    .IsRequired()
                    .HasColumnName("RIF_FACT")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SufijoDesde)
                    .IsRequired()
                    .HasColumnName("SUFIJO_DESDE")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SufijoHasta)
                    .IsRequired()
                    .HasColumnName("SUFIJO_HASTA")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TipoDoc)
                    .HasColumnName("TIPO_DOC")
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

                entity.Property(e => e.TotalParcial)
                    .IsRequired()
                    .HasColumnName("TOTAL_PARCIAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.UnidadFacturar)
                    .IsRequired()
                    .HasColumnName("UNIDAD_FACTURAR")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ValorLista)
                    .HasColumnName("VALOR_LISTA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorListaR)
                    .HasColumnName("VALOR_LISTA_R")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorListad)
                    .HasColumnName("VALOR_LISTAD")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorListadR)
                    .HasColumnName("VALOR_LISTAD_R")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorVenta)
                    .HasColumnName("VALOR_VENTA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorVentaR)
                    .HasColumnName("VALOR_VENTA_R")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorVentad)
                    .HasColumnName("VALOR_VENTAD")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorVentadR)
                    .HasColumnName("VALOR_VENTAD_R")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.VentaUnitDol)
                    .HasColumnName("VENTA_UNIT_DOL")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.VentaUnitDolr)
                    .HasColumnName("VENTA_UNIT_DOLR")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<Ciny055>(entity =>
            {
                entity.HasKey(e => new { e.Orden, e.Recnum })
                    .HasName("CINY055_INDEX01");

                entity.ToTable("CINY055");

                entity.HasIndex(e => e.Recnum)
                    .HasName("CINY055_INDEX00")
                    .IsUnique();

                entity.Property(e => e.Orden)
                    .HasColumnName("ORDEN")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.NroCaja)
                    .HasColumnName("NRO_CAJA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.NumCliDesde)
                    .HasColumnName("NUM_CLI_DESDE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumCliHasta)
                    .HasColumnName("NUM_CLI_HASTA")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroDesde)
                    .IsRequired()
                    .HasColumnName("NUMERO_DESDE")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.NumeroHasta)
                    .IsRequired()
                    .HasColumnName("NUMERO_HASTA")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PrefDesde)
                    .IsRequired()
                    .HasColumnName("PREF_DESDE")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PrefHasta)
                    .IsRequired()
                    .HasColumnName("PREF_HASTA")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PrefijoCli)
                    .HasColumnName("PREFIJO_CLI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SufDesde)
                    .IsRequired()
                    .HasColumnName("SUF_DESDE")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SufHasta)
                    .IsRequired()
                    .HasColumnName("SUF_HASTA")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SufijoCli)
                    .HasColumnName("SUFIJO_CLI")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ciny056>(entity =>
            {
                entity.HasKey(e => new { e.Factura, e.CentroFact, e.TipoDoc })
                    .HasName("CINY056_INDEX01");

                entity.ToTable("CINY056");

                entity.HasIndex(e => e.Factura)
                    .HasName("IX_CINY056");

                entity.HasIndex(e => e.Orden)
                    .HasName("dep_ciny056orden");

                entity.HasIndex(e => e.Recnum)
                    .HasName("CINY056_INDEX00")
                    .IsUnique();

                entity.HasIndex(e => new { e.Factura, e.FacturaRepetir })
                    .HasName("IX_CINY056_1");

                entity.HasIndex(e => new { e.FechaDespacho, e.Factura })
                    .HasName("CINY056_INDEX14")
                    .IsUnique();

                entity.HasIndex(e => new { e.FlagImpreso, e.Factura, e.Recnum })
                    .HasName("CINY056_INDEX12")
                    .IsUnique();

                entity.HasIndex(e => new { e.Orden, e.FechaFactura, e.Recnum })
                    .HasName("CINY056_INDEX11")
                    .IsUnique();

                entity.HasIndex(e => new { e.AnoFactura, e.MesFactura, e.RifFact, e.Recnum })
                    .HasName("CINY056_INDEX13")
                    .IsUnique();

                entity.HasIndex(e => new { e.FechaFactura, e.CentroFact, e.Factura, e.TipoDoc })
                    .HasName("CINY056_INDEX02")
                    .IsUnique();

                entity.HasIndex(e => new { e.FechaRecibCli, e.Factura, e.TipoDoc, e.CentroFact })
                    .HasName("CINY056_INDEX06")
                    .IsUnique();

                entity.HasIndex(e => new { e.AnoFactura, e.MesFactura, e.CentroFact, e.TipoDoc, e.Factura })
                    .HasName("CINY056_INDEX09")
                    .IsUnique();

                entity.HasIndex(e => new { e.Cliente, e.FechaFactura, e.CentroFact, e.Factura, e.TipoDoc })
                    .HasName("CINY056_INDEX03")
                    .IsUnique();

                entity.HasIndex(e => new { e.FechaFactura, e.CodigoRepetici, e.Factura, e.TipoDoc, e.CentroFact })
                    .HasName("CINY056_INDEX05")
                    .IsUnique();

                entity.HasIndex(e => new { e.FechaFactura, e.TotalParcial, e.Factura, e.TipoDoc, e.CentroFact })
                    .HasName("CINY056_INDEX07")
                    .IsUnique();

                entity.HasIndex(e => new { e.Vendedor, e.CentroFact, e.FechaFactura, e.Factura, e.TipoDoc })
                    .HasName("CINY056_INDEX04")
                    .IsUnique();

                entity.HasIndex(e => new { e.AnoFactura, e.MesFactura, e.Pais, e.TipoDoc, e.Factura, e.Recnum })
                    .HasName("CINY056_INDEX08")
                    .IsUnique();

                entity.Property(e => e.Factura).HasColumnName("FACTURA");

                entity.Property(e => e.CentroFact).HasColumnName("CENTRO_FACT");

                entity.Property(e => e.TipoDoc)
                    .HasColumnName("TIPO_DOC")
                    .HasDefaultValueSql("((2))");

                entity.Property(e => e.AnoFactura)
                    .HasColumnName("ANO_FACTURA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Anticipo).HasColumnName("ANTICIPO");

                entity.Property(e => e.Anulada)
                    .HasColumnName("ANULADA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Batch)
                    .HasColumnName("BATCH")
                    .HasColumnType("decimal(14, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cajas)
                    .HasColumnName("CAJAS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CantResumen)
                    .HasColumnName("CANT_RESUMEN")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cliente)
                    .HasColumnName("CLIENTE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ClienteJde)
                    .HasColumnName("CLIENTE_JDE")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoRepetici)
                    .HasColumnName("CODIGO_REPETICI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ColetillaInd1)
                    .HasColumnName("COLETILLA_IND1")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ColetillaInd2)
                    .HasColumnName("COLETILLA_IND2")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ColetillaInd3)
                    .HasColumnName("COLETILLA_IND3")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ColetillaInd4)
                    .HasColumnName("COLETILLA_IND4")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.CondPago).HasColumnName("COND_PAGO");

                entity.Property(e => e.CondicionPago)
                    .HasColumnName("CONDICION_PAGO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Copy).HasColumnName("COPY");

                entity.Property(e => e.Cotizacion)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CredConta)
                    .HasColumnName("CRED_CONTA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Dciudad)
                    .HasColumnName("DCIUDAD")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DescResumen1)
                    .HasColumnName("DESC_RESUMEN1")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.DescResumen2)
                    .HasColumnName("DESC_RESUMEN2")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Destado)
                    .HasColumnName("DESTADO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DireccFiscal)
                    .HasColumnName("DIRECC_FISCAL")
                    .HasColumnType("text");

                entity.Property(e => e.DireccionEmb1)
                    .HasColumnName("DIRECCION_EMB1")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccionEmb2)
                    .HasColumnName("DIRECCION_EMB2")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccionEmb3)
                    .IsRequired()
                    .HasColumnName("DIRECCION_EMB3")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccionFact1)
                    .HasColumnName("DIRECCION_FACT1")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccionFact2)
                    .HasColumnName("DIRECCION_FACT2")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccionFact3)
                    .IsRequired()
                    .HasColumnName("DIRECCION_FACT3")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DocumentoSap).HasMaxLength(10);

                entity.Property(e => e.Dolar)
                    .HasColumnName("DOLAR")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.EstadoEntregar).HasMaxLength(2);

                entity.Property(e => e.EstadoFacturar).HasMaxLength(2);

                entity.Property(e => e.FactAdelantada)
                    .IsRequired()
                    .HasColumnName("FACT_ADELANTADA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FactFinal)
                    .HasColumnName("FACT_FINAL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FacturaRepetir).HasColumnName("FACTURA_REPETIR");

                entity.Property(e => e.FechaAnulada)
                    .HasColumnName("FECHA_ANULADA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaDespacho)
                    .HasColumnName("FECHA_DESPACHO")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.FechaFactura)
                    .HasColumnName("FECHA_FACTURA")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.FechaRecibCli)
                    .HasColumnName("FECHA_RECIB_CLI")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.Field98)
                    .HasColumnName("FIELD98")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Fiscal)
                    .IsRequired()
                    .HasColumnName("FISCAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagComision)
                    .HasColumnName("FLAG_COMISION")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagGeneroPdf)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FlagImpreso)
                    .IsRequired()
                    .HasColumnName("FLAG_IMPRESO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Flete)
                    .HasColumnName("FLETE")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IdDirEntregar).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IdDirFacturar).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IdDireccion).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Imp)
                    .HasColumnName("IMP")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ImpStock)
                    .IsRequired()
                    .HasColumnName("IMP_STOCK")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ImpuestoDol)
                    .HasColumnName("IMPUESTO_DOL")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.JobId)
                    .HasColumnName("JOB_ID")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.LineaAnt).HasColumnName("LINEA_ANT");

                entity.Property(e => e.MesFactura)
                    .HasColumnName("MES_FACTURA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Miscelaneo)
                    .HasColumnName("MISCELANEO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MultiplesEmb)
                    .HasColumnName("MULTIPLES_EMB")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Municipio)
                    .HasColumnName("MUNICIPIO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.MunicipioEntregar).HasMaxLength(2);

                entity.Property(e => e.MunicipioFacturar).HasMaxLength(2);

                entity.Property(e => e.NcFacturar).HasColumnName("NC_FACTURAR");

                entity.Property(e => e.NitEmb)
                    .HasColumnName("NIT_EMB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NitFact)
                    .HasColumnName("NIT_FACT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NombreEmb)
                    .HasColumnName("NOMBRE_EMB")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NombreFact)
                    .HasColumnName("NOMBRE_FACT")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NroControl).HasColumnName("NRO_CONTROL");

                entity.Property(e => e.NroNc).HasColumnName("NRO_NC");

                entity.Property(e => e.NuevaLineaAnt).HasColumnName("NUEVA_LINEA_ANT");

                entity.Property(e => e.ObsCobranzas1)
                    .HasColumnName("OBS_COBRANZAS1")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ObsCobranzas2)
                    .HasColumnName("OBS_COBRANZAS2")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ObsCobranzas3)
                    .HasColumnName("OBS_COBRANZAS3")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ObsCobranzas4)
                    .HasColumnName("OBS_COBRANZAS4")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Observacion1)
                    .IsRequired()
                    .HasColumnName("OBSERVACION1")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Observacion2)
                    .IsRequired()
                    .HasColumnName("OBSERVACION2")
                    .HasMaxLength(79)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Observacion3)
                    .IsRequired()
                    .HasColumnName("OBSERVACION3")
                    .HasMaxLength(79)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Orden)
                    .HasColumnName("ORDEN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OrdenCompra)
                    .HasColumnName("ORDEN_COMPRA")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.OtroGasto1)
                    .HasColumnName("OTRO_GASTO_1")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OtroGasto2)
                    .HasColumnName("OTRO_GASTO_2")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Pais)
                    .HasColumnName("PAIS")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Pltyp)
                    .HasColumnName("PLTYP")
                    .HasMaxLength(2)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RegistroTribut)
                    .HasColumnName("REGISTRO_TRIBUT")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.RifEmb)
                    .HasColumnName("RIF_EMB")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.RifFact)
                    .HasColumnName("RIF_FACT")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.RotroGasto1)
                    .HasColumnName("ROTRO_GASTO_1")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RsdoAnticipo)
                    .HasColumnName("RSDO_ANTICIPO")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RvalorLista)
                    .HasColumnName("RVALOR_LISTA")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RvalorVenta)
                    .HasColumnName("RVALOR_VENTA")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SdoAnticipo)
                    .HasColumnName("SDO_ANTICIPO")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.SdoAnticipoDo)
                    .HasColumnName("SDO_ANTICIPO_DO")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Seguro)
                    .HasColumnName("SEGURO")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Supervisor)
                    .HasColumnName("SUPERVISOR")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TasaAnticipo)
                    .HasColumnName("TASA_ANTICIPO")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.TasaImpuesto)
                    .HasColumnName("TASA_IMPUESTO")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.TipoCambio)
                    .HasColumnName("TIPO_CAMBIO")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalParcial)
                    .HasColumnName("TOTAL_PARCIAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Transmision)
                    .HasColumnName("TRANSMISION")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.UndResumen)
                    .HasColumnName("UND_RESUMEN")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnidadFacturar)
                    .HasColumnName("UNIDAD_FACTURAR")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Usuario)
                    .HasColumnName("USUARIO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ValorLista)
                    .HasColumnName("VALOR_LISTA")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ValorListad)
                    .HasColumnName("VALOR_LISTAD")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ValorVenta)
                    .HasColumnName("VALOR_VENTA")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ValorVentad)
                    .HasColumnName("VALOR_VENTAD")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VendGestion)
                    .HasColumnName("VEND_GESTION")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Vendedor)
                    .HasColumnName("VENDEDOR")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Ciny057>(entity =>
            {
                entity.HasKey(e => new { e.Factura, e.CentroFact, e.TipoDoc, e.Recnum })
                    .HasName("CINY057_INDEX01");

                entity.ToTable("CINY057");

                entity.HasIndex(e => e.IdSolicitud)
                    .HasName("IX_CINY057_1");

                entity.HasIndex(e => e.Orden)
                    .HasName("dep_ciny057orden");

                entity.HasIndex(e => e.Pedidosap)
                    .HasName("IX_CINY057_6");

                entity.HasIndex(e => e.Recnum)
                    .HasName("CINY057_INDEX00")
                    .IsUnique();

                entity.HasIndex(e => new { e.Año, e.Mes })
                    .HasName("IX_CINY057_2");

                entity.HasIndex(e => new { e.Estadisticas, e.Recnum })
                    .HasName("CINY057_INDEX11")
                    .IsUnique();

                entity.HasIndex(e => new { e.Lipamepa, e.Recnum })
                    .HasName("CINY057_INDEX08")
                    .IsUnique();

                entity.HasIndex(e => new { e.Año, e.Mes, e.Articulo })
                    .HasName("IX_CINY057_5");

                entity.HasIndex(e => new { e.Factura, e.Articulo, e.Recnum })
                    .HasName("CINY057_INDEX13")
                    .IsUnique();

                entity.HasIndex(e => new { e.FechaFactura, e.Factura, e.Recnum })
                    .HasName("CINY057_INDEX06")
                    .IsUnique();

                entity.HasIndex(e => new { e.Articulo, e.FechaFactura, e.Orden, e.Recnum })
                    .HasName("CINY057_INDEX07")
                    .IsUnique();

                entity.HasIndex(e => new { e.Año, e.Mes, e.IdSolicitud, e.MetodoCalculo })
                    .HasName("IX_CINY057_3");

                entity.HasIndex(e => new { e.Año, e.Mes, e.Orden, e.Articulo })
                    .HasName("IX_CINY057_4");

                entity.HasIndex(e => new { e.CentroFact, e.Factura, e.TipoDoc, e.Recnum })
                    .HasName("CINY057_INDEX03")
                    .IsUnique();

                entity.HasIndex(e => new { e.Orden, e.Factura, e.FechaFactura, e.Recnum })
                    .HasName("CINY057_INDEX04")
                    .IsUnique();

                entity.HasIndex(e => new { e.FechaFactura, e.CentroFact, e.TipoDoc, e.Factura, e.Recnum })
                    .HasName("CINY057_INDEX02")
                    .IsUnique();

                entity.HasIndex(e => new { e.FechaFactura, e.TipoProducto, e.Factura, e.TipoDoc, e.Recnum })
                    .HasName("CINY057_INDEX05")
                    .IsUnique();

                entity.HasIndex(e => new { e.Linea1, e.Partes, e.MetodoPrecio1, e.TipoPapel, e.Recnum })
                    .HasName("CINY057_INDEX10")
                    .IsUnique();

                entity.HasIndex(e => new { e.FechaFactura, e.Linea1, e.Partes, e.MetodoPrecio1, e.TipoPapel, e.Recnum })
                    .HasName("CINY057_INDEX09")
                    .IsUnique();

                entity.Property(e => e.Factura).HasColumnName("FACTURA");

                entity.Property(e => e.CentroFact).HasColumnName("CENTRO_FACT");

                entity.Property(e => e.TipoDoc)
                    .HasColumnName("TIPO_DOC")
                    .HasDefaultValueSql("((2))");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Almacen)
                    .HasColumnName("ALMACEN")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Articulo)
                    .IsRequired()
                    .HasColumnName("ARTICULO")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Batch)
                    .HasColumnName("BATCH")
                    .HasColumnType("decimal(14, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BsMcFinan)
                    .HasColumnName("BS_MC_FINAN")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BsMcFinansc)
                    .HasColumnName("BS_MC_FINANSC")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BsMcPapel)
                    .HasColumnName("BS_MC_PAPEL")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BsMcPapelsc)
                    .HasColumnName("BS_MC_PAPELSC")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Bsmc)
                    .HasColumnName("BSMC")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BultoDesp)
                    .HasColumnName("BULTO_DESP")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BultoTran)
                    .HasColumnName("BULTO_TRAN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Bultos).HasColumnName("BULTOS");

                entity.Property(e => e.CantEntregar)
                    .HasColumnName("CANT_ENTREGAR")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Cantidad)
                    .HasColumnName("CANTIDAD")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CantidadEntregada).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Copy)
                    .HasColumnName("COPY")
                    .HasColumnType("decimal(4, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Costo).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Cotizacion).HasMaxLength(20);

                entity.Property(e => e.CtaConc)
                    .IsRequired()
                    .HasColumnName("CTA_CONC")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CtaLista)
                    .IsRequired()
                    .HasColumnName("CTA_LISTA")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

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

                entity.Property(e => e.DireccionEmb)
                    .HasColumnName("DIRECCION_EMB")
                    .HasColumnType("text");

                entity.Property(e => e.DireccionFact)
                    .HasColumnName("DIRECCION_FACT")
                    .HasColumnType("text");

                entity.Property(e => e.Estadisticas)
                    .IsRequired()
                    .HasColumnName("ESTADISTICAS")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Familia)
                    .HasColumnName("FAMILIA")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FamiliaProducc)
                    .HasColumnName("FAMILIA_PRODUCC")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FecComproClte)
                    .HasColumnName("FEC_COMPRO_CLTE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FecRecPlaneac)
                    .HasColumnName("FEC_REC_PLANEAC")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaFactura)
                    .HasColumnName("FECHA_FACTURA")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.FechaOrden)
                    .HasColumnName("FECHA_ORDEN")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaProg)
                    .HasColumnName("FECHA_PROG")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlagFaltante)
                    .IsRequired()
                    .HasColumnName("FLAG_FALTANTE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagImprenta)
                    .IsRequired()
                    .HasColumnName("FLAG_IMPRENTA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagRetenido)
                    .IsRequired()
                    .HasColumnName("FLAG_RETENIDO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagTipoJob)
                    .IsRequired()
                    .HasColumnName("FLAG_TIPO_JOB")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagTipoOrden)
                    .IsRequired()
                    .HasColumnName("FLAG_TIPO_ORDEN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FormasBajotiro).HasColumnName("FORMAS_BAJOTIRO");

                entity.Property(e => e.FormasUnidad)
                    .HasColumnName("FORMAS_UNIDAD")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.GeneraDespacho)
                    .HasColumnName("GENERA_DESPACHO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.GeneraListaDespacho).HasMaxLength(1);

                entity.Property(e => e.IdPrelista).HasDefaultValueSql("((0))");

                entity.Property(e => e.IdRegistroPrelista).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdSolicitud)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IdSolicitudCosto).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdSolicitudCostoCpj)
                    .HasColumnName("IdSolicitudCosto_CPJ")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ImpStock)
                    .HasColumnName("IMP_STOCK")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Impuesto1)
                    .HasColumnName("IMPUESTO_1")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Impuesto2)
                    .HasColumnName("IMPUESTO_2")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ImpuestoDol)
                    .HasColumnName("IMPUESTO_DOL")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Iva)
                    .HasColumnName("IVA")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.JobId).HasColumnName("JOB_ID");

                entity.Property(e => e.KiloBulto)
                    .HasColumnName("KILO_BULTO")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Linea1)
                    .HasColumnName("LINEA1")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.LineaProduccio)
                    .HasColumnName("LINEA_PRODUCCIO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Lipamepa)
                    .IsRequired()
                    .HasColumnName("LIPAMEPA")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ListaUniDol)
                    .HasColumnName("LISTA_UNI_DOL")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MetodoCalculo).HasDefaultValueSql("((0))");

                entity.Property(e => e.MetodoPrecio1)
                    .IsRequired()
                    .HasColumnName("METODO_PRECIO1")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Millares)
                    .IsRequired()
                    .HasColumnName("MILLARES")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NoEntrega).HasColumnName("NO_ENTREGA");

                entity.Property(e => e.NombreEmb)
                    .HasColumnName("NOMBRE_EMB")
                    .HasColumnType("text");

                entity.Property(e => e.NombreFact)
                    .HasColumnName("NOMBRE_FACT")
                    .HasColumnType("text");

                entity.Property(e => e.NumCliDesde)
                    .HasColumnName("NUM_CLI_DESDE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumCliDesdeE)
                    .HasColumnName("NUM_CLI_DESDE_E")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumCliHasta)
                    .HasColumnName("NUM_CLI_HASTA")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumCliHastaE)
                    .HasColumnName("NUM_CLI_HASTA_E")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroDesde)
                    .IsRequired()
                    .HasColumnName("NUMERO_DESDE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroDesdeE)
                    .HasColumnName("NUMERO_DESDE_E")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroHasta)
                    .IsRequired()
                    .HasColumnName("NUMERO_HASTA")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroHastaE)
                    .HasColumnName("NUMERO_HASTA_E")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.OrigenProducto)
                    .IsRequired()
                    .HasColumnName("ORIGEN_PRODUCTO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Pais)
                    .IsRequired()
                    .HasColumnName("PAIS")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Partes)
                    .IsRequired()
                    .HasColumnName("PARTES")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Pedidosap)
                    .HasColumnName("PEDIDOSAP")
                    .HasMaxLength(10);

                entity.Property(e => e.Pieslineales)
                    .HasColumnName("PIESLINEALES")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PorcMcFinan)
                    .HasColumnName("PORC_MC_FINAN")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PorcMcFinansc)
                    .HasColumnName("PORC_MC_FINANSC")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PorcMcPapel)
                    .HasColumnName("PORC_MC_PAPEL")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PorcMcPapelsc)
                    .HasColumnName("PORC_MC_PAPELSC")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Posicionsap)
                    .HasColumnName("POSICIONSAP")
                    .HasMaxLength(36);

                entity.Property(e => e.PrecioLista)
                    .HasColumnName("PRECIO_LISTA")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PrecioVenta)
                    .HasColumnName("PRECIO_VENTA")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Preciounidad)
                    .HasColumnName("PRECIOUNIDAD")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.PrefijoCli)
                    .HasColumnName("PREFIJO_CLI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrefijoCliE)
                    .HasColumnName("PREFIJO_CLI_E")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrefijoDesde)
                    .IsRequired()
                    .HasColumnName("PREFIJO_DESDE")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PrefijoDesdeE)
                    .HasColumnName("PREFIJO_DESDE_E")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrefijoHasta)
                    .IsRequired()
                    .HasColumnName("PREFIJO_HASTA")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PrefijoHastaE)
                    .HasColumnName("PREFIJO_HASTA_E")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RbsMcFinan)
                    .HasColumnName("RBS_MC_FINAN")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RbsMcFinansc)
                    .HasColumnName("RBS_MC_FINANSC")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RbsMcPapel)
                    .HasColumnName("RBS_MC_PAPEL")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RbsMcPapelsc)
                    .HasColumnName("RBS_MC_PAPELSC")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rbsmc)
                    .HasColumnName("RBSMC")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RecalcularMargen)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RegistroTribut)
                    .HasColumnName("REGISTRO_TRIBUT")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.RemisionOfi)
                    .HasColumnName("REMISION_OFI")
                    .HasColumnType("decimal(14, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReportadoSeniat).HasMaxLength(1);

                entity.Property(e => e.RifEmb)
                    .IsRequired()
                    .HasColumnName("RIF_EMB")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.RifFact)
                    .IsRequired()
                    .HasColumnName("RIF_FACT")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Rimpuesto1)
                    .HasColumnName("RIMPUESTO_1")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RprecioLista)
                    .HasColumnName("RPRECIO_LISTA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RprecioVenta)
                    .HasColumnName("RPRECIO_VENTA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rpreciounidad)
                    .HasColumnName("RPRECIOUNIDAD")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RvalorLista)
                    .HasColumnName("RVALOR_LISTA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RvalorVenta)
                    .HasColumnName("RVALOR_VENTA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RventaEntregada)
                    .HasColumnName("RVentaEntregada")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SufijoCli)
                    .HasColumnName("SUFIJO_CLI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SufijoCliE)
                    .HasColumnName("SUFIJO_CLI_E")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SufijoDesde)
                    .IsRequired()
                    .HasColumnName("SUFIJO_DESDE")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SufijoDesdeE)
                    .HasColumnName("SUFIJO_DESDE_E")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SufijoHasta)
                    .IsRequired()
                    .HasColumnName("SUFIJO_HASTA")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SufijoHastaE)
                    .HasColumnName("SUFIJO_HASTA_E")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCambio)
                    .HasColumnName("TIPO_CAMBIO")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TipoPapel)
                    .IsRequired()
                    .HasColumnName("TIPO_PAPEL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TipoProducto)
                    .HasColumnName("TIPO_PRODUCTO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TotalParcial)
                    .IsRequired()
                    .HasColumnName("TOTAL_PARCIAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.UnidadFacturar)
                    .IsRequired()
                    .HasColumnName("UNIDAD_FACTURAR")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Unidadesent)
                    .HasColumnName("UNIDADESENT")
                    .HasColumnType("decimal(16, 3)");

                entity.Property(e => e.Unidadesfact)
                    .HasColumnName("UNIDADESFACT")
                    .HasColumnType("decimal(16, 3)");

                entity.Property(e => e.Usuario)
                    .HasColumnName("USUARIO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ValorLista)
                    .HasColumnName("VALOR_LISTA")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ValorListad)
                    .HasColumnName("VALOR_LISTAD")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ValorVenta)
                    .HasColumnName("VALOR_VENTA")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ValorVentaCpj)
                    .HasColumnName("VALOR_VENTA_CPJ")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.ValorVentad)
                    .HasColumnName("VALOR_VENTAD")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Vbeln)
                    .HasColumnName("VBELN")
                    .HasMaxLength(10);

                entity.Property(e => e.VentaEntregada)
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VentaUniDol)
                    .HasColumnName("VENTA_UNI_DOL")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Ciny057anulada>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CINY057ANULADA");

                entity.HasIndex(e => e.Orden)
                    .HasName("dep_ciny057Anuladaorden");

                entity.Property(e => e.Almacen)
                    .HasColumnName("ALMACEN")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Articulo)
                    .IsRequired()
                    .HasColumnName("ARTICULO")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Batch)
                    .HasColumnName("BATCH")
                    .HasColumnType("decimal(14, 0)");

                entity.Property(e => e.BsMcFinan)
                    .HasColumnName("BS_MC_FINAN")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.BsMcFinansc)
                    .HasColumnName("BS_MC_FINANSC")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.BsMcPapel)
                    .HasColumnName("BS_MC_PAPEL")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.BsMcPapelsc)
                    .HasColumnName("BS_MC_PAPELSC")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Bsmc)
                    .HasColumnName("BSMC")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.BultoDesp).HasColumnName("BULTO_DESP");

                entity.Property(e => e.BultoTran).HasColumnName("BULTO_TRAN");

                entity.Property(e => e.Bultos).HasColumnName("BULTOS");

                entity.Property(e => e.CantEntregar)
                    .HasColumnName("CANT_ENTREGAR")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Cantidad)
                    .HasColumnName("CANTIDAD")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CantidadEntregada).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CentroFact).HasColumnName("CENTRO_FACT");

                entity.Property(e => e.Copy)
                    .HasColumnName("COPY")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.Costo).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Cotizacion).HasMaxLength(20);

                entity.Property(e => e.CtaConc)
                    .IsRequired()
                    .HasColumnName("CTA_CONC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CtaLista)
                    .IsRequired()
                    .HasColumnName("CTA_LISTA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion1)
                    .IsRequired()
                    .HasColumnName("DESCRIPCION1")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion2)
                    .IsRequired()
                    .HasColumnName("DESCRIPCION2")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.DireccionEmb)
                    .HasColumnName("DIRECCION_EMB")
                    .HasColumnType("text");

                entity.Property(e => e.DireccionFact)
                    .HasColumnName("DIRECCION_FACT")
                    .HasColumnType("text");

                entity.Property(e => e.Estadisticas)
                    .IsRequired()
                    .HasColumnName("ESTADISTICAS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Factura).HasColumnName("FACTURA");

                entity.Property(e => e.Familia)
                    .IsRequired()
                    .HasColumnName("FAMILIA")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.FamiliaProducc)
                    .IsRequired()
                    .HasColumnName("FAMILIA_PRODUCC")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.FecComproClte)
                    .HasColumnName("FEC_COMPRO_CLTE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FecRecPlaneac)
                    .HasColumnName("FEC_REC_PLANEAC")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaFactura)
                    .HasColumnName("FECHA_FACTURA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaOrden)
                    .HasColumnName("FECHA_ORDEN")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaProg)
                    .HasColumnName("FECHA_PROG")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlagFaltante)
                    .IsRequired()
                    .HasColumnName("FLAG_FALTANTE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FlagImprenta)
                    .IsRequired()
                    .HasColumnName("FLAG_IMPRENTA")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FlagRetenido)
                    .IsRequired()
                    .HasColumnName("FLAG_RETENIDO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FlagTipoJob)
                    .IsRequired()
                    .HasColumnName("FLAG_TIPO_JOB")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FlagTipoOrden)
                    .IsRequired()
                    .HasColumnName("FLAG_TIPO_ORDEN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FormasBajotiro).HasColumnName("FORMAS_BAJOTIRO");

                entity.Property(e => e.FormasUnidad)
                    .HasColumnName("FORMAS_UNIDAD")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.GeneraDespacho)
                    .HasColumnName("GENERA_DESPACHO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IdRegistroPrelista).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdSolicitud).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdSolicitudCosto).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdSolicitudCostoCpj)
                    .HasColumnName("IdSolicitudCosto_CPJ")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ImpStock)
                    .HasColumnName("IMP_STOCK")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Impuesto1)
                    .HasColumnName("IMPUESTO_1")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Impuesto2)
                    .HasColumnName("IMPUESTO_2")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.ImpuestoDol)
                    .HasColumnName("IMPUESTO_DOL")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Iva)
                    .HasColumnName("IVA")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.JobId).HasColumnName("JOB_ID");

                entity.Property(e => e.KiloBulto)
                    .HasColumnName("KILO_BULTO")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Linea1)
                    .IsRequired()
                    .HasColumnName("LINEA1")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.LineaProduccio)
                    .IsRequired()
                    .HasColumnName("LINEA_PRODUCCIO")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Lipamepa)
                    .IsRequired()
                    .HasColumnName("LIPAMEPA")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ListaUniDol)
                    .HasColumnName("LISTA_UNI_DOL")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.MetodoPrecio1)
                    .IsRequired()
                    .HasColumnName("METODO_PRECIO1")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Millares)
                    .IsRequired()
                    .HasColumnName("MILLARES")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.NoEntrega).HasColumnName("NO_ENTREGA");

                entity.Property(e => e.NombreEmb)
                    .HasColumnName("NOMBRE_EMB")
                    .HasColumnType("text");

                entity.Property(e => e.NombreFact)
                    .HasColumnName("NOMBRE_FACT")
                    .HasColumnType("text");

                entity.Property(e => e.NumCliDesde)
                    .HasColumnName("NUM_CLI_DESDE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumCliDesdeE)
                    .HasColumnName("NUM_CLI_DESDE_E")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumCliHasta)
                    .HasColumnName("NUM_CLI_HASTA")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumCliHastaE)
                    .HasColumnName("NUM_CLI_HASTA_E")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroDesde)
                    .IsRequired()
                    .HasColumnName("NUMERO_DESDE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroDesdeE)
                    .HasColumnName("NUMERO_DESDE_E")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroHasta)
                    .IsRequired()
                    .HasColumnName("NUMERO_HASTA")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroHastaE)
                    .HasColumnName("NUMERO_HASTA_E")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.OrigenProducto)
                    .IsRequired()
                    .HasColumnName("ORIGEN_PRODUCTO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Pais)
                    .IsRequired()
                    .HasColumnName("PAIS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Partes)
                    .IsRequired()
                    .HasColumnName("PARTES")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Pedidosap)
                    .HasColumnName("PEDIDOSAP")
                    .HasMaxLength(10);

                entity.Property(e => e.Pieslineales)
                    .HasColumnName("PIESLINEALES")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PorcMcFinan)
                    .HasColumnName("PORC_MC_FINAN")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.PorcMcFinansc)
                    .HasColumnName("PORC_MC_FINANSC")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.PorcMcPapel)
                    .HasColumnName("PORC_MC_PAPEL")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.PorcMcPapelsc)
                    .HasColumnName("PORC_MC_PAPELSC")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Posicionsap)
                    .HasColumnName("POSICIONSAP")
                    .HasMaxLength(36);

                entity.Property(e => e.PrecioLista)
                    .HasColumnName("PRECIO_LISTA")
                    .HasColumnType("decimal(16, 6)");

                entity.Property(e => e.PrecioVenta)
                    .HasColumnName("PRECIO_VENTA")
                    .HasColumnType("decimal(16, 6)");

                entity.Property(e => e.Preciounidad)
                    .HasColumnName("PRECIOUNIDAD")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.PrefijoCli)
                    .HasColumnName("PREFIJO_CLI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrefijoCliE)
                    .HasColumnName("PREFIJO_CLI_E")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrefijoDesde)
                    .IsRequired()
                    .HasColumnName("PREFIJO_DESDE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrefijoDesdeE)
                    .HasColumnName("PREFIJO_DESDE_E")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrefijoHasta)
                    .IsRequired()
                    .HasColumnName("PREFIJO_HASTA")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrefijoHastaE)
                    .HasColumnName("PREFIJO_HASTA_E")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RbsMcFinan)
                    .HasColumnName("RBS_MC_FINAN")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.RbsMcFinansc)
                    .HasColumnName("RBS_MC_FINANSC")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.RbsMcPapel)
                    .HasColumnName("RBS_MC_PAPEL")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.RbsMcPapelsc)
                    .HasColumnName("RBS_MC_PAPELSC")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Rbsmc)
                    .HasColumnName("RBSMC")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.RecalcularMargen)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)");

                entity.Property(e => e.RegistroTribut)
                    .HasColumnName("REGISTRO_TRIBUT")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.RemisionOfi)
                    .HasColumnName("REMISION_OFI")
                    .HasColumnType("decimal(14, 0)");

                entity.Property(e => e.ReportadoSeniat).HasMaxLength(1);

                entity.Property(e => e.RifEmb)
                    .IsRequired()
                    .HasColumnName("RIF_EMB")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.RifFact)
                    .IsRequired()
                    .HasColumnName("RIF_FACT")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Rimpuesto1)
                    .HasColumnName("RIMPUESTO_1")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.RprecioLista)
                    .HasColumnName("RPRECIO_LISTA")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.RprecioVenta)
                    .HasColumnName("RPRECIO_VENTA")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Rpreciounidad)
                    .HasColumnName("RPRECIOUNIDAD")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.RvalorLista)
                    .HasColumnName("RVALOR_LISTA")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.RvalorVenta)
                    .HasColumnName("RVALOR_VENTA")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.SufijoCli)
                    .HasColumnName("SUFIJO_CLI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SufijoCliE)
                    .HasColumnName("SUFIJO_CLI_E")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SufijoDesde)
                    .IsRequired()
                    .HasColumnName("SUFIJO_DESDE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SufijoDesdeE)
                    .HasColumnName("SUFIJO_DESDE_E")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SufijoHasta)
                    .IsRequired()
                    .HasColumnName("SUFIJO_HASTA")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SufijoHastaE)
                    .HasColumnName("SUFIJO_HASTA_E")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCambio)
                    .HasColumnName("TIPO_CAMBIO")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.TipoDoc).HasColumnName("TIPO_DOC");

                entity.Property(e => e.TipoPapel)
                    .IsRequired()
                    .HasColumnName("TIPO_PAPEL")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TipoProducto)
                    .IsRequired()
                    .HasColumnName("TIPO_PRODUCTO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TotalParcial)
                    .IsRequired()
                    .HasColumnName("TOTAL_PARCIAL")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UnidadFacturar)
                    .IsRequired()
                    .HasColumnName("UNIDAD_FACTURAR")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Unidadesent)
                    .HasColumnName("UNIDADESENT")
                    .HasColumnType("decimal(16, 3)");

                entity.Property(e => e.Unidadesfact)
                    .HasColumnName("UNIDADESFACT")
                    .HasColumnType("decimal(16, 3)");

                entity.Property(e => e.Usuario)
                    .HasColumnName("USUARIO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ValorLista)
                    .HasColumnName("VALOR_LISTA")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.ValorListad)
                    .HasColumnName("VALOR_LISTAD")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.ValorVenta)
                    .HasColumnName("VALOR_VENTA")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.ValorVentaCpj)
                    .HasColumnName("VALOR_VENTA_CPJ")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ValorVentad)
                    .HasColumnName("VALOR_VENTAD")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Vbeln)
                    .HasColumnName("VBELN")
                    .HasMaxLength(10);

                entity.Property(e => e.VentaUniDol)
                    .HasColumnName("VENTA_UNI_DOL")
                    .HasColumnType("decimal(16, 2)");
            });

            modelBuilder.Entity<Ciny058>(entity =>
            {
                entity.HasKey(e => new { e.Factura, e.NroCaja, e.Recnum })
                    .HasName("CINY058_INDEX01");

                entity.ToTable("CINY058");

                entity.HasIndex(e => e.Orden)
                    .HasName("dep_ciny058orden");

                entity.HasIndex(e => e.Recnum)
                    .HasName("CINY058_INDEX00")
                    .IsUnique();

                entity.HasIndex(e => new { e.FlagImpreso, e.Factura, e.Recnum })
                    .HasName("CINY058_INDEX02")
                    .IsUnique();

                entity.Property(e => e.Factura)
                    .HasColumnName("FACTURA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.NroCaja)
                    .HasColumnName("NRO_CAJA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.FlagImpreso)
                    .IsRequired()
                    .HasColumnName("FLAG_IMPRESO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NumCliDesde)
                    .IsRequired()
                    .HasColumnName("NUM_CLI_DESDE")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NumCliHasta)
                    .IsRequired()
                    .HasColumnName("NUM_CLI_HASTA")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NumeroDesde)
                    .IsRequired()
                    .HasColumnName("NUMERO_DESDE")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.NumeroHasta)
                    .IsRequired()
                    .HasColumnName("NUMERO_HASTA")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Orden)
                    .HasColumnName("ORDEN")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PrefDesde)
                    .IsRequired()
                    .HasColumnName("PREF_DESDE")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PrefHasta)
                    .IsRequired()
                    .HasColumnName("PREF_HASTA")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PrefijoCli)
                    .IsRequired()
                    .HasColumnName("PREFIJO_CLI")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SufDesde)
                    .IsRequired()
                    .HasColumnName("SUF_DESDE")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SufHasta)
                    .IsRequired()
                    .HasColumnName("SUF_HASTA")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SufijoCli)
                    .IsRequired()
                    .HasColumnName("SUFIJO_CLI")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Ciny059>(entity =>
            {
                entity.HasKey(e => e.Factura)
                    .HasName("CINY059_INDEX01");

                entity.ToTable("CINY059");

                entity.HasIndex(e => e.Recnum)
                    .HasName("CINY059_INDEX00")
                    .IsUnique();

                entity.Property(e => e.Factura)
                    .HasColumnName("FACTURA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Anulada)
                    .IsRequired()
                    .HasColumnName("ANULADA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Cajas)
                    .HasColumnName("CAJAS")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CentroFact)
                    .HasColumnName("CENTRO_FACT")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Ciudad)
                    .IsRequired()
                    .HasColumnName("CIUDAD")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Cliente)
                    .HasColumnName("CLIENTE")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CodEdo)
                    .IsRequired()
                    .HasColumnName("COD_EDO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CodMcpo)
                    .IsRequired()
                    .HasColumnName("COD_MCPO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CodigoRepetici)
                    .HasColumnName("CODIGO_REPETICI")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CondicionPago)
                    .HasColumnName("CONDICION_PAGO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CredConta)
                    .IsRequired()
                    .HasColumnName("CRED_CONTA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Despachar)
                    .IsRequired()
                    .HasColumnName("DESPACHAR")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccFiscal)
                    .HasColumnName("DIRECC_FISCAL")
                    .HasColumnType("text");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasColumnName("DIRECCION")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccionEmb1)
                    .IsRequired()
                    .HasColumnName("DIRECCION_EMB1")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccionEmb2)
                    .IsRequired()
                    .HasColumnName("DIRECCION_EMB2")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccionEmb3)
                    .IsRequired()
                    .HasColumnName("DIRECCION_EMB3")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccionFact1)
                    .IsRequired()
                    .HasColumnName("DIRECCION_FACT1")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccionFact2)
                    .IsRequired()
                    .HasColumnName("DIRECCION_FACT2")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccionFact3)
                    .IsRequired()
                    .HasColumnName("DIRECCION_FACT3")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Dolar)
                    .IsRequired()
                    .HasColumnName("DOLAR")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FactFinal)
                    .HasColumnName("FACT_FINAL")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.FechaFactura)
                    .HasColumnName("FECHA_FACTURA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaRecibCli)
                    .HasColumnName("FECHA_RECIB_CLI")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlagComision)
                    .IsRequired()
                    .HasColumnName("FLAG_COMISION")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Flete)
                    .HasColumnName("FLETE")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.GiroNegocio)
                    .IsRequired()
                    .HasColumnName("GIRO_NEGOCIO")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Imp)
                    .HasColumnName("IMP")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Iva)
                    .HasColumnName("IVA")
                    .HasColumnType("decimal(4, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.MultiplesEmb)
                    .IsRequired()
                    .HasColumnName("MULTIPLES_EMB")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NitEmb)
                    .HasColumnName("NIT_EMB")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.NitFact)
                    .HasColumnName("NIT_FACT")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NombreEmb)
                    .IsRequired()
                    .HasColumnName("NOMBRE_EMB")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NombreFact)
                    .IsRequired()
                    .HasColumnName("NOMBRE_FACT")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Orden)
                    .HasColumnName("ORDEN")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.OrdenCompra)
                    .IsRequired()
                    .HasColumnName("ORDEN_COMPRA")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.OtroGasto1)
                    .HasColumnName("OTRO_GASTO_1")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.OtroGasto2)
                    .HasColumnName("OTRO_GASTO_2")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Pais)
                    .HasColumnName("PAIS")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RegistroTribut)
                    .IsRequired()
                    .HasColumnName("REGISTRO_TRIBUT")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.RifEmb)
                    .IsRequired()
                    .HasColumnName("RIF_EMB")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.RifFact)
                    .IsRequired()
                    .HasColumnName("RIF_FACT")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Seguro)
                    .HasColumnName("SEGURO")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Supervisor)
                    .IsRequired()
                    .HasColumnName("SUPERVISOR")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasColumnName("TELEFONO")
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TipoCambio)
                    .HasColumnName("TIPO_CAMBIO")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TipoDoc)
                    .HasColumnName("TIPO_DOC")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TotalParcial)
                    .IsRequired()
                    .HasColumnName("TOTAL_PARCIAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Transmision)
                    .IsRequired()
                    .HasColumnName("TRANSMISION")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.UnidadFacturar)
                    .HasColumnName("UNIDAD_FACTURAR")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorLista)
                    .HasColumnName("VALOR_LISTA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorListad)
                    .HasColumnName("VALOR_LISTAD")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorVenta)
                    .HasColumnName("VALOR_VENTA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorVentad)
                    .HasColumnName("VALOR_VENTAD")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.VendGestion)
                    .IsRequired()
                    .HasColumnName("VEND_GESTION")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Vendedor)
                    .IsRequired()
                    .HasColumnName("VENDEDOR")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Ciny060>(entity =>
            {
                entity.HasKey(e => new { e.Factura, e.Recnum })
                    .HasName("CINY060_INDEX01");

                entity.ToTable("CINY060");

                entity.HasIndex(e => e.Recnum)
                    .HasName("CINY060_INDEX00")
                    .IsUnique();

                entity.Property(e => e.Factura)
                    .HasColumnName("FACTURA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Articulo)
                    .IsRequired()
                    .HasColumnName("ARTICULO")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Cajas)
                    .HasColumnName("CAJAS")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CantCajaUtili)
                    .HasColumnName("CANT_CAJA_UTILI")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CantidRemanent)
                    .HasColumnName("CANTID_REMANENT")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Cantidad)
                    .HasColumnName("CANTIDAD")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CentroFact)
                    .HasColumnName("CENTRO_FACT")
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
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccionEmb)
                    .HasColumnName("DIRECCION_EMB")
                    .HasColumnType("text");

                entity.Property(e => e.DireccionFact)
                    .HasColumnName("DIRECCION_FACT")
                    .HasColumnType("text");

                entity.Property(e => e.FamiliaProducc)
                    .IsRequired()
                    .HasColumnName("FAMILIA_PRODUCC")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FecComproClte)
                    .HasColumnName("FEC_COMPRO_CLTE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FecRecPlaneac)
                    .HasColumnName("FEC_REC_PLANEAC")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaEntrega)
                    .HasColumnName("FECHA_ENTREGA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaFactura)
                    .HasColumnName("FECHA_FACTURA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaOrden)
                    .HasColumnName("FECHA_ORDEN")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlagExistencia)
                    .IsRequired()
                    .HasColumnName("FLAG_EXISTENCIA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagImprenta)
                    .IsRequired()
                    .HasColumnName("FLAG_IMPRENTA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagRetenido)
                    .IsRequired()
                    .HasColumnName("FLAG_RETENIDO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagTipoJob)
                    .IsRequired()
                    .HasColumnName("FLAG_TIPO_JOB")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagTipoOrden)
                    .IsRequired()
                    .HasColumnName("FLAG_TIPO_ORDEN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FormPorCaja)
                    .HasColumnName("FORM_POR_CAJA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Impuesto1)
                    .HasColumnName("IMPUESTO_1")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Impuesto2)
                    .HasColumnName("IMPUESTO_2")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.JobId)
                    .HasColumnName("JOB_ID")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LineaProduccio)
                    .IsRequired()
                    .HasColumnName("LINEA_PRODUCCIO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Medida)
                    .IsRequired()
                    .HasColumnName("MEDIDA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NoEntrega)
                    .HasColumnName("NO_ENTREGA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.NombreEmb)
                    .HasColumnName("NOMBRE_EMB")
                    .HasColumnType("text");

                entity.Property(e => e.NombreFact)
                    .HasColumnName("NOMBRE_FACT")
                    .HasColumnType("text");

                entity.Property(e => e.Orden)
                    .HasColumnName("ORDEN")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.OrigenProducto)
                    .IsRequired()
                    .HasColumnName("ORIGEN_PRODUCTO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Pais)
                    .IsRequired()
                    .HasColumnName("PAIS")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PrecioLista)
                    .HasColumnName("PRECIO_LISTA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PrecioVenta)
                    .HasColumnName("PRECIO_VENTA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Presentacion)
                    .IsRequired()
                    .HasColumnName("PRESENTACION")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.RifEmb)
                    .IsRequired()
                    .HasColumnName("RIF_EMB")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.RifFact)
                    .IsRequired()
                    .HasColumnName("RIF_FACT")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TipoDoc)
                    .HasColumnName("TIPO_DOC")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TipoProducto)
                    .IsRequired()
                    .HasColumnName("TIPO_PRODUCTO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TotalParcial)
                    .IsRequired()
                    .HasColumnName("TOTAL_PARCIAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ValorLista)
                    .HasColumnName("VALOR_LISTA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorListad)
                    .HasColumnName("VALOR_LISTAD")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorVenta)
                    .HasColumnName("VALOR_VENTA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorVentad)
                    .HasColumnName("VALOR_VENTAD")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<Ciny061>(entity =>
            {
                entity.HasKey(e => e.Impuesto)
                    .HasName("CINY061_INDEX01");

                entity.ToTable("CINY061");

                entity.HasIndex(e => e.Recnum)
                    .HasName("CINY061_INDEX00")
                    .IsUnique();

                entity.HasIndex(e => new { e.Porcentaje, e.Recnum })
                    .HasName("CINY061_INDEX02")
                    .IsUnique();

                entity.Property(e => e.Impuesto)
                    .HasColumnName("IMPUESTO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CodJde)
                    .HasColumnName("cod_jde")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodSap)
                    .HasColumnName("cod_sap")
                    .HasMaxLength(1);

                entity.Property(e => e.CuentaContab)
                    .HasColumnName("CUENTA_CONTAB")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FechaVigencia)
                    .HasColumnName("FECHA_VIGENCIA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Porcentaje)
                    .HasColumnName("PORCENTAJE")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Resumen)
                    .IsRequired()
                    .HasColumnName("RESUMEN")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Ciny062>(entity =>
            {
                entity.HasKey(e => e.CentroFac)
                    .HasName("CINY062_INDEX01");

                entity.ToTable("CINY062");

                entity.HasIndex(e => e.Recnum)
                    .HasName("CINY062_INDEX00")
                    .IsUnique();

                entity.HasIndex(e => new { e.Lugar, e.CentroFac })
                    .HasName("CINY062_INDEX02")
                    .IsUnique();

                entity.Property(e => e.CentroFac)
                    .HasColumnName("CENTRO_FAC")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Ano)
                    .HasColumnName("ANO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Atencion1)
                    .IsRequired()
                    .HasColumnName("ATENCION1")
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Atencion2)
                    .IsRequired()
                    .HasColumnName("ATENCION2")
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Atencion3)
                    .IsRequired()
                    .HasColumnName("ATENCION3")
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ColetillaDol1)
                    .IsRequired()
                    .HasColumnName("COLETILLA_DOL1")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ColetillaDol2)
                    .IsRequired()
                    .HasColumnName("COLETILLA_DOL2")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ColetillaDol3)
                    .IsRequired()
                    .HasColumnName("COLETILLA_DOL3")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ColetillaDol4)
                    .IsRequired()
                    .HasColumnName("COLETILLA_DOL4")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ColetillaInd1)
                    .IsRequired()
                    .HasColumnName("COLETILLA_IND1")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ColetillaInd2)
                    .IsRequired()
                    .HasColumnName("COLETILLA_IND2")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ColetillaInd3)
                    .IsRequired()
                    .HasColumnName("COLETILLA_IND3")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ColetillaInd4)
                    .IsRequired()
                    .HasColumnName("COLETILLA_IND4")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ComprbFiscal)
                    .HasColumnName("COMPRB_FISCAL")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CruzaCxc)
                    .IsRequired()
                    .HasColumnName("CRUZA_CXC")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CtaCobrar)
                    .IsRequired()
                    .HasColumnName("CTA_COBRAR")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CteContado)
                    .HasColumnName("CTE_CONTADO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CxcPais1)
                    .HasColumnName("CXC_PAIS_1")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CxcPais2)
                    .HasColumnName("CXC_PAIS_2")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CxcPais3)
                    .HasColumnName("CXC_PAIS_3")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CxcPais4)
                    .HasColumnName("CXC_PAIS_4")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CxcPais5)
                    .HasColumnName("CXC_PAIS_5")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CxcPais6)
                    .HasColumnName("CXC_PAIS_6")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Factura)
                    .HasColumnName("FACTURA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.FechaCambio)
                    .HasColumnName("FECHA_CAMBIO")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaDia)
                    .HasColumnName("FECHA_DIA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Gastos)
                    .IsRequired()
                    .HasColumnName("GASTOS")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Imp)
                    .HasColumnName("IMP")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ImpAcum)
                    .IsRequired()
                    .HasColumnName("IMP_ACUM")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ImpIndiv)
                    .IsRequired()
                    .HasColumnName("IMP_INDIV")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Impuesto1)
                    .HasColumnName("IMPUESTO_1")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Impuesto2)
                    .HasColumnName("IMPUESTO_2")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Impuesto3)
                    .HasColumnName("IMPUESTO_3")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Impuesto4)
                    .HasColumnName("IMPUESTO_4")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Impuesto5)
                    .HasColumnName("IMPUESTO_5")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.InvAutomatico)
                    .IsRequired()
                    .HasColumnName("INV_AUTOMATICO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Lugar)
                    .IsRequired()
                    .HasColumnName("LUGAR")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Mes)
                    .HasColumnName("MES")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ObsCobranzas1)
                    .IsRequired()
                    .HasColumnName("OBS_COBRANZAS1")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ObsCobranzas2)
                    .IsRequired()
                    .HasColumnName("OBS_COBRANZAS2")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ObsCobranzas3)
                    .IsRequired()
                    .HasColumnName("OBS_COBRANZAS3")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ObsCobranzas4)
                    .IsRequired()
                    .HasColumnName("OBS_COBRANZAS4")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.OficinaVenta)
                    .HasColumnName("OFICINA_VENTA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.OrdenCliente)
                    .HasColumnName("ORDEN_CLIENTE")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.OrdenConsecuti)
                    .HasColumnName("ORDEN_CONSECUTI")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PrintDolFact)
                    .IsRequired()
                    .HasColumnName("PRINT_DOL_FACT")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Redondear)
                    .IsRequired()
                    .HasColumnName("REDONDEAR")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Remision)
                    .HasColumnName("REMISION")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TipoCambio)
                    .HasColumnName("TIPO_CAMBIO")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TomarDolActua)
                    .IsRequired()
                    .HasColumnName("TOMAR_DOL_ACTUA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Vendedor)
                    .HasColumnName("VENDEDOR")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<Ciny064>(entity =>
            {
                entity.HasKey(e => e.Orden)
                    .HasName("CINY064_INDEX01");

                entity.ToTable("CINY064");

                entity.HasIndex(e => e.Factura)
                    .HasName("CINY064_INDEX02")
                    .IsUnique();

                entity.HasIndex(e => e.Recnum)
                    .HasName("CINY064_INDEX00")
                    .IsUnique();

                entity.Property(e => e.Orden)
                    .HasColumnName("ORDEN")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AnoFactura)
                    .HasColumnName("ANO_FACTURA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Anticipo)
                    .HasColumnName("ANTICIPO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Anulada)
                    .IsRequired()
                    .HasColumnName("ANULADA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Cajas)
                    .HasColumnName("CAJAS")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CentroFact)
                    .HasColumnName("CENTRO_FACT")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Cliente)
                    .HasColumnName("CLIENTE")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CodEdo)
                    .IsRequired()
                    .HasColumnName("COD_EDO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CodMcpo)
                    .IsRequired()
                    .HasColumnName("COD_MCPO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CodigoRepetici)
                    .HasColumnName("CODIGO_REPETICI")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CondicionPago)
                    .HasColumnName("CONDICION_PAGO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Copy)
                    .HasColumnName("COPY")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CredConta)
                    .IsRequired()
                    .HasColumnName("CRED_CONTA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Despachar)
                    .IsRequired()
                    .HasColumnName("DESPACHAR")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccFiscal)
                    .HasColumnName("DIRECC_FISCAL")
                    .HasColumnType("text");

                entity.Property(e => e.DireccionEmb1)
                    .IsRequired()
                    .HasColumnName("DIRECCION_EMB1")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccionEmb2)
                    .IsRequired()
                    .HasColumnName("DIRECCION_EMB2")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccionEmb3)
                    .IsRequired()
                    .HasColumnName("DIRECCION_EMB3")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccionFact1)
                    .IsRequired()
                    .HasColumnName("DIRECCION_FACT1")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccionFact2)
                    .IsRequired()
                    .HasColumnName("DIRECCION_FACT2")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccionFact3)
                    .IsRequired()
                    .HasColumnName("DIRECCION_FACT3")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Dolar)
                    .IsRequired()
                    .HasColumnName("DOLAR")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FactFinal)
                    .HasColumnName("FACT_FINAL")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Factura)
                    .HasColumnName("FACTURA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.FacturaRepetir)
                    .HasColumnName("FACTURA_REPETIR")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.FechaFactura)
                    .HasColumnName("FECHA_FACTURA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaRecibCli)
                    .HasColumnName("FECHA_RECIB_CLI")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fiscal)
                    .IsRequired()
                    .HasColumnName("FISCAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagComision)
                    .IsRequired()
                    .HasColumnName("FLAG_COMISION")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Flete)
                    .HasColumnName("FLETE")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Imp)
                    .HasColumnName("IMP")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ImpuestoDol)
                    .HasColumnName("IMPUESTO_DOL")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LineaAnt)
                    .HasColumnName("LINEA_ANT")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.MesFactura)
                    .HasColumnName("MES_FACTURA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.MultiplesEmb)
                    .IsRequired()
                    .HasColumnName("MULTIPLES_EMB")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NcFacturar)
                    .HasColumnName("NC_FACTURAR")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.NitEmb)
                    .HasColumnName("NIT_EMB")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.NitFact)
                    .HasColumnName("NIT_FACT")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NombreEmb)
                    .IsRequired()
                    .HasColumnName("NOMBRE_EMB")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NombreFact)
                    .IsRequired()
                    .HasColumnName("NOMBRE_FACT")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Observacion1)
                    .IsRequired()
                    .HasColumnName("OBSERVACION1")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Observacion2)
                    .IsRequired()
                    .HasColumnName("OBSERVACION2")
                    .HasMaxLength(79)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Observacion3)
                    .IsRequired()
                    .HasColumnName("OBSERVACION3")
                    .HasMaxLength(79)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.OrdenCompra)
                    .IsRequired()
                    .HasColumnName("ORDEN_COMPRA")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.OtroGasto1)
                    .HasColumnName("OTRO_GASTO_1")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.OtroGasto1R)
                    .HasColumnName("OTRO_GASTO_1_R")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.OtroGasto2)
                    .HasColumnName("OTRO_GASTO_2")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Pais)
                    .HasColumnName("PAIS")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RegistroTribut)
                    .IsRequired()
                    .HasColumnName("REGISTRO_TRIBUT")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.RifEmb)
                    .IsRequired()
                    .HasColumnName("RIF_EMB")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.RifFact)
                    .IsRequired()
                    .HasColumnName("RIF_FACT")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SdoAnticipo)
                    .HasColumnName("SDO_ANTICIPO")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SdoAnticipoDo)
                    .HasColumnName("SDO_ANTICIPO_DO")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Seguro)
                    .HasColumnName("SEGURO")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Supervisor)
                    .IsRequired()
                    .HasColumnName("SUPERVISOR")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TasaAnticipo)
                    .HasColumnName("TASA_ANTICIPO")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TasaImpuesto)
                    .HasColumnName("TASA_IMPUESTO")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TipoCambio)
                    .HasColumnName("TIPO_CAMBIO")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TipoDoc)
                    .HasColumnName("TIPO_DOC")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TotalParcial)
                    .IsRequired()
                    .HasColumnName("TOTAL_PARCIAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Transmision)
                    .IsRequired()
                    .HasColumnName("TRANSMISION")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.UnidadFacturar)
                    .HasColumnName("UNIDAD_FACTURAR")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorLista)
                    .HasColumnName("VALOR_LISTA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorListaR)
                    .HasColumnName("VALOR_LISTA_R")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorListad)
                    .HasColumnName("VALOR_LISTAD")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorListadR)
                    .HasColumnName("VALOR_LISTAD_R")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorVenta)
                    .HasColumnName("VALOR_VENTA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorVentaR)
                    .HasColumnName("VALOR_VENTA_R")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorVentad)
                    .HasColumnName("VALOR_VENTAD")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorVentadR)
                    .HasColumnName("VALOR_VENTAD_R")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.VendGestion)
                    .IsRequired()
                    .HasColumnName("VEND_GESTION")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Vendedor)
                    .IsRequired()
                    .HasColumnName("VENDEDOR")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Ciny065>(entity =>
            {
                entity.HasKey(e => new { e.JobId, e.Recnum })
                    .HasName("CINY065_INDEX01");

                entity.ToTable("CINY065");

                entity.HasIndex(e => e.Recnum)
                    .HasName("CINY065_INDEX00")
                    .IsUnique();

                entity.HasIndex(e => new { e.Articulo, e.Orden })
                    .HasName("CINY065_INDEX03")
                    .IsUnique();

                entity.HasIndex(e => new { e.Orden, e.Recnum })
                    .HasName("CINY065_INDEX02")
                    .IsUnique();

                entity.Property(e => e.JobId)
                    .HasColumnName("JOB_ID")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Articulo)
                    .IsRequired()
                    .HasColumnName("ARTICULO")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Bultos)
                    .HasColumnName("BULTOS")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Cantidad)
                    .HasColumnName("CANTIDAD")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CantidadOfic)
                    .HasColumnName("CANTIDAD_OFIC")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CentroFact)
                    .HasColumnName("CENTRO_FACT")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CtdEntregar)
                    .HasColumnName("CTD_ENTREGAR")
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

                entity.Property(e => e.DireccionEmb)
                    .HasColumnName("DIRECCION_EMB")
                    .HasColumnType("text");

                entity.Property(e => e.DireccionFact)
                    .HasColumnName("DIRECCION_FACT")
                    .HasColumnType("text");

                entity.Property(e => e.EntNumDesde)
                    .HasColumnName("ENT_NUM_DESDE")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.EntNumHasta)
                    .HasColumnName("ENT_NUM_HASTA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.EntPrefDesde)
                    .IsRequired()
                    .HasColumnName("ENT_PREF_DESDE")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.EntPrefHasta)
                    .IsRequired()
                    .HasColumnName("ENT_PREF_HASTA")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.EntSufiDesde)
                    .IsRequired()
                    .HasColumnName("ENT_SUFI_DESDE")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.EntSufiHasta)
                    .IsRequired()
                    .HasColumnName("ENT_SUFI_HASTA")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Factura)
                    .HasColumnName("FACTURA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.FacturaAfecta)
                    .HasColumnName("FACTURA_AFECTA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Familia)
                    .IsRequired()
                    .HasColumnName("FAMILIA")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FamiliaProducc)
                    .IsRequired()
                    .HasColumnName("FAMILIA_PRODUCC")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FecComproClte)
                    .HasColumnName("FEC_COMPRO_CLTE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FecRecPlaneac)
                    .HasColumnName("FEC_REC_PLANEAC")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaFactura)
                    .HasColumnName("FECHA_FACTURA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaOfic)
                    .HasColumnName("FECHA_OFIC")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaOrden)
                    .HasColumnName("FECHA_ORDEN")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlagFaltante)
                    .IsRequired()
                    .HasColumnName("FLAG_FALTANTE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagImprenta)
                    .IsRequired()
                    .HasColumnName("FLAG_IMPRENTA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagRetenido)
                    .IsRequired()
                    .HasColumnName("FLAG_RETENIDO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagTipoJob)
                    .IsRequired()
                    .HasColumnName("FLAG_TIPO_JOB")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagTipoOrden)
                    .IsRequired()
                    .HasColumnName("FLAG_TIPO_ORDEN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FormasBajotiro)
                    .HasColumnName("FORMAS_BAJOTIRO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.FormasUnidad)
                    .HasColumnName("FORMAS_UNIDAD")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Impuesto1)
                    .HasColumnName("IMPUESTO_1")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Impuesto1R)
                    .HasColumnName("IMPUESTO_1_R")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Impuesto2)
                    .HasColumnName("IMPUESTO_2")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ImpuestoDol)
                    .HasColumnName("IMPUESTO_DOL")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ImpuestoDolR)
                    .HasColumnName("IMPUESTO_DOL_R")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Iva)
                    .HasColumnName("IVA")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Linea1)
                    .IsRequired()
                    .HasColumnName("LINEA1")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.LineaProduccio)
                    .IsRequired()
                    .HasColumnName("LINEA_PRODUCCIO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ListaUnitDol)
                    .HasColumnName("LISTA_UNIT_DOL")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ListaUnitDolr)
                    .HasColumnName("LISTA_UNIT_DOLR")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.MetodoPrecio1)
                    .IsRequired()
                    .HasColumnName("METODO_PRECIO1")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NoEntrega)
                    .HasColumnName("NO_ENTREGA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.NombreEmb)
                    .HasColumnName("NOMBRE_EMB")
                    .HasColumnType("text");

                entity.Property(e => e.NombreFact)
                    .HasColumnName("NOMBRE_FACT")
                    .HasColumnType("text");

                entity.Property(e => e.NumeroDesde)
                    .HasColumnName("NUMERO_DESDE")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.NumeroHasta)
                    .HasColumnName("NUMERO_HASTA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Orden)
                    .HasColumnName("ORDEN")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.OrigenProducto)
                    .IsRequired()
                    .HasColumnName("ORIGEN_PRODUCTO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Pais)
                    .IsRequired()
                    .HasColumnName("PAIS")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Partes)
                    .IsRequired()
                    .HasColumnName("PARTES")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PrecioLista)
                    .HasColumnName("PRECIO_LISTA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PrecioListaR)
                    .HasColumnName("PRECIO_LISTA_R")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PrecioVenta)
                    .HasColumnName("PRECIO_VENTA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PrecioVentaR)
                    .HasColumnName("PRECIO_VENTA_R")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PrefijoDesde)
                    .IsRequired()
                    .HasColumnName("PREFIJO_DESDE")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PrefijoHasta)
                    .IsRequired()
                    .HasColumnName("PREFIJO_HASTA")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.RemisionOfic)
                    .HasColumnName("REMISION_OFIC")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RifEmb)
                    .IsRequired()
                    .HasColumnName("RIF_EMB")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.RifFact)
                    .IsRequired()
                    .HasColumnName("RIF_FACT")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SufijoDesde)
                    .IsRequired()
                    .HasColumnName("SUFIJO_DESDE")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SufijoHasta)
                    .IsRequired()
                    .HasColumnName("SUFIJO_HASTA")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TipoDoc)
                    .HasColumnName("TIPO_DOC")
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

                entity.Property(e => e.TotalParcial)
                    .IsRequired()
                    .HasColumnName("TOTAL_PARCIAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.UnidadFacturar)
                    .IsRequired()
                    .HasColumnName("UNIDAD_FACTURAR")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ValorLista)
                    .HasColumnName("VALOR_LISTA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorListaR)
                    .HasColumnName("VALOR_LISTA_R")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorListad)
                    .HasColumnName("VALOR_LISTAD")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorListadR)
                    .HasColumnName("VALOR_LISTAD_R")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorVenta)
                    .HasColumnName("VALOR_VENTA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorVentaR)
                    .HasColumnName("VALOR_VENTA_R")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorVentad)
                    .HasColumnName("VALOR_VENTAD")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorVentadR)
                    .HasColumnName("VALOR_VENTAD_R")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.VentaUnitDol)
                    .HasColumnName("VENTA_UNIT_DOL")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.VentaUnitDolr)
                    .HasColumnName("VENTA_UNIT_DOLR")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<Ciny066>(entity =>
            {
                entity.HasKey(e => e.Orden)
                    .HasName("CINY066_INDEX01");

                entity.ToTable("CINY066");

                entity.HasIndex(e => e.Recnum)
                    .HasName("CINY066_INDEX00")
                    .IsUnique();

                entity.Property(e => e.Orden)
                    .HasColumnName("ORDEN")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AnoFactura)
                    .HasColumnName("ANO_FACTURA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Anticipo)
                    .HasColumnName("ANTICIPO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Anulada)
                    .IsRequired()
                    .HasColumnName("ANULADA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Cajas)
                    .HasColumnName("CAJAS")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CentroFact)
                    .HasColumnName("CENTRO_FACT")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Cliente)
                    .HasColumnName("CLIENTE")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CodEdo)
                    .IsRequired()
                    .HasColumnName("COD_EDO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CodMcpo)
                    .IsRequired()
                    .HasColumnName("COD_MCPO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CodigoRepetici)
                    .HasColumnName("CODIGO_REPETICI")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CondicionPago)
                    .HasColumnName("CONDICION_PAGO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Copy)
                    .HasColumnName("COPY")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CredConta)
                    .IsRequired()
                    .HasColumnName("CRED_CONTA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Despachar)
                    .IsRequired()
                    .HasColumnName("DESPACHAR")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccFiscal)
                    .HasColumnName("DIRECC_FISCAL")
                    .HasColumnType("text");

                entity.Property(e => e.DireccionEmb1)
                    .IsRequired()
                    .HasColumnName("DIRECCION_EMB1")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccionEmb2)
                    .IsRequired()
                    .HasColumnName("DIRECCION_EMB2")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccionEmb3)
                    .IsRequired()
                    .HasColumnName("DIRECCION_EMB3")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccionFact1)
                    .IsRequired()
                    .HasColumnName("DIRECCION_FACT1")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccionFact2)
                    .IsRequired()
                    .HasColumnName("DIRECCION_FACT2")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccionFact3)
                    .IsRequired()
                    .HasColumnName("DIRECCION_FACT3")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Dolar)
                    .IsRequired()
                    .HasColumnName("DOLAR")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FactFinal)
                    .HasColumnName("FACT_FINAL")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Factura)
                    .HasColumnName("FACTURA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.FacturaRepetir)
                    .HasColumnName("FACTURA_REPETIR")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.FechaFactura)
                    .HasColumnName("FECHA_FACTURA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaRecibCli)
                    .HasColumnName("FECHA_RECIB_CLI")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fiscal)
                    .IsRequired()
                    .HasColumnName("FISCAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagComision)
                    .IsRequired()
                    .HasColumnName("FLAG_COMISION")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Flete)
                    .HasColumnName("FLETE")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Imp)
                    .HasColumnName("IMP")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ImpuestoDol)
                    .HasColumnName("IMPUESTO_DOL")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LineaAnt)
                    .HasColumnName("LINEA_ANT")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.MesFactura)
                    .HasColumnName("MES_FACTURA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.MultiplesEmb)
                    .IsRequired()
                    .HasColumnName("MULTIPLES_EMB")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NcFacturar)
                    .HasColumnName("NC_FACTURAR")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.NitEmb)
                    .HasColumnName("NIT_EMB")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.NitFact)
                    .HasColumnName("NIT_FACT")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NombreEmb)
                    .IsRequired()
                    .HasColumnName("NOMBRE_EMB")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NombreFact)
                    .IsRequired()
                    .HasColumnName("NOMBRE_FACT")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Observacion1)
                    .IsRequired()
                    .HasColumnName("OBSERVACION1")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Observacion2)
                    .IsRequired()
                    .HasColumnName("OBSERVACION2")
                    .HasMaxLength(79)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Observacion3)
                    .IsRequired()
                    .HasColumnName("OBSERVACION3")
                    .HasMaxLength(79)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.OrdenCompra)
                    .IsRequired()
                    .HasColumnName("ORDEN_COMPRA")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.OtroGasto1)
                    .HasColumnName("OTRO_GASTO_1")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.OtroGasto1R)
                    .HasColumnName("OTRO_GASTO_1_R")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.OtroGasto2)
                    .HasColumnName("OTRO_GASTO_2")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Pais)
                    .HasColumnName("PAIS")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RegistroTribut)
                    .IsRequired()
                    .HasColumnName("REGISTRO_TRIBUT")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.RifEmb)
                    .IsRequired()
                    .HasColumnName("RIF_EMB")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.RifFact)
                    .IsRequired()
                    .HasColumnName("RIF_FACT")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SdoAnticipo)
                    .HasColumnName("SDO_ANTICIPO")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SdoAnticipoDo)
                    .HasColumnName("SDO_ANTICIPO_DO")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Seguro)
                    .HasColumnName("SEGURO")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Supervisor)
                    .IsRequired()
                    .HasColumnName("SUPERVISOR")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TasaAnticipo)
                    .HasColumnName("TASA_ANTICIPO")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TasaImpuesto)
                    .HasColumnName("TASA_IMPUESTO")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TipoCambio)
                    .HasColumnName("TIPO_CAMBIO")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TipoDoc)
                    .HasColumnName("TIPO_DOC")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TotalParcial)
                    .IsRequired()
                    .HasColumnName("TOTAL_PARCIAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Transmision)
                    .IsRequired()
                    .HasColumnName("TRANSMISION")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.UnidadFacturar)
                    .HasColumnName("UNIDAD_FACTURAR")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorLista)
                    .HasColumnName("VALOR_LISTA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorListaR)
                    .HasColumnName("VALOR_LISTA_R")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorListad)
                    .HasColumnName("VALOR_LISTAD")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorListadR)
                    .HasColumnName("VALOR_LISTAD_R")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorVenta)
                    .HasColumnName("VALOR_VENTA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorVentaR)
                    .HasColumnName("VALOR_VENTA_R")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorVentad)
                    .HasColumnName("VALOR_VENTAD")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorVentadR)
                    .HasColumnName("VALOR_VENTAD_R")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.VendGestion)
                    .IsRequired()
                    .HasColumnName("VEND_GESTION")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Vendedor)
                    .IsRequired()
                    .HasColumnName("VENDEDOR")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Ciny067>(entity =>
            {
                entity.HasKey(e => new { e.JobId, e.Recnum })
                    .HasName("CINY067_INDEX01");

                entity.ToTable("CINY067");

                entity.HasIndex(e => e.Recnum)
                    .HasName("CINY067_INDEX00")
                    .IsUnique();

                entity.HasIndex(e => new { e.Articulo, e.Orden })
                    .HasName("CINY067_INDEX03")
                    .IsUnique();

                entity.HasIndex(e => new { e.Orden, e.Recnum })
                    .HasName("CINY067_INDEX02")
                    .IsUnique();

                entity.Property(e => e.JobId)
                    .HasColumnName("JOB_ID")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Articulo)
                    .IsRequired()
                    .HasColumnName("ARTICULO")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Bultos)
                    .HasColumnName("BULTOS")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Cantidad)
                    .HasColumnName("CANTIDAD")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CantidadOfic)
                    .HasColumnName("CANTIDAD_OFIC")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CentroFact)
                    .HasColumnName("CENTRO_FACT")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CtdEntregar)
                    .HasColumnName("CTD_ENTREGAR")
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

                entity.Property(e => e.DireccionEmb)
                    .HasColumnName("DIRECCION_EMB")
                    .HasColumnType("text");

                entity.Property(e => e.DireccionFact)
                    .HasColumnName("DIRECCION_FACT")
                    .HasColumnType("text");

                entity.Property(e => e.EntNumDesde)
                    .HasColumnName("ENT_NUM_DESDE")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.EntNumHasta)
                    .HasColumnName("ENT_NUM_HASTA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.EntPrefDesde)
                    .IsRequired()
                    .HasColumnName("ENT_PREF_DESDE")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.EntPrefHasta)
                    .IsRequired()
                    .HasColumnName("ENT_PREF_HASTA")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.EntSufiDesde)
                    .IsRequired()
                    .HasColumnName("ENT_SUFI_DESDE")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.EntSufiHasta)
                    .IsRequired()
                    .HasColumnName("ENT_SUFI_HASTA")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Factura)
                    .HasColumnName("FACTURA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.FacturaAfecta)
                    .HasColumnName("FACTURA_AFECTA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Familia)
                    .IsRequired()
                    .HasColumnName("FAMILIA")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FamiliaProducc)
                    .IsRequired()
                    .HasColumnName("FAMILIA_PRODUCC")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FecComproClte)
                    .HasColumnName("FEC_COMPRO_CLTE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FecRecPlaneac)
                    .HasColumnName("FEC_REC_PLANEAC")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaFactura)
                    .HasColumnName("FECHA_FACTURA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaOfic)
                    .HasColumnName("FECHA_OFIC")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaOrden)
                    .HasColumnName("FECHA_ORDEN")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlagFaltante)
                    .IsRequired()
                    .HasColumnName("FLAG_FALTANTE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagImprenta)
                    .IsRequired()
                    .HasColumnName("FLAG_IMPRENTA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagRetenido)
                    .IsRequired()
                    .HasColumnName("FLAG_RETENIDO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagTipoJob)
                    .IsRequired()
                    .HasColumnName("FLAG_TIPO_JOB")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagTipoOrden)
                    .IsRequired()
                    .HasColumnName("FLAG_TIPO_ORDEN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FormasBajotiro)
                    .HasColumnName("FORMAS_BAJOTIRO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.FormasUnidad)
                    .HasColumnName("FORMAS_UNIDAD")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Impuesto1)
                    .HasColumnName("IMPUESTO_1")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Impuesto1R)
                    .HasColumnName("IMPUESTO_1_R")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Impuesto2)
                    .HasColumnName("IMPUESTO_2")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ImpuestoDol)
                    .HasColumnName("IMPUESTO_DOL")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ImpuestoDolR)
                    .HasColumnName("IMPUESTO_DOL_R")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Iva)
                    .HasColumnName("IVA")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Linea1)
                    .IsRequired()
                    .HasColumnName("LINEA1")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.LineaProduccio)
                    .IsRequired()
                    .HasColumnName("LINEA_PRODUCCIO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ListaUnitDol)
                    .HasColumnName("LISTA_UNIT_DOL")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ListaUnitDolr)
                    .HasColumnName("LISTA_UNIT_DOLR")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.MetodoPrecio1)
                    .IsRequired()
                    .HasColumnName("METODO_PRECIO1")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NoEntrega)
                    .HasColumnName("NO_ENTREGA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.NombreEmb)
                    .HasColumnName("NOMBRE_EMB")
                    .HasColumnType("text");

                entity.Property(e => e.NombreFact)
                    .HasColumnName("NOMBRE_FACT")
                    .HasColumnType("text");

                entity.Property(e => e.NumeroDesde)
                    .HasColumnName("NUMERO_DESDE")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.NumeroHasta)
                    .HasColumnName("NUMERO_HASTA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Orden)
                    .HasColumnName("ORDEN")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.OrigenProducto)
                    .IsRequired()
                    .HasColumnName("ORIGEN_PRODUCTO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Pais)
                    .IsRequired()
                    .HasColumnName("PAIS")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Partes)
                    .IsRequired()
                    .HasColumnName("PARTES")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PrecioLista)
                    .HasColumnName("PRECIO_LISTA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PrecioListaR)
                    .HasColumnName("PRECIO_LISTA_R")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PrecioVenta)
                    .HasColumnName("PRECIO_VENTA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PrecioVentaR)
                    .HasColumnName("PRECIO_VENTA_R")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PrefijoDesde)
                    .IsRequired()
                    .HasColumnName("PREFIJO_DESDE")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PrefijoHasta)
                    .IsRequired()
                    .HasColumnName("PREFIJO_HASTA")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.RemisionOfic)
                    .HasColumnName("REMISION_OFIC")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RifEmb)
                    .IsRequired()
                    .HasColumnName("RIF_EMB")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.RifFact)
                    .IsRequired()
                    .HasColumnName("RIF_FACT")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SufijoDesde)
                    .IsRequired()
                    .HasColumnName("SUFIJO_DESDE")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SufijoHasta)
                    .IsRequired()
                    .HasColumnName("SUFIJO_HASTA")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TipoDoc)
                    .HasColumnName("TIPO_DOC")
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

                entity.Property(e => e.TotalParcial)
                    .IsRequired()
                    .HasColumnName("TOTAL_PARCIAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.UnidadFacturar)
                    .IsRequired()
                    .HasColumnName("UNIDAD_FACTURAR")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ValorLista)
                    .HasColumnName("VALOR_LISTA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorListaR)
                    .HasColumnName("VALOR_LISTA_R")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorListad)
                    .HasColumnName("VALOR_LISTAD")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorListadR)
                    .HasColumnName("VALOR_LISTAD_R")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorVenta)
                    .HasColumnName("VALOR_VENTA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorVentaR)
                    .HasColumnName("VALOR_VENTA_R")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorVentad)
                    .HasColumnName("VALOR_VENTAD")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorVentadR)
                    .HasColumnName("VALOR_VENTAD_R")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.VentaUnitDol)
                    .HasColumnName("VENTA_UNIT_DOL")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.VentaUnitDolr)
                    .HasColumnName("VENTA_UNIT_DOLR")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<Ciny100>(entity =>
            {
                entity.HasKey(e => new { e.TipoProducto, e.SumaResta })
                    .HasName("CINY100_INDEX01");

                entity.ToTable("CINY100");

                entity.HasIndex(e => e.Recnum)
                    .HasName("CINY100_INDEX00")
                    .IsUnique();

                entity.Property(e => e.TipoProducto)
                    .HasColumnName("TIPO_PRODUCTO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SumaResta)
                    .HasColumnName("SUMA_RESTA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Campo)
                    .HasColumnName("CAMPO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.FechaDesde)
                    .HasColumnName("FECHA_DESDE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaHasta)
                    .HasColumnName("FECHA_HASTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Hora)
                    .IsRequired()
                    .HasColumnName("HORA")
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Lista)
                    .HasColumnName("LISTA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TasaDolar)
                    .HasColumnName("TASA_DOLAR")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Venta)
                    .HasColumnName("VENTA")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<Ciny101>(entity =>
            {
                entity.HasKey(e => new { e.TipoProducto, e.SumaResta })
                    .HasName("CINY101_INDEX01");

                entity.ToTable("CINY101");

                entity.HasIndex(e => e.Recnum)
                    .HasName("CINY101_INDEX00")
                    .IsUnique();

                entity.Property(e => e.TipoProducto)
                    .HasColumnName("TIPO_PRODUCTO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SumaResta)
                    .HasColumnName("SUMA_RESTA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Campo)
                    .HasColumnName("CAMPO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.FechaDesde)
                    .HasColumnName("FECHA_DESDE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaHasta)
                    .HasColumnName("FECHA_HASTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Hora)
                    .IsRequired()
                    .HasColumnName("HORA")
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Lista)
                    .HasColumnName("LISTA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Venta)
                    .HasColumnName("VENTA")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<Ciny102>(entity =>
            {
                entity.HasKey(e => e.Clave)
                    .HasName("CINY102_INDEX01");

                entity.ToTable("CINY102");

                entity.HasIndex(e => e.Recnum)
                    .HasName("CINY102_INDEX00")
                    .IsUnique();

                entity.Property(e => e.Clave)
                    .HasColumnName("CLAVE")
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ActionItems)
                    .IsRequired()
                    .HasColumnName("ACTION_ITEMS")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Fecha)
                    .HasColumnName("FECHA")
                    .HasColumnType("datetime");

                entity.Property(e => e.ListaBs)
                    .HasColumnName("LISTA_BS")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ListaDol)
                    .HasColumnName("LISTA_DOL")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Orden)
                    .IsRequired()
                    .HasColumnName("ORDEN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PresupBsHoy)
                    .HasColumnName("PRESUP_BS_HOY")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PresupDolHoy)
                    .HasColumnName("PRESUP_DOL_HOY")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PresupuestoBs)
                    .HasColumnName("PRESUPUESTO_BS")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PresupuestoDol)
                    .HasColumnName("PRESUPUESTO_DOL")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Responsable)
                    .IsRequired()
                    .HasColumnName("RESPONSABLE")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Tasa)
                    .HasColumnName("TASA")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.VentaBs)
                    .HasColumnName("VENTA_BS")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.VentaDol)
                    .HasColumnName("VENTA_DOL")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<Ciny103>(entity =>
            {
                entity.HasKey(e => e.Mes)
                    .HasName("CINY103_INDEX01");

                entity.ToTable("CINY103");

                entity.HasIndex(e => e.Recnum)
                    .HasName("CINY103_INDEX00")
                    .IsUnique();

                entity.Property(e => e.Mes)
                    .HasColumnName("MES")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ActionItemsCp)
                    .IsRequired()
                    .HasColumnName("ACTION_ITEMS_CP")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ActionItemsEt)
                    .IsRequired()
                    .HasColumnName("ACTION_ITEMS_ET")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ActionItemsIm)
                    .IsRequired()
                    .HasColumnName("ACTION_ITEMS_IM")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ActionItemsJo)
                    .IsRequired()
                    .HasColumnName("ACTION_ITEMS_JO")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ActionItemsMo)
                    .IsRequired()
                    .HasColumnName("ACTION_ITEMS_MO")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Cpo)
                    .HasColumnName("CPO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Etiquetas)
                    .HasColumnName("ETIQUETAS")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Impresos)
                    .HasColumnName("IMPRESOS")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Jobbing)
                    .HasColumnName("JOBBING")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Outsourcing)
                    .HasColumnName("OUTSOURCING")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ResponsableCp)
                    .IsRequired()
                    .HasColumnName("RESPONSABLE_CP")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ResponsableEt)
                    .IsRequired()
                    .HasColumnName("RESPONSABLE_ET")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ResponsableIm)
                    .IsRequired()
                    .HasColumnName("RESPONSABLE_IM")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ResponsableJo)
                    .IsRequired()
                    .HasColumnName("RESPONSABLE_JO")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ResponsableMo)
                    .IsRequired()
                    .HasColumnName("RESPONSABLE_MO")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TasaDolar)
                    .HasColumnName("TASA_DOLAR")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<Ciny105>(entity =>
            {
                entity.HasKey(e => new { e.Mes, e.Orden })
                    .HasName("CINY105_INDEX01");

                entity.ToTable("CINY105");

                entity.HasIndex(e => e.Recnum)
                    .HasName("CINY105_INDEX00")
                    .IsUnique();

                entity.Property(e => e.Mes)
                    .HasColumnName("MES")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Orden)
                    .HasColumnName("ORDEN")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ActionItems)
                    .IsRequired()
                    .HasColumnName("ACTION_ITEMS")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PresupOrden)
                    .HasColumnName("PRESUP_ORDEN")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Responsable)
                    .IsRequired()
                    .HasColumnName("RESPONSABLE")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TasaDolar)
                    .HasColumnName("TASA_DOLAR")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<Ciny206>(entity =>
            {
                entity.HasKey(e => e.Remision)
                    .HasName("CINY206_INDEX01");

                entity.ToTable("CINY206");

                entity.HasIndex(e => e.Recnum)
                    .HasName("CINY206_INDEX00")
                    .IsUnique();

                entity.Property(e => e.Remision)
                    .HasColumnName("REMISION")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AnoFactura)
                    .HasColumnName("ANO_FACTURA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Anulada)
                    .IsRequired()
                    .HasColumnName("ANULADA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Cajas)
                    .HasColumnName("CAJAS")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CentroFact)
                    .HasColumnName("CENTRO_FACT")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Ciudad)
                    .IsRequired()
                    .HasColumnName("CIUDAD")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Cliente)
                    .HasColumnName("CLIENTE")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CodigoRepetici)
                    .HasColumnName("CODIGO_REPETICI")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CondPago)
                    .HasColumnName("COND_PAGO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CondicionPago)
                    .HasColumnName("CONDICION_PAGO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Copy)
                    .HasColumnName("COPY")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CredConta)
                    .IsRequired()
                    .HasColumnName("CRED_CONTA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccFiscal)
                    .HasColumnName("DIRECC_FISCAL")
                    .HasColumnType("text");

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

                entity.Property(e => e.Dolar)
                    .IsRequired()
                    .HasColumnName("DOLAR")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FactFinal)
                    .HasColumnName("FACT_FINAL")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Factura)
                    .HasColumnName("FACTURA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.FechaDespacho)
                    .HasColumnName("FECHA_DESPACHO")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaFactura)
                    .HasColumnName("FECHA_FACTURA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaRecibCli)
                    .HasColumnName("FECHA_RECIB_CLI")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaRemision)
                    .HasColumnName("FECHA_REMISION")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fiscal)
                    .IsRequired()
                    .HasColumnName("FISCAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagComision)
                    .IsRequired()
                    .HasColumnName("FLAG_COMISION")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagImpreso)
                    .IsRequired()
                    .HasColumnName("FLAG_IMPRESO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Flete)
                    .HasColumnName("FLETE")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.GiroNegocio)
                    .IsRequired()
                    .HasColumnName("GIRO_NEGOCIO")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Imp)
                    .HasColumnName("IMP")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ImpStock)
                    .IsRequired()
                    .HasColumnName("IMP_STOCK")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.MesFactura)
                    .HasColumnName("MES_FACTURA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.MultiplesEmb)
                    .IsRequired()
                    .HasColumnName("MULTIPLES_EMB")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Nit)
                    .HasColumnName("NIT")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Obs)
                    .IsRequired()
                    .HasColumnName("OBS")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Observacion1)
                    .IsRequired()
                    .HasColumnName("OBSERVACION1")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Observacion2)
                    .IsRequired()
                    .HasColumnName("OBSERVACION2")
                    .HasMaxLength(79)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Observacion3)
                    .IsRequired()
                    .HasColumnName("OBSERVACION3")
                    .HasMaxLength(79)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Orden)
                    .HasColumnName("ORDEN")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.OrdenCompra)
                    .IsRequired()
                    .HasColumnName("ORDEN_COMPRA")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.OtroGasto1)
                    .HasColumnName("OTRO_GASTO_1")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.OtroGasto2)
                    .HasColumnName("OTRO_GASTO_2")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Pais)
                    .HasColumnName("PAIS")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RegistroTribut)
                    .IsRequired()
                    .HasColumnName("REGISTRO_TRIBUT")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Seguro)
                    .HasColumnName("SEGURO")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Supervisor)
                    .IsRequired()
                    .HasColumnName("SUPERVISOR")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TasaImpuesto)
                    .HasColumnName("TASA_IMPUESTO")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasColumnName("TELEFONO")
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TipoCambio)
                    .HasColumnName("TIPO_CAMBIO")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TipoDoc)
                    .HasColumnName("TIPO_DOC")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TotalParcial)
                    .IsRequired()
                    .HasColumnName("TOTAL_PARCIAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Transmision)
                    .IsRequired()
                    .HasColumnName("TRANSMISION")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.UnidadFacturar)
                    .HasColumnName("UNIDAD_FACTURAR")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorLista)
                    .HasColumnName("VALOR_LISTA")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorListad)
                    .HasColumnName("VALOR_LISTAD")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorVenta)
                    .HasColumnName("VALOR_VENTA")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorVentad)
                    .HasColumnName("VALOR_VENTAD")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.VendGestion)
                    .IsRequired()
                    .HasColumnName("VEND_GESTION")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Vendedor)
                    .IsRequired()
                    .HasColumnName("VENDEDOR")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Ciny207>(entity =>
            {
                entity.HasKey(e => e.Recnum);

                entity.ToTable("CINY207");

                entity.HasIndex(e => e.Orden)
                    .HasName("dep_CINY207orden");

                entity.HasIndex(e => e.Recnum)
                    .HasName("CINY207_INDEX00")
                    .IsUnique();

                entity.HasIndex(e => new { e.Factura, e.Recnum })
                    .HasName("CINY207_INDEX02")
                    .IsUnique();

                entity.HasIndex(e => new { e.FlagImpreso, e.Remision, e.Recnum })
                    .HasName("CINY207_INDEX04")
                    .IsUnique();

                entity.HasIndex(e => new { e.Orden, e.Factura, e.Recnum })
                    .HasName("CINY207_INDEX03")
                    .IsUnique();

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AnoFactura)
                    .HasColumnName("ANO_FACTURA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Anulada)
                    .HasColumnName("ANULADA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Cajas)
                    .HasColumnName("CAJAS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CantResumen)
                    .HasColumnName("CANT_RESUMEN")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CentroFact)
                    .HasColumnName("CENTRO_FACT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ciudad)
                    .HasColumnName("CIUDAD")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Cliente)
                    .HasColumnName("CLIENTE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CodigoRepetici)
                    .HasColumnName("CODIGO_REPETICI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ColetillaInd1)
                    .HasColumnName("COLETILLA_IND1")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ColetillaInd2)
                    .HasColumnName("COLETILLA_IND2")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ColetillaInd3)
                    .HasColumnName("COLETILLA_IND3")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ColetillaInd4)
                    .HasColumnName("COLETILLA_IND4")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.CondPago)
                    .HasColumnName("COND_PAGO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CondicionPago)
                    .HasColumnName("CONDICION_PAGO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Copy)
                    .HasColumnName("COPY")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CredConta)
                    .HasColumnName("CRED_CONTA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Dciudad)
                    .HasColumnName("DCIUDAD")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DescResumen1)
                    .HasColumnName("DESC_RESUMEN1")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.DescResumen2)
                    .HasColumnName("DESC_RESUMEN2")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Destado)
                    .HasColumnName("DESTADO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DireccFiscal)
                    .HasColumnName("DIRECC_FISCAL")
                    .HasColumnType("text");

                entity.Property(e => e.Direccion)
                    .HasColumnName("DIRECCION")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Direccion1)
                    .HasColumnName("DIRECCION1")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Direccion2)
                    .HasColumnName("DIRECCION2")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Dolar)
                    .HasColumnName("DOLAR")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.EstadoEntregar).HasMaxLength(2);

                entity.Property(e => e.EstadoFacturar).HasMaxLength(2);

                entity.Property(e => e.FactFinal)
                    .HasColumnName("FACT_FINAL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Factura)
                    .HasColumnName("FACTURA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FechaDespacho)
                    .HasColumnName("FECHA_DESPACHO")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaFactura)
                    .HasColumnName("FECHA_FACTURA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaRecibCli)
                    .HasColumnName("FECHA_RECIB_CLI")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaRemision)
                    .HasColumnName("FECHA_REMISION")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fiscal)
                    .HasColumnName("FISCAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagComision)
                    .HasColumnName("FLAG_COMISION")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagGeneroPdf)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FlagImpreso)
                    .HasColumnName("FLAG_IMPRESO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Flete)
                    .HasColumnName("FLETE")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.GiroNegocio)
                    .HasColumnName("GIRO_NEGOCIO")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.IdDirEntregar).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IdDirFacturar).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IdDireccion).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Imp)
                    .HasColumnName("IMP")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ImpStock)
                    .HasColumnName("IMP_STOCK")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ImpuestoDol)
                    .HasColumnName("IMPUESTO_DOL")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.JobId)
                    .HasColumnName("JOB_ID")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.MesFactura)
                    .HasColumnName("MES_FACTURA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Miscelaneo)
                    .HasColumnName("MISCELANEO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MultiplesEmb)
                    .HasColumnName("MULTIPLES_EMB")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Municipio)
                    .HasColumnName("MUNICIPIO")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.MunicipioEntregar).HasMaxLength(2);

                entity.Property(e => e.MunicipioFacturar).HasMaxLength(2);

                entity.Property(e => e.Nit)
                    .HasColumnName("NIT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Nombre)
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NroControl)
                    .HasColumnName("NRO_CONTROL")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Obs)
                    .HasColumnName("OBS")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ObsCobranzas1)
                    .HasColumnName("OBS_COBRANZAS1")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ObsCobranzas2)
                    .HasColumnName("OBS_COBRANZAS2")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ObsCobranzas3)
                    .HasColumnName("OBS_COBRANZAS3")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ObsCobranzas4)
                    .HasColumnName("OBS_COBRANZAS4")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Observacion1)
                    .HasColumnName("OBSERVACION1")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Observacion2)
                    .HasColumnName("OBSERVACION2")
                    .HasMaxLength(79)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Observacion3)
                    .HasColumnName("OBSERVACION3")
                    .HasMaxLength(79)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Orden)
                    .HasColumnName("ORDEN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OrdenCompra)
                    .HasColumnName("ORDEN_COMPRA")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.OtroGasto1)
                    .HasColumnName("OTRO_GASTO_1")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OtroGasto2)
                    .HasColumnName("OTRO_GASTO_2")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Pais)
                    .HasColumnName("PAIS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RegistroTribut)
                    .HasColumnName("REGISTRO_TRIBUT")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Remision)
                    .HasColumnName("REMISION")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RotroGasto1)
                    .HasColumnName("ROTRO_GASTO_1")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RvalorLista)
                    .HasColumnName("RVALOR_LISTA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RvalorVenta)
                    .HasColumnName("RVALOR_VENTA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Seguro)
                    .HasColumnName("SEGURO")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Supervisor)
                    .HasColumnName("SUPERVISOR")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TasaImpuesto)
                    .HasColumnName("TASA_IMPUESTO")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Telefono)
                    .HasColumnName("TELEFONO")
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TipoCambio)
                    .HasColumnName("TIPO_CAMBIO")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TipoDoc)
                    .HasColumnName("TIPO_DOC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalParcial)
                    .HasColumnName("TOTAL_PARCIAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Transmision)
                    .HasColumnName("TRANSMISION")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.UndResumen)
                    .HasColumnName("UND_RESUMEN")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnidadFacturar)
                    .HasColumnName("UNIDAD_FACTURAR")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ValorLista)
                    .HasColumnName("VALOR_LISTA")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ValorListad)
                    .HasColumnName("VALOR_LISTAD")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ValorVenta)
                    .HasColumnName("VALOR_VENTA")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ValorVentad)
                    .HasColumnName("VALOR_VENTAD")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VendGestion)
                    .HasColumnName("VEND_GESTION")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Vendedor)
                    .HasColumnName("VENDEDOR")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Ciny208>(entity =>
            {
                entity.HasKey(e => new { e.Remision, e.Recnum })
                    .HasName("CINY208_INDEX01");

                entity.ToTable("CINY208");

                entity.HasIndex(e => e.Orden)
                    .HasName("dep_CINY208orden");

                entity.HasIndex(e => e.Recnum)
                    .HasName("CINY208_INDEX00")
                    .IsUnique();

                entity.HasIndex(e => new { e.Factura, e.Recnum })
                    .HasName("CINY208_INDEX02")
                    .IsUnique();

                entity.HasIndex(e => new { e.Orden, e.Recnum })
                    .HasName("CINY208_INDEX03")
                    .IsUnique();

                entity.Property(e => e.Remision)
                    .HasColumnName("REMISION")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Articulo)
                    .IsRequired()
                    .HasColumnName("ARTICULO")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.BultoDesp)
                    .HasColumnName("BULTO_DESP")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.BultoTran)
                    .HasColumnName("BULTO_TRAN")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Bultos)
                    .HasColumnName("BULTOS")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Cantidad)
                    .HasColumnName("CANTIDAD")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CentroFact)
                    .HasColumnName("CENTRO_FACT")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Copy)
                    .HasColumnName("COPY")
                    .HasColumnType("decimal(10, 0)")
                    .HasDefaultValueSql("((0))");

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

                entity.Property(e => e.Factura)
                    .HasColumnName("FACTURA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.FacturasAdelantadas).HasDefaultValueSql("('')");

                entity.Property(e => e.FamiliaProducc)
                    .IsRequired()
                    .HasColumnName("FAMILIA_PRODUCC")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FecComproClte)
                    .HasColumnName("FEC_COMPRO_CLTE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FecRecPlaneac)
                    .HasColumnName("FEC_REC_PLANEAC")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaEntrega)
                    .HasColumnName("FECHA_ENTREGA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaFactura)
                    .HasColumnName("FECHA_FACTURA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaOrden)
                    .HasColumnName("FECHA_ORDEN")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaProg)
                    .HasColumnName("FECHA_PROG")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlagExistencia)
                    .IsRequired()
                    .HasColumnName("FLAG_EXISTENCIA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagImprenta)
                    .IsRequired()
                    .HasColumnName("FLAG_IMPRENTA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagOficina)
                    .IsRequired()
                    .HasColumnName("FLAG_OFICINA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagRetenido)
                    .IsRequired()
                    .HasColumnName("FLAG_RETENIDO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagTipoJob)
                    .IsRequired()
                    .HasColumnName("FLAG_TIPO_JOB")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagTipoOrden)
                    .IsRequired()
                    .HasColumnName("FLAG_TIPO_ORDEN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FormasUnidad)
                    .HasColumnName("FORMAS_UNIDAD")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.GeneraDespacho)
                    .HasColumnName("GENERA_DESPACHO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IdPrelista).HasDefaultValueSql("((0))");

                entity.Property(e => e.IdRegistroPrelista).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Impuesto1)
                    .HasColumnName("IMPUESTO_1")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Impuesto2)
                    .HasColumnName("IMPUESTO_2")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ImpuestoDol)
                    .HasColumnName("IMPUESTO_DOL")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Iva)
                    .HasColumnName("IVA")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.JobId)
                    .HasColumnName("JOB_ID")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.KiloBulto)
                    .HasColumnName("KILO_BULTO")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LineaProduccio)
                    .IsRequired()
                    .HasColumnName("LINEA_PRODUCCIO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Medida)
                    .IsRequired()
                    .HasColumnName("MEDIDA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Millares)
                    .IsRequired()
                    .HasColumnName("MILLARES")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NoEntrega)
                    .HasColumnName("NO_ENTREGA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.NumCliDesde)
                    .HasColumnName("NUM_CLI_DESDE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumCliHasta)
                    .HasColumnName("NUM_CLI_HASTA")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroDesde)
                    .IsRequired()
                    .HasColumnName("NUMERO_DESDE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroHasta)
                    .IsRequired()
                    .HasColumnName("NUMERO_HASTA")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Orden)
                    .HasColumnName("ORDEN")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.OrigenProducto)
                    .IsRequired()
                    .HasColumnName("ORIGEN_PRODUCTO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Pais)
                    .IsRequired()
                    .HasColumnName("PAIS")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PrecioLista)
                    .HasColumnName("PRECIO_LISTA")
                    .HasColumnType("decimal(16, 6)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PrecioVenta)
                    .HasColumnName("PRECIO_VENTA")
                    .HasColumnType("decimal(16, 6)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Preciounidad)
                    .HasColumnName("PRECIOUNIDAD")
                    .HasColumnType("decimal(16, 6)");

                entity.Property(e => e.PrefijoCli)
                    .HasColumnName("PREFIJO_CLI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrefijoDesde)
                    .IsRequired()
                    .HasColumnName("PREFIJO_DESDE")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PrefijoHasta)
                    .IsRequired()
                    .HasColumnName("PREFIJO_HASTA")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Presentacion)
                    .IsRequired()
                    .HasColumnName("PRESENTACION")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Rimpuesto1)
                    .HasColumnName("RIMPUESTO_1")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RprecioLista)
                    .HasColumnName("RPRECIO_LISTA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RprecioVenta)
                    .HasColumnName("RPRECIO_VENTA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Rpreciounidad)
                    .HasColumnName("RPRECIOUNIDAD")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RvalorLista)
                    .HasColumnName("RVALOR_LISTA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RvalorVenta)
                    .HasColumnName("RVALOR_VENTA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SufijoCli)
                    .HasColumnName("SUFIJO_CLI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SufijoDesde)
                    .IsRequired()
                    .HasColumnName("SUFIJO_DESDE")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SufijoHasta)
                    .IsRequired()
                    .HasColumnName("SUFIJO_HASTA")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TipoCambio)
                    .HasColumnName("TIPO_CAMBIO")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.TipoDoc)
                    .HasColumnName("TIPO_DOC")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TipoProducto)
                    .IsRequired()
                    .HasColumnName("TIPO_PRODUCTO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TotalParcial)
                    .IsRequired()
                    .HasColumnName("TOTAL_PARCIAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.UnidadFact)
                    .IsRequired()
                    .HasColumnName("UNIDAD_FACT")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Unidadesent)
                    .HasColumnName("UNIDADESENT")
                    .HasColumnType("decimal(16, 3)");

                entity.Property(e => e.Usuario)
                    .HasColumnName("USUARIO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ValorLista)
                    .HasColumnName("VALOR_LISTA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorListad)
                    .HasColumnName("VALOR_LISTAD")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorVenta)
                    .HasColumnName("VALOR_VENTA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorVentad)
                    .HasColumnName("VALOR_VENTAD")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.VentaConciliado)
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Ciny216>(entity =>
            {
                entity.HasKey(e => new { e.Rif, e.Recnum })
                    .HasName("CINY216_INDEX01");

                entity.ToTable("CINY216");

                entity.HasIndex(e => e.Recnum)
                    .HasName("CINY216_INDEX00")
                    .IsUnique();

                entity.Property(e => e.Rif)
                    .HasColumnName("RIF")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Actividadecono)
                    .IsRequired()
                    .HasColumnName("ACTIVIDADECONO")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Cantidad)
                    .IsRequired()
                    .HasColumnName("CANTIDAD")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Cliente)
                    .HasColumnName("CLIENTE")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Control)
                    .IsRequired()
                    .HasColumnName("CONTROL")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasColumnName("DIRECCION")
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Fcontrol)
                    .IsRequired()
                    .HasColumnName("FCONTROL")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FechaImpresion)
                    .IsRequired()
                    .HasColumnName("FECHA_IMPRESION")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Fserie)
                    .IsRequired()
                    .HasColumnName("FSERIE")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FtipoDocumento)
                    .IsRequired()
                    .HasColumnName("FTIPO_DOCUMENTO")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Nit)
                    .IsRequired()
                    .HasColumnName("NIT")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Orden)
                    .HasColumnName("ORDEN")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RazonSocial)
                    .IsRequired()
                    .HasColumnName("RAZON_SOCIAL")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Serie)
                    .IsRequired()
                    .HasColumnName("SERIE")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasColumnName("TELEFONO")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TipoDocumento)
                    .IsRequired()
                    .HasColumnName("TIPO_DOCUMENTO")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Civy004>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CIVY004");

                entity.Property(e => e.CantidadXCaja).HasColumnName("CANTIDAD_X_CAJA");

                entity.Property(e => e.Comprometido).HasColumnName("COMPROMETIDO");

                entity.Property(e => e.CosPromActual)
                    .HasColumnName("COS_PROM_ACTUAL")
                    .HasColumnType("decimal(12, 4)");

                entity.Property(e => e.CostPromDolar)
                    .HasColumnName("COST_PROM_DOLAR")
                    .HasColumnType("decimal(12, 4)");

                entity.Property(e => e.CostoPromFin)
                    .HasColumnName("COSTO_PROM_FIN")
                    .HasColumnType("decimal(12, 4)");

                entity.Property(e => e.CostoPromIni)
                    .HasColumnName("COSTO_PROM_INI")
                    .HasColumnType("decimal(12, 4)");

                entity.Property(e => e.CostoPromReva)
                    .HasColumnName("COSTO_PROM_REVA")
                    .HasColumnType("decimal(12, 4)");

                entity.Property(e => e.CtdMaximaVta).HasColumnName("CTD_MAXIMA_VTA");

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

                entity.Property(e => e.ExiInicioMes).HasColumnName("EXI_INICIO_MES");

                entity.Property(e => e.ExisDiaAnter).HasColumnName("EXIS_DIA_ANTER");

                entity.Property(e => e.ExisFinMes).HasColumnName("EXIS_FIN_MES");

                entity.Property(e => e.ExistActual).HasColumnName("EXIST_ACTUAL");

                entity.Property(e => e.ExistMaxima).HasColumnName("EXIST_MAXIMA");

                entity.Property(e => e.ExistMinima).HasColumnName("EXIST_MINIMA");

                entity.Property(e => e.FamiliaProduct)
                    .IsRequired()
                    .HasColumnName("FAMILIA_PRODUCT")
                    .HasMaxLength(2)
                    .IsUnicode(false);

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
                    .IsUnicode(false);

                entity.Property(e => e.ImpPorConsumo)
                    .IsRequired()
                    .HasColumnName("IMP_POR_CONSUMO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.KilosPorEmpaq).HasColumnName("KILOS_POR_EMPAQ");

                entity.Property(e => e.LineaProducto)
                    .IsRequired()
                    .HasColumnName("LINEA_PRODUCTO")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ListFinMes)
                    .HasColumnName("LIST_FIN_MES")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.ListInicioMes)
                    .HasColumnName("LIST_INICIO_MES")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Medida)
                    .IsRequired()
                    .HasColumnName("MEDIDA")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MetodoPrecio)
                    .IsRequired()
                    .HasColumnName("METODO_PRECIO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.OrigenProducto)
                    .IsRequired()
                    .HasColumnName("ORIGEN_PRODUCTO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.OtroFactor).HasColumnName("OTRO_FACTOR");

                entity.Property(e => e.Partes).HasColumnName("PARTES");

                entity.Property(e => e.PorcCosto)
                    .HasColumnName("PORC_COSTO")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.PorcMarkup)
                    .HasColumnName("PORC_MARKUP")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.PreListActual)
                    .HasColumnName("PRE_LIST_ACTUAL")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PrecioSugerido)
                    .IsRequired()
                    .HasColumnName("PRECIO_SUGERIDO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Producto)
                    .IsRequired()
                    .HasColumnName("PRODUCTO")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Proveedor).HasColumnName("PROVEEDOR");

                entity.Property(e => e.PtoReorden).HasColumnName("PTO_REORDEN");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SalidaPendien).HasColumnName("SALIDA_PENDIEN");

                entity.Property(e => e.TipoPapel)
                    .IsRequired()
                    .HasColumnName("TIPO_PAPEL")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TipoProducto)
                    .IsRequired()
                    .HasColumnName("TIPO_PRODUCTO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UnidadCosteo).HasColumnName("UNIDAD_COSTEO");

                entity.Property(e => e.ValExisActual)
                    .HasColumnName("VAL_EXIS_ACTUAL")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.ValFinMes)
                    .HasColumnName("VAL_FIN_MES")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.ValInicioMes)
                    .HasColumnName("VAL_INICIO_MES")
                    .HasColumnType("decimal(12, 2)");
            });

            modelBuilder.Entity<CondicionPagoxcliente>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CONDICION_PAGOXCLIENTE");

                entity.Property(e => e.Cliente)
                    .HasColumnName("CLIENTE")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.CpMaxima)
                    .HasColumnName("CP MAXIMA")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.CpMinima)
                    .HasColumnName("CP MINIMA")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.CpPromedio)
                    .HasColumnName("CP PROMEDIO")
                    .HasColumnType("decimal(38, 6)");
            });

            modelBuilder.Entity<ConversionFactura>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CantidadFact).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CantidadNueva).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FechaFactura).HasColumnType("datetime");

                entity.Property(e => e.NombreProducto)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.PrecioVentaFact).HasColumnType("decimal(16, 6)");

                entity.Property(e => e.PrecioVentaOrd).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.Producto)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.TotalVentaFact).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.TotalVentaOrd).HasColumnType("decimal(16, 2)");
            });

            modelBuilder.Entity<CpMaxima>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CP_MAXIMA");

                entity.Property(e => e.Cliente)
                    .HasColumnName("CLIENTE")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.CpMaxima1)
                    .HasColumnName("CP MAXIMA")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<CpMinima>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CP_MINIMA");

                entity.Property(e => e.Cliente)
                    .HasColumnName("CLIENTE")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.CpMinima1)
                    .HasColumnName("CP MINIMA")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<CpPromedio>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CP_PROMEDIO");

                entity.Property(e => e.Cliente)
                    .HasColumnName("CLIENTE")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.CpPromedio1)
                    .HasColumnName("CP PROMEDIO")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Csmy0031>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CSMY0031");

                entity.HasIndex(e => e.Recnum)
                    .HasName("CSMY0031_INDEX00")
                    .IsUnique();

                entity.HasIndex(e => new { e.Cliente, e.Rif })
                    .HasName("CSMY0031_INDEX02")
                    .IsUnique();

                entity.HasIndex(e => new { e.FlagModificado, e.RifNuevo, e.Recnum })
                    .HasName("CSMY0031_INDEX03")
                    .IsUnique();

                entity.Property(e => e.Bueno)
                    .HasColumnName("BUENO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Ciudad)
                    .HasColumnName("CIUDAD")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Cliente)
                    .HasColumnName("CLIENTE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CodMcpo)
                    .HasColumnName("COD_MCPO")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CodigoEdo)
                    .HasColumnName("CODIGO_EDO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CodigoMcpo)
                    .HasColumnName("CODIGO_MCPO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Direccion1)
                    .HasColumnName("DIRECCION1")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Direccion2)
                    .HasColumnName("DIRECCION2")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Direccion3)
                    .HasColumnName("DIRECCION3")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DocPendientes)
                    .HasColumnName("DOC_PENDIENTES")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Eli)
                    .HasColumnName("ELI")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FModificado)
                    .HasColumnName("F_MODIFICADO")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCrea)
                    .HasColumnName("FECHA_CREA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaExpide)
                    .HasColumnName("FECHA_EXPIDE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaModifica)
                    .HasColumnName("FECHA_MODIFICA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlagModificado)
                    .HasColumnName("FLAG_MODIFICADO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Matriz)
                    .HasColumnName("MATRIZ")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Nit)
                    .HasColumnName("NIT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Postal)
                    .HasColumnName("POSTAL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RazonSocial)
                    .HasColumnName("RAZON_SOCIAL")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Rif)
                    .HasColumnName("RIF")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.RifNuevo)
                    .HasColumnName("RIF_NUEVO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TImpuesto)
                    .HasColumnName("T_IMPUESTO")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Facturadonodespacho>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("FACTURADONODESPACHO");

                entity.Property(e => e.Bultos).HasColumnName("BULTOS");

                entity.Property(e => e.Factura).HasColumnName("FACTURA");
            });

            modelBuilder.Entity<Facturas>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("FACTURAS");

                entity.Property(e => e.Cambio)
                    .HasColumnName("CAMBIO")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Campo).HasColumnName("CAMPO");

                entity.Property(e => e.FechaDesde)
                    .IsRequired()
                    .HasColumnName("FECHA_DESDE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechaHasta)
                    .IsRequired()
                    .HasColumnName("FECHA_HASTA")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Hora)
                    .HasColumnName("HORA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lista)
                    .HasColumnName("LISTA")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.SumaResta)
                    .IsRequired()
                    .HasColumnName("SUMA_RESTA")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TipoProducto)
                    .IsRequired()
                    .HasColumnName("TIPO_PRODUCTO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Venta)
                    .HasColumnName("VENTA")
                    .HasColumnType("decimal(38, 2)");
            });

            modelBuilder.Entity<FacturasDistribuidores>(entity =>
            {
                entity.HasKey(e => e.Factura);

                entity.Property(e => e.Factura).ValueGeneratedNever();

                entity.Property(e => e.FechaCreacion).HasColumnType("smalldatetime");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<LogCary029>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LogCARY029");

                entity.Property(e => e.Aplicacion)
                    .IsRequired()
                    .HasColumnName("APLICACION")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha)
                    .HasColumnName("FECHA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdEvento)
                    .HasColumnName("ID_EVENTO")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IvaAnterior)
                    .HasColumnName("IVA_ANTERIOR")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.IvaNuevo)
                    .HasColumnName("IVA_NUEVO")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Terminal)
                    .IsRequired()
                    .HasColumnName("TERMINAL")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasColumnName("USUARIO")
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LogSysfile>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Fecha)
                    .HasName("IX_LogSysfile");

                entity.Property(e => e.Fecha).HasColumnType("smalldatetime");

                entity.Property(e => e.NuevoControl).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.UltimoControl).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<MunicipioFlete>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Estado).HasMaxLength(2);

                entity.Property(e => e.Flete)
                    .HasColumnName("flete")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Municipio).HasMaxLength(2);
            });

            modelBuilder.Entity<Notas>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("notas");

                entity.Property(e => e.F2).HasMaxLength(255);

                entity.Property(e => e.Remision).HasColumnName("remision");
            });

            modelBuilder.Entity<Notascredito>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("NOTASCREDITO");

                entity.Property(e => e.Cambio)
                    .HasColumnName("CAMBIO")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Campo).HasColumnName("CAMPO");

                entity.Property(e => e.FechaDesde)
                    .IsRequired()
                    .HasColumnName("FECHA_DESDE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechaHasta)
                    .IsRequired()
                    .HasColumnName("FECHA_HASTA")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Hora)
                    .HasColumnName("HORA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lista)
                    .HasColumnName("LISTA")
                    .HasColumnType("decimal(38, 4)");

                entity.Property(e => e.SumaResta)
                    .IsRequired()
                    .HasColumnName("SUMA_RESTA")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TipoProducto)
                    .IsRequired()
                    .HasColumnName("TIPO_PRODUCTO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Venta)
                    .HasColumnName("VENTA")
                    .HasColumnType("decimal(38, 4)");
            });

            modelBuilder.Entity<QueryRelaclienteFact01>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QUERY_RELACLIENTE_FACT_01");

                entity.Property(e => e.AnoFactura).HasColumnName("ANO_FACTURA");

                entity.Property(e => e.Anulada)
                    .IsRequired()
                    .HasColumnName("ANULADA")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Cliente).HasColumnName("CLIENTE");

                entity.Property(e => e.ClienteNuevo).HasColumnName("CLIENTE_NUEVO");

                entity.Property(e => e.FApertura)
                    .HasColumnName("F_Apertura")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Factura).HasColumnName("FACTURA");

                entity.Property(e => e.FechaFactura)
                    .HasColumnName("FECHA_FACTURA")
                    .HasColumnType("datetime");

                entity.Property(e => e.MesFactura).HasColumnName("MES_FACTURA");
            });

            modelBuilder.Entity<Recuperados>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("recuperados");

                entity.Property(e => e.Articulo)
                    .IsRequired()
                    .HasColumnName("ARTICULO")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Bultos).HasColumnName("BULTOS");

                entity.Property(e => e.Cantidad)
                    .HasColumnName("CANTIDAD")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CentroFact).HasColumnName("CENTRO_FACT");

                entity.Property(e => e.Copy)
                    .HasColumnName("COPY")
                    .HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Descripcion1)
                    .IsRequired()
                    .HasColumnName("DESCRIPCION1")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion2)
                    .IsRequired()
                    .HasColumnName("DESCRIPCION2")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Factura).HasColumnName("FACTURA");

                entity.Property(e => e.FamiliaProducc)
                    .IsRequired()
                    .HasColumnName("FAMILIA_PRODUCC")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.FecComproClte)
                    .HasColumnName("FEC_COMPRO_CLTE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FecRecPlaneac)
                    .HasColumnName("FEC_REC_PLANEAC")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaEntrega)
                    .HasColumnName("FECHA_ENTREGA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaFactura)
                    .HasColumnName("FECHA_FACTURA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaOrden)
                    .HasColumnName("FECHA_ORDEN")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlagExistencia)
                    .IsRequired()
                    .HasColumnName("FLAG_EXISTENCIA")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FlagImprenta)
                    .IsRequired()
                    .HasColumnName("FLAG_IMPRENTA")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FlagOficina)
                    .IsRequired()
                    .HasColumnName("FLAG_OFICINA")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FlagRetenido)
                    .IsRequired()
                    .HasColumnName("FLAG_RETENIDO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FlagTipoJob)
                    .IsRequired()
                    .HasColumnName("FLAG_TIPO_JOB")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FlagTipoOrden)
                    .IsRequired()
                    .HasColumnName("FLAG_TIPO_ORDEN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FormasUnidad)
                    .HasColumnName("FORMAS_UNIDAD")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Impuesto1)
                    .HasColumnName("IMPUESTO_1")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Impuesto2)
                    .HasColumnName("IMPUESTO_2")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ImpuestoDol)
                    .HasColumnName("IMPUESTO_DOL")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Iva)
                    .HasColumnName("IVA")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.JobId).HasColumnName("JOB_ID");

                entity.Property(e => e.LineaProduccio)
                    .IsRequired()
                    .HasColumnName("LINEA_PRODUCCIO")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Medida)
                    .IsRequired()
                    .HasColumnName("MEDIDA")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Millares)
                    .IsRequired()
                    .HasColumnName("MILLARES")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.NoEntrega).HasColumnName("NO_ENTREGA");

                entity.Property(e => e.NumeroDesde).HasColumnName("NUMERO_DESDE");

                entity.Property(e => e.NumeroHasta).HasColumnName("NUMERO_HASTA");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.OrigenProducto)
                    .IsRequired()
                    .HasColumnName("ORIGEN_PRODUCTO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Pais)
                    .IsRequired()
                    .HasColumnName("PAIS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PrecioLista)
                    .HasColumnName("PRECIO_LISTA")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.PrecioVenta)
                    .HasColumnName("PRECIO_VENTA")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Preciounidad)
                    .HasColumnName("PRECIOUNIDAD")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.PrefijoDesde)
                    .IsRequired()
                    .HasColumnName("PREFIJO_DESDE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrefijoHasta)
                    .IsRequired()
                    .HasColumnName("PREFIJO_HASTA")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Presentacion)
                    .IsRequired()
                    .HasColumnName("PRESENTACION")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)");

                entity.Property(e => e.Remision).HasColumnName("REMISION");

                entity.Property(e => e.SufijoDesde)
                    .IsRequired()
                    .HasColumnName("SUFIJO_DESDE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SufijoHasta)
                    .IsRequired()
                    .HasColumnName("SUFIJO_HASTA")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCambio)
                    .HasColumnName("TIPO_CAMBIO")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.TipoDoc).HasColumnName("TIPO_DOC");

                entity.Property(e => e.TipoProducto)
                    .IsRequired()
                    .HasColumnName("TIPO_PRODUCTO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TotalParcial)
                    .IsRequired()
                    .HasColumnName("TOTAL_PARCIAL")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UnidadFact)
                    .IsRequired()
                    .HasColumnName("UNIDAD_FACT")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Unidadesent)
                    .HasColumnName("UNIDADESENT")
                    .HasColumnType("decimal(16, 3)");

                entity.Property(e => e.Usuario)
                    .HasColumnName("USUARIO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ValorLista)
                    .HasColumnName("VALOR_LISTA")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.ValorListad)
                    .HasColumnName("VALOR_LISTAD")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.ValorVenta)
                    .HasColumnName("VALOR_VENTA")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.ValorVentad)
                    .HasColumnName("VALOR_VENTAD")
                    .HasColumnType("decimal(16, 2)");
            });

            modelBuilder.Entity<Relaclientefact>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RELACLIENTEFACT");

                entity.Property(e => e.AnoFactura).HasColumnName("ANO_FACTURA");

                entity.Property(e => e.Anulada)
                    .IsRequired()
                    .HasColumnName("ANULADA")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Cliente).HasColumnName("CLIENTE");

                entity.Property(e => e.Factura).HasColumnName("FACTURA");

                entity.Property(e => e.FechaFactura)
                    .HasColumnName("FECHA_FACTURA")
                    .HasColumnType("datetime");

                entity.Property(e => e.MesFactura).HasColumnName("MES_FACTURA");
            });

            modelBuilder.Entity<Remisiones>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("remisiones");

                entity.Property(e => e.Articulo)
                    .IsRequired()
                    .HasColumnName("ARTICULO")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Bultos).HasColumnName("BULTOS");

                entity.Property(e => e.Cantidad)
                    .HasColumnName("CANTIDAD")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CentroFact).HasColumnName("CENTRO_FACT");

                entity.Property(e => e.Copy)
                    .HasColumnName("COPY")
                    .HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Descripcion1)
                    .IsRequired()
                    .HasColumnName("DESCRIPCION1")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion2)
                    .IsRequired()
                    .HasColumnName("DESCRIPCION2")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Factura).HasColumnName("FACTURA");

                entity.Property(e => e.FamiliaProducc)
                    .IsRequired()
                    .HasColumnName("FAMILIA_PRODUCC")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.FecComproClte)
                    .HasColumnName("FEC_COMPRO_CLTE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FecRecPlaneac)
                    .HasColumnName("FEC_REC_PLANEAC")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaEntrega)
                    .HasColumnName("FECHA_ENTREGA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaFactura)
                    .HasColumnName("FECHA_FACTURA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaOrden)
                    .HasColumnName("FECHA_ORDEN")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlagExistencia)
                    .IsRequired()
                    .HasColumnName("FLAG_EXISTENCIA")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FlagImprenta)
                    .IsRequired()
                    .HasColumnName("FLAG_IMPRENTA")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FlagOficina)
                    .IsRequired()
                    .HasColumnName("FLAG_OFICINA")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FlagRetenido)
                    .IsRequired()
                    .HasColumnName("FLAG_RETENIDO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FlagTipoJob)
                    .IsRequired()
                    .HasColumnName("FLAG_TIPO_JOB")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FlagTipoOrden)
                    .IsRequired()
                    .HasColumnName("FLAG_TIPO_ORDEN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FormasUnidad)
                    .HasColumnName("FORMAS_UNIDAD")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Impuesto1)
                    .HasColumnName("IMPUESTO_1")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Impuesto2)
                    .HasColumnName("IMPUESTO_2")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ImpuestoDol)
                    .HasColumnName("IMPUESTO_DOL")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Iva)
                    .HasColumnName("IVA")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.JobId).HasColumnName("JOB_ID");

                entity.Property(e => e.LineaProduccio)
                    .IsRequired()
                    .HasColumnName("LINEA_PRODUCCIO")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Medida)
                    .IsRequired()
                    .HasColumnName("MEDIDA")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Millares)
                    .IsRequired()
                    .HasColumnName("MILLARES")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.NoEntrega).HasColumnName("NO_ENTREGA");

                entity.Property(e => e.NumeroDesde).HasColumnName("NUMERO_DESDE");

                entity.Property(e => e.NumeroHasta).HasColumnName("NUMERO_HASTA");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.OrigenProducto)
                    .IsRequired()
                    .HasColumnName("ORIGEN_PRODUCTO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Pais)
                    .IsRequired()
                    .HasColumnName("PAIS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PrecioLista)
                    .HasColumnName("PRECIO_LISTA")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.PrecioVenta)
                    .HasColumnName("PRECIO_VENTA")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Preciounidad)
                    .HasColumnName("PRECIOUNIDAD")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.PrefijoDesde)
                    .IsRequired()
                    .HasColumnName("PREFIJO_DESDE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrefijoHasta)
                    .IsRequired()
                    .HasColumnName("PREFIJO_HASTA")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Presentacion)
                    .IsRequired()
                    .HasColumnName("PRESENTACION")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)");

                entity.Property(e => e.Remision).HasColumnName("REMISION");

                entity.Property(e => e.SufijoDesde)
                    .IsRequired()
                    .HasColumnName("SUFIJO_DESDE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SufijoHasta)
                    .IsRequired()
                    .HasColumnName("SUFIJO_HASTA")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCambio)
                    .HasColumnName("TIPO_CAMBIO")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.TipoDoc).HasColumnName("TIPO_DOC");

                entity.Property(e => e.TipoProducto)
                    .IsRequired()
                    .HasColumnName("TIPO_PRODUCTO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TotalParcial)
                    .IsRequired()
                    .HasColumnName("TOTAL_PARCIAL")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UnidadFact)
                    .IsRequired()
                    .HasColumnName("UNIDAD_FACT")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Unidadesent)
                    .HasColumnName("UNIDADESENT")
                    .HasColumnType("decimal(16, 3)");

                entity.Property(e => e.Usuario)
                    .HasColumnName("USUARIO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ValorLista)
                    .HasColumnName("VALOR_LISTA")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.ValorListad)
                    .HasColumnName("VALOR_LISTAD")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.ValorVenta)
                    .HasColumnName("VALOR_VENTA")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.ValorVentad)
                    .HasColumnName("VALOR_VENTAD")
                    .HasColumnType("decimal(16, 2)");
            });

            modelBuilder.Entity<RepCobranzasLcCp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("REP_COBRANZAS_LC_CP");

                entity.Property(e => e.Codigo)
                    .HasColumnName("CODIGO")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CpMaxima)
                    .HasColumnName("CP MAXIMA")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.CpMinima)
                    .HasColumnName("CP MINIMA")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.CpPromedio)
                    .HasColumnName("CP PROMEDIO")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.DescripcionCpMax)
                    .HasColumnName("DESCRIPCION CP MAX")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DescripcionCpMin)
                    .HasColumnName("DESCRIPCION CP MIN")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DescripcionCpProm)
                    .HasColumnName("DESCRIPCION CP PROM")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Inactivo)
                    .HasColumnName("INACTIVO")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LcMaximoBs)
                    .HasColumnName("LC MAXIMO BS")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.LcMaximoUt)
                    .HasColumnName("LC MAXIMO UT")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.LcMinimoBs)
                    .HasColumnName("LC MINIMO BS")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.LcMinimoUt)
                    .HasColumnName("LC MINIMO UT")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.LcPromedioBs)
                    .HasColumnName("LC PROMEDIO BS")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.LcPromedioUt)
                    .HasColumnName("LC PROMEDIO UT")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Nombre)
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NombreTipo)
                    .HasColumnName("NOMBRE_TIPO")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NombreZc)
                    .HasColumnName("NOMBRE ZC")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoNegocio)
                    .HasColumnName("TIPO NEGOCIO")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UnidaTributariaBs)
                    .HasColumnName("UNIDA TRIBUTARIA BS")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ZonaCobranza)
                    .HasColumnName("ZONA COBRANZA")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Sheet1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sheet1$");

                entity.Property(e => e.Metodo)
                    .HasColumnName("METODO")
                    .HasMaxLength(255);

                entity.Property(e => e.Metodob)
                    .HasColumnName("METODOB")
                    .HasMaxLength(255);

                entity.Property(e => e.Nc)
                    .HasColumnName("NC")
                    .HasMaxLength(255);

                entity.Property(e => e.Tipopapel)
                    .HasColumnName("TIPOPAPEL")
                    .HasMaxLength(255);

                entity.Property(e => e.Tipopapelb)
                    .HasColumnName("TIPOPAPELB")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Sysfile>(entity =>
            {
                entity.HasKey(e => e.CompanyName)
                    .HasName("SYSFILE_INDEX01");

                entity.ToTable("SYSFILE");

                entity.HasIndex(e => e.Recnum)
                    .HasName("SYSFILE_INDEX00")
                    .IsUnique();

                entity.Property(e => e.CompanyName)
                    .HasColumnName("COMPANY_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ActMiscelaneo)
                    .HasColumnName("ACT_MISCELANEO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Batch)
                    .HasColumnName("BATCH")
                    .HasColumnType("decimal(14, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CifrasEti)
                    .IsRequired()
                    .HasColumnName("CIFRAS_ETI")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CifrasGen)
                    .IsRequired()
                    .HasColumnName("CIFRAS_GEN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ComprobanteFac).HasColumnName("COMPROBANTE_FAC");

                entity.Property(e => e.CtaImpSVenta)
                    .HasColumnName("CTA_IMP_S_VENTA")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Desde)
                    .HasColumnName("DESDE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCompFac)
                    .HasColumnName("FECHA_COMP_FAC")
                    .HasColumnType("datetime");

                entity.Property(e => e.Hasta)
                    .HasColumnName("HASTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.LargoPagina).HasColumnName("LARGO_PAGINA");

                entity.Property(e => e.NroControl)
                    .HasColumnName("NRO_CONTROL")
                    .HasColumnType("decimal(14, 0)");

                entity.Property(e => e.OficinaDefecto).HasColumnName("OFICINA_DEFECTO");

                entity.Property(e => e.Pais).HasColumnName("PAIS");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SaltoPagina).HasColumnName("SALTO_PAGINA");
            });

            modelBuilder.Entity<Tipos>(entity =>
            {
                entity.HasKey(e => e.Tipo)
                    .HasName("TIPOS_INDEX01");

                entity.ToTable("TIPOS");

                entity.HasIndex(e => e.Recnum)
                    .HasName("TIPOS_INDEX00")
                    .IsUnique();

                entity.Property(e => e.Tipo)
                    .HasColumnName("TIPO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VCiny056>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ciny056");

                entity.Property(e => e.CondicionPago)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Factura).HasColumnName("FACTURA");

                entity.Property(e => e.FechaFactura)
                    .HasColumnName("FECHA_FACTURA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Miscelaneo)
                    .IsRequired()
                    .HasColumnName("MISCELANEO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.OtroGasto1)
                    .HasColumnName("OTRO_GASTO_1")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Remision)
                    .HasColumnName("remision")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.ValorLista)
                    .HasColumnName("VALOR_LISTA")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.ValorVenta)
                    .HasColumnName("VALOR_VENTA")
                    .HasColumnType("decimal(16, 2)");
            });

            modelBuilder.Entity<VCuadreFa>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_CUADRE_FA");

                entity.Property(e => e.Articulo)
                    .IsRequired()
                    .HasColumnName("ARTICULO")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CtaConc)
                    .IsRequired()
                    .HasColumnName("CTA_CONC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CtaLista)
                    .IsRequired()
                    .HasColumnName("CTA_LISTA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Factura).HasColumnName("FACTURA");

                entity.Property(e => e.FechaFactura)
                    .HasColumnName("FECHA_FACTURA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Linea1)
                    .IsRequired()
                    .HasColumnName("LINEA1")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.MetodoPrecio1)
                    .IsRequired()
                    .HasColumnName("METODO_PRECIO1")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Partes)
                    .IsRequired()
                    .HasColumnName("PARTES")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TipoPapel)
                    .IsRequired()
                    .HasColumnName("TIPO_PAPEL")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ValorLista)
                    .HasColumnName("VALOR_LISTA")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.ValorVenta)
                    .HasColumnName("VALOR_VENTA")
                    .HasColumnType("decimal(16, 2)");
            });

            modelBuilder.Entity<VCuadreNc>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_CUADRE_NC");

                entity.Property(e => e.CtaConc)
                    .IsRequired()
                    .HasColumnName("CTA_CONC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CtaLista)
                    .IsRequired()
                    .HasColumnName("CTA_LISTA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FechaNota)
                    .HasColumnName("FECHA_NOTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Linea1)
                    .IsRequired()
                    .HasColumnName("LINEA1")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.MetodoPrecio1)
                    .IsRequired()
                    .HasColumnName("METODO_PRECIO1")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroNota).HasColumnName("NUMERO_NOTA");

                entity.Property(e => e.Partes)
                    .IsRequired()
                    .HasColumnName("PARTES")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TipoPapel)
                    .IsRequired()
                    .HasColumnName("TIPO_PAPEL")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ValorLista)
                    .HasColumnName("VALOR_LISTA")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ValorVenta)
                    .HasColumnName("VALOR_VENTA")
                    .HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<VDiccionariofacturacion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_DICCIONARIOFACTURACION");

                entity.Property(e => e.Basededatos)
                    .IsRequired()
                    .HasColumnName("basededatos")
                    .HasMaxLength(11)
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

            modelBuilder.Entity<VFacturasFiscalesConImagen>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_FacturasFiscalesConImagen");

                entity.Property(e => e.Blob)
                    .HasColumnName("BLOB")
                    .HasColumnType("image");

                entity.Property(e => e.Cliente).HasColumnName("CLIENTE");

                entity.Property(e => e.Factura).HasColumnName("FACTURA");

                entity.Property(e => e.FechaFactura)
                    .HasColumnName("FECHA_FACTURA")
                    .HasColumnType("datetime");

                entity.Property(e => e.NombreEmb)
                    .HasColumnName("NOMBRE_EMB")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.NombreOficina)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Oficina)
                    .HasColumnName("oficina")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.RifFact)
                    .HasColumnName("RIF_FACT")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.RifImagen)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Vendedor)
                    .HasColumnName("vendedor")
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VFaltantes>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_faltantes");

                entity.Property(e => e.Cant).HasColumnName("cant");

                entity.Property(e => e.DireccionFact1)
                    .IsRequired()
                    .HasColumnName("DIRECCION_FACT1")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.DireccionFact2)
                    .IsRequired()
                    .HasColumnName("DIRECCION_FACT2")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.DireccionFact3)
                    .IsRequired()
                    .HasColumnName("DIRECCION_FACT3")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Factura).HasColumnName("FACTURA");

                entity.Property(e => e.FechaFactura)
                    .HasColumnName("FECHA_FACTURA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Firma)
                    .IsRequired()
                    .HasColumnName("firma")
                    .HasMaxLength(23)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NombreFact)
                    .IsRequired()
                    .HasColumnName("NOMBRE_FACT")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.NroCaja).HasColumnName("NRO_CAJA");

                entity.Property(e => e.NumeroDesde).HasColumnName("NUMERO_DESDE");

                entity.Property(e => e.NumeroHasta).HasColumnName("NUMERO_HASTA");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.PrefDesde)
                    .IsRequired()
                    .HasColumnName("PREF_DESDE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrefHasta)
                    .IsRequired()
                    .HasColumnName("PREF_HASTA")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SufDesde)
                    .IsRequired()
                    .HasColumnName("SUF_DESDE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SufHasta)
                    .IsRequired()
                    .HasColumnName("SUF_HASTA")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VInvetarioReconversion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_InvetarioReconversion");

                entity.Property(e => e.Basededatos)
                    .IsRequired()
                    .HasColumnName("basededatos")
                    .HasMaxLength(11)
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

            modelBuilder.Entity<VNotas>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_notas");

                entity.Property(e => e.Cantidad)
                    .HasColumnName("CANTIDAD")
                    .HasColumnType("decimal(12, 4)");

                entity.Property(e => e.CodProducto)
                    .IsRequired()
                    .HasColumnName("COD_PRODUCTO")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Comision)
                    .HasColumnName("COMISION")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.CtaConc)
                    .IsRequired()
                    .HasColumnName("CTA_CONC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CtaLista)
                    .IsRequired()
                    .HasColumnName("CTA_LISTA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Estadisticas)
                    .IsRequired()
                    .HasColumnName("ESTADISTICAS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Familia)
                    .IsRequired()
                    .HasColumnName("FAMILIA")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.FamiliaProducc)
                    .IsRequired()
                    .HasColumnName("FAMILIA_PRODUCC")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.FechaNota)
                    .HasColumnName("FECHA_NOTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaOrden)
                    .HasColumnName("FECHA_ORDEN")
                    .HasColumnType("datetime");

                entity.Property(e => e.ImpPorConsumo)
                    .HasColumnName("IMP_POR_CONSUMO")
                    .HasColumnType("decimal(12, 4)");

                entity.Property(e => e.ImpSobVentas)
                    .HasColumnName("IMP_SOB_VENTAS")
                    .HasColumnType("decimal(12, 4)");

                entity.Property(e => e.ImpuestoDol)
                    .HasColumnName("IMPUESTO_DOL")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Linea1)
                    .IsRequired()
                    .HasColumnName("LINEA1")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.LineaIncoming).HasColumnName("LINEA_INCOMING");

                entity.Property(e => e.LineaProduccio)
                    .IsRequired()
                    .HasColumnName("LINEA_PRODUCCIO")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ListaUniDol)
                    .HasColumnName("LISTA_UNI_DOL")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.MetodoPrecio1)
                    .IsRequired()
                    .HasColumnName("METODO_PRECIO1")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroNota).HasColumnName("NUMERO_NOTA");

                entity.Property(e => e.Orden).HasColumnName("orden");

                entity.Property(e => e.Partes)
                    .IsRequired()
                    .HasColumnName("PARTES")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PrecioVenta)
                    .HasColumnName("PRECIO_VENTA")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)");

                entity.Property(e => e.TipoDoc).HasColumnName("TIPO_DOC");

                entity.Property(e => e.TipoPapel)
                    .IsRequired()
                    .HasColumnName("TIPO_PAPEL")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TipoProducto)
                    .IsRequired()
                    .HasColumnName("TIPO_PRODUCTO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Valor)
                    .HasColumnName("VALOR_$")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ValorLista)
                    .HasColumnName("VALOR_LISTA")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ValorListad)
                    .HasColumnName("VALOR_LISTAD")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.ValorVenta)
                    .HasColumnName("VALOR_VENTA")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ValorVentad)
                    .HasColumnName("VALOR_VENTAD")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.VentaUniDol)
                    .HasColumnName("VENTA_UNI_DOL")
                    .HasColumnType("decimal(16, 2)");
            });

            modelBuilder.Entity<VNotasdeCreditoaRefacturar>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_NotasdeCreditoaRefacturar");

                entity.Property(e => e.AfectaFactura)
                    .IsRequired()
                    .HasColumnName("AFECTA_FACTURA")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CodProducto)
                    .IsRequired()
                    .HasColumnName("COD_PRODUCTO")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Factura).HasColumnName("FACTURA");

                entity.Property(e => e.FacturaRepetir).HasColumnName("FACTURA_REPETIR");

                entity.Property(e => e.Fecha)
                    .HasColumnName("FECHA")
                    .HasColumnType("datetime");

                entity.Property(e => e.NombreCliente)
                    .IsRequired()
                    .HasColumnName("NOMBRE_CLIENTE")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.NotaCredito).HasColumnName("NOTA_CREDITO");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.Valor)
                    .HasColumnName("VALOR")
                    .HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<VProductosNoInventariados>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_ProductosNoInventariados");

                entity.Property(e => e.Articulo)
                    .IsRequired()
                    .HasColumnName("ARTICULO")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Cantidad)
                    .HasColumnName("CANTIDAD")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Comprobante2).HasColumnName("comprobante2");

                entity.Property(e => e.Factura).HasColumnName("FACTURA");

                entity.Property(e => e.FechaFactura)
                    .HasColumnName("FECHA_FACTURA")
                    .HasColumnType("datetime");

                entity.Property(e => e.GeneraDespacho)
                    .HasColumnName("GENERA_DESPACHO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ManejaInv)
                    .HasColumnName("MANEJA_INV")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Remision).HasColumnName("remision");
            });

            modelBuilder.Entity<View1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW1");

                entity.Property(e => e.Codigo)
                    .HasColumnName("CODIGO")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CpMaxima)
                    .HasColumnName("CP MAXIMA")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.CpMinima)
                    .HasColumnName("CP MINIMA")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.CpPromedio)
                    .HasColumnName("CP PROMEDIO")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.DescripcionCpMax)
                    .HasColumnName("DESCRIPCION CP MAX")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DescripcionCpMin)
                    .HasColumnName("DESCRIPCION CP MIN")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DescripcionCpProm)
                    .HasColumnName("DESCRIPCION CP PROM")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Inactivo)
                    .HasColumnName("INACTIVO")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LcMaximoBs)
                    .HasColumnName("LC MAXIMO BS")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.LcMaximoUt)
                    .HasColumnName("LC MAXIMO UT")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.LcMinimoBs)
                    .HasColumnName("LC MINIMO BS")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.LcMinimoUt)
                    .HasColumnName("LC MINIMO UT")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.LcPromedioBs)
                    .HasColumnName("LC PROMEDIO BS")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.LcPromedioUt)
                    .HasColumnName("LC PROMEDIO UT")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Nombre)
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NombreTipo)
                    .HasColumnName("NOMBRE_TIPO")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NombreZc)
                    .HasColumnName("NOMBRE ZC")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoNegocio)
                    .HasColumnName("TIPO NEGOCIO")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UnidaTributariaBs)
                    .HasColumnName("UNIDA TRIBUTARIA BS")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ZonaCobranza)
                    .HasColumnName("ZONA COBRANZA")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Winy025>(entity =>
            {
                entity.HasKey(e => new { e.Mes, e.TipoProducto })
                    .HasName("WINY025_INDEX01");

                entity.ToTable("WINY025");

                entity.HasIndex(e => e.Recnum)
                    .HasName("WINY025_INDEX00")
                    .IsUnique();

                entity.Property(e => e.Mes)
                    .HasColumnName("MES")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TipoProducto)
                    .HasColumnName("TIPO_PRODUCTO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Anuladas)
                    .HasColumnName("ANULADAS")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.MesNumero)
                    .HasColumnName("MES_NUMERO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Nc)
                    .HasColumnName("NC")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Normales)
                    .HasColumnName("NORMALES")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Winy026>(entity =>
            {
                entity.HasKey(e => e.Orden)
                    .HasName("WINY026_INDEX01");

                entity.ToTable("WINY026");

                entity.HasIndex(e => e.Recnum)
                    .HasName("WINY026_INDEX00")
                    .IsUnique();

                entity.Property(e => e.Orden)
                    .HasColumnName("ORDEN")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PorcMo)
                    .HasColumnName("PORC_MO")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PorcMp)
                    .HasColumnName("PORC_MP")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Winy032>(entity =>
            {
                entity.HasKey(e => e.Rif)
                    .HasName("WINY032_INDEX01");

                entity.ToTable("WINY032");

                entity.HasIndex(e => e.Recnum)
                    .HasName("WINY032_INDEX00")
                    .IsUnique();

                entity.Property(e => e.Rif)
                    .HasColumnName("RIF")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Cliente)
                    .HasColumnName("CLIENTE")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("ESTADO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Municipio)
                    .IsRequired()
                    .HasColumnName("MUNICIPIO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Winy242>(entity =>
            {
                entity.HasKey(e => e.CodigoEstado)
                    .HasName("WINY242_INDEX01");

                entity.ToTable("WINY242");

                entity.HasIndex(e => e.Recnum)
                    .HasName("WINY242_INDEX00")
                    .IsUnique();

                entity.HasIndex(e => new { e.NombreEstado, e.Recnum })
                    .HasName("WINY242_INDEX02")
                    .IsUnique();

                entity.Property(e => e.CodigoEstado)
                    .HasColumnName("CODIGO_ESTADO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CapitalEstado)
                    .IsRequired()
                    .HasColumnName("CAPITAL_ESTADO")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CodigoJde)
                    .HasColumnName("CODIGO_JDE")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoSap)
                    .HasColumnName("CODIGO_SAP")
                    .HasMaxLength(3)
                    .IsUnicode(false);

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

            modelBuilder.Entity<Winy243>(entity =>
            {
                entity.HasKey(e => new { e.CodigoEstado, e.CodigoMcpo })
                    .HasName("WINY243_INDEX01");

                entity.ToTable("WINY243");

                entity.HasIndex(e => e.Recnum)
                    .HasName("WINY243_INDEX00")
                    .IsUnique();

                entity.HasIndex(e => new { e.DescMunicipio, e.Recnum })
                    .HasName("WINY243_INDEX02")
                    .IsUnique();

                entity.HasIndex(e => new { e.ZonaDespacho, e.PosicionRuta, e.Recnum })
                    .HasName("WINY243_INDEX03")
                    .IsUnique();

                entity.Property(e => e.CodigoEstado)
                    .HasColumnName("CODIGO_ESTADO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CodigoMcpo)
                    .HasColumnName("CODIGO_MCPO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CapitalMcpo)
                    .IsRequired()
                    .HasColumnName("CAPITAL_MCPO")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CodigoJde)
                    .HasColumnName("CODIGO_JDE")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DescMunicipio)
                    .IsRequired()
                    .HasColumnName("DESC_MUNICIPIO")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.EdoMcpo)
                    .IsRequired()
                    .HasColumnName("EDO_MCPO")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Kilometros)
                    .HasColumnName("KILOMETROS")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.NombreEstado)
                    .IsRequired()
                    .HasColumnName("NOMBRE_ESTADO")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PorcFlete).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PosicionRuta)
                    .HasColumnName("POSICION_RUTA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ZonaDespacho)
                    .HasColumnName("ZONA_DESPACHO")
                    .HasDefaultValueSql("(0)");

                entity.HasOne(d => d.CodigoEstadoNavigation)
                    .WithMany(p => p.Winy243)
                    .HasForeignKey(d => d.CodigoEstado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WINY243_WINY242");
            });

            modelBuilder.Entity<Winy244>(entity =>
            {
                entity.HasKey(e => new { e.Linea, e.TipoProducto, e.TipoNegocio, e.Partes })
                    .HasName("WINY244_INDEX01");

                entity.ToTable("WINY244");

                entity.HasIndex(e => e.Recnum)
                    .HasName("WINY244_INDEX00")
                    .IsUnique();

                entity.Property(e => e.Linea)
                    .HasColumnName("LINEA")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TipoProducto)
                    .HasColumnName("TIPO_PRODUCTO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TipoNegocio)
                    .HasColumnName("TIPO_NEGOCIO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Partes)
                    .HasColumnName("PARTES")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CtaConc)
                    .IsRequired()
                    .HasColumnName("CTA_CONC")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CtaLista)
                    .IsRequired()
                    .HasColumnName("CTA_LISTA")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Winy245>(entity =>
            {
                entity.HasKey(e => new { e.IdEstado, e.IdMunicipio, e.IdParroquia });

                entity.ToTable("WINY245");

                entity.Property(e => e.IdEstado)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.IdMunicipio)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NombreParroquia)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.Winy245)
                    .HasForeignKey(d => new { d.IdEstado, d.IdMunicipio })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WINY245_WINY243");
            });

            modelBuilder.Entity<Wsmy0032>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WSMY0032");

                entity.HasIndex(e => e.Recnum)
                    .HasName("WSMY0032_INDEX00")
                    .IsUnique();

                entity.Property(e => e.CapitalEstado)
                    .IsRequired()
                    .HasColumnName("CAPITAL_ESTADO")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CodigoEstado)
                    .IsRequired()
                    .HasColumnName("CODIGO_ESTADO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CodigoMcpo)
                    .IsRequired()
                    .HasColumnName("CODIGO_MCPO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DescMunicipio)
                    .IsRequired()
                    .HasColumnName("DESC_MUNICIPIO")
                    .HasMaxLength(30)
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

                entity.Property(e => e.Direccion3)
                    .IsRequired()
                    .HasColumnName("DIRECCION3")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NombreEstado)
                    .IsRequired()
                    .HasColumnName("NOMBRE_ESTADO")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.RazonSocial)
                    .IsRequired()
                    .HasColumnName("RAZON_SOCIAL")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Rif)
                    .IsRequired()
                    .HasColumnName("RIF")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
