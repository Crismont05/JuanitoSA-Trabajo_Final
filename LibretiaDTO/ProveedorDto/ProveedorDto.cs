using System.ComponentModel.DataAnnotations;

namespace InventarioAPI.Models.ProveedorDto
{
    public class ProveedorDto
    {
        [Required]
        public int Id { get; set; }
       
        public string? Nombre { get; set; }
        
        public string? Apellido { get; set; }
       
        public string? Direccion { get; set; }
    }
}
