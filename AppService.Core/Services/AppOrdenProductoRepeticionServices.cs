using AppService.Core.CustomEntities;
using AppService.Core.DTOs.Repeticiones;
using AppService.Core.Interfaces;
using AppService.Core.Responses;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppService.Core.Services
{
    public class AppOrdenProductoRepeticionServices : IAppOrdenProductoRepeticionServices
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AppOrdenProductoRepeticionServices(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<ApiResponse<ListaRepeticiones>> GetAllFilter(AppOrdenProductoRepeticionFilterDto filter)
        {
            ListaRepeticiones resultDto = new ListaRepeticiones();
            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };

            ApiResponse<ListaRepeticiones> response = new ApiResponse<ListaRepeticiones>(resultDto);

            var appOrdenProductoRepeticion = await _unitOfWork.AppOrdenProductoRepeticionRepository.GetByCliente(filter.IdCliente);
            if (appOrdenProductoRepeticion.Count > 0)
            {
                List<AppOrdenProductoRepeticionGetDto> listOrdenProducto = new List<AppOrdenProductoRepeticionGetDto>();
                foreach (var item in appOrdenProductoRepeticion.Where(x => x.AppproductsId > 0).ToList())
                {
                    AppOrdenProductoRepeticionGetDto itemOrdenProducto = new AppOrdenProductoRepeticionGetDto();
                    itemOrdenProducto.Id = item.Id;
                    itemOrdenProducto.NombreCliente = item.NombreCliente.Trim();
                    itemOrdenProducto.IdCliente = item.IdCliente;
                    itemOrdenProducto.Orden = item.Orden.ToString();
                    itemOrdenProducto.Fecha = item.Fecha;
                    itemOrdenProducto.AppproductsId = item.AppproductsId;
                    itemOrdenProducto.AppproductsDecription = item.AppproductsDecription.Trim();
                    itemOrdenProducto.CodProducto = item.COD_PRODUCTO.Trim();
                    itemOrdenProducto.NombreProducto = item.NombreProducto.Trim();
                    itemOrdenProducto.NombreForma = item.NombreForma.Trim();
                    itemOrdenProducto.CantTintas = item.Cant_Tintas;
                    itemOrdenProducto.PartesFormula = item.PARTES_FORMULA;
                    itemOrdenProducto.MedidaBase = item.MEDIDA_BASE;
                    itemOrdenProducto.MedidaVariable = item.MEDIDA_VARIABLE;
                    itemOrdenProducto.MedidaBaseDecimal = item.MEDIDA_BASE_DECIMAL;
                    itemOrdenProducto.MedidaVariableDecimal = item.MEDIDA_VARIABLE_DECIMAL;
                    itemOrdenProducto.BasicaHumano = item.BasicaHumano;
                    itemOrdenProducto.OpuestaHumano = item.OpuestaHumano;
                    itemOrdenProducto.PapelPrimeraParte = item.PAPELPRIMERAPARTE;
                    itemOrdenProducto.PapelSegundaParte = item.PAPELSEGUNDAPARTE;
                    itemOrdenProducto.PapelTerceraParte = item.PAPELTERCERAPARTE;
                    itemOrdenProducto.PapelCuartaParte = item.PAPELCUARTAPARTE;
                    itemOrdenProducto.PapelQuintaParte = item.PAPELQUINTAPARTE;
                    listOrdenProducto.Add(itemOrdenProducto);

                }
                resultDto.AppOrdenProductoRepeticionGetDto = listOrdenProducto;


                List<CantidadTintas> listaCantidadTintas = (from item in listOrdenProducto
                                                            group item by item.CantTintas into x
                                                            select new CantidadTintas
                                                            {
                                                                Cantidad = x.Key,
                                                            }).ToList();

                List<CantidadPartes> listaCantidadPartes = (from item in listOrdenProducto
                                                            group item by item.PartesFormula into x
                                                            select new CantidadPartes
                                                            {
                                                                Cantidad = x.Key,
                                                            }).ToList();

                List<Basica> listaBasica = (from item in listOrdenProducto
                                            group item by item.BasicaHumano into x
                                            select new Basica
                                            {
                                                MedidaBasica = x.Key,
                                            }).ToList();
                List<Opuesta> listaOpuesta = (from item in listOrdenProducto
                                              group item by item.OpuestaHumano into x
                                              select new Opuesta
                                              {
                                                  MedidaOpuesta = x.Key,
                                              }).ToList();

                List<PapelPrimeraParte> listaPapelPrimeraParte = (from item in listOrdenProducto
                                                                  group item by item.PapelPrimeraParte into x
                                                                  select new PapelPrimeraParte
                                                                  {
                                                                      Papel = x.Key,
                                                                  }).ToList();

                List<PapelSegundaParte> listaPapelSegundaParte = (from item in listOrdenProducto
                                                                  group item by item.PapelSegundaParte into x
                                                                  select new PapelSegundaParte
                                                                  {
                                                                      Papel = x.Key,
                                                                  }).ToList();

                List<PapelTerceraParte> listaPapelTerceraParte = (from item in listOrdenProducto
                                                                  group item by item.PapelTerceraParte into x
                                                                  select new PapelTerceraParte
                                                                  {
                                                                      Papel = x.Key,
                                                                  }).ToList();

                List<PapelCuartaParte> listaPapelCuartaParte = (from item in listOrdenProducto
                                                                group item by item.PapelCuartaParte into x
                                                                select new PapelCuartaParte
                                                                {
                                                                    Papel = x.Key,
                                                                }).ToList();

                List<PapelQuintaParte> listaPapelQuintaParte = (from item in listOrdenProducto
                                                                group item by item.PapelQuintaParte into x
                                                                select new PapelQuintaParte
                                                                {
                                                                    Papel = x.Key,
                                                                }).ToList();

                List<NombresForma> listaNombresForma = (from item in listOrdenProducto
                                                        group item by item.NombreForma into x
                                                        select new NombresForma
                                                        {
                                                            descripcion = x.Key,
                                                        }).ToList();

                List<Productos> listaProductos = (from item in listOrdenProducto
                                                  group item by item.AppproductsDecription into x
                                                  select new Productos
                                                  {
                                                      AppproductsDecription = x.Key,
                                                  }).ToList();

                List<ProductosExternos> listaProductosExternos = (from item in listOrdenProducto
                                                                  group item by item.NombreProducto into x
                                                                  select new ProductosExternos
                                                                  {
                                                                      NombreProducto = x.Key,
                                                                  }).ToList();

                resultDto.CantidadTintas = listaCantidadTintas;
                resultDto.CantidadPartes = listaCantidadPartes;
                resultDto.MedidasBasica = listaBasica;
                resultDto.MedidasOpuesta = listaOpuesta;
                resultDto.PapelesPrimeraParte = listaPapelPrimeraParte.Where(x => x.Papel != null).ToList();
                resultDto.PapelesSegundaParte = listaPapelSegundaParte.Where(x => x.Papel != null).ToList();
                resultDto.PapelesTerceraParte = listaPapelTerceraParte.Where(x => x.Papel != null).ToList();
                resultDto.PapelesCuartaParte = listaPapelCuartaParte.Where(x => x.Papel != null).ToList();
                resultDto.PapelesQuintaParte = listaPapelQuintaParte.Where(x => x.Papel != null).ToList();
                resultDto.NombresForma = listaNombresForma.Where(x => x.descripcion != null && x.descripcion != "").ToList();
                resultDto.Productos = listaProductos.Where(x => x.AppproductsDecription != null && x.AppproductsDecription != "").ToList();
                resultDto.ProductosExternos = listaProductosExternos.Where(x => x.NombreProducto != null && x.NombreProducto != "").ToList();

            }

            response.Data = resultDto;
            metadata.IsValid = true;
            metadata.Message = "";
            response.Meta = metadata;
            return response;


        }




    }
}
