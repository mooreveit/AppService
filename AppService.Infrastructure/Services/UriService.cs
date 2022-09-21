using AppService.Core.QueryFilters;
using AppService.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Infrastructure.Services
{
    public class UriService:IUriService
    {
        private readonly string _baseUri;
        public UriService(string baseUri)
        {
            _baseUri = baseUri;
        }

        public Uri GetGeneralCobranzaPaginationUri(GeneralCobranzaQueryFilter filter,string actionUrl)
        {

            string baseUrl = $"{_baseUri}/{actionUrl}";

            return new Uri(baseUrl);

        }
    }
}
