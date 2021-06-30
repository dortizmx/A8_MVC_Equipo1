using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using A8UI.Data.Domain;
using A8UI.Data.IRepositories;
using Dapper;
using System.Linq;

namespace A8UI.Data.Repositories
{
    public class PacienteRepository : IPacienteRepository
    {
        IDbConnection dbConnection;
        public PacienteRepository(IDbConnection dbConnection)
        {
            this.dbConnection = dbConnection;
        }

        public async Task<Paciente> Add(Paciente obj, CancellationToken ct = default)
        {
            string sql = "INSERT INTO paciente (nombre, apellidopaterno,apellidomaterno, fechanaciemiento, fechaingreso, status) values (@nombre, @apellidopaterno, @apellidomaterno, @fechanacimiento, @fechaingreso,@status)";
            var result = await dbConnection.ExecuteAsync(sql,
                new
                {
                    obj.Nombre,
                    obj.ApellidoPaterno,
                    obj.ApellidoMaterno,
                    obj.FechaNacimiento,
                    fechaingreso = DateTime.Now,
                    Status = "AC"
                }
                );
            if (result > 0) return obj;
            return null;
             
        }

        public Task<Paciente> Delete(Paciente obj, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Paciente>> GetAll(CancellationToken ct = default)
        {
            var sql = new StringBuilder();
            sql.Append(" select id, nombre,apellidopaterno, apellidomaterno, fechanaciemiento 'fechanacimiento', fechaingreso, status ");
            sql.Append("   from paciente");
            var retvalue = await dbConnection.QueryAsync<Paciente>(sql.ToString());
            return retvalue.ToList<Paciente>();
        }

        public Task<Paciente> GetById(int id, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public Task<Paciente> Update(Paciente obj, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }
    }
}
