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

        [HttpGet("{id:int}", Name = "GetProveedor")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<ProveedorDto>> GetProveedor(int id)
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
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ProveedorDto>> AddProveedor([FromBody] CreateProveedorDto proveedorCreateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (await _proveedorRepo.Get(p => p.Nombre.ToLower() == proveedorCreateDto.Nombre.ToLower()) != null)
            {
                ModelState.AddModelError("NombreExiste", "¡El Proveedor con ese Nombre ya existe!");
                return BadRequest(ModelState);
            }

            if (proveedorCreateDto == null)
            {
                return BadRequest(proveedorCreateDto);
            }

            Proveedor modelo = _mapper.Map<Proveedor>(proveedorCreateDto);

            await _proveedorRepo.Add(modelo);

            return CreatedAtRoute("GetProveedor", new { id = modelo.Id }, modelo);
        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteProveedor(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var proveedor = await _proveedorRepo.Get(p => p.Id == id);

            if (proveedor == null)
            {
                return NotFound();
            }

            await _proveedorRepo.Remove(proveedor);

            return NoContent();
        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateProveedor(int id, [FromBody] UpdateProveedorDto proveedorUpdateDto)
        {
            if (proveedorUpdateDto == null || id != proveedorUpdateDto.Id)
            {
                return BadRequest();
            }

            Proveedor modelo = _mapper.Map<Proveedor>(proveedorUpdateDto);

            _proveedorRepo.Update(modelo);

            return NoContent();
        }

        [HttpPatch("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePartialStudent(int id, JsonPatchDocument<UpdateProveedorDto> patchDto)
        {
            if (patchDto == null || id == 0)
            {
                return BadRequest();
            }

            var proveeedor = await _proveedorRepo.Get(p => p.Id == id, tracked: false);

            UpdateProveedorDto proveedorUpdateDto = _mapper.Map<UpdateProveedorDto>(proveeedor);
        
            if (proveeedor == null) return BadRequest();

            patchDto.ApplyTo(proveedorUpdateDto, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Proveedor modelo = _mapper.Map<Proveedor>(proveedorUpdateDto);
          
            _proveedorRepo.Update(modelo);

            return NoContent();
        }
    }
}
