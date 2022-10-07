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

                var listAppRepeticionClienteProducto = await _unitOfWork.AppOrdenProductoRepeticionRepository.GetAppRepeticionClienteProductoByCliente(filter.IdCliente);
                var lisAppRepeticionClienteNombreForma = await _unitOfWork.AppOrdenProductoRepeticionRepository.GetAppRepeticionClienteNombreFormaByCliente(filter.IdCliente);
                var listAppRepeticionClienteBasica = await _unitOfWork.AppOrdenProductoRepeticionRepository.GetAppRepeticionClienteBasicaByCliente(filter.IdCliente);
                var listAppRepeticionClienteOpuesta = await _unitOfWork.AppOrdenProductoRepeticionRepository.GetAppRepeticionClienteOpuestaByCliente(filter.IdCliente);
                var listAppRepeticionClientePartes = await _unitOfWork.AppOrdenProductoRepeticionRepository.GetAppRepeticionClientePartesByCliente(filter.IdCliente);
                var listAppRepeticionClienteTintas = await _unitOfWork.AppOrdenProductoRepeticionRepository.GetAppRepeticionClienteTintasByCliente(filter.IdCliente);
                var listAppRepeticionClientePapelPrimeraParte = await _unitOfWork.AppOrdenProductoRepeticionRepository.GetAppRepeticionClientePapelPrimeraParteByCliente(filter.IdCliente);
                var listAppRepeticionClientePapelSegundaParte = await _unitOfWork.AppOrdenProductoRepeticionRepository.GetAppRepeticionClientePapelSegundaParteByCliente(filter.IdCliente);
                var listAppRepeticionClientePapelTerceraParte = await _unitOfWork.AppOrdenProductoRepeticionRepository.GetAppRepeticionClientePapelTerceraParteByCliente(filter.IdCliente);
                var listAppRepeticionClientePapelCuartaParte = await _unitOfWork.AppOrdenProductoRepeticionRepository.GetAppRepeticionClientePapelCuartaParteByCliente(filter.IdCliente);
                var listAppRepeticionClientePapelQuintaParte = await _unitOfWork.AppOrdenProductoRepeticionRepository.GetAppRepeticionClientePapelQuintaParteByCliente(filter.IdCliente);

                resultDto.AppRepeticionClienteProducto = listAppRepeticionClienteProducto;
                resultDto.AppRepeticionClienteNombreForma = lisAppRepeticionClienteNombreForma;
                resultDto.AppRepeticionClienteBasica = listAppRepeticionClienteBasica;
                resultDto.AppRepeticionClienteOpuesta = listAppRepeticionClienteOpuesta;

                resultDto.AppRepeticionClientePartes = listAppRepeticionClientePartes;
                resultDto.AppRepeticionClienteTintas = listAppRepeticionClienteTintas;
                resultDto.AppRepeticionClientePapelPrimeraParte = listAppRepeticionClientePapelPrimeraParte;
                resultDto.AppRepeticionClientePapelSegundaParte = listAppRepeticionClientePapelSegundaParte;
                resultDto.AppRepeticionClientePapelTerceraParte = listAppRepeticionClientePapelTerceraParte;
                resultDto.AppRepeticionClientePapelCuartaParte = listAppRepeticionClientePapelCuartaParte;
                resultDto.AppRepeticionClientePapelQuintaParte = listAppRepeticionClientePapelQuintaParte;

            }

            response.Data = resultDto;
            metadata.IsValid = true;
            metadata.Message = "";
            response.Meta = metadata;
            return response;


        }




    }
}
