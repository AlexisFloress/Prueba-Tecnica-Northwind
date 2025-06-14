using NorthWind.Modelos;

namespace NorthWind.Repositorio.IRepositorio
{
    public interface IWebTrackerRepositorio
    {
        Task TrackRequestAsync(WebTracker tracker);
    }
}
