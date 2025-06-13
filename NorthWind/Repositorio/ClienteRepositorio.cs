using Microsoft.EntityFrameworkCore;
using NorthWind.Data;
using NorthWind.Modelos;
using NorthWind.Repositorio.IRepositorio;

namespace NorthWind.Repositorio
{
    public class ClienteRepositorio : IClienteRepositorio
    {

        private readonly ApplicationDbContext _db;
        public ClienteRepositorio(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<ICollection<Cliente>> GetClientes()
        {
            return await _db.Cliente.OrderBy(x => x.ContactName).ToListAsync(); 
        }

        public async Task<ICollection<Cliente>> GetClientesPorPais(string pais)
        {
            return await _db.Cliente.Where(x => x.Pais.ToLower() == pais.ToLower()).OrderBy(x => x.ContactName).ToListAsync();
        }


        public async Task<ICollection<Orden>> GetOredenesPorClienteId(int id)
        {
            return await _db.Orden.Where(x => x.CustomerId == id).OrderBy(x => x.ShippedDate).ToListAsync();
        }
    }
}
