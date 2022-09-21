using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMaestros
{
    public partial class Wsmy273
    {
        public string CodigoEstatus { get; set; }
        public string Descripcion { get; set; }
        public string AfectaBacklog { get; set; }
        public string EstatusCerrado { get; set; }
        public string AfectaCotizacion { get; set; }
        public string FlagEnAprob { get; set; }
        public string FlagListoCotizar { get; set; }
        public string FlagComp { get; set; }
        public string FlagRechazo { get; set; }
        public string FlagAnulado { get; set; }
        public string FlagEditar { get; set; }
        public short? IdComp { get; set; }
        public string Inactivo { get; set; }
        public short? IdAprb { get; set; }
        public string Responsable { get; set; }
        public string FlagCalculo { get; set; }
        public string ResponsableEst { get; set; }
        public string FlagEnviado { get; set; }
        public string FlagCotizador { get; set; }
        public string FlagAsignaciones { get; set; }
        public string FlagSolicitudPorAprobar { get; set; }
        public string FlagSolicitudProcesada { get; set; }
        public string FlagSolicitudAnulada { get; set; }
        public string FlagSolicitudRechazada { get; set; }
    }
}
