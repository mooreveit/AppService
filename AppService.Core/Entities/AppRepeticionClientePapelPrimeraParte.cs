﻿namespace AppService.Core.Entities
{
    public class AppRepeticionClientePapelPrimeraParte
    {
        public int Id { get; set; }
        public string IdCliente { get; set; }
        public string NombreProducto { get; set; }
        public string NombreForma { get; set; }
        public string BasicaHumano { get; set; }
        public int partes_formula { get; set; }
        public int Cant_Tintas { get; set; }
        public string PAPELPRIMERAPARTE { get; set; }
    }
}
