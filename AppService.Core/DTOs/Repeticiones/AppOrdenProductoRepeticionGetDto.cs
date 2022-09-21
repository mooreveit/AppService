using System;
using System.Collections.Generic;

namespace AppService.Core.DTOs.Repeticiones
{
    public class ListaRepeticiones
    {
        public List<AppOrdenProductoRepeticionGetDto> AppOrdenProductoRepeticionGetDto { get; set; }
        public List<PapelPrimeraParte> PapelesPrimeraParte { get; set; }
        public List<PapelSegundaParte> PapelesSegundaParte { get; set; }
        public List<PapelTerceraParte> PapelesTerceraParte { get; set; }
        public List<PapelCuartaParte> PapelesCuartaParte { get; set; }
        public List<PapelQuintaParte> PapelesQuintaParte { get; set; }
        public List<Basica> MedidasBasica { get; set; }
        public List<Opuesta> MedidasOpuesta { get; set; }
        public List<CantidadTintas> CantidadTintas { get; set; }
        public List<CantidadPartes> CantidadPartes { get; set; }
        public List<Productos> Productos { get; set; }
        public List<ProductosExternos> ProductosExternos { get; set; }
        public List<NombresForma> NombresForma { get; set; }
    }


    public class AppOrdenProductoRepeticionGetDto
    {
        public int Id { get; set; }
        public string IdCliente { get; set; }
        public string NombreCliente { get; set; }
        public string Orden { get; set; }
        public DateTime Fecha { get; set; }
        public int AppproductsId { get; set; }
        public string AppproductsDecription { get; set; }
        public string CodProducto { get; set; }
        public string NombreProducto { get; set; }

        public string NombreForma { get; set; }
        public int MedidaBase { get; set; }
        public int MedidaVariable { get; set; }
        public int PartesFormula { get; set; }
        public int CantTintas { get; set; }
        public string PapelPrimeraParte { get; set; }
        public string PapelSegundaParte { get; set; }
        public string PapelTerceraParte { get; set; }
        public string PapelCuartaParte { get; set; }
        public string PapelQuintaParte { get; set; }
        public decimal MedidaBaseDecimal { get; set; }
        public decimal MedidaVariableDecimal { get; set; }
        public string BasicaHumano { get; set; }
        public string OpuestaHumano { get; set; }


    }

    public class NombresForma
    {
        public string descripcion { get; set; }

    }

    public class ProductosExternos
    {

        public string NombreProducto { get; set; }
    }

    public class Productos
    {

        public string AppproductsDecription { get; set; }
    }

    public class CantidadPartes
    {
        public int Cantidad { get; set; }
    }
    public class CantidadTintas
    {
        public int Cantidad { get; set; }
    }
    public class Basica
    {
        public string MedidaBasica { get; set; }
    }
    public class Opuesta
    {
        public string MedidaOpuesta { get; set; }
    }
    public class PapelPrimeraParte
    {
        public string Papel { get; set; }
    }
    public class PapelSegundaParte
    {
        public string Papel { get; set; }
    }
    public class PapelTerceraParte
    {
        public string Papel { get; set; }
    }
    public class PapelCuartaParte
    {
        public string Papel { get; set; }
    }
    public class PapelQuintaParte
    {
        public string Papel { get; set; }
    }

}
