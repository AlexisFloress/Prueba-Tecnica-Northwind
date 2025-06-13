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


        [HttpGet("{Country}", Name = "GetClientePorPais")]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetClientes(string Country)
        {
            var clientes = _clienteRepo.GetClientesPorPais(Country);

            if (clientes == null || !clientes.Any())
            {
                return NotFound();
            }

            // Mapeamos la lista de clientes a lista de DTOs
            var clientesDto = clientes.Select(c => _mapper.Map<ClienteDto>(c)).ToList();

            return Ok(clientesDto);
        }

        [HttpGet("{CostomerId:int}", Name = "GetOrdenesPorClienteID")]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetOrdenes(int CostomerId)
        {
            var Ordenes = _clienteRepo.GetOredenesPorClienteId(CostomerId);

            if (Ordenes == null || !Ordenes.Any())
            {
                return NotFound();
            }

            // Mapeamos la lista de clientes a lista de DTOs
            var ClienteDto = Ordenes.Select(c => _mapper.Map<OrdenDto>(c)).ToList();

            return Ok(ClienteDto);
        }
    }
}
