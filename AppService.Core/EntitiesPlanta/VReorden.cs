using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class VReorden
    {
        public long Orden { get; set; }
        public long? OrdenAnterior { get; set; }
        public short MesReorden { get; set; }
        public short AnoReorden { get; set; }
        public short? MesOrden { get; set; }
        public short? AnoOrden { get; set; }
        public DateTime Fecha { get; set; }
        public string OrdenCliente { get; set; }
        public int Cliente { get; set; }
        public string NombreCliente { get; set; }
        public string NombreForma { get; set; }
        public string Vendedor { get; set; }
        public string EmailVendedor { get; set; }
        public string EmailCliente { get; set; }
        public string VendedorId { get; set; }
        public string SupervisorId { get; set; }
        public string OficinaId { get; set; }
    }
}
