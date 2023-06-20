using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class CrmMtrSeguimiento
    {
        public CrmMtrSeguimiento()
        {
            CrmSeguimientos = new HashSet<CrmSeguimiento>();
        }

        public short IdTipoSegumiento { get; set; }
        public string NombreSeguimiento { get; set; }
        public bool FlagUpdateData { get; set; }

        public virtual ICollection<CrmSeguimiento> CrmSeguimientos { get; set; }
    }
}
