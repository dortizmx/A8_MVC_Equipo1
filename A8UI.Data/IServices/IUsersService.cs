using System.Threading;
using System.Threading.Tasks;
using A8UI.Data.Domain;

namespace A8UI.Data.IServices
{
    public interface IUsersService : IService<Users>
    {
        public Task<Users> GetByEmail(string email, CancellationToken ct = default(CancellationToken));
    }
}
