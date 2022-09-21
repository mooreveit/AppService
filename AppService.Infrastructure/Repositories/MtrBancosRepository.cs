using AppService.Core.DTOs;
using AppService.Core.Entities;
using AppService.Core.Interfaces;
using AppService.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class MtrBancosRepository: IMtrBancosRepository
    {

        private readonly RRDContext _context;

        public MtrBancosRepository(RRDContext context)
        {
            _context = context;
        }

        public async Task<List<MtrBancos> >GetAll()
        {

            return await _context.MtrBancos.Where(x=> x.FlagActivo == true && x.FlagIngreso == true).ToListAsync();

        }

        public async Task<MtrBancos> GetById(short id)
        {
            var bancos = await _context.MtrBancos.FindAsync(id);
            return bancos;
        }

        public async Task<MtrBancos> GetByCodigo(string id)
        {
            return await _context.MtrBancos.Where(x=>x.Codigo==id).FirstOrDefaultAsync();
        }

        public async Task Add(MtrBancos entity)
        {
            await _context.MtrBancos.AddAsync(entity);


        }



        public void Update(MtrBancos entity)
        {
            _context.MtrBancos.Update(entity);

        }

        public async Task Delete(string id)
        {
            MtrBancos entity = await GetByCodigo(id);
            _context.MtrBancos.Remove(entity);

        }


        public async Task<List<MtrBancosDto>> GetBancos(string Id)
        {

            
            List<MtrBancosDto> resultDto = new List<MtrBancosDto>();
            if (Id!="")
            {
                var result =  await (from ban in _context.MtrBancos
                                    join trancuen in _context.MtrTipoTransaccionCuentaDestino on ban.IdTipoCuentaDestino equals trancuen.IdTipoCuentaDestino
                                    where ban.FlagActivo == true && ban.FlagIngreso == true && trancuen.IdTipoTransaccion == Id
                                     select new
                                 {
                                     Recnum=ban.Recnum,
                                     Codigo = ban.Codigo,
                                     Nombre = ban.Nombre,
                                     CodContable = ban.CodContable,
                                     IdTipoCuentaDestino = ban.IdTipoCuentaDestino,
                                            IdTipoTransaccion = trancuen.IdTipoTransaccion
                                 }).ToListAsync();

                foreach (var item in result)
                {

                    MtrBancosDto resultDtoitem = new MtrBancosDto();
                    resultDtoitem.Recnum = item.Recnum;
                    resultDtoitem.Codigo = item.Codigo;
                    resultDtoitem.CodContable = item.CodContable;
                    resultDtoitem.Nombre = item.Nombre;
                    resultDtoitem.IdTipoCuentaDestino = item.IdTipoCuentaDestino;
                    resultDtoitem.IdTipoTransaccion = item.IdTipoTransaccion;
                    resultDto.Add(resultDtoitem);

                }

            }
            else
            {
               var result = await (from ban in _context.MtrBancos
                                join trancuen in _context.MtrTipoTransaccionCuentaDestino on ban.IdTipoCuentaDestino equals trancuen.IdTipoCuentaDestino
                                where ban.FlagActivo == true && ban.FlagIngreso == true 
                                select new {
                                    Recnum = ban.Recnum,
                                    Codigo = ban.Codigo,
                                             Nombre = ban.Nombre,
                                            CodContable=ban.CodContable,
                                            IdTipoCuentaDestino=ban.IdTipoCuentaDestino,
                                            IdTipoTransaccion =trancuen.IdTipoTransaccion }).ToListAsync();

                foreach (var item in result)
                {

                    MtrBancosDto resultDtoitem = new MtrBancosDto();
                    resultDtoitem.Recnum = item.Recnum;
                    resultDtoitem.Codigo = item.Codigo;
                    resultDtoitem.CodContable = item.CodContable;
                    resultDtoitem.Nombre = item.Nombre;
                    resultDtoitem.IdTipoCuentaDestino = item.IdTipoCuentaDestino;
                    resultDtoitem.IdTipoTransaccion = item.IdTipoTransaccion;
                    resultDto.Add(resultDtoitem);

                }
            }
        



            return resultDto.OrderBy(x => x.Nombre).ToList();



        }

    }
}
