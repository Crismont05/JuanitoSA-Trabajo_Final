using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InventarioAPI.Data;
using InventarioAPI.Models;
using InventarioAPI.Repository.IRepository;
using InventarioAPI.Models.ProveedorDto;

namespace InventarioAPI.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class ProveedorController : ControllerBase
    {
        private readonly ILogger<ProveedorController> _logger;
        private readonly IProveedorRepository _proveedorRepo;
        private readonly IMapper _mapper;

        public ProveedorController(ILogger<ProveedorController> logger, IProveedorRepository proveedorRepo, IMapper mapper)
        {
            _logger = logger;
            _proveedorRepo = proveedorRepo;
            _mapper = mapper;
        }

        
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)] 
        public async Task<ActionResult<IEnumerable<ProveedorDto>>> GetProveedores()
        {
            _logger.LogInformation("Obtienes una lista de los proveedores");
            var proveedoreslist = await _proveedorRepo.GetAll();
            return Ok(_mapper.Map<IEnumerable<ProveedorDto>>(proveedoreslist));
        }

        [HttpGet("{id:int}", Name = "GetProveedores")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<ProveedorDto>> GetProveedores(int id)
        {
           if (id == 0)
           {
                _logger.LogError($"Error al tratar de traer al proveedor con ID {id}");
                return BadRequest();    
           }
            var proveedor = await _proveedorRepo.Get(p => p.Id == id);

            if (proveedor == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<ProveedorDto>(proveedor));
        }
    }
}
