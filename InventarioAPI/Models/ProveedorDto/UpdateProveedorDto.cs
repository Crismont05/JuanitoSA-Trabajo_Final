using System.ComponentModel.DataAnnotations;

namespace InventarioAPI.Models.ProveedorDto
{
    public class UpdateProveedorDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string? Nombre { get; set; }
        [Required]
        [MaxLength (30)]    
        public string? Apellido { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }

    }
}
