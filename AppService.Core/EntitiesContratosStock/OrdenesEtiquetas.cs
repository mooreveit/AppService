using System;
using System.Collections.Generic;

namespace AppService.Core.DataContratosStock
{
    public partial class OrdenesEtiquetas
    {
        public decimal NumCot { get; set; }
        public string CodVend { get; set; }
        public string NomCliente { get; set; }
        public string Codigo { get; set; }
        public float? CantMill { get; set; }
        public float? ValorLista { get; set; }
        public float? VentaUnit { get; set; }
    }
}
