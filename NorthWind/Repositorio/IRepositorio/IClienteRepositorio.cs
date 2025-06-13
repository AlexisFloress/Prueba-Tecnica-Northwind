using NorthWind.Modelos;

namespace NorthWind.Repositorio.IRepositorio
{
    public interface IClienteRepositorio
    {
        ICollection<Cliente> GetClientes();
        ICollection<Cliente> GetClientesPorPais(string pais);
        ICollection<Orden> GetOredenesPorClienteId(int id);
        ICollection<Orden> GetOrdenes();
    }
}