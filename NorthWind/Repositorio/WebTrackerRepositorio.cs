using Microsoft.EntityFrameworkCore;
using NorthWind.Data;
using NorthWind.Modelos;
using NorthWind.Repositorio.IRepositorio;

namespace NorthWind.Repositorio
{
    public class WebTrackerRepositorio : IWebTrackerRepositorio
    {
        private readonly ApplicationDbContext _db;

        public WebTrackerRepositorio(ApplicationDbContext db)
        {
            _db = db; 
        }
        public async Task TrackRequestAsync(WebTracker tracker)
        {
            _db.WebTracker.Add(tracker);
            await _db.SaveChangesAsync();
        }
    }
}
