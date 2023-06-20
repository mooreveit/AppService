using System;

namespace AppService.Core.Entities
{
    public class MtrClienteEnvioOdooLog
    {
        //In de registro a enviar para entrar
        public int Id { get; set; }
        public string IdCliente { get; set; }
        public string JsonSend { get; set; }
        public string Mensaje { get; set; }
        public DateTime Fecha { get; set; }

    }
}
