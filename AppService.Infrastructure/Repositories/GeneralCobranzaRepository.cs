using AppService.Core.Entities;
using AppService.Core.Interfaces;
using AppService.Core.QueryFilters;
using AppService.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class GeneralCobranzaRepository : ICobGeneralCobranzaRepository
    {
        private readonly RRDContext _context;

        public GeneralCobranzaRepository(RRDContext context)
        {
            _context = context;
        }


        public IEnumerable<CobGeneralCobranza> GetAll()
        {
            return _context.CobGeneralCobranza.AsEnumerable();
        }

        public async Task<CobGeneralCobranza> GetById(long id)
        {
            return await _context.CobGeneralCobranza.FindAsync(id);
        }


        public async Task Add(CobGeneralCobranza entity)
        {
            await _context.CobGeneralCobranza.AddAsync(entity);


        }



        public async Task Update(CobGeneralCobranza entity)
        {

            _context.CobGeneralCobranza.Update(entity);

        }

        public async Task Delete(long id)
        {
            CobGeneralCobranza entity = await GetById(id);
            _context.CobGeneralCobranza.Remove(entity);

        }

        public async Task<CobGeneralCobranza> ExisteCobranzaPendienteEnviar(CobGeneralCobranza generalCobranza)
        {
            CobGeneralCobranza row = await _context.CobGeneralCobranza.Where(x => x.IdCliente == generalCobranza.IdCliente && x.FlagEnviado == false && x.FlagAnulado == false).FirstOrDefaultAsync();
            return row;
        }
        public async Task<CobGeneralCobranza> GetGeneralCobranzaDocumento(long documento)
        {
            CobGeneralCobranza row = await _context.CobGeneralCobranza.Where(x => x.Documento == documento ).FirstOrDefaultAsync();
            return row;
        }

        public async Task<CobGrabacionCobranzas> RCRUYaTieneCobranzaGrabada(long documento)
        {
            CobGrabacionCobranzas row = await _context.CobGrabacionCobranzas.Where(x => x.Documento == documento && (x.Transaccion == "RC" || x.Transaccion == "RU")).FirstOrDefaultAsync();
            return row;
        }

        public async Task<CobGrabacionCobranzas> RETYaTieneCobranzaGrabada(long documento)
        {
            CobGrabacionCobranzas row = await _context.CobGrabacionCobranzas.Where(x => x.Documento == documento && x.Transaccion == "RE").FirstOrDefaultAsync();
            return row;
        }




        public async Task<IEnumerable<CobGeneralCobranza>> ListCobranzaPorUsuario(GeneralCobranzaQueryFilter filter)
        {
            List<CobGeneralCobranza> result = new List<CobGeneralCobranza>();
            string usuario = filter.UsuarioConectado;
            int pageSize = filter.PageSize;
            bool esVendedor = false;
            MtrVendedor vendedor = await _context.MtrVendedor.Where(x => x.Codigo == usuario).FirstOrDefaultAsync();
            if (vendedor != null)
            {
                esVendedor = true;

            }

            if (filter.Vendedor != "")
            {

                if (filter.SearchText != null && filter.SearchText.Length > 0)
                {
                    if (esVendedor)
                    {
                        result = await _context.CobGeneralCobranza.Where(x => x.IdClienteNavigation.Vendedor1 == usuario.ToString() && x.SearchText.Trim().ToLower().Contains(filter.SearchText.Trim().ToLower())).OrderByDescending(x => x.FechaRegistro).Skip((filter.PageNumber - 1) * pageSize).Take(pageSize).ToListAsync();

                    }
                    else
                    {
                        result = await _context.CobGeneralCobranza.Where(x =>  x.SearchText.Trim().ToLower().Contains(filter.SearchText.Trim().ToLower())).OrderByDescending(x => x.FechaRegistro).Skip((filter.PageNumber - 1) * pageSize).Take(pageSize).ToListAsync();

                    }




                }
                else
                {
                    result = await _context.CobGeneralCobranza.Where(x => x.IdClienteNavigation.Vendedor1 == filter.Vendedor.ToString()).OrderByDescending(x => x.FechaRegistro).Skip((filter.PageNumber - 1) * pageSize).Take(pageSize).ToListAsync();

                }



                if (filter.Documento > 0)
                {
                    result = result.Where(x => x.Documento == filter.Documento).ToList();
                }

                return result;

            }


            if (esVendedor)
            {
                if (filter.SearchText != null && filter.SearchText.Length > 0)
                {

                    result = await _context.CobGeneralCobranza.Where(x => x.IdClienteNavigation.Vendedor1 == usuario.ToString() && x.SearchText.Trim().ToLower().Contains(filter.SearchText.Trim().ToLower())).OrderByDescending(x => x.Documento).Skip((filter.PageNumber - 1) * pageSize).Take(pageSize).ToListAsync();

                }
                else
                {
                    result = await _context.CobGeneralCobranza.Where(x => x.IdClienteNavigation.Vendedor1 == usuario.ToString()).OrderByDescending(x => x.Documento).Skip((filter.PageNumber - 1) * pageSize).Take(pageSize).ToListAsync();


                }



                return result;
            }

            MtrVendedor supervisor = await _context.MtrVendedor.Where(x => x.Supervisor == usuario).FirstOrDefaultAsync();
            if (supervisor != null)
            {
                if (filter.SearchText != null && filter.SearchText.Length > 0)
                {

                    result = await (from u in _context.CobGeneralCobranza
                                    join ur in _context.MtrVendedor on u.UsuarioRegistro equals ur.Codigo

                                    where ur.Supervisor == usuario
                                    && u.SearchText.Trim().ToLower().Contains(filter.SearchText.Trim().ToLower())
                                    select u).Skip((filter.PageNumber - 1) * pageSize).Take(pageSize).ToListAsync();

                }
                else
                {
                    result = await (from u in _context.CobGeneralCobranza
                                    join ur in _context.MtrVendedor on u.UsuarioRegistro equals ur.Codigo

                                    where ur.Supervisor == usuario

                                    select u).Skip((filter.PageNumber - 1) * pageSize).Take(pageSize).ToListAsync();

                }


                return result;
            }

            List<MtrUsuarioOficina> usuarioOficina = new List<MtrUsuarioOficina>();
            if (filter.IdOficina == null || filter.IdOficina.Trim() == "")
            {
                usuarioOficina = await _context.MtrUsuarioOficina.Where(x => x.Usuario == usuario).ToListAsync();
            }
            else
            {

                int.TryParse(filter.IdOficina, out int id);
                usuarioOficina = await _context.MtrUsuarioOficina.Where(x => x.Usuario == usuario && x.Oficina == id).ToListAsync();
            }

            if (usuarioOficina.Count > 0)
            {


                if (filter.SearchText != null && filter.SearchText.Length > 0)
                {
                    List<CobGeneralCobranza> cobresult = await _context.CobGeneralCobranza


                                                                .Where(x =>  x.SearchText.Trim().ToLower().Contains(filter.SearchText.Trim().ToLower()))
                                                                .OrderByDescending(x => x.Documento)
                                                                .Skip((filter.PageNumber - 1) * pageSize).Take(pageSize)
                                                                .ToListAsync();

                    result.AddRange(cobresult);


                }
                else
                {
                    // foreach (MtrUsuarioOficina item in usuarioOficina)
                    // {
                    if (filter.Vendedor!="" && filter.Vendedor != null)
                    {


                        result = await _context.CobGeneralCobranza.Where(x => x.IdClienteNavigation.Vendedor1 == filter.Vendedor).OrderByDescending(x => x.Documento).Skip((filter.PageNumber - 1) * pageSize).Take(pageSize).ToListAsync();



                        result.AddRange(result);

                    }
                    else
                    {
                        List<CobGeneralCobranza> cobresult = await _context.CobGeneralCobranza
                                                                      .OrderByDescending(x => x.Documento)
                                                                      .Skip((filter.PageNumber - 1) * pageSize).Take(pageSize)
                                                                      .ToListAsync();
                        result.AddRange(cobresult);


                    }




                    //}
                }





                return result;
            }





            return result;

        }



        public async Task<IEnumerable<CobGeneralCobranza>> ListCobranzaPorUsuarioPendienteVerificarPago(GeneralCobranzaQueryFilter filter)
        {
            List<CobGeneralCobranza> result = new List<CobGeneralCobranza>();
            string usuario = filter.UsuarioConectado;
            int pageSize = filter.PageSize;







            List<MtrUsuarioOficina> usuarioOficina = new List<MtrUsuarioOficina>();
            usuarioOficina = await _context.MtrUsuarioOficina.Where(x => x.Usuario == usuario).ToListAsync();


            if (usuarioOficina.Count > 0)
            {

                foreach (MtrUsuarioOficina item in usuarioOficina)
                {

                    if (filter.SearchText != null && filter.SearchText.Length > 0)
                    {

                        List<CobGeneralCobranza> cobresult = await _context.CobGeneralCobranza.Where(x =>  x.OficinaVenta == item.Oficina.ToString()
                                                                     && x.SearchText.Trim().ToLower().Contains(filter.SearchText.Trim().ToLower())
                                                                     && x.FlagEnviado == true && x.FlagAnulado == false && x.FlagConfirmado == false)
                                                                    .Skip((filter.PageNumber - 1) * pageSize).Take(pageSize)
                                                                    .ToListAsync();

 
                        result.AddRange(cobresult);


                    }
                    else
                    {
                        List<CobGeneralCobranza> cobresult = await _context.CobGeneralCobranza.Where(x => x.OficinaVenta == item.Oficina.ToString()
                                             
                                             && x.FlagEnviado == true && x.FlagAnulado == false && x.FlagConfirmado == false)
                                            .Skip((filter.PageNumber - 1) * pageSize).Take(pageSize)
                                            .ToListAsync();

                        result.AddRange(cobresult);
                    }






                }
                return result;
            }


            result = result.OrderByDescending(x => x.Documento).ToList();
            return result;

        }

        public async Task<IEnumerable<CobGeneralCobranza>> ListCobranzaPorUsuarioPendienteVerificarPagoOld(GeneralCobranzaQueryFilter filter)
        {
            List<CobGeneralCobranza> result = new List<CobGeneralCobranza>();
            string usuario = filter.UsuarioConectado;
            int pageSize = filter.PageSize * 5;







            List<MtrUsuarioOficina> usuarioOficina = new List<MtrUsuarioOficina>();
            usuarioOficina = await _context.MtrUsuarioOficina.Where(x => x.Usuario == usuario).ToListAsync();


            if (usuarioOficina.Count > 0)
            {

                foreach (MtrUsuarioOficina item in usuarioOficina)
                {

                    if (filter.SearchText != null && filter.SearchText.Length > 0)
                    {
                        List<CobGeneralCobranza> cobresult = await (from u in _context.CobGeneralCobranza
                                                                    join ur in _context.MtrCliente on u.IdCliente equals ur.Codigo

                                                                    where ur.OficinaVenta == item.Oficina.ToString()
                                                                     && u.SearchText.Trim().ToLower().Contains(filter.SearchText.Trim().ToLower())
                                                                     && u.FlagEnviado == true && u.FlagAnulado == false && u.FlagConfirmado == false
                                                                    select u).Skip((filter.PageNumber - 1) * pageSize).Take(pageSize).ToListAsync();

                        result.AddRange(cobresult);


                    }
                    else
                    {
                        List<CobGeneralCobranza> cobresult = await (from u in _context.CobGeneralCobranza
                                                                    join ur in _context.MtrCliente on u.IdCliente equals ur.Codigo

                                                                    where ur.OficinaVenta == item.Oficina.ToString()
                                                                    && u.FlagEnviado == true && u.FlagAnulado == false && u.FlagConfirmado == false
                                                                    select u).Skip((filter.PageNumber - 1) * pageSize).Take(pageSize).ToListAsync();
                        result.AddRange(cobresult);
                    }






                }
                return result;
            }





            return result;

        }


        public async Task<IEnumerable<CobGeneralCobranza>> ListGeneralCobranzaPendienteAprobarPago(GeneralCobranzaQueryFilter filter)
        {
            List<CobGeneralCobranza> result = new List<CobGeneralCobranza>();
            string usuario = filter.UsuarioConectado;
            int pageSize = filter.PageSize * 5;






            List<MtrUsuarioOficina> usuarioOficina = new List<MtrUsuarioOficina>();
            usuarioOficina = await _context.MtrUsuarioOficina.Where(x => x.Usuario == usuario).ToListAsync();


            if (usuarioOficina.Count > 0)
            {

                foreach (MtrUsuarioOficina item in usuarioOficina)
                {

                    if (filter.SearchText != null && filter.SearchText.Length > 0)
                    {
                        List<CobGeneralCobranza> cobresult = await _context.CobGeneralCobranza
                                                                   

                                                                    .Where(x=> x.OficinaVenta == item.Oficina.ToString()
                                                                     && x.SearchText.Trim().ToLower().Contains(filter.SearchText.Trim().ToLower())
                                                                     && x.FlagEnviado == true && x.FlagAnulado == false && x.FlagConfirmado == true && x.FlagAprobado == false)
                                                                    .Skip((filter.PageNumber - 1) * pageSize).Take(pageSize)
                                                                    .ToListAsync();

                        result.AddRange(cobresult);


                    }
                    else
                    {
                        List<CobGeneralCobranza> cobresult = await  _context.CobGeneralCobranza
                                                                     .Where(x => x.OficinaVenta == item.Oficina.ToString()
                                                                    
                                                                     && x.FlagEnviado == true && x.FlagAnulado == false && x.FlagConfirmado == true && x.FlagAprobado == false)
                                                                    .Skip((filter.PageNumber - 1) * pageSize).Take(pageSize)
                                                                    .ToListAsync();
                        result.AddRange(cobresult);
                    }






                }
                result = result.OrderByDescending(x => x.Documento).ToList();
                return result;
            }





            return result;

        }


        public async Task<IEnumerable<CobGeneralCobranza>> ListGeneralCobranzaPendienteAprobarPagoOld(GeneralCobranzaQueryFilter filter)
        {
            List<CobGeneralCobranza> result = new List<CobGeneralCobranza>();
            string usuario = filter.UsuarioConectado;
            int pageSize = filter.PageSize * 5;






            List<MtrUsuarioOficina> usuarioOficina = new List<MtrUsuarioOficina>();
            usuarioOficina = await _context.MtrUsuarioOficina.Where(x => x.Usuario == usuario).ToListAsync();


            if (usuarioOficina.Count > 0)
            {

                foreach (MtrUsuarioOficina item in usuarioOficina)
                {

                    if (filter.SearchText != null && filter.SearchText.Length > 0)
                    {
                        List<CobGeneralCobranza> cobresult = await (from u in _context.CobGeneralCobranza
                                                                    join ur in _context.MtrCliente on u.IdCliente equals ur.Codigo

                                                                    where ur.OficinaVenta == item.Oficina.ToString()
                                                                     && u.SearchText.Trim().ToLower().Contains(filter.SearchText.Trim().ToLower())
                                                                     && u.FlagEnviado == true && u.FlagAnulado == false && u.FlagConfirmado == true && u.FlagAprobado == false
                                                                    select u).Skip((filter.PageNumber - 1) * pageSize).Take(pageSize).ToListAsync();

                        result.AddRange(cobresult);


                    }
                    else
                    {
                        List<CobGeneralCobranza> cobresult = await (from u in _context.CobGeneralCobranza
                                                                    join ur in _context.MtrCliente on u.IdCliente equals ur.Codigo

                                                                    where ur.OficinaVenta == item.Oficina.ToString()
                                                                     && u.FlagEnviado == true && u.FlagAnulado == false && u.FlagConfirmado == true && u.FlagAprobado == false
                                                                    select u).Skip((filter.PageNumber - 1) * pageSize).Take(pageSize).ToListAsync();
                        result.AddRange(cobresult);
                    }






                }
                return result;
            }





            return result;

        }



        public async Task<List<CobGeneralCobranza>> GetAllSearchTextBlanco()
        {
            return await _context.CobGeneralCobranza.Where(x=> x.SearchText=="").ToListAsync();
        }

    }
}
