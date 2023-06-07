using InventarioAPI.Models;

namespace InventarioAPI.Repository.IRepository
{
    public interface IProveedorRepository : IRepository<Proveedor>
    {
        Task<Proveedor> Update(Proveedor entity);
    }
}
