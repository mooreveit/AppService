using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy536
    {
        public int Id { get; set; }
        public int Ruta { get; set; }
        public byte Aprobacion { get; set; }
        public string Responsable { get; set; }
        public byte? Secuencia { get; set; }
        public string Principal { get; set; }

        public virtual Wsmy534 RutaNavigation { get; set; }
    }
}
