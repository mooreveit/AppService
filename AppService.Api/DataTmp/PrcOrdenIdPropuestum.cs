using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class PrcOrdenIdPropuestum
    {
        public decimal Id { get; set; }
        public long IdPropuesta { get; set; }
        public long? Orden { get; set; }
    }
}
