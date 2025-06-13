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
            CreateMap<Cliente, ClienteDto>().ReverseMap();
            CreateMap<Orden,  OrdenDto>().ReverseMap();
        }
    }
}
