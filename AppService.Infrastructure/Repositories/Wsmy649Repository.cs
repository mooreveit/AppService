using AppService.Core.EntitiesMooreve;
using AppService.Core.Interfaces;
using AppService.Infrastructure.DataMooreve;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class Wsmy649Repository : IWsmy649Repository
    {


        private readonly MooreveContext _context;

        public Wsmy649Repository(MooreveContext context)
        {
            _context = context;
        }



        public async Task<Wsmy649> BuscarRuta(short idSubCategoria, short idOficina)
        {
            var ruta = await _context.Wsmy649.Where(x => x.IdSubCategoria == idSubCategoria && x.IdOficina == idOficina).FirstOrDefaultAsync();

            return ruta;
        }


        public async Task<int> BuscarAprobador(short idSubCategoria, short idOficina, short idRuta)
        {



            int idStacion = 0;

            var IdSubCategoriaParam = new SqlParameter("@IdSubCategoria", idSubCategoria);
            var IdOficinaParam = new SqlParameter("@IdOficina", idOficina);
            var idRutaParam = new SqlParameter("@IdRuta", idRuta);


            try
            {





                var result = await _context.Wsmy646.FromSqlRaw<Wsmy646>("exec PaBuscarAprobadorNew @IdSubCategoria,@IdOficina,@IdRuta", IdSubCategoriaParam, IdOficinaParam, idRutaParam).ToListAsync();
                if (result.Count > 0)
                {
                    idStacion = result.FirstOrDefault().IdEstacion;
                }
                else
                {
                    idStacion = 0;
                }


                return idStacion;
            }
            catch (Exception ex)
            {
                var msg = ex.InnerException.Message;
                throw;
            }

            //var result = _context.Wsmy649.FromSql("exec PaBuscarAprobador @IdSubCategoria,@IdOficina,@IdRuta", IdSubCategoriaParam, IdOficinaParam, idRutaParam).AsNoTracking().ToList();


            //var result = _context.Wsmy649.FromSql("exec PaBuscarAprobador @IdSubCategoria,@IdOficina,@IdRuta", IdSubCategoriaParam, IdOficinaParam, idRutaParam).AsNoTracking().ToList();

            //var aprobadores = _context.Database.ExecuteSqlRaw("exec PaBuscarAprobador @IdSubCategoria,@IdOficina,@IdRuta", IdSubCategoriaParam, IdOficinaParam, idRutaParam);

            // AprobadoresPorRutaDto





        }

    }
}
