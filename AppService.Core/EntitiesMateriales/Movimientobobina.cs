using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMateriales
{
    public partial class Movimientobobina
    {
        public string Codigo { get; set; }
        public int Bobina { get; set; }
        public int Rollo { get; set; }
        public string Transaccion { get; set; }
        public DateTime FechaTransac { get; set; }
        public short AloContable { get; set; }
        public short MesContable { get; set; }
        public int Nroir { get; set; }
        public long Cantidad { get; set; }
        public decimal Ancho { get; set; }
    }
}
