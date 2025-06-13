using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NorthWind.Modelos.Dtos;
using NorthWind.Repositorio.IRepositorio;
using System.Runtime.CompilerServices;

namespace NorthWind.Controllers
{
    [Route("api/Customers")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly IClienteRepositorio _clienteRepo;
        private readonly IMapper _mapper;

        public CustomersController(IClienteRepositorio cRepo, IMapper mapper)
        {
            _clienteRepo = cRepo;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetClientes()
        {
            var listaClientes = _clienteRepo.GetClientes();
            var listaClientesDto = new List<ClienteDto>();

            foreach (var lista in listaClientes)
            {
                listaClientesDto.Add(_mapper.Map<ClienteDto>(lista));
            }
            return Ok(listaClientesDto);
        }


        [HttpGet("{ClientesPais}", Name = "GetClientePorPais")]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetPelicula(string ClientesPais)
        {
            var clientes = _clienteRepo.GetClientesPorPais(ClientesPais);

            if (clientes == null || !clientes.Any())
            {
                return NotFound();
            }

            // Mapeamos la lista de clientes a lista de DTOs
            var clientesDto = clientes.Select(c => _mapper.Map<ClienteDto>(c)).ToList();

            return Ok(clientesDto);
        }
    }
}
