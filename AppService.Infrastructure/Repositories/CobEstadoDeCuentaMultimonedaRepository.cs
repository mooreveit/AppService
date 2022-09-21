using AppService.Core.EntitiesMooreve;
using AppService.Core.Interfaces;
using AppService.Infrastructure.DataMooreve;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class CobEstadoDeCuentaMultimonedaRepository : ICobEstadoDeCuentaMultimonedaRepository
    {
        private readonly MooreveContext _context;

        public CobEstadoDeCuentaMultimonedaRepository(MooreveContext context)
        {
            _context = context;
        }


        public async Task Add(CobEstadoCuentaMultiMoneda entity)
        {
            await _context.CobEstadoCuentaMultiMoneda.AddAsync(entity);


        }

        public async Task AddList(List<CobEstadoCuentaMultiMoneda> entity)
        {
            _context.CobEstadoCuentaMultiMoneda.AddRange(entity);
            await _context.SaveChangesAsync(); // don't remember exaxct syntaxt but this should be faster way


        }

        public void Update(CobEstadoCuentaMultiMoneda entity)
        {
            _context.CobEstadoCuentaMultiMoneda.Update(entity);

        }
        public async Task DeleteByCliente(string cliente)
        {
            var clienteList = await GetByCliente(cliente);
            if (clienteList!= null) {
                _context.CobEstadoCuentaMultiMoneda.RemoveRange(clienteList); ;
            }
            
        }
        public async Task<List<CobEstadoCuentaMultiMoneda>> GetByCliente(string cliente)
        {
            return await _context.CobEstadoCuentaMultiMoneda.Where(x => x.Cliente.Trim() == cliente.Trim()).ToListAsync(); ;
        }

        public async Task<CobEstadoCuentaMultiMoneda> GetByDocumentoSap(string id)
        {
            return await _context.CobEstadoCuentaMultiMoneda.Where(x => x.DocumentoSap == id).FirstOrDefaultAsync(); ;
        }

        public void UpdateEstadoCuentaMultimoneda()
        {
            var cmd = _context.Database.GetDbConnection().CreateCommand();
            cmd.CommandText = "[dbo].[CobUpdateEstadoCuentaMultimoneda]";

            //common
            cmd.CommandType = CommandType.StoredProcedure;
            if (cmd.Connection.State != ConnectionState.Open) cmd.Connection.Open();
            //cmd.Parameters.Add(new SqlParameter("@LOGIN", SqlDbType.VarChar) { Value = user });
            //cmd.Parameters.Add(new SqlParameter("@PASSWORD", SqlDbType.VarChar) { Value = password });
            //cmd.Parameters.Add(new SqlParameter("@EXIT", SqlDbType.Int) { Direction = ParameterDirection.Output });

            cmd.ExecuteNonQuery();



        }

        public void DeleteEstadoCuentaMultimoneda()
        {
            var cmd = _context.Database.GetDbConnection().CreateCommand();
            cmd.CommandText = "[dbo].[DeleteEstadoCuentaMultimoneda]";

            //common
            cmd.CommandType = CommandType.StoredProcedure;
            if (cmd.Connection.State != ConnectionState.Open) cmd.Connection.Open();
            //cmd.Parameters.Add(new SqlParameter("@LOGIN", SqlDbType.VarChar) { Value = user });
            //cmd.Parameters.Add(new SqlParameter("@PASSWORD", SqlDbType.VarChar) { Value = password });
            //cmd.Parameters.Add(new SqlParameter("@EXIT", SqlDbType.Int) { Direction = ParameterDirection.Output });

            cmd.ExecuteNonQuery();



        }
    }
}
