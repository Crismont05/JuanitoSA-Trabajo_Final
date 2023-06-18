using System.ComponentModel.DataAnnotations;

namespace InventarioAPI.Models.ProveedorDto
{
    public class UpdateProveedorDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string? Nombre { get; set; }
        [Required]
        public string? Apellido { get; set; }
        [Required]
        public string? Direccion { get; set; }

        public char? Sexo { get; set; }
        [Required]
        public string? Telefono { get; set; }

        public string? Nacionalidad { get; set; }

        public DateTime Nacimiento { get; set; }

    }
}
