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

    }
}
