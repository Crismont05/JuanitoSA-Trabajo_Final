using Microsoft.EntityFrameworkCore;
using InventarioAPI.Models;
namespace InventarioAPI.Data
{
    public class InventarioContext : DbContext
    {
        public InventarioContext(DbContextOptions<InventarioContext> options) : base(options) { }
        public DbSet<Producto> Productos { get; set; }

        public DbSet<Proveedor> Proveedores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Proveedor>().HasData(
                new Proveedor()
                {
                    Id = 1,
                    Nombre = "Juan",
                    Apellido = "Ramirez",
                    Direccion = "De la vuelta te embroco 2 cuadras a lago, Casa V2",
                    Sexo = 'm',
                    Telefono = "89273898",
                    Nacionalidad = "Cuba",
                    Nacimiento = new DateTime(1979, 09, 20)
                });
            modelBuilder.Entity<Producto>().HasData(
                new Producto()
                {
                    Id = 1,
                    Nombre = "PC gaming",
                    Existencia = 1,
                    Costo = 800.00m,
                    Precio = 1000.00m,
                    Id_Proveedor = 1
                });
        }
    }
}