using System;

namespace AppService.Core.EntitiesMateriales
{
    public partial class Bobina
    {
        public string Codigo { get; set; }
        public int Bobina1 { get; set; }
        public int Rollo { get; set; }
        public string Transaccion { get; set; }
        public DateTime FechaTransac { get; set; }
        public short AloContable { get; set; }
        public short MesContable { get; set; }
        public int Nroir { get; set; }
        public long Cantidad { get; set; }
    }
}
