using NorthWind.Modelos;

namespace NorthWind.Repositorio.IRepositorio
{
    public interface IClienteRepositorio
    {
        //Devuelve en una lista todos los clientes
        Task<ICollection<Cliente>> GetClientes();
        //Devuelve en una lista todos los clientes filtrados por Pais
        Task<ICollection<Cliente>> GetClientesPorPais(string pais);
        //Devuelve en una lista todos las ordenes filtrados id Del cliente
        Task<ICollection<Orden>> GetOredenesPorClienteId(int id);
        
    }
}