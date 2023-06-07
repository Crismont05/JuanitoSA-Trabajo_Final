using System.ComponentModel.DataAnnotations;

namespace InventarioAPI.Models.ProductoDto
{
    public class UpdateProductoDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string? Nombre { get; set; }

        public int Existencia { get; set; }

        [Required]
        public decimal Costo { get; set; }
        [Required]
        public decimal Precio { get; set; }
        public int Id_Proveedor { get; set; }
    }
}
