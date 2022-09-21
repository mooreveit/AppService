using System;
using AppService.Core.EntitiesClientes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AppService.Infrastructure.DataClientes
{
    public partial class ClientesContext : DbContext
    {
        public ClientesContext()
        {
        }

        public ClientesContext(DbContextOptions<ClientesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ActLimiteCred> ActLimiteCred { get; set; }
        public virtual DbSet<Analisis> Analisis { get; set; }
        public virtual DbSet<Asignacion> Asignacion { get; set; }
        public virtual DbSet<Asignacion1> Asignacion1 { get; set; }
        public virtual DbSet<BarridoAsig> BarridoAsig { get; set; }
        public virtual DbSet<Cambioasigbar> Cambioasigbar { get; set; }
        public virtual DbSet<Cambioasigptolacruz> Cambioasigptolacruz { get; set; }
        public virtual DbSet<Cambioasigptoordaz> Cambioasigptoordaz { get; set; }
        public virtual DbSet<Cambioasigsc> Cambioasigsc { get; set; }
        public virtual DbSet<Cambioasigval> Cambioasigval { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<ClientesInactivos2010> ClientesInactivos2010 { get; set; }
        public virtual DbSet<ClientesInactivosFinCrm> ClientesInactivosFinCrm { get; set; }
        public virtual DbSet<ClientesMaracaibo> ClientesMaracaibo { get; set; }
        public virtual DbSet<ClientesVe> ClientesVe { get; set; }
        public virtual DbSet<ComparativoClientesMaracay> ComparativoClientesMaracay { get; set; }
        public virtual DbSet<ConsultaContactos> ConsultaContactos { get; set; }
        public virtual DbSet<ConsultaDirecciones> ConsultaDirecciones { get; set; }
        public virtual DbSet<ConsultaWmsy270> ConsultaWmsy270 { get; set; }
        public virtual DbSet<ConsultaWsmy265> ConsultaWsmy265 { get; set; }
        public virtual DbSet<ConsultaWsmy266> ConsultaWsmy266 { get; set; }
        public virtual DbSet<ConsultaWsmy267> ConsultaWsmy267 { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<ContactoProspecto> ContactoProspecto { get; set; }
        public virtual DbSet<CorrelativoProspecto> CorrelativoProspecto { get; set; }
        public virtual DbSet<Csmy003> Csmy003 { get; set; }
        public virtual DbSet<Csmy0031> Csmy0031 { get; set; }
        public virtual DbSet<Csmy177> Csmy177 { get; set; }
        public virtual DbSet<DatosAdjuntos> DatosAdjuntos { get; set; }
        public virtual DbSet<DfCsmy0031> DfCsmy0031 { get; set; }
        public virtual DbSet<DfWsmy003> DfWsmy003 { get; set; }
        public virtual DbSet<Duplicados> Duplicados { get; set; }
        public virtual DbSet<Duplicados2> Duplicados2 { get; set; }
        public virtual DbSet<EmpleadosVe> EmpleadosVe { get; set; }
        public virtual DbSet<FechaAperturaClientes> FechaAperturaClientes { get; set; }
        public virtual DbSet<InactivacionAgo2012> InactivacionAgo2012 { get; set; }
        public virtual DbSet<JdeProveedoresImpuesto> JdeProveedoresImpuesto { get; set; }
        public virtual DbSet<LimiteCreditoxCliente01> LimiteCreditoxCliente01 { get; set; }
        public virtual DbSet<LimiteCreditoxCliente02> LimiteCreditoxCliente02 { get; set; }
        public virtual DbSet<LogicoCsmy003> LogicoCsmy003 { get; set; }
        public virtual DbSet<OficianasValidarParroquia> OficianasValidarParroquia { get; set; }
        public virtual DbSet<ParaActualizarElContacto1> ParaActualizarElContacto1 { get; set; }
        public virtual DbSet<ParaActualizarElContacto2> ParaActualizarElContacto2 { get; set; }
        public virtual DbSet<ParaActualizarElContacto3> ParaActualizarElContacto3 { get; set; }
        public virtual DbSet<Paseclientes> Paseclientes { get; set; }
        public virtual DbSet<Pasejde> Pasejde { get; set; }
        public virtual DbSet<PlanillaDeActualizacion> PlanillaDeActualizacion { get; set; }
        public virtual DbSet<Proveedores> Proveedores { get; set; }
        public virtual DbSet<QueryCsmy00302> QueryCsmy00302 { get; set; }
        public virtual DbSet<QueryCsmy00303> QueryCsmy00303 { get; set; }
        public virtual DbSet<QueryCsmy00304> QueryCsmy00304 { get; set; }
        public virtual DbSet<QueryWsmy06501> QueryWsmy06501 { get; set; }
        public virtual DbSet<RamoWeb> RamoWeb { get; set; }
        public virtual DbSet<RifAsociadoProspecto> RifAsociadoProspecto { get; set; }
        public virtual DbSet<SapFuncionesInterlocutor> SapFuncionesInterlocutor { get; set; }
        public virtual DbSet<SectorWeb> SectorWeb { get; set; }
        public virtual DbSet<TipoRif> TipoRif { get; set; }
        public virtual DbSet<VClientesFaltantes> VClientesFaltantes { get; set; }
        public virtual DbSet<VDiccionarioclientes> VDiccionarioclientes { get; set; }
        public virtual DbSet<VDiferentesf010131> VDiferentesf010131 { get; set; }
        public virtual DbSet<VDireccionesComerciales> VDireccionesComerciales { get; set; }
        public virtual DbSet<VRepetidos> VRepetidos { get; set; }
        public virtual DbSet<VResumenEmail> VResumenEmail { get; set; }
        public virtual DbSet<VResumenEmailCarta2> VResumenEmailCarta2 { get; set; }
        public virtual DbSet<View1> View1 { get; set; }
        public virtual DbSet<View2> View2 { get; set; }
        public virtual DbSet<View3> View3 { get; set; }
        public virtual DbSet<VistaClienteVendedores> VistaClienteVendedores { get; set; }
        public virtual DbSet<Winy242> Winy242 { get; set; }
        public virtual DbSet<Winy243> Winy243 { get; set; }
        public virtual DbSet<Wsmy0032> Wsmy0032 { get; set; }
        public virtual DbSet<Wsmy003a> Wsmy003a { get; set; }
        public virtual DbSet<Wsmy063> Wsmy063 { get; set; }
        public virtual DbSet<Wsmy063Consulta> Wsmy063Consulta { get; set; }
        public virtual DbSet<Wsmy064> Wsmy064 { get; set; }
        public virtual DbSet<Wsmy065> Wsmy065 { get; set; }
        public virtual DbSet<Wsmy264> Wsmy264 { get; set; }
        public virtual DbSet<Wsmy26410122015> Wsmy26410122015 { get; set; }
        public virtual DbSet<Wsmy264IdDuplicados> Wsmy264IdDuplicados { get; set; }
        public virtual DbSet<Wsmy264Temp> Wsmy264Temp { get; set; }
        public virtual DbSet<Wsmy265> Wsmy265 { get; set; }
        public virtual DbSet<Wsmy266> Wsmy266 { get; set; }
        public virtual DbSet<Wsmy267> Wsmy267 { get; set; }
        public virtual DbSet<Wsmy269> Wsmy269 { get; set; }
        public virtual DbSet<Wsmy270> Wsmy270 { get; set; }
        public virtual DbSet<Wsmy271> Wsmy271 { get; set; }
        public virtual DbSet<Wsmy272> Wsmy272 { get; set; }
        public virtual DbSet<Wsmy274> Wsmy274 { get; set; }
        public virtual DbSet<Wsmy275> Wsmy275 { get; set; }
        public virtual DbSet<Wsmy276> Wsmy276 { get; set; }
        public virtual DbSet<Wsmy277> Wsmy277 { get; set; }
        public virtual DbSet<Wsmy278> Wsmy278 { get; set; }
        public virtual DbSet<Wsmy279> Wsmy279 { get; set; }
        public virtual DbSet<Wsmy280> Wsmy280 { get; set; }
        public virtual DbSet<Wsmy281> Wsmy281 { get; set; }
        public virtual DbSet<Wsmy282> Wsmy282 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=Clientes;User Id=userweb;Password=userweb2003;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActLimiteCred>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CodigoJde)
                    .HasColumnName("CodigoJDE")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.LimiteCredito).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Analisis>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Analisis");

                entity.Property(e => e.AO)
                    .HasColumnName("A#O")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.Afectanota)
                    .HasColumnName("AFECTANOTA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Anticipo)
                    .HasColumnName("ANTICIPO")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.AsigActual)
                    .HasColumnName("ASIG_ACTUAL")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.Banco)
                    .HasColumnName("BANCO")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cambio)
                    .HasColumnName("CAMBIO")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Ciudad)
                    .HasColumnName("CIUDAD")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cliente)
                    .HasColumnName("CLIENTE")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Cobrador)
                    .HasColumnName("COBRADOR")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodContrapart)
                    .HasColumnName("COD_CONTRAPART")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodMoore)
                    .HasColumnName("COD_MOORE")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Comisionpagada)
                    .HasColumnName("COMISIONPAGADA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CompLinea)
                    .HasColumnName("COMP_LINEA")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.Comprobante)
                    .HasColumnName("COMPROBANTE")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.Concepto)
                    .HasColumnName("CONCEPTO")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CondPago)
                    .HasColumnName("COND_PAGO")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Contabilizado)
                    .HasColumnName("CONTABILIZADO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cotizacion)
                    .HasColumnName("COTIZACION")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CuentaEfecto)
                    .HasColumnName("CUENTA_EFECTO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Dias)
                    .HasColumnName("DIAS")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.DiasEntrega)
                    .HasColumnName("DIAS_ENTREGA")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Diferencial)
                    .HasColumnName("DIFERENCIAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DocCanc)
                    .HasColumnName("DOC_CANC")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Documento)
                    .HasColumnName("DOCUMENTO")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Eliminar)
                    .HasColumnName("ELIMINAR")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Facdoc)
                    .HasColumnName("FACDOC")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaCobro)
                    .HasColumnName("FECHA_COBRO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaEmision)
                    .HasColumnName("FECHA_EMISION")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaEntrega)
                    .HasColumnName("FECHA_ENTREGA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnName("FECHA_INGRESO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaPlanilla)
                    .HasColumnName("FECHA_PLANILLA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaUsuario)
                    .HasColumnName("FECHA_USUARIO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaVcto)
                    .HasColumnName("FECHA_VCTO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Grupo)
                    .HasColumnName("GRUPO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GrupoActual)
                    .HasColumnName("GRUPO_ACTUAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HoraUsario)
                    .HasColumnName("HORA_USARIO")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.InformeQueja)
                    .HasColumnName("INFORME_QUEJA")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.LinCanc)
                    .HasColumnName("LIN_CANC")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.Linea)
                    .HasColumnName("LINEA")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.Lote)
                    .HasColumnName("LOTE")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Matriz)
                    .HasColumnName("MATRIZ")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Mes)
                    .HasColumnName("MES")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.MinutosUsuario)
                    .HasColumnName("MINUTOS_USUARIO")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Moneda)
                    .HasColumnName("MONEDA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Monto)
                    .HasColumnName("MONTO")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.MontoDolar)
                    .HasColumnName("MONTO_DOLAR")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.MontoMoneda)
                    .HasColumnName("MONTO_MONEDA")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.NoTieneDebe)
                    .HasColumnName("NO_TIENE_DEBE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NroPlanilla)
                    .HasColumnName("NRO_PLANILLA")
                    .HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Observacion1)
                    .HasColumnName("OBSERVACION1")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Observacion2)
                    .HasColumnName("OBSERVACION2")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Orden)
                    .HasColumnName("ORDEN")
                    .HasColumnType("decimal(10, 0)");

                entity.Property(e => e.PasoSql)
                    .HasColumnName("PASO_SQL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PlantaOficina)
                    .HasColumnName("PLANTA_OFICINA")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.PorIva)
                    .HasColumnName("POR_IVA")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Recalcular)
                    .HasColumnName("RECALCULAR")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RecordNumber).HasColumnName("RECORD_NUMBER");

                entity.Property(e => e.Referencia)
                    .HasColumnName("REFERENCIA")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Region)
                    .HasColumnName("REGION")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RegionActual)
                    .HasColumnName("REGION_ACTUAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RelacionCobro)
                    .HasColumnName("RELACION_COBRO")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Remisionma)
                    .HasColumnName("REMISIONMA")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Remisionsi)
                    .HasColumnName("REMISIONSI")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Saldo)
                    .HasColumnName("SALDO")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.SaldoDolar)
                    .HasColumnName("SALDO_DOLAR")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Supervisor)
                    .HasColumnName("SUPERVISOR")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TasaCambio)
                    .HasColumnName("TASA_CAMBIO")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Tipo)
                    .HasColumnName("TIPO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoCanc)
                    .HasColumnName("TIPO_CANC")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoCiudad)
                    .HasColumnName("TIPO_CIUDAD")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoCompania)
                    .HasColumnName("TIPO_COMPANIA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Transaccion)
                    .HasColumnName("TRANSACCION")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UltimoPago)
                    .HasColumnName("ULTIMO_PAGO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Usuario)
                    .HasColumnName("USUARIO")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VecesCobro)
                    .HasColumnName("VECES_COBRO")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.Vendedor)
                    .HasColumnName("VENDEDOR")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Zona)
                    .HasColumnName("ZONA")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Asignacion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ASIGNACION");

                entity.Property(e => e.AsignacionActual).HasColumnName("ASIGNACION_ACTUAL");

                entity.Property(e => e.AsignacionNueva).HasColumnName("ASIGNACION_NUEVA");

                entity.Property(e => e.Codigo)
                    .HasColumnName("CODIGO")
                    .HasMaxLength(255);

                entity.Property(e => e.Nombre)
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(255);

                entity.Property(e => e.Oficina).HasColumnName("OFICINA");
            });

            modelBuilder.Entity<Asignacion1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("asignacion1");

                entity.Property(e => e.AsignacionActual).HasColumnName("ASIGNACION_ACTUAL");

                entity.Property(e => e.AsignacionNueva).HasColumnName("ASIGNACION_NUEVA");

                entity.Property(e => e.Codigo)
                    .HasColumnName("CODIGO")
                    .HasMaxLength(255);

                entity.Property(e => e.Nombre)
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(255);

                entity.Property(e => e.Oficina)
                    .HasColumnName("OFICINA")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<BarridoAsig>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("barrido_asig");

                entity.Property(e => e.Asignacion)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AsignacionActual)
                    .HasColumnName("ASIGNACION_ACTUAL")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cobrador)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CobradorActual)
                    .HasColumnName("COBRADOR_ACTUAL")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoActual)
                    .HasColumnName("CODIGO_ACTUAL")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Diferente).HasColumnName("diferente");

                entity.Property(e => e.Monto)
                    .HasColumnName("MONTO")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Saldo)
                    .HasColumnName("SALDO")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Vendedor1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VendedorActual)
                    .HasColumnName("VENDEDOR_ACTUAL")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Cambioasigbar>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CAMBIOASIGBAR");

                entity.Property(e => e.AreaCobranz)
                    .HasColumnName("Area_Cobranz")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Asignacion)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Categoria)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CierreEjerc)
                    .HasColumnName("CIERRE_EJERC")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ClientContado)
                    .HasColumnName("Client_Contado")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClienteNuevo)
                    .HasColumnName("Cliente_Nuevo")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cobrador)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodMcpo)
                    .HasColumnName("Cod_Mcpo")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodProveedor)
                    .HasColumnName("Cod_Proveedor")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodSubSegmento)
                    .HasColumnName("Cod_SubSegmento")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoCiudad)
                    .HasColumnName("Codigo_Ciudad")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoEstado)
                    .HasColumnName("Codigo_Estado")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoMcpo)
                    .HasColumnName("Codigo_Mcpo")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoParroq)
                    .HasColumnName("Codigo_Parroq")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoPostal)
                    .HasColumnName("Codigo_Postal")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoRegion)
                    .HasColumnName("Codigo_Region")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CondPago)
                    .HasColumnName("COND_PAGO")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ContCarg1)
                    .HasColumnName("Cont_Carg_1")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContCarg2)
                    .HasColumnName("Cont_Carg_2")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContCarg3)
                    .HasColumnName("Cont_Carg_3")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContEmail1)
                    .HasColumnName("Cont_Email_1")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContEmail2)
                    .HasColumnName("Cont_Email_2")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContEmail3)
                    .HasColumnName("Cont_Email_3")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContEspecial)
                    .HasColumnName("Cont_Especial")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContFechNacm1)
                    .HasColumnName("Cont_FechNacm_1")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ContFechNacm2)
                    .HasColumnName("Cont_FechNacm_2")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ContFechNacm3)
                    .HasColumnName("Cont_FechNacm_3")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ContNomb1)
                    .HasColumnName("Cont_Nomb_1")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContNomb2)
                    .HasColumnName("Cont_Nomb_2")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContNomb3)
                    .HasColumnName("Cont_Nomb_3")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContTelf1)
                    .HasColumnName("Cont_Telf_1")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContTelf2)
                    .HasColumnName("Cont_Telf_2")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContTelf3)
                    .HasColumnName("Cont_Telf_3")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DepuraCod)
                    .HasColumnName("DEPURA_COD")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DiaDeCobro)
                    .HasColumnName("Dia_de_Cobro")
                    .HasMaxLength(10)
                    .IsUnicode(false)
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
                    .HasColumnName("E_mail_Client")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ExentoDeImpuesto)
                    .HasColumnName("Exento_de_Impuesto")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FApertura)
                    .HasColumnName("F_Apertura")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FModificacion)
                    .HasColumnName("F_Modificacion")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FUltmCompra)
                    .HasColumnName("F_Ultm_Compra")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Fax)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaCerrado)
                    .HasColumnName("Fecha_Cerrado")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaInactivo)
                    .HasColumnName("Fecha_Inactivo")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaLegal)
                    .HasColumnName("FECHA_LEGAL")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaReactivado)
                    .HasColumnName("Fecha_Reactivado")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaRiesgo)
                    .HasColumnName("FECHA_RIESGO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FlagCerrado)
                    .HasColumnName("Flag_Cerrado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagInactivo)
                    .HasColumnName("Flag_Inactivo")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagMat)
                    .HasColumnName("Flag_Mat")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagMod03)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagModificado)
                    .HasColumnName("Flag_Modificado")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagNuevo)
                    .HasColumnName("Flag_Nuevo")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GiroNegocio)
                    .HasColumnName("Giro_Negocio")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Grupo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LCredito)
                    .HasColumnName("L_Credito")
                    .HasColumnType("money");

                entity.Property(e => e.Legal)
                    .HasColumnName("LEGAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LimiteCredUt)
                    .HasColumnName("Limite_Cred_Ut")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Nit)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NoRegTribut)
                    .HasColumnName("No_Reg_Tribut")
                    .HasMaxLength(12)
                    .IsUnicode(false)
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
                    .HasColumnName("Oficina_Venta")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrdenCompra)
                    .HasColumnName("Orden_Compra")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PaginaWeb)
                    .HasColumnName("Pagina_Web")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RepresLegal)
                    .HasColumnName("Repres_Legal")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Riesgo)
                    .HasColumnName("RIESGO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RutCartero)
                    .HasColumnName("Rut_Cartero")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Segmento)
                    .HasMaxLength(10)
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
                    .HasColumnName("Tipo_Negocio")
                    .HasMaxLength(10)
                    .IsUnicode(false)
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

            modelBuilder.Entity<Cambioasigptolacruz>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CAMBIOASIGPTOLACRUZ");

                entity.Property(e => e.AsignacionActual).HasColumnName("ASIGNACION_ACTUAL");

                entity.Property(e => e.AsignacionNueva).HasColumnName("ASIGNACION_NUEVA");

                entity.Property(e => e.Codigo)
                    .HasColumnName("CODIGO")
                    .HasMaxLength(255);

                entity.Property(e => e.Nombre)
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(255);

                entity.Property(e => e.Oficina).HasColumnName("OFICINA");
            });

            modelBuilder.Entity<Cambioasigptoordaz>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CAMBIOASIGPTOORDAZ");

                entity.Property(e => e.AsignacionActual).HasColumnName("ASIGNACION_ACTUAL");

                entity.Property(e => e.AsignacionNueva).HasColumnName("ASIGNACION_NUEVA");

                entity.Property(e => e.Codigo)
                    .HasColumnName("CODIGO")
                    .HasMaxLength(255);

                entity.Property(e => e.Nombre)
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(255);

                entity.Property(e => e.Oficina).HasColumnName("OFICINA");
            });

            modelBuilder.Entity<Cambioasigsc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CAMBIOASIGSC");

                entity.Property(e => e.AreaCobranz)
                    .HasColumnName("Area_Cobranz")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Asignacion)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Canal)
                    .HasColumnName("CANAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Categoria)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CierreEjerc)
                    .HasColumnName("CIERRE_EJERC")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ClientContado)
                    .HasColumnName("Client_Contado")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClienteNuevo)
                    .HasColumnName("Cliente_Nuevo")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cobrador)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodMcpo)
                    .HasColumnName("Cod_Mcpo")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodProveedor)
                    .HasColumnName("Cod_Proveedor")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodSubSegmento)
                    .HasColumnName("Cod_SubSegmento")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoCiudad)
                    .HasColumnName("Codigo_Ciudad")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoEstado)
                    .HasColumnName("Codigo_Estado")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoMcpo)
                    .HasColumnName("Codigo_Mcpo")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoParroq)
                    .HasColumnName("Codigo_Parroq")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoPostal)
                    .HasColumnName("Codigo_Postal")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoRegion)
                    .HasColumnName("Codigo_Region")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CondPago)
                    .HasColumnName("COND_PAGO")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ContCarg1)
                    .HasColumnName("Cont_Carg_1")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContCarg2)
                    .HasColumnName("Cont_Carg_2")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContCarg3)
                    .HasColumnName("Cont_Carg_3")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContEmail1)
                    .HasColumnName("Cont_Email_1")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContEmail2)
                    .HasColumnName("Cont_Email_2")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContEmail3)
                    .HasColumnName("Cont_Email_3")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContEspecial)
                    .HasColumnName("Cont_Especial")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContFechNacm1)
                    .HasColumnName("Cont_FechNacm_1")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ContFechNacm2)
                    .HasColumnName("Cont_FechNacm_2")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ContFechNacm3)
                    .HasColumnName("Cont_FechNacm_3")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ContNomb1)
                    .HasColumnName("Cont_Nomb_1")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContNomb2)
                    .HasColumnName("Cont_Nomb_2")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContNomb3)
                    .HasColumnName("Cont_Nomb_3")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContTelf1)
                    .HasColumnName("Cont_Telf_1")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContTelf2)
                    .HasColumnName("Cont_Telf_2")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContTelf3)
                    .HasColumnName("Cont_Telf_3")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DepuraCod)
                    .HasColumnName("DEPURA_COD")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DiaDeCobro)
                    .HasColumnName("Dia_de_Cobro")
                    .HasMaxLength(10)
                    .IsUnicode(false)
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
                    .HasColumnName("E_mail_Client")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ExentoDeImpuesto)
                    .HasColumnName("Exento_de_Impuesto")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FApertura)
                    .HasColumnName("F_Apertura")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FModificacion)
                    .HasColumnName("F_Modificacion")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FUltmCompra)
                    .HasColumnName("F_Ultm_Compra")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Fax)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaCerrado)
                    .HasColumnName("Fecha_Cerrado")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaInactivo)
                    .HasColumnName("Fecha_Inactivo")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaLegal)
                    .HasColumnName("FECHA_LEGAL")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaReactivado)
                    .HasColumnName("Fecha_Reactivado")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaRiesgo)
                    .HasColumnName("FECHA_RIESGO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FlagCerrado)
                    .HasColumnName("Flag_Cerrado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagInactivo)
                    .HasColumnName("Flag_Inactivo")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagMat)
                    .HasColumnName("Flag_Mat")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagMod03)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagModificado)
                    .HasColumnName("Flag_Modificado")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagNuevo)
                    .HasColumnName("Flag_Nuevo")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GiroNegocio)
                    .HasColumnName("Giro_Negocio")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Grupo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LCredito)
                    .HasColumnName("L_Credito")
                    .HasColumnType("money");

                entity.Property(e => e.Legal)
                    .HasColumnName("LEGAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LimiteCredUt)
                    .HasColumnName("Limite_Cred_Ut")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.Nit)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NoRegTribut)
                    .HasColumnName("No_Reg_Tribut")
                    .HasMaxLength(12)
                    .IsUnicode(false)
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
                    .HasColumnName("Oficina_Venta")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrdenCompra)
                    .HasColumnName("Orden_Compra")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PaginaWeb)
                    .HasColumnName("Pagina_Web")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RepresLegal)
                    .HasColumnName("Repres_Legal")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Riesgo)
                    .HasColumnName("RIESGO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RutCartero)
                    .HasColumnName("Rut_Cartero")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Segmento)
                    .HasMaxLength(10)
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
                    .HasColumnName("Tipo_Negocio")
                    .HasMaxLength(10)
                    .IsUnicode(false)
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

            modelBuilder.Entity<Cambioasigval>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CAMBIOASIGVAL");

                entity.Property(e => e.AreaCobranz)
                    .HasColumnName("Area_Cobranz")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Asignacion)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Categoria)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CierreEjerc)
                    .HasColumnName("CIERRE_EJERC")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ClientContado)
                    .HasColumnName("Client_Contado")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClienteNuevo)
                    .HasColumnName("Cliente_Nuevo")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cobrador)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodMcpo)
                    .HasColumnName("Cod_Mcpo")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodProveedor)
                    .HasColumnName("Cod_Proveedor")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodSubSegmento)
                    .HasColumnName("Cod_SubSegmento")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoCiudad)
                    .HasColumnName("Codigo_Ciudad")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoEstado)
                    .HasColumnName("Codigo_Estado")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoMcpo)
                    .HasColumnName("Codigo_Mcpo")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoParroq)
                    .HasColumnName("Codigo_Parroq")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoPostal)
                    .HasColumnName("Codigo_Postal")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoRegion)
                    .HasColumnName("Codigo_Region")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CondPago)
                    .HasColumnName("COND_PAGO")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ContCarg1)
                    .HasColumnName("Cont_Carg_1")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContCarg2)
                    .HasColumnName("Cont_Carg_2")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContCarg3)
                    .HasColumnName("Cont_Carg_3")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContEmail1)
                    .HasColumnName("Cont_Email_1")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContEmail2)
                    .HasColumnName("Cont_Email_2")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContEmail3)
                    .HasColumnName("Cont_Email_3")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContEspecial)
                    .HasColumnName("Cont_Especial")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContFechNacm1)
                    .HasColumnName("Cont_FechNacm_1")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ContFechNacm2)
                    .HasColumnName("Cont_FechNacm_2")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ContFechNacm3)
                    .HasColumnName("Cont_FechNacm_3")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ContNomb1)
                    .HasColumnName("Cont_Nomb_1")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContNomb2)
                    .HasColumnName("Cont_Nomb_2")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContNomb3)
                    .HasColumnName("Cont_Nomb_3")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContTelf1)
                    .HasColumnName("Cont_Telf_1")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContTelf2)
                    .HasColumnName("Cont_Telf_2")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContTelf3)
                    .HasColumnName("Cont_Telf_3")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DepuraCod)
                    .HasColumnName("DEPURA_COD")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DiaDeCobro)
                    .HasColumnName("Dia_de_Cobro")
                    .HasMaxLength(10)
                    .IsUnicode(false)
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
                    .HasColumnName("E_mail_Client")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ExentoDeImpuesto)
                    .HasColumnName("Exento_de_Impuesto")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FApertura)
                    .HasColumnName("F_Apertura")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FModificacion)
                    .HasColumnName("F_Modificacion")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FUltmCompra)
                    .HasColumnName("F_Ultm_Compra")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Fax)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaCerrado)
                    .HasColumnName("Fecha_Cerrado")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaInactivo)
                    .HasColumnName("Fecha_Inactivo")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaLegal)
                    .HasColumnName("FECHA_LEGAL")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaReactivado)
                    .HasColumnName("Fecha_Reactivado")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaRiesgo)
                    .HasColumnName("FECHA_RIESGO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FlagCerrado)
                    .HasColumnName("Flag_Cerrado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagInactivo)
                    .HasColumnName("Flag_Inactivo")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagMat)
                    .HasColumnName("Flag_Mat")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagMod03)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagModificado)
                    .HasColumnName("Flag_Modificado")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagNuevo)
                    .HasColumnName("Flag_Nuevo")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GiroNegocio)
                    .HasColumnName("Giro_Negocio")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Grupo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LCredito)
                    .HasColumnName("L_Credito")
                    .HasColumnType("money");

                entity.Property(e => e.Legal)
                    .HasColumnName("LEGAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LimiteCredUt)
                    .HasColumnName("Limite_Cred_Ut")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Nit)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NoRegTribut)
                    .HasColumnName("No_Reg_Tribut")
                    .HasMaxLength(12)
                    .IsUnicode(false)
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
                    .HasColumnName("Oficina_Venta")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrdenCompra)
                    .HasColumnName("Orden_Compra")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PaginaWeb)
                    .HasColumnName("Pagina_Web")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RepresLegal)
                    .HasColumnName("Repres_Legal")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Riesgo)
                    .HasColumnName("RIESGO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RutCartero)
                    .HasColumnName("Rut_Cartero")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Segmento)
                    .HasMaxLength(10)
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
                    .HasColumnName("Tipo_Negocio")
                    .HasMaxLength(10)
                    .IsUnicode(false)
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

            modelBuilder.Entity<Clientes>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CLIENTES");

                entity.Property(e => e.Abalky)
                    .HasColumnName("ABALKY")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Abalph)
                    .HasColumnName("ABALPH")
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.Aban8).HasColumnName("ABAN8");

                entity.Property(e => e.Abat1)
                    .HasColumnName("ABAT1")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Abtax)
                    .HasColumnName("ABTAX")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Abupmj)
                    .HasColumnName("ABUPMJ")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Aiarc)
                    .HasColumnName("AIARC")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Aitxa1)
                    .HasColumnName("AITXA1")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Aladd1)
                    .HasColumnName("ALADD1")
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.Aladd2)
                    .HasColumnName("ALADD2")
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.Aladd3)
                    .HasColumnName("ALADD3")
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.Aladd4)
                    .HasColumnName("ALADD4")
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.Aladds)
                    .HasColumnName("ALADDS")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Aladdz)
                    .HasColumnName("ALADDZ")
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.Alcoun)
                    .HasColumnName("ALCOUN")
                    .HasMaxLength(25)
                    .IsFixedLength();

                entity.Property(e => e.Alcty1)
                    .HasColumnName("ALCTY1")
                    .HasMaxLength(25)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ClientesInactivos2010>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Codigo).HasMaxLength(255);

                entity.Property(e => e.Nombre).HasMaxLength(255);

                entity.Property(e => e.Vendedor).HasMaxLength(255);
            });

            modelBuilder.Entity<ClientesInactivosFinCrm>(entity =>
            {
                entity.HasKey(e => e.IdCliente);

                entity.ToTable("ClientesInactivosFinCRM");

                entity.Property(e => e.IdCliente).HasMaxLength(10);
            });

            modelBuilder.Entity<ClientesMaracaibo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Clientes Maracaibo");

                entity.Property(e => e.Ciudad)
                    .HasColumnName("CIUDAD")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Codigo)
                    .HasColumnName("CODIGO")
                    .HasColumnType("decimal(6, 0)");

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

                entity.Property(e => e.Nombre)
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Region)
                    .HasColumnName("REGION")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Vendedor)
                    .HasColumnName("VENDEDOR")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ClientesVe>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("clientesVE");

                entity.HasIndex(e => e.Padre)
                    .HasName("IX_clientesVE")
                    .IsClustered();

                entity.Property(e => e.Apertura)
                    .HasColumnName("APERTURA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CP)
                    .HasColumnName("C#P#")
                    .HasMaxLength(255);

                entity.Property(e => e.Ciudad)
                    .HasColumnName("CIUDAD")
                    .HasMaxLength(255);

                entity.Property(e => e.Cobrador).HasColumnName("COBRADOR");

                entity.Property(e => e.Codigo).HasColumnName("CODIGO");

                entity.Property(e => e.Diasdecredito)
                    .HasColumnName("DIASDECREDITO")
                    .HasMaxLength(255);

                entity.Property(e => e.Direccion1)
                    .HasColumnName("DIRECCION1")
                    .HasMaxLength(255);

                entity.Property(e => e.Direccion2)
                    .HasColumnName("DIRECCION2")
                    .HasMaxLength(255);

                entity.Property(e => e.Direccion3)
                    .HasColumnName("DIRECCION3")
                    .HasMaxLength(255);

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasMaxLength(255);

                entity.Property(e => e.Estado1)
                    .HasColumnName("ESTADO1")
                    .HasMaxLength(255);

                entity.Property(e => e.Limite).HasColumnName("LIMITE");

                entity.Property(e => e.Modificacion)
                    .HasColumnName("MODIFICACION")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Nombre)
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(255);

                entity.Property(e => e.Padre).HasColumnName("PADRE");

                entity.Property(e => e.Pais)
                    .HasColumnName("PAIS")
                    .HasMaxLength(255);

                entity.Property(e => e.Rif)
                    .HasColumnName("RIF")
                    .HasMaxLength(255);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(255);

                entity.Property(e => e.Supervisor).HasColumnName("SUPERVISOR");

                entity.Property(e => e.Vendedor).HasColumnName("VENDEDOR");
            });

            modelBuilder.Entity<ComparativoClientesMaracay>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Comparativo_Clientes_maracay");

                entity.Property(e => e.Asignacion)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AsignacionActual)
                    .HasColumnName("ASIGNACION_ACTUAL")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cobrador)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CobradorActual)
                    .HasColumnName("COBRADOR_ACTUAL")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoActual)
                    .HasColumnName("CODIGO_ACTUAL")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Vendedor1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VendedorActual)
                    .HasColumnName("VENDEDOR_ACTUAL")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Zona)
                    .HasColumnName("zona")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ConsultaContactos>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Consulta_Contactos");

                entity.Property(e => e.Area)
                    .HasColumnName("AREA")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cargo)
                    .HasColumnName("CARGO")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cliente)
                    .HasColumnName("CLIENTE")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Fax)
                    .HasColumnName("FAX")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("Fecha_Creacion")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaCumpleanos)
                    .HasColumnName("FECHA_CUMPLEANOS")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdContactos)
                    .HasColumnName("ID_CONTACTOS")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Inactivo)
                    .HasColumnName("INACTIVO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OficinaVenta)
                    .HasColumnName("Oficina_Venta")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Prospecto)
                    .HasColumnName("PROSPECTO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Rif)
                    .HasColumnName("RIF")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TelefonoCelular)
                    .HasColumnName("TELEFONO_CELULAR")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TelefonoOficina1)
                    .HasColumnName("TELEFONO_OFICINA1")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TelefonoOficina2)
                    .HasColumnName("TELEFONO_OFICINA2")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TomaDecision)
                    .HasColumnName("TOMA_DECISION")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Vendedor1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ConsultaDirecciones>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Consulta_Direcciones");

                entity.Property(e => e.Codigo).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Direccion1)
                    .HasColumnName("Direccion_1")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Direccion2)
                    .HasColumnName("Direccion_2")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdDireccion)
                    .HasColumnName("Id_Direccion")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Municipio)
                    .HasColumnName("MUNICIPIO")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nuevo)
                    .HasColumnName("NUEVO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OficinaVenta)
                    .HasColumnName("Oficina_Venta")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Rif)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Vendedor1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ConsultaWmsy270>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CONSULTA_WMSY270");

                entity.Property(e => e.CodAsignacion)
                    .HasColumnName("Cod_Asignacion")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodOficina)
                    .HasColumnName("Cod_Oficina")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaCreado)
                    .HasColumnName("Fecha_Creado")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaModificado)
                    .HasColumnName("Fecha_Modificado")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Inactiva)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UserCreado)
                    .HasColumnName("User_Creado")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ConsultaWsmy265>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CONSULTA_WSMY265");

                entity.Property(e => e.Codigo)
                    .HasColumnName("CODIGO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ConsultaWsmy266>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CONSULTA_WSMY266");

                entity.Property(e => e.Codigo)
                    .HasColumnName("CODIGO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ConsultaWsmy267>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CONSULTA_WSMY267");

                entity.Property(e => e.CodZona)
                    .HasColumnName("COD_ZONA")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LimiteDesde)
                    .HasColumnName("LIMITE_DESDE")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.LimiteHasta)
                    .HasColumnName("LIMITE_HASTA")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Observacion)
                    .HasColumnName("OBSERVACION")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Oficina)
                    .HasColumnName("OFICINA")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Sector)
                    .HasColumnName("SECTOR")
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Contact");

                entity.Property(e => e.Cargo)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cliente).HasColumnType("numeric(10, 0)");

                entity.Property(e => e.Contacto)
                    .HasColumnType("numeric(10, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Email)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaNac)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(85)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TelefonoCelular)
                    .HasColumnName("Telefono_Celular")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TelefonoOficina)
                    .HasColumnName("Telefono_Oficina")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TelefonoPersonal)
                    .HasColumnName("Telefono_Personal")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ContactoProspecto>(entity =>
            {
                entity.HasKey(e => new { e.Cliente, e.Contacto })
                    .HasName("PK_Contactos");

                entity.ToTable("Contacto Prospecto");

                entity.Property(e => e.Cliente).HasColumnType("numeric(10, 0)");

                entity.Property(e => e.Contacto)
                    .HasColumnType("numeric(10, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Cargo)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Email)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaNac)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(85)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TelefonoCelular)
                    .HasColumnName("Telefono_Celular")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TelefonoOficina)
                    .HasColumnName("Telefono_Oficina")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TelefonoPersonal)
                    .HasColumnName("Telefono_Personal")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<CorrelativoProspecto>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CorrelativoProspecto");

                entity.Property(e => e.Correlativo)
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Csmy003>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .IsClustered(false);

                entity.ToTable("CSMY003");

                entity.HasIndex(e => e.CodJdePadre)
                    .HasName("IX_CSMY003_4");

                entity.HasIndex(e => e.Codigo)
                    .HasName("IX_CSMY003")
                    .IsUnique()
                    .IsClustered();

                entity.HasIndex(e => e.IdDireccion)
                    .HasName("IX_CSMY003_9");

                entity.HasIndex(e => e.NoRegTribut)
                    .HasName("IX_CSMY003_8");

                entity.HasIndex(e => e.Nombre)
                    .HasName("IX_CSMY003_5");

                entity.HasIndex(e => e.Vendedor1)
                    .HasName("_dta_index_CSMY003_8_295672101__K54");

                entity.HasIndex(e => new { e.Codigo, e.FechaInactivo })
                    .HasName("IX_CSMY003_3");

                entity.HasIndex(e => new { e.Codigo, e.FlagInactivo })
                    .HasName("IX_CSMY003_7");

                entity.HasIndex(e => new { e.Codigo, e.GrupoCliente })
                    .HasName("IX_CSMY003_1");

                entity.HasIndex(e => new { e.Vendedor1, e.Nombre })
                    .HasName("IX_CSMY003_6");

                entity.HasIndex(e => new { e.Nombre, e.Codigo, e.AreaCobranz, e.Vendedor1 })
                    .HasName("_dta_index_CSMY003_8_295672101__K29_K54_1_2");

                entity.HasIndex(e => new { e.Nombre, e.FlagCerrado, e.FlagInactivo, e.Vendedor1, e.Codigo })
                    .HasName("_dta_index_CSMY003_8_295672101__K54_K1_2_23_71");

                entity.HasIndex(e => new { e.Nombre, e.FlagCerrado, e.FlagInactivo, e.FlagAtendido, e.Vendedor1, e.Codigo, e.AreaCobranz })
                    .HasName("_dta_index_CSMY003_8_295672101__K54_K1_K29_2_23_71_89");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AreaCobranz)
                    .HasColumnName("Area_Cobranz")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Asignacion)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Canal)
                    .HasColumnName("CANAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CapitalSoc)
                    .HasColumnName("CAPITAL_SOC")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Categoria)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CierreEjerc)
                    .HasColumnName("CIERRE_EJERC")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ClientContado)
                    .HasColumnName("Client_Contado")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClienteNuevo)
                    .HasColumnName("Cliente_Nuevo")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cobrador)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodJde).HasColumnName("cod_jde");

                entity.Property(e => e.CodJdePadre).HasColumnName("Cod_jdePadre");

                entity.Property(e => e.CodMcpo)
                    .HasColumnName("Cod_Mcpo")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodProveedor)
                    .HasColumnName("Cod_Proveedor")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodSubSegmento)
                    .HasColumnName("Cod_SubSegmento")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoCiudad)
                    .HasColumnName("Codigo_Ciudad")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoEstado)
                    .HasColumnName("Codigo_Estado")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoMcpo)
                    .HasColumnName("Codigo_Mcpo")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoNumerico)
                    .HasColumnName("codigo_numerico")
                    .HasColumnType("numeric(6, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CodigoParroq)
                    .HasColumnName("Codigo_Parroq")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoPostal)
                    .HasColumnName("Codigo_Postal")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoRegion)
                    .HasColumnName("Codigo_Region")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CondPago)
                    .HasColumnName("COND_PAGO")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ContCarg1)
                    .HasColumnName("Cont_Carg_1")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContCarg2)
                    .HasColumnName("Cont_Carg_2")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContCarg3)
                    .HasColumnName("Cont_Carg_3")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContEmail1)
                    .HasColumnName("Cont_Email_1")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContEmail2)
                    .HasColumnName("Cont_Email_2")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContEmail3)
                    .HasColumnName("Cont_Email_3")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContEspecial)
                    .HasColumnName("Cont_Especial")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContFechNacm1)
                    .HasColumnName("Cont_FechNacm_1")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ContFechNacm2)
                    .HasColumnName("Cont_FechNacm_2")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ContFechNacm3)
                    .HasColumnName("Cont_FechNacm_3")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ContNomb1)
                    .HasColumnName("Cont_Nomb_1")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContNomb2)
                    .HasColumnName("Cont_Nomb_2")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContNomb3)
                    .HasColumnName("Cont_Nomb_3")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContTelf1)
                    .HasColumnName("Cont_Telf_1")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContTelf2)
                    .HasColumnName("Cont_Telf_2")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContTelf3)
                    .HasColumnName("Cont_Telf_3")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DepuraCod)
                    .HasColumnName("DEPURA_COD")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Depurar)
                    .HasColumnName("depurar")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DiaDeCobro)
                    .HasColumnName("Dia_de_Cobro")
                    .HasMaxLength(10)
                    .IsUnicode(false)
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
                    .HasColumnName("E_mail_Client")
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado).HasMaxLength(2);

                entity.Property(e => e.ExentoDeImpuesto)
                    .HasColumnName("Exento_de_Impuesto")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FApertura)
                    .HasColumnName("F_Apertura")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FModificacion)
                    .HasColumnName("F_Modificacion")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FUltmCompra)
                    .HasColumnName("F_Ultm_Compra")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Fax)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaAtendido)
                    .HasColumnName("Fecha_Atendido")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaCerrado)
                    .HasColumnName("Fecha_Cerrado")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaDesatendido)
                    .HasColumnName("Fecha_Desatendido")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaInactivo)
                    .HasColumnName("Fecha_Inactivo")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaLegal)
                    .HasColumnName("FECHA_LEGAL")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaModificadoLimite)
                    .HasColumnName("Fecha_modificado_Limite")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaReactivado)
                    .HasColumnName("Fecha_Reactivado")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaReactivado1)
                    .HasColumnName("FechaReactivado")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaRiesgo)
                    .HasColumnName("FECHA_RIESGO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FlagAtendido)
                    .HasColumnName("Flag_Atendido")
                    .HasMaxLength(1)
                    .IsFixedLength()
                    .HasDefaultValueSql("(N'X')");

                entity.Property(e => e.FlagCerrado)
                    .HasColumnName("Flag_Cerrado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FlagInactivo)
                    .HasColumnName("Flag_Inactivo")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FlagMat)
                    .HasColumnName("Flag_Mat")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagMod03)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagModificado)
                    .HasColumnName("Flag_Modificado")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagNuevo)
                    .HasColumnName("Flag_Nuevo")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GiroNegocio)
                    .HasColumnName("Giro_Negocio")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Grupo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GrupoCliente)
                    .HasColumnName("GRUPO_CLIENTE")
                    .HasColumnType("numeric(5, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IdDireccion)
                    .HasColumnName("Id_direccion")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Klabc)
                    .HasColumnName("KLABC")
                    .HasMaxLength(2)
                    .HasDefaultValueSql("(N'C')");

                entity.Property(e => e.LCredito)
                    .HasColumnName("L_Credito")
                    .HasColumnType("money");

                entity.Property(e => e.Legal)
                    .HasColumnName("LEGAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LimiteCredUt)
                    .HasColumnName("Limite_Cred_Ut")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.Municipio).HasMaxLength(2);

                entity.Property(e => e.Nit)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NoPasoJde)
                    .HasMaxLength(1)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NoRegTribut)
                    .HasColumnName("No_Reg_Tribut")
                    .HasMaxLength(12)
                    .IsUnicode(false)
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
                    .HasColumnName("Oficina_Venta")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrdenCompra)
                    .HasColumnName("Orden_Compra")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PaginaWeb)
                    .HasColumnName("Pagina_Web")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RepresLegal)
                    .HasColumnName("Repres_Legal")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Riesgo)
                    .HasColumnName("RIESGO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RutCartero)
                    .HasColumnName("Rut_Cartero")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Saldo).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Segmento)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SiDolares)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Smacc)
                    .HasColumnName("smacc")
                    .HasMaxLength(50);

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
                    .HasColumnName("Tipo_Negocio")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioMod)
                    .HasColumnName("USUARIO_MOD")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Vendedor1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Zona)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Zzsn01)
                    .HasColumnName("ZZSN01")
                    .HasMaxLength(50)
                    .HasComment("Página Web");

                entity.Property(e => e.Zzsn02)
                    .HasColumnName("ZZSN02")
                    .HasMaxLength(50)
                    .HasComment("Facebook");

                entity.Property(e => e.Zzsn03)
                    .HasColumnName("ZZSN03")
                    .HasMaxLength(50)
                    .HasComment("Google+");

                entity.Property(e => e.Zzsn04)
                    .HasColumnName("ZZSN04")
                    .HasMaxLength(50)
                    .HasComment("Instagram");

                entity.Property(e => e.Zzsn05)
                    .HasColumnName("ZZSN05")
                    .HasMaxLength(50)
                    .HasComment("Twitter");

                entity.Property(e => e.Zzsn06)
                    .HasColumnName("ZZSN06")
                    .HasMaxLength(8)
                    .HasComment("Fecha cumpleaños");
            });

            modelBuilder.Entity<Csmy0031>(entity =>
            {
                entity.HasKey(e => e.Rif);

                entity.ToTable("CSMY0031");

                entity.HasIndex(e => e.CodJde)
                    .HasName("IX_CSMY0031");

                entity.HasIndex(e => e.IdDireccion)
                    .HasName("IX_CSMY0031_2");

                entity.HasIndex(e => e.RazonSocial)
                    .HasName("IX_CSMY0031_1");

                entity.HasIndex(e => e.Rif)
                    .HasName("Rif")
                    .IsUnique();

                entity.HasIndex(e => new { e.Codigo, e.Rif })
                    .HasName("Rif_Codigo");

                entity.Property(e => e.Rif)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cambio)
                    .HasColumnName("CAMBIO")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Ciudad)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ClienteMatriz)
                    .HasColumnName("Cliente_Matriz")
                    .HasMaxLength(1);

                entity.Property(e => e.CodEstado)
                    .HasColumnName("Cod_Estado")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodJde).HasColumnName("cod_jde");

                entity.Property(e => e.CodMcpo)
                    .HasColumnName("Cod_Mcpo")
                    .HasMaxLength(4)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodSubsegmento)
                    .HasColumnName("Cod_Subsegmento")
                    .HasMaxLength(6);

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoPostal)
                    .HasColumnName("Codigo_Postal")
                    .HasMaxLength(12);

                entity.Property(e => e.ContEspecial)
                    .HasColumnName("Cont_Especial")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DocumentPend).HasMaxLength(80);

                entity.Property(e => e.DocumentosPendientes)
                    .HasColumnName("Documentos_Pendientes")
                    .HasMaxLength(1);

                entity.Property(e => e.DomicilioFiscal)
                    .HasColumnName("Domicilio_Fiscal")
                    .HasMaxLength(80);

                entity.Property(e => e.DomicilioFiscal1)
                    .HasColumnName("Domicilio_Fiscal1")
                    .HasMaxLength(80);

                entity.Property(e => e.DomicilioFiscal2)
                    .HasColumnName("Domicilio_Fiscal2")
                    .HasMaxLength(80);

                entity.Property(e => e.Estado)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FechaCerrado)
                    .HasColumnName("Fecha_Cerrado")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaCreacion).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaExpide)
                    .HasColumnName("Fecha_Expide")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaModificado).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaVigenciaRif).HasColumnType("datetime");

                entity.Property(e => e.FlagCerrado)
                    .HasColumnName("Flag_Cerrado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagDesactivar)
                    .HasColumnName("Flag_Desactivar")
                    .HasMaxLength(1);

                entity.Property(e => e.FlagModificado)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'X')");

                entity.Property(e => e.FlagOutsoc)
                    .HasColumnName("Flag_Outsoc")
                    .HasMaxLength(1);

                entity.Property(e => e.IdDireccion)
                    .HasColumnName("Id_direccion")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ImagenRif).HasColumnType("image");

                entity.Property(e => e.Nit)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RazonSocial)
                    .HasColumnName("Razon_Social")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RifNuevo)
                    .HasColumnName("Rif_Nuevo")
                    .HasMaxLength(1);

                entity.Property(e => e.SiDolares)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TImpuesto).HasColumnName("T_Impuesto");
            });

            modelBuilder.Entity<Csmy177>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CSMY177");

                entity.Property(e => e.FlagAct11)
                    .HasColumnName("FLAG_ACT_11")
                    .HasMaxLength(1);

                entity.Property(e => e.FlagAct12)
                    .HasColumnName("FLAG_ACT_12")
                    .HasMaxLength(1);

                entity.Property(e => e.FlagAct13)
                    .HasColumnName("FLAG_ACT_13")
                    .HasMaxLength(1);

                entity.Property(e => e.FlagAct14)
                    .HasColumnName("FLAG_ACT_14")
                    .HasMaxLength(1);

                entity.Property(e => e.FlagAct15)
                    .HasColumnName("FLAG_ACT_15")
                    .HasMaxLength(1);

                entity.Property(e => e.FlagAct16)
                    .HasColumnName("FLAG_ACT_16")
                    .HasMaxLength(1);

                entity.Property(e => e.FlagAct17)
                    .HasColumnName("FLAG_ACT_17")
                    .HasMaxLength(1);

                entity.Property(e => e.FlagAct18)
                    .HasColumnName("FLAG_ACT_18")
                    .HasMaxLength(1);

                entity.Property(e => e.FlagAct19)
                    .HasColumnName("FLAG_ACT_19")
                    .HasMaxLength(1);

                entity.Property(e => e.FlagAct21)
                    .HasColumnName("FLAG_ACT_21")
                    .HasMaxLength(1);

                entity.Property(e => e.FlagAct22)
                    .HasColumnName("FLAG_ACT_22")
                    .HasMaxLength(1);

                entity.Property(e => e.FlagAct23)
                    .HasColumnName("FLAG_ACT_23")
                    .HasMaxLength(1);

                entity.Property(e => e.FlagAct24)
                    .HasColumnName("FLAG_ACT_24")
                    .HasMaxLength(1);

                entity.Property(e => e.FlagAct25)
                    .HasColumnName("FLAG_ACT_25")
                    .HasMaxLength(1);

                entity.Property(e => e.FlagAct26)
                    .HasColumnName("FLAG_ACT_26")
                    .HasMaxLength(1);

                entity.Property(e => e.FlagAct27)
                    .HasColumnName("FLAG_ACT_27")
                    .HasMaxLength(1);

                entity.Property(e => e.FlagAct28)
                    .HasColumnName("FLAG_ACT_28")
                    .HasMaxLength(1);

                entity.Property(e => e.FlagAct29)
                    .HasColumnName("FLAG_ACT_29")
                    .HasMaxLength(1);

                entity.Property(e => e.FlagAct31)
                    .HasColumnName("FLAG_ACT_31")
                    .HasMaxLength(1);

                entity.Property(e => e.FlagAct32)
                    .HasColumnName("FLAG_ACT_32")
                    .HasMaxLength(1);

                entity.Property(e => e.FlagAct33)
                    .HasColumnName("FLAG_ACT_33")
                    .HasMaxLength(1);

                entity.Property(e => e.FlagAct34)
                    .HasColumnName("FLAG_ACT_34")
                    .HasMaxLength(1);

                entity.Property(e => e.FlagAct41)
                    .HasColumnName("FLAG_ACT_41")
                    .HasMaxLength(1);

                entity.Property(e => e.FlagAct42)
                    .HasColumnName("FLAG_ACT_42")
                    .HasMaxLength(1);

                entity.Property(e => e.FlagAct43)
                    .HasColumnName("FLAG_ACT_43")
                    .HasMaxLength(1);

                entity.Property(e => e.FlagAct44)
                    .HasColumnName("FLAG_ACT_44")
                    .HasMaxLength(1);

                entity.Property(e => e.Zon11).HasColumnName("ZON_11");

                entity.Property(e => e.Zon12).HasColumnName("ZON_12");

                entity.Property(e => e.Zon13).HasColumnName("ZON_13");

                entity.Property(e => e.Zon14).HasColumnName("ZON_14");

                entity.Property(e => e.Zon15).HasColumnName("ZON_15");

                entity.Property(e => e.Zon16).HasColumnName("ZON_16");

                entity.Property(e => e.Zon17).HasColumnName("ZON_17");

                entity.Property(e => e.Zon18).HasColumnName("ZON_18");

                entity.Property(e => e.Zon19).HasColumnName("ZON_19");

                entity.Property(e => e.Zon21).HasColumnName("ZON_21");

                entity.Property(e => e.Zon22).HasColumnName("ZON_22");

                entity.Property(e => e.Zon23).HasColumnName("ZON_23");

                entity.Property(e => e.Zon24).HasColumnName("ZON_24");

                entity.Property(e => e.Zon25).HasColumnName("ZON_25");

                entity.Property(e => e.Zon26).HasColumnName("ZON_26");

                entity.Property(e => e.Zon27).HasColumnName("ZON_27");

                entity.Property(e => e.Zon28).HasColumnName("ZON_28");

                entity.Property(e => e.Zon29).HasColumnName("ZON_29");

                entity.Property(e => e.Zon31).HasColumnName("ZON_31");

                entity.Property(e => e.Zon32).HasColumnName("ZON_32");

                entity.Property(e => e.Zon33).HasColumnName("ZON_33");

                entity.Property(e => e.Zon34).HasColumnName("ZON_34");

                entity.Property(e => e.Zon41).HasColumnName("ZON_41");

                entity.Property(e => e.Zon42).HasColumnName("ZON_42");

                entity.Property(e => e.Zon43).HasColumnName("ZON_43");

                entity.Property(e => e.Zon44).HasColumnName("ZON_44");
            });

            modelBuilder.Entity<DatosAdjuntos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK___DatosAdjuntos__1881A0DE");

                entity.ToTable("_DatosAdjuntos", "userweb");

                entity.Property(e => e.Codigo)
                    .HasColumnName("codigo")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Blob)
                    .HasColumnName("BLOB")
                    .HasColumnType("image");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Estado).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<DfCsmy0031>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DF_Csmy0031");

                entity.Property(e => e.Bueno)
                    .HasColumnName("BUENO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ciudad)
                    .HasColumnName("CIUDAD")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cliente)
                    .HasColumnName("CLIENTE")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.CodMcpo)
                    .HasColumnName("COD_MCPO")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoEdo)
                    .HasColumnName("CODIGO_EDO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoMcpo)
                    .HasColumnName("CODIGO_MCPO")
                    .HasMaxLength(2)
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

                entity.Property(e => e.Direccion3)
                    .HasColumnName("DIRECCION3")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DocPendientes)
                    .HasColumnName("DOC_PENDIENTES")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Eli)
                    .HasColumnName("ELI")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

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
                    .IsFixedLength();

                entity.Property(e => e.Matriz)
                    .HasColumnName("MATRIZ")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nit)
                    .HasColumnName("NIT")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.Postal)
                    .HasColumnName("POSTAL")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.RazonSocial)
                    .HasColumnName("RAZON_SOCIAL")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RecordNumber).HasColumnName("RECORD_NUMBER");

                entity.Property(e => e.Rif)
                    .HasColumnName("RIF")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RifNuevo)
                    .HasColumnName("RIF_NUEVO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TImpuesto)
                    .HasColumnName("T_IMPUESTO")
                    .HasColumnType("numeric(2, 0)");
            });

            modelBuilder.Entity<DfWsmy003>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DF_wsmy003");

                entity.Property(e => e.ActividadEco)
                    .HasColumnName("ACTIVIDAD_ECO")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Asignacion)
                    .HasColumnName("ASIGNACION")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.Ciudad)
                    .HasColumnName("CIUDAD")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Clave)
                    .HasColumnName("CLAVE")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Clave1)
                    .HasColumnName("CLAVE1")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Clave3)
                    .HasColumnName("CLAVE3")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClientContado)
                    .HasColumnName("CLIENT_CONTADO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

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

                entity.Property(e => e.CodMcpo)
                    .HasColumnName("COD_MCPO")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodPostal)
                    .HasColumnName("COD_POSTAL")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodProv)
                    .HasColumnName("COD_PROV")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Codigo)
                    .HasColumnName("CODIGO")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.CteMatriz)
                    .HasColumnName("CTE_MATRIZ")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DiaCobroJu)
                    .HasColumnName("DIA_COBRO_JU")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DiaCobroLu)
                    .HasColumnName("DIA_COBRO_LU")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DiaCobroMa)
                    .HasColumnName("DIA_COBRO_MA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DiaCobroMi)
                    .HasColumnName("DIA_COBRO_MI")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DiaCobroSa)
                    .HasColumnName("DIA_COBRO_SA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DiaCobroVi)
                    .HasColumnName("DIA_COBRO_VI")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

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

                entity.Property(e => e.Especial)
                    .HasColumnName("ESPECIAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Fax)
                    .HasColumnName("FAX")
                    .HasColumnType("numeric(8, 0)");

                entity.Property(e => e.FechaCambio)
                    .HasColumnName("FECHA_CAMBIO")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaVenRegm)
                    .HasColumnName("FECHA_VEN_REGM")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagCambio)
                    .HasColumnName("FLAG_CAMBIO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagInactivo)
                    .HasColumnName("FLAG_INACTIVO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GeoEstado)
                    .HasColumnName("GEO_ESTADO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GeoMunParr)
                    .HasColumnName("GEO_MUN_PARR")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Grupo)
                    .HasColumnName("GRUPO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LCredito)
                    .HasColumnName("L_CREDITO")
                    .HasColumnType("numeric(8, 0)");

                entity.Property(e => e.Municipio)
                    .HasColumnName("MUNICIPIO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Observacion)
                    .HasColumnName("OBSERVACION")
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Parada)
                    .HasColumnName("PARADA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PromHistorico)
                    .HasColumnName("PROM_HISTORICO")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.RamoNegocio)
                    .HasColumnName("RAMO_NEGOCIO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RecordNumber).HasColumnName("RECORD_NUMBER");

                entity.Property(e => e.Region)
                    .HasColumnName("REGION")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Rif)
                    .HasColumnName("RIF")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Saldoact)
                    .HasColumnName("SALDOACT")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.SectorNegocio)
                    .HasColumnName("SECTOR_NEGOCIO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Solvencia)
                    .HasColumnName("SOLVENCIA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sucursal)
                    .HasColumnName("SUCURSAL")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.SumaHistorico)
                    .HasColumnName("SUMA_HISTORICO")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.SumaProceso)
                    .HasColumnName("SUMA_PROCESO")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.TImpuesto)
                    .HasColumnName("T_IMPUESTO")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Telefono)
                    .HasColumnName("TELEFONO")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Telex)
                    .HasColumnName("TELEX")
                    .HasColumnType("numeric(6, 0)");

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
                    .HasColumnType("datetime");

                entity.Property(e => e.Vendedor)
                    .HasColumnName("VENDEDOR")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Zona)
                    .HasColumnName("ZONA")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Duplicados>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CodJde).HasColumnName("cod_jde");
            });

            modelBuilder.Entity<Duplicados2>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CodJde).HasColumnName("cod_jde");
            });

            modelBuilder.Entity<EmpleadosVe>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .IsClustered(false);

                entity.ToTable("EmpleadosVE");

                entity.HasIndex(e => e.Codigo)
                    .HasName("IX_EmpleadosVE")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.Codigo).HasColumnName("CODIGO");

                entity.Property(e => e.Ciudad)
                    .HasColumnName("CIUDAD")
                    .HasMaxLength(255);

                entity.Property(e => e.Cp)
                    .HasColumnName("CP")
                    .HasMaxLength(255);

                entity.Property(e => e.Direccion1)
                    .HasColumnName("DIRECCION1")
                    .HasMaxLength(255);

                entity.Property(e => e.Direccion2)
                    .HasColumnName("DIRECCION2")
                    .HasMaxLength(255);

                entity.Property(e => e.Direccion3)
                    .HasColumnName("DIRECCION3")
                    .HasMaxLength(255);

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasMaxLength(255);

                entity.Property(e => e.Estado1)
                    .HasColumnName("ESTADO1")
                    .HasMaxLength(255);

                entity.Property(e => e.Modificacion)
                    .HasColumnName(" MODIFICACION")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Nombre)
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(255);

                entity.Property(e => e.Pais)
                    .HasColumnName("PAIS")
                    .HasMaxLength(255);

                entity.Property(e => e.Rif)
                    .HasColumnName("RIF")
                    .HasMaxLength(255);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<FechaAperturaClientes>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FECHA_APERTURA_CLIENTES");

                entity.Property(e => e.CodCliente)
                    .HasColumnName("COD_CLIENTE")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.FechaApertura)
                    .HasColumnName("FECHA_APERTURA")
                    .HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<InactivacionAgo2012>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CodigoCobrador)
                    .HasColumnName("Codigo Cobrador")
                    .HasMaxLength(255);

                entity.Property(e => e.CodigoJde)
                    .HasColumnName("Codigo JDE")
                    .HasMaxLength(255);

                entity.Property(e => e.CodigoLegacy)
                    .HasColumnName("Codigo Legacy")
                    .HasMaxLength(255);

                entity.Property(e => e.CodigoPadre).HasColumnName("Codigo Padre");

                entity.Property(e => e.EsPadre)
                    .HasColumnName("Es Padre")
                    .HasMaxLength(255);

                entity.Property(e => e.FechaCreación)
                    .HasColumnName("Fecha Creación")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaUltimaCompra)
                    .HasColumnName("Fecha Ultima Compra")
                    .HasColumnType("datetime");

                entity.Property(e => e.MesesCreación).HasColumnName("Meses Creación");

                entity.Property(e => e.MesesUltimaCompra).HasColumnName("Meses Ultima Compra");

                entity.Property(e => e.NombreCliente)
                    .HasColumnName("Nombre Cliente")
                    .HasMaxLength(255);

                entity.Property(e => e.OrdenesEnProceso)
                    .HasColumnName("Ordenes En Proceso")
                    .HasMaxLength(255);

                entity.Property(e => e.PadreInactivo)
                    .HasColumnName("Padre Inactivo")
                    .HasMaxLength(255);

                entity.Property(e => e.SaldoCliente)
                    .HasColumnName("Saldo Cliente")
                    .HasColumnType("money");

                entity.Property(e => e.SaldoClientePadre)
                    .HasColumnName("Saldo Cliente Padre")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<JdeProveedoresImpuesto>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("JdeProveedoresImpuesto");

                entity.Property(e => e.Abtax)
                    .HasColumnName("ABTAX")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.An8).HasColumnName("AN8");

                entity.Property(e => e.Codigo).HasColumnName("CODIGO");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion1)
                    .HasColumnName("DESCRIPCION1")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Tipopersona).HasColumnName("TIPOPERSONA");

                entity.Property(e => e.V76isfc).HasColumnName("V76ISFC");

                entity.Property(e => e.Vt6vatw).HasColumnName("VT6VATW");
            });

            modelBuilder.Entity<LimiteCreditoxCliente01>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("LimiteCreditoxCliente_01");

                entity.Property(e => e.AreaCobranz)
                    .HasColumnName("Area_Cobranz")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LimiteCredUt)
                    .HasColumnName("Limite_Cred_Ut")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.NombZona)
                    .HasColumnName("NOMB_ZONA")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoNegocio)
                    .HasColumnName("Tipo_Negocio")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TotalBs)
                    .HasColumnName("Total_Bs")
                    .HasColumnType("decimal(35, 4)");

                entity.Property(e => e.UtBs)
                    .HasColumnName("UT_BS")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<LimiteCreditoxCliente02>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("LimiteCreditoxCliente_02");

                entity.Property(e => e.AreaCobranz)
                    .HasColumnName("Area_Cobranz")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LimiteCredUt)
                    .HasColumnName("Limite_Cred_Ut")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.NombZona)
                    .HasColumnName("NOMB_ZONA")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoNegocio)
                    .HasColumnName("Tipo_Negocio")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TotalBs)
                    .HasColumnName("Total_Bs")
                    .HasColumnType("decimal(35, 4)");

                entity.Property(e => e.UtBs)
                    .HasColumnName("UT_BS")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<LogicoCsmy003>(entity =>
            {
                entity.HasIndex(e => new { e.Cliente, e.FechaUpdate })
                    .HasName("IX_LogicoCsmy003");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Campo)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Cliente).HasColumnType("numeric(6, 0)");

                entity.Property(e => e.FechaUpdate)
                    .HasColumnName("Fecha_update")
                    .HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<OficianasValidarParroquia>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Oficina).HasMaxLength(10);
            });

            modelBuilder.Entity<ParaActualizarElContacto1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Para actualizar el contacto 1");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContCarg1)
                    .HasColumnName("Cont_Carg_1")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContEmail1)
                    .HasColumnName("Cont_Email_1")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContFechNacm1)
                    .HasColumnName("Cont_FechNacm_1")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ContNomb1)
                    .HasColumnName("Cont_Nomb_1")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContTelf1)
                    .HasColumnName("Cont_Telf_1")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ParaActualizarElContacto2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Para actualizar el contacto 2");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContCarg2)
                    .HasColumnName("Cont_Carg_2")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContEmail2)
                    .HasColumnName("Cont_Email_2")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContFechNacm2)
                    .HasColumnName("Cont_FechNacm_2")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ContNomb2)
                    .HasColumnName("Cont_Nomb_2")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContTelf2)
                    .HasColumnName("Cont_Telf_2")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ParaActualizarElContacto3>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Para actualizar el contacto 3");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContCarg3)
                    .HasColumnName("Cont_Carg_3")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContEmail3)
                    .HasColumnName("Cont_Email_3")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContFechNacm3)
                    .HasColumnName("Cont_FechNacm_3")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ContNomb3)
                    .HasColumnName("Cont_Nomb_3")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContTelf3)
                    .HasColumnName("Cont_Telf_3")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Paseclientes>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("paseclientes");

                entity.Property(e => e.AreaCobranz)
                    .HasColumnName("Area_Cobranz")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Asignacion)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Canal)
                    .HasColumnName("CANAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CapitalSoc)
                    .HasColumnName("CAPITAL_SOC")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Categoria)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CierreEjerc)
                    .HasColumnName("CIERRE_EJERC")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ClientContado)
                    .HasColumnName("Client_Contado")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClienteNuevo)
                    .HasColumnName("Cliente_Nuevo")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cobrador)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodJde).HasColumnName("cod_jde");

                entity.Property(e => e.CodMcpo)
                    .HasColumnName("Cod_Mcpo")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodProveedor)
                    .HasColumnName("Cod_Proveedor")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodSubSegmento)
                    .HasColumnName("Cod_SubSegmento")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoCiudad)
                    .HasColumnName("Codigo_Ciudad")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoEstado)
                    .HasColumnName("Codigo_Estado")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoMcpo)
                    .HasColumnName("Codigo_Mcpo")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoNumerico).HasColumnName("codigo_numerico");

                entity.Property(e => e.CodigoParroq)
                    .HasColumnName("Codigo_Parroq")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoPostal)
                    .HasColumnName("Codigo_Postal")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoRegion)
                    .HasColumnName("Codigo_Region")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CondPago)
                    .HasColumnName("COND_PAGO")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ContCarg1)
                    .HasColumnName("Cont_Carg_1")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContCarg2)
                    .HasColumnName("Cont_Carg_2")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContCarg3)
                    .HasColumnName("Cont_Carg_3")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContEmail1)
                    .HasColumnName("Cont_Email_1")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContEmail2)
                    .HasColumnName("Cont_Email_2")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContEmail3)
                    .HasColumnName("Cont_Email_3")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContEspecial)
                    .HasColumnName("Cont_Especial")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContFechNacm1)
                    .HasColumnName("Cont_FechNacm_1")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ContFechNacm2)
                    .HasColumnName("Cont_FechNacm_2")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ContFechNacm3)
                    .HasColumnName("Cont_FechNacm_3")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ContNomb1)
                    .HasColumnName("Cont_Nomb_1")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContNomb2)
                    .HasColumnName("Cont_Nomb_2")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContNomb3)
                    .HasColumnName("Cont_Nomb_3")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContTelf1)
                    .HasColumnName("Cont_Telf_1")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContTelf2)
                    .HasColumnName("Cont_Telf_2")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContTelf3)
                    .HasColumnName("Cont_Telf_3")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DepuraCod)
                    .HasColumnName("DEPURA_COD")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DiaDeCobro)
                    .HasColumnName("Dia_de_Cobro")
                    .HasMaxLength(10)
                    .IsUnicode(false)
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

                entity.Property(e => e.DomicilioFiscal)
                    .HasColumnName("Domicilio_Fiscal")
                    .HasMaxLength(80);

                entity.Property(e => e.DomicilioFiscal1)
                    .HasColumnName("Domicilio_Fiscal1")
                    .HasMaxLength(80);

                entity.Property(e => e.DomicilioFiscal2)
                    .HasColumnName("Domicilio_Fiscal2")
                    .HasMaxLength(80);

                entity.Property(e => e.EMailClient)
                    .HasColumnName("E_mail_Client")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ExentoDeImpuesto)
                    .HasColumnName("Exento_de_Impuesto")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Expr1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FApertura)
                    .HasColumnName("F_Apertura")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FModificacion)
                    .HasColumnName("F_Modificacion")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FUltmCompra)
                    .HasColumnName("F_Ultm_Compra")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Fax)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaCerrado)
                    .HasColumnName("Fecha_Cerrado")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaInactivo)
                    .HasColumnName("Fecha_Inactivo")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaLegal)
                    .HasColumnName("FECHA_LEGAL")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaReactivado)
                    .HasColumnName("Fecha_Reactivado")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaRiesgo)
                    .HasColumnName("FECHA_RIESGO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FlagCerrado)
                    .HasColumnName("Flag_Cerrado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagInactivo)
                    .HasColumnName("Flag_Inactivo")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagMat)
                    .HasColumnName("Flag_Mat")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagMod03)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagModificado)
                    .HasColumnName("Flag_Modificado")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagNuevo)
                    .HasColumnName("Flag_Nuevo")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GiroNegocio)
                    .HasColumnName("Giro_Negocio")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Grupo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GrupoCliente)
                    .HasColumnName("GRUPO_CLIENTE")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.LCredito)
                    .HasColumnName("L_Credito")
                    .HasColumnType("money");

                entity.Property(e => e.Legal)
                    .HasColumnName("LEGAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LimiteCredUt)
                    .HasColumnName("Limite_Cred_Ut")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.Nit)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NoRegTribut)
                    .HasColumnName("No_Reg_Tribut")
                    .HasMaxLength(12)
                    .IsUnicode(false)
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
                    .HasColumnName("Oficina_Venta")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrdenCompra)
                    .HasColumnName("Orden_Compra")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PaginaWeb)
                    .HasColumnName("Pagina_Web")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RazonSocial)
                    .HasColumnName("Razon_Social")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RepresLegal)
                    .HasColumnName("Repres_Legal")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Riesgo)
                    .HasColumnName("RIESGO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Rif)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RutCartero)
                    .HasColumnName("Rut_Cartero")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Segmento)
                    .HasMaxLength(10)
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
                    .HasColumnName("Tipo_Negocio")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioMod)
                    .HasColumnName("USUARIO_MOD")
                    .HasMaxLength(30)
                    .IsUnicode(false)
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

            modelBuilder.Entity<Pasejde>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PASEJDE");

                entity.Property(e => e.AreaCobranz)
                    .HasColumnName("Area_Cobranz")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Asignacion)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Canal)
                    .HasColumnName("CANAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CapitalSoc)
                    .HasColumnName("CAPITAL_SOC")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Categoria)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CierreEjerc)
                    .HasColumnName("CIERRE_EJERC")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ClientContado)
                    .HasColumnName("Client_Contado")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClienteNuevo)
                    .HasColumnName("Cliente_Nuevo")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cobrador)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodJde).HasColumnName("cod_jde");

                entity.Property(e => e.CodMcpo)
                    .HasColumnName("Cod_Mcpo")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodProveedor)
                    .HasColumnName("Cod_Proveedor")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodSubSegmento)
                    .HasColumnName("Cod_SubSegmento")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoCiudad)
                    .HasColumnName("Codigo_Ciudad")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoEstado)
                    .HasColumnName("Codigo_Estado")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoMcpo)
                    .HasColumnName("Codigo_Mcpo")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoNumerico).HasColumnName("codigo_numerico");

                entity.Property(e => e.CodigoParroq)
                    .HasColumnName("Codigo_Parroq")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoPostal)
                    .HasColumnName("Codigo_Postal")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoRegion)
                    .HasColumnName("Codigo_Region")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CondPago)
                    .HasColumnName("COND_PAGO")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ContCarg1)
                    .HasColumnName("Cont_Carg_1")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContCarg2)
                    .HasColumnName("Cont_Carg_2")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContCarg3)
                    .HasColumnName("Cont_Carg_3")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContEmail1)
                    .HasColumnName("Cont_Email_1")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContEmail2)
                    .HasColumnName("Cont_Email_2")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContEmail3)
                    .HasColumnName("Cont_Email_3")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContEspecial)
                    .HasColumnName("Cont_Especial")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContFechNacm1)
                    .HasColumnName("Cont_FechNacm_1")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ContFechNacm2)
                    .HasColumnName("Cont_FechNacm_2")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ContFechNacm3)
                    .HasColumnName("Cont_FechNacm_3")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ContNomb1)
                    .HasColumnName("Cont_Nomb_1")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContNomb2)
                    .HasColumnName("Cont_Nomb_2")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContNomb3)
                    .HasColumnName("Cont_Nomb_3")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContTelf1)
                    .HasColumnName("Cont_Telf_1")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContTelf2)
                    .HasColumnName("Cont_Telf_2")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContTelf3)
                    .HasColumnName("Cont_Telf_3")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DepuraCod)
                    .HasColumnName("DEPURA_COD")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DiaDeCobro)
                    .HasColumnName("Dia_de_Cobro")
                    .HasMaxLength(10)
                    .IsUnicode(false)
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
                    .HasColumnName("E_mail_Client")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ExentoDeImpuesto)
                    .HasColumnName("Exento_de_Impuesto")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Expr1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FApertura)
                    .HasColumnName("F_Apertura")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FModificacion)
                    .HasColumnName("F_Modificacion")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FUltmCompra)
                    .HasColumnName("F_Ultm_Compra")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Fax)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaCerrado)
                    .HasColumnName("Fecha_Cerrado")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaInactivo)
                    .HasColumnName("Fecha_Inactivo")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaLegal)
                    .HasColumnName("FECHA_LEGAL")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaReactivado)
                    .HasColumnName("Fecha_Reactivado")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaRiesgo)
                    .HasColumnName("FECHA_RIESGO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FlagCerrado)
                    .HasColumnName("Flag_Cerrado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagInactivo)
                    .HasColumnName("Flag_Inactivo")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagMat)
                    .HasColumnName("Flag_Mat")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagMod03)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagModificado)
                    .HasColumnName("Flag_Modificado")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagNuevo)
                    .HasColumnName("Flag_Nuevo")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GiroNegocio)
                    .HasColumnName("Giro_Negocio")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Grupo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GrupoCliente)
                    .HasColumnName("GRUPO_CLIENTE")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.LCredito)
                    .HasColumnName("L_Credito")
                    .HasColumnType("money");

                entity.Property(e => e.Legal)
                    .HasColumnName("LEGAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LimiteCredUt)
                    .HasColumnName("Limite_Cred_Ut")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.Nit)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NoRegTribut)
                    .HasColumnName("No_Reg_Tribut")
                    .HasMaxLength(12)
                    .IsUnicode(false)
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
                    .HasColumnName("Oficina_Venta")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrdenCompra)
                    .HasColumnName("Orden_Compra")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PaginaWeb)
                    .HasColumnName("Pagina_Web")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RepresLegal)
                    .HasColumnName("Repres_Legal")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Riesgo)
                    .HasColumnName("RIESGO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RutCartero)
                    .HasColumnName("Rut_Cartero")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Segmento)
                    .HasMaxLength(10)
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
                    .HasColumnName("Tipo_Negocio")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioMod)
                    .HasColumnName("USUARIO_MOD")
                    .HasMaxLength(30)
                    .IsUnicode(false)
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

            modelBuilder.Entity<PlanillaDeActualizacion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Planilla de Actualizacion");

                entity.Property(e => e.Cargo)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoCiudad)
                    .HasColumnName("Codigo_Ciudad")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoEstado)
                    .HasColumnName("Codigo_Estado")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoRegion)
                    .HasColumnName("Codigo_Region")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DiaDeCobro)
                    .HasColumnName("Dia_de_Cobro")
                    .HasMaxLength(10)
                    .IsUnicode(false)
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

                entity.Property(e => e.Email)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ExentoDeImpuesto)
                    .HasColumnName("Exento_de_Impuesto")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Expr1)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Fax)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaNac).HasColumnType("smalldatetime");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrdenCompra)
                    .HasColumnName("Orden_Compra")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RazonSocial)
                    .HasColumnName("Razon_Social")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RepresLegal)
                    .HasColumnName("Repres_Legal")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Rif)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Telefono)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Telefono1)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TelefonoCelular)
                    .HasColumnName("Telefono_Celular")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TelefonoOficina)
                    .HasColumnName("Telefono_Oficina")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TelefonoPersonal)
                    .HasColumnName("Telefono_Personal")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Proveedores>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PROVEEDORES");

                entity.Property(e => e.A6apc)
                    .HasColumnName("A6APC")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.A6txa2)
                    .HasColumnName("A6TXA2")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Abalky)
                    .HasColumnName("ABALKY")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Abalph)
                    .HasColumnName("ABALPH")
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.Aban8).HasColumnName("ABAN8");

                entity.Property(e => e.Abat1)
                    .HasColumnName("ABAT1")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Absbli)
                    .HasColumnName("ABSBLI")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Abtax)
                    .HasColumnName("ABTAX")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Abupmj)
                    .HasColumnName("ABUPMJ")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Aladd3)
                    .HasColumnName("ALADD3")
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.Aladd4)
                    .HasColumnName("ALADD4")
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.Aladds)
                    .HasColumnName("ALADDS")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Aladdz)
                    .HasColumnName("ALADDZ")
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.Alcoun)
                    .HasColumnName("ALCOUN")
                    .HasMaxLength(25)
                    .IsFixedLength();

                entity.Property(e => e.Alcty1)
                    .HasColumnName("ALCTY1")
                    .HasMaxLength(25)
                    .IsFixedLength();
            });

            modelBuilder.Entity<QueryCsmy00302>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QUERY_CSMY003_02");

                entity.Property(e => e.AreaCobranz)
                    .HasColumnName("Area_Cobranz")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagInactivo)
                    .HasColumnName("Flag_Inactivo")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NoRegTribut)
                    .HasColumnName("No_Reg_Tribut")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NombAreaCob)
                    .HasColumnName("NOMB_AREA_COB")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NombreTipo)
                    .HasColumnName("NOMBRE_TIPO")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoCliente).HasColumnName("TIPO_CLIENTE");
            });

            modelBuilder.Entity<QueryCsmy00303>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QUERY_CSMY003_03");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.Rif)
                    .HasColumnName("RIF")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<QueryCsmy00304>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QUERY_CSMY003_04");

                entity.Property(e => e.AreaCobranz)
                    .HasColumnName("Area_Cobranz")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Expr1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagInactivo)
                    .HasColumnName("Flag_Inactivo")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NoRegTribut)
                    .HasColumnName("No_Reg_Tribut")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NombreTipo)
                    .HasColumnName("NOMBRE_TIPO")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Rif)
                    .HasColumnName("RIF")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Tipo).HasColumnName("TIPO");
            });

            modelBuilder.Entity<QueryWsmy06501>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QUERY_WSMY065_01");

                entity.Property(e => e.FechaCambio)
                    .HasColumnName("FECHA_CAMBIO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.NombreRamo)
                    .HasColumnName("NOMBRE_RAMO")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NombreSector)
                    .HasColumnName("NOMBRE_SECTOR")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ramo)
                    .HasColumnName("RAMO")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.Sector)
                    .HasColumnName("SECTOR")
                    .HasColumnType("decimal(2, 0)");
            });

            modelBuilder.Entity<RamoWeb>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RAMO_WEB");

                entity.Property(e => e.Combinacion)
                    .HasColumnName("COMBINACION")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.NombreRamo)
                    .HasColumnName("NOMBRE_RAMO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ramo)
                    .HasColumnName("RAMO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Sector)
                    .HasColumnName("SECTOR")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RifAsociadoProspecto>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Rif Asociado Prospecto");

                entity.Property(e => e.Avenida)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Calle)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoPostal)
                    .HasColumnName("Codigo_Postal")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoProspecto)
                    .IsRequired()
                    .HasColumnName("Codigo_Prospecto")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Edificio)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaExpide)
                    .HasColumnName("Fecha_Expide")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Municipio)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nit)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Numero)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Piso)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RazonSocial)
                    .HasColumnName("Razon_Social")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Rif)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Urbanizacion)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Zona)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SapFuncionesInterlocutor>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sap_FuncionesInterlocutor");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Id).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Ktokd)
                    .IsRequired()
                    .HasColumnName("KTOKD")
                    .HasMaxLength(4);

                entity.Property(e => e.NombreTipo)
                    .IsRequired()
                    .HasMaxLength(50);
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

            modelBuilder.Entity<TipoRif>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Rif)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VClientesFaltantes>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_clientes_faltantes");

                entity.Property(e => e.AreaCobranz)
                    .HasColumnName("Area_Cobranz")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Asignacion)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Canal)
                    .HasColumnName("CANAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CapitalSoc)
                    .HasColumnName("CAPITAL_SOC")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Categoria)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CierreEjerc)
                    .HasColumnName("CIERRE_EJERC")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ClientContado)
                    .HasColumnName("Client_Contado")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClienteNuevo)
                    .HasColumnName("Cliente_Nuevo")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cobrador)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodJde).HasColumnName("cod_jde");

                entity.Property(e => e.CodMcpo)
                    .HasColumnName("Cod_Mcpo")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodProveedor)
                    .HasColumnName("Cod_Proveedor")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodSubSegmento)
                    .HasColumnName("Cod_SubSegmento")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoCiudad)
                    .HasColumnName("Codigo_Ciudad")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoEstado)
                    .HasColumnName("Codigo_Estado")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoMcpo)
                    .HasColumnName("Codigo_Mcpo")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoNumerico).HasColumnName("codigo_numerico");

                entity.Property(e => e.CodigoParroq)
                    .HasColumnName("Codigo_Parroq")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoPostal)
                    .HasColumnName("Codigo_Postal")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoRegion)
                    .HasColumnName("Codigo_Region")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CondPago)
                    .HasColumnName("COND_PAGO")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ContCarg1)
                    .HasColumnName("Cont_Carg_1")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContCarg2)
                    .HasColumnName("Cont_Carg_2")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContCarg3)
                    .HasColumnName("Cont_Carg_3")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContEmail1)
                    .HasColumnName("Cont_Email_1")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContEmail2)
                    .HasColumnName("Cont_Email_2")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContEmail3)
                    .HasColumnName("Cont_Email_3")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContEspecial)
                    .HasColumnName("Cont_Especial")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContFechNacm1)
                    .HasColumnName("Cont_FechNacm_1")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ContFechNacm2)
                    .HasColumnName("Cont_FechNacm_2")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ContFechNacm3)
                    .HasColumnName("Cont_FechNacm_3")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ContNomb1)
                    .HasColumnName("Cont_Nomb_1")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContNomb2)
                    .HasColumnName("Cont_Nomb_2")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContNomb3)
                    .HasColumnName("Cont_Nomb_3")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContTelf1)
                    .HasColumnName("Cont_Telf_1")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContTelf2)
                    .HasColumnName("Cont_Telf_2")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContTelf3)
                    .HasColumnName("Cont_Telf_3")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DepuraCod)
                    .HasColumnName("DEPURA_COD")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DiaDeCobro)
                    .HasColumnName("Dia_de_Cobro")
                    .HasMaxLength(10)
                    .IsUnicode(false)
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
                    .HasColumnName("E_mail_Client")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ExentoDeImpuesto)
                    .HasColumnName("Exento_de_Impuesto")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Expr1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Expr3).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.FApertura)
                    .HasColumnName("F_Apertura")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FModificacion)
                    .HasColumnName("F_Modificacion")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FUltmCompra)
                    .HasColumnName("F_Ultm_Compra")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Fax)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaCerrado)
                    .HasColumnName("Fecha_Cerrado")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaInactivo)
                    .HasColumnName("Fecha_Inactivo")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaLegal)
                    .HasColumnName("FECHA_LEGAL")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaReactivado)
                    .HasColumnName("Fecha_Reactivado")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaRiesgo)
                    .HasColumnName("FECHA_RIESGO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FlagCerrado)
                    .HasColumnName("Flag_Cerrado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagInactivo)
                    .HasColumnName("Flag_Inactivo")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagMat)
                    .HasColumnName("Flag_Mat")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagMod03)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagModificado)
                    .HasColumnName("Flag_Modificado")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagNuevo)
                    .HasColumnName("Flag_Nuevo")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GiroNegocio)
                    .HasColumnName("Giro_Negocio")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Grupo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GrupoCliente)
                    .HasColumnName("GRUPO_CLIENTE")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.LCredito)
                    .HasColumnName("L_Credito")
                    .HasColumnType("money");

                entity.Property(e => e.Legal)
                    .HasColumnName("LEGAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LimiteCredUt)
                    .HasColumnName("Limite_Cred_Ut")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.Nit)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NoRegTribut)
                    .HasColumnName("No_Reg_Tribut")
                    .HasMaxLength(12)
                    .IsUnicode(false)
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
                    .HasColumnName("Oficina_Venta")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrdenCompra)
                    .HasColumnName("Orden_Compra")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PaginaWeb)
                    .HasColumnName("Pagina_Web")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RepresLegal)
                    .HasColumnName("Repres_Legal")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Riesgo)
                    .HasColumnName("RIESGO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RutCartero)
                    .HasColumnName("Rut_Cartero")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Segmento)
                    .HasMaxLength(10)
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
                    .HasColumnName("Tipo_Negocio")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioMod)
                    .HasColumnName("USUARIO_MOD")
                    .HasMaxLength(30)
                    .IsUnicode(false)
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

            modelBuilder.Entity<VDiccionarioclientes>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_DICCIONARIOCLIENTES");

                entity.Property(e => e.Basededatos)
                    .IsRequired()
                    .HasColumnName("basededatos")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Colid).HasColumnName("colid");

                entity.Property(e => e.Field).HasMaxLength(128);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Length).HasColumnName("length");

                entity.Property(e => e.Modulo).HasMaxLength(3);

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

                entity.Property(e => e.Xtype).HasColumnName("xtype");
            });

            modelBuilder.Entity<VDiferentesf010131>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Diferentesf010131");

                entity.Property(e => e.Abalky)
                    .HasColumnName("ABALKY")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Abalph)
                    .HasColumnName("ABALPH")
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.Aban8).HasColumnName("ABAN8");

                entity.Property(e => e.Abat1)
                    .HasColumnName("ABAT1")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Absbli)
                    .HasColumnName("ABSBLI")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Abtax)
                    .HasColumnName("ABTAX")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Abupmj)
                    .HasColumnName("ABUPMJ")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Rif31).HasMaxLength(12);
            });

            modelBuilder.Entity<VDireccionesComerciales>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_DireccionesComerciales");

                entity.Property(e => e.Codigo).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(240)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Municipio)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreParroquia)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<VRepetidos>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_REPETIDOS");

                entity.Property(e => e.CodJde).HasColumnName("cod_jde");
            });

            modelBuilder.Entity<VResumenEmail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_resumen_email");

                entity.Property(e => e.EmailCliente)
                    .HasColumnName("email_cliente")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdCarta).HasColumnName("id_carta");
            });

            modelBuilder.Entity<VResumenEmailCarta2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_RESUMEN_EMAIL_CARTA2");

                entity.Property(e => e.EmailCliente)
                    .HasColumnName("email_cliente")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdCarta).HasColumnName("id_carta");

                entity.Property(e => e.Orden)
                    .HasColumnName("orden")
                    .HasColumnType("decimal(10, 0)");
            });

            modelBuilder.Entity<View1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW1");

                entity.Property(e => e.Campo)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<View2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW2");

                entity.Property(e => e.Asignacion)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AsignacionActual)
                    .HasColumnName("ASIGNACION_ACTUAL")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cobrador)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CobradorActual)
                    .HasColumnName("COBRADOR_ACTUAL")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoActual)
                    .HasColumnName("CODIGO_ACTUAL")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Diferente).HasColumnName("diferente");

                entity.Property(e => e.Monto)
                    .HasColumnName("MONTO")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Saldo)
                    .HasColumnName("SALDO")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Vendedor1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VendedorActual)
                    .HasColumnName("VENDEDOR_ACTUAL")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<View3>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view3");

                entity.Property(e => e.Asignacion)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AsignacionActual)
                    .HasColumnName("ASIGNACION_ACTUAL")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cobrador)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CobradorActual)
                    .HasColumnName("COBRADOR_ACTUAL")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoActual)
                    .HasColumnName("CODIGO_ACTUAL")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Diferente).HasColumnName("diferente");

                entity.Property(e => e.Monto)
                    .HasColumnName("MONTO")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Saldo)
                    .HasColumnName("SALDO")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Vendedor1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VendedorActual)
                    .HasColumnName("VENDEDOR_ACTUAL")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VistaClienteVendedores>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vista Cliente Vendedores");

                entity.Property(e => e.Activo)
                    .HasColumnName("ACTIVO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomVendedor)
                    .HasColumnName("Nom_vendedor")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Vendedor1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Winy242>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("winy242");

                entity.Property(e => e.CapitalEstado)
                    .HasColumnName("CAPITAL_ESTADO")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoEstado)
                    .HasColumnName("CODIGO_ESTADO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NombreEstado)
                    .HasColumnName("NOMBRE_ESTADO")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RecordNumber).HasColumnName("RECORD_NUMBER");
            });

            modelBuilder.Entity<Winy243>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("winy243");

                entity.Property(e => e.CapitalMcpo)
                    .HasColumnName("CAPITAL_MCPO")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

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

                entity.Property(e => e.DescMunicipio)
                    .HasColumnName("DESC_MUNICIPIO")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EdoMcpo)
                    .HasColumnName("EDO_MCPO")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PosicionRuta)
                    .HasColumnName("POSICION_RUTA")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.RecordNumber).HasColumnName("RECORD_NUMBER");

                entity.Property(e => e.ZonaDespacho)
                    .HasColumnName("ZONA_DESPACHO")
                    .HasColumnType("decimal(2, 0)");
            });

            modelBuilder.Entity<Wsmy0032>(entity =>
            {
                entity.HasKey(e => e.Rif);

                entity.ToTable("WSMY0032");

                entity.Property(e => e.Rif)
                    .HasColumnName("RIF")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CapitalEstado)
                    .HasColumnName("CAPITAL_ESTADO")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoEstado)
                    .HasColumnName("CODIGO_ESTADO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodigoMcpo)
                    .HasColumnName("CODIGO_MCPO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DescMunicipio)
                    .HasColumnName("DESC_MUNICIPIO")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Direccion1)
                    .HasColumnName("DIRECCION1")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Direccion2)
                    .HasColumnName("DIRECCION2")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Direccion3)
                    .HasColumnName("DIRECCION3")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NombreEstado)
                    .HasColumnName("NOMBRE_ESTADO")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RazonSocial)
                    .HasColumnName("RAZON_SOCIAL")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Wsmy003a>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WSMY003A");

                entity.Property(e => e.ActividadEco)
                    .HasColumnName("ACTIVIDAD_ECO")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Asignacion)
                    .HasColumnName("ASIGNACION")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.Ciudad)
                    .HasColumnName("CIUDAD")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Clave)
                    .HasColumnName("CLAVE")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Clave1)
                    .HasColumnName("CLAVE1")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Clave3)
                    .HasColumnName("CLAVE3")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClientContado)
                    .HasColumnName("CLIENT_CONTADO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

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

                entity.Property(e => e.CodMcpo)
                    .HasColumnName("COD_MCPO")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodPostal)
                    .HasColumnName("COD_POSTAL")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodProv)
                    .HasColumnName("COD_PROV")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Codigo)
                    .HasColumnName("CODIGO")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.CteMatriz)
                    .HasColumnName("CTE_MATRIZ")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DiaCobroJu)
                    .HasColumnName("DIA_COBRO_JU")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DiaCobroLu)
                    .HasColumnName("DIA_COBRO_LU")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DiaCobroMa)
                    .HasColumnName("DIA_COBRO_MA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DiaCobroMi)
                    .HasColumnName("DIA_COBRO_MI")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DiaCobroSa)
                    .HasColumnName("DIA_COBRO_SA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DiaCobroVi)
                    .HasColumnName("DIA_COBRO_VI")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

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

                entity.Property(e => e.Especial)
                    .HasColumnName("ESPECIAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Fax)
                    .HasColumnName("FAX")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.FechaCambio)
                    .HasColumnName("FECHA_CAMBIO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaVenRegm)
                    .HasColumnName("FECHA_VEN_REGM")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagCambio)
                    .HasColumnName("FLAG_CAMBIO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagInactivo)
                    .HasColumnName("FLAG_INACTIVO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GeoEstado)
                    .HasColumnName("GEO_ESTADO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GeoMunParr)
                    .HasColumnName("GEO_MUN_PARR")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Grupo)
                    .HasColumnName("GRUPO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LCredito)
                    .HasColumnName("L_CREDITO")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Municipio)
                    .HasColumnName("MUNICIPIO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Observacion)
                    .HasColumnName("OBSERVACION")
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Parada)
                    .HasColumnName("PARADA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PromHistorico)
                    .HasColumnName("PROM_HISTORICO")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.RamoNegocio)
                    .HasColumnName("RAMO_NEGOCIO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RecordNumber).HasColumnName("RECORD_NUMBER");

                entity.Property(e => e.Region)
                    .HasColumnName("REGION")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Rif)
                    .HasColumnName("RIF")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Saldoact)
                    .HasColumnName("SALDOACT")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.SectorNegocio)
                    .HasColumnName("SECTOR_NEGOCIO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Solvencia)
                    .HasColumnName("SOLVENCIA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sucursal)
                    .HasColumnName("SUCURSAL")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.SumaHistorico)
                    .HasColumnName("SUMA_HISTORICO")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.SumaProceso)
                    .HasColumnName("SUMA_PROCESO")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.TImpuesto)
                    .HasColumnName("T_IMPUESTO")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Telefono)
                    .HasColumnName("TELEFONO")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Telex)
                    .HasColumnName("TELEX")
                    .HasColumnType("decimal(6, 0)");

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

                entity.Property(e => e.Zona)
                    .HasColumnName("ZONA")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Wsmy063>(entity =>
            {
                entity.HasKey(e => e.Tipo);

                entity.ToTable("WSMY063");

                entity.Property(e => e.Tipo)
                    .HasColumnName("TIPO")
                    .ValueGeneratedNever();

                entity.Property(e => e.EsGobierno)
                    .IsRequired()
                    .HasColumnName("ES_GOBIERNO")
                    .HasMaxLength(1);

                entity.Property(e => e.FechaCambio)
                    .HasColumnName("FECHA_CAMBIO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.NombreTipo)
                    .IsRequired()
                    .HasColumnName("NOMBRE_TIPO")
                    .HasMaxLength(15);

                entity.Property(e => e.TipoSap).HasMaxLength(2);
            });

            modelBuilder.Entity<Wsmy063Consulta>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("WSMY063_CONSULTA");

                entity.Property(e => e.NombreTipo)
                    .HasColumnName("NOMBRE_TIPO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasColumnName("TIPO")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Wsmy064>(entity =>
            {
                entity.HasKey(e => e.Sector);

                entity.ToTable("WSMY064");

                entity.Property(e => e.Sector)
                    .HasColumnName("SECTOR")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Clave)
                    .HasColumnName("CLAVE")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaCambio)
                    .HasColumnName("FECHA_CAMBIO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.NombreSector)
                    .IsRequired()
                    .HasColumnName("NOMBRE_SECTOR")
                    .HasMaxLength(60);

                entity.Property(e => e.RecordNumber).HasColumnName("RECORD_NUMBER");

                entity.Property(e => e.SectorSap).HasMaxLength(4);

                entity.Property(e => e.Tipo)
                    .HasColumnName("TIPO")
                    .HasColumnType("decimal(2, 0)");
            });

            modelBuilder.Entity<Wsmy065>(entity =>
            {
                entity.HasKey(e => new { e.Sector, e.Ramo });

                entity.ToTable("WSMY065");

                entity.Property(e => e.Sector)
                    .HasColumnName("SECTOR")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Ramo)
                    .HasColumnName("RAMO")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.Clave)
                    .HasColumnName("CLAVE")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Clave1)
                    .HasColumnName("CLAVE1")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaCambio)
                    .HasColumnName("FECHA_CAMBIO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.NombreRamo)
                    .IsRequired()
                    .HasColumnName("NOMBRE_RAMO")
                    .HasMaxLength(150);

                entity.Property(e => e.RamoSap).HasMaxLength(10);

                entity.Property(e => e.RecordNumber).HasColumnName("RECORD_NUMBER");

                entity.Property(e => e.Tipo)
                    .HasColumnName("TIPO")
                    .HasColumnType("decimal(2, 0)");

                entity.HasOne(d => d.SectorNavigation)
                    .WithMany(p => p.Wsmy065)
                    .HasForeignKey(d => d.Sector)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WSMY065_WSMY064");
            });

            modelBuilder.Entity<Wsmy264>(entity =>
            {
                entity.ToTable("WSMY264");

                entity.HasIndex(e => e.Codigo)
                    .HasName("IX_WSMY264_3");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_WSMY264_2");

                entity.HasIndex(e => e.Recnum)
                    .HasName("IX_WSMY264_5")
                    .IsUnique();

                entity.HasIndex(e => e.Rif)
                    .HasName("IX_WSMY264_4");

                entity.HasIndex(e => new { e.Codigo, e.Rif })
                    .HasName("IX_WSMY264_1");

                entity.HasIndex(e => new { e.Codigo, e.Rif, e.IdDireccion })
                    .HasName("IX_WSMY264");

                entity.HasIndex(e => new { e.Codigo, e.Direccion, e.Direccion1, e.Municipio, e.Ort02, e.Direccion2, e.Estado, e.Inactivo, e.FuncionInterlocutor })
                    .HasName("IX_WSMY264_6");

                entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Codigo).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Direccion1)
                    .HasColumnName("Direccion_1")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Direccion2)
                    .HasColumnName("Direccion_2")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaAprobacionDireccion).HasMaxLength(50);

                entity.Property(e => e.FechaUpdate).HasColumnType("smalldatetime");

                entity.Property(e => e.FuncionInterlocutor).HasMaxLength(2);

                entity.Property(e => e.IdDireccion)
                    .HasColumnName("Id_Direccion")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Inactivo).HasDefaultValueSql("((0))");

                entity.Property(e => e.Municipio)
                    .HasColumnName("MUNICIPIO")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nuevo)
                    .HasColumnName("NUEVO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Origen).HasMaxLength(40);

                entity.Property(e => e.Ort02)
                    .HasColumnName("ORT02")
                    .HasMaxLength(35);

                entity.Property(e => e.PuntoReferencia).HasMaxLength(80);

                entity.Property(e => e.Recnum)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Rif)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StmpAddr)
                    .HasColumnName("STMP_ADDR")
                    .HasMaxLength(240);

                entity.Property(e => e.Telf1)
                    .HasColumnName("TELF1")
                    .HasMaxLength(30);

                entity.Property(e => e.Telf2)
                    .HasColumnName("TELF2")
                    .HasMaxLength(30);

                entity.Property(e => e.UsuarioAprobacionDireccion).HasMaxLength(50);

                entity.Property(e => e.Zzsn01)
                    .HasColumnName("ZZSN01")
                    .HasMaxLength(50);

                entity.Property(e => e.Zzsn02)
                    .HasColumnName("ZZSN02")
                    .HasMaxLength(50);

                entity.Property(e => e.Zzsn03)
                    .HasColumnName("ZZSN03")
                    .HasMaxLength(50);

                entity.Property(e => e.Zzsn04)
                    .HasColumnName("ZZSN04")
                    .HasMaxLength(50);

                entity.Property(e => e.Zzsn05)
                    .HasColumnName("ZZSN05")
                    .HasMaxLength(50);

                entity.Property(e => e.Zzsn06)
                    .HasColumnName("ZZSN06")
                    .HasMaxLength(8);
            });

            modelBuilder.Entity<Wsmy26410122015>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WSMY26410122015");

                entity.HasIndex(e => e.Codigo)
                    .HasName("IX_WSMY26410122015");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_WSMY26410122015_1");

                entity.Property(e => e.Codigo).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Direccion1)
                    .HasColumnName("Direccion_1")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Direccion2)
                    .HasColumnName("Direccion_2")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaAprobacionDireccion).HasMaxLength(50);

                entity.Property(e => e.FechaUpdate).HasColumnType("smalldatetime");

                entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdDireccion)
                    .HasColumnName("Id_Direccion")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Municipio)
                    .HasColumnName("MUNICIPIO")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nuevo)
                    .HasColumnName("NUEVO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Origen).HasMaxLength(40);

                entity.Property(e => e.PuntoReferencia).HasMaxLength(80);

                entity.Property(e => e.Recnum).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Rif)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioAprobacionDireccion).HasMaxLength(50);
            });

            modelBuilder.Entity<Wsmy264IdDuplicados>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Codigo).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Direccion1)
                    .HasColumnName("Direccion_1")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Direccion2)
                    .HasColumnName("Direccion_2")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaAprobacionDireccion).HasMaxLength(50);

                entity.Property(e => e.FechaUpdate).HasColumnType("smalldatetime");

                entity.Property(e => e.FuncionInterlocutor).HasMaxLength(2);

                entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdDireccion)
                    .HasColumnName("Id_Direccion")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Ident).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Municipio)
                    .HasColumnName("MUNICIPIO")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nuevo)
                    .HasColumnName("NUEVO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Origen).HasMaxLength(40);

                entity.Property(e => e.Ort02)
                    .HasColumnName("ORT02")
                    .HasMaxLength(35);

                entity.Property(e => e.PuntoReferencia).HasMaxLength(80);

                entity.Property(e => e.Recnum)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Rif)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StmpAddr)
                    .HasColumnName("STMP_ADDR")
                    .HasMaxLength(240);

                entity.Property(e => e.Telf1)
                    .HasColumnName("TELF1")
                    .HasMaxLength(30);

                entity.Property(e => e.Telf2)
                    .HasColumnName("TELF2")
                    .HasMaxLength(30);

                entity.Property(e => e.UsuarioAprobacionDireccion).HasMaxLength(50);

                entity.Property(e => e.Zzsn01)
                    .HasColumnName("ZZSN01")
                    .HasMaxLength(50);

                entity.Property(e => e.Zzsn02)
                    .HasColumnName("ZZSN02")
                    .HasMaxLength(50);

                entity.Property(e => e.Zzsn03)
                    .HasColumnName("ZZSN03")
                    .HasMaxLength(50);

                entity.Property(e => e.Zzsn04)
                    .HasColumnName("ZZSN04")
                    .HasMaxLength(50);

                entity.Property(e => e.Zzsn05)
                    .HasColumnName("ZZSN05")
                    .HasMaxLength(50);

                entity.Property(e => e.Zzsn06)
                    .HasColumnName("ZZSN06")
                    .HasMaxLength(8);
            });

            modelBuilder.Entity<Wsmy264Temp>(entity =>
            {
                entity.ToTable("WSMY264_Temp");

                entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Codigo).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Direccion1)
                    .HasColumnName("Direccion_1")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Direccion2)
                    .HasColumnName("Direccion_2")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaAprobacionDireccion).HasMaxLength(50);

                entity.Property(e => e.FechaUpdate).HasColumnType("smalldatetime");

                entity.Property(e => e.FuncionInterlocutor).HasMaxLength(2);

                entity.Property(e => e.IdDireccion)
                    .HasColumnName("Id_Direccion")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Inactivo).HasDefaultValueSql("((0))");

                entity.Property(e => e.Municipio)
                    .HasColumnName("MUNICIPIO")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nuevo)
                    .HasColumnName("NUEVO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Origen).HasMaxLength(40);

                entity.Property(e => e.Ort02)
                    .HasColumnName("ORT02")
                    .HasMaxLength(35);

                entity.Property(e => e.PuntoReferencia).HasMaxLength(80);

                entity.Property(e => e.Recnum)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Rif)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StmpAddr)
                    .HasColumnName("STMP_ADDR")
                    .HasMaxLength(240);

                entity.Property(e => e.Telf1)
                    .HasColumnName("TELF1")
                    .HasMaxLength(30);

                entity.Property(e => e.Telf2)
                    .HasColumnName("TELF2")
                    .HasMaxLength(30);

                entity.Property(e => e.UsuarioAprobacionDireccion).HasMaxLength(50);

                entity.Property(e => e.Zzsn01)
                    .HasColumnName("ZZSN01")
                    .HasMaxLength(50);

                entity.Property(e => e.Zzsn02)
                    .HasColumnName("ZZSN02")
                    .HasMaxLength(50);

                entity.Property(e => e.Zzsn03)
                    .HasColumnName("ZZSN03")
                    .HasMaxLength(50);

                entity.Property(e => e.Zzsn04)
                    .HasColumnName("ZZSN04")
                    .HasMaxLength(50);

                entity.Property(e => e.Zzsn05)
                    .HasColumnName("ZZSN05")
                    .HasMaxLength(50);

                entity.Property(e => e.Zzsn06)
                    .HasColumnName("ZZSN06")
                    .HasMaxLength(8);
            });

            modelBuilder.Entity<Wsmy265>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("WSMY265");

                entity.HasIndex(e => e.Email)
                    .HasName("IX_WSMY265_1");

                entity.HasIndex(e => new { e.Cliente, e.Rif, e.Id })
                    .HasName("IX_WSMY265")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AceptaEmail)
                    .HasColumnName("ACEPTA_EMAIL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AceptaSms)
                    .HasColumnName("ACEPTA_SMS")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Area)
                    .HasColumnName("AREA")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("(' ')")
                    .HasComment("AREA O DEPARTAMENTO");

                entity.Property(e => e.Cargo)
                    .HasColumnName("CARGO")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("(' ')")
                    .HasComment("CARGO ACTUAL");

                entity.Property(e => e.Cliente)
                    .HasColumnName("CLIENTE")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("NOMBRE DEL CLIENTE");

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(' ')")
                    .HasComment("CORREO ELECTRONOCO");

                entity.Property(e => e.Fax)
                    .HasColumnName("FAX")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("(' ')")
                    .HasComment("FAX");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("Fecha_Creacion")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaCumpleanos)
                    .HasColumnName("FECHA_CUMPLEANOS")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdContactos)
                    .HasColumnName("ID_CONTACTOS")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Inactivo)
                    .HasColumnName("INACTIVO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("(' ')")
                    .HasComment("NOMBRE DEL CONTACTO");

                entity.Property(e => e.Prospecto)
                    .HasColumnName("PROSPECTO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Rif)
                    .HasColumnName("RIF")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("(' ')")
                    .HasComment("NÚMERO DE RIF");

                entity.Property(e => e.TelefonoCelular)
                    .HasColumnName("TELEFONO_CELULAR")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("(' ')")
                    .HasComment("CELULAR");

                entity.Property(e => e.TelefonoOficina1)
                    .HasColumnName("TELEFONO_OFICINA1")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("(' ')")
                    .HasComment("TELEFONO 1");

                entity.Property(e => e.TelefonoOficina2)
                    .HasColumnName("TELEFONO_OFICINA2")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("(' ')")
                    .HasComment("TELEFONO 2");

                entity.Property(e => e.TomaDecision)
                    .HasColumnName("TOMA_DECISION")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Wsmy266>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.ToTable("WSMY266");

                entity.Property(e => e.Codigo)
                    .HasColumnName("CODIGO")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(30);

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaModificado)
                    .HasColumnName("FECHA_MODIFICADO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdSap)
                    .IsRequired()
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<Wsmy267>(entity =>
            {
                entity.HasKey(e => new { e.CodZona, e.Oficina });

                entity.ToTable("WSMY267");

                entity.Property(e => e.CodZona)
                    .HasColumnName("COD_ZONA")
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Oficina)
                    .HasColumnName("OFICINA")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.LimiteDesde)
                    .HasColumnName("LIMITE_DESDE")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LimiteHasta)
                    .HasColumnName("LIMITE_HASTA")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Observacion)
                    .HasColumnName("OBSERVACION")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sector)
                    .HasColumnName("SECTOR")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Wsmy269>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WSMY269");

                entity.Property(e => e.CodOficina)
                    .HasColumnName("COD_OFICINA")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CodSolicitud)
                    .HasColumnName("COD_SOLICITUD")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Codigo)
                    .HasColumnName("CODIGO")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Estatus)
                    .HasColumnName("ESTATUS")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaAprob)
                    .HasColumnName("FECHA_APROB")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaGer)
                    .HasColumnName("FECHA_GER")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaReg)
                    .HasColumnName("FECHA_REG")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaSolicitud)
                    .HasColumnName("FECHA_SOLICITUD")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaTeam)
                    .HasColumnName("FECHA_TEAM")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ObservAprob)
                    .HasColumnName("OBSERV_APROB")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ObservSolicitud)
                    .HasColumnName("OBSERV_SOLICITUD")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ObservSolicitudGer)
                    .HasColumnName("OBSERV_SOLICITUD_GER")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ObservSolicitudReg)
                    .HasColumnName("OBSERV_SOLICITUD_REG")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ObservSolicitudTeam)
                    .HasColumnName("OBSERV_SOLICITUD_TEAM")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Procesado)
                    .HasColumnName("PROCESADO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Rif)
                    .HasColumnName("RIF")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SinRif)
                    .HasColumnName("SIN_RIF")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UserAprob)
                    .HasColumnName("USER_APROB")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UserGer)
                    .HasColumnName("USER_GER")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UserReg)
                    .HasColumnName("USER_REG")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UserSolicitud)
                    .HasColumnName("USER_SOLICITUD")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UserTeam)
                    .HasColumnName("USER_TEAM")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Wsmy270>(entity =>
            {
                entity.HasKey(e => e.CodAsignacion);

                entity.ToTable("WSMY270");

                entity.Property(e => e.CodAsignacion)
                    .HasColumnName("Cod_Asignacion")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CodOficina)
                    .HasColumnName("Cod_Oficina")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaCreado)
                    .HasColumnName("Fecha_Creado")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaModificado)
                    .HasColumnName("Fecha_Modificado")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Inactiva)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoAsig)
                    .HasColumnName("Tipo_Asig")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UserCreado)
                    .HasColumnName("User_Creado")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UserModificado)
                    .HasColumnName("User_Modificado")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Wsmy271>(entity =>
            {
                entity.HasKey(e => new { e.CodSolicitud, e.CodOficina, e.CodCliente });

                entity.ToTable("WSMY271");

                entity.HasIndex(e => e.CodSolicitud)
                    .HasName("IX_WSMY271");

                entity.HasIndex(e => new { e.CodCliente, e.Cerrado })
                    .HasName("IX_WSMY271_1");

                entity.Property(e => e.CodSolicitud).HasColumnName("Cod_Solicitud");

                entity.Property(e => e.CodOficina).HasColumnName("Cod_Oficina");

                entity.Property(e => e.CodCliente).HasColumnName("Cod_Cliente");

                entity.Property(e => e.AsigActual).HasColumnName("Asig_Actual");

                entity.Property(e => e.AsigNueva).HasColumnName("Asig_Nueva");

                entity.Property(e => e.Cerrado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodGrupo).HasColumnName("Cod_Grupo");

                entity.Property(e => e.CodMotivo).HasColumnName("Cod_Motivo");

                entity.Property(e => e.FechaAnulacion)
                    .HasColumnName("Fecha_Anulacion")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaAprob)
                    .HasColumnName("Fecha_Aprob")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaSolicitud)
                    .HasColumnName("Fecha_Solicitud")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ObservAnulacion)
                    .HasColumnName("Observ_Anulacion")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ObservAprob)
                    .HasColumnName("Observ_Aprob")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ObservSolicitud)
                    .HasColumnName("Observ_Solicitud")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Status)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UserAnulacion)
                    .HasColumnName("User_Anulacion")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UserAprob)
                    .HasColumnName("User_Aprob")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UserSolicitud)
                    .HasColumnName("User_Solicitud")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VendActual)
                    .HasColumnName("Vend_Actual")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VendNuevo)
                    .HasColumnName("Vend_Nuevo")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Wsmy272>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WSMY272");

                entity.HasIndex(e => e.IdRegistro)
                    .HasName("IX_WSMY272")
                    .IsUnique();

                entity.Property(e => e.CodCliente)
                    .HasColumnName("Cod_Cliente")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CodGrupo).HasColumnName("Cod_Grupo");

                entity.Property(e => e.CodMotivo).HasColumnName("Cod_Motivo");

                entity.Property(e => e.CodOficina)
                    .HasColumnName("Cod_Oficina")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CodSolicitud)
                    .HasColumnName("Cod_Solicitud")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FechaRechazo)
                    .HasColumnName("Fecha_Rechazo")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdRegistro).ValueGeneratedOnAdd();

                entity.Property(e => e.ObservRechazo)
                    .HasColumnName("Observ_Rechazo")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UserRechazo)
                    .HasColumnName("User_Rechazo")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Wsmy274>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WSMY274");

                entity.Property(e => e.CodGrupo).HasColumnName("Cod_Grupo");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaModificado)
                    .HasColumnName("Fecha_Modificado")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdUsuario).HasColumnName("Id_Usuario");

                entity.Property(e => e.TiempoDias).HasColumnName("Tiempo_dias");

                entity.Property(e => e.UserModificado)
                    .HasColumnName("User_Modificado")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Wsmy275>(entity =>
            {
                entity.HasKey(e => e.CodGrupo);

                entity.ToTable("WSMY275");

                entity.HasIndex(e => e.Descripcion)
                    .HasName("IX_WSMY275");

                entity.Property(e => e.CodGrupo)
                    .HasColumnName("Cod_Grupo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Wsmy276>(entity =>
            {
                entity.HasKey(e => e.CodDefinicion);

                entity.ToTable("WSMY276");

                entity.Property(e => e.CodDefinicion)
                    .HasColumnName("Cod_Definicion")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaModificacion)
                    .HasColumnName("Fecha_Modificacion")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FlagAnulacion).HasMaxLength(1);

                entity.Property(e => e.UserModificacion)
                    .HasColumnName("User_Modificacion")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Wsmy277>(entity =>
            {
                entity.HasKey(e => new { e.CodMotivo, e.CodGrupo });

                entity.ToTable("WSMY277");

                entity.Property(e => e.CodMotivo).HasColumnName("Cod_Motivo");

                entity.Property(e => e.CodGrupo).HasColumnName("Cod_Grupo");

                entity.Property(e => e.CodDefinicion).HasColumnName("Cod_definicion");

                entity.Property(e => e.DescripcionMotivo)
                    .HasColumnName("Descripcion_Motivo")
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaModificacion)
                    .HasColumnName("Fecha_Modificacion")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UserModificacion)
                    .HasColumnName("User_Modificacion")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Wsmy278>(entity =>
            {
                entity.ToTable("WSMY278");

                entity.HasIndex(e => e.FechaRegistro)
                    .HasName("WSMY278FechaRegistro");

                entity.HasIndex(e => e.NombreCliente)
                    .HasName("IX_WSMY278_1");

                entity.HasIndex(e => e.Numero)
                    .HasName("Wsmy278Numero");

                entity.HasIndex(e => e.Orden)
                    .HasName("Wsmy278Orden");

                entity.HasIndex(e => new { e.Flag, e.IdCarta, e.EmailCliente, e.Orden, e.NombreProducto })
                    .HasName("IX_WSMY278");

                entity.Property(e => e.Bultos).HasColumnName("bultos");

                entity.Property(e => e.CantFormas)
                    .HasColumnName("CANT_FORMAS")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Documento)
                    .HasColumnName("documento")
                    .HasColumnType("decimal(10, 0)");

                entity.Property(e => e.EmailCliente)
                    .HasColumnName("email_cliente")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EmailVendedor)
                    .HasColumnName("email_vendedor")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Flag)
                    .HasColumnName("flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdCarta).HasColumnName("id_carta");

                entity.Property(e => e.NombreCliente)
                    .HasColumnName("nombre_cliente")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NombreContacto)
                    .HasColumnName("nombre_contacto")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NombreProducto)
                    .HasColumnName("nombre_producto")
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NombreVendedor)
                    .HasColumnName("NOMBRE_VENDEDOR")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NroGuia)
                    .HasColumnName("nro_guia")
                    .HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Numero).HasColumnName("numero");

                entity.Property(e => e.Orden)
                    .HasColumnName("orden")
                    .HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Transporte)
                    .HasColumnName("transporte")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UnidadCosteo)
                    .HasColumnName("UNIDAD_COSTEO")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Wsmy279>(entity =>
            {
                entity.HasKey(e => e.IdCarta);

                entity.ToTable("WSMY279");

                entity.Property(e => e.IdCarta)
                    .HasColumnName("id_carta")
                    .ValueGeneratedNever();

                entity.Property(e => e.Asunto)
                    .HasColumnName("asunto")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Firma)
                    .HasColumnName("firma")
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdFile)
                    .HasColumnName("ID_FILE")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NsfFile)
                    .HasColumnName("NSF_FILE")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Password)
                    .HasColumnName("PASSWORD")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Texto1)
                    .HasColumnName("texto1")
                    .HasColumnType("text");

                entity.Property(e => e.Texto2)
                    .HasColumnName("texto2")
                    .HasColumnType("text");

                entity.Property(e => e.Texto3)
                    .HasColumnName("texto3")
                    .HasColumnType("text");

                entity.Property(e => e.Texto4)
                    .HasColumnName("texto4")
                    .HasColumnType("ntext");

                entity.Property(e => e.Texto5)
                    .HasColumnName("texto5")
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<Wsmy280>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WSMY280");

                entity.Property(e => e.Documento)
                    .HasColumnName("DOCUMENTO")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("decimal(4, 0)");
            });

            modelBuilder.Entity<Wsmy281>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WSMY281");

                entity.HasIndex(e => e.IdRegistro)
                    .HasName("IX_WSMY281");

                entity.HasIndex(e => new { e.Solicitud, e.Oficina, e.Fecha })
                    .HasName("IX_WSMY281_1");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdRegistro).ValueGeneratedOnAdd();

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<Wsmy282>(entity =>
            {
                entity.HasKey(e => e.Usuario);

                entity.ToTable("WSMY282");

                entity.Property(e => e.Usuario).HasMaxLength(40);

                entity.Property(e => e.CodGrupo).HasColumnName("Cod_Grupo");

                entity.Property(e => e.IdRegistro).ValueGeneratedOnAdd();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
