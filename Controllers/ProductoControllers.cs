using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaVideojuegos.DataAccess;
using TiendaVideojuegos.Model;

namespace TiendaVideojuegos.Controllers
{
    public class ProductoControllers
    {
        private readonly ProductoDAO productoDAO;

        public ProductoControllers(string connectionString)
        {
            productoDAO = new ProductoDAO(connectionString);
        }

        public bool AgregarNuevoProducto(Producto producto)
        {
            return productoDAO.AgregarProducto(producto);
        }
    }
}
