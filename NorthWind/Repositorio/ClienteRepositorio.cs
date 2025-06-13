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

        public ICollection<Cliente> GetClientes()
        {
            return _db.Cliente.OrderBy(x => x.ContactName).ToList(); 
        }

        public ICollection<Cliente> GetClientesPorPais(string pais)
        {
            return _db.Cliente.Where(x => x.Pais.ToLower() == pais.ToLower()).OrderBy(x => x.ContactName).ToList();
        }

        public ICollection<Orden> GetOrdenes()
        {
            return _db.Orden.OrderBy(x => x.ShippedDate).ToList();

        }

        public ICollection<Orden> GetOredenesPorClienteId(int id)
        {
            return _db.Orden.Where(x => x.CustomerId == id).OrderBy(x => x.ShippedDate).ToList();
        }
    }
}
