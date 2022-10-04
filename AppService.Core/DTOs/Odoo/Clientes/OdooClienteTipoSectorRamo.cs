namespace AppService.Core.DTOs.Odoo.Clientes
{
    public class OdooClienteTipoSectorRamo
    {


        public string IdCliente { get; set; }

        public decimal Tipo { get; set; }
        public decimal Sector { get; set; }
        public decimal Ramo { get; set; }
        public string DescripcionSector { get; set; }
        public string DescripcionRamo { get; set; }


    }
}
