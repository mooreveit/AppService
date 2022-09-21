using System;
using AppService.Core.EntitiesDw;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AppService.Infrastructure.DataDW
{
    public partial class DWContext : DbContext
    {
        public DWContext()
        {
        }

        public DWContext(DbContextOptions<DWContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CobradoXml> CobradoXml { get; set; }
        public virtual DbSet<ComparativoProvision> ComparativoProvision { get; set; }
        public virtual DbSet<DestinoDeSqlServer> DestinoDeSqlServer { get; set; }
        public virtual DbSet<DiasProvision> DiasProvision { get; set; }
        public virtual DbSet<DwBalanceContable> DwBalanceContable { get; set; }
        public virtual DbSet<DwConsolidadoAnalisisDeVencimiento> DwConsolidadoAnalisisDeVencimiento { get; set; }
        public virtual DbSet<DwConsolidadoDePago> DwConsolidadoDePago { get; set; }
        public virtual DbSet<DwConsolidadoDePagoTempCxP> DwConsolidadoDePagoTempCxP { get; set; }
        public virtual DbSet<DwConsolidadoDePagoTempNomina> DwConsolidadoDePagoTempNomina { get; set; }
        public virtual DbSet<DwConsumoInvOld> DwConsumoInvOld { get; set; }
        public virtual DbSet<DwConsumoInventario> DwConsumoInventario { get; set; }
        public virtual DbSet<DwConsumoInventarioHistorico> DwConsumoInventarioHistorico { get; set; }
        public virtual DbSet<DwConsumoInventarioHistoricoBk> DwConsumoInventarioHistoricoBk { get; set; }
        public virtual DbSet<DwContabilidad> DwContabilidad { get; set; }
        public virtual DbSet<DwControlPronostico> DwControlPronostico { get; set; }
        public virtual DbSet<DwDashboardVendedor> DwDashboardVendedor { get; set; }
        public virtual DbSet<DwHistorialDespacho> DwHistorialDespacho { get; set; }
        public virtual DbSet<DwInventarioValorado> DwInventarioValorado { get; set; }
        public virtual DbSet<DwPronosticoDiarioCia> DwPronosticoDiarioCia { get; set; }
        public virtual DbSet<DwPronosticoDiarioCiaTemp> DwPronosticoDiarioCiaTemp { get; set; }
        public virtual DbSet<DwPronosticoDiarioOficina> DwPronosticoDiarioOficina { get; set; }
        public virtual DbSet<DwPronosticoDiarioOficinaTemp> DwPronosticoDiarioOficinaTemp { get; set; }
        public virtual DbSet<DwProvisionCliente> DwProvisionCliente { get; set; }
        public virtual DbSet<DwTiposDeTransaccion> DwTiposDeTransaccion { get; set; }
        public virtual DbSet<DwcategoriaCuenta> DwcategoriaCuenta { get; set; }
        public virtual DbSet<ProveedoresDireccionResidencia> ProveedoresDireccionResidencia { get; set; }
        public virtual DbSet<VDetallePronostico> VDetallePronostico { get; set; }
        public virtual DbSet<VProvision> VProvision { get; set; }
        public virtual DbSet<VResumenPronostico> VResumenPronostico { get; set; }
        public virtual DbSet<VTopProvisionCliente> VTopProvisionCliente { get; set; }
        public virtual DbSet<XmlCobrado> XmlCobrado { get; set; }

       /* protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=172.28.107.19\\FSVEMCYN03D;Database=DW;User Id=userweb;Password=userweb2003;MultipleActiveResultSets=true");
            }
        }*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CobradoXml>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Cobrado).HasColumnType("xml");
            });

            modelBuilder.Entity<ComparativoProvision>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => new { e.Año, e.Mes })
                    .HasName("IX_ComparativoProvision_1");

                entity.HasIndex(e => new { e.Año, e.Mes, e.Vendedor })
                    .HasName("IX_ComparativoProvision");

                entity.Property(e => e.Diferencia)
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NombreAn8).HasMaxLength(80);

                entity.Property(e => e.NombreOficina).HasMaxLength(50);

                entity.Property(e => e.NombreVendedor).HasMaxLength(50);

                entity.Property(e => e.ProvisionActual)
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProvisionNueva)
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rdiferencia)
                    .HasColumnName("RDiferencia")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RprovisionActual)
                    .HasColumnName("RProvisionActual")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RprovisionNueva)
                    .HasColumnName("RProvisionNueva")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RsaldoProvisionActual)
                    .HasColumnName("RSaldoProvisionActual")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RsaldoProvisionNueva)
                    .HasColumnName("RSaldoProvisionNueva")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SaldoProvisionActual)
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SaldoProvisionNueva)
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Titulo).HasMaxLength(50);

                entity.Property(e => e.Vendedor).HasMaxLength(4);
            });

            modelBuilder.Entity<DestinoDeSqlServer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Destino de SQL Server");

                entity.Property(e => e.Rpaap).HasColumnName("RPAAP");

                entity.Property(e => e.Rpacr).HasColumnName("RPACR");

                entity.Property(e => e.Rpadsa).HasColumnName("RPADSA");

                entity.Property(e => e.Rpadsc).HasColumnName("RPADSC");

                entity.Property(e => e.Rpafc)
                    .HasColumnName("RPAFC")
                    .HasMaxLength(1);

                entity.Property(e => e.Rpag).HasColumnName("RPAG");

                entity.Property(e => e.Rpaid)
                    .HasColumnName("RPAID")
                    .HasMaxLength(8);

                entity.Property(e => e.Rpaid2)
                    .HasColumnName("RPAID2")
                    .HasMaxLength(8);

                entity.Property(e => e.Rpajcl)
                    .HasColumnName("RPAJCL")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Rpalph)
                    .HasColumnName("RPALPH")
                    .HasMaxLength(40);

                entity.Property(e => e.Rpalt6)
                    .HasColumnName("RPALT6")
                    .HasMaxLength(1);

                entity.Property(e => e.Rpam)
                    .HasColumnName("RPAM")
                    .HasMaxLength(1);

                entity.Property(e => e.Rpam2)
                    .HasColumnName("RPAM2")
                    .HasMaxLength(1);

                entity.Property(e => e.Rpan8).HasColumnName("RPAN8");

                entity.Property(e => e.Rpan8j).HasColumnName("RPAN8J");

                entity.Property(e => e.Rpar01)
                    .HasColumnName("RPAR01")
                    .HasMaxLength(3);

                entity.Property(e => e.Rpar02)
                    .HasColumnName("RPAR02")
                    .HasMaxLength(3);

                entity.Property(e => e.Rpar03)
                    .HasColumnName("RPAR03")
                    .HasMaxLength(3);

                entity.Property(e => e.Rpar04)
                    .HasColumnName("RPAR04")
                    .HasMaxLength(3);

                entity.Property(e => e.Rpar05)
                    .HasColumnName("RPAR05")
                    .HasMaxLength(3);

                entity.Property(e => e.Rpar06)
                    .HasColumnName("RPAR06")
                    .HasMaxLength(3);

                entity.Property(e => e.Rpar07)
                    .HasColumnName("RPAR07")
                    .HasMaxLength(3);

                entity.Property(e => e.Rpar08)
                    .HasColumnName("RPAR08")
                    .HasMaxLength(3);

                entity.Property(e => e.Rpar09)
                    .HasColumnName("RPAR09")
                    .HasMaxLength(3);

                entity.Property(e => e.Rpar10)
                    .HasColumnName("RPAR10")
                    .HasMaxLength(3);

                entity.Property(e => e.Rpatad).HasColumnName("RPATAD");

                entity.Property(e => e.Rpatxa).HasColumnName("RPATXA");

                entity.Property(e => e.Rpatxn).HasColumnName("RPATXN");

                entity.Property(e => e.Rpbalj)
                    .HasColumnName("RPBALJ")
                    .HasMaxLength(1);

                entity.Property(e => e.Rpbcrc)
                    .HasColumnName("RPBCRC")
                    .HasMaxLength(3);

                entity.Property(e => e.Rpcds).HasColumnName("RPCDS");

                entity.Property(e => e.Rpcdsa).HasColumnName("RPCDSA");

                entity.Property(e => e.Rpclmg)
                    .HasColumnName("RPCLMG")
                    .HasMaxLength(10);

                entity.Property(e => e.Rpcmc1).HasColumnName("RPCMC1");

                entity.Property(e => e.Rpcmgr)
                    .HasColumnName("RPCMGR")
                    .HasMaxLength(10);

                entity.Property(e => e.Rpco)
                    .HasColumnName("RPCO")
                    .HasMaxLength(5);

                entity.Property(e => e.Rpcoll)
                    .HasColumnName("RPCOLL")
                    .HasMaxLength(1);

                entity.Property(e => e.Rpcorc)
                    .HasColumnName("RPCORC")
                    .HasMaxLength(2);

                entity.Property(e => e.Rpcrcd)
                    .HasColumnName("RPCRCD")
                    .HasMaxLength(3);

                entity.Property(e => e.Rpcrr).HasColumnName("RPCRR");

                entity.Property(e => e.Rpcrrm)
                    .HasColumnName("RPCRRM")
                    .HasMaxLength(1);

                entity.Property(e => e.Rpctad).HasColumnName("RPCTAD");

                entity.Property(e => e.Rpctam).HasColumnName("RPCTAM");

                entity.Property(e => e.Rpctl)
                    .HasColumnName("RPCTL")
                    .HasMaxLength(13);

                entity.Property(e => e.Rpctry).HasColumnName("RPCTRY");

                entity.Property(e => e.Rpctxa).HasColumnName("RPCTXA");

                entity.Property(e => e.Rpctxn).HasColumnName("RPCTXN");

                entity.Property(e => e.Rpdct)
                    .HasColumnName("RPDCT")
                    .HasMaxLength(2);

                entity.Property(e => e.Rpdcto)
                    .HasColumnName("RPDCTO")
                    .HasMaxLength(2);

                entity.Property(e => e.Rpddex)
                    .HasColumnName("RPDDEX")
                    .HasMaxLength(2);

                entity.Property(e => e.Rpddj)
                    .HasColumnName("RPDDJ")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Rpddnj)
                    .HasColumnName("RPDDNJ")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Rpdgj)
                    .HasColumnName("RPDGJ")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Rpdicj)
                    .HasColumnName("RPDICJ")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Rpdivj)
                    .HasColumnName("RPDIVJ")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Rpdmcd)
                    .HasColumnName("RPDMCD")
                    .HasMaxLength(1);

                entity.Property(e => e.Rpdnlt)
                    .HasColumnName("RPDNLT")
                    .HasMaxLength(1);

                entity.Property(e => e.Rpdoc).HasColumnName("RPDOC");

                entity.Property(e => e.Rpdoco).HasColumnName("RPDOCO");

                entity.Property(e => e.Rpdrf).HasColumnName("RPDRF");

                entity.Property(e => e.Rpdsvj)
                    .HasColumnName("RPDSVJ")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Rpdtpb)
                    .HasColumnName("RPDTPB")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Rpdtxs)
                    .HasColumnName("RPDTXS")
                    .HasMaxLength(1);

                entity.Property(e => e.Rperdj)
                    .HasColumnName("RPERDJ")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Rpexr1)
                    .HasColumnName("RPEXR1")
                    .HasMaxLength(2);

                entity.Property(e => e.Rpfap).HasColumnName("RPFAP");

                entity.Property(e => e.Rpfnlp)
                    .HasColumnName("RPFNLP")
                    .HasMaxLength(1);

                entity.Property(e => e.Rpfnrt).HasColumnName("RPFNRT");

                entity.Property(e => e.Rpfy).HasColumnName("RPFY");

                entity.Property(e => e.Rpgfl1)
                    .HasColumnName("RPGFL1")
                    .HasMaxLength(1);

                entity.Property(e => e.Rpgfl2)
                    .HasColumnName("RPGFL2")
                    .HasMaxLength(1);

                entity.Property(e => e.Rpglba)
                    .HasColumnName("RPGLBA")
                    .HasMaxLength(8);

                entity.Property(e => e.Rpglc)
                    .HasColumnName("RPGLC")
                    .HasMaxLength(4);

                entity.Property(e => e.Rphcrr).HasColumnName("RPHCRR");

                entity.Property(e => e.Rphdgj)
                    .HasColumnName("RPHDGJ")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Rpicu).HasColumnName("RPICU");

                entity.Property(e => e.Rpicut)
                    .HasColumnName("RPICUT")
                    .HasMaxLength(2);

                entity.Property(e => e.Rpistc)
                    .HasColumnName("RPISTC")
                    .HasMaxLength(1);

                entity.Property(e => e.Rpistr)
                    .HasColumnName("RPISTR")
                    .HasMaxLength(1);

                entity.Property(e => e.Rpitm).HasColumnName("RPITM");

                entity.Property(e => e.Rpjcl)
                    .HasColumnName("RPJCL")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Rpjobn)
                    .HasColumnName("RPJOBN")
                    .HasMaxLength(10);

                entity.Property(e => e.Rpkco)
                    .HasColumnName("RPKCO")
                    .HasMaxLength(5);

                entity.Property(e => e.Rpkcoo)
                    .HasColumnName("RPKCOO")
                    .HasMaxLength(5);

                entity.Property(e => e.Rplfcj)
                    .HasColumnName("RPLFCJ")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Rplnid).HasColumnName("RPLNID");

                entity.Property(e => e.Rpmcu)
                    .HasColumnName("RPMCU")
                    .HasMaxLength(12);

                entity.Property(e => e.Rpmcu2)
                    .HasColumnName("RPMCU2")
                    .HasMaxLength(12);

                entity.Property(e => e.Rpnbrr)
                    .HasColumnName("RPNBRR")
                    .HasMaxLength(1);

                entity.Property(e => e.Rpnetdoc).HasColumnName("RPNETDOC");

                entity.Property(e => e.Rpnetrc5).HasColumnName("RPNETRC5");

                entity.Property(e => e.Rpnetst)
                    .HasColumnName("RPNETST")
                    .HasMaxLength(1);

                entity.Property(e => e.Rpnettcid).HasColumnName("RPNETTCID");

                entity.Property(e => e.Rpnrta).HasColumnName("RPNRTA");

                entity.Property(e => e.Rpobj)
                    .HasColumnName("RPOBJ")
                    .HasMaxLength(6);

                entity.Property(e => e.Rpodct)
                    .HasColumnName("RPODCT")
                    .HasMaxLength(2);

                entity.Property(e => e.Rpodoc).HasColumnName("RPODOC");

                entity.Property(e => e.Rpokco)
                    .HasColumnName("RPOKCO")
                    .HasMaxLength(5);

                entity.Property(e => e.Rpomod)
                    .HasColumnName("RPOMOD")
                    .HasMaxLength(1);

                entity.Property(e => e.Rposfx)
                    .HasColumnName("RPOSFX")
                    .HasMaxLength(3);

                entity.Property(e => e.Rppa8).HasColumnName("RPPA8");

                entity.Property(e => e.Rppdct)
                    .HasColumnName("RPPDCT")
                    .HasMaxLength(2);

                entity.Property(e => e.Rppid)
                    .HasColumnName("RPPID")
                    .HasMaxLength(10);

                entity.Property(e => e.Rppkco)
                    .HasColumnName("RPPKCO")
                    .HasMaxLength(5);

                entity.Property(e => e.Rppn).HasColumnName("RPPN");

                entity.Property(e => e.Rppo)
                    .HasColumnName("RPPO")
                    .HasMaxLength(8);

                entity.Property(e => e.Rppost)
                    .HasColumnName("RPPOST")
                    .HasMaxLength(1);

                entity.Property(e => e.Rpppdi)
                    .HasColumnName("RPPPDI")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Rpprgf)
                    .HasColumnName("RPPRGF")
                    .HasMaxLength(1);

                entity.Property(e => e.Rppst)
                    .HasColumnName("RPPST")
                    .HasMaxLength(1);

                entity.Property(e => e.Rpptc)
                    .HasColumnName("RPPTC")
                    .HasMaxLength(3);

                entity.Property(e => e.Rppwpg).HasColumnName("RPPWPG");

                entity.Property(e => e.Rppyid).HasColumnName("RPPYID");

                entity.Property(e => e.Rppyr).HasColumnName("RPPYR");

                entity.Property(e => e.Rprddj)
                    .HasColumnName("RPRDDJ")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Rprdrl)
                    .HasColumnName("RPRDRL")
                    .HasMaxLength(1);

                entity.Property(e => e.Rprdsj)
                    .HasColumnName("RPRDSJ")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Rprf)
                    .HasColumnName("RPRF")
                    .HasMaxLength(2);

                entity.Property(e => e.Rprmds).HasColumnName("RPRMDS");

                entity.Property(e => e.Rprmk)
                    .HasColumnName("RPRMK")
                    .HasMaxLength(30);

                entity.Property(e => e.Rprnid).HasColumnName("RPRNID");

                entity.Property(e => e.Rprp1)
                    .HasColumnName("RPRP1")
                    .HasMaxLength(1);

                entity.Property(e => e.Rprp2)
                    .HasColumnName("RPRP2")
                    .HasMaxLength(1);

                entity.Property(e => e.Rprp3)
                    .HasColumnName("RPRP3")
                    .HasMaxLength(1);

                entity.Property(e => e.Rprsco)
                    .HasColumnName("RPRSCO")
                    .HasMaxLength(2);

                entity.Property(e => e.Rpryin)
                    .HasColumnName("RPRYIN")
                    .HasMaxLength(1);

                entity.Property(e => e.Rpsbl)
                    .HasColumnName("RPSBL")
                    .HasMaxLength(8);

                entity.Property(e => e.Rpsblt)
                    .HasColumnName("RPSBLT")
                    .HasMaxLength(1);

                entity.Property(e => e.Rpsdct)
                    .HasColumnName("RPSDCT")
                    .HasMaxLength(2);

                entity.Property(e => e.Rpsdoc).HasColumnName("RPSDOC");

                entity.Property(e => e.Rpsfx)
                    .HasColumnName("RPSFX")
                    .HasMaxLength(3);

                entity.Property(e => e.Rpsfxo)
                    .HasColumnName("RPSFXO")
                    .HasMaxLength(3);

                entity.Property(e => e.Rpshpn).HasColumnName("RPSHPN");

                entity.Property(e => e.Rpskco)
                    .HasColumnName("RPSKCO")
                    .HasMaxLength(5);

                entity.Property(e => e.Rpsmtj)
                    .HasColumnName("RPSMTJ")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Rpsotf)
                    .HasColumnName("RPSOTF")
                    .HasMaxLength(1);

                entity.Property(e => e.Rpstam).HasColumnName("RPSTAM");

                entity.Property(e => e.Rpsub)
                    .HasColumnName("RPSUB")
                    .HasMaxLength(8);

                entity.Property(e => e.Rptorg)
                    .HasColumnName("RPTORG")
                    .HasMaxLength(10);

                entity.Property(e => e.Rptxa1)
                    .HasColumnName("RPTXA1")
                    .HasMaxLength(10);

                entity.Property(e => e.Rpu).HasColumnName("RPU");

                entity.Property(e => e.Rpum)
                    .HasColumnName("RPUM")
                    .HasMaxLength(2);

                entity.Property(e => e.Rpunit)
                    .HasColumnName("RPUNIT")
                    .HasMaxLength(8);

                entity.Property(e => e.Rpupmj)
                    .HasColumnName("RPUPMJ")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Rpupmt).HasColumnName("RPUPMT");

                entity.Property(e => e.Rpurab).HasColumnName("RPURAB");

                entity.Property(e => e.Rpurat).HasColumnName("RPURAT");

                entity.Property(e => e.Rpurc1)
                    .HasColumnName("RPURC1")
                    .HasMaxLength(3);

                entity.Property(e => e.Rpurdt)
                    .HasColumnName("RPURDT")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Rpurrf)
                    .HasColumnName("RPURRF")
                    .HasMaxLength(15);

                entity.Property(e => e.Rpuser)
                    .HasColumnName("RPUSER")
                    .HasMaxLength(10);

                entity.Property(e => e.Rpvdgj)
                    .HasColumnName("RPVDGJ")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Rpvinv)
                    .HasColumnName("RPVINV")
                    .HasMaxLength(25);

                entity.Property(e => e.Rpvldt)
                    .HasColumnName("RPVLDT")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Rpvod)
                    .HasColumnName("RPVOD")
                    .HasMaxLength(1);

                entity.Property(e => e.Rpvr01)
                    .HasColumnName("RPVR01")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<DiasProvision>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Desde).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Hasta).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PorcerntajeProvision).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TiluloPorcentaje).HasMaxLength(50);

                entity.Property(e => e.TituloDias).HasMaxLength(50);
            });

            modelBuilder.Entity<DwBalanceContable>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CategoriaDesc22)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CategoriaDesc23)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CategoriaDesc24)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CategoriaDesc25)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CategoriaDesc26)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CategoriaDesc27)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CategoriaId22)
                    .HasColumnName("CategoriaID22")
                    .HasMaxLength(10);

                entity.Property(e => e.CategoriaId23)
                    .HasColumnName("CategoriaID23")
                    .HasMaxLength(10);

                entity.Property(e => e.CategoriaId24)
                    .HasColumnName("CategoriaID24")
                    .HasMaxLength(10);

                entity.Property(e => e.CategoriaId25)
                    .HasColumnName("CategoriaID25")
                    .HasMaxLength(10);

                entity.Property(e => e.CategoriaId26)
                    .HasColumnName("CategoriaID26")
                    .HasMaxLength(10);

                entity.Property(e => e.CategoriaId27)
                    .HasColumnName("CategoriaID27")
                    .HasMaxLength(10);

                entity.Property(e => e.Compañia)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.CuentaDesc)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaId)
                    .IsRequired()
                    .HasColumnName("CuentaID")
                    .HasMaxLength(8);

                entity.Property(e => e.GerenciaDesc)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.GerenciaId)
                    .HasColumnName("GerenciaID")
                    .HasMaxLength(2);

                entity.Property(e => e.MonedaId)
                    .HasColumnName("MonedaID")
                    .HasMaxLength(3);

                entity.Property(e => e.NivelCuenta).HasMaxLength(1);

                entity.Property(e => e.SubLibroId)
                    .IsRequired()
                    .HasColumnName("SubLibroID")
                    .HasMaxLength(8);

                entity.Property(e => e.TipoLibroAux).HasMaxLength(1);

                entity.Property(e => e.TipoLibroDesc)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TipoLibroId)
                    .IsRequired()
                    .HasColumnName("TipoLibroID")
                    .HasMaxLength(2);

                entity.Property(e => e.UnidadNegocioDesc)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.UnidadNegocioId)
                    .HasColumnName("UnidadNegocioID")
                    .HasMaxLength(12);
            });

            modelBuilder.Entity<DwConsolidadoAnalisisDeVencimiento>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.HasIndex(e => new { e.Año, e.Mes })
                    .HasName("IX_DwConsolidadoAnalisisDeVencimiento_8");

                entity.HasIndex(e => new { e.Auxiliar, e.Año, e.Mes })
                    .HasName("IX_DwConsolidadoAnalisisDeVencimiento")
                    .IsClustered();

                entity.HasIndex(e => new { e.Año, e.Mes, e.Rpglc })
                    .HasName("IX_DwConsolidadoAnalisisDeVencimiento_5");

                entity.HasIndex(e => new { e.Auxiliar, e.Año, e.Mes, e.Vendedor })
                    .HasName("IX_DwConsolidadoAnalisisDeVencimiento_6");

                entity.HasIndex(e => new { e.Año, e.Mes, e.Oficina, e.FechaVencimiento })
                    .HasName("IX_DwConsolidadoAnalisisDeVencimiento_3");

                entity.HasIndex(e => new { e.Año, e.Mes, e.Vendedor, e.FechaVencimiento })
                    .HasName("IX_DwConsolidadoAnalisisDeVencimiento_4");

                entity.HasIndex(e => new { e.Auxiliar, e.Año, e.Mes, e.Transaccion, e.Documento })
                    .HasName("IX_DwConsolidadoAnalisisDeVencimiento_1");

                entity.HasIndex(e => new { e.Auxiliar, e.Año, e.Mes, e.Vendedor, e.Transaccion })
                    .HasName("IX_DwConsolidadoAnalisisDeVencimiento_7");

                entity.HasIndex(e => new { e.Auxiliar, e.Transaccion, e.Documento, e.Año, e.Mes })
                    .HasName("IX_DwConsolidadoAnalisisDeVencimiento_2");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.An8vendedor).HasMaxLength(6);

                entity.Property(e => e.AprobacionCobranzas)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Auxiliar)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Cia)
                    .HasMaxLength(5)
                    .HasDefaultValueSql("('01406')");

                entity.Property(e => e.Comision).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Condicion)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DescTransaccion).HasMaxLength(50);

                entity.Property(e => e.Dias)
                    .HasColumnName("DIAS")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Documento).HasMaxLength(25);

                entity.Property(e => e.FechaCredito).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaEmision).HasColumnType("datetime");

                entity.Property(e => e.FechaIngreso).HasColumnType("datetime");

                entity.Property(e => e.FechaVencimiento).HasColumnType("datetime");

                entity.Property(e => e.FechaVentas).HasColumnType("smalldatetime");

                entity.Property(e => e.NombOfic)
                    .HasColumnName("nomb_ofic")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NombreAn8)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.NombreVendedor)
                    .HasMaxLength(80)
                    .IsFixedLength();

                entity.Property(e => e.NuevaFechaVencimiento).HasColumnType("datetime");

                entity.Property(e => e.ObservacionesCobranzas)
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ObservacionesVentas)
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Oficina).HasColumnName("oficina");

                entity.Property(e => e.PorcProvision).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Provision).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Rango1)
                    .HasColumnName("RANGO1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Rango2)
                    .HasColumnName("RANGO2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Rango3)
                    .HasColumnName("RANGO3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Rango4)
                    .HasColumnName("RANGO4")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.RechazoCobranzas)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Refacturada)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rmonto).HasColumnName("RMonto");

                entity.Property(e => e.Rnc)
                    .HasColumnName("RNC")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Rpglc)
                    .HasColumnName("RPGLC")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Rrango1)
                    .HasColumnName("RRANGO1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Rrango2)
                    .HasColumnName("RRANGO2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Rrango3)
                    .HasColumnName("RRANGO3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Rrango4)
                    .HasColumnName("RRANGO4")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Rsaldo).HasColumnName("RSaldo");

                entity.Property(e => e.Sinvencer)
                    .HasColumnName("SINVENCER")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.SolicitudVentas)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Supervisor)
                    .HasColumnName("supervisor")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoNegocio).HasMaxLength(3);

                entity.Property(e => e.Top20Cia).HasMaxLength(1);

                entity.Property(e => e.Top20Oficina).HasMaxLength(1);

                entity.Property(e => e.Transaccion).HasMaxLength(2);

                entity.Property(e => e.UsuarioCredito)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioVentas)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Vendedor)
                    .HasColumnName("vendedor")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VendedorDeTransaccion)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<DwConsolidadoDePago>(entity =>
            {
                entity.HasIndex(e => new { e.Cia, e.Año, e.Mes, e.Auxiliar })
                    .HasName("IX_DwConsolidadoDePago");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.An8).HasComment("Codigo jde de Cliente-proveedor-empleado");

                entity.Property(e => e.Articulo)
                    .HasMaxLength(25)
                    .IsFixedLength();

                entity.Property(e => e.Auxiliar)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("Nombre de el auxiliar");

                entity.Property(e => e.Año).HasComment("Año de la Transaccion");

                entity.Property(e => e.Cia)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasComment("Compañia");

                entity.Property(e => e.CtoCodcto)
                    .HasColumnName("CTO_CODCTO")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DocCanc)
                    .HasColumnName("Doc_canc")
                    .HasMaxLength(25)
                    .IsFixedLength();

                entity.Property(e => e.FechaEmision)
                    .HasColumnName("Fecha_Emision")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaEmisionDocCanc)
                    .HasColumnName("Fecha_Emision_doc_canc")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnName("Fecha_ingreso")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaVencDocCanc)
                    .HasColumnName("Fecha_venc_doc_canc")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Mes).HasComment("Mes de la Transaccion");

                entity.Property(e => e.Monto).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NombreAn8)
                    .HasColumnName("Nombre_an8")
                    .HasMaxLength(80)
                    .IsFixedLength()
                    .HasComment("Nombre de Cliente-proveedor-empleado");

                entity.Property(e => e.NombreCuentaContable)
                    .HasColumnName("Nombre_cuentaContable")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.TnomTipnom)
                    .HasColumnName("TNOM_TIPNOM")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.TraCanc)
                    .HasColumnName("Tra_canc")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Transaccion)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<DwConsolidadoDePagoTempCxP>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Auxiliar)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Cia)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Cuenta).HasMaxLength(30);

                entity.Property(e => e.DocCanc)
                    .HasColumnName("Doc_canc")
                    .HasMaxLength(25);

                entity.Property(e => e.FechaEmision)
                    .HasColumnName("Fecha_emision")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaEmisionDocCanc)
                    .HasColumnName("Fecha_Emision_doc_canc")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnName("Fecha_Ingreso")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaVencDocCanc)
                    .HasColumnName("Fecha_venc_doc_canc")
                    .HasColumnType("datetime");

                entity.Property(e => e.NombreAn8)
                    .HasColumnName("Nombre_an8")
                    .HasMaxLength(40);

                entity.Property(e => e.TraCanc)
                    .HasColumnName("Tra_canc")
                    .HasMaxLength(2);

                entity.Property(e => e.Transaccion).HasMaxLength(2);
            });

            modelBuilder.Entity<DwConsolidadoDePagoTempNomina>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.An8)
                    .HasColumnName("an8")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Articulo)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Auxiliar)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Año).HasColumnType("numeric(4, 0)");

                entity.Property(e => e.Cia)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CtoCodcto)
                    .HasColumnName("CTO_CODCTO")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Cuenta)
                    .HasMaxLength(23)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DocCanc).HasColumnName("Doc_canc");

                entity.Property(e => e.FechaEmision)
                    .HasColumnName("Fecha_emision")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnName("fecha_ingreso")
                    .HasColumnType("datetime");

                entity.Property(e => e.Mes).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Monto)
                    .HasColumnName("monto")
                    .HasColumnType("numeric(23, 9)");

                entity.Property(e => e.NombreAn8)
                    .HasColumnName("nombre_an8")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.TnomTipnom)
                    .HasColumnName("TNOM_TIPNOM")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.TraCanc)
                    .HasColumnName("Tra_canc")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Transaccion).HasColumnType("numeric(4, 0)");
            });

            modelBuilder.Entity<DwConsumoInvOld>(entity =>
            {
                entity.HasKey(e => e.CodigoLargo)
                    .HasName("PK_ConsumoInventario");

                entity.ToTable("DwConsumoInvOLD");

                entity.Property(e => e.CodigoLargo)
                    .HasMaxLength(25)
                    .IsFixedLength();

                entity.Property(e => e.Act1)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Act10).HasDefaultValueSql("(0)");

                entity.Property(e => e.Act11).HasDefaultValueSql("(0)");

                entity.Property(e => e.Act12).HasDefaultValueSql("(0)");

                entity.Property(e => e.Act2).HasDefaultValueSql("(0)");

                entity.Property(e => e.Act3).HasDefaultValueSql("(0)");

                entity.Property(e => e.Act4).HasDefaultValueSql("(0)");

                entity.Property(e => e.Act5).HasDefaultValueSql("(0)");

                entity.Property(e => e.Act6).HasDefaultValueSql("(0)");

                entity.Property(e => e.Act7).HasDefaultValueSql("(0)");

                entity.Property(e => e.Act8).HasDefaultValueSql("(0)");

                entity.Property(e => e.Act9).HasDefaultValueSql("(0)");

                entity.Property(e => e.Ant1).HasDefaultValueSql("(0)");

                entity.Property(e => e.Ant10).HasDefaultValueSql("(0)");

                entity.Property(e => e.Ant11).HasDefaultValueSql("(0)");

                entity.Property(e => e.Ant12).HasDefaultValueSql("(0)");

                entity.Property(e => e.Ant2).HasDefaultValueSql("(0)");

                entity.Property(e => e.Ant3).HasDefaultValueSql("(0)");

                entity.Property(e => e.Ant4).HasDefaultValueSql("(0)");

                entity.Property(e => e.Ant5).HasDefaultValueSql("(0)");

                entity.Property(e => e.Ant6).HasDefaultValueSql("(0)");

                entity.Property(e => e.Ant7).HasDefaultValueSql("(0)");

                entity.Property(e => e.Ant8).HasDefaultValueSql("(0)");

                entity.Property(e => e.Ant9).HasDefaultValueSql("(0)");

                entity.Property(e => e.ArticuloDesc)
                    .HasMaxLength(80)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Categoria)
                    .HasMaxLength(3)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CategoriaDesc)
                    .HasMaxLength(30)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodigoCorto).HasDefaultValueSql("(0)");

                entity.Property(e => e.Glclass)
                    .HasColumnName("GLClass")
                    .HasMaxLength(4)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GlclassDesc)
                    .HasColumnName("GLClassDesc")
                    .HasMaxLength(30)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SubCategoria)
                    .HasMaxLength(3)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SubCategoriaDesc)
                    .HasMaxLength(30)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UndCompra)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.UndInventario)
                    .HasMaxLength(2)
                    .IsFixedLength();
            });

            modelBuilder.Entity<DwConsumoInventario>(entity =>
            {
                entity.HasKey(e => new { e.Año, e.Mes, e.CodigoLargo, e.Ancho });

                entity.Property(e => e.CodigoLargo)
                    .HasMaxLength(25)
                    .IsFixedLength();

                entity.Property(e => e.Ancho)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.ArticuloDesc)
                    .HasMaxLength(80)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BsConsumo)
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Categoria)
                    .HasMaxLength(3)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CategoriaDesc)
                    .HasMaxLength(30)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodigoCorto)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Consumo).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Disponible).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.FechaActualizado).HasColumnType("datetime");

                entity.Property(e => e.Glclass)
                    .HasColumnName("GLClass")
                    .HasMaxLength(4)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GlclassDesc)
                    .HasColumnName("GLClassDesc")
                    .HasMaxLength(30)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SubCategoria)
                    .HasMaxLength(3)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SubCategoriaDesc)
                    .HasMaxLength(30)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UndCompra)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.UndInventario)
                    .HasMaxLength(2)
                    .IsFixedLength();
            });

            modelBuilder.Entity<DwConsumoInventarioHistorico>(entity =>
            {
                entity.HasKey(e => new { e.Año, e.Mes, e.CodigoLargo, e.Ancho });

                entity.Property(e => e.CodigoLargo)
                    .HasMaxLength(25)
                    .IsFixedLength();

                entity.Property(e => e.Ancho)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.ArticuloDesc)
                    .HasMaxLength(80)
                    .IsFixedLength();

                entity.Property(e => e.BsConsumo)
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Categoria)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.CategoriaDesc)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.CodigoCorto).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Consumo).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Disponible).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.FechaActualizado).HasColumnType("datetime");

                entity.Property(e => e.Glclass)
                    .HasColumnName("GLClass")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.GlclassDesc)
                    .HasColumnName("GLClassDesc")
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.SubCategoria)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.SubCategoriaDesc)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.UndCompra)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.UndInventario)
                    .HasMaxLength(2)
                    .IsFixedLength();
            });

            modelBuilder.Entity<DwConsumoInventarioHistoricoBk>(entity =>
            {
                entity.HasKey(e => new { e.Año, e.Mes, e.CodigoLargo });

                entity.ToTable("DwConsumoInventarioHistoricoBK");

                entity.Property(e => e.CodigoLargo)
                    .HasMaxLength(25)
                    .IsFixedLength();

                entity.Property(e => e.Ancho)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.ArticuloDesc)
                    .HasMaxLength(80)
                    .IsFixedLength();

                entity.Property(e => e.Categoria)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.CategoriaDesc)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.FechaActualizado).HasColumnType("datetime");

                entity.Property(e => e.Glclass)
                    .HasColumnName("GLClass")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.GlclassDesc)
                    .HasColumnName("GLClassDesc")
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.SubCategoria)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.SubCategoriaDesc)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.UndCompra)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.UndInventario)
                    .HasMaxLength(2)
                    .IsFixedLength();
            });

            modelBuilder.Entity<DwContabilidad>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ArticuloAlphId)
                    .HasColumnName("ArticuloAlphID")
                    .HasMaxLength(25);

                entity.Property(e => e.ArticuloDesc)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ArticuloNumId).HasColumnName("ArticuloNumID");

                entity.Property(e => e.BatchId).HasColumnName("BatchID");

                entity.Property(e => e.BatchTipoDesc)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.BatchTipoId)
                    .HasColumnName("BatchTipoID")
                    .HasMaxLength(2);

                entity.Property(e => e.CategoriaDesc22)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CategoriaDesc23)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CategoriaDesc24)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CategoriaDesc25)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CategoriaDesc26)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CategoriaDesc27)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CategoriaDesc28)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CategoriaId22)
                    .HasColumnName("CategoriaID22")
                    .HasMaxLength(10);

                entity.Property(e => e.CategoriaId23)
                    .HasColumnName("CategoriaID23")
                    .HasMaxLength(10);

                entity.Property(e => e.CategoriaId24)
                    .HasColumnName("CategoriaID24")
                    .HasMaxLength(10);

                entity.Property(e => e.CategoriaId25)
                    .HasColumnName("CategoriaID25")
                    .HasMaxLength(10);

                entity.Property(e => e.CategoriaId26)
                    .HasColumnName("CategoriaID26")
                    .HasMaxLength(10);

                entity.Property(e => e.CategoriaId27)
                    .HasColumnName("CategoriaID27")
                    .HasMaxLength(10);

                entity.Property(e => e.CategoriaId28)
                    .HasColumnName("CategoriaID28")
                    .HasMaxLength(10);

                entity.Property(e => e.Compañia)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.Concepto)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Concepto1)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Concepto2)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.CuentaAux).HasMaxLength(8);

                entity.Property(e => e.CuentaDesc)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaId)
                    .HasColumnName("CuentaID")
                    .HasMaxLength(8);

                entity.Property(e => e.CuentaLargaId)
                    .HasColumnName("CuentaLargaID")
                    .HasMaxLength(29);

                entity.Property(e => e.CuentaObjeto).HasMaxLength(6);

                entity.Property(e => e.DireccionId).HasColumnName("DireccionID");

                entity.Property(e => e.DocumentoId).HasColumnName("DocumentoID");

                entity.Property(e => e.DocumentoTipoDesc)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentoTipoId)
                    .IsRequired()
                    .HasColumnName("DocumentoTipoID")
                    .HasMaxLength(4);

                entity.Property(e => e.FechaBatchReg).HasColumnType("decimal(9, 0)");

                entity.Property(e => e.FechaBatchSist).HasColumnType("decimal(9, 0)");

                entity.Property(e => e.FechaLm)
                    .HasColumnName("FechaLM")
                    .HasColumnType("decimal(9, 0)");

                entity.Property(e => e.GerenciaDesc)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.GerenciaId)
                    .HasColumnName("GerenciaID")
                    .HasMaxLength(2);

                entity.Property(e => e.MonedaCompañiaId)
                    .HasColumnName("MonedaCompañiaID")
                    .HasMaxLength(3);

                entity.Property(e => e.MonedaTransaccionId)
                    .HasColumnName("MonedaTransaccionID")
                    .HasMaxLength(3);

                entity.Property(e => e.NivelCuenta).HasMaxLength(1);

                entity.Property(e => e.Posteo).HasMaxLength(1);

                entity.Property(e => e.TipoLibroDesc)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TipoLibroId)
                    .IsRequired()
                    .HasColumnName("TipoLibroID")
                    .HasMaxLength(2);

                entity.Property(e => e.UnidadNegocio).HasMaxLength(12);

                entity.Property(e => e.UnidadNegocioDesc)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioFinal).HasMaxLength(10);

                entity.Property(e => e.UsuarioInicial).HasMaxLength(10);
            });

            modelBuilder.Entity<DwControlPronostico>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Activo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaVencimiento).HasColumnType("smalldatetime");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Modificar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<DwDashboardVendedor>(entity =>
            {
                entity.HasKey(e => new { e.Año, e.Mes, e.CodigoVendedor });

                entity.Property(e => e.CodigoVendedor)
                    .HasColumnName("Codigo_vendedor")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BsMcCategoria1).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BsMcCategoria10).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BsMcCategoria2).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BsMcCategoria3).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BsMcCategoria4).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BsMcCategoria5).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BsMcCategoria6).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BsMcCategoria7).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BsMcCategoria8).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BsMcCategoria9).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BsMcGeneral).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CobranzaPronostico).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CobranzaReal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CodigoSupervisor)
                    .HasColumnName("Codigo_Supervisor")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CotizadoPendiente).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CuotaGeneral).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FechaUpdate).HasColumnType("datetime");

                entity.Property(e => e.GanadoPeriodo).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NombreSupervisor)
                    .HasColumnName("Nombre_Supervisor")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NombreVendedor)
                    .IsRequired()
                    .HasColumnName("Nombre_Vendedor")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OficinaNombre)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PronosticoGeneral).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RncBs).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TituloCategoria1)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TituloCategoria10)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TituloCategoria2)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TituloCategoria3)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TituloCategoria4)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TituloCategoria5)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TituloCategoria6)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TituloCategoria7)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TituloCategoria8)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TituloCategoria9)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ValorListaRnc).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VentaCategoria1).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VentaCategoria10).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VentaCategoria2).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VentaCategoria3).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VentaCategoria4).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VentaCategoria5).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VentaCategoria6).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VentaCategoria7).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VentaCategoria8).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VentaCategoria9).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VentaGeneral).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<DwHistorialDespacho>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => new { e.Lista, e.Zona })
                    .HasName("IX_DwHistorialDespacho");

                entity.HasIndex(e => new { e.Lista, e.Zona, e.Kilometros })
                    .HasName("IX_DwHistorialDespacho_1");

                entity.Property(e => e.Bsflete)
                    .HasColumnName("bsflete")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Bsventa)
                    .HasColumnName("bsventa")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Bultos).HasColumnName("bultos");

                entity.Property(e => e.Ciudad)
                    .HasColumnName("ciudad")
                    .HasMaxLength(50);

                entity.Property(e => e.Ciudadlejana)
                    .HasColumnName("ciudadlejana")
                    .HasMaxLength(50);

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Kilometros).HasColumnName("kilometros");

                entity.Property(e => e.Lista).HasColumnName("lista");

                entity.Property(e => e.Orden).HasColumnName("orden");

                entity.Property(e => e.Posicionruta).HasColumnName("posicionruta");

                entity.Property(e => e.Tipovehiculo)
                    .HasColumnName("tipovehiculo")
                    .HasMaxLength(20);

                entity.Property(e => e.Zona)
                    .HasColumnName("zona")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<DwInventarioValorado>(entity =>
            {
                entity.HasKey(e => new { e.Año, e.Mes, e.CodigoLargo });

                entity.HasIndex(e => new { e.Año, e.Mes })
                    .HasName("IX_DwInventarioValorado");

                entity.Property(e => e.CodigoLargo)
                    .HasMaxLength(25)
                    .IsFixedLength();

                entity.Property(e => e.Almacen).HasMaxLength(50);

                entity.Property(e => e.ArticuloDesc)
                    .HasMaxLength(80)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CantidadAjustesMes).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CantidadComprasMes).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CantidadConsumoMes).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Categoria)
                    .HasMaxLength(3)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CategoriaDesc)
                    .HasMaxLength(30)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CostoFinal).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CostoPromedioAjustesMes).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CostoPromedioComprasMes).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CostoPromedioConsumoMes).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CostoPromedioConsumoMesCalculado).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CostoPromedioInicioMes).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.FechaActualizado).HasColumnType("datetime");

                entity.Property(e => e.Glclass)
                    .HasColumnName("GLClass")
                    .HasMaxLength(4)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GlclassDesc)
                    .HasColumnName("GLClassDesc")
                    .HasMaxLength(30)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SaldoFinal).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.SaldoInicioMes).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.SubCategoria)
                    .HasMaxLength(3)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SubCategoriaDesc)
                    .HasMaxLength(30)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TotalCostoAjustesMes).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TotalCostoComprasMes).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TotalCostoConsumoMes).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TotalCostoConsumoMesCalculado).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TotalCostoInicioMes).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<DwPronosticoDiarioCia>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Cobrado).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CobradoAcumulado).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CobradoAcumuladoSinPosteo).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CobradoSinPosteo).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Desde)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DiaHabil).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DiasHabiles).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.EstimadoAcumulado).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.EstimadoDiario).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.EstimadoTotal).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.FechaActualizacion).HasColumnType("smalldatetime");

                entity.Property(e => e.Hasta)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<DwPronosticoDiarioCiaTemp>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Cobrado).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CobradoAcumulado).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CobradoAcumuladoSinPosteo).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CobradoSinPosteo).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Desde)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DiaHabil).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DiasHabiles).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.EstimadoAcumulado).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.EstimadoDiario).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.EstimadoTotal).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.FechaActualizacion).HasColumnType("smalldatetime");

                entity.Property(e => e.Hasta)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<DwPronosticoDiarioOficina>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Cobrado).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CobradoAcumulado).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CobradoAcumuladoSinPosteo).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CobradoSinPosteo).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Desde)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DiaHabil).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DiasHabiles).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.EstimadoAcumulado).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.EstimadoDiario).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.EstimadoTotal).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.FechaActualizacion).HasColumnType("smalldatetime");

                entity.Property(e => e.Hasta)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.NombreOficina)
                    .HasColumnName("Nombre_oficina")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DwPronosticoDiarioOficinaTemp>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Cobrado).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CobradoAcumulado).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CobradoAcumuladoSinPosteo).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CobradoSinPosteo).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Desde)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DiaHabil).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DiasHabiles).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.EstimadoAcumulado).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.EstimadoDiario).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.EstimadoTotal).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.FechaActualizacion).HasColumnType("smalldatetime");

                entity.Property(e => e.Hasta)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.NombreOficina)
                    .HasColumnName("Nombre_oficina")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DwProvisionCliente>(entity =>
            {
                entity.HasKey(e => new { e.Año, e.Mes, e.An8 });

                entity.HasIndex(e => new { e.Año, e.Mes })
                    .HasName("IX_DwProvisionCliente");

                entity.HasIndex(e => new { e.Año, e.Mes, e.Vendedor })
                    .HasName("IX_DwProvisionCliente_1");

                entity.Property(e => e.Cia).HasMaxLength(5);

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.NombOfic)
                    .HasColumnName("nomb_ofic")
                    .HasMaxLength(40);

                entity.Property(e => e.NombreAn8).HasMaxLength(80);

                entity.Property(e => e.NombreVendedor).HasMaxLength(80);

                entity.Property(e => e.Rprovision).HasColumnName("RProvision");

                entity.Property(e => e.Rsaldo).HasColumnName("RSaldo");

                entity.Property(e => e.Vendedor)
                    .HasColumnName("vendedor")
                    .HasMaxLength(4);
            });

            modelBuilder.Entity<DwTiposDeTransaccion>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Aplicacion).HasMaxLength(50);

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Transaccion)
                    .HasMaxLength(2)
                    .IsFixedLength();
            });

            modelBuilder.Entity<DwcategoriaCuenta>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DWCategoriaCuenta");

                entity.Property(e => e.CategoriaDesc)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CategoriaId).HasColumnName("CategoriaID");

                entity.Property(e => e.SubCatDesc)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SubCatId).HasColumnName("SubCatID");

                entity.Property(e => e.TipoLibro)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProveedoresDireccionResidencia>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DireccionProveedor).HasMaxLength(500);

                entity.Property(e => e.FechaIni).HasColumnType("datetime");

                entity.Property(e => e.FechaUlt).HasColumnType("datetime");

                entity.Property(e => e.NombreProveedor).HasMaxLength(120);

                entity.Property(e => e.RifProveedor).HasMaxLength(15);
            });

            modelBuilder.Entity<VDetallePronostico>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_DetallePronostico");

                entity.Property(e => e.AprobacionCobranzas)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Auxiliar)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Año).HasColumnName("año");

                entity.Property(e => e.Cia).HasMaxLength(5);

                entity.Property(e => e.CondPago).HasColumnType("numeric(19, 0)");

                entity.Property(e => e.DescTransaccion).HasMaxLength(50);

                entity.Property(e => e.Documento).HasMaxLength(25);

                entity.Property(e => e.FechaEmision).HasColumnType("datetime");

                entity.Property(e => e.FechaIngreso).HasColumnType("datetime");

                entity.Property(e => e.FechaVencimiento).HasColumnType("datetime");

                entity.Property(e => e.Mes).HasColumnName("mes");

                entity.Property(e => e.NombOfic)
                    .HasColumnName("nomb_ofic")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NombreAn8)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.NombreVendedor)
                    .HasMaxLength(80)
                    .IsFixedLength();

                entity.Property(e => e.ObservacionesCobranzas).HasColumnType("text");

                entity.Property(e => e.ObservacionesVentas).HasColumnType("text");

                entity.Property(e => e.Rpglc)
                    .HasColumnName("RPGLC")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.SolicitudVentas)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Supervisor)
                    .HasColumnName("supervisor")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Transaccion).HasMaxLength(2);

                entity.Property(e => e.Vendedor)
                    .HasColumnName("vendedor")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VProvision>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_Provision");

                entity.Property(e => e.An8vendedor).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AprobacionCobranzas)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Auxiliar)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Cia).HasMaxLength(5);

                entity.Property(e => e.CondPago).HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Condicion)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DescTransaccion).HasMaxLength(50);

                entity.Property(e => e.Documento).HasMaxLength(25);

                entity.Property(e => e.FechaCredito).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaEmision).HasColumnType("datetime");

                entity.Property(e => e.FechaIngreso).HasColumnType("datetime");

                entity.Property(e => e.FechaVencimiento).HasColumnType("datetime");

                entity.Property(e => e.FechaVentas).HasColumnType("smalldatetime");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.NombOfic)
                    .HasColumnName("nomb_ofic")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NombreAn8)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.NombreVendedor)
                    .HasMaxLength(80)
                    .IsFixedLength();

                entity.Property(e => e.NuevaFechaVencimiento).HasColumnType("datetime");

                entity.Property(e => e.ObservacionesCobranzas).HasColumnType("text");

                entity.Property(e => e.ObservacionesVentas).HasColumnType("text");

                entity.Property(e => e.OchoPorc).HasColumnName("ochoPorc");

                entity.Property(e => e.Oficina).HasColumnName("oficina");

                entity.Property(e => e.Periodo).HasMaxLength(7);

                entity.Property(e => e.RechazoCobranzas).HasMaxLength(1);

                entity.Property(e => e.Refacturada).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Rnc)
                    .HasColumnName("RNC")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Rpglc)
                    .HasColumnName("RPGLC")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.SolicitudVentas)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Supervisor)
                    .HasColumnName("supervisor")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoNegocio).HasMaxLength(3);

                entity.Property(e => e.Transaccion).HasMaxLength(2);

                entity.Property(e => e.UsuarioCredito)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioVentas)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Vendedor)
                    .HasColumnName("vendedor")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VendedorDeTransaccion)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VResumenPronostico>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_ResumenPronostico");

                entity.Property(e => e.NombOfic)
                    .HasColumnName("nomb_ofic")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NombreVendedor)
                    .HasMaxLength(80)
                    .IsFixedLength();

                entity.Property(e => e.Oficina).HasColumnName("oficina");

                entity.Property(e => e.Pronosticado).HasColumnName("pronosticado");

                entity.Property(e => e.Supervisor)
                    .HasColumnName("supervisor")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Vendedor)
                    .HasColumnName("vendedor")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VTopProvisionCliente>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_TopProvisionCliente");

                entity.Property(e => e.NombOfic)
                    .HasColumnName("nomb_ofic")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Nombrean8)
                    .HasColumnName("nombrean8")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Nombrevendedor)
                    .HasColumnName("nombrevendedor")
                    .HasMaxLength(80);

                entity.Property(e => e.Provision)
                    .HasColumnName("provision")
                    .HasColumnType("numeric(38, 2)");

                entity.Property(e => e.Vendedor)
                    .HasColumnName("vendedor")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<XmlCobrado>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ValorX).HasMaxLength(20);

                entity.Property(e => e.Valory).HasMaxLength(20);

                entity.Property(e => e.Valory1).HasMaxLength(20);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
