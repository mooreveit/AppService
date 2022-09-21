using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy534
    {
        public Wsmy534()
        {
            Wsmy536 = new HashSet<Wsmy536>();
        }

        public int Id { get; set; }
        public int Ruta { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Wsmy536> Wsmy536 { get; set; }
    }
}
