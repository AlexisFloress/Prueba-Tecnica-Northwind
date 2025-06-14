using NorthWind.Modelos;
using NorthWind.Repositorio.IRepositorio;

namespace NorthWind.MiddleWare
{
    public class RequestTrackingMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestTrackingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, IWebTrackerRepositorio trackingRepository)
        {
            // Capturar datos antes de procesar la solicitud
            var tracker = new WebTracker
            {
                UrlRequest = context.Request.Path,
                SourceIp = context.Connection.RemoteIpAddress?.ToString() ?? "Desconocido",
                TimeOfAction = DateTime.UtcNow
            };

            // Procesar la solicitud
            await _next(context);

            // Guardar asíncronamente después de completar la respuesta
            await trackingRepository.TrackRequestAsync(tracker);
        }
    }
}
