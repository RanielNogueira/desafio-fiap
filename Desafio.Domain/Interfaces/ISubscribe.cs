using Desafio.Domain.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Desafio.Domain.Interfaces
{
    public interface ISubscribe
    {
        Task Insert(Subscribe sub);
        Task<IEnumerable<Subscribe>> GetAll();
        Task<Subscribe> Get(int id);
        Task Delete(Subscribe id);
        Task Update(Subscribe sub);
        Task<Subscribe> Verification(string email);
        Task<bool> Exists(int id);
    }
}
