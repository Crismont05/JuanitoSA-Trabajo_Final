using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace InventarioAPI.Models
{
    public class Proveedor
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
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
