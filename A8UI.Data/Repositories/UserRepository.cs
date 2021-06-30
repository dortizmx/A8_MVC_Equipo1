using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using A8UI.Data.Domain;
using A8UI.Data.IRepositories;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using System.Linq;

namespace A8UI.Data.Repositories
{
    public class UserRepository : IUsersRepository
    {
        IDbConnection dbConnection;
        public UserRepository(IDbConnection dbConnection)
        {
            this.dbConnection = dbConnection;
        }

        public Task<Users> Add(Users obj, CancellationToken ct = default)
        {

            throw new NotImplementedException();
        }

        public async Task<Users> Delete(Users obj, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Users>> GetAll(CancellationToken ct = default)
        {
            string sql = "SELECT id, email,nombre, apellido_paterno ApellidoPaterno, apellido_materno ApellidoMaterno, contrasena Contraseña, status, tipousuario FROM users";
            var retvalue = await dbConnection.QueryAsync<Users>(sql);
            return retvalue.ToList<Users>();

        }

        public async Task<Users> GetByEmail(string email, CancellationToken ct = default)
        {
            string sql = "SELECT * FROM users where email = @email";
            var retvalue = await dbConnection.QueryFirstOrDefaultAsync<Users>(sql, new { email = email });
            return retvalue;
            
        }

        public Task<Users> GetById(int id, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public Task<Users> Update(Users obj, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }
    }
}
