using InventarioAPI.Data;
using InventarioAPI.Models;
using InventarioAPI.Repository;
using InventarioAPI.Repository.IRepository;

namespace InventarioAPI.Repository
{
    public class ProductoRepository : Repository<Producto>, IProductoRepository
    {
        private readonly InventarioContext _db;
        public ProductoRepository(InventarioContext db) : base(db)
        { 
            _db = db;
        }

        public async Task<Producto> Update(Producto entity)
        {
            _db.Productos.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
