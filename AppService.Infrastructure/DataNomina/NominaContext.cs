using AppService.Core.EntitiesNomina;
using Microsoft.EntityFrameworkCore;

namespace AppService.Infrastructure.DataNomina
{
    public partial class NominaContext : DbContext
    {
        public NominaContext()
        {
        }

        public NominaContext(DbContextOptions<NominaContext> options)
            : base(options)
        {
        }


        public virtual DbSet<Nmm024> NMM024 { get; set; }

        public virtual DbSet<Nmt033> NMT033 { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Nmm024>(entity =>
            {
                entity.ToTable("NMM024");

                entity.HasIndex(e => new { e.FPRO_ANOCAL, e.MESCAL }, "IX_NMM024_7");

                entity.Property(e => e.ABONAR)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ABONAR");

                entity.Property(e => e.AFECHE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AFECHE");

                entity.Property(e => e.CANCTO)
                    .HasColumnType("numeric(14, 7)")
                    .HasColumnName("CANCTO");

                entity.Property(e => e.CANIMP)
                    .HasColumnType("numeric(7, 3)")
                    .HasColumnName("CANIMP");

                entity.Property(e => e.CIA_CODACT)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CIA_CODACT");

                entity.Property(e => e.CIA_CODCIA)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CIA_CODCIA");

                entity.Property(e => e.CODBEN)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CODBEN");

                entity.Property(e => e.CODOPE)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CODOPE");

                entity.Property(e => e.CODSUC)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CODSUC");

                entity.Property(e => e.CONARM)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CONARM");

                entity.Property(e => e.CONCHE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CONCHE");

                entity.Property(e => e.CONCUO)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CONCUO");

                entity.Property(e => e.CONTROL)
                    .HasColumnType("numeric(38, 0)")
                    .HasColumnName("CONTROL");

                entity.Property(e => e.CTAAHO)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CTAAHO");

                entity.Property(e => e.CTACON)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("CTACON");

                entity.Property(e => e.CTO_CODCTO)
                    .HasColumnType("numeric(4, 0)")
                    .HasColumnName("CTO_CODCTO");

                entity.Property(e => e.CTO_CTOAHO)
                    .HasColumnType("numeric(4, 0)")
                    .HasColumnName("CTO_CTOAHO");

                entity.Property(e => e.CUOREG)
                    .HasColumnType("numeric(7, 3)")
                    .HasColumnName("CUOREG");

                entity.Property(e => e.DEPALT)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("DEPALT");

                entity.Property(e => e.DESADI)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DESADI");

                entity.Property(e => e.DGRT_CODGRU)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("DGRT_CODGRU");

                entity.Property(e => e.DPTO_CODDEP)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("DPTO_CODDEP");

                entity.Property(e => e.FACCAL)
                    .HasColumnType("numeric(22, 10)")
                    .HasColumnName("FACCAL");

                entity.Property(e => e.FECMES)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FECMES");

                entity.Property(e => e.FECMOV)
                    .HasColumnType("date")
                    .HasColumnName("FECMOV");

                entity.Property(e => e.FECSIS)
                    .HasColumnType("date")
                    .HasColumnName("FECSIS");

                entity.Property(e => e.FECSUE)
                    .HasColumnType("date")
                    .HasColumnName("FECSUE");

                entity.Property(e => e.FPRO_ANOCAL)
                    .HasColumnType("numeric(4, 0)")
                    .HasColumnName("FPRO_ANOCAL");

                entity.Property(e => e.FPRO_NUMPER)
                    .HasColumnType("numeric(3, 0)")
                    .HasColumnName("FPRO_NUMPER");

                entity.Property(e => e.FUNCTO)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FUNCTO");

                entity.Property(e => e.ID_MOTIVO_HE)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID_MOTIVO_HE");

                entity.Property(e => e.ID_PERSONA)
                    .HasColumnType("numeric(20, 0)")
                    .HasColumnName("ID_PERSONA");

                entity.Property(e => e.ID_PUESTO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID_PUESTO");

                entity.Property(e => e.INIDES)
                    .HasColumnType("date")
                    .HasColumnName("INIDES");

                entity.Property(e => e.INSD_INSAHO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("INSD_INSAHO");

                entity.Property(e => e.MANINS)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MANINS");

                entity.Property(e => e.MESCAL)
                    .HasColumnType("numeric(2, 0)")
                    .HasColumnName("MESCAL");

                entity.Property(e => e.MONCTO)
                    .HasColumnType("numeric(25, 9)")
                    .HasColumnName("MONCTO");

                entity.Property(e => e.MONCUO)
                    .HasColumnType("numeric(25, 9)")
                    .HasColumnName("MONCUO");

                entity.Property(e => e.MONORI)
                    .HasColumnType("numeric(25, 9)")
                    .HasColumnName("MONORI");

                entity.Property(e => e.MRETRO)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MRETRO");

                entity.Property(e => e.NOIMPR)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NOIMPR");

                entity.Property(e => e.NONETO)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NONETO");

                entity.Property(e => e.NOSUMA)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NOSUMA");

                entity.Property(e => e.ORDTRA)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ORDTRA");

                entity.Property(e => e.POSVAC)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("POSVAC");

                entity.Property(e => e.PRIEJE)
                    .HasColumnType("numeric(4, 0)")
                    .HasColumnName("PRIEJE");

                entity.Property(e => e.PROC_TIPPRO)
                    .HasColumnType("numeric(2, 0)")
                    .HasColumnName("PROC_TIPPRO");

                entity.Property(e => e.PROM_CODPRO)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("PROM_CODPRO");

                entity.Property(e => e.PROM_PROSUS)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("PROM_PROSUS");

                entity.Property(e => e.RETISR)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("RETISR");

                entity.Property(e => e.RGRU_CONGRU)
                    .HasColumnType("numeric(2, 0)")
                    .HasColumnName("RGRU_CONGRU");

                entity.Property(e => e.SALDOT)
                    .HasColumnType("numeric(25, 9)")
                    .HasColumnName("SALDOT");

                entity.Property(e => e.SOLOPAGO)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SOLOPAGO");

                entity.Property(e => e.SUBPRO)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("SUBPRO");

                entity.Property(e => e.SUEANT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SUEANT");

                entity.Property(e => e.SUECAL)
                    .HasColumnType("numeric(25, 9)")
                    .HasColumnName("SUECAL");

                entity.Property(e => e.SUESUS)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SUESUS");

                entity.Property(e => e.TABGEN)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TABGEN");

                entity.Property(e => e.TABU_CODTAB)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("TABU_CODTAB");

                entity.Property(e => e.TASINT)
                    .HasColumnType("numeric(13, 10)")
                    .HasColumnName("TASINT");

                entity.Property(e => e.TCTA_TIPAHO)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TCTA_TIPAHO");

                entity.Property(e => e.TIPANT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPANT");

                entity.Property(e => e.TIPCAL)
                    .HasColumnType("numeric(2, 0)")
                    .HasColumnName("TIPCAL");

                entity.Property(e => e.TIPFIS)
                    .HasColumnType("numeric(2, 0)")
                    .HasColumnName("TIPFIS");

                entity.Property(e => e.TIPI_TIPAHO)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TIPI_TIPAHO");

                entity.Property(e => e.TIPSUE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPSUE");

                entity.Property(e => e.TNOM_TIPNOM)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("TNOM_TIPNOM");

                entity.Property(e => e.TRAB_FICACT)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TRAB_FICACT");

                entity.Property(e => e.TRAB_FICSUP)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TRAB_FICSUP");

                entity.Property(e => e.TRAB_FICTRA)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TRAB_FICTRA");

                entity.Property(e => e.TRAB_SBTACT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TRAB_SBTACT");

                entity.Property(e => e.TRAB_SUBTIP)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TRAB_SUBTIP");

                entity.Property(e => e.USERID)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("USERID");

                entity.Property(e => e.VALCAL)
                    .HasColumnType("numeric(25, 9)")
                    .HasColumnName("VALCAL");

                entity.Property(e => e.YACONT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("YACONT");
            });

            modelBuilder.Entity<Nmt033>(entity =>
            {
                entity.ToTable("NMT033");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ANOCAL)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("ANOCAL");

                entity.Property(e => e.ANOCON)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("ANOCON");

                entity.Property(e => e.ANODIF)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("ANODIF");

                entity.Property(e => e.BUSCOL)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BUSCOL");

                entity.Property(e => e.CIA_CODCIA)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CIA_CODCIA");

                entity.Property(e => e.CUOREG)
                    .HasColumnType("decimal(7, 3)")
                    .HasColumnName("CUOREG");

                entity.Property(e => e.CUOSAL)
                    .HasColumnType("decimal(7, 3)")
                    .HasColumnName("CUOSAL");

                entity.Property(e => e.DESPER)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DESPER");

                entity.Property(e => e.DIAING)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("DIAING");

                entity.Property(e => e.DIARET)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("DIARET");

                entity.Property(e => e.ESTPER)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ESTPER");

                entity.Property(e => e.FACDIF)
                    .HasColumnType("decimal(22, 10)")
                    .HasColumnName("FACDIF");

                entity.Property(e => e.FECACT).HasColumnName("FECACT");

                entity.Property(e => e.FECCOM).HasColumnName("FECCOM");

                entity.Property(e => e.FECCRE).HasColumnName("FECCRE");

                entity.Property(e => e.FECDIF).HasColumnName("FECDIF");

                entity.Property(e => e.FECESQ).HasColumnName("FECESQ");

                entity.Property(e => e.FECFIN).HasColumnName("FECFIN");

                entity.Property(e => e.FECHA1).HasColumnName("FECHA1");

                entity.Property(e => e.FECHA2).HasColumnName("FECHA2");

                entity.Property(e => e.FECHA3).HasColumnName("FECHA3");

                entity.Property(e => e.FECIND).HasColumnName("FECIND");

                entity.Property(e => e.FECINH).HasColumnName("FECINH");

                entity.Property(e => e.FECINI).HasColumnName("FECINI");

                entity.Property(e => e.FECPAG).HasColumnName("FECPAG");

                entity.Property(e => e.FECRED).HasColumnName("FECRED");

                entity.Property(e => e.FECREH).HasColumnName("FECREH");

                entity.Property(e => e.FECRET).HasColumnName("FECRET");

                entity.Property(e => e.FECSAL).HasColumnName("FECSAL");

                entity.Property(e => e.FINANI).HasColumnName("FINANI");

                entity.Property(e => e.FORPAG)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FORPAG");

                entity.Property(e => e.FPRO_ANOCA1)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("FPRO_ANOCA1");

                entity.Property(e => e.FPRO_ANOCAL)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("FPRO_ANOCAL");

                entity.Property(e => e.FPRO_NUMPE1)
                    .HasColumnType("decimal(3, 0)")
                    .HasColumnName("FPRO_NUMPE1");

                entity.Property(e => e.FPRO_NUMPER)
                    .HasColumnType("decimal(3, 0)")
                    .HasColumnName("FPRO_NUMPER");

                entity.Property(e => e.FPRO_SUBPR1)
                    .HasColumnType("decimal(1, 0)")
                    .HasColumnName("FPRO_SUBPR1");

                entity.Property(e => e.FPRO_SUBPRO)
                    .HasColumnType("decimal(1, 0)")
                    .HasColumnName("FPRO_SUBPRO");

                entity.Property(e => e.FPRO_TIPPR1)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("FPRO_TIPPR1");

                entity.Property(e => e.FPRO_TIPPRO)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("FPRO_TIPPRO");

                entity.Property(e => e.FUNDIF)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FUNDIF");

                entity.Property(e => e.INIANI).HasColumnName("INIANI");

                entity.Property(e => e.MDES_CODDES)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("MDES_CODDES");

                entity.Property(e => e.MESCAL)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("MESCAL");

                entity.Property(e => e.MESCON)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("MESCON");

                entity.Property(e => e.MESDIF)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("MESDIF");

                entity.Property(e => e.NUMCOM)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("NUMCOM");

                entity.Property(e => e.NUMDIF)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("NUMDIF");

                entity.Property(e => e.NUMNOM)
                    .HasColumnType("decimal(1, 0)")
                    .HasColumnName("NUMNOM");

                entity.Property(e => e.NUMPER)
                    .HasColumnType("decimal(3, 0)")
                    .HasColumnName("NUMPER");

                entity.Property(e => e.POSCOM)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("POSCOM");

                entity.Property(e => e.POSDIF)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("POSDIF");

                entity.Property(e => e.PROC_TIPPRO)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("PROC_TIPPRO");

                entity.Property(e => e.PRORET)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PRORET");

                entity.Property(e => e.STAT_CODSTA)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("STAT_CODSTA");

                entity.Property(e => e.SUBPRO)
                    .HasColumnType("decimal(1, 0)")
                    .HasColumnName("SUBPRO");

                entity.Property(e => e.TIEFRC)
                    .HasColumnType("decimal(5, 0)")
                    .HasColumnName("TIEFRC");

                entity.Property(e => e.TIPCOM)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TIPCOM");

                entity.Property(e => e.TIPDIF)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TIPDIF");

                entity.Property(e => e.TIPFED)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("TIPFED");

                entity.Property(e => e.TIPFEF)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("TIPFEF");

                entity.Property(e => e.TIPFEH)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("TIPFEH");

                entity.Property(e => e.TNOM_TIPNOM)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("TNOM_TIPNOM");

                entity.Property(e => e.ULTNOM)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ULTNOM");

                entity.Property(e => e.UNITIE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("UNITIE");

                entity.Property(e => e.USRACT)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("USRACT");

                entity.Property(e => e.USRCRE)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("USRCRE");
            });




            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
