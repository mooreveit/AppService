using AppService.Core.EntitiesMooreve;
using AppService.Core.Interfaces;
using AppService.Infrastructure.DataMateriales;
using AppService.Infrastructure.DataMooreve;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class Wpry240Repository : IWpry240Repository
    {


        private readonly MooreveContext _context;
        private readonly MaterialesContext _contextMateriales;

        public Wpry240Repository(MooreveContext context, MaterialesContext contextMateriales)
        {
            _context = context;
            _contextMateriales = contextMateriales;
        }

        public async Task<List<Csmy011>> GetListTintasActivas()
        {

            return await _context.Csmy011.Where(x => x.FlagEliminada != "X").OrderByDescending(x => x.Frecuencia).ToListAsync();

        }

        public async Task<List<Wpry240>> GetAll()
        {

            return await _context.Wpry240.ToListAsync();

        }



        public async Task<Wpry240> GetByCotizacionRenglonPropuestaParte(string cotizacion, int renglon, int propuesta, int parte)
        {

            return await _context.Wpry240.Where(x => x.Cotizacion == cotizacion && x.Renglon == renglon && x.Propuesta == propuesta && x.IdParte == parte).FirstOrDefaultAsync();
        }
        public async Task<List<Wpry240>> GetByCotizacion(string cotizacion)
        {

            return await _context.Wpry240.Where(x => x.Cotizacion == cotizacion).ToListAsync();
        }
        public async Task<List<Wpry240>> GetByCotizacionRenglon(string cotizacion, int renglon)
        {

            return await _context.Wpry240.Where(x => x.Cotizacion == cotizacion && x.Renglon == renglon).ToListAsync();
        }

        public async Task Add(Wpry240 entity)
        {


            try
            {
                await _context.Wpry240.AddAsync(entity);
            }
            catch (Exception ex)
            {
                var msg = ex.InnerException.Message;
                throw;
            }
        }

        public async Task<int> GetCantPartes(string cotizacion)
        {
            int result = 0;
            var papeles = await _context.Wpry240.Where(x => x.Cotizacion == cotizacion).ToListAsync();
            result = papeles.Count;
            return result;

        }

        public async Task<string> GetPapeles(string cotizacion)
        {
            string result = string.Empty;
            var papeles = await _context.Wpry240.Where(x => x.Cotizacion == cotizacion).ToListAsync();
            if (papeles.Count > 0)
            {
                foreach (var item in papeles)
                {
                    if (result.Length == 0)
                    {
                        result = item.IdPapel;
                    }
                    else
                    {
                        result = result + "," + item.IdPapel;
                    }


                }
            }
            return result;

        }

        public async Task<string> GetPapelesTipo(string cotizacion)
        {
            string result = string.Empty;
            var papeles = await _context.Wpry240.Where(x => x.Cotizacion == cotizacion).ToListAsync();
            if (papeles.Count > 0)
            {
                foreach (var item in papeles)
                {
                    var papel = await _contextMateriales.Wimy001s.Where(x => x.Codigo == item.IdPapel).FirstOrDefaultAsync();
                    var tipo = await _contextMateriales.Wimy002s.Where(x => x.Tipo == papel.TipoPapel).FirstOrDefaultAsync();
                    if (tipo == null) result = "";
                    if (tipo != null)
                    {
                        if (result.Length == 0)
                        {
                            result = tipo.DESCRIPCION_VENTAS;
                        }
                        else
                        {
                            bool exists = result.Contains(tipo.DESCRIPCION_VENTAS);
                            if (!exists)
                            {
                                result = result + "," + tipo.DESCRIPCION_VENTAS;
                            }


                        }
                    }



                }
            }
            return result;

        }


        public void Update(Wpry240 entity)
        {
            _context.Wpry240.Update(entity).Property(x => x.Recnum).IsModified = false; ;

        }

        public async Task Delete(string cotizacion, int renglon, int propuesta, int parte)
        {
            Wpry240 entity = await GetByCotizacionRenglonPropuestaParte(cotizacion, renglon, propuesta, parte);
            _context.Wpry240.Remove(entity);

        }

    }
}
