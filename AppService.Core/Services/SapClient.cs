using AppService.Core.CustomEntities;
using AppService.Core.DTOs.Sap;
using AppService.Core.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Services
{
    public class SapClient: ISapClient
    {

        private readonly HttpClient _client;

        public SapClient(HttpClient httpClient)
        {
            //DEV
            //httpClient.BaseAddress = new Uri("http://172.28.106.218:8000/sap/opu/odata/sap/ZCOBRANZAS/");


            //Prod
            httpClient.BaseAddress = new Uri("http://172.28.105.202:8000/sap/opu/odata/sap/ZCOBRANZAS/");
            //httpClient.DefaultRequestHeaders.Add("Accept", "application/json");

            //Prod
            httpClient.DefaultRequestHeaders.Add("sap-client", "400");

            //DEV
            //httpClient.DefaultRequestHeaders.Add("sap-client", "250");
            _client = httpClient;
        }

        public async Task<Metadata> GetToken(string yourusername,string yourpwd)
        {
            Metadata metadata = new Metadata();
            try
            {

                _client.DefaultRequestHeaders.Add("x-csrf-token", "Fetch");
                _client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue(
                    "Basic", Convert.ToBase64String(
                        System.Text.ASCIIEncoding.ASCII.GetBytes(
                           $"{yourusername}:{yourpwd}")));

                var result = await _client.GetAsync("$metadata");

                if (result.IsSuccessStatusCode)
                {
                    IEnumerable<string> headerValues = result.Headers.GetValues("x-csrf-token");

                    String[] token = (String[])headerValues;

                    metadata.IsValid = result.IsSuccessStatusCode;
                    metadata.Message = token[0]; ;

                    return metadata;
                }
                else
                {
                    metadata.IsValid = result.IsSuccessStatusCode;
                    metadata.Message = ""; 

                    return metadata;
                  
                }
               
             
            }
            catch (Exception ex)
            {
                metadata.IsValid = false;
                metadata.Message = ex.InnerException.Message;
                return metadata;


            }



        }


        public async Task<Metadata> Post(string action,string token, StringContent data)
        {
            Metadata metadata = new Metadata();

          
            _client.DefaultRequestHeaders.Clear();
            _client.DefaultRequestHeaders.Add("Accept", "application/json");
            _client.DefaultRequestHeaders.Add("x-csrf-token", token);
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("x-csrf-token", token);
                                   


            var result = await _client.PostAsync(action, data);
            string resultContent = await result.Content.ReadAsStringAsync();

            metadata.IsValid= result.IsSuccessStatusCode;
            metadata.Message = resultContent;
            return metadata;
           // return await _client.GetStringAsync("/");
        }
        
        public async Task<Metadata> GetEstadoCuenta(string action, string token)
        {
            Metadata metadata = new Metadata();

          
                _client.DefaultRequestHeaders.Clear();
                _client.DefaultRequestHeaders.Add("Accept", "application/json");
                _client.DefaultRequestHeaders.Add("x-csrf-token", token);
                _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("x-csrf-token", token);



                var result = await _client.GetAsync(action);
               
                string resultContent = await result.Content.ReadAsStringAsync();

                metadata.IsValid = result.IsSuccessStatusCode;
                metadata.Message = resultContent;
          

          
          
            return metadata;
           
        }

      

        public async Task<string> GetData()
        {
          
            var result = await _client.GetAsync("/");
            return await _client.GetStringAsync("/");
        }

    }
}
