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
    public class CobGrabacionCobranzasRepository: ICobGrabacionCobranzasRepository
    {
        private readonly RRDContext _context;

        public CobGrabacionCobranzasRepository(RRDContext context)
        {
            _context = context;
        }


        public IEnumerable<CobGrabacionCobranzas> GetAll()
        {
            return _context.CobGrabacionCobranzas.AsEnumerable();
        }

        public async Task<CobGrabacionCobranzas> GetById(long id)
        {
            return await _context.CobGrabacionCobranzas.FindAsync(id);
        }

        public async Task Add(CobGrabacionCobranzas entity)
        {
            await _context.CobGrabacionCobranzas.AddAsync(entity);


        }



        public async Task Update(CobGrabacionCobranzas entity)
        {

            _context.CobGrabacionCobranzas.Update(entity);

        }

        public async Task Delete(long id)
        {
            CobGrabacionCobranzas entity = await GetById(id);
            _context.CobGrabacionCobranzas.Remove(entity);

        }

        public List<CobGrabacionCobranzas> GetByDocumento(long id)
        {
            return _context.CobGrabacionCobranzas.Where(x=> x.Documento==id).ToList();
        }

        public CobGrabacionCobranzas GetByDocumentoAfecta( decimal docAfecta)
        {
            var grabacionCobranza = _context.CobGrabacionCobranzas.Where(x => x.DocAfecta == docAfecta).FirstOrDefault();


            return grabacionCobranza;
        }

        public async Task<CobGrabacionCobranzas> GetByDocumentoSap(string documentoSap)
        {
            var grabacionCobranza = await _context.CobGrabacionCobranzas.Where(x => x.DocumentoSap == documentoSap).FirstOrDefaultAsync();


            return grabacionCobranza;
        }

        public async Task<bool> GrabacionCobranzasTieneRetencionCero(long documento)
        {
            bool result ;

            result = await DocumentoSinGrabarRetenciones(documento);
           
            return result;

        }


        public async Task<bool> DocumentoSinGrabarRetenciones(long documento)
        {
            bool result=false;

            var grabacion = await _context.CobGrabacionCobranzas.Where(x => x.Documento == documento && x.Transaccion == "RE").ToListAsync();

            if (grabacion != null)
            {
                foreach (var item in grabacion)
                {

                    var retencionGrabada = _context.CobPagosRetenciones.Where(x => x.IdCobranza == item.Id).FirstOrDefault();
                    if (retencionGrabada== null)
                    {
                        result = true;
                        return result;
                    }
                    else
                    {
                        result = false;
                    }

                    
                }

                
            }
            else
            {
                result = false;

            }
            return result;

        }

        public async Task<bool> FacturaTieneRetencionesPendientes(long documento)
        {
            bool result = false;

            var grabacion = await _context.CobGrabacionCobranzas.Where(x => x.Rpdoc == documento ).ToListAsync();

            if (grabacion != null && grabacion.Count>0)
            {
                foreach (var item in grabacion)
                {

                    var retencionGrabada = _context.CobPagosRetenciones.Where(x => x.IdCobranza == item.Id  ).FirstOrDefault();
                    //TODO || String.IsNullOrEmpty(retencionGrabada.DocumentoSap) agregar Validacion por fecha
                    bool contabilizado = false;
                    DateTime fecha = DateTime.Parse("12/01/2021");
                    if (retencionGrabada!=null) {

                        if(retencionGrabada.FechaCrea >= fecha){
                            if (String.IsNullOrEmpty(retencionGrabada.DocumentoSap))
                            {
                                result = true;
                                return result;
                            }
                            else
                            {
                                result = false;
                                return result;
                            }
                        }
                        else
                        {
                            result = false;
                            return result;
                        }
                    }
                    else
                    {
                        result = true;
                        return result;
                    }
                }


            }
            else
            {
                result = true;
                return result;
            }

           
            return result;

        }


        public decimal TotalAfectadoDocumento(long documento,decimal docafecta)
        {
          
            var total = (decimal)_context.CobGrabacionCobranzas.Where(x => x.Documento == documento && x.DocAfecta==docafecta).Sum(x => x.Monto);


            return total;

        }

        public decimal TotalDetalleRecibo(long documento)
        {

            var total = (decimal)_context.CobGrabacionCobranzas.Where(x => x.Documento == documento).Sum(x => x.Monto);

            if (total==null)
            {
                total = 0;
            }
            return total;

        }


        public async Task<bool> ReciboTienePendienteContabilizar(long documento)
        {

          

            var reciboTienePendienteContabilizar = await _context.CobGrabacionCobranzas.Where(x => x.Documento == documento && (x.DocumentoSap == "" || x.DocumentoSap ==null)  && x.Transaccion!="RE").ToListAsync();

            if (reciboTienePendienteContabilizar.Count>0 && reciboTienePendienteContabilizar!= null)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }







    }
}
