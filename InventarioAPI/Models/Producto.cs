using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventarioAPI.Models
{
    public class Producto
    {

        //La clase producto tiene la relación de una a muchos Proveedores
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string? Nombre { get; set; }

        public int Existencia { get; set; }
        [Required]
        public decimal Costo { get; set; }
        [Required]
        public decimal Precio { get; set; }

        public int Id_Proveedor { get; set; }
        [ForeignKey("Id_Proveedor")]
        public Proveedor Proveedor { get; set; }

    }
}
