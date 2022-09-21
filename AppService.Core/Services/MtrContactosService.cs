using AppService.Core.CustomEntities;
using AppService.Core.DTOs;
using AppService.Core.DTOs.Odoo.Clientes;
using AppService.Core.DTOs.Odoo.Clientes.OdooClients;
using AppService.Core.DTOs.Odoo.Contactos;
using AppService.Core.DTOs.Odoo.Direccion;
using AppService.Core.Entities;
using AppService.Core.EntitiesClientes;
using AppService.Core.EntitiesSap;
using AppService.Core.Interfaces;
using AppService.Core.QueryFilters;
using AppService.Core.Responses;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Services
{
    public class MtrContactosService : IMtrContactosService
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IOdooClient _odooClient;

        public MtrContactosService(IUnitOfWork unitOfWork, IOdooClient odooClient)
        {
            _unitOfWork = unitOfWork;
            _odooClient = odooClient;
        }

        public IEnumerable<MtrContactos> GetAll()
        {

            var contactos = _unitOfWork.MtrContactosRepository.GetAll();


            return contactos;
        }

        public async Task<MtrContactos> GetById(long id)
        {
            return await _unitOfWork.MtrContactosRepository.GetById(id);
        }

        public async Task<MtrContactos> Insert(MtrContactos mtrContactos)
        {


            await _unitOfWork.MtrContactosRepository.Add(mtrContactos);
            await _unitOfWork.SaveChangesAsync();
            return mtrContactos;
        }




        public async Task<MtrContactos> Update(MtrContactos mtrContactos)
        {

            var contacto = await GetById(mtrContactos.IdContacto);
            if (contacto == null)
            {
                throw new Exception("Contacto No existe");
            }

            _unitOfWork.MtrContactosRepository.Update(contacto);
            await _unitOfWork.SaveChangesAsync();

            return await GetById(contacto.IdContacto);

        }

        public async Task<bool> Delete(long id)
        {
            await _unitOfWork.MtrContactosRepository.Delete(id);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }

        public async Task<List<MtrContactos>> GetByIdCliente(MtrClienteQueryFilter filter)
        {
            return await _unitOfWork.MtrContactosRepository.GetByEmailContactosCliente(filter);
        }

        public async Task<List<SapTratamientoContacto>> GetAllSapTratamientoContacto()
        {

            var tratamiento = await _unitOfWork.SapTratamientoContactoRepository.GetAll();


            return tratamiento;

        }

        public async Task<List<SapCargoContacto>> GetAllSapCargoContacto()
        {

            var cargoContacto = await _unitOfWork.SapCargoContactoRepository.GetAll();


            return cargoContacto;

        }

        public async Task<List<SapDepartamentoContacto>> GetAllSapDepartamentoContacto()
        {

            var departamentoContacto = await _unitOfWork.SapDepartamentoContactoRepository.GetAll();


            return departamentoContacto;

        }

        public async Task<List<SapPoderContacto>> GetAllSapPoderContacto()
        {

            var poderContacto = await _unitOfWork.SapPoderContactoRepository.GetAll();


            return poderContacto;

        }


        public async Task<ApiResponse<bool>> CreateContactoAlTables(ContactoCreateDto dto)
        {

            bool resultDto = new bool();

            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };

            ApiResponse<bool> response = new ApiResponse<bool>(resultDto);


            try
            {




                SapTratamientoContacto sapTratamientoContacto = await _unitOfWork.SapTratamientoContactoRepository.GetById(dto.Tratamiento);
                if (sapTratamientoContacto == null)
                {

                    metadata.IsValid = false;
                    metadata.Message = "Tratamiento no existe!!";
                    response.Data = false;
                    response.Meta = metadata;
                    return response;
                }
                SapDepartamentoContacto sapDepartamentoContacto = await _unitOfWork.SapDepartamentoContactoRepository.GetById(dto.Departamento);
                if (sapDepartamentoContacto == null)
                {

                    metadata.IsValid = false;
                    metadata.Message = "Departamento no existe!!";
                    response.Data = false;
                    response.Meta = metadata;
                    return response;
                }

                SapCargoContacto sapCargoContacto = await _unitOfWork.SapCargoContactoRepository.GetById(dto.Cargo);
                if (sapCargoContacto == null)
                {

                    metadata.IsValid = false;
                    metadata.Message = "Cargo no existe!!";
                    response.Data = false;
                    response.Meta = metadata;
                    return response;
                }

                SapPoderContacto sapPoderContacto = await _unitOfWork.SapPoderContactoRepository.GetById(dto.Poder);
                if (sapPoderContacto == null)
                {

                    metadata.IsValid = false;
                    metadata.Message = "Poder no existe!!";
                    response.Data = false;
                    response.Meta = metadata;
                    return response;
                }
                if (String.IsNullOrEmpty(dto.Rif))
                {

                    metadata.IsValid = false;
                    metadata.Message = "Rif Invalido!!";
                    response.Data = false;
                    response.Meta = metadata;
                    return response;
                }
                if (String.IsNullOrEmpty(dto.Nombre))
                {

                    metadata.IsValid = false;
                    metadata.Message = "Nombre Invalido!!";
                    response.Data = false;
                    response.Meta = metadata;
                    return response;
                }
                if (String.IsNullOrEmpty(dto.Apellido))
                {

                    metadata.IsValid = false;
                    metadata.Message = "Apellido Invalido!!";
                    response.Data = false;
                    response.Meta = metadata;
                    return response;
                }
                if (String.IsNullOrEmpty(dto.Celular))
                {

                    metadata.IsValid = false;
                    metadata.Message = "Celular Invalido!!";
                    response.Data = false;
                    response.Meta = metadata;
                    return response;
                }
                if (String.IsNullOrEmpty(dto.Telefono))
                {

                    metadata.IsValid = false;
                    metadata.Message = "Telefono Invalido!!";
                    response.Data = false;
                    response.Meta = metadata;
                    return response;
                }
                if (String.IsNullOrEmpty(dto.Email))
                {

                    metadata.IsValid = false;
                    metadata.Message = "Telefono Invalido!!";
                    response.Data = false;
                    response.Meta = metadata;
                    return response;
                }

                var newIdContacto = await _unitOfWork.SapContactoRepository.NextId();

                string FlagProcesado = "";

                if (dto.IdCliente == "0")
                {
                    FlagProcesado = "X";
                }

                SapContactos newSapContactos = new SapContactos();

                newSapContactos.IdContacto = newIdContacto;
                newSapContactos.Kunnr = dto.IdCliente;
                newSapContactos.Parnr = "";
                newSapContactos.TitleMedi = sapTratamientoContacto.NombreTratamiento;
                newSapContactos.Name1 = dto.Apellido;
                newSapContactos.Namev = dto.Nombre;
                newSapContactos.Pafkt = sapCargoContacto.Codigo;
                newSapContactos.Abtnr = sapDepartamentoContacto.Codigo;
                newSapContactos.Telf1 = dto.Telefono;
                newSapContactos.Telf2 = dto.Celular;
                newSapContactos.StmpAddr = dto.Email;
                newSapContactos.Fax = dto.Fax;
                newSapContactos.Pavip = "3";//Activo
                if (dto.FechaNacimiento != null)
                {
                    newSapContactos.Gbdat = dto.FechaNacimiento.Value.Year.ToString() + dto.FechaNacimiento.Value.Month.ToString() + dto.FechaNacimiento.Value.Day.ToString();
                }

                newSapContactos.Parvo = sapPoderContacto.Codigo;
                newSapContactos.Nmail = "X";
                newSapContactos.Procesado = FlagProcesado;
                newSapContactos.FechaCreacion = DateTime.Now;
                newSapContactos.UsuarioCreacion = dto.UsuarioConectado;
                await _unitOfWork.SapContactoRepository.Add(newSapContactos);


                MtrContactos newMtrContactos = new MtrContactos();
                newMtrContactos.IdContacto = (long)newIdContacto;
                newMtrContactos.IdCliente = dto.IdCliente;
                newMtrContactos.Rif = dto.Rif;
                newMtrContactos.Nombre = dto.Nombre + " " + dto.Apellido;
                newMtrContactos.Cargo = sapCargoContacto.Descripcion;
                newMtrContactos.Area = sapDepartamentoContacto.Descripcion;
                newMtrContactos.Telefono1 = dto.Telefono;
                newMtrContactos.Celular = dto.Celular;
                newMtrContactos.Email = dto.Email;
                newMtrContactos.Fax = dto.Fax;
                newMtrContactos.Inactivo = false;
                newMtrContactos.FechaCreacion = DateTime.Now;
                newMtrContactos.Usuario = dto.UsuarioConectado;
                await _unitOfWork.MtrContactosRepository.Add(newMtrContactos);

                Wsmy265 newWsmy265 = new Wsmy265();

                decimal decimalVal = 0;
                decimalVal = System.Convert.ToDecimal(dto.IdCliente);
                var newCorrelativoContactoCliente = await _unitOfWork.Wsmy265Repository.NextCorrelativoContactoCliente(decimalVal, dto.Rif);
                newWsmy265.Id = (long)newIdContacto;
                newWsmy265.Cliente = decimalVal;
                newWsmy265.Rif = dto.Rif;
                newWsmy265.Nombre = dto.Nombre + " " + dto.Apellido;
                newWsmy265.Cargo = sapCargoContacto.Descripcion;
                newWsmy265.Area = sapDepartamentoContacto.Descripcion;
                newWsmy265.TelefonoOficina1 = dto.Telefono;
                newWsmy265.TelefonoCelular = dto.Celular;
                newWsmy265.Email = dto.Email;
                newWsmy265.Fax = dto.Fax;
                newWsmy265.IdContactos = newCorrelativoContactoCliente;
                newWsmy265.Inactivo = "";
                if (dto.FechaNacimiento != null)
                {
                    newWsmy265.FechaCumpleanos = dto.FechaNacimiento.Value.Year.ToString() + dto.FechaNacimiento.Value.Month.ToString() + dto.FechaNacimiento.Value.Day.ToString();

                }

                newWsmy265.TomaDecision = sapPoderContacto.Id;
                newWsmy265.AceptaEmail = "X";
                newWsmy265.FechaCreacion = DateTime.Now;
                newWsmy265.Usuario = dto.UsuarioConectado;

                await _unitOfWork.Wsmy265Repository.Add(newWsmy265);


                await _unitOfWork.SaveChangesAsync();


                response.Data = true;
                response.Meta = metadata;
                return response;

            }
            catch (Exception ex)
            {

                metadata.IsValid = false;
                metadata.Message = ex.InnerException.Message;
                response.Data = false;
                response.Meta = metadata;
                return response;
            }





        }

        public async Task<ApiResponse<bool>> UpdateContactoAllTables(ContactoUpdateDto dto)
        {

            bool resultDto = new bool();

            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };

            ApiResponse<bool> response = new ApiResponse<bool>(resultDto);


            try
            {





                SapTratamientoContacto sapTratamientoContacto = await _unitOfWork.SapTratamientoContactoRepository.GetById(dto.Tratamiento);
                if (sapTratamientoContacto == null)
                {

                    metadata.IsValid = false;
                    metadata.Message = "Tratamiento no existe!!";
                    response.Data = false;
                    response.Meta = metadata;
                    return response;
                }
                SapDepartamentoContacto sapDepartamentoContacto = await _unitOfWork.SapDepartamentoContactoRepository.GetById(dto.Departamento);
                if (sapDepartamentoContacto == null)
                {

                    metadata.IsValid = false;
                    metadata.Message = "Departamento no existe!!";
                    response.Data = false;
                    response.Meta = metadata;
                    return response;
                }

                SapCargoContacto sapCargoContacto = await _unitOfWork.SapCargoContactoRepository.GetById(dto.Cargo);
                if (sapCargoContacto == null)
                {

                    metadata.IsValid = false;
                    metadata.Message = "Cargo no existe!!";
                    response.Data = false;
                    response.Meta = metadata;
                    return response;
                }

                SapPoderContacto sapPoderContacto = await _unitOfWork.SapPoderContactoRepository.GetById(dto.Poder);
                if (sapPoderContacto == null)
                {

                    metadata.IsValid = false;
                    metadata.Message = "Poder no existe!!";
                    response.Data = false;
                    response.Meta = metadata;
                    return response;
                }
                if (String.IsNullOrEmpty(dto.Rif))
                {

                    metadata.IsValid = false;
                    metadata.Message = "Rif Invalido!!";
                    response.Data = false;
                    response.Meta = metadata;
                    return response;
                }
                if (String.IsNullOrEmpty(dto.Nombre))
                {

                    metadata.IsValid = false;
                    metadata.Message = "Nombre Invalido!!";
                    response.Data = false;
                    response.Meta = metadata;
                    return response;
                }

                if (String.IsNullOrEmpty(dto.Celular))
                {

                    metadata.IsValid = false;
                    metadata.Message = "Celular Invalido!!";
                    response.Data = false;
                    response.Meta = metadata;
                    return response;
                }
                if (String.IsNullOrEmpty(dto.Telefono))
                {

                    metadata.IsValid = false;
                    metadata.Message = "Telefono Invalido!!";
                    response.Data = false;
                    response.Meta = metadata;
                    return response;
                }
                if (String.IsNullOrEmpty(dto.Email))
                {

                    metadata.IsValid = false;
                    metadata.Message = "Telefono Invalido!!";
                    response.Data = false;
                    response.Meta = metadata;
                    return response;
                }

                //var newIdContacto = await _unitOfWork.SapContactoRepository.NextId();

                string FlagProcesado = "";

                if (dto.IdCliente == "0")
                {
                    FlagProcesado = "X";
                }

                MtrContactos mtrContactos = await _unitOfWork.MtrContactosRepository.GetById((long)dto.IdContacto);
                if (mtrContactos == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Contacto No existe";
                    response.Data = false;
                    response.Meta = metadata;
                    return response;
                }
                else
                {

                    mtrContactos.Rif = dto.Rif;
                    mtrContactos.Nombre = dto.Nombre;
                    mtrContactos.Cargo = sapCargoContacto.Descripcion;
                    mtrContactos.Area = sapDepartamentoContacto.Descripcion;
                    mtrContactos.Telefono1 = dto.Telefono;
                    mtrContactos.Celular = dto.Celular;
                    mtrContactos.Email = dto.Email;
                    mtrContactos.Fax = dto.Fax;
                    mtrContactos.Inactivo = false;
                    mtrContactos.FechaCreacion = DateTime.Now;
                    mtrContactos.Usuario = dto.UsuarioConectado;
                    _unitOfWork.MtrContactosRepository.Update(mtrContactos);
                    await _unitOfWork.SaveChangesAsync();
                    SapContactos sapContactos = await _unitOfWork.SapContactoRepository.GetById(mtrContactos.IdContacto);
                    if (sapContactos != null)
                    {
                        sapContactos.Parnr = "";
                        sapContactos.TitleMedi = sapTratamientoContacto.NombreTratamiento;
                        sapContactos.Name1 = dto.Apellido;
                        sapContactos.Namev = dto.Nombre;
                        sapContactos.Pafkt = sapCargoContacto.Codigo;
                        sapContactos.Abtnr = sapDepartamentoContacto.Codigo;
                        sapContactos.Telf1 = dto.Telefono;
                        sapContactos.Telf2 = dto.Celular;
                        sapContactos.StmpAddr = dto.Email;
                        sapContactos.Fax = dto.Fax;
                        sapContactos.Pavip = "3";//Activo
                        if (dto.FechaNacimiento != null)
                        {
                            sapContactos.Gbdat = dto.FechaNacimiento.Value.Year.ToString() + dto.FechaNacimiento.Value.Month.ToString() + dto.FechaNacimiento.Value.Day.ToString();
                        }

                        sapContactos.Parvo = sapPoderContacto.Codigo;
                        sapContactos.Nmail = "X";
                        sapContactos.Procesado = FlagProcesado;
                        sapContactos.FechaCreacion = DateTime.Now;
                        sapContactos.UsuarioCreacion = dto.UsuarioConectado;
                        _unitOfWork.SapContactoRepository.Update(sapContactos);
                        await _unitOfWork.SaveChangesAsync();
                    }
                    Wsmy265 wsmy265 = await _unitOfWork.Wsmy265Repository.GetById(mtrContactos.IdContacto);
                    if (wsmy265 != null)
                    {
                        wsmy265.Rif = dto.Rif;
                        wsmy265.Nombre = dto.Nombre + " " + dto.Apellido;
                        wsmy265.Cargo = sapCargoContacto.Descripcion;
                        wsmy265.Area = sapDepartamentoContacto.Descripcion;
                        wsmy265.TelefonoOficina1 = dto.Telefono;
                        wsmy265.TelefonoCelular = dto.Celular;
                        wsmy265.Email = dto.Email;
                        wsmy265.Fax = dto.Fax;
                        wsmy265.Inactivo = "";
                        if (dto.FechaNacimiento != null)
                        {
                            wsmy265.FechaCumpleanos = dto.FechaNacimiento.Value.Year.ToString() + dto.FechaNacimiento.Value.Month.ToString() + dto.FechaNacimiento.Value.Day.ToString();
                        }

                        wsmy265.TomaDecision = sapPoderContacto.Id;
                        wsmy265.AceptaEmail = "X";
                        wsmy265.Usuario = dto.UsuarioConectado;

                        _unitOfWork.Wsmy265Repository.Update(wsmy265);
                        await _unitOfWork.SaveChangesAsync();
                    }


                }


                response.Data = true;
                response.Meta = metadata;
                return response;

            }
            catch (Exception ex)
            {

                metadata.IsValid = false;
                metadata.Message = ex.InnerException.Message;
                response.Data = false;
                response.Meta = metadata;
                return response;
            }





        }

        public async Task<ApiResponse<ContactoGetDto>> GetContactoById(ContactoQueryFilter filter)
        {

            ContactoGetDto resultDto = new ContactoGetDto();

            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };

            ApiResponse<ContactoGetDto> response = new ApiResponse<ContactoGetDto>(resultDto);


            try
            {




                MtrContactos mtrContactos = await _unitOfWork.MtrContactosRepository.GetById((long)filter.IdContacto);
                if (mtrContactos != null)
                {

                    SapContactos sapContactos = await _unitOfWork.SapContactoRepository.GetById(mtrContactos.IdContacto);

                    ContactoGetDto contactoGetDto = new ContactoGetDto();
                    if (sapContactos.TitleMedi == "Señor")
                    {
                        contactoGetDto.Tratamiento = 1;
                    }
                    else
                    {
                        contactoGetDto.Tratamiento = 2;
                    }

                    contactoGetDto.Poder = sapContactos.Parvo;
                    contactoGetDto.Nombre = mtrContactos.Nombre;
                    contactoGetDto.Departamento = sapContactos.Abtnr;
                    contactoGetDto.Telefono = mtrContactos.Telefono1;
                    contactoGetDto.Celular = mtrContactos.Celular;
                    contactoGetDto.Fax = mtrContactos.Fax;
                    contactoGetDto.Email = mtrContactos.Email;
                    contactoGetDto.IdContacto = mtrContactos.IdContacto;
                    contactoGetDto.IdCliente = mtrContactos.IdCliente;
                    contactoGetDto.Rif = mtrContactos.Rif;
                    contactoGetDto.Cargo = sapContactos.Pafkt;






                    metadata.IsValid = true;
                    metadata.Message = "";
                    response.Data = contactoGetDto;
                    response.Meta = metadata;
                    return response;
                }
                else
                {
                    metadata.IsValid = false;
                    metadata.Message = "Contacto No existe";
                    response.Data = null;
                    response.Meta = metadata;
                    return response;
                }


                response.Data = null;
                response.Meta = metadata;
                return response;

            }
            catch (Exception ex)
            {

                metadata.IsValid = false;
                metadata.Message = ex.InnerException.Message;
                response.Data = null;
                response.Meta = metadata;
                return response;
            }





        }


        //*************************CONTACTOS ODOO*************************

        public async Task<ApiResponse<OdooContactoGetDto>> OdooCreateContactoAlTables(OdooContactoCreateDto dto)
        {

            OdooContactoGetDto resultDto = new OdooContactoGetDto();

            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };

            ApiResponse<OdooContactoGetDto> response = new ApiResponse<OdooContactoGetDto>(resultDto);


            try
            {


                dto.Tratamiento = 1;

                var cliente = await _unitOfWork.MtrClienteRepository.GetByIdAsync(dto.IdCliente);
                if (cliente == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Cliente no existe!!";
                    response.Data = null;
                    response.Meta = metadata;
                    return response;
                }


                SapTratamientoContacto sapTratamientoContacto = await _unitOfWork.SapTratamientoContactoRepository.GetById(dto.Tratamiento);
                if (sapTratamientoContacto == null)
                {

                    metadata.IsValid = false;
                    metadata.Message = "Tratamiento no existe!!";
                    response.Data = null;
                    response.Meta = metadata;
                    return response;
                }

                decimal departamento;

                Decimal.TryParse(dto.Departamento, out departamento);

                SapDepartamentoContacto sapDepartamentoContacto = await _unitOfWork.SapDepartamentoContactoRepository.GetByIdDecimal(departamento);
                if (sapDepartamentoContacto == null)
                {

                    metadata.IsValid = false;
                    metadata.Message = "Departamento no existe!!";
                    response.Data = null;
                    response.Meta = metadata;
                    return response;
                }

                decimal cargo;

                Decimal.TryParse(dto.Cargo, out cargo);
                SapCargoContacto sapCargoContacto = await _unitOfWork.SapCargoContactoRepository.GetByIdDecimal(cargo);
                if (sapCargoContacto == null)
                {

                    metadata.IsValid = false;
                    metadata.Message = "Cargo no existe!!";
                    response.Data = null;
                    response.Meta = metadata;
                    return response;
                }
                decimal poder;
                Decimal.TryParse(dto.Poder, out poder);
                SapPoderContacto sapPoderContacto = await _unitOfWork.SapPoderContactoRepository.GetByIdDecimal(poder);
                if (sapPoderContacto == null)
                {

                    metadata.IsValid = false;
                    metadata.Message = "Poder no existe!!";
                    response.Data = null;
                    response.Meta = metadata;
                    return response;
                }
                if (String.IsNullOrEmpty(dto.Rif))
                {

                    metadata.IsValid = false;
                    metadata.Message = "Rif Invalido!!";
                    response.Data = null;
                    response.Meta = metadata;
                    return response;
                }
                if (String.IsNullOrEmpty(dto.Nombre))
                {

                    metadata.IsValid = false;
                    metadata.Message = "Nombre Invalido!!";
                    response.Data = null;
                    response.Meta = metadata;
                    return response;
                }

                if (String.IsNullOrEmpty(dto.Celular))
                {

                    metadata.IsValid = false;
                    metadata.Message = "Celular Invalido!!";
                    response.Data = null;
                    response.Meta = metadata;
                    return response;
                }
                if (String.IsNullOrEmpty(dto.Telefono))
                {

                    metadata.IsValid = false;
                    metadata.Message = "Telefono Invalido!!";
                    response.Data = null;
                    response.Meta = metadata;
                    return response;
                }
                if (String.IsNullOrEmpty(dto.Email))
                {

                    metadata.IsValid = false;
                    metadata.Message = "Telefono Invalido!!";
                    response.Data = null;
                    response.Meta = metadata;
                    return response;
                }

                var newIdContacto = await _unitOfWork.SapContactoRepository.NextId();

                string FlagProcesado = "";

                if (dto.IdCliente == "0")
                {
                    FlagProcesado = "X";
                }

                SapContactos newSapContactos = new SapContactos();

                newSapContactos.IdContacto = newIdContacto;
                newSapContactos.Kunnr = dto.IdCliente;
                newSapContactos.Parnr = "";
                newSapContactos.TitleMedi = sapTratamientoContacto.NombreTratamiento;
                if (!String.IsNullOrEmpty(dto.Apellido))
                {
                    newSapContactos.Name1 = dto.Apellido;
                }
                else
                {
                    newSapContactos.Name1 = "";
                }


                newSapContactos.Namev = dto.Nombre;
                newSapContactos.Pafkt = sapCargoContacto.Codigo;
                newSapContactos.Abtnr = sapDepartamentoContacto.Codigo;
                newSapContactos.Telf1 = dto.Telefono;
                newSapContactos.Telf2 = dto.Celular;
                newSapContactos.StmpAddr = dto.Email;
                newSapContactos.Fax = "";
                newSapContactos.Pavip = "3";//Activo

                newSapContactos.Parvo = sapPoderContacto.Codigo;
                newSapContactos.Nmail = "X";
                newSapContactos.Procesado = FlagProcesado;
                newSapContactos.FechaCreacion = DateTime.Now;
                newSapContactos.UsuarioCreacion = dto.UsuarioConectado;
                await _unitOfWork.SapContactoRepository.Add(newSapContactos);


                MtrContactos newMtrContactos = new MtrContactos();
                newMtrContactos.IdContacto = (long)newIdContacto;
                newMtrContactos.IdCliente = dto.IdCliente;
                newMtrContactos.Rif = dto.Rif;
                if (!String.IsNullOrEmpty(dto.Apellido))
                {
                    newMtrContactos.Nombre = dto.Nombre + " " + dto.Apellido;
                }
                else
                {
                    newMtrContactos.Nombre = dto.Nombre;
                }

                newMtrContactos.Cargo = sapCargoContacto.Descripcion;
                newMtrContactos.Area = sapDepartamentoContacto.Descripcion;
                newMtrContactos.Telefono1 = dto.Telefono;
                newMtrContactos.Celular = dto.Celular;
                newMtrContactos.Email = dto.Email;
                newMtrContactos.Fax = "";
                newMtrContactos.Inactivo = false;
                newMtrContactos.FechaCreacion = DateTime.Now;
                newMtrContactos.Usuario = dto.UsuarioConectado;
                await _unitOfWork.MtrContactosRepository.Add(newMtrContactos);

                Wsmy265 newWsmy265 = new Wsmy265();

                decimal decimalVal = 0;
                decimalVal = System.Convert.ToDecimal(dto.IdCliente);
                var newCorrelativoContactoCliente = await _unitOfWork.Wsmy265Repository.NextCorrelativoContactoCliente(decimalVal, dto.Rif);
                newWsmy265.Id = (long)newIdContacto;
                newWsmy265.Cliente = decimalVal;
                newWsmy265.Rif = dto.Rif;
                var nombre = "";
                if (!String.IsNullOrEmpty(dto.Apellido))
                {
                    nombre = dto.Nombre + " " + dto.Apellido;
                }
                else
                {
                    nombre = dto.Nombre;
                }

                if (nombre.Length > 30)
                {
                    newWsmy265.Nombre = nombre.Substring(0, 29);

                }
                else
                {
                    newWsmy265.Nombre = nombre;
                }

                newWsmy265.Cargo = sapCargoContacto.Descripcion;
                newWsmy265.Area = sapDepartamentoContacto.Descripcion;
                newWsmy265.TelefonoOficina1 = dto.Telefono;
                newWsmy265.TelefonoCelular = dto.Celular;
                newWsmy265.Email = dto.Email;
                newWsmy265.Fax = "";
                newWsmy265.IdContactos = newCorrelativoContactoCliente;
                newWsmy265.Inactivo = "";


                newWsmy265.TomaDecision = sapPoderContacto.Id;
                newWsmy265.AceptaEmail = "X";
                newWsmy265.FechaCreacion = DateTime.Now;
                newWsmy265.Usuario = dto.UsuarioConectado;

                await _unitOfWork.Wsmy265Repository.Add(newWsmy265);


                await _unitOfWork.SaveChangesAsync();


                var contacto = await GetById(newMtrContactos.IdContacto);
                resultDto.IdCliente = contacto.IdCliente;
                resultDto.IdContacto = contacto.IdContacto;

                response.Data = resultDto;
                response.Meta = metadata;
                return response;

            }
            catch (Exception ex)
            {

                metadata.IsValid = false;
                metadata.Message = ex.InnerException.Message;
                response.Data = null;
                response.Meta = metadata;
                return response;
            }





        }

        public async Task<ApiResponse<OdooContactoGetDto>> OdooUpdateContactoAllTables(OdooContactoUpdateDto dto)
        {

            OdooContactoGetDto resultDto = new OdooContactoGetDto();

            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };

            ApiResponse<OdooContactoGetDto> response = new ApiResponse<OdooContactoGetDto>(resultDto);


            try
            {

                var cliente = await _unitOfWork.MtrClienteRepository.GetByIdAsync(dto.IdCliente);
                if (cliente == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Cliente no existe!!";
                    response.Data = null;
                    response.Meta = metadata;
                    return response;
                }


                dto.Tratamiento = 1;


                SapTratamientoContacto sapTratamientoContacto = await _unitOfWork.SapTratamientoContactoRepository.GetById(dto.Tratamiento);
                if (sapTratamientoContacto == null)
                {

                    metadata.IsValid = false;
                    metadata.Message = "Tratamiento no existe!!";
                    response.Data = null;
                    response.Meta = metadata;
                    return response;
                }
                decimal departamento;

                Decimal.TryParse(dto.Departamento, out departamento);

                SapDepartamentoContacto sapDepartamentoContacto = await _unitOfWork.SapDepartamentoContactoRepository.GetByIdDecimal(departamento);
                if (sapDepartamentoContacto == null)
                {

                    metadata.IsValid = false;
                    metadata.Message = "Departamento no existe!!";
                    response.Data = null;
                    response.Meta = metadata;
                    return response;
                }

                decimal cargo;

                Decimal.TryParse(dto.Cargo, out cargo);
                SapCargoContacto sapCargoContacto = await _unitOfWork.SapCargoContactoRepository.GetByIdDecimal(cargo);
                if (sapCargoContacto == null)
                {

                    metadata.IsValid = false;
                    metadata.Message = "Cargo no existe!!";
                    response.Data = null;
                    response.Meta = metadata;
                    return response;
                }
                decimal poder;
                Decimal.TryParse(dto.Poder, out poder);
                SapPoderContacto sapPoderContacto = await _unitOfWork.SapPoderContactoRepository.GetByIdDecimal(poder);

                if (sapPoderContacto == null)
                {

                    metadata.IsValid = false;
                    metadata.Message = "Poder no existe!!";
                    response.Data = null;
                    response.Meta = metadata;
                    return response;
                }
                if (String.IsNullOrEmpty(dto.Rif))
                {

                    metadata.IsValid = false;
                    metadata.Message = "Rif Invalido!!";
                    response.Data = null;
                    response.Meta = metadata;
                    return response;
                }
                if (String.IsNullOrEmpty(dto.Nombre))
                {

                    metadata.IsValid = false;
                    metadata.Message = "Nombre Invalido!!";
                    response.Data = null;
                    response.Meta = metadata;
                    return response;
                }

                if (String.IsNullOrEmpty(dto.Celular))
                {

                    metadata.IsValid = false;
                    metadata.Message = "Celular Invalido!!";
                    response.Data = null;
                    response.Meta = metadata;
                    return response;
                }
                if (String.IsNullOrEmpty(dto.Telefono))
                {

                    metadata.IsValid = false;
                    metadata.Message = "Telefono Invalido!!";
                    response.Data = null;
                    response.Meta = metadata;
                    return response;
                }
                if (String.IsNullOrEmpty(dto.Email))
                {

                    metadata.IsValid = false;
                    metadata.Message = "Telefono Invalido!!";
                    response.Data = null;
                    response.Meta = metadata;
                    return response;
                }



                string FlagProcesado = "";

                if (dto.IdCliente == "0")
                {
                    FlagProcesado = "X";
                }

                MtrContactos mtrContactos = await _unitOfWork.MtrContactosRepository.GetById((long)dto.IdContacto);
                if (mtrContactos == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Contacto No existe";
                    response.Data = null;
                    response.Meta = metadata;
                    return response;
                }
                else
                {

                    mtrContactos.Rif = dto.Rif;
                    mtrContactos.Nombre = dto.Nombre;
                    mtrContactos.Cargo = sapCargoContacto.Descripcion;
                    mtrContactos.Area = sapDepartamentoContacto.Descripcion;
                    mtrContactos.Telefono1 = dto.Telefono;
                    mtrContactos.Celular = dto.Celular;
                    mtrContactos.Email = dto.Email;
                    mtrContactos.Fax = "";
                    mtrContactos.Inactivo = false;
                    mtrContactos.FechaCreacion = DateTime.Now;
                    mtrContactos.Usuario = dto.UsuarioConectado;
                    _unitOfWork.MtrContactosRepository.Update(mtrContactos);

                    SapContactos sapContactos = await _unitOfWork.SapContactoRepository.GetById(mtrContactos.IdContacto);
                    if (sapContactos != null)
                    {
                        sapContactos.Parnr = "";
                        sapContactos.TitleMedi = sapTratamientoContacto.NombreTratamiento;
                        if (!String.IsNullOrEmpty(dto.Apellido))
                        {
                            sapContactos.Name1 = dto.Apellido;
                        }
                        else
                        {
                            sapContactos.Name1 = "";
                        }

                        sapContactos.Namev = dto.Nombre;
                        sapContactos.Pafkt = sapCargoContacto.Codigo;
                        sapContactos.Abtnr = sapDepartamentoContacto.Codigo;
                        sapContactos.Telf1 = dto.Telefono;
                        sapContactos.Telf2 = dto.Celular;
                        sapContactos.StmpAddr = dto.Email;
                        sapContactos.Fax = "";
                        sapContactos.Pavip = "3";//Activo

                        sapContactos.Parvo = sapPoderContacto.Codigo;
                        sapContactos.Nmail = "X";
                        sapContactos.Procesado = FlagProcesado;
                        sapContactos.FechaCreacion = DateTime.Now;
                        sapContactos.UsuarioCreacion = dto.UsuarioConectado;
                        _unitOfWork.SapContactoRepository.Update(sapContactos);

                    }
                    Wsmy265 wsmy265 = await _unitOfWork.Wsmy265Repository.GetById(mtrContactos.IdContacto);
                    if (wsmy265 != null)
                    {
                        wsmy265.Rif = dto.Rif;
                        var nombre = "";

                        if (!String.IsNullOrEmpty(dto.Apellido))
                        {
                            nombre = dto.Nombre + " " + dto.Apellido;
                        }
                        else
                        {
                            nombre = dto.Nombre;
                        }

                        if (nombre.Length > 30)
                        {
                            wsmy265.Nombre = nombre.Substring(0, 29);

                        }
                        else
                        {
                            wsmy265.Nombre = nombre;
                        }


                        wsmy265.Cargo = sapCargoContacto.Descripcion;
                        wsmy265.Area = sapDepartamentoContacto.Descripcion;
                        wsmy265.TelefonoOficina1 = dto.Telefono;
                        wsmy265.TelefonoCelular = dto.Celular;
                        wsmy265.Email = dto.Email;
                        wsmy265.Fax = "";
                        wsmy265.Inactivo = "";


                        wsmy265.TomaDecision = sapPoderContacto.Id;
                        wsmy265.AceptaEmail = "X";
                        wsmy265.Usuario = dto.UsuarioConectado;

                        _unitOfWork.Wsmy265Repository.Update(wsmy265);

                    }
                    await _unitOfWork.SaveChangesAsync();
                    var contacto = await GetById(mtrContactos.IdContacto);
                    resultDto.IdCliente = contacto.IdCliente;
                    resultDto.IdContacto = contacto.IdContacto;
                    response.Data = resultDto;
                }



                response.Meta = metadata;
                return response;

            }
            catch (Exception ex)
            {

                metadata.IsValid = false;
                metadata.Message = ex.InnerException.Message;
                response.Data = null;
                response.Meta = metadata;
                return response;
            }





        }


        public async Task<ArgClass> GetDetailClient(MtrCliente mtrCliente)
        {



            ArgClass result = new ArgClass();
            result.company_type = "company";
            result.IdContacto = 0;
            result.IdCliente = mtrCliente.Codigo.Trim();
            if (mtrCliente.NoRegTribut == null)
            {
                mtrCliente.NoRegTribut = "RIF";
            }
            result.Rif = mtrCliente.NoRegTribut.Trim();
            result.Nombre = mtrCliente.Nombre.Trim();



            if (mtrCliente.Telefono1 == null)
            {


                mtrCliente.Telefono1 = "5555555";
            }

            if (mtrCliente.Telefono1.Trim() == "")
            {

                mtrCliente.Telefono1 = "5555555";
            }

            result.Telefono = mtrCliente.Telefono1.Trim();

            if (mtrCliente.Telefono == null)
            {
                mtrCliente.Telefono = "5555555";
            }

            if (mtrCliente.Telefono.Trim() == "")
            {
                mtrCliente.Telefono = "5555555";
            }


            result.Celular = mtrCliente.Telefono.Trim();

            if (mtrCliente.EMailClient == null)
            {
                mtrCliente.EMailClient = "";
            }
            result.Email = mtrCliente.EMailClient.Trim();
            if (string.IsNullOrEmpty(mtrCliente.EMailClient.Trim())) result.Email = "sinEmail@gmail.com";

            result.Poder = "";
            result.Cargo = "";
            result.Departamento = "";


            if (string.IsNullOrEmpty(mtrCliente.TipoNegocio.Trim()))
            {
                result.TipoNegocio = "1";
            }
            else
            {
                result.TipoNegocio = mtrCliente.TipoNegocio.Trim();
            }




            if (mtrCliente.CodSubSegmento == null)
            {
                mtrCliente.CodSubSegmento = "";
            }
            mtrCliente.CodSubSegmento = mtrCliente.CodSubSegmento.Trim();
            if (string.IsNullOrEmpty(mtrCliente.CodSubSegmento))
            {

                result.Ramo = "498";
                result.Sector = "53";
            }
            else
            {
                try
                {

                    decimal codSubSegmento = decimal.Parse(mtrCliente.CodSubSegmento, CultureInfo.InvariantCulture); // 14500
                    var ramo = await _unitOfWork.Wsmy065Repository.GetByRamo(codSubSegmento);
                    if (ramo != null)
                    {
                        result.Ramo = ramo.Ramo.ToString();
                        result.Sector = ramo.Sector.ToString();

                    }
                    else
                    {
                        result.Ramo = "498";
                        result.Sector = "53";

                    }
                }
                catch (Exception e)
                {

                    result.Ramo = "498";
                    result.Sector = "53";
                }

            }

            //if (string.IsNullOrEmpty(result.Sector)) { result.Sector = "1"; } else { result.Sector = mtrCliente.Segmento.Trim(); }

            //if (string.IsNullOrEmpty(mtrCliente.CodSubSegmento)) { result.Ramo = "1"; } else { result.Ramo = mtrCliente.CodSubSegmento.Trim(); };
            if (mtrCliente.Direccion == null)
            {
                mtrCliente.Direccion = "";
            }
            result.Direccion = mtrCliente.Direccion.Trim();

            if (mtrCliente.Direccion2 == null)
            {
                mtrCliente.Direccion2 = "";
            }
            result.Direccion2 = mtrCliente.Direccion2.Trim();

            if (mtrCliente.CodigoPostal == null)
            {
                mtrCliente.CodigoPostal = "";
            }
            result.CodigoPostal = mtrCliente.CodigoPostal.Trim();
            result.Pais = "1";

            if (mtrCliente.Municipio == null)
            {
                mtrCliente.Municipio = "";
            }

            var municipio = await _unitOfWork.Winy243Repository.GetByCodigoMunicipio(mtrCliente.Municipio);
            if (municipio != null)
            {
                result.Ciudad = municipio.CapitalMcpo.Trim();
                result.Estado = municipio.IdEstado.ToString();
                result.Municipio = municipio.Recnum.ToString();
            }
            else
            {
                result.Ciudad = "SIN CIUDAD";
                result.Estado = "999";
                result.Municipio = "999";
            }


            result.company_ref = "1";

            //ASIGNACION DEL ID_COMERCIANTE DEFAULT
            var config = await _unitOfWork.AppConfigAppRepository.GetByKey("IdComerciante");
            string idComerciante = "";
            if (!string.IsNullOrEmpty(config.Valor)) idComerciante = config.Valor;
            result.IdComerciante = Convert.ToInt32(idComerciante);


            //ASIGNAMOS EL ID_COMERCIANTE SI EL CONSULTOR ESTA ACTIVO
            var vendedor = await _unitOfWork.MtrVendedorRepository.GetByIdAsync(mtrCliente.Vendedor1.Trim());
            if (vendedor != null)
            {
                if (vendedor.IdUsuarioOdoo != null && vendedor.IdUsuarioOdoo > 0)
                {
                    result.IdComerciante = (int)vendedor.IdUsuarioOdoo;
                    if (vendedor.Activo == "") result.IdComerciante = Convert.ToInt32(idComerciante);
                }
            }
            result.Direcciones = await ListDirecciones(mtrCliente.Codigo);

            return result;
        }

        public async Task<List<Direcciones>> ListDirecciones(string idCliente)
        {
            List<Direcciones> result = new List<Direcciones>();

            var cliente = await _unitOfWork.MtrClienteRepository.GetByIdAsync(idCliente);

            var direcciones = await _unitOfWork.MtrDireccionesRepository.GetByIdCliente(idCliente);
            foreach (var direccion in direcciones.Where(x => !x.Direccion.IsNullOrEmpty()))
            {
                Direcciones resultItem = new Direcciones();
                resultItem.OdooId = 0;
                resultItem.MooreId = direccion.Id.ToString();
                resultItem.Calle1 = direccion.Direccion.Trim();
                resultItem.Calle2 = direccion.Direccion1.Trim();
                resultItem.CodigoPostal = cliente.CodigoPostal.Trim();
                resultItem.IdPais = "1";

                var municipio = await _unitOfWork.Winy243Repository.GetByCodigoMunicipio(direccion.Municipio);
                if (municipio != null)
                {
                    resultItem.Ciudad = municipio.CapitalMcpo;
                    resultItem.IdMunicipio = municipio.Recnum.ToString();

                    resultItem.IdEstado = municipio.IdEstado.ToString();
                }
                else
                {


                    var municipioClient = await _unitOfWork.Winy243Repository.GetByCodigoMunicipio(cliente.Municipio);
                    if (municipioClient != null)
                    {
                        resultItem.Ciudad = municipioClient.CapitalMcpo;
                        resultItem.IdEstado = municipioClient.IdEstado.ToString();
                        resultItem.IdMunicipio = municipioClient.Recnum.ToString();
                    }
                    else
                    {
                        resultItem.Ciudad = "CARACAS";
                        resultItem.IdMunicipio = "1";
                        resultItem.IdEstado = "1";
                    }


                }


                resultItem.Facturacion = false;
                resultItem.Envio = false;


                if ((cliente.IdDireccion == direccion.Id) || (idCliente == "000000"))
                {
                    resultItem.PorDefecto = true;
                    resultItem.Facturacion = true;
                    resultItem.Envio = true;

                }
                else
                {
                    resultItem.PorDefecto = false;
                    resultItem.Facturacion = false;
                    resultItem.Envio = true;
                }
                if (resultItem.Calle1.Trim() != "")
                {
                    result.Add(resultItem);
                }



            }

            return result;

        }

        public async Task<OdooClients> GetOdooCliente(MtrCliente mtrCliente)
        {
            /*
             OdooServerProd
             OdooServerDev
             OdooTokenProd
             OdooTokenDev*/

            var server = await _unitOfWork.AppConfigAppRepository.GetByKey("OdooServerProd");
            var token = await _unitOfWork.AppConfigAppRepository.GetByKey("OdooTokenProd");

            ArrayList arr = new ArrayList();
            arr.Add(server.Valor.Trim());
            arr.Add(2);
            arr.Add(token.Valor.Trim());
            arr.Add("integration.model");
            arr.Add("contact_create_update");

            var listOfStrings = new List<string>();
            string[] arrayOfStrings = listOfStrings.ToArray();
            arr.Add(arrayOfStrings);
            ArrayList arrCliente = new ArrayList();
            var detailCliente = await GetDetailClient(mtrCliente);
            arrCliente.Add(detailCliente);
            arr.Add(arrCliente);


            OdooClients odooClients = new OdooClients();
            odooClients.jsonrpc = "2.0";
            odooClients.method = "call";
            odooClients.Params = new Params
            {
                Service = "object",
                Method = "execute",
                Args = arr

            };

            return odooClients;

        }

        public async Task UpdateClientesToOdoo(List<MtrCliente> mtrClientes)
        {

            foreach (var item in mtrClientes)
            {
                var odooProduct = await GetOdooCliente(item);

                string json1 = JsonConvert.SerializeObject(odooProduct);
                StringContent data = new StringContent(json1, Encoding.UTF8, "application/json");

                var result = await _odooClient.Post(data);




                //var myclass = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(result.Message);
                Respuesta respuesta = new Respuesta();
                respuesta = Newtonsoft.Json.JsonConvert.DeserializeObject<Respuesta>(result.Message);


                if (respuesta.result == null || !respuesta.result.success)
                {
                    MtrClienteEnvioOdooLog mtrClienteEnvioOdooLog = new MtrClienteEnvioOdooLog();
                    mtrClienteEnvioOdooLog.IdCliente = item.Codigo;
                    mtrClienteEnvioOdooLog.Mensaje = result.Message;
                    mtrClienteEnvioOdooLog.Fecha = DateTime.Now;
                    await _unitOfWork.MtrClienteRepository.AddMtrClienteEnvioOdooLog(mtrClienteEnvioOdooLog);
                }
                else
                {
                    //Enviamos los contactos de cada cliente
                    var mtrContactos = await _unitOfWork.MtrContactosRepository.GetByIdCliente(item.Codigo);
                    if (mtrContactos.Count > 0)
                    {
                        await UpdateContactosToOdoo(mtrContactos);
                    }
                }





            }

        }

        public async Task UpdateContactosToOdoo(List<MtrCliente> mtrClientes)
        {

            foreach (var item in mtrClientes)
            {

                var mtrContactos = await _unitOfWork.MtrContactosRepository.GetByIdCliente(item.Codigo);
                if (mtrContactos.Count > 0)
                {
                    await UpdateContactosToOdoo(mtrContactos);
                }




            }

        }


        public async Task EniarClientesAOdoo(string region)
        {
            var clientes = await _unitOfWork.MtrClienteRepository.GetAllActive(region);

            //var clientesOrder = clientes.Where(x => x.Vendedor1.Trim() == "GR13").OrderByDescending(x => x.Codigo).ToList();
            var clientesOrder = clientes.OrderByDescending(x => x.Codigo).ToList();
            await UpdateClientesToOdoo(clientesOrder);

        }




        public async Task<OdooClients> GetOdooContacto(MtrContactos mtrContacto)
        {

            /*
              OdooServerProd
              OdooServerDev
              OdooTokenProd
              OdooTokenDev*/

            var server = await _unitOfWork.AppConfigAppRepository.GetByKey("OdooServerProd");
            var token = await _unitOfWork.AppConfigAppRepository.GetByKey("OdooTokenProd");
            ArrayList arr = new ArrayList();
            arr.Add(server.Valor.Trim());
            arr.Add(2);
            arr.Add(token.Valor.Trim());
            arr.Add("integration.model");
            arr.Add("contact_create_update");

            var listOfStrings = new List<string>();
            string[] arrayOfStrings = listOfStrings.ToArray();
            arr.Add(arrayOfStrings);

            ArrayList arrCliente = new ArrayList();
            var detailContacto = await GetDetailContacto(mtrContacto);
            arrCliente.Add(detailContacto);
            arr.Add(arrCliente);


            OdooClients odooClients = new OdooClients();
            odooClients.jsonrpc = "2.0";
            odooClients.method = "call";
            odooClients.Params = new Params
            {
                Service = "object",
                Method = "execute",
                Args = arr

            };

            return odooClients;

        }

        public async Task<ArgClass> GetDetailContacto(MtrContactos mtrContactos)
        {



            ArgClass result = new ArgClass();
            result.company_type = "person";
            result.IdContacto = (int)mtrContactos.IdContacto;
            result.IdCliente = mtrContactos.IdCliente.Trim();
            result.Rif = mtrContactos.Rif;
            result.Nombre = mtrContactos.Nombre.Trim();
            if (mtrContactos.Telefono1 == null)
            {


                mtrContactos.Telefono1 = "5555555";
            }

            if (mtrContactos.Telefono1.Trim() == "")
            {

                mtrContactos.Telefono1 = "5555555";
            }
            result.Telefono = mtrContactos.Telefono1.Trim();
            if (mtrContactos.Celular == null)
            {
                mtrContactos.Celular = "";
                result.Celular = "";
            }
            if (mtrContactos.Celular.Trim() == "")
            {
                result.Celular = mtrContactos.Telefono1.Trim();
            }
            else
            {
                result.Celular = mtrContactos.Celular.Trim();
            }

            result.Email = mtrContactos.Email.Trim();

            if (string.IsNullOrEmpty(mtrContactos.Email.Trim())) result.Email = "sinEmail@gmail.com";



            //BUSCAMOS EL CARGO EN LA TABLA SAPCONTACTO
            var sapContacto = await _unitOfWork.SapContactoRepository.GetByIdContacto(mtrContactos.IdContacto);
            if (sapContacto != null)
            {
                result.Cargo = "2"; //sapContacto.Pafkt;
                var poder = await _unitOfWork.SapPoderContactoRepository.GetById(sapContacto.Parvo);
                if (poder != null)
                {
                    result.Poder = poder.Id.ToString();
                }
                else
                {
                    result.Poder = "4";
                }

                var departamento = await _unitOfWork.SapDepartamentoContactoRepository.GetByDescripcion(mtrContactos.Area);
                if (departamento != null)
                {
                    result.Departamento = departamento.Id.ToString();
                }
                else
                {
                    result.Departamento = "2";
                }

            }
            else
            {
                result.Cargo = "2";
                result.Poder = "4";
                result.Departamento = "2";
            }




            result.TipoNegocio = "";
            result.Sector = "";
            result.Ramo = "";
            result.Direccion = "";
            result.Direccion2 = "";
            result.Ciudad = "";
            result.CodigoPostal = "";
            result.Pais = "1";
            result.Estado = "";
            result.Municipio = "";
            result.company_ref = "1";

            List<Direcciones> direccones = new List<Direcciones>();

            result.Direcciones = direccones;

            //ASIGNACION DEL ID_COMERCIANTE DEFAULT
            var config = await _unitOfWork.AppConfigAppRepository.GetByKey("IdComerciante");
            string idComerciante = "";
            if (!string.IsNullOrEmpty(config.Valor)) idComerciante = config.Valor;
            result.IdComerciante = Convert.ToInt32(idComerciante);




            return result;
        }

        public async Task UpdateContactosToOdoo(List<MtrContactos> mtrContactos)
        {

            foreach (var item in mtrContactos)
            {
                var odooProduct = await GetOdooContacto(item);
                try
                {
                    //JsonSerializerOptions options = new JsonSerializerOptions
                    //{
                    //    IgnoreNullValues = true,
                    //    WriteIndented = true,
                    //    PropertyNameCaseInsensitive = true
                    //};
                    //string json = JsonSerializer.Serialize(odooProduct, options);

                    //StringContent data = new StringContent(json, Encoding.UTF8, "application/json");

                    string json1 = JsonConvert.SerializeObject(odooProduct);
                    StringContent data = new StringContent(json1, Encoding.UTF8, "application/json");



                    Metadata result = await _odooClient.Post(data);

                }
                catch (Exception e)
                {
                    var msg = e.InnerException.Message;

                }




            }

        }

    }
}
