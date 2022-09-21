using AppService.Core.QueryFilters;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Infrastructure.Interfaces
{
    public interface IUriService
    {
        Uri GetGeneralCobranzaPaginationUri(GeneralCobranzaQueryFilter filter, string actionUrl);

    }
}
