using AutoMapper;
using NorthWind.Modelos;
using NorthWind.Modelos.Dtos;
using System.Runtime.CompilerServices;


namespace NorthWind.Mappers
{
    public class NorthWindMappers : Profile
    {
        public NorthWindMappers()
        {
            //Se crea la relacion del modelo con el DTO para que el mapper pueda relacionar los datos del
            //modelo con el DTO
            CreateMap<Cliente, ClienteDto>().ReverseMap();
            CreateMap<Orden,  OrdenDto>().ReverseMap();
        }
    }
}
