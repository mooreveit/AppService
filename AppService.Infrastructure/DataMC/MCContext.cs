using System;
using AppService.Core.EntitiesMC;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AppService.Infrastructure.DataMc
{
    public partial class MCContext : DbContext
    {
        public MCContext()
        {
        }

        public MCContext(DbContextOptions<MCContext> options)
            : base(options)
        {
        }

        public virtual DbSet<EjeucionProcesoCredito> EjeucionProcesoCredito { get; set; }
        public virtual DbSet<EjeucionProcesoCreditoMobil> EjeucionProcesoCreditoMobil { get; set; }
        public virtual DbSet<EjeucionProcesoPierdeCotizacionPorCredito> EjeucionProcesoPierdeCotizacionPorCredito { get; set; }
        public virtual DbSet<Materiaprima> Materiaprima { get; set; }
        public virtual DbSet<PaBsPagadosMes> PaBsPagadosMes { get; set; }
        public virtual DbSet<PlantillaPreset> PlantillaPreset { get; set; }
        public virtual DbSet<Preset> Preset { get; set; }
        public virtual DbSet<Psopdf> Psopdf { get; set; }
        public virtual DbSet<Pvt> Pvt { get; set; }
        public virtual DbSet<SolicitudesExistentes> SolicitudesExistentes { get; set; }
        public virtual DbSet<TEnControlCalculo> TEnControlCalculo { get; set; }
        public virtual DbSet<TEnEntradas> TEnEntradas { get; set; }
        public virtual DbSet<TPaCantidadAnchosetiquetasSinTroquel> TPaCantidadAnchosetiquetasSinTroquel { get; set; }
        public virtual DbSet<TPaCaracteresValidos> TPaCaracteresValidos { get; set; }
        public virtual DbSet<TPaConceptosNominaAfectanCosto> TPaConceptosNominaAfectanCosto { get; set; }
        public virtual DbSet<TPaConversionMedidaBasica> TPaConversionMedidaBasica { get; set; }
        public virtual DbSet<TPaConversionPulg2Placa> TPaConversionPulg2Placa { get; set; }
        public virtual DbSet<TPaCostoAñoMesManodeObraCargaFabrilPorPie> TPaCostoAñoMesManodeObraCargaFabrilPorPie { get; set; }
        public virtual DbSet<TPaCostoAñoMesManodeObraCargaFabrilPorPieJj> TPaCostoAñoMesManodeObraCargaFabrilPorPieJj { get; set; }
        public virtual DbSet<TPaCuentasContablePorVariable> TPaCuentasContablePorVariable { get; set; }
        public virtual DbSet<TPaCuentasContablePorVariableAñoMes> TPaCuentasContablePorVariableAñoMes { get; set; }
        public virtual DbSet<TPaDesarrolloEtiqueta> TPaDesarrolloEtiqueta { get; set; }
        public virtual DbSet<TPaDesperdicioEtiquetas> TPaDesperdicioEtiquetas { get; set; }
        public virtual DbSet<TPaFormulas> TPaFormulas { get; set; }
        public virtual DbSet<TPaFormulas13042019> TPaFormulas13042019 { get; set; }
        public virtual DbSet<TPaHistoricoCalculoCosto> TPaHistoricoCalculoCosto { get; set; }
        public virtual DbSet<TPaImpuestosYotros> TPaImpuestosYotros { get; set; }
        public virtual DbSet<TPaMateriaPrima> TPaMateriaPrima { get; set; }
        public virtual DbSet<TPaMedidasOpuestasYanchosCashRoll> TPaMedidasOpuestasYanchosCashRoll { get; set; }
        public virtual DbSet<TPaModeloCalculo> TPaModeloCalculo { get; set; }
        public virtual DbSet<TPaPlantillaEntradas> TPaPlantillaEntradas { get; set; }
        public virtual DbSet<TPaPorcDesperdicio> TPaPorcDesperdicio { get; set; }
        public virtual DbSet<TPaPrimeBasicasPorDesarrollo> TPaPrimeBasicasPorDesarrollo { get; set; }
        public virtual DbSet<TPaRangoToleranciaMc> TPaRangoToleranciaMc { get; set; }
        public virtual DbSet<TPaRatesOtrosMateriales> TPaRatesOtrosMateriales { get; set; }
        public virtual DbSet<TPaRatesOtrosMaterialesPrime> TPaRatesOtrosMaterialesPrime { get; set; }
        public virtual DbSet<TPaSysfile> TPaSysfile { get; set; }
        public virtual DbSet<TPaTasa> TPaTasa { get; set; }
        public virtual DbSet<TPaTasaBancoCentral> TPaTasaBancoCentral { get; set; }
        public virtual DbSet<TPaTasaCopia> TPaTasaCopia { get; set; }
        public virtual DbSet<TPaTasaReferencial> TPaTasaReferencial { get; set; }
        public virtual DbSet<TPaTipoCalculo> TPaTipoCalculo { get; set; }
        public virtual DbSet<TPaTiposDeVariables> TPaTiposDeVariables { get; set; }
        public virtual DbSet<TPaTroqueles> TPaTroqueles { get; set; }
        public virtual DbSet<TPaVariables> TPaVariables { get; set; }
        public virtual DbSet<TPaVariablesReporte> TPaVariablesReporte { get; set; }
        public virtual DbSet<TPrCalculo> TPrCalculo { get; set; }
        public virtual DbSet<TPrIdCalculo> TPrIdCalculo { get; set; }
        public virtual DbSet<TPrPendienteCalculo> TPrPendienteCalculo { get; set; }
        public virtual DbSet<TPrRecnumCalcularEmbarques> TPrRecnumCalcularEmbarques { get; set; }
        public virtual DbSet<TSaCalculoHistorico> TSaCalculoHistorico { get; set; }
        public virtual DbSet<TSaCalculoHistoricoGeneral> TSaCalculoHistoricoGeneral { get; set; }
        public virtual DbSet<TSaEntradasHistorico> TSaEntradasHistorico { get; set; }
        public virtual DbSet<TSaEntradasHistoricoGeneral> TSaEntradasHistoricoGeneral { get; set; }
        public virtual DbSet<TSaEstadisticaPapelEmbarques> TSaEstadisticaPapelEmbarques { get; set; }
        public virtual DbSet<TSaHistoricoCalculoCosto> TSaHistoricoCalculoCosto { get; set; }
        public virtual DbSet<TSaHistoricoDeMensajesPorIdCalculo> TSaHistoricoDeMensajesPorIdCalculo { get; set; }
        public virtual DbSet<TSaPlantillaReporteAnalisisCredito> TSaPlantillaReporteAnalisisCredito { get; set; }
        public virtual DbSet<TSaReporteAnalisisCredito> TSaReporteAnalisisCredito { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=MC;User Id=userweb;Password=userweb2003;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EjeucionProcesoCredito>(entity =>
            {
                entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Cotizacion)
                    .HasColumnName("COTIZACION")
                    .HasMaxLength(20);

                entity.Property(e => e.Fin).HasColumnType("datetime");

                entity.Property(e => e.Inicio).HasColumnType("datetime");

                entity.Property(e => e.Usuario).HasMaxLength(40);
            });

            modelBuilder.Entity<EjeucionProcesoCreditoMobil>(entity =>
            {
                entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Fin).HasColumnType("datetime");

                entity.Property(e => e.IdEvaluacion).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Inicio).HasColumnType("datetime");

                entity.Property(e => e.Usuario).HasMaxLength(40);
            });

            modelBuilder.Entity<EjeucionProcesoPierdeCotizacionPorCredito>(entity =>
            {
                entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Cotizacion)
                    .HasColumnName("COTIZACION")
                    .HasMaxLength(20);

                entity.Property(e => e.Fin).HasColumnType("datetime");

                entity.Property(e => e.Inicio).HasColumnType("datetime");

                entity.Property(e => e.Usuario).HasMaxLength(40);
            });

            modelBuilder.Entity<Materiaprima>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Codigo).HasMaxLength(12);

                entity.Property(e => e.Costo).HasColumnType("numeric(18, 4)");
            });

            modelBuilder.Entity<PaBsPagadosMes>(entity =>
            {
                entity.HasKey(e => new { e.Año, e.Mes });

                entity.ToTable("PA_BsPagadosMes");

                entity.Property(e => e.BsPagadoMes).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PlantillaPreset>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Basica)
                    .HasColumnName("BASICA")
                    .HasMaxLength(50);

                entity.Property(e => e.Cambioscomposicion)
                    .HasColumnName("CAMBIOSCOMPOSICION")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Cantfranjastransfertape)
                    .HasColumnName("CANTFRANJASTRANSFERTAPE")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Cantitintas)
                    .HasColumnName("CANTITINTAS")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Carbon)
                    .HasColumnName("CARBON")
                    .HasMaxLength(50);

                entity.Property(e => e.CodProducto)
                    .HasColumnName("COD_PRODUCTO")
                    .HasMaxLength(12);

                entity.Property(e => e.Grupopapel)
                    .HasColumnName("GRUPOPAPEL")
                    .HasMaxLength(100);

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdSolicitud)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Medidaopuestacarbon)
                    .HasColumnName("MEDIDAOPUESTACARBON")
                    .HasMaxLength(50);

                entity.Property(e => e.Millares).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Nombreproducto)
                    .HasColumnName("NOMBREPRODUCTO")
                    .HasMaxLength(50);

                entity.Property(e => e.Opuesta)
                    .HasColumnName("OPUESTA")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Orden)
                    .HasColumnName("ORDEN")
                    .HasMaxLength(50);

                entity.Property(e => e.Ordenreferencia)
                    .HasColumnName("ORDENReferencia")
                    .HasMaxLength(50);

                entity.Property(e => e.Papel)
                    .HasColumnName("PAPEL")
                    .HasMaxLength(100);

                entity.Property(e => e.Partes)
                    .HasColumnName("PARTES")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PrecioMaximoMillar)
                    .HasColumnType("numeric(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Talonextra)
                    .HasColumnName("TALONEXTRA")
                    .HasMaxLength(50);

                entity.Property(e => e.Tienecarbonspot)
                    .HasColumnName("TIENECARBONSPOT")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Preset>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Orden)
                    .HasName("IX_Preset");

                entity.Property(e => e.Basica)
                    .HasColumnName("BASICA")
                    .HasMaxLength(50);

                entity.Property(e => e.Cambioscomposicion)
                    .HasColumnName("CAMBIOSCOMPOSICION")
                    .HasMaxLength(50);

                entity.Property(e => e.Cantfranjastransfertape)
                    .HasColumnName("CANTFRANJASTRANSFERTAPE")
                    .HasMaxLength(50);

                entity.Property(e => e.Cantitintas)
                    .HasColumnName("CANTITINTAS")
                    .HasMaxLength(50);

                entity.Property(e => e.Carbon)
                    .HasColumnName("CARBON")
                    .HasMaxLength(50);

                entity.Property(e => e.CodProducto)
                    .HasColumnName("COD_PRODUCTO")
                    .HasMaxLength(12);

                entity.Property(e => e.FormasUndFact)
                    .HasColumnName("FORMAS_UND_FACT")
                    .HasMaxLength(50);

                entity.Property(e => e.Grupopapel)
                    .HasColumnName("GRUPOPAPEL")
                    .HasMaxLength(100);

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Medidaopuestacarbon)
                    .HasColumnName("MEDIDAOPUESTACARBON")
                    .HasMaxLength(50);

                entity.Property(e => e.Millares)
                    .HasColumnName("MILLARES")
                    .HasMaxLength(50);

                entity.Property(e => e.Nombreproducto)
                    .HasColumnName("NOMBREPRODUCTO")
                    .HasMaxLength(100);

                entity.Property(e => e.Opuesta)
                    .HasColumnName("OPUESTA")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Orden)
                    .HasColumnName("ORDEN")
                    .HasMaxLength(50);

                entity.Property(e => e.Papel)
                    .HasColumnName("PAPEL")
                    .HasMaxLength(100);

                entity.Property(e => e.Partes)
                    .HasColumnName("PARTES")
                    .HasMaxLength(50);

                entity.Property(e => e.Talonextra)
                    .HasColumnName("TALONEXTRA")
                    .HasMaxLength(50);

                entity.Property(e => e.Tienecarbonspot)
                    .HasColumnName("TIENECARBONSPOT")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Psopdf>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("psopdf");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(80);
            });

            modelBuilder.Entity<Pvt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pvt");

                entity.Property(e => e.VendorId).HasColumnName("VendorID");
            });

            modelBuilder.Entity<SolicitudesExistentes>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.IdSolicitud)
                    .HasName("IX_SolicitudesExistentes");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdSolicitud).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<TEnControlCalculo>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("T_En_ControlCalculo");

                entity.HasIndex(e => e.Documento)
                    .HasName("IX_T_En_ControlCalculo_1");

                entity.HasIndex(e => e.FechaCreacion)
                    .HasName("IX_T_En_ControlCalculo");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_T_En_ControlCalculo_2");

                entity.Property(e => e.IdSolicitud).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Documento).HasMaxLength(20);

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TEnEntradas>(entity =>
            {
                entity.HasKey(e => new { e.IdSolicitud, e.LineaNegocio, e.IdVariables, e.Item });

                entity.ToTable("T_En_Entradas");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_T_En_Entradas_2");

                entity.HasIndex(e => e.IdSolicitud)
                    .HasName("IX_T_En_Entradas");

                entity.HasIndex(e => new { e.IdSolicitud, e.IdVariables })
                    .HasName("IX_T_En_Entradas_1");

                entity.Property(e => e.IdSolicitud).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdVariables).HasMaxLength(20);

                entity.Property(e => e.FuncionDeBusqueda).HasMaxLength(500);

                entity.Property(e => e.FuncionDeBusquedaValor).HasMaxLength(500);

                entity.Property(e => e.FuncionDeValidacion)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MensajeValidacion)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Orden).HasMaxLength(20);

                entity.Property(e => e.Producto).HasMaxLength(12);

                entity.Property(e => e.Valor).HasMaxLength(150);

                entity.HasOne(d => d.IdVariablesNavigation)
                    .WithMany(p => p.TEnEntradas)
                    .HasForeignKey(d => d.IdVariables)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_T_En_Entradas_T_Pa_Variables");
            });

            modelBuilder.Entity<TPaCantidadAnchosetiquetasSinTroquel>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_Pa_CantidadAnchosetiquetasSinTroquel");

                entity.Property(e => e.CantAnchos).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MedidaOpuestaDecimalDesde).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MedidaOpuestaDecimalHasta).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<TPaCaracteresValidos>(entity =>
            {
                entity.HasKey(e => new { e.Ultimo, e.Siguiente });

                entity.ToTable("T_Pa_CaracteresValidos");

                entity.Property(e => e.Ultimo).HasMaxLength(1);

                entity.Property(e => e.Siguiente).HasMaxLength(1);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TPaConceptosNominaAfectanCosto>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_Pa_ConceptosNominaAfectanCosto");

                entity.Property(e => e.Codcto)
                    .HasColumnName("CODCTO")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.Descto)
                    .HasColumnName("DESCTO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TnomTipnom)
                    .IsRequired()
                    .HasColumnName("TNOM_TIPNOM")
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TPaConversionMedidaBasica>(entity =>
            {
                entity.ToTable("T_Pa_ConversionMedidaBasica");

                entity.HasIndex(e => e.Medida)
                    .HasName("IX_T_Pa_ConversionMedidaBasica")
                    .IsUnique();

                entity.Property(e => e.FactorConversion).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Medida).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.MedidaString).HasMaxLength(6);

                entity.Property(e => e.UsuarioCreacion).HasMaxLength(50);

                entity.Property(e => e.UsuarioModifico).HasMaxLength(50);
            });

            modelBuilder.Entity<TPaConversionPulg2Placa>(entity =>
            {
                entity.ToTable("T_Pa_ConversionPulg2Placa");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Medida).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.MedidaString).HasMaxLength(6);

                entity.Property(e => e.Resultado).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ResultadoString)
                    .IsRequired()
                    .HasMaxLength(6);

                entity.Property(e => e.UsuarioCreacion).HasMaxLength(50);

                entity.Property(e => e.UsuarioModifico).HasMaxLength(50);
            });

            modelBuilder.Entity<TPaCostoAñoMesManodeObraCargaFabrilPorPie>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_Pa_CostoAñoMesManodeObraCargaFabrilPorPie");

                entity.HasIndex(e => new { e.Año, e.Mes })
                    .HasName("IX_T_Pa_CostoAñoMesManodeObraCargaFabrilPorPie");

                entity.HasIndex(e => new { e.Año, e.Mes, e.TipoRate })
                    .HasName("IX_T_Pa_CostoAñoMesManodeObraCargaFabrilPorPie_1");

                entity.Property(e => e.CostoCargaFabrilColectoraPorPie).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CostoCargaFabrilColectoraPorPieShortRun)
                    .HasColumnType("numeric(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CostoCargaFabrilEtiquetas).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CostoCargaFabrilPrensaPorPie).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CostoCargaFabrilPrensaPorPieShortRun)
                    .HasColumnType("numeric(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CostoManoDeObraColectoraPorPie).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CostoManoDeObraColectoraPorPieShortRun)
                    .HasColumnType("numeric(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CostoManoDeObraEtiquetas).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CostoManoDeObraPrensaPorPie).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CostoManoDeObraPrensaPorPieShortRun)
                    .HasColumnType("numeric(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CostoManoObraAcabadoPrime).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CostoManoObraPrensaPrime).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CostoPlacaPorPie).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Costodistribucion).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CostodistribucionComprado).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RateCargaFabrilPrime).HasColumnType("numeric(18, 4)");
            });

            modelBuilder.Entity<TPaCostoAñoMesManodeObraCargaFabrilPorPieJj>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_Pa_CostoAñoMesManodeObraCargaFabrilPorPieJJ");

                entity.Property(e => e.CostoCargaFabrilColectoraPorPie).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CostoCargaFabrilColectoraPorPieShortRun).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CostoCargaFabrilEtiquetas).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CostoCargaFabrilPrensaPorPie).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CostoCargaFabrilPrensaPorPieShortRun).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CostoManoDeObraColectoraPorPie).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CostoManoDeObraColectoraPorPieShortRun).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CostoManoDeObraEtiquetas).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CostoManoDeObraPrensaPorPie).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CostoManoDeObraPrensaPorPieShortRun).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CostoManoObraAcabadoPrime).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CostoManoObraPrensaPrime).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CostoPlacaPorPie).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Costodistribucion).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CostodistribucionComprado).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RateCargaFabrilPrime).HasColumnType("numeric(18, 4)");
            });

            modelBuilder.Entity<TPaCuentasContablePorVariable>(entity =>
            {
                entity.HasKey(e => new { e.Glani, e.IdVariables });

                entity.ToTable("T_Pa_CuentasContablePorVariable");

                entity.HasIndex(e => new { e.IdVariables, e.Glani })
                    .HasName("IX_T_Pa_CuentasContablePorVariable");

                entity.Property(e => e.Glani)
                    .HasColumnName("GLANI")
                    .HasMaxLength(29)
                    .IsFixedLength();

                entity.Property(e => e.IdVariables).HasMaxLength(20);

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdCuenta)
                    .HasMaxLength(8)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TPaCuentasContablePorVariableAñoMes>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_Pa_CuentasContablePorVariableAñoMes");

                entity.HasIndex(e => new { e.Año, e.IdVariables })
                    .HasName("IX_T_Pa_CuentasContablePorVariableAñoMes");

                entity.HasIndex(e => new { e.Año, e.Mes })
                    .HasName("IX_T_Pa_CuentasContablePorVariableAñoMes_1");

                entity.HasIndex(e => new { e.Año, e.Mes, e.IdVariables })
                    .HasName("IX_T_Pa_CuentasContablePorVariableAñoMes_2");

                entity.Property(e => e.Año).HasColumnType("numeric(4, 0)");

                entity.Property(e => e.Glani)
                    .IsRequired()
                    .HasColumnName("GLANI")
                    .HasMaxLength(29)
                    .IsFixedLength();

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdVariables)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Mes).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Monto).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<TPaDesarrolloEtiqueta>(entity =>
            {
                entity.ToTable("T_Pa_DesarrolloEtiqueta");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Desarrollo).HasMaxLength(6);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.MedidaBasica)
                    .IsRequired()
                    .HasMaxLength(6);

                entity.Property(e => e.UsuarioCreacion).HasMaxLength(50);

                entity.Property(e => e.UsuarioModifico).HasMaxLength(50);
            });

            modelBuilder.Entity<TPaDesperdicioEtiquetas>(entity =>
            {
                entity.ToTable("T_Pa_DesperdicioEtiquetas");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.MtsLineales).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Tintas).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.UsuarioCreacion).HasMaxLength(50);

                entity.Property(e => e.UsuarioModifico).HasMaxLength(50);
            });

            modelBuilder.Entity<TPaFormulas>(entity =>
            {
                entity.HasKey(e => new { e.IdVariables, e.LineaNegocio });

                entity.ToTable("T_Pa_Formulas");

                entity.Property(e => e.IdVariables).HasMaxLength(20);

                entity.Property(e => e.DescripcionFormula)
                    .HasMaxLength(4000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Formula).HasMaxLength(4000);

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.OrdenCalculo).HasColumnType("numeric(18, 1)");

                entity.Property(e => e.UsuarioCreacion).HasMaxLength(50);

                entity.Property(e => e.UsuarioModifico).HasMaxLength(50);
            });

            modelBuilder.Entity<TPaFormulas13042019>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_Pa_Formulas13042019");

                entity.Property(e => e.DescripcionFormula).HasMaxLength(4000);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Formula).HasMaxLength(4000);

                entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdVariables)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.OrdenCalculo).HasColumnType("numeric(18, 1)");

                entity.Property(e => e.UsuarioCreacion).HasMaxLength(50);

                entity.Property(e => e.UsuarioModifico).HasMaxLength(50);
            });

            modelBuilder.Entity<TPaHistoricoCalculoCosto>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_Pa_HistoricoCalculoCosto");

                entity.Property(e => e.Documento).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdSolicitud).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Monto).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Nombre).HasMaxLength(50);

                entity.Property(e => e.Orden).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.OrdenProduccion).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Variable).HasMaxLength(20);

                entity.Property(e => e.VariablePadre).HasMaxLength(20);
            });

            modelBuilder.Entity<TPaImpuestosYotros>(entity =>
            {
                entity.ToTable("T_Pa_ImpuestosYOtros");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Porcentaje).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.UsuarioCreacion).HasMaxLength(50);

                entity.Property(e => e.UsuarioModifico).HasMaxLength(50);
            });

            modelBuilder.Entity<TPaMateriaPrima>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_Pa_MateriaPrima");

                entity.HasIndex(e => e.AñoMes)
                    .HasName("IX_T_Pa_MateriaPrima");

                entity.HasIndex(e => new { e.AñoMes, e.Codigo })
                    .HasName("IX_T_Pa_MateriaPrima_1");

                entity.HasIndex(e => new { e.Codigo, e.AñoMes })
                    .HasName("IX_T_Pa_MateriaPrima_2");

                entity.Property(e => e.Almacen).HasMaxLength(50);

                entity.Property(e => e.AñoMes).HasColumnType("numeric(6, 0)");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasColumnName("CODIGO")
                    .HasMaxLength(20);

                entity.Property(e => e.CostoPromedio)
                    .HasColumnName("COSTO_PROMEDIO")
                    .HasColumnType("numeric(20, 2)");

                entity.Property(e => e.CostoPromedioInicial).HasColumnType("numeric(20, 2)");

                entity.Property(e => e.CostoReposicion)
                    .HasColumnName("COSTO_REPOSICION")
                    .HasColumnType("numeric(20, 2)");

                entity.Property(e => e.DescMaterial1)
                    .IsRequired()
                    .HasColumnName("DESC_MATERIAL1")
                    .HasMaxLength(256);

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaModifica)
                    .HasColumnName("FECHA_MODIFICA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Gramaje)
                    .HasColumnName("GRAMAJE")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.Id)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Idcategoria).HasColumnName("IDCATEGORIA");

                entity.Property(e => e.RcostoPromedio)
                    .HasColumnName("RCOSTO_PROMEDIO")
                    .HasColumnType("numeric(20, 2)");

                entity.Property(e => e.RcostoReposicion)
                    .HasColumnName("RCOSTO_REPOSICION")
                    .HasColumnType("numeric(20, 2)");

                entity.Property(e => e.SaldoInicial).HasColumnType("numeric(20, 2)");

                entity.Property(e => e.TotalCostoInicial).HasColumnType("numeric(20, 2)");

                entity.Property(e => e.UsuarioCreo)
                    .IsRequired()
                    .HasColumnName("USUARIO_CREO")
                    .HasMaxLength(20);

                entity.Property(e => e.UsuarioModif)
                    .IsRequired()
                    .HasColumnName("USUARIO_MODIF")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<TPaMedidasOpuestasYanchosCashRoll>(entity =>
            {
                entity.ToTable("T_Pa_MedidasOpuestasYAnchosCashRoll");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AnchosAproducir)
                    .HasColumnName("AnchosAProducir")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CantPartes).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.MedidaOpuesta).HasMaxLength(50);

                entity.Property(e => e.UsuarioCreacion).HasMaxLength(50);

                entity.Property(e => e.UsuarioModifico).HasMaxLength(50);
            });

            modelBuilder.Entity<TPaModeloCalculo>(entity =>
            {
                entity.HasKey(e => e.CodigoModelo)
                    .HasName("PK_T_Pr_TiposDeCalculo");

                entity.ToTable("T_Pa_ModeloCalculo");

                entity.Property(e => e.CodigoModelo).ValueGeneratedNever();

                entity.Property(e => e.DescripcionModelo).HasMaxLength(256);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.UsuarioCreacion).HasMaxLength(50);

                entity.Property(e => e.UsuarioModifico).HasMaxLength(50);
            });

            modelBuilder.Entity<TPaPlantillaEntradas>(entity =>
            {
                entity.HasKey(e => new { e.LineaNegocio, e.IdVariables, e.Item });

                entity.ToTable("T_PA_PlantillaEntradas");

                entity.HasIndex(e => e.LineaNegocio)
                    .HasName("IX_T_PA_PlantillaEntradas");

                entity.Property(e => e.IdVariables).HasMaxLength(20);

                entity.Property(e => e.DescripcionVariable).HasMaxLength(100);

                entity.Property(e => e.FuncionDeBusqueda).HasMaxLength(500);

                entity.Property(e => e.FuncionDeValidacion).HasMaxLength(500);

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Observaciones).HasMaxLength(500);

                entity.Property(e => e.Valor).HasMaxLength(50);

                entity.HasOne(d => d.IdVariablesNavigation)
                    .WithMany(p => p.TPaPlantillaEntradas)
                    .HasForeignKey(d => d.IdVariables)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_T_PA_PlantillaEntradas_T_Pa_Variables");

                entity.HasOne(d => d.LineaNegocioNavigation)
                    .WithMany(p => p.TPaPlantillaEntradas)
                    .HasForeignKey(d => d.LineaNegocio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_T_PA_PlantillaEntradas_T_Pa_ModeloCalculo");
            });

            modelBuilder.Entity<TPaPorcDesperdicio>(entity =>
            {
                entity.HasKey(e => new { e.MillaresDesde, e.MillaresHasta, e.CantTintas });

                entity.ToTable("T_Pa_PorcDesperdicio");

                entity.Property(e => e.MillaresDesde).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.MillaresHasta).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PorcDersperdicio).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.UsuarioCreacion).HasMaxLength(50);

                entity.Property(e => e.UsuarioModifico).HasMaxLength(50);
            });

            modelBuilder.Entity<TPaPrimeBasicasPorDesarrollo>(entity =>
            {
                entity.HasKey(e => new { e.Desarrollo, e.Repeticiones });

                entity.ToTable("T_Pa_PrimeBasicasPorDesarrollo");

                entity.Property(e => e.Basica).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TPaRangoToleranciaMc>(entity =>
            {
                entity.ToTable("T_Pa_RangoToleranciaMC");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(20);

                entity.Property(e => e.Desde)
                    .HasColumnName("DESDE")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Enviaemail)
                    .HasColumnName("ENVIAEMAIL")
                    .HasMaxLength(1);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Hasta)
                    .HasColumnName("HASTA")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.LineaProducto)
                    .IsRequired()
                    .HasColumnName("LINEA_PRODUCTO")
                    .HasMaxLength(2);

                entity.Property(e => e.Mensaje)
                    .HasColumnName("MENSAJE")
                    .HasMaxLength(50);

                entity.Property(e => e.PositivoNegativo).HasMaxLength(1);

                entity.Property(e => e.UsuarioCreacion).HasMaxLength(50);

                entity.Property(e => e.UsuarioModifico).HasMaxLength(50);
            });

            modelBuilder.Entity<TPaRatesOtrosMateriales>(entity =>
            {
                entity.ToTable("T_Pa_RatesOtrosMateriales");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.PorcCargaFabril).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.PorcManoDeObra).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.RateCajasBs).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.RateCajasBsRollos).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.RateCajasKg).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.RateCajasRollos).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.RateCoresRollos).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.RateOtrosMateriales).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.RatePlaca).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.RatePlacaEtiqueta).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.RateTinta).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.RateTintaCarbonSpot).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.RateTransferTape)
                    .HasColumnName("RateTransferTApe")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.RrateCajasBs)
                    .HasColumnName("RRateCajasBs")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.RrateCajasBsRollos)
                    .HasColumnName("RRateCajasBsRollos")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.RrateCajasKg)
                    .HasColumnName("RRateCajasKg")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.RrateCajasRollos)
                    .HasColumnName("RRateCajasRollos")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.RrateCoresRollos)
                    .HasColumnName("RRateCoresRollos")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.RrateOtrosMateriales)
                    .HasColumnName("RRateOtrosMateriales")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.RratePlaca)
                    .HasColumnName("RRatePlaca")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.RratePlacaEtiqueta)
                    .HasColumnName("RRatePlacaEtiqueta")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.RrateTinta)
                    .HasColumnName("RRateTinta")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.RrateTintaCarbonSpot)
                    .HasColumnName("RRateTintaCarbonSpot")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.RrateTransferTape)
                    .HasColumnName("RRateTransferTApe")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.UsuarioCreacion).HasMaxLength(50);

                entity.Property(e => e.UsuarioModifico).HasMaxLength(50);
            });

            modelBuilder.Entity<TPaRatesOtrosMaterialesPrime>(entity =>
            {
                entity.ToTable("T_Pa_RatesOtrosMaterialesPrime");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.RateAnimes).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.RateBarnizUv)
                    .HasColumnName("RateBarnizUV")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.RateCajasBs).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.RateCajasBsRollos).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.RateCajasKg).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.RateCajasRollos).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.RateCartonLigas).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.RateColdFoil).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.RateCoresRollos).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.RateOtrosMateriales).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.RatePlaca).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.RatePlacaEtiqueta).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.RatePolifilm).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.RateRibbon).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.RateTinta).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.RateTintaCarbonSpot).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.RateTransferTape)
                    .HasColumnName("RateTransferTApe")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.RateTroquel).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.UsuarioCreacion).HasMaxLength(50);

                entity.Property(e => e.UsuarioModifico).HasMaxLength(50);
            });

            modelBuilder.Entity<TPaSysfile>(entity =>
            {
                entity.ToTable("T_Pa_Sysfile");

                entity.Property(e => e.ConsecutivoOrdenPlantilla).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CopiaFuncional).HasMaxLength(256);

                entity.Property(e => e.CopiaTecnico).HasMaxLength(256);

                entity.Property(e => e.DestinatarioFuncional).HasMaxLength(256);

                entity.Property(e => e.DestinatarioTecnico).HasMaxLength(256);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.SegundaCopiaFuncional).HasMaxLength(256);

                entity.Property(e => e.UsuarioCreacion).HasMaxLength(50);

                entity.Property(e => e.UsuarioModifico).HasMaxLength(50);
            });

            modelBuilder.Entity<TPaTasa>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_Pa_Tasa");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Tasa).HasColumnType("numeric(18, 4)");
            });

            modelBuilder.Entity<TPaTasaBancoCentral>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_Pa_Tasa_BancoCentral");

                entity.HasIndex(e => e.Fecha)
                    .HasName("UQ__T_Pa_Tas__B30C8A5E27F17494")
                    .IsUnique();

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaTasa)
                    .HasColumnName("Fecha_Tasa")
                    .HasMaxLength(18)
                    .IsFixedLength();

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Tasa).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<TPaTasaCopia>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_Pa_TasaCopia");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Tasa).HasColumnType("numeric(18, 4)");
            });

            modelBuilder.Entity<TPaTasaReferencial>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_Pa_Tasa_Referencial");

                entity.HasIndex(e => e.Fecha)
                    .HasName("UQ__T_Pa_Tas__B30C8A5E03A666DF")
                    .IsUnique();

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaTasa)
                    .HasColumnName("Fecha_Tasa")
                    .HasMaxLength(18)
                    .IsFixedLength();

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Tasa).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<TPaTipoCalculo>(entity =>
            {
                entity.HasKey(e => e.TipoCalculo);

                entity.ToTable("T_Pa_TipoCalculo");

                entity.Property(e => e.TipoCalculo).ValueGeneratedNever();

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Promedio).HasMaxLength(1);

                entity.Property(e => e.Reposicion)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioCreacion).HasMaxLength(50);

                entity.Property(e => e.UsuarioModifico).HasMaxLength(50);
            });

            modelBuilder.Entity<TPaTiposDeVariables>(entity =>
            {
                entity.HasKey(e => e.IdTipoVariable);

                entity.ToTable("T_Pa_TiposDeVariables");

                entity.Property(e => e.IdTipoVariable).ValueGeneratedNever();

                entity.Property(e => e.Acumulador)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.AcumuladorGeneral)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Busqueda)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Calculo)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Constante)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.Property(e => e.Entrada)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SubDetalle)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioCreacion).HasMaxLength(50);

                entity.Property(e => e.UsuarioModifico).HasMaxLength(50);
            });

            modelBuilder.Entity<TPaTroqueles>(entity =>
            {
                entity.HasKey(e => new { e.Prefijo, e.Numero, e.Sufijo, e.CantidadXAnch });

                entity.ToTable("T_Pa_Troqueles");

                entity.Property(e => e.Prefijo)
                    .HasColumnName("PREFIJO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Numero)
                    .HasColumnName("NUMERO")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.Sufijo)
                    .HasColumnName("SUFIJO")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CantidadXAnch)
                    .HasColumnName("CANTIDAD_X_ANCH")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.CantidadXLarg)
                    .HasColumnName("CANTIDAD_X_LARG")
                    .HasColumnType("decimal(4, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EtiquetaAncho)
                    .HasColumnName("ETIQUETA_ANCHO")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EtiquetaLargo)
                    .HasColumnName("ETIQUETA_LARGO")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EtiquetaXVuel)
                    .HasColumnName("ETIQUETA_X_VUEL")
                    .HasColumnType("decimal(4, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LinerAnchoDob)
                    .HasColumnName("LINER_ANCHO_DOB")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LinerAnchoRol)
                    .HasColumnName("LINER_ANCHO_ROL")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LinerLargo)
                    .HasColumnName("LINER_LARGO")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nodisponible)
                    .HasColumnName("NODISPONIBLE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RecordNumber)
                    .HasColumnName("RECORD_NUMBER")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TPaVariables>(entity =>
            {
                entity.HasKey(e => e.IdVariables);

                entity.ToTable("T_Pa_Variables");

                entity.HasIndex(e => new { e.IdVariables, e.AfectaMc })
                    .HasName("IX_T_Pa_Variables");

                entity.Property(e => e.IdVariables).HasMaxLength(20);

                entity.Property(e => e.AfectaCostoPororden).HasMaxLength(1);

                entity.Property(e => e.AfectaMc)
                    .HasColumnName("AfectaMC")
                    .HasMaxLength(1);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.General)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IgualEnCombinacion).HasMaxLength(1);

                entity.Property(e => e.NombreVariable).HasMaxLength(100);

                entity.Property(e => e.TipoDato).HasMaxLength(25);

                entity.Property(e => e.UsuarioCreacion).HasMaxLength(50);

                entity.Property(e => e.UsuarioModifico).HasMaxLength(50);

                entity.HasOne(d => d.IdTipoVariableNavigation)
                    .WithMany(p => p.TPaVariables)
                    .HasForeignKey(d => d.IdTipoVariable)
                    .HasConstraintName("FK_T_Pa_Variables_T_Pa_TiposDeVariables");
            });

            modelBuilder.Entity<TPaVariablesReporte>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_Pa_VariablesReporte");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Nombre).HasMaxLength(50);

                entity.Property(e => e.Orden).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Variable).HasMaxLength(20);

                entity.Property(e => e.VariablePadre).HasMaxLength(20);
            });

            modelBuilder.Entity<TPrCalculo>(entity =>
            {
                entity.HasKey(e => new { e.IdSolicitud, e.LineaNegocio, e.IdVariables, e.Item });

                entity.ToTable("T_Pr_Calculo");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_T_Pr_Calculo_1");

                entity.HasIndex(e => e.IdSolicitud)
                    .HasName("IX_T_Pr_Calculo");

                entity.HasIndex(e => new { e.IdSolicitud, e.IdVariables })
                    .HasName("IX_T_Pr_Calculo_3");

                entity.HasIndex(e => new { e.IdSolicitud, e.LineaNegocio })
                    .HasName("IX_T_Pr_Calculo_2");

                entity.Property(e => e.IdSolicitud).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdVariables).HasMaxLength(20);

                entity.Property(e => e.Calculo).HasMaxLength(1);

                entity.Property(e => e.DescripcionFormula).HasMaxLength(4000);

                entity.Property(e => e.Formula).HasMaxLength(4000);

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Orden).HasMaxLength(20);

                entity.Property(e => e.OrdenCalculo).HasColumnType("numeric(18, 1)");

                entity.Property(e => e.Producto).HasMaxLength(12);

                entity.Property(e => e.Qry).HasMaxLength(4000);

                entity.Property(e => e.TiempoEjecucion).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Valor).HasColumnType("numeric(20, 4)");
            });

            modelBuilder.Entity<TPrIdCalculo>(entity =>
            {
                entity.HasKey(e => e.IdSolicitud);

                entity.ToTable("T_Pr_IdCalculo");

                entity.Property(e => e.IdSolicitud).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Valor)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TPrPendienteCalculo>(entity =>
            {
                entity.ToTable("T_Pr_PendienteCalculo");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Culminado)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Fin).HasColumnType("smalldatetime");

                entity.Property(e => e.Inicio)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TPrRecnumCalcularEmbarques>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_Pr_RecnumCalcularEmbarques");

                entity.HasIndex(e => e.Transaccion)
                    .HasName("IX_T_Pr_RecnumCalcularEmbarques");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Recnum).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Transaccion).HasMaxLength(2);
            });

            modelBuilder.Entity<TSaCalculoHistorico>(entity =>
            {
                entity.HasKey(e => new { e.IdSolicitud, e.LineaNegocio, e.IdVariables, e.Item });

                entity.ToTable("T_Sa_CalculoHistorico");

                entity.HasIndex(e => e.FechaCalculo)
                    .HasName("IX_T_Sa_CalculoHistorico_3");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_T_Sa_CalculoHistoricoID");

                entity.HasIndex(e => e.IdSolicitud)
                    .HasName("IX_T_Sa_CalculoHistorico");

                entity.HasIndex(e => e.LineaNegocio)
                    .HasName("IDX_LineaNegocioT_Sa_CalculoHistorico");

                entity.HasIndex(e => e.Orden)
                    .HasName("IX_T_Sa_CalculoHistorico_2");

                entity.HasIndex(e => new { e.IdSolicitud, e.IdVariables })
                    .HasName("IX_T_Sa_CalculoHistorico_1");

                entity.HasIndex(e => new { e.Valor, e.IdSolicitud, e.IdVariables, e.LineaNegocio, e.Item })
                    .HasName("_dta_index_T_Sa_CalculoHistorico_36_674101442__K2_K4_K3_K5_8");

                entity.Property(e => e.IdSolicitud).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdVariables).HasMaxLength(20);

                entity.Property(e => e.DescripcionFormula).HasMaxLength(4000);

                entity.Property(e => e.FechaCalculo)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Formula).HasMaxLength(4000);

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Orden).HasMaxLength(20);

                entity.Property(e => e.OrdenCalculo).HasColumnType("numeric(18, 1)");

                entity.Property(e => e.Producto).HasMaxLength(12);

                entity.Property(e => e.Qry).HasMaxLength(4000);

                entity.Property(e => e.TiempoEjecucion).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Valor).HasColumnType("numeric(20, 4)");
            });

            modelBuilder.Entity<TSaCalculoHistoricoGeneral>(entity =>
            {
                entity.HasKey(e => new { e.IdSolicitud, e.LineaNegocio, e.IdVariables, e.Item });

                entity.ToTable("T_Sa_CalculoHistoricoGeneral");

                entity.HasIndex(e => e.FechaCalculo)
                    .HasName("IX_T_Sa_CalculoHistoricoGeneral_1");

                entity.HasIndex(e => e.IdSolicitud)
                    .HasName("IX_T_Sa_CalculoHistoricoGeneral");

                entity.HasIndex(e => e.Orden)
                    .HasName("IX_T_Sa_CalculoHistorico_2General");

                entity.HasIndex(e => new { e.IdSolicitud, e.IdVariables })
                    .HasName("IX_T_Sa_CalculoHistorico_1General");

                entity.HasIndex(e => new { e.Valor, e.IdVariables, e.IdSolicitud })
                    .HasName("_dta_index_T_Sa_CalculoHistorico_26_674101442__K4_K2_8General");

                entity.Property(e => e.IdSolicitud).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdVariables).HasMaxLength(20);

                entity.Property(e => e.DescripcionFormula).HasMaxLength(4000);

                entity.Property(e => e.FechaCalculo)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Formula).HasMaxLength(4000);

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Orden).HasMaxLength(20);

                entity.Property(e => e.OrdenCalculo).HasColumnType("numeric(18, 1)");

                entity.Property(e => e.Producto).HasMaxLength(12);

                entity.Property(e => e.Qry).HasMaxLength(4000);

                entity.Property(e => e.Valor).HasColumnType("numeric(18, 4)");
            });

            modelBuilder.Entity<TSaEntradasHistorico>(entity =>
            {
                entity.HasKey(e => new { e.IdSolicitud, e.LineaNegocio, e.IdVariables, e.Item });

                entity.ToTable("T_Sa_EntradasHistorico");

                entity.HasIndex(e => e.FechaCalculo)
                    .HasName("IX_T_Sa_EntradasHistorico_4");

                entity.HasIndex(e => e.IdSolicitud)
                    .HasName("IX_T_Sa_EntradasHistorico");

                entity.HasIndex(e => e.IdVariables)
                    .HasName("IX_T_Sa_EntradasHistorico_1");

                entity.HasIndex(e => e.LineaNegocio)
                    .HasName("IDX_LineaNegocioT_Sa_EntradasHistorico");

                entity.HasIndex(e => e.Orden)
                    .HasName("IX_T_Sa_EntradasHistorico_3");

                entity.HasIndex(e => new { e.IdSolicitud, e.IdVariables })
                    .HasName("IX_T_Sa_EntradasHistorico_2");

                entity.Property(e => e.IdSolicitud).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdVariables).HasMaxLength(20);

                entity.Property(e => e.FechaCalculo)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FuncionDeBusqueda).HasMaxLength(500);

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Orden).HasMaxLength(20);

                entity.Property(e => e.Producto).HasMaxLength(12);

                entity.Property(e => e.Valor).HasMaxLength(150);
            });

            modelBuilder.Entity<TSaEntradasHistoricoGeneral>(entity =>
            {
                entity.HasKey(e => new { e.IdSolicitud, e.LineaNegocio, e.IdVariables, e.Item });

                entity.ToTable("T_Sa_EntradasHistoricoGeneral");

                entity.HasIndex(e => e.FechaCalculo)
                    .HasName("IX_T_Sa_EntradasHistoricoGeneral_1");

                entity.HasIndex(e => e.IdSolicitud)
                    .HasName("IX_T_Sa_EntradasHistoricoGeneral");

                entity.HasIndex(e => e.IdVariables)
                    .HasName("IX_T_Sa_EntradasHistorico_1General");

                entity.HasIndex(e => e.Orden)
                    .HasName("IX_T_Sa_EntradasHistorico_3General");

                entity.HasIndex(e => new { e.IdSolicitud, e.IdVariables })
                    .HasName("IX_T_Sa_EntradasHistorico_2General");

                entity.Property(e => e.IdSolicitud).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdVariables).HasMaxLength(20);

                entity.Property(e => e.FechaCalculo)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FuncionDeBusqueda).HasMaxLength(500);

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Orden).HasMaxLength(20);

                entity.Property(e => e.Producto).HasMaxLength(12);

                entity.Property(e => e.Valor).HasMaxLength(50);
            });

            modelBuilder.Entity<TSaEstadisticaPapelEmbarques>(entity =>
            {
                entity.HasKey(e => new { e.LineaNegocio, e.IdVariables, e.IdSolicitud, e.Item });

                entity.ToTable("T_Sa_EstadisticaPapelEmbarques");

                entity.HasIndex(e => e.AñoMes)
                    .HasName("IX_T_Sa_EstadisticaPapelEmbarques");

                entity.HasIndex(e => e.IdVariables)
                    .HasName("IX_T_Sa_EstadisticaPapelEmbarques_2");

                entity.HasIndex(e => e.Orden)
                    .HasName("dep_T_Sa_EstadisticaPapelEmbarquesorden");

                entity.HasIndex(e => new { e.Año, e.Mes })
                    .HasName("IX_T_Sa_EstadisticaPapelEmbarques_1");

                entity.Property(e => e.IdVariables).HasMaxLength(20);

                entity.Property(e => e.IdSolicitud).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Articulo)
                    .HasMaxLength(25)
                    .IsFixedLength();

                entity.Property(e => e.Año).HasColumnType("numeric(4, 0)");

                entity.Property(e => e.AñoMes).HasColumnType("numeric(6, 0)");

                entity.Property(e => e.BsKg).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Cantidad).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Categoria).HasMaxLength(50);

                entity.Property(e => e.CostoPapel).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DescripcionGenero).HasMaxLength(50);

                entity.Property(e => e.Factura).HasColumnType("numeric(10, 0)");

                entity.Property(e => e.Genero).HasMaxLength(1);

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Kg).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Mes).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Orden).HasColumnType("numeric(10, 0)");

                entity.Property(e => e.Origen).HasMaxLength(50);

                entity.Property(e => e.Papel).HasMaxLength(25);

                entity.Property(e => e.Producto).HasMaxLength(25);

                entity.Property(e => e.SubCategoria).HasMaxLength(50);

                entity.Property(e => e.TotalCosto).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.TotalKg).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Venta).HasColumnType("numeric(18, 4)");
            });

            modelBuilder.Entity<TSaHistoricoCalculoCosto>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_Sa_HistoricoCalculoCosto");

                entity.HasIndex(e => e.OrdenProduccion)
                    .HasName("dep_T_Sa_HistoricoCalculoCostoOrdenProduccion");

                entity.HasIndex(e => e.RecnumAuxiliar)
                    .HasName("IX_T_Sa_HistoricoCalculoCosto");

                entity.HasIndex(e => new { e.AñoDocumento, e.MesDocumento })
                    .HasName("IX_T_Sa_HistoricoCalculoCosto_1");

                entity.HasIndex(e => new { e.RecnumAuxiliar, e.Variable })
                    .HasName("IX_T_Sa_HistoricoCalculoCosto_2");

                entity.HasIndex(e => new { e.Transaccion, e.RecnumAuxiliar })
                    .HasName("IX_T_Sa_HistoricoCalculoCosto_3");

                entity.HasIndex(e => new { e.Transaccion, e.RecnumAuxiliar, e.Variable })
                    .HasName("IX_T_Sa_HistoricoCalculoCosto_4");

                entity.Property(e => e.AñoCosto).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AñoDocumento).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DescripcionCategoria).HasMaxLength(50);

                entity.Property(e => e.DescripcionSubcategoria).HasMaxLength(50);

                entity.Property(e => e.Documento).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdSolicitud).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MesCosto).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MesDocumento).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Monto)
                    .HasColumnType("numeric(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Nombre).HasMaxLength(50);

                entity.Property(e => e.NombreCliente).HasMaxLength(80);

                entity.Property(e => e.Orden).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.OrdenProduccion).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Producto).HasMaxLength(12);

                entity.Property(e => e.RecnumAuxiliar).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Signo).HasDefaultValueSql("((1))");

                entity.Property(e => e.Transaccion).HasMaxLength(2);

                entity.Property(e => e.Variable).HasMaxLength(20);

                entity.Property(e => e.VariablePadre).HasMaxLength(20);
            });

            modelBuilder.Entity<TSaHistoricoDeMensajesPorIdCalculo>(entity =>
            {
                entity.HasKey(e => new { e.IdSolicitud, e.Orden });

                entity.ToTable("T_Sa_HistoricoDeMensajesPorIdCalculo");

                entity.HasIndex(e => e.IdSolicitud)
                    .HasName("IX_T_Sa_HistoricoDeMensajesPorIdCalculo_1");

                entity.HasIndex(e => e.Orden)
                    .HasName("IX_T_Sa_HistoricoDeMensajesPorIdCalculo");

                entity.HasIndex(e => e.TipoProceso)
                    .HasName("IX_T_Sa_HistoricoDeMensajesPorIdCalculo_2");

                entity.Property(e => e.IdSolicitud).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Orden).HasMaxLength(20);

                entity.Property(e => e.Fecha).HasColumnType("smalldatetime");

                entity.Property(e => e.Mensaje).HasMaxLength(2000);

                entity.Property(e => e.TipoProceso).HasMaxLength(50);
            });

            modelBuilder.Entity<TSaPlantillaReporteAnalisisCredito>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_Sa_PlantillaReporteAnalisisCredito");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdVariablePadre).HasMaxLength(20);

                entity.Property(e => e.Idvariables).HasMaxLength(20);

                entity.Property(e => e.LineaReporte).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.NombreVariable).HasMaxLength(100);

                entity.Property(e => e.Titulo).HasMaxLength(1);
            });

            modelBuilder.Entity<TSaReporteAnalisisCredito>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_Sa_ReporteAnalisisCredito");

                entity.HasIndex(e => e.IdSolicitud)
                    .HasName("IX_Sa_ReporteAnalisisCredito");

                entity.HasIndex(e => new { e.IdSolicitud, e.LineaReporte })
                    .HasName("IX_Sa_ReporteAnalisisCredito_1");

                entity.Property(e => e.Cotizacion).HasMaxLength(13);

                entity.Property(e => e.FechaRegistro).HasColumnType("smalldatetime");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdSolicitud).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdvariablePadre).HasMaxLength(20);

                entity.Property(e => e.Idvariables).HasMaxLength(20);

                entity.Property(e => e.LineaReporte).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.NombreVariable).HasMaxLength(100);

                entity.Property(e => e.Titulo).HasMaxLength(1);

                entity.Property(e => e.Valor).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
