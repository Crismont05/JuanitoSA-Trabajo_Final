using AutoMapper;
using InventarioAPI.Models;
using InventarioAPI.Models.ProductoDto;
using InventarioAPI.Models.ProveedorDto;

namespace InventarioAPI
{
    public class MappingConfig : Profile
    {
        public MappingConfig() 
        {
            //Mapeo de productos, para facilitar la elaboración de los controladores.
            CreateMap<Producto, ProductoDto>().ReverseMap();
            CreateMap<Producto, UpdateProductoDto>().ReverseMap();
            CreateMap<Producto, CreateProductoDto>().ReverseMap();
            //Mapeo de proveedores, para facilitar la elaboración de los controladores.
            CreateMap<Proveedor, ProveedorDto>().ReverseMap();
            CreateMap<Proveedor, UpdateProveedorDto>().ReverseMap();
            CreateMap<Proveedor, CreateProveedorDto>().ReverseMap();
        }
    }
}
