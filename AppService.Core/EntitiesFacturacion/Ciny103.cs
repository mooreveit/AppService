using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesFacturacion
{
    public partial class Ciny103
    {
        public decimal Recnum { get; set; }
        public short Mes { get; set; }
        public decimal TasaDolar { get; set; }
        public long Impresos { get; set; }
        public long Etiquetas { get; set; }
        public long Cpo { get; set; }
        public long Jobbing { get; set; }
        public long Outsourcing { get; set; }
        public string ActionItemsIm { get; set; }
        public string ResponsableIm { get; set; }
        public string ActionItemsEt { get; set; }
        public string ResponsableEt { get; set; }
        public string ActionItemsCp { get; set; }
        public string ResponsableCp { get; set; }
        public string ActionItemsJo { get; set; }
        public string ResponsableJo { get; set; }
        public string ActionItemsMo { get; set; }
        public string ResponsableMo { get; set; }
    }
}
