using LaBrasa.Shared.Contracts;
using LaBrasa.Shared.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using con = LaBrasa.Shared.Context;

namespace LaBrasa.Shared.Repository
{
    public class ItensRepository : IItensRepository
    {
        private readonly con.Context _context;
        public ItensRepository(con.Context context)
        {
            _context = context;
        }
        public Task<Itens> AddAsync(Itens item)
        {
            throw new System.NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Itens>> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<Itens> GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Itens> UpdateAsync(Itens item)
        {
            throw new System.NotImplementedException();
        }
    }
}
