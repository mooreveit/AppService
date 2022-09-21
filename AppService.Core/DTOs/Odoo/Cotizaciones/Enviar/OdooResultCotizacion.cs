using System.Collections.Generic;

namespace AppService.Core.DTOs.Odoo.Cotizaciones.Enviar
{
    public class OdooResultCotizacion
    {


        //{"jsonrpc": "2.0", "id": null, "result": {"success": true, "data": [{"success": true, "data": {"idCotizacion": "LC28202208001", "state": "sent", "idContacto": 65647, "idCliente": "736604", "idDireccionEntregar": "8070178", "idDireccionFacturar": "30590", "idCondPago": "40", "idMtrTipoMoneda": "USD", "MonedaFacturar": "USD", "fecha": "2022-08-01 10:55:08", "ordenCompra": "1", "observaciones": "", "idComercial": 195, "idEquipoVentas": 19, "OrderLines": [{"MooreId": 11225, "OdooId": 0, "idProducto": 20, "idVariante": 0, "nombreComercialProducto": "etq solomo d/cuerito bovino premium", "cantidadSolicitada": 1000.0, "cantidadConvertida": 15.151, "precioLista": 8.5, "PrecioUnitVendedor": 25.0, "Total": 357.14, "medidaBasica": 12.0, "medidaOpuesta": 9.2, "delete": false}]}, "error": "", "message": "", "action": "update"}], "error": "", "message": "", "oportunidades": []}}

        public string jsonrpc { get; set; }
        public object id { get; set; }
        public Result result { get; set; }


        public class Data
        {
            public bool success { get; set; }
            public string error { get; set; }
            public string message { get; set; }
        }

        public class Result
        {
            public bool success { get; set; }
            public string error { get; set; }
            public string message { get; set; }
            public List<Data> data { get; set; }

        }



    }
}
