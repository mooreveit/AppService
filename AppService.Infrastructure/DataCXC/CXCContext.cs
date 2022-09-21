using System;
using AppService.Core.EntitiesCXC;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AppService.Infrastructure.DataCXC
{
    public partial class CXCContext : DbContext
    {
        public CXCContext()
        {
        }

        public CXCContext(DbContextOptions<CXCContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Wary074> Wary074 { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=.;Database=CXC;Integrated Security = true");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Wary074>(entity =>
            {
                entity.HasKey(e => e.Recnum);

                entity.ToTable("WARY074");

                entity.HasComment("TRANSACCIONES PERMANENTE  CXC");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AO).HasColumnName("A#O");

                entity.Property(e => e.Afectanota)
                    .HasColumnName("AFECTANOTA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Anticipo).HasColumnName("ANTICIPO");

                entity.Property(e => e.AsigActual).HasColumnName("ASIG_ACTUAL");

                entity.Property(e => e.Banco)
                    .HasColumnName("BANCO")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Batch).HasColumnName("batch");

                entity.Property(e => e.Cambio)
                    .HasColumnName("CAMBIO")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Ciudad)
                    .IsRequired()
                    .HasColumnName("CIUDAD")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Cliente).HasColumnName("CLIENTE");

                entity.Property(e => e.Cobrador)
                    .IsRequired()
                    .HasColumnName("COBRADOR")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CodContrapart)
                    .HasColumnName("COD_CONTRAPART")
                    .HasMaxLength(50);

                entity.Property(e => e.ComisionPag)
                    .HasColumnName("COMISION_PAG")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Comisionpagada)
                    .HasColumnName("COMISIONPAGADA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CompLinea).HasColumnName("COMP_LINEA");

                entity.Property(e => e.Comprobante).HasColumnName("COMPROBANTE");

                entity.Property(e => e.Concepto)
                    .HasColumnName("CONCEPTO")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CondPago).HasColumnName("COND_PAGO");

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

                entity.Property(e => e.Depura)
                    .HasColumnName("DEPURA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Dias).HasColumnName("DIAS");

                entity.Property(e => e.DiasEntrega).HasColumnName("DIAS_ENTREGA");

                entity.Property(e => e.Diastransc).HasColumnName("DIASTRANSC");

                entity.Property(e => e.Diferencial)
                    .HasColumnName("DIFERENCIAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DocCanc)
                    .HasColumnName("DOC_CANC")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.DocJde)
                    .HasColumnName("doc_jde")
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Documento)
                    .HasColumnName("DOCUMENTO")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.DocumentoSap).HasMaxLength(10);

                entity.Property(e => e.Efectivo)
                    .HasColumnName("EFECTIVO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Eliminar)
                    .HasColumnName("ELIMINAR")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estacion)
                    .HasColumnName("ESTACION")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("ESTADO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FechaCobro)
                    .HasColumnName("FECHA_COBRO")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaComision).HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaEmision)
                    .HasColumnName("FECHA_EMISION")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.FechaEntrega)
                    .HasColumnName("FECHA_ENTREGA")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnName("FECHA_INGRESO")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.FechaPlanilla)
                    .HasColumnName("FECHA_PLANILLA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaUsuario)
                    .HasColumnName("FECHA_USUARIO")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaVcto)
                    .HasColumnName("FECHA_VCTO")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fechadoccanc)
                    .HasColumnName("FECHADOCCANC")
                    .HasColumnType("datetime");

                entity.Property(e => e.FecrecibPl)
                    .HasColumnName("FECRECIB_PL")
                    .HasColumnType("datetime");

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

                entity.Property(e => e.HoraCreacion)
                    .HasColumnName("HORA_CREACION")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HoraUsario).HasColumnName("HORA_USARIO");

                entity.Property(e => e.InformeQueja).HasColumnName("INFORME_QUEJA");

                entity.Property(e => e.LinCanc).HasColumnName("LIN_CANC");

                entity.Property(e => e.Linea).HasColumnName("LINEA");

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

                entity.Property(e => e.Mes).HasColumnName("MES");

                entity.Property(e => e.MinutosUsuario).HasColumnName("MINUTOS_USUARIO");

                entity.Property(e => e.Moneda)
                    .HasColumnName("MONEDA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Monto)
                    .HasColumnName("MONTO")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

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

                entity.Property(e => e.Nombre)
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NroPlanilla)
                    .HasColumnName("NRO_PLANILLA")
                    .HasMaxLength(25)
                    .IsFixedLength();

                entity.Property(e => e.Nrocheque)
                    .HasColumnName("NROCHEQUE")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumeroPl)
                    .HasColumnName("NUMERO_PL")
                    .HasDefaultValueSql("((0))");

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

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.PasoJde)
                    .HasColumnName("paso_jde")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PasoSql)
                    .IsRequired()
                    .HasColumnName("PASO_SQL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PlantaOficina).HasColumnName("PLANTA_OFICINA");

                entity.Property(e => e.PorIva)
                    .HasColumnName("POR_IVA")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Porcret)
                    .HasColumnName("PORCRET")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PosicionSap).HasMaxLength(3);

                entity.Property(e => e.Recalcular)
                    .HasColumnName("RECALCULAR")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RecibidaPl)
                    .HasColumnName("RECIBIDA_PL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Referencia).HasColumnName("REFERENCIA");

                entity.Property(e => e.Region)
                    .HasColumnName("REGION")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RegionActual)
                    .IsRequired()
                    .HasColumnName("REGION_ACTUAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.RelacionCobro).HasColumnName("RELACION_COBRO");

                entity.Property(e => e.Remisionma).HasColumnName("REMISIONMA");

                entity.Property(e => e.Remisionsi).HasColumnName("REMISIONSI");

                entity.Property(e => e.Rmonto)
                    .HasColumnName("RMONTO")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rsaldo)
                    .HasColumnName("RSALDO")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rzvre)
                    .HasColumnName("RZVRE")
                    .HasMaxLength(10);

                entity.Property(e => e.Saldo)
                    .HasColumnName("SALDO")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

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
                    .IsRequired()
                    .HasColumnName("TIPO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TipoCanc)
                    .IsRequired()
                    .HasColumnName("TIPO_CANC")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TipoCiudad)
                    .HasColumnName("TIPO_CIUDAD")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoCompania)
                    .IsRequired()
                    .HasColumnName("TIPO_COMPANIA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Transaccion)
                    .IsRequired()
                    .HasColumnName("TRANSACCION")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TransaccionSap).HasMaxLength(2);

                entity.Property(e => e.Transferencia)
                    .HasColumnName("TRANSFERENCIA")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UltimoPago)
                    .HasColumnName("ULTIMO_PAGO")
                    .HasColumnType("datetime");

                entity.Property(e => e.Usuario)
                    .HasColumnName("USUARIO")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VecesCobro).HasColumnName("VECES_COBRO");

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

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
