using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy530
    {
        public Wsmy530()
        {
            Wsmy531 = new HashSet<Wsmy531>();
        }

        public byte Id { get; set; }
        public string Estatus { get; set; }
        public string Descripcion { get; set; }
        public byte? Secuencia { get; set; }
        public string PendienteAprobacion { get; set; }

        public virtual ICollection<Wsmy531> Wsmy531 { get; set; }
    }
}
