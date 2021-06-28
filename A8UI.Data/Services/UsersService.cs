using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using A8UI.Data.Domain;
using A8UI.Data.IServices;
using A8UI.Data.IRepository;

namespace A8UI.Data.Services
{
    public class UsersService : IUsersService
    {
        private IUsersRepository usersRepository;
        public UsersService(IUsersRepository usersRepository)
        {
            this.usersRepository = usersRepository;
        }

        public async Task<Users> Add(Users obj, CancellationToken ct = default)
        {
            var retvalue = await usersRepository.Add(obj, ct);
            return retvalue;
        }

        public async Task<Users> Delete(Users obj, CancellationToken ct = default)
        {
            var retvalue = await usersRepository.Delete(obj, ct);
            return retvalue;
        }

        public async Task<List<Users>> GetAll(CancellationToken ct = default)
        {
            var retvalue = await usersRepository.GetAll(ct);
            return retvalue;
        }

        public async Task<Users> GetByEmail(string email, CancellationToken ct = default)
        {
            var retvalue = await usersRepository.GetByEmail(email, ct);
            return retvalue;
        }

        public async Task<Users> GetById(int id, CancellationToken ct = default)
        {
            var retvalue = await usersRepository.GetById(id, ct);
            return retvalue;
        }

        public async Task<Users> Update(Users obj, CancellationToken ct = default)
        {
            var retvalue = await usersRepository.Update(obj, ct);
            return retvalue;
        }
    }
}
