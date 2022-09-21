using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMaestros
{
    public partial class Wppy001
    {
        public decimal Recnum { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Descripcion2 { get; set; }
        public string Unidad { get; set; }
        public short Categoria { get; set; }
        public string Ubicacion { get; set; }
        public string Origen { get; set; }
        public short Invmay { get; set; }
        public short Invaux { get; set; }
        public int Invcco { get; set; }
        public short Conmay { get; set; }
        public short Conaux { get; set; }
        public int Concco { get; set; }
        public DateTime? FechaInicial { get; set; }
        public decimal PuntoReorden { get; set; }
        public decimal Minimo { get; set; }
        public decimal Maximo { get; set; }
        public decimal CantOrdenar { get; set; }
        public DateTime? FUltCompra { get; set; }
        public DateTime? FUltSalida { get; set; }
        public decimal UltCosto { get; set; }
        public decimal Qactual { get; set; }
        public decimal Qiniano { get; set; }
        public decimal Qentano { get; set; }
        public decimal Qsalano { get; set; }
        public string Abc { get; set; }
        public decimal Porcentaje { get; set; }
        public DateTime? FechaAbc { get; set; }
        public decimal ConsPromedio { get; set; }
        public short MaqUso { get; set; }
        public int Peso { get; set; }
        public int UltProvee { get; set; }
        public decimal CostoDolar { get; set; }
        public string NroParte { get; set; }
        public string Dimension { get; set; }
        public decimal CostoProm { get; set; }
        public short DiasEntrega { get; set; }
        public int CtdUnd { get; set; }
        public int CtdMinDesp { get; set; }
        public DateTime? FechaCreacion { get; set; }
    }
}
