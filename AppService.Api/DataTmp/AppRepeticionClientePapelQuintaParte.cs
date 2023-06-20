using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class AppRepeticionClientePapelQuintaParte
    {
        public int Id { get; set; }
        public string IdCliente { get; set; }
        public string NombreProducto { get; set; }
        public string NombreForma { get; set; }
        public string BasicaHumano { get; set; }
        public string OpuestaHumano { get; set; }
        public int? PartesFormula { get; set; }
        public int? CantTintas { get; set; }
        public string Papelprimeraparte { get; set; }
        public string Papelsegundaparte { get; set; }
        public string Papelterceraparte { get; set; }
        public string Papelcuartaparte { get; set; }
        public string Papelquintaparte { get; set; }
    }
}
