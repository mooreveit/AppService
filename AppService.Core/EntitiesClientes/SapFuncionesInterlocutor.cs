using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesClientes
{
    public partial class SapFuncionesInterlocutor
    {
        public decimal Id { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Ktokd { get; set; }
        public string NombreTipo { get; set; }
    }
}
