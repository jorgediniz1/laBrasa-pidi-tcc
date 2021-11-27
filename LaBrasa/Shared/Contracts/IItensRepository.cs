using LaBrasa.Shared.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LaBrasa.Shared.Contracts
{
    public interface IItensRepository
    {
        Task<Itens> AddAsync(Itens item);
        Task<List<Itens>> GetAllAsync();
        Task<Itens> GetById(int id);
        Task<Itens> UpdateAsync(Itens item);
        Task Delete(int id);
    }
}
