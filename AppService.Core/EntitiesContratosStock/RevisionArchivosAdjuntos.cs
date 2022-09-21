using System;
using System.Collections.Generic;

namespace AppService.Core.DataContratosStock
{
    public partial class RevisionArchivosAdjuntos
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public byte[] Blob { get; set; }
        public string CodVend { get; set; }
        public string CodigoClient { get; set; }
        public string NomCliente { get; set; }
    }
}
