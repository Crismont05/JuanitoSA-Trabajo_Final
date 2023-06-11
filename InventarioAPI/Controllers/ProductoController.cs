using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InventarioAPI.Data;
using InventarioAPI.Models;
using InventarioAPI.Repository.IRepository;
using InventarioAPI.Models.ProveedorDto;
using InventarioAPI.Models.ProductoDto;

namespace InventarioAPI.Controllers
{

    [Route("api/[Controller]")]
    [ApiController]
    public class ProductoController : ControllerBase    
    {

        private readonly ILogger<ProductoController> _logger;
        private readonly IProductoRepository _productoRepo;
        private readonly IMapper _mapper;

        public ProductoController(ILogger<ProductoController> logger, IProductoRepository productoRepo, IMapper mapper)
        {
            _logger = logger;
            _productoRepo = productoRepo;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<ProductoDto>>> GetProductos()
        {
            _logger.LogInformation("Obtienes una lista de los productos");
            var productolist = await _productoRepo.GetAll();
            return Ok(_mapper.Map<IEnumerable<ProductoDto>>(productolist));
        }

        [HttpGet("{id:int}", Name = "GetProducto")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<ProductoDto>> GetProducto(int id)
        {
            if (id == 0)
            {
                _logger.LogError($"Error al tratar de traer el producto con ID {id}");
                return BadRequest();
            }
            var producto = await _productoRepo.Get(p => p.Id == id);

            if (producto == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<ProductoDto>(producto));
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ProductoDto>> AddProducto([FromBody] CreateProductoDto productoCreateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (await _productoRepo.Get(p => p.Nombre.ToLower() == productoCreateDto.Nombre.ToLower()) != null)
            {
                ModelState.AddModelError("NombreExiste", "¡Un Producto con ese Nombre ya existe!");
                return BadRequest(ModelState);
            }

            if (productoCreateDto == null)
            {
                return BadRequest(productoCreateDto);
            }

            Producto modelo = _mapper.Map<Producto>(productoCreateDto);

            await _productoRepo.Add(modelo);

            return CreatedAtRoute("GetProducto", new { id = modelo.Id}, modelo);
        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteProducto(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var producto = await _productoRepo.Get(p => p.Id == id);

            if (producto == null)
            {
                return NotFound();
            }

            await _productoRepo.Remove(producto);

            return NoContent();
        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateProducto(int id, [FromBody] UpdateProductoDto productoUpdateDto)
        {
            if (productoUpdateDto == null || id != productoUpdateDto.Id)
            {
                return BadRequest();
            }

            Producto modelo = _mapper.Map<Producto>(productoUpdateDto);

            _productoRepo.Update(modelo);

            return NoContent();
        }

        [HttpPatch("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePartialProducto(int id, JsonPatchDocument<UpdateProductoDto> patchDto)
        {
            if (patchDto == null || id == 0)
            {
                return BadRequest();
            }

            var producto = await _productoRepo.Get(p => p.Id == id, tracked: false);

            UpdateProductoDto productoUpdateDto = _mapper.Map<UpdateProductoDto>(producto);

            if (producto == null) return BadRequest();

            patchDto.ApplyTo(productoUpdateDto, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Producto modelo = _mapper.Map<Producto>(productoUpdateDto);

            _productoRepo.Update(modelo);

            return NoContent();
        }

    }
}
