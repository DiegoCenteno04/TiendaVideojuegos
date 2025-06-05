using TiendaVideojuegos.DataAccess;
using TiendaVideojuegos.Model;

namespace TiendaVideojuegos.Controllers
{
    public class ProveedorControllers
    {
        private readonly ProveedorDAO proveedorDAO;

        public ProveedorControllers(string connectionString)
        {
            proveedorDAO = new ProveedorDAO(connectionString);
        }

        public bool AgregarNuevoProveedor(Proveedor proveedor)
        {
            return proveedorDAO.AgregarProveedor(proveedor);
        }


    }
}
