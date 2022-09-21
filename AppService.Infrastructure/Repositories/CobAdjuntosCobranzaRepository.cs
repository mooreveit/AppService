using AppService.Core.DTOs;
using AppService.Core.Entities;
using AppService.Core.Interfaces;
using AppService.Core.QueryFilters;
using AppService.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class CobAdjuntosCobranzaRepository: ICobAdjuntosCobranzaRepository
    {
        private readonly RRDContext _context;

        public CobAdjuntosCobranzaRepository(RRDContext context) 
        {
            _context = context;
        }

        public IEnumerable<CobAdjuntosCobranza> GetAll()
        {
            return _context.CobAdjuntosCobranza.AsEnumerable();
        }
        public async Task<CobAdjuntosCobranza> GetById(long id)
        {
            return await _context.CobAdjuntosCobranza.FindAsync(id);
        }
        public async Task Add(CobAdjuntosCobranza entity)
        {
            await _context.CobAdjuntosCobranza.AddAsync(entity);


        }
        public async Task<List<CobAdjuntosCobranza>> GetAdjuntoRecibo(long recibo)
        {
            string nombreArchivo = "RC_" + recibo.ToString() + ".pdf";
            string nombreArchivoJpg = "RC_" + recibo.ToString() + ".jpg";
            return await _context.CobAdjuntosCobranza.Where(x => x.Documento == recibo && x.IdTipoDocumento == 20 && (x.NombreArchivo==nombreArchivo || x.NombreArchivo == nombreArchivoJpg)).OrderByDescending(x=> x.FechaCreacion).ToListAsync();
        }
        public async Task<List<CobAdjuntosCobranza>> GetAdjuntoPorDocumento(long recibo)
        {
            
            return await _context.CobAdjuntosCobranza.Where(x => x.Documento == recibo ).OrderByDescending(x => x.FechaCreacion).ToListAsync();
        }



        public async Task<List<CobAdjuntosCobranza>> GetAdjuntoTiff()
        {
            string searchText = ".tiff";
            


            try
            {
                var result = await _context.CobAdjuntosCobranza.Where(x => x.NombreArchivo.Trim().ToLower().Contains(searchText)).ToListAsync();
                return result;


            }
            catch (Exception e)
            {
                var msg = e.InnerException.Message;
                throw;
            }
        }


        public async Task<bool> DocumentoTieneAdjunto(long recibo)
        {
            bool result = false; 

            var existe = await _context.CobAdjuntosCobranza.Where(x => x.Documento == recibo).FirstOrDefaultAsync();
            if (existe!=null)
            {
                result = true;
            }

            return result;
        }

        public async Task DeleteByNameFile(long recibo,string nombreArchivo)
        {

            var adjunto = await _context.CobAdjuntosCobranza.Where(x => x.Documento == recibo && x.NombreArchivo.Trim()== nombreArchivo.Trim()).ToListAsync();

            if (adjunto!= null)
            {

                foreach (var item in adjunto)
                {
                    await Delete(item.IdAdjunto);
                }

            }

        }


        public async Task Delete(long id)
        {
            CobAdjuntosCobranza entity = await GetById(id);
            _context.CobAdjuntosCobranza.Remove(entity);

        }


    }
}
