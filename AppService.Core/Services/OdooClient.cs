using AppService.Core.CustomEntities;
using AppService.Core.Interfaces;

using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace AppService.Core.Services
{
    public class OdooClient : IOdooClient
    {

        private readonly HttpClient _client;
        private readonly IUnitOfWork unitOfWork;

        public OdooClient(HttpClient httpClient)
        {

            /*OdooUrlBaseProd
            OdooUrlBaseDev*/

            //Prod
            //httpClient.BaseAddress = new Uri("https://mooreveit-moore-qa-4914439.dev.odoo.com/jsonrpc/");

            httpClient.BaseAddress = new Uri(" https://mooreveit-moore.odoo.com/jsonrpc/");

            //var url="https://mooreveit-moore-qa1-5818605.dev.odoo.com/jsonrpc/"
            //httpClient.DefaultRequestHeaders.Add("Accept", "application/json");

            //Prod
            //httpClient.DefaultRequestHeaders.Add("sap-client", "400");

            //DEV
            //httpClient.DefaultRequestHeaders.Add("sap-client", "250");
            _client = httpClient;

        }



        public async Task<Metadata> Post(StringContent data)
        {
            Metadata metadata = new Metadata();

            try
            {
                _client.DefaultRequestHeaders.Clear();
                _client.DefaultRequestHeaders.Add("Accept", "application/json");
                //_client.DefaultRequestHeaders.Add("x-csrf-token", token);
                //_client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("x-csrf-token", token);



                var result = await _client.PostAsync(_client.BaseAddress, data);
                string resultContent = await result.Content.ReadAsStringAsync();

                metadata.IsValid = result.IsSuccessStatusCode;
                metadata.Message = resultContent;
                return metadata;
            }
            catch (Exception ex)
            {

                metadata.IsValid = false;
                metadata.Message = ex.InnerException.Message;
                return metadata;
            }

            // return await _client.GetStringAsync("/");
        }




        public async Task<string> GetData()
        {

            var result = await _client.GetAsync("/");
            return await _client.GetStringAsync("/");
        }

    }
}
