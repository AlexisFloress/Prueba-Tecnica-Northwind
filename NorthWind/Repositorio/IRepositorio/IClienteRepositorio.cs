using NorthWind.Modelos;

namespace NorthWind.Repositorio.IRepositorio
{
    public interface IClienteRepositorio
    {
        ICollection<Cliente> GetClientesPorPais(string pais);
        ICollection<Cliente> GetClientes();
    }
}
