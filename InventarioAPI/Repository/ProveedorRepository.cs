using InventarioAPI.Data;
using InventarioAPI.Models;
using InventarioAPI.Repository.IRepository;

namespace InventarioAPI.Repository
{
    public class ProveedorRepository : Repository<Proveedor>, IProveedorRepository
    {
        private readonly InventarioContext _db;
        public ProveedorRepository(InventarioContext db) : base(db)
        {
            _db = db;
        }

        public async Task<Proveedor> Update(Proveedor entity)
        {
            _db.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}