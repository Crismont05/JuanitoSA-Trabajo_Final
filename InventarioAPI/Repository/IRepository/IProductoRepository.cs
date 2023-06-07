
using InventarioAPI.Models;

namespace InventarioAPI.Repository.IRepository
{
    public interface IProductoRepository : IRepository<Producto>
    {
        Task<Producto> Update(Producto entity);
    }
}
