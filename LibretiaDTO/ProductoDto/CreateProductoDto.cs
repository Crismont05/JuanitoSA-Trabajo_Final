using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioAPI.Models.ProductoDto
{
    public class CreateProductoDto
    {
        [MaxLength(30)]
        [Required]
        public string? Nombre { get; set; }

        public int Existencia { get; set; }

        [Required]
        public decimal Costo { get; set; }

        [Required]
        public decimal Precio { get; set; }

        
        public int Id_Proveedor { get; set; }
    }
}