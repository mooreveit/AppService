using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Core.QueryFilters
{
    public class GeneralCobranzaQueryFilter
    {

        public string UsuarioConectado { get; set; }

        public string IdOficina { get; set; }

        public string IdCliente { get; set; }
        
        public string IdBanco { get; set; }
        
        public string IdTipoTransaccion { get; set; }
        
        public DateTime? FechaTransaccion { get; set; }

        public string UsuarioRegistro { get; set; }
        
        public long Documento { get; set; }
        
        public string Vendedor { get; set; }

        public string SearchText { get; set; }

        


        //Paginacion
        public int PageSize { get; set; }

        public int PageNumber { get; set; }


    }
}
