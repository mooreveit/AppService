using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMaestros
{
    public partial class Wivy044
    {
        public decimal NroOc { get; set; }
        public string Departamento { get; set; }
        public string Origen { get; set; }
        public DateTime FechaElaborada { get; set; }
        public DateTime FechaEstimada { get; set; }
        public DateTime FechaColocada { get; set; }
        public DateTime FechaEnvFirma { get; set; }
        public DateTime FechaRecFirma { get; set; }
        public string OrdenCompleta { get; set; }
        public decimal NroReq { get; set; }
        public decimal ItemReq { get; set; }
        public decimal CantidadPedida { get; set; }
        public string Unidad { get; set; }
        public string Descripcion1 { get; set; }
        public decimal CantidadRecibi { get; set; }
        public string ItemCompleto { get; set; }
        public string Marca { get; set; }
        public string NombreProv { get; set; }
    }
}
